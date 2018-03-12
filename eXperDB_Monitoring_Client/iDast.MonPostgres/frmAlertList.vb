﻿Public Class frmAlertList

    Private _clsQuery As clsQuerys  ' Main Thread용
    Private _intInstanceID As Integer = -1
    Private _strCollectDt As String = ""
    Private _intAlertLevel As Integer = -1


    Private _SvrpList As List(Of GroupInfo.ServerInfo)
    ''' <summary>
    ''' Group List Items 안에 서버 리스트가 있음. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property SvrpList As List(Of GroupInfo.ServerInfo)
        Get
            Return _SvrpList
        End Get
    End Property

    Private _cbCheckAll As New eXperDB.BaseControls.CheckBox()

    Public Sub New(ByVal GrpLst As List(Of GroupInfo.ServerInfo), ByVal clsAgentInfo As structAgent, ByVal AgentCn As eXperDB.ODBC.DXODBC, ByVal InstanceID As Integer, ByVal intAlertLevel As Integer, ByVal strCollectDt As String)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        'Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or _
        '                    ControlStyles.UserPaint Or _
        '                    ControlStyles.DoubleBuffer, True)
        UseResizeFont = False
        _SvrpList = GrpLst
        _intInstanceID = InstanceID
        _strCollectDt = strCollectDt
        _intAlertLevel = intAlertLevel
        _clsQuery = New clsQuerys(AgentCn)
    End Sub
    ''' <summary>
    ''' 화면 초기화 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmAlertList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitForm()

        If _intInstanceID > 0 Then
            Dim comboSource As New Dictionary(Of String, String)()
            Dim index As Integer = 0
            For Each tmpSvr As GroupInfo.ServerInfo In _SvrpList
                If tmpSvr.InstanceID = _intInstanceID Then
                    cmbServer.SelectedIndex = index + 1
                End If
                index += 1
            Next
        End If

        If _intAlertLevel = 200 Then
            cmbLevel.SelectedIndex = 2
        ElseIf _intAlertLevel = 300 Then
            cmbLevel.SelectedIndex = 1
        End If

        If Not _strCollectDt.Equals("") Then
            dtpEd.Value = _strCollectDt
            dtpSt.Value = dtpEd.Value.AddMinutes(-5)
        End If

        Me.Invoke(New MethodInvoker(Sub()
                                        btnQuery.PerformClick()
                                    End Sub))

        'Temporary solution
        Me.dgvAlertList.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Gulim", 8.3)
        Me.dgvAlertList.DefaultCellStyle.Font = New System.Drawing.Font("Gulim", 8.3)

    End Sub

    Private Sub InitForm()


        Dim strHeader As String = Common.ClsConfigure.fn_rtnComponentDescription(p_ShowName.GetType.GetMember(p_ShowName.ToString)(0))
        'lblTitle.Text = String.Format("{0} : {1} / IP : {2} / START : {3}", strHeader, _ServerInfo.HostNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"))
        FormMovePanel1.Text += " [ " + String.Format("Alert List") + " ]"

        lblServer.Text = p_clsMsgData.fn_GetData("F033")
        lblLevel.Text = p_clsMsgData.fn_GetData("F247")
        lblCheck.Text = p_clsMsgData.fn_GetData("F262")
        lblDuration.Text = p_clsMsgData.fn_GetData("F254")
        btnQuery.Text = p_clsMsgData.fn_GetData("F151")
        btnCheck.Text = p_clsMsgData.fn_GetData("F262")
        btnConfig.Text = p_clsMsgData.fn_GetData("F264")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        grpAlertList.Text = p_clsMsgData.fn_GetData("F255")
        ' Talble Information
        grpAlert.Text = p_clsMsgData.fn_GetData("F255")
        dgvAlertList.AutoGenerateColumns = False
        'coldgvAlertSel.HeaderText = p_clsMsgData.fn_GetData("F252")
        coldgvAlertHostName.HeaderText = p_clsMsgData.fn_GetData("F033")
        coldgvAlertTime.HeaderText = p_clsMsgData.fn_GetData("F257")
        coldgvAlertType.HeaderText = p_clsMsgData.fn_GetData("F258")
        coldgvAlertLevel.HeaderText = p_clsMsgData.fn_GetData("F247")
        coldgvAlertMessage.HeaderText = p_clsMsgData.fn_GetData("F259")
        coldgvAlertYN.HeaderText = p_clsMsgData.fn_GetData("F262")
        coldgvAlertComment.HeaderText = p_clsMsgData.fn_GetData("F260")
        coldgvAlertIP.HeaderText = p_clsMsgData.fn_GetData("F266")
        coldgvAlertDT.HeaderText = p_clsMsgData.fn_GetData("F261")

        btnExcel.Text = p_clsMsgData.fn_GetData("F142")

        Me.FormControlBox1.UseConfigBox = False
        Me.FormControlBox1.UseLockBox = False
        Me.FormControlBox1.UseCriticalBox = False
        Me.FormControlBox1.UseRotationBox = False
        Me.FormControlBox1.UsePowerBox = False

        ' fit button location
        Me.btnExcel.Location = New System.Drawing.Point(Me.grpAlertList.Width - Me.btnExcel.Width - Me.btnExcel.Margin.Right, Me.btnExcel.Margin.Top)

        ' Set default duration
        dtpSt.Value = DateTime.Now.AddHours(-1)

        ' Add Server list into combo
        Dim comboSource As New Dictionary(Of String, String)()

        comboSource.Add(0, "All")
        For Each tmpSvr As GroupInfo.ServerInfo In _SvrpList
            comboSource.Add(tmpSvr.InstanceID, tmpSvr.HostNm)
        Next

        cmbServer.DataSource = New BindingSource(comboSource, Nothing)
        cmbServer.DisplayMember = "Value"
        cmbServer.ValueMember = "Key"

        cmbLevel.SelectedIndex = 1
        cmbCheck.SelectedIndex = 0

        ' modCommon.FontChange(Me, p_Font)

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim fsd As New SaveFileDialog
        fsd.AddExtension = True
        fsd.DefaultExt = "*.xls"
        fsd.Filter = "Excel files (*.xls)|*.xls"
        If fsd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim strExcelFile As String = fsd.FileName

            Dim tmpDtSet As New DataSet

            tmpDtSet.Tables.Add(dgvAlertList.GetDataTable2("ALERT_LIST"))
            eXperDB.ODBC.DXOLEDB.SaveExcelData(strExcelFile, tmpDtSet, True, Nothing)

            If MsgBox(p_clsMsgData.fn_GetData("M013"), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start(strExcelFile)
            End If

        End If
    End Sub
    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        Dim dtTable As DataTable

        dgvAlertList.Rows.Clear()
        RemoveHandler _cbCheckAll.CheckedChanged, AddressOf dgvAlertListCheckBox_CheckedChanged

        dtTable = _clsQuery.SelectAlertSearch(dtpSt.Value, dtpEd.Value, cmbServer.SelectedValue, cmbLevel.SelectedIndex, cmbCheck.SelectedIndex, p_ShowName.ToString("d"))
        If dtTable IsNot Nothing Then
            For Each tmpRow As DataRow In dtTable.Rows
                Dim idxRow As Integer = dgvAlertList.Rows.Add()
                ' 데이터 비교를 위해서 반드시 Controls.iDastDataGridView의 fn_DataCellADD를 사용한다. => Check 같은것을 수행하기 위함. 
                dgvAlertList.Rows(idxRow).Tag = tmpRow.Item("INSTANCE_ID")
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertHostName.Index, tmpRow.Item("HOST_NAME"))
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertTime.Index, tmpRow.Item("COLLECT_TIME"))
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertType.Index, tmpRow.Item("HCHK_NAME"))
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertLevel.Index, IIf((tmpRow.Item("STATE") = 200), "Warning", "Critical"))
                Dim strValue As String = fn_GetValueCast(tmpRow.Item("HCHK_NAME"), tmpRow.Item("VALUE"))
                Dim strValueUnit As String = ""
                If tmpRow.Item("VALUE") <> 99999 Then
                    strValueUnit = tmpRow.Item("UNIT")
                End If
                Dim strShowValue As String = "{0} " + "{1}"
                strShowValue = String.Format(strShowValue, strValue, strValueUnit)
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertMessage.Index, strShowValue)
                'dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertYN.Index, IIf(IsDBNull(tmpRow.Item("CHECK_USER_ID")), "Unchecked", "Checked"))
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertYN.Index, tmpRow.Item("CHECK_USER_ID"))
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertComment.Index, tmpRow.Item("CHECK_COMMENT"))
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertIP.Index, tmpRow.Item("CHECK_IP"))
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertTime.Index, tmpRow.Item("COLLECT_TIME"))
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertRegDate.Index, tmpRow.Item("REG_DATE"))
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertHCHKREGREQ.Index, tmpRow.Item("HCHK_REG_SEQ"))
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertDT.Index, tmpRow.Item("CHECK_DT"))
            Next
        End If
    End Sub

    Private Sub dgvAlertList_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvAlertList.CellPainting
        If e.ColumnIndex = 0 AndAlso e.RowIndex = -1 Then
            e.PaintBackground(e.ClipBounds, False)
            Dim pt As New Point()
            pt = e.CellBounds.Location ' where you want the bitmap in the cell

            Dim nChkBoxWidth As Integer = 20
            Dim nChkBoxHeight As Integer = 20
            Dim offsetx As Integer = (e.CellBounds.Width - nChkBoxWidth) / 2
            Dim offsety As Integer = (e.CellBounds.Height - nChkBoxHeight) / 2

            pt.X += offsetx
            pt.Y += offsety

            _cbCheckAll.Location = pt
            _cbCheckAll.Size = New Size(nChkBoxWidth, nChkBoxHeight)
            'AddHandler _cbCheckAll.CheckedChanged, AddressOf dgvAlertListCheckBox_CheckedChanged
            'DirectCast(sender, BaseControls.DataGridView).Controls.Add(_cbCheckAll)
            AddHandler _cbCheckAll.Click, AddressOf dgvAlertListCheckBox_CheckedChanged
            dgvAlertList.Controls.Add(_cbCheckAll)

            e.Handled = True
        End If
        dgvAlertList.EndEdit()
    End Sub
    Private Sub dgvAlertListCheckBox_CheckedChanged(sender As Object, e As EventArgs)
        dgvAlertList.EndEdit()

        For Each row As DataGridViewRow In dgvAlertList.Rows
            Dim checkBox As DataGridViewCheckBoxCell = (TryCast(row.Cells(coldgvAlertSel.Index), DataGridViewCheckBoxCell))
            checkBox.ReadOnly = True
            'checkBox.Value = DirectCast(sender, BaseControls.CheckBox).Checked
            checkBox.Value = _cbCheckAll.Checked
            checkBox.ReadOnly = False
        Next
    End Sub


    Private Sub dgvAlertList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlertList.CellClick
        'Check to ensure that the row CheckBox is clicked.
        Dim checkBox As DataGridViewCheckBoxCell = Nothing
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            checkBox = (TryCast(dgvAlertList.Rows(e.RowIndex).Cells(coldgvAlertSel.Index), DataGridViewCheckBoxCell))
            If checkBox.Value = True Then
                checkBox.Value = False
            Else
                checkBox.Value = True
            End If
        End If

        'Loop to verify whether all row CheckBoxes are checked or not.
        Dim nChecked As Integer = IIf(checkBox.Value, 1, 0)

        For Each row As DataGridViewRow In dgvAlertList.Rows
            If row.Index = e.RowIndex Then Continue For
            If Convert.ToBoolean(row.Cells(coldgvAlertSel.Index).EditedFormattedValue) = True Then
                nChecked += 1
            End If
        Next
        _cbCheckAll.Checked = IIf(nChecked = dgvAlertList.Rows.Count, True, False)

        ' DirectCast(sender, BaseControls.CheckBox).Checked = isChecked
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim intPauseTime As Integer = 0
        Dim strCheckComment As String = ""
        Dim strCheckUser As String = ""
        Dim bReturn As Boolean = False

        Dim i As Integer = 0
        For Each row As DataGridViewRow In dgvAlertList.Rows
            Dim checkBox As DataGridViewCheckBoxCell = (TryCast(row.Cells(coldgvAlertSel.Index), DataGridViewCheckBoxCell))
            If checkBox.Value = True Then
                i += 1
                Exit For
            End If
        Next
        If i = 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M034"))
            Return
        End If

        If frmAlertCheck.ShowDialog = Windows.Forms.DialogResult.OK Then
            frmAlertCheck.rtnValue(intPauseTime, strCheckComment, strCheckUser)
        Else
            frmAlertCheck.Dispose()
            Return
        End If
        Try
            Dim COC As New Common.ClsObjectCtl
            Dim strLocIP As String = COC.GetLocalIP

            Dim PauseTime As Date = Now        ' Current date and time.
            PauseTime = PauseTime.AddSeconds(intPauseTime)

            For Each row As DataGridViewRow In dgvAlertList.Rows
                Dim checkBox As DataGridViewCheckBoxCell = (TryCast(row.Cells(coldgvAlertSel.Index), DataGridViewCheckBoxCell))
                If checkBox.Value = True Then
                    Dim instInstanceId As Integer = row.Tag
                    Dim strRegDate As String = row.Cells(coldgvAlertRegDate.Index).Value
                    Dim intHchkRegSeq As Integer = row.Cells(coldgvAlertHCHKREGREQ.Index).Value
                    Dim strHchkName As String = row.Cells(coldgvAlertType.Index).Value
                    If intPauseTime > 0 Then
                        bReturn = _clsQuery.UpdatePauseAlert(instInstanceId, strHchkName, PauseTime.ToString("yyyy-MM-dd HH:mm:ss"))
                        If bReturn = False Then
                            Exit For
                        End If
                    End If

                    bReturn = _clsQuery.UpdateCheckAlert(strRegDate,
                                               intHchkRegSeq,
                                               instInstanceId,
                                               strHchkName,
                                               strCheckUser,
                                               strCheckComment,
                                               strLocIP)
                    If bReturn = False Then
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            bReturn = False
        Finally
            frmAlertCheck.Dispose()
        End Try

        If bReturn = True Then
            MsgBox(p_clsMsgData.fn_GetData("M028"))
            Me.Invoke(New MethodInvoker(Sub()
                                            btnQuery.PerformClick()
                                        End Sub))
        Else
            MsgBox(p_clsMsgData.fn_GetData("M029"))
        End If

    End Sub

    Private Sub frmAlertList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        RemoveHandler _cbCheckAll.CheckedChanged, AddressOf dgvAlertListCheckBox_CheckedChanged
    End Sub


    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        Dim AlertConfig As New frmAlertConfig(_SvrpList)
        AlertConfig.ShowDialog()
    End Sub

    Private Sub dgvAlertList_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAlertList.CellMouseMove
        If e.RowIndex >= 0 Then
            dgvAlertList.Cursor = Cursors.Hand
            If dgvAlertList.Rows(e.RowIndex).Selected = False Then
                dgvAlertList.ClearSelection()
                dgvAlertList.Rows(e.RowIndex).Selected = True
            End If
            dgvAlertList.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 40, 70)
        End If
    End Sub

    Private Sub dgvAlertList_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlertList.CellMouseLeave
        If e.RowIndex >= 0 Then
            dgvAlertList.Cursor = Cursors.Arrow
            If dgvAlertList.Rows(e.RowIndex).Selected = True Then
                dgvAlertList.ClearSelection()
                dgvAlertList.Rows(e.RowIndex).Selected = False
            End If
            dgvAlertList.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = dgvAlertList.DefaultCellStyle.SelectionBackColor
        End If
    End Sub
End Class
