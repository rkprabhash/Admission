Public Class Form1

    Dim userName As String
    Dim passWord As String

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        If userName = "admin" And passWord = "password" Then
            Dim MainForm As New Form2
            Me.Hide()
            MainForm.ShowDialog()
        Else
            MessageBox.Show("WRONG CREDENTIALS..!")
        End If

    End Sub

    Private Sub Got_Input(sender As Object, e As EventArgs) Handles UsernameTxt.TextChanged, PasswordTxt.TextChanged
        userName = UsernameTxt.Text
        passWord = PasswordTxt.Text
    End Sub


    Private Sub UsernameTxt_TextChanged(sender As Object, e As EventArgs) Handles UsernameTxt.TextChanged

    End Sub

    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click
        Me.Close()
    End Sub

    Private Sub Register_Btn_Click(sender As Object, e As EventArgs) Handles Register_Btn.Click
        Dim MainForm As New RegistrationForm
        Me.Hide()
        MainForm.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class