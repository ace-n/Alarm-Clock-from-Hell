<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txtMyPass
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bW1 = New System.ComponentModel.BackgroundWorker()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.txtPass3 = New System.Windows.Forms.TextBox()
        Me.txtPass1 = New System.Windows.Forms.TextBox()
        Me.lblPass1 = New System.Windows.Forms.Label()
        Me.lblPass2 = New System.Windows.Forms.Label()
        Me.lblPass3 = New System.Windows.Forms.Label()
        Me.txtMyPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bW1
        '
        Me.bW1.WorkerReportsProgress = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.lblTime.ForeColor = System.Drawing.Color.Red
        Me.lblTime.Location = New System.Drawing.Point(78, 74)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(351, 76)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "Alarm time"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(389, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 41)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(78, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(382, 76)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(567, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 76)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Password 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(567, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(382, 76)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password 3"
        '
        'txtPass2
        '
        Me.txtPass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass2.Location = New System.Drawing.Point(580, 147)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.Size = New System.Drawing.Size(350, 41)
        Me.txtPass2.TabIndex = 8
        '
        'txtPass3
        '
        Me.txtPass3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass3.Location = New System.Drawing.Point(580, 337)
        Me.txtPass3.Name = "txtPass3"
        Me.txtPass3.Size = New System.Drawing.Size(350, 41)
        Me.txtPass3.TabIndex = 9
        '
        'txtPass1
        '
        Me.txtPass1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass1.Location = New System.Drawing.Point(91, 337)
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.Size = New System.Drawing.Size(338, 41)
        Me.txtPass1.TabIndex = 10
        '
        'lblPass1
        '
        Me.lblPass1.AutoSize = True
        Me.lblPass1.Location = New System.Drawing.Point(91, 385)
        Me.lblPass1.Name = "lblPass1"
        Me.lblPass1.Size = New System.Drawing.Size(83, 17)
        Me.lblPass1.TabIndex = 11
        Me.lblPass1.Text = "Password is"
        '
        'lblPass2
        '
        Me.lblPass2.AutoSize = True
        Me.lblPass2.Location = New System.Drawing.Point(577, 191)
        Me.lblPass2.Name = "lblPass2"
        Me.lblPass2.Size = New System.Drawing.Size(83, 17)
        Me.lblPass2.TabIndex = 12
        Me.lblPass2.Text = "Password is"
        '
        'lblPass3
        '
        Me.lblPass3.AutoSize = True
        Me.lblPass3.Location = New System.Drawing.Point(577, 385)
        Me.lblPass3.Name = "lblPass3"
        Me.lblPass3.Size = New System.Drawing.Size(83, 17)
        Me.lblPass3.TabIndex = 13
        Me.lblPass3.Text = "Password is"
        '
        'txtMyPassword
        '
        Me.txtMyPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMyPassword.Location = New System.Drawing.Point(252, 510)
        Me.txtMyPassword.Name = "txtMyPassword"
        Me.txtMyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMyPassword.Size = New System.Drawing.Size(513, 41)
        Me.txtMyPassword.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(239, 431)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(550, 76)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Master Password"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(194, 147)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(100, 22)
        Me.txtTime.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Time (military)"
        '
        'txtMyPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 585)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtMyPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPass3)
        Me.Controls.Add(Me.lblPass2)
        Me.Controls.Add(Me.lblPass1)
        Me.Controls.Add(Me.txtPass1)
        Me.Controls.Add(Me.txtPass3)
        Me.Controls.Add(Me.txtPass2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "txtMyPass"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Form1"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bW1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPass2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPass3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPass1 As System.Windows.Forms.TextBox
    Friend WithEvents lblPass1 As System.Windows.Forms.Label
    Friend WithEvents lblPass2 As System.Windows.Forms.Label
    Friend WithEvents lblPass3 As System.Windows.Forms.Label
    Friend WithEvents txtMyPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
