package experdb.mnt.task;

import java.math.BigDecimal;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.apache.commons.dbcp.PoolingDriver;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;

import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.ResourceInfo;
import experdb.mnt.db.dbcp.DBCPPoolManager;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class ActvCollect extends TaskApplication {

	private static final String RESOURCE_KEY_CURRENT_LOCK = "CURRENT_LOCK";
	private static final String RESOURCE_KEY_BACKEND_RSC = "BACKEND_RSC";
	private static final String RESOURCE_KEY_ACCESS = "ACCESS";
	
	private static final String RESOURCE_KEY_CPU_CLOCKS = "CPU_CLOCKS";	
	
	private String is_collect_ok = "Y";
	private String failed_collect_type = "";	
	
	public ActvCollect(String instanceId, String taskId) {
		super(instanceId, taskId);
	}

	@Override
	public void run() {
		
		long collectPeriod = (Integer)MonitoringInfoManager.getInstance().getInstanceMap(instanceId).get("collect_period_sec");
		
		long sleepTime;
		long startTime;
		long endTime;
		
		while (!MonitoringInfoManager.getInstance().isReLoad())
		{
			log.debug(System.currentTimeMillis());
			
			try {
				is_collect_ok = "Y";
				failed_collect_type = "";
				
				startTime =  System.currentTimeMillis();
				
				execute(); //수집 실행

				endTime =  System.currentTimeMillis();
				
				if((endTime - startTime) > (collectPeriod * 1000) )
				{
					//처리 시간이 수집주기보다 크면 바로처리
					continue;
				} else {
					sleepTime = (collectPeriod * 1000) - (endTime - startTime);
				}
			
				Thread.sleep(sleepTime);

			} catch (Exception e) {
				log.error("", e);
			}
		}
		
	}	
	
	private void execute() {
		SqlSessionFactory sqlSessionFactory = null;
		Connection connection = null;
		SqlSession sessionCollect = null;
		SqlSession sessionAgent  = null;
		
		try {
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			
			try {
				connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + instanceId);
				sessionCollect = sqlSessionFactory.openSession(connection);
			} catch (Exception e) {
				failed_collect_type = "0";
				is_collect_ok = "N";
				log.error("", e);
			}
				
			sessionAgent = sqlSessionFactory.openSession();
	
			
			List<HashMap<String, Object>> currentLockSel = new ArrayList<HashMap<String,Object>>(); // CURRENT_LOCK 정보 수집
			List<HashMap<String, Object>> backendRscSel = new ArrayList<HashMap<String,Object>>(); // BACKEND_RSC 정보 수집
			List<HashMap<String, Object>> accessSel = new ArrayList<HashMap<String,Object>>(); //Access 수집
			
			if(is_collect_ok.equals("Y"))
			{			
				//////////////////////////////////////////////////////////////////////////////////////////////////////////////
				// CPU_CLOCKS 구하기			
				if(ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_CPU_CLOCKS) == null)
				{
					HashMap<String, Object> tempCpuClocks = new HashMap<String, Object>();
					
					tempCpuClocks = sessionCollect.selectOne("app.BT_GET_CPU_CLOCKS_001");
					
					ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_CPU_CLOCKS, tempCpuClocks.get("get_cpu_clocks"));
				}
				//////////////////////////////////////////////////////////////////////////////////////////////////////////////
							
				
				
				//////////////////////////////////////////////////////////////////////////////////////////////////////////////
				// 이전값 확인
				List<HashMap<String, Object>> preList = new ArrayList<HashMap<String,Object>>();
				
	
				///////////////////////////////////////////////////////////////////////////////
				// BACKEND_RSC 이전값 확인
				if(ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_BACKEND_RSC) == null)
				{
					preList.clear();
					preList = sessionCollect.selectList("app.BT_BACKEND_RSC_001");
					
					HashMap<String, Object> tempCpu = new HashMap<String, Object>();
					for (HashMap<String, Object> map : preList) {
						tempCpu.put(String.valueOf(map.get("process_id")), map);
					}				
					
					ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_BACKEND_RSC, tempCpu);
				}
				///////////////////////////////////////////////////////////////////////////////			
				
				
				
				//////////////////////////////////////////////////////////////////////////////////////////////////////////////			
				//서버를 모니터링한다.
				
				try {
					// CURRENT_LOCK 정보 수집
					try {			
						currentLockSel = sessionCollect.selectList("app.BT_CURR_LOCK_001");
					} catch (Exception e) {
						failed_collect_type = "1";
						throw e;
					}			
					
					// BACKEND_RSC 정보 수집
					try {			 
					 	backendRscSel = sessionCollect.selectList("app.BT_BACKEND_RSC_001");
					} catch (Exception e) {
						failed_collect_type = "2";
						throw e;
					}				
					
				} catch (Exception e1) {
					is_collect_ok = "N";
					log.error("", e1);
				}
			}
				
			if(is_collect_ok.equals("Y"))
			{			
				//////////////////////////////////////////////////////////////////////////////////////////////////////////////
				// DB connection 정보
				List<HashMap<String, Object>> dbConnList = new ArrayList<HashMap<String,Object>>();
				dbConnList = sessionCollect.selectList("app.PG_STAT_DATABASE_INFO_001");
	
				// pool 네임정보를 가져온다.
				PoolingDriver driver = (PoolingDriver) DriverManager.getDriver("jdbc:apache:commons:dbcp:");
				String[] poolNames = driver.getPoolNames();
				
				log.debug("이전 pool ==>> " + Arrays.toString(poolNames));
				
		
				for (HashMap<String, Object> mapDB : dbConnList) {
					String poolName = instanceId + "." + taskId + "." + mapDB.get("db_name");
					
					//풀 생성여부를 확인하여 없으면 생성한다.
					boolean isPool = false;
					for (int i = 0; i < poolNames.length; i++){
						if(poolNames[i].equals(poolName)){
							isPool = true;
							break;
						}
					}				
					
					if(!isPool)
					{
						//pool이 없는경우 폴을 생성한다.
						HashMap instanceMap = MonitoringInfoManager.getInstanceMap(instanceId);
						
						DBCPPoolManager.setupDriver(
								"org.postgresql.Driver",
								"jdbc:postgresql://"+ instanceMap.get("server_ip") +":"+ instanceMap.get("service_port") +"/"+ mapDB.get("db_name"),
								(String)instanceMap.get("conn_user_id"),
								(String)instanceMap.get("conn_user_pwd"),
								poolName,
								10
						);					
					}
					/////////////////////////////////////////////////////////
					
					
					Connection connDB = null;
					SqlSession sessDB = null;
					
					try {
						//DB 컨넥션을 가져온다.
						connDB = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + poolName);
						sessDB = sqlSessionFactory.openSession(connDB);
	
						///////////////////////////////////////////////////////////////////////////////
						// ACCESS 이전값 확인
						if(ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_ACCESS + "_" + mapDB.get("db_name")) == null)
						{
							HashMap<String, Object> inputParam = new HashMap<String, Object>();
							inputParam.put("db_name", 					mapDB.get("db_name"));
							inputParam.put("datid", 					mapDB.get("datid"));
	
							
							HashMap<String, Object> selectMap = sessDB.selectOne("app.BT_ACCESS_INFO_001", inputParam);
	
							ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_ACCESS + "_" + mapDB.get("db_name"), selectMap);
							
	//						log.fatal("최초 이전값 : " + selectMap);
						}
						///////////////////////////////////////////////////////////////////////////////				
						
						///////////////////////////////////////////////////////////////////////////////
						// ACCESS 정보수집
						HashMap<String, Object> inputAccessParam = new HashMap<String, Object>();
						inputAccessParam = (HashMap<String, Object>) ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_ACCESS + "_" + mapDB.get("db_name"));
						
						Map<String, Object> accessTempSel = new HashMap<String, Object>();
						try {
							inputAccessParam.put("datid", 					mapDB.get("datid"));
							
							accessTempSel = sessDB.selectOne("app.BT_ACCESS_INFO_001", inputAccessParam);
						} catch (Exception e) {
							failed_collect_type = "3";
							throw e;
						}						
						accessSel.add((HashMap<String, Object>) accessTempSel);
						
	//					log.fatal("이전값 : " + inputAccessParam);
	//					log.fatal("조회값 : " + accessTempSel);
						
						ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_ACCESS + "_" + mapDB.get("db_name"), accessTempSel);
						/////////////////////////////////////////////////////////////////////////////
				
					} catch (Exception e1) {
						is_collect_ok = "N";
						log.error("", e1);
						break;
					} finally {
						sessDB.close();
					}
				}
			}			
			
			
			
			try {
				Map<String, Object> parameAgent = new HashMap<String, Object>();

				Map<String, Object> preValue = new HashMap<String, Object>();
				
				///////////////////////////////////////////////////////////////////////////////
				// TB_ACTV_COLLECT_INFO 정보 등록
				Map<String, Object> parameActv = new HashMap<String, Object>();
				parameActv.put("instance_id", Integer.valueOf(instanceId));
				parameActv.put("is_collect_ok", is_collect_ok);				
				parameActv.put("failed_collect_type", failed_collect_type);
				
				sessionAgent.insert("app.TB_ACTV_COLLECT_INFO_I001", parameActv);
				
				if(is_collect_ok.equals("N"))
				{
					sessionAgent.commit();
					return;
				}
				///////////////////////////////////////////////////////////////////////////////
				
				///////////////////////////////////////////////////////////////////////////////
				// CURRENT_LOCK 정보 등록
				for (HashMap<String, Object> map : currentLockSel) {
					sessionAgent.insert("app.TB_CURRENT_LOCK_I001", map);
				}
				///////////////////////////////////////////////////////////////////////////////				
				
				///////////////////////////////////////////////////////////////////////////////
				// BACKEND_RSC 정보 등록
				preValue.clear();
				preValue = (Map<String, Object>) ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_BACKEND_RSC);
				
				Map<String, Object> preSaveBackendRsc = new HashMap<String, Object>();
				for (HashMap<String, Object> map : backendRscSel) {
					HashMap<String, Object> tempMap = new HashMap<String, Object>();
					tempMap = (HashMap<String, Object>) preValue.get(String.valueOf(map.get("process_id")));

					//이전값이 없는경우(새로생성된 프로세스)
					if(tempMap == null) {
						preSaveBackendRsc.put(String.valueOf(map.get("process_id")), map);
						
						continue;
					}
					
					double current_proc_utime = Double.valueOf(map.get("agg_proc_utime").toString()) - Double.valueOf(tempMap.get("agg_proc_utime").toString());
					double current_proc_stime = Double.valueOf(map.get("agg_proc_stime").toString()) - Double.valueOf(tempMap.get("agg_proc_stime").toString());
					double current_proc_read_kb = Double.valueOf(map.get("agg_proc_read_kb").toString()) - Double.valueOf(tempMap.get("agg_proc_read_kb").toString());
					double current_proc_write_kb = Double.valueOf(map.get("agg_proc_write_kb").toString()) - Double.valueOf(tempMap.get("agg_proc_write_kb").toString());
					
					double current_sec_from_epoch = Double.valueOf(map.get("sec_from_epoch").toString()) - Double.valueOf(tempMap.get("sec_from_epoch").toString());
					
					double proc_cpu_util = 0;
					
					double cpu_clock = Double.valueOf(ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_CPU_CLOCKS).toString());

			
					if(cpu_clock != 0)
					{
						proc_cpu_util = Math.round((((current_proc_utime + current_proc_stime) / (cpu_clock * current_sec_from_epoch)) * 100 ) * Math.pow(10, 2)) / Math.pow(10, 2);
						
						
						//if(proc_cpu_util > 100)		proc_cpu_util = 100.0;
					}

					map.put("current_proc_utime", current_proc_utime);
					map.put("current_proc_stime", current_proc_stime);
					map.put("current_proc_read_kb", current_proc_read_kb);
					map.put("current_proc_write_kb", current_proc_write_kb);
					
					map.put("proc_cpu_util", proc_cpu_util);
					
					sessionAgent.insert("app.TB_BACKEND_RSC_I001", map);

					preSaveBackendRsc.put(String.valueOf(map.get("process_id")), map);
				}
				
				ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_BACKEND_RSC, preSaveBackendRsc);
				///////////////////////////////////////////////////////////////////////////////				
				
				///////////////////////////////////////////////////////////////////////////////
				// ACCESS 정보 등록
				for (HashMap<String, Object> map : accessSel) {
					sessionAgent.insert("app.TB_ACCESS_INFO_I001", map);
				}
				///////////////////////////////////////////////////////////////////////////////			
				
				//Commit
				sessionAgent.commit();
			} catch (Exception e) {
				sessionAgent.rollback();
				log.error("", e);
			}
			
		} catch (Exception e) {
			log.error("", e);
		} finally {
			if(sessionAgent != null)	sessionAgent.close();
			if(sessionCollect != null)	sessionCollect.close();
		}
	}

}
