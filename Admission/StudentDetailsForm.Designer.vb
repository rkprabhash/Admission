<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentDetailsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StudentDBDataSet = New Admission.StudentDBDataSet()
        Me.Stu_tableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Stu_tableTableAdapter = New Admission.StudentDBDataSetTableAdapters.stu_tableTableAdapter()
        Me.TableAdapterManager = New Admission.StudentDBDataSetTableAdapters.TableAdapterManager()
        Me.Stu_tableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.StudentDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stu_tableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stu_tableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentDBDataSet
        '
        Me.StudentDBDataSet.DataSetName = "StudentDBDataSet"
        Me.StudentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Stu_tableBindingSource
        '
        Me.Stu_tableBindingSource.DataMember = "stu_table"
        Me.Stu_tableBindingSource.DataSource = Me.StudentDBDataSet
        '
        'Stu_tableTableAdapter
        '
        Me.Stu_tableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.stu_tableTableAdapter = Me.Stu_tableTableAdapter
        Me.TableAdapterManager.UpdateOrder = Admission.StudentDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Stu_tableDataGridView
        '
        Me.Stu_tableDataGridView.AutoGenerateColumns = False
        Me.Stu_tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Stu_tableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.Stu_tableDataGridView.DataSource = Me.Stu_tableBindingSource
        Me.Stu_tableDataGridView.Location = New System.Drawing.Point(12, 29)
        Me.Stu_tableDataGridView.Name = "Stu_tableDataGridView"
        Me.Stu_tableDataGridView.Size = New System.Drawing.Size(1226, 220)
        Me.Stu_tableDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Student ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Student ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Course_Applied"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Course_Applied"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Fathers_Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fathers_Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Mothers_Name"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Mothers_Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "School_10_Name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "School_10_Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Year_Pass_10"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Year_Pass_10"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Marks_10"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Marks_10"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "School_12_Name"
        Me.DataGridViewTextBoxColumn10.HeaderText = "School_12_Name"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Year_Pass_12"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Year_Pass_12"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Marks_12"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Marks_12"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "DOB"
        Me.DataGridViewTextBoxColumn13.HeaderText = "DOB"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "State_Of_Birth"
        Me.DataGridViewTextBoxColumn15.HeaderText = "State_Of_Birth"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "AGE"
        Me.DataGridViewTextBoxColumn16.HeaderText = "AGE"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "gender"
        Me.DataGridViewTextBoxColumn17.HeaderText = "gender"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Contact"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Contact"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Email_id"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Email_id"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StudentDetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 296)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Stu_tableDataGridView)
        Me.Name = "StudentDetailsForm"
        Me.Text = "StudentDetailsForm"
        CType(Me.StudentDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stu_tableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stu_tableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentDBDataSet As StudentDBDataSet
    Friend WithEvents Stu_tableBindingSource As BindingSource
    Friend WithEvents Stu_tableTableAdapter As StudentDBDataSetTableAdapters.stu_tableTableAdapter
    Friend WithEvents TableAdapterManager As StudentDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Stu_tableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
