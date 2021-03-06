﻿Public Class frmCritical

    Private Sub frmCritical_Click(sender As Object, e As EventArgs) Handles Me.Click, Panel2.Click, Panel3.Click, Label1.Click, Label2.Click
        Dim intPauseTime As Integer = -1
        Dim tmpFrm As Form = Nothing
        For Each tmpFrm In My.Application.OpenForms
            If tmpFrm.GetType.Equals(GetType(frmMonMain)) Then
                DirectCast(tmpFrm, frmMonMain).ShowCritical = False
                Exit For
            End If
        Next

        frmCriticalCheck.TopMost = True
        If frmCriticalCheck.ShowDialog = Windows.Forms.DialogResult.OK Then
            frmCriticalCheck.rtnValue(intPauseTime)
        Else
            DirectCast(tmpFrm, frmMonMain).ShowCritical = True
            frmCriticalCheck.Dispose()
            Return
        End If
        If intPauseTime > 0 Then
            Dim PauseTime As Date
            PauseTime = Now        ' Current date and time.
            PauseTime = PauseTime.AddSeconds(intPauseTime)
            'PauseTime = PauseTime.AddSeconds(30)
            DirectCast(tmpFrm, frmMonMain).UseCriticalTime = True
            DirectCast(tmpFrm, frmMonMain).CriticalTime = PauseTime
        Else
            DirectCast(tmpFrm, frmMonMain).UseCriticalTime = False
        End If

        Me.Close()

    End Sub

    Private Sub frmCritical_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        sndPlayer.Stop()
        sndPlayer.Dispose()

        'Dim strMsg As String = p_clsMsgData.fn_GetData("M012")
        'MsgBox(strMsg)

    End Sub

    Private Sub frmWarning_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ConfigIni As New Common.IniFile(p_AppConfigIni)

        MyBase.SetStyle(ControlStyles.ResizeRedraw, True)
        MyBase.SetStyle(ControlStyles.UserPaint, True)

        MyBase.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        MyBase.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        MyBase.SetStyle(DoubleBuffered, True)





        Timer1.Interval = 200
        Timer1.Enabled = True

        Dim Snd As String = ""
        'Snd = ConfigIni.ReadValue("General", "SIREN", "Siren.wav")
        Snd = p_UserENv.CFG_SirenName
        If Snd.Trim <> "" Then
            Dim sndFile As String = System.IO.Path.Combine(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Sounds"), Snd)
            If System.IO.File.Exists(sndFile) Then
                sndPlayer.SoundLocation = sndFile
                sndPlayer.PlayLooping()
            End If
        End If
    End Sub
    Dim sndPlayer As New System.Media.SoundPlayer



    Private _FontSize As Single = 50

    'Protected Overrides Sub OnPaint(e As PaintEventArgs)
    '    MyBase.OnPaint(e)
    '    e.Graphics.DrawString("Warning", New Font(MyBase.Font.FontFamily, _FontSize), New SolidBrush(Color.FromArgb(255, Color.Red)), New Point(0, MyBase.Height / 2))

    'End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If _FontSize >= 90 Then
            _FontSize = 50
        Else
            _FontSize += 2
        End If


        'If DateDiff(DateInterval.Second, _StTime, Now) > Elapse Then
        '    Me.Close()
        'Else
        'Me.Invalidate()
        Label1.Text = "C R I T I C A L"
        Label1.Font = New Font(Label1.Font.FontFamily, _FontSize)
        Label2.Font = New Font(Label2.Font.FontFamily, _FontSize - 25)
        'End If
    End Sub


    Public Sub New(ByVal SvrLst As String)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        Label2.Text = SvrLst


        modCommon.FontChange(Me, p_Font)

    End Sub

    Private Sub frmWarning_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Label2.Height = Panel1.Height / 2
    End Sub



End Class