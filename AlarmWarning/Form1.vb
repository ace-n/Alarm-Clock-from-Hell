Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class txtMyPass

    Declare Function Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer) As Integer

    Public Msg As String = "Set alarm!"
    Public BlockCloses As Boolean = False ' If TRUE, window-closing requests are blocked
    Public HasBeenCloseMsgd As Boolean = False ' Allows the program to detect shutdown requests (because it will be requested to close for the first time)

    ' Password generator stuff
    Public Rand As New Random
    Public RandomStr As String = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ1234567890" ' Password search space

    ' The passwords themselves
    Public SizeInt As Integer = 10
    Public Password1 As String = RandomString(Rand.Next(SizeInt, SizeInt + 5))
    Public Password2 As String = RandomString(Rand.Next(SizeInt, SizeInt + 5))
    Public Password3 As String = RandomString(Rand.Next(SizeInt, SizeInt + 5))

    ' Path of sound
    Public SoundPath As String = "C:\Users\Ace\My Code\VB.NET\alarm_tone.wav"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Generate random passwords
        lblPass1.Text = "Password is " & Password1
        lblPass2.Text = "Password is " & Password2
        lblPass3.Text = "Password is " & Password3

        ' Generate striped image
        Dim PerLineOffset As Integer = 1
        Dim LineSize As Integer = 200

        Dim ScrSz As Size = Screen.PrimaryScreen.WorkingArea.Size ' Screen size
        Dim BMP As New Bitmap(ScrSz.Width, ScrSz.Height)
        Dim BMPGr As Graphics = Graphics.FromImage(BMP)
        BMPGr.FillRectangle(Brushes.Yellow, New Rectangle(0, 0, BMP.Width, BMP.Height))

        For y = 0 To BMP.Height - 1
            For x = ((PerLineOffset * y) Mod LineSize * 2) - LineSize * 2 To BMP.Width - 1 Step LineSize * 2

                ' Skip/clamp X's that are out of range
                If x + LineSize < 0 Then ' Skip (because the entire proposed line is out of the picture)
                    Continue For
                ElseIf x < 0 Then ' Clamp (because x+LineSize is still in range, so a line will be drawn)
                    BMPGr.DrawLine(Pens.Black, New Point(0, y), New Point(x + LineSize, y))
                Else ' No clamping required
                    BMPGr.DrawLine(Pens.Black, New Point(x, y), New Point(x + LineSize, y))
                End If

            Next
        Next

        ' Update background
        'Me.BackgroundImage = BMP

        ' Set window position/size
        Me.Location = New Point
        Me.Size = ScrSz


    End Sub

    ' Message interceptor - prevents window-close messages from doing anything
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        ' Shoot the message down, if appropriate
        If BlockCloses Then
            If m.Msg = 16 Then ' Close window

                ' If first request, start closing process
                If Not HasBeenCloseMsgd Then
                    Me.Visible = True
                    bW1.RunWorkerAsync()
                    HasBeenCloseMsgd = True
                End If

                Exit Sub
            ElseIf m.Msg = 3 Then ' Move
                Exit Sub
            End If
        End If

        ' Pass the message on
        MyBase.WndProc(m)
        Return

    End Sub

#Region "Commented out stuff"
    'Private Sub bW1_DoWork() Handles bW1.DoWork

    '    Sleep(100)

    '    ' Keep track of seconds
    '    For i = 30 To -1 Step -1
    '        bW1.ReportProgress(i)
    '        Sleep(1000)
    '    Next

    'End Sub

    'Private Sub bW1_Receiver(ByVal sender As System.Object, ByVal e As ProgressChangedEventArgs) Handles bW1.ProgressChanged

    '    ' Set label
    '    lblTime.Text = "This window will close in " & e.ProgressPercentage & " seconds."

    '    ' Close window if appropriate
    '    If e.ProgressPercentage = -1 Then
    '        BlockCloses = False
    '        Sleep(100)
    '        Me.Close()
    '    End If

    'End Sub
#End Region

    ' Password generator
    Public Function RandomString(ByVal Length As Integer)

        Dim Str As String = ""
        While Str.Length < Length
            Str &= RandomStr.Chars(Rand.Next(0, RandomStr.Length))
        End While

        Return Str

    End Function

    ' === Textbox freezing (password boxes are frozen when correct password is typed) ===
    Private Sub txtPass1_TextChanged() Handles txtPass1.TextChanged

        ' Pass-match check
        If txtPass1.Text = Password1 Then
            txtPass1.Enabled = False
        End If

        ' Close check
        CheckClose()

    End Sub
    Private Sub txtPass2_TextChanged() Handles txtPass2.TextChanged

        ' Pass-match check
        If txtPass2.Text = Password2 Then
            txtPass2.Enabled = False
        End If

        ' Close check
        CheckClose()

    End Sub
    Private Sub txtPass3_TextChanged() Handles txtPass3.TextChanged

        ' Pass-match check
        If txtPass3.Text = Password3 Then
            txtPass3.Enabled = False
        End If

        ' Close check
        CheckClose()

    End Sub

    ' Close-check procedure
    Private Sub CheckClose()

        If Not (txtPass1.Enabled OrElse txtPass2.Enabled OrElse txtPass3.Enabled OrElse txtMyPassword.Enabled) Then
            My.Computer.Audio.Stop()
            Sleep(1000)
            Process.GetCurrentProcess.Kill()
        End If

    End Sub

    ' Hashing function
    Private Function SimpleHash(ByVal Str As String) As String

        ' Modulo factor
        Dim HashFactor As Integer = 16983

        ' Compute hash
        Dim Hash As Long = 0
        For i = 0 To Str.Length - 1
            Hash = (Hash + RandomStr.IndexOf(Str.Chars(i)) ^ (i + 1)) Mod HashFactor
        Next

        ' Return hash
        Return Hash & "/" & Str.Length

    End Function

    Private Sub myPassChanged() Handles txtMyPassword.TextChanged

        If SimpleHash(txtMyPassword.Text) = "1663/10" Then

            ' Disable
            txtMyPassword.Enabled = False

            ' Check close
            CheckClose()

        End If

    End Sub

    Private Sub Button1_Click() Handles Button1.Click

        ' Find trigger date
        Dim Time_H As Integer = -1
        Dim Time_M As Integer = -1
        If Not (Regex.IsMatch(txtTime.Text, "\d{1,2}:\d{1,2}") AndAlso _
            Integer.TryParse(Regex.Match(txtTime.Text, "\d{1,2}").Value, Time_H) AndAlso _
            Integer.TryParse(Regex.Match(txtTime.Text, "(?<=(:))\d{1,2}").Value, Time_M)) Then
            MsgBox("Invalid time. Time must between 0 and 23:59 hours (military time). [1]")
            Exit Sub
        End If

        ' == Input validation ==
        If Time_H < 0 OrElse Time_H > 23 OrElse Time_M < 0 OrElse Time_M > 59 Then
            MsgBox("Invalid time. Time must between 0 and 23:59 hours (military time). [2]")
            Exit Sub
        End If

        ' == Wait until then ==
        Dim Now As DateTime = My.Computer.Clock.LocalTime
        Dim TargetTime As New DateTime(Now.Year, Now.Month, Now.Day, Time_H, Time_M, 0)

        ' Day offset
        If Now.Hour * 60 + Now.Minute > Time_H * 60 + Time_M Then
            TargetTime.AddDays(1)
        End If

        ' Get difference
        Dim SleepTime As TimeSpan = TargetTime - Now

        ' Sleep
        Console.WriteLine(SleepTime.TotalSeconds)
        Sleep(Math.Max((SleepTime.TotalSeconds - 1), 0) * 1000)

        ' F*ck sh*t up
        BlockCloses = True
        Sleep(1000)
        My.Computer.Audio.Play(SoundPath, AudioPlayMode.BackgroundLoop)

    End Sub



End Class
