﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrendReport
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Edges1 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrendReport))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tlpSnapShot = New eXperDB.BaseControls.TableLayoutPanel()
        Me.tlpCluster = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbClusters = New eXperDB.BaseControls.ComboBox()
        Me.lblCluster = New eXperDB.BaseControls.Label()
        Me.tlpSnapshot1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.cmbUnit = New eXperDB.BaseControls.ComboBox()
        Me.lblUnit = New eXperDB.BaseControls.Label()
        Me.cmbTopNSQL = New eXperDB.BaseControls.ComboBox()
        Me.lblTopNSQL = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel4 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.dtpEd = New eXperDB.BaseControls.DateTimePicker()
        Me.dtpSt = New eXperDB.BaseControls.DateTimePicker()
        Me.lblReportTo = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel3 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.rbLastWeek = New eXperDB.BaseControls.RadioButton()
        Me.rbLastMonth = New eXperDB.BaseControls.RadioButton()
        Me.rbToday = New eXperDB.BaseControls.RadioButton()
        Me.rbTomorrow = New eXperDB.BaseControls.RadioButton()
        Me.grpReportItemList = New eXperDB.BaseControls.GroupBox()
        Me.tlpSvrChk = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvReportItemList = New eXperDB.BaseControls.DataGridView()
        Me.colDgvReportItemListCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvReportItemListCodeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDeleteItem = New eXperDB.BaseControls.Button()
        Me.btnAddItem = New eXperDB.BaseControls.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSnapshotIcon = New System.Windows.Forms.Label()
        Me.lblReportItemConfig = New System.Windows.Forms.Label()
        Me.dgvCollectItemList = New eXperDB.BaseControls.DataGridView()
        Me.colDgvCollectItemListCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvCollectItemListCodeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSnapFrom = New eXperDB.BaseControls.Label()
        Me.lblReportFrom = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel7 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnGenerate = New eXperDB.BaseControls.Button()
        Me.ttChart = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.bgmanual = New System.ComponentModel.BackgroundWorker()
        Me.btnHistory = New eXperDB.BaseControls.Button()
        Me.tlpSnapShot.SuspendLayout()
        Me.tlpCluster.SuspendLayout()
        Me.tlpSnapshot1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.grpReportItemList.SuspendLayout()
        Me.tlpSvrChk.SuspendLayout()
        CType(Me.dgvReportItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvCollectItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpSnapShot
        '
        Me.tlpSnapShot.ColumnCount = 2
        Me.tlpSnapShot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSnapShot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSnapShot.Controls.Add(Me.tlpCluster, 0, 0)
        Me.tlpSnapShot.Controls.Add(Me.tlpSnapshot1, 0, 1)
        Me.tlpSnapShot.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpSnapShot.Location = New System.Drawing.Point(3, 47)
        Me.tlpSnapShot.Name = "tlpSnapShot"
        Me.tlpSnapShot.RowCount = 5
        Me.tlpSnapShot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpSnapShot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpSnapShot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpSnapShot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 239.0!))
        Me.tlpSnapShot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.tlpSnapShot.Size = New System.Drawing.Size(516, 540)
        Me.tlpSnapShot.TabIndex = 16
        '
        'tlpCluster
        '
        Me.tlpCluster.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tlpCluster.ColumnCount = 6
        Me.tlpSnapShot.SetColumnSpan(Me.tlpCluster, 2)
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpCluster.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpCluster.Controls.Add(Me.cmbClusters, 2, 1)
        Me.tlpCluster.Controls.Add(Me.lblCluster, 1, 1)
        Me.tlpCluster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpCluster.Location = New System.Drawing.Point(3, 3)
        Me.tlpCluster.Name = "tlpCluster"
        Me.tlpCluster.RowCount = 3
        Me.tlpCluster.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpCluster.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpCluster.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpCluster.Size = New System.Drawing.Size(510, 64)
        Me.tlpCluster.TabIndex = 27
        '
        'cmbClusters
        '
        Me.cmbClusters.BackColor = System.Drawing.SystemColors.Window
        Me.cmbClusters.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbClusters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClusters.FixedWidth = False
        Me.cmbClusters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbClusters.FormattingEnabled = True
        Me.cmbClusters.Location = New System.Drawing.Point(74, 27)
        Me.cmbClusters.Name = "cmbClusters"
        Me.cmbClusters.Necessary = False
        Me.cmbClusters.Size = New System.Drawing.Size(134, 20)
        Me.cmbClusters.StatusTip = ""
        Me.cmbClusters.TabIndex = 34
        Me.cmbClusters.ValueText = ""
        '
        'lblCluster
        '
        Me.lblCluster.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCluster.FixedWidth = False
        Me.lblCluster.LineSpacing = 0.0!
        Me.lblCluster.Location = New System.Drawing.Point(4, 27)
        Me.lblCluster.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblCluster.Name = "lblCluster"
        Me.lblCluster.Size = New System.Drawing.Size(64, 21)
        Me.lblCluster.TabIndex = 33
        Me.lblCluster.Text = "Cluster"
        Me.lblCluster.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tlpSnapshot1
        '
        Me.tlpSnapshot1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tlpSnapshot1.ColumnCount = 8
        Me.tlpSnapShot.SetColumnSpan(Me.tlpSnapshot1, 2)
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSnapshot1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSnapshot1.Controls.Add(Me.TableLayoutPanel5, 2, 4)
        Me.tlpSnapshot1.Controls.Add(Me.lblTopNSQL, 1, 4)
        Me.tlpSnapshot1.Controls.Add(Me.TableLayoutPanel4, 2, 2)
        Me.tlpSnapshot1.Controls.Add(Me.TableLayoutPanel3, 2, 1)
        Me.tlpSnapshot1.Controls.Add(Me.grpReportItemList, 2, 5)
        Me.tlpSnapshot1.Controls.Add(Me.lblSnapFrom, 2, 7)
        Me.tlpSnapshot1.Controls.Add(Me.lblReportFrom, 1, 2)
        Me.tlpSnapshot1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSnapshot1.Location = New System.Drawing.Point(3, 73)
        Me.tlpSnapshot1.Name = "tlpSnapshot1"
        Me.tlpSnapshot1.RowCount = 8
        Me.tlpSnapShot.SetRowSpan(Me.tlpSnapshot1, 3)
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSnapshot1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSnapshot1.Size = New System.Drawing.Size(510, 403)
        Me.tlpSnapshot1.TabIndex = 25
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 5
        Me.tlpSnapshot1.SetColumnSpan(Me.TableLayoutPanel5, 4)
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.cmbUnit, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lblUnit, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.cmbTopNSQL, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(74, 103)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(354, 34)
        Me.TableLayoutPanel5.TabIndex = 44
        '
        'cmbUnit
        '
        Me.cmbUnit.BackColor = System.Drawing.SystemColors.Window
        Me.cmbUnit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit.FixedWidth = False
        Me.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Items.AddRange(New Object() {"Hour", "Day"})
        Me.cmbUnit.Location = New System.Drawing.Point(213, 11)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Necessary = False
        Me.cmbUnit.Size = New System.Drawing.Size(124, 20)
        Me.cmbUnit.StatusTip = ""
        Me.cmbUnit.TabIndex = 46
        Me.cmbUnit.ValueText = ""
        '
        'lblUnit
        '
        Me.lblUnit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUnit.FixedHeight = False
        Me.lblUnit.FixedWidth = False
        Me.lblUnit.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblUnit.ForeColor = System.Drawing.Color.White
        Me.lblUnit.LineSpacing = 0.0!
        Me.lblUnit.Location = New System.Drawing.Point(133, 12)
        Me.lblUnit.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(74, 20)
        Me.lblUnit.TabIndex = 45
        Me.lblUnit.Text = "F973"
        Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTopNSQL
        '
        Me.cmbTopNSQL.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTopNSQL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbTopNSQL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTopNSQL.FixedWidth = False
        Me.cmbTopNSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTopNSQL.FormattingEnabled = True
        Me.cmbTopNSQL.Items.AddRange(New Object() {"20", "30", "40", "50", "100"})
        Me.cmbTopNSQL.Location = New System.Drawing.Point(3, 11)
        Me.cmbTopNSQL.Name = "cmbTopNSQL"
        Me.cmbTopNSQL.Necessary = False
        Me.cmbTopNSQL.Size = New System.Drawing.Size(124, 20)
        Me.cmbTopNSQL.StatusTip = ""
        Me.cmbTopNSQL.TabIndex = 44
        Me.cmbTopNSQL.ValueText = ""
        '
        'lblTopNSQL
        '
        Me.lblTopNSQL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTopNSQL.FixedHeight = False
        Me.lblTopNSQL.FixedWidth = False
        Me.lblTopNSQL.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblTopNSQL.ForeColor = System.Drawing.Color.White
        Me.lblTopNSQL.LineSpacing = 0.0!
        Me.lblTopNSQL.Location = New System.Drawing.Point(4, 118)
        Me.lblTopNSQL.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblTopNSQL.Name = "lblTopNSQL"
        Me.lblTopNSQL.Size = New System.Drawing.Size(64, 20)
        Me.lblTopNSQL.TabIndex = 42
        Me.lblTopNSQL.Text = "TopN SQL"
        Me.lblTopNSQL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.tlpSnapshot1.SetColumnSpan(Me.TableLayoutPanel4, 4)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.dtpEd, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.dtpSt, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblReportTo, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(74, 53)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(354, 34)
        Me.TableLayoutPanel4.TabIndex = 41
        '
        'dtpEd
        '
        Me.dtpEd.BackColor = System.Drawing.SystemColors.Window
        Me.dtpEd.CustomFormat = "yyyy-MM-dd HH"
        Me.dtpEd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpEd.FixedWidth = False
        Me.dtpEd.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.dtpEd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEd.Location = New System.Drawing.Point(163, 12)
        Me.dtpEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.dtpEd.Name = "dtpEd"
        Me.dtpEd.Necessary = False
        Me.dtpEd.Size = New System.Drawing.Size(124, 22)
        Me.dtpEd.StatusTip = ""
        Me.dtpEd.TabIndex = 41
        '
        'dtpSt
        '
        Me.dtpSt.BackColor = System.Drawing.SystemColors.Window
        Me.dtpSt.CustomFormat = "yyyy-MM-dd HH"
        Me.dtpSt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpSt.FixedWidth = False
        Me.dtpSt.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.dtpSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSt.Location = New System.Drawing.Point(3, 12)
        Me.dtpSt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.dtpSt.Name = "dtpSt"
        Me.dtpSt.Necessary = False
        Me.dtpSt.Size = New System.Drawing.Size(124, 22)
        Me.dtpSt.StatusTip = ""
        Me.dtpSt.TabIndex = 40
        '
        'lblReportTo
        '
        Me.lblReportTo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblReportTo.FixedHeight = False
        Me.lblReportTo.FixedWidth = False
        Me.lblReportTo.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblReportTo.ForeColor = System.Drawing.Color.White
        Me.lblReportTo.LineSpacing = 0.0!
        Me.lblReportTo.Location = New System.Drawing.Point(133, 12)
        Me.lblReportTo.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblReportTo.Name = "lblReportTo"
        Me.lblReportTo.Size = New System.Drawing.Size(24, 20)
        Me.lblReportTo.TabIndex = 9
        Me.lblReportTo.Text = "~"
        Me.lblReportTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.tlpSnapshot1.SetColumnSpan(Me.TableLayoutPanel3, 5)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.rbLastWeek, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.rbLastMonth, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.rbToday, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.rbTomorrow, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(74, 13)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(384, 34)
        Me.TableLayoutPanel3.TabIndex = 28
        '
        'rbLastWeek
        '
        Me.rbLastWeek.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbLastWeek.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.rbLastWeek.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rbLastWeek.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbLastWeek.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.rbLastWeek.ForeColor = System.Drawing.Color.White
        Me.rbLastWeek.LineColor = System.Drawing.Color.Transparent
        Me.rbLastWeek.Location = New System.Drawing.Point(195, 3)
        Me.rbLastWeek.Name = "rbLastWeek"
        Me.rbLastWeek.Radius = 8
        Me.rbLastWeek.Size = New System.Drawing.Size(90, 28)
        Me.rbLastWeek.TabIndex = 43
        Me.rbLastWeek.Text = "F971"
        Me.rbLastWeek.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.rbLastWeek.UseRound = True
        Me.rbLastWeek.UseVisualStyleBackColor = False
        Me.rbLastWeek.Warning = False
        Me.rbLastWeek.WarningColor = System.Drawing.Color.Red
        '
        'rbLastMonth
        '
        Me.rbLastMonth.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbLastMonth.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.rbLastMonth.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rbLastMonth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbLastMonth.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.rbLastMonth.ForeColor = System.Drawing.Color.White
        Me.rbLastMonth.LineColor = System.Drawing.Color.Transparent
        Me.rbLastMonth.Location = New System.Drawing.Point(291, 3)
        Me.rbLastMonth.Name = "rbLastMonth"
        Me.rbLastMonth.Radius = 8
        Me.rbLastMonth.Size = New System.Drawing.Size(90, 28)
        Me.rbLastMonth.TabIndex = 42
        Me.rbLastMonth.Text = "F972"
        Me.rbLastMonth.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.rbLastMonth.UseRound = True
        Me.rbLastMonth.UseVisualStyleBackColor = False
        Me.rbLastMonth.Warning = False
        Me.rbLastMonth.WarningColor = System.Drawing.Color.Red
        '
        'rbToday
        '
        Me.rbToday.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbToday.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.rbToday.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rbToday.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbToday.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.rbToday.ForeColor = System.Drawing.Color.White
        Me.rbToday.LineColor = System.Drawing.Color.Transparent
        Me.rbToday.Location = New System.Drawing.Point(3, 3)
        Me.rbToday.Name = "rbToday"
        Me.rbToday.Radius = 8
        Me.rbToday.Size = New System.Drawing.Size(90, 28)
        Me.rbToday.TabIndex = 41
        Me.rbToday.Text = "F969"
        Me.rbToday.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.rbToday.UseRound = True
        Me.rbToday.UseVisualStyleBackColor = False
        Me.rbToday.Warning = False
        Me.rbToday.WarningColor = System.Drawing.Color.Red
        '
        'rbTomorrow
        '
        Me.rbTomorrow.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbTomorrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.rbTomorrow.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rbTomorrow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbTomorrow.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.rbTomorrow.ForeColor = System.Drawing.Color.White
        Me.rbTomorrow.LineColor = System.Drawing.Color.Transparent
        Me.rbTomorrow.Location = New System.Drawing.Point(99, 3)
        Me.rbTomorrow.Name = "rbTomorrow"
        Me.rbTomorrow.Radius = 8
        Me.rbTomorrow.Size = New System.Drawing.Size(90, 28)
        Me.rbTomorrow.TabIndex = 40
        Me.rbTomorrow.Text = "F970"
        Me.rbTomorrow.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.rbTomorrow.UseRound = True
        Me.rbTomorrow.UseVisualStyleBackColor = False
        Me.rbTomorrow.Warning = False
        Me.rbTomorrow.WarningColor = System.Drawing.Color.Red
        '
        'grpReportItemList
        '
        Me.grpReportItemList.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpReportItemList.AlignString = System.Drawing.StringAlignment.Near
        Me.tlpSnapshot1.SetColumnSpan(Me.grpReportItemList, 5)
        Me.grpReportItemList.Controls.Add(Me.tlpSvrChk)
        Me.grpReportItemList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpReportItemList.EdgeRound = Edges1
        Me.grpReportItemList.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.grpReportItemList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpReportItemList.Icon = CType(resources.GetObject("grpReportItemList.Icon"), System.Drawing.Icon)
        Me.grpReportItemList.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.grpReportItemList.LineWidth = 1
        Me.grpReportItemList.Location = New System.Drawing.Point(71, 140)
        Me.grpReportItemList.Margin = New System.Windows.Forms.Padding(0)
        Me.grpReportItemList.Name = "grpReportItemList"
        Me.grpReportItemList.Padding = New System.Windows.Forms.Padding(0)
        Me.tlpSnapshot1.SetRowSpan(Me.grpReportItemList, 3)
        Me.grpReportItemList.Size = New System.Drawing.Size(390, 263)
        Me.grpReportItemList.TabIndex = 38
        Me.grpReportItemList.TabStop = False
        Me.grpReportItemList.TitleFont = New System.Drawing.Font("Gulim", 9.0!)
        Me.grpReportItemList.TitleGraColor = System.Drawing.Color.CornflowerBlue
        Me.grpReportItemList.UseGraColor = False
        Me.grpReportItemList.UseRound = True
        Me.grpReportItemList.UseTitle = False
        '
        'tlpSvrChk
        '
        Me.tlpSvrChk.BackColor = System.Drawing.Color.Transparent
        Me.tlpSvrChk.ColumnCount = 3
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSvrChk.Controls.Add(Me.dgvReportItemList, 2, 1)
        Me.tlpSvrChk.Controls.Add(Me.btnDeleteItem, 1, 3)
        Me.tlpSvrChk.Controls.Add(Me.btnAddItem, 1, 2)
        Me.tlpSvrChk.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.tlpSvrChk.Controls.Add(Me.dgvCollectItemList, 0, 1)
        Me.tlpSvrChk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSvrChk.Location = New System.Drawing.Point(0, 14)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 5
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(390, 249)
        Me.tlpSvrChk.TabIndex = 30
        '
        'dgvReportItemList
        '
        Me.dgvReportItemList.AllowUserToAddRows = False
        Me.dgvReportItemList.AllowUserToDeleteRows = False
        Me.dgvReportItemList.AllowUserToOrderColumns = True
        Me.dgvReportItemList.AllowUserToResizeColumns = False
        Me.dgvReportItemList.AllowUserToResizeRows = False
        Me.dgvReportItemList.BackgroundColor = System.Drawing.Color.Black
        Me.dgvReportItemList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReportItemList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 7.760073!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReportItemList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReportItemList.ColumnHeadersHeight = 30
        Me.dgvReportItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvReportItemList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDgvReportItemListCode, Me.colDgvReportItemListCodeName})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Gulim", 7.760073!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReportItemList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvReportItemList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReportItemList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvReportItemList.EnableHeadersVisualStyles = False
        Me.dgvReportItemList.Font = New System.Drawing.Font("Gulim", 7.760073!)
        Me.dgvReportItemList.GridColor = System.Drawing.Color.Black
        Me.dgvReportItemList.Location = New System.Drawing.Point(220, 34)
        Me.dgvReportItemList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvReportItemList.Name = "dgvReportItemList"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Gulim", 9.2!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReportItemList.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvReportItemList.RowHeadersVisible = False
        Me.tlpSvrChk.SetRowSpan(Me.dgvReportItemList, 4)
        Me.dgvReportItemList.RowTemplate.Height = 23
        Me.dgvReportItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReportItemList.Size = New System.Drawing.Size(167, 211)
        Me.dgvReportItemList.TabIndex = 43
        Me.dgvReportItemList.TagValueMatchColor = System.Drawing.Color.Black
        Me.dgvReportItemList.UseTagValueMatchColor = False
        '
        'colDgvReportItemListCode
        '
        Me.colDgvReportItemListCode.DataPropertyName = "CODE"
        Me.colDgvReportItemListCode.HeaderText = "Code"
        Me.colDgvReportItemListCode.Name = "colDgvReportItemListCode"
        Me.colDgvReportItemListCode.ReadOnly = True
        Me.colDgvReportItemListCode.Visible = False
        Me.colDgvReportItemListCode.Width = 70
        '
        'colDgvReportItemListCodeName
        '
        Me.colDgvReportItemListCodeName.DataPropertyName = "CODE_NAME"
        DataGridViewCellStyle2.Format = "yyyy-MM-dd HH:mm:ss"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colDgvReportItemListCodeName.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDgvReportItemListCodeName.HeaderText = "F968"
        Me.colDgvReportItemListCodeName.Name = "colDgvReportItemListCodeName"
        Me.colDgvReportItemListCodeName.ReadOnly = True
        Me.colDgvReportItemListCodeName.Width = 145
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.BackColor = System.Drawing.Color.LightGray
        Me.btnDeleteItem.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDeleteItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDeleteItem.FixedHeight = False
        Me.btnDeleteItem.FixedWidth = False
        Me.btnDeleteItem.Font = New System.Drawing.Font("Webdings", 12.0!)
        Me.btnDeleteItem.ForeColor = System.Drawing.Color.White
        Me.btnDeleteItem.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDeleteItem.Image = CType(resources.GetObject("btnDeleteItem.Image"), System.Drawing.Image)
        Me.btnDeleteItem.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnDeleteItem.Location = New System.Drawing.Point(178, 142)
        Me.btnDeleteItem.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnDeleteItem.Radius = 5
        Me.btnDeleteItem.Size = New System.Drawing.Size(33, 29)
        Me.btnDeleteItem.TabIndex = 41
        Me.btnDeleteItem.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDeleteItem.UseVisualStyleBackColor = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.LightGray
        Me.btnAddItem.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAddItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddItem.FixedHeight = False
        Me.btnAddItem.FixedWidth = False
        Me.btnAddItem.Font = New System.Drawing.Font("Webdings", 12.0!)
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAddItem.Image = CType(resources.GetObject("btnAddItem.Image"), System.Drawing.Image)
        Me.btnAddItem.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnAddItem.Location = New System.Drawing.Point(178, 107)
        Me.btnAddItem.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.btnAddItem.Radius = 5
        Me.btnAddItem.Size = New System.Drawing.Size(33, 29)
        Me.btnAddItem.TabIndex = 42
        Me.btnAddItem.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.tlpSvrChk.SetColumnSpan(Me.TableLayoutPanel1, 3)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblSnapshotIcon, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblReportItemConfig, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(384, 24)
        Me.TableLayoutPanel1.TabIndex = 39
        '
        'lblSnapshotIcon
        '
        Me.lblSnapshotIcon.AutoSize = True
        Me.lblSnapshotIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSnapshotIcon.Image = CType(resources.GetObject("lblSnapshotIcon.Image"), System.Drawing.Image)
        Me.lblSnapshotIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSnapshotIcon.Location = New System.Drawing.Point(3, 0)
        Me.lblSnapshotIcon.Name = "lblSnapshotIcon"
        Me.lblSnapshotIcon.Size = New System.Drawing.Size(34, 24)
        Me.lblSnapshotIcon.TabIndex = 2
        Me.lblSnapshotIcon.Text = "      "
        '
        'lblReportItemConfig
        '
        Me.lblReportItemConfig.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblReportItemConfig, 2)
        Me.lblReportItemConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReportItemConfig.ForeColor = System.Drawing.Color.White
        Me.lblReportItemConfig.Location = New System.Drawing.Point(43, 0)
        Me.lblReportItemConfig.Name = "lblReportItemConfig"
        Me.lblReportItemConfig.Size = New System.Drawing.Size(338, 24)
        Me.lblReportItemConfig.TabIndex = 3
        Me.lblReportItemConfig.Text = "F966"
        Me.lblReportItemConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvCollectItemList
        '
        Me.dgvCollectItemList.AllowUserToAddRows = False
        Me.dgvCollectItemList.AllowUserToDeleteRows = False
        Me.dgvCollectItemList.AllowUserToOrderColumns = True
        Me.dgvCollectItemList.AllowUserToResizeColumns = False
        Me.dgvCollectItemList.AllowUserToResizeRows = False
        Me.dgvCollectItemList.BackgroundColor = System.Drawing.Color.Black
        Me.dgvCollectItemList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCollectItemList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Gulim", 7.760073!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCollectItemList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCollectItemList.ColumnHeadersHeight = 30
        Me.dgvCollectItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCollectItemList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDgvCollectItemListCode, Me.colDgvCollectItemListCodeName})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Gulim", 7.760073!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCollectItemList.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvCollectItemList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCollectItemList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvCollectItemList.EnableHeadersVisualStyles = False
        Me.dgvCollectItemList.Font = New System.Drawing.Font("Gulim", 7.760073!)
        Me.dgvCollectItemList.GridColor = System.Drawing.Color.Black
        Me.dgvCollectItemList.Location = New System.Drawing.Point(3, 34)
        Me.dgvCollectItemList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvCollectItemList.Name = "dgvCollectItemList"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Gulim", 9.2!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCollectItemList.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCollectItemList.RowHeadersVisible = False
        Me.tlpSvrChk.SetRowSpan(Me.dgvCollectItemList, 4)
        Me.dgvCollectItemList.RowTemplate.Height = 23
        Me.dgvCollectItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCollectItemList.Size = New System.Drawing.Size(166, 211)
        Me.dgvCollectItemList.TabIndex = 38
        Me.dgvCollectItemList.TagValueMatchColor = System.Drawing.Color.Black
        Me.dgvCollectItemList.UseTagValueMatchColor = False
        '
        'colDgvCollectItemListCode
        '
        Me.colDgvCollectItemListCode.DataPropertyName = "CODE"
        Me.colDgvCollectItemListCode.HeaderText = "Code"
        Me.colDgvCollectItemListCode.Name = "colDgvCollectItemListCode"
        Me.colDgvCollectItemListCode.ReadOnly = True
        Me.colDgvCollectItemListCode.Visible = False
        Me.colDgvCollectItemListCode.Width = 70
        '
        'colDgvCollectItemListCodeName
        '
        Me.colDgvCollectItemListCodeName.DataPropertyName = "CODE_NAME"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.NullValue = Nothing
        Me.colDgvCollectItemListCodeName.DefaultCellStyle = DataGridViewCellStyle6
        Me.colDgvCollectItemListCodeName.HeaderText = "F967"
        Me.colDgvCollectItemListCodeName.Name = "colDgvCollectItemListCodeName"
        Me.colDgvCollectItemListCodeName.ReadOnly = True
        Me.colDgvCollectItemListCodeName.Width = 145
        '
        'lblSnapFrom
        '
        Me.lblSnapFrom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSnapFrom.FixedHeight = False
        Me.lblSnapFrom.FixedWidth = False
        Me.lblSnapFrom.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSnapFrom.ForeColor = System.Drawing.Color.White
        Me.lblSnapFrom.LineSpacing = 0.0!
        Me.lblSnapFrom.Location = New System.Drawing.Point(464, 400)
        Me.lblSnapFrom.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblSnapFrom.Name = "lblSnapFrom"
        Me.lblSnapFrom.Size = New System.Drawing.Size(43, 1)
        Me.lblSnapFrom.TabIndex = 28
        Me.lblSnapFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSnapFrom.Visible = False
        '
        'lblReportFrom
        '
        Me.lblReportFrom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblReportFrom.FixedHeight = False
        Me.lblReportFrom.FixedWidth = False
        Me.lblReportFrom.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblReportFrom.ForeColor = System.Drawing.Color.White
        Me.lblReportFrom.LineSpacing = 0.0!
        Me.lblReportFrom.Location = New System.Drawing.Point(4, 68)
        Me.lblReportFrom.Margin = New System.Windows.Forms.Padding(3, 0, 3, 2)
        Me.lblReportFrom.Name = "lblReportFrom"
        Me.lblReportFrom.Size = New System.Drawing.Size(64, 20)
        Me.lblReportFrom.TabIndex = 0
        Me.lblReportFrom.Text = "F254"
        Me.lblReportFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.btnGenerate, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel7.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 526)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(516, 46)
        Me.TableLayoutPanel7.TabIndex = 35
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnGenerate.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnGenerate.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnGenerate.FixedHeight = False
        Me.btnGenerate.FixedWidth = False
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnGenerate.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnGenerate.Location = New System.Drawing.Point(215, 4)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Radius = 10
        Me.btnGenerate.Size = New System.Drawing.Size(90, 38)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "F014"
        Me.btnGenerate.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnGenerate.UseRound = True
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusLabel.ForeColor = System.Drawing.Color.White
        Me.StatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusLabel.Location = New System.Drawing.Point(43, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(430, 44)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Text"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnHistory, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.StatusLabel, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(516, 44)
        Me.TableLayoutPanel2.TabIndex = 15
        '
        'bgmanual
        '
        Me.bgmanual.WorkerReportsProgress = True
        Me.bgmanual.WorkerSupportsCancellation = True
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.Silver
        Me.btnHistory.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHistory.FixedHeight = False
        Me.btnHistory.FixedWidth = False
        Me.btnHistory.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.btnHistory.ForeColor = System.Drawing.Color.Yellow
        Me.btnHistory.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnHistory.Image = CType(resources.GetObject("btnHistory.Image"), System.Drawing.Image)
        Me.btnHistory.LineColor = System.Drawing.Color.LightGray
        Me.btnHistory.Location = New System.Drawing.Point(479, 5)
        Me.btnHistory.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Radius = 5
        Me.btnHistory.Size = New System.Drawing.Size(34, 34)
        Me.btnHistory.TabIndex = 3
        Me.btnHistory.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'frmTrendReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(522, 575)
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.Controls.Add(Me.tlpSnapShot)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTrendReport"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TrendReport"
        Me.tlpSnapShot.ResumeLayout(False)
        Me.tlpCluster.ResumeLayout(False)
        Me.tlpSnapshot1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.grpReportItemList.ResumeLayout(False)
        Me.tlpSvrChk.ResumeLayout(False)
        CType(Me.dgvReportItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dgvCollectItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpSnapShot As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents tlpCluster As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbClusters As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblCluster As eXperDB.BaseControls.Label
    Friend WithEvents tlpSnapshot1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblReportFrom As eXperDB.BaseControls.Label
    Friend WithEvents TableLayoutPanel7 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnGenerate As eXperDB.BaseControls.Button
    Friend WithEvents ttChart As System.Windows.Forms.ToolTip
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSnapFrom As eXperDB.BaseControls.Label
    Friend WithEvents bgmanual As System.ComponentModel.BackgroundWorker
    Friend WithEvents TableLayoutPanel3 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents rbTomorrow As eXperDB.BaseControls.RadioButton
    Friend WithEvents rbToday As eXperDB.BaseControls.RadioButton
    Friend WithEvents rbLastWeek As eXperDB.BaseControls.RadioButton
    Friend WithEvents rbLastMonth As eXperDB.BaseControls.RadioButton
    Friend WithEvents grpReportItemList As eXperDB.BaseControls.GroupBox
    Friend WithEvents tlpSvrChk As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvReportItemList As eXperDB.BaseControls.DataGridView
    Friend WithEvents btnDeleteItem As eXperDB.BaseControls.Button
    Friend WithEvents btnAddItem As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSnapshotIcon As System.Windows.Forms.Label
    Friend WithEvents lblReportItemConfig As System.Windows.Forms.Label
    Friend WithEvents dgvCollectItemList As eXperDB.BaseControls.DataGridView
    Friend WithEvents TableLayoutPanel4 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents dtpEd As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents dtpSt As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents lblReportTo As eXperDB.BaseControls.Label
    Friend WithEvents colDgvCollectItemListCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvCollectItemListCodeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvReportItemListCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvReportItemListCodeName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel5 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents cmbTopNSQL As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblTopNSQL As eXperDB.BaseControls.Label
    Friend WithEvents cmbUnit As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblUnit As eXperDB.BaseControls.Label
    Friend WithEvents btnHistory As eXperDB.BaseControls.Button
End Class
