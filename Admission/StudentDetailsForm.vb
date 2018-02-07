Public Class StudentDetailsForm
    Private Sub Stu_tableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Stu_tableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentDBDataSet)

    End Sub

    Private Sub StudentDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDBDataSet.stu_table' table. You can move, or remove it, as needed.
        Me.Stu_tableTableAdapter.Fill(Me.StudentDBDataSet.stu_table)

    End Sub

    Private Sub Stu_tableDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()

    End Sub
End Class