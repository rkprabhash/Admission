Public Class Form2
    Private Sub Stu_tableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Stu_tableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDBDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Stu_tableTableAdapter.Fill(Me.StudentDBDataSet.stu_table)

    End Sub

    Private Sub Btn_Home_Click(sender As Object, e As EventArgs) Handles Btn_Home.Click
        Dim MainForm As New Form1
        Me.Hide()
        MainForm.ShowDialog()
    End Sub
End Class