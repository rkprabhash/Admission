<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Btn_Login = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UsernameTxt = New System.Windows.Forms.TextBox()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.Register_Btn = New System.Windows.Forms.Button()
        Me.Close_Btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Login
        '
        Me.Btn_Login.Location = New System.Drawing.Point(200, 173)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Login.TabIndex = 0
        Me.Btn_Login.Text = "Login"
        Me.Btn_Login.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'UsernameTxt
        '
        Me.UsernameTxt.Location = New System.Drawing.Point(276, 62)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.Size = New System.Drawing.Size(149, 20)
        Me.UsernameTxt.TabIndex = 3
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Location = New System.Drawing.Point(275, 103)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.PasswordTxt.Size = New System.Drawing.Size(149, 20)
        Me.PasswordTxt.TabIndex = 4
        '
        'Register_Btn
        '
        Me.Register_Btn.Location = New System.Drawing.Point(301, 173)
        Me.Register_Btn.Name = "Register_Btn"
        Me.Register_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Register_Btn.TabIndex = 5
        Me.Register_Btn.Text = "Register"
        Me.Register_Btn.UseVisualStyleBackColor = True
        '
        'Close_Btn
        '
        Me.Close_Btn.Location = New System.Drawing.Point(97, 173)
        Me.Close_Btn.Name = "Close_Btn"
        Me.Close_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Close_Btn.TabIndex = 6
        Me.Close_Btn.Text = "Close"
        Me.Close_Btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.ClientSize = New System.Drawing.Size(452, 261)
        Me.Controls.Add(Me.Close_Btn)
        Me.Controls.Add(Me.Register_Btn)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.UsernameTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Login)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Admission_2018"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UsernameTxt As TextBox
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents Register_Btn As Button
    Friend WithEvents Close_Btn As Button
End Class
