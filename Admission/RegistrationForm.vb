
Imports System.Data
Imports System
Imports System.OleDb

Public Class RegistrationForm
    Private stu_tableAdapter As Object

    Private Sub Stu_tableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Stu_tableBindingNavigatorSaveItem.Click


        Me.Validate()
        Me.Stu_tableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDBDataSet)
        MessageBox.Show("Data Saved")

    End Sub

    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDBDataSet.stu_table' table. You can move, or remove it, as needed.
        Me.Stu_tableTableAdapter.Fill(Me.StudentDBDataSet.stu_table)
        'above one line is commented by akash

    End Sub



    Private Sub Student_IDTextBox_TextChanged(sender As Object, e As EventArgs) Handles Student_IDTextBox.TextChanged
        'Dim sid As String = Student_IDTextBox.Text
        'Dim sql As String = "INSERT INTO Studnet VALUES (" & sid")"
    End Sub

    Private Sub Btn_Home_Click(sender As Object, e As EventArgs) Handles Btn_Home.Click
        Dim MainForm As New Form1
        Me.Hide()
        MainForm.ShowDialog()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()

    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click

    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        Stu_tableBindingSource.RemoveCurrent()
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Try
            Stu_tableBindingSource.EndEdit()
            stu_tableAdapter.UpdateAll(StudentDBDataSet.stu_table)
            MessageBox.Show("DATA SAVED")
        Catch ex As Exception
            MessageBox.Show("DATA SAved.!!")
        End Try
        Me.Hide()
        Form1.Show()
    End Sub




End Class