<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Me.components = New System.ComponentModel.Container()
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Course_AppliedLabel As System.Windows.Forms.Label
        Dim Fathers_NameLabel As System.Windows.Forms.Label
        Dim Mothers_NameLabel As System.Windows.Forms.Label
        Dim School_10_NameLabel As System.Windows.Forms.Label
        Dim Year_Pass_10Label As System.Windows.Forms.Label
        Dim Marks_10Label As System.Windows.Forms.Label
        Dim School_12_NameLabel As System.Windows.Forms.Label
        Dim Year_Pass_12Label As System.Windows.Forms.Label
        Dim Marks_12Label As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim State_Of_BirthLabel As System.Windows.Forms.Label
        Dim AGELabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim Email_idLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationForm))
        Me.Stu_tableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Stu_tableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentDBDataSet = New Admission.StudentDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Stu_tableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Course_AppliedTextBox = New System.Windows.Forms.TextBox()
        Me.Fathers_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Mothers_NameTextBox = New System.Windows.Forms.TextBox()
        Me.School_10_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Year_Pass_10TextBox = New System.Windows.Forms.TextBox()
        Me.Marks_10TextBox = New System.Windows.Forms.TextBox()
        Me.School_12_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Year_Pass_12TextBox = New System.Windows.Forms.TextBox()
        Me.Marks_12TextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.State_Of_BirthTextBox = New System.Windows.Forms.TextBox()
        Me.AGETextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTextBox = New System.Windows.Forms.TextBox()
        Me.Email_idTextBox = New System.Windows.Forms.TextBox()
        Me.Btn_Home = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Stu_tableTableAdapter = New Admission.StudentDBDataSetTableAdapters.stu_tableTableAdapter()
        Me.TableAdapterManager = New Admission.StudentDBDataSetTableAdapters.TableAdapterManager()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Student_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Course_AppliedLabel = New System.Windows.Forms.Label()
        Fathers_NameLabel = New System.Windows.Forms.Label()
        Mothers_NameLabel = New System.Windows.Forms.Label()
        School_10_NameLabel = New System.Windows.Forms.Label()
        Year_Pass_10Label = New System.Windows.Forms.Label()
        Marks_10Label = New System.Windows.Forms.Label()
        School_12_NameLabel = New System.Windows.Forms.Label()
        Year_Pass_12Label = New System.Windows.Forms.Label()
        Marks_12Label = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        State_Of_BirthLabel = New System.Windows.Forms.Label()
        AGELabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        Email_idLabel = New System.Windows.Forms.Label()
        CType(Me.Stu_tableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Stu_tableBindingNavigator.SuspendLayout()
        CType(Me.Stu_tableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_IDLabel.Location = New System.Drawing.Point(48, 54)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(90, 19)
        Student_IDLabel.TabIndex = 1
        Student_IDLabel.Text = "Student ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(48, 92)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(98, 23)
        First_NameLabel.TabIndex = 3
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(473, 81)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(119, 23)
        Last_NameLabel.TabIndex = 5
        Last_NameLabel.Text = "      Last Name:"
        '
        'Course_AppliedLabel
        '
        Course_AppliedLabel.AutoSize = True
        Course_AppliedLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Course_AppliedLabel.Location = New System.Drawing.Point(571, 123)
        Course_AppliedLabel.Name = "Course_AppliedLabel"
        Course_AppliedLabel.Size = New System.Drawing.Size(131, 23)
        Course_AppliedLabel.TabIndex = 7
        Course_AppliedLabel.Text = "Course Applied:"
        '
        'Fathers_NameLabel
        '
        Fathers_NameLabel.AutoSize = True
        Fathers_NameLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fathers_NameLabel.Location = New System.Drawing.Point(27, 126)
        Fathers_NameLabel.Name = "Fathers_NameLabel"
        Fathers_NameLabel.Size = New System.Drawing.Size(121, 23)
        Fathers_NameLabel.TabIndex = 9
        Fathers_NameLabel.Text = "Fathers Name:"
        '
        'Mothers_NameLabel
        '
        Mothers_NameLabel.AutoSize = True
        Mothers_NameLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Mothers_NameLabel.Location = New System.Drawing.Point(18, 163)
        Mothers_NameLabel.Name = "Mothers_NameLabel"
        Mothers_NameLabel.Size = New System.Drawing.Size(130, 23)
        Mothers_NameLabel.TabIndex = 11
        Mothers_NameLabel.Text = "Mothers Name:"
        '
        'School_10_NameLabel
        '
        School_10_NameLabel.AutoSize = True
        School_10_NameLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        School_10_NameLabel.Location = New System.Drawing.Point(7, 202)
        School_10_NameLabel.Name = "School_10_NameLabel"
        School_10_NameLabel.Size = New System.Drawing.Size(139, 23)
        School_10_NameLabel.TabIndex = 13
        School_10_NameLabel.Text = "School 10 Name:"
        '
        'Year_Pass_10Label
        '
        Year_Pass_10Label.AutoSize = True
        Year_Pass_10Label.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Year_Pass_10Label.Location = New System.Drawing.Point(628, 202)
        Year_Pass_10Label.Name = "Year_Pass_10Label"
        Year_Pass_10Label.Size = New System.Drawing.Size(111, 23)
        Year_Pass_10Label.TabIndex = 15
        Year_Pass_10Label.Text = "Year Pass 10:"
        '
        'Marks_10Label
        '
        Marks_10Label.AutoSize = True
        Marks_10Label.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Marks_10Label.Location = New System.Drawing.Point(427, 205)
        Marks_10Label.Name = "Marks_10Label"
        Marks_10Label.Size = New System.Drawing.Size(88, 23)
        Marks_10Label.TabIndex = 17
        Marks_10Label.Text = "Marks 10:"
        '
        'School_12_NameLabel
        '
        School_12_NameLabel.AutoSize = True
        School_12_NameLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        School_12_NameLabel.Location = New System.Drawing.Point(12, 242)
        School_12_NameLabel.Name = "School_12_NameLabel"
        School_12_NameLabel.Size = New System.Drawing.Size(139, 23)
        School_12_NameLabel.TabIndex = 19
        School_12_NameLabel.Text = "School 12 Name:"
        '
        'Year_Pass_12Label
        '
        Year_Pass_12Label.AutoSize = True
        Year_Pass_12Label.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Year_Pass_12Label.Location = New System.Drawing.Point(628, 247)
        Year_Pass_12Label.Name = "Year_Pass_12Label"
        Year_Pass_12Label.Size = New System.Drawing.Size(111, 23)
        Year_Pass_12Label.TabIndex = 21
        Year_Pass_12Label.Text = "Year Pass 12:"
        '
        'Marks_12Label
        '
        Marks_12Label.AutoSize = True
        Marks_12Label.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Marks_12Label.Location = New System.Drawing.Point(427, 245)
        Marks_12Label.Name = "Marks_12Label"
        Marks_12Label.Size = New System.Drawing.Size(88, 23)
        Marks_12Label.TabIndex = 23
        Marks_12Label.Text = "Marks 12:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOBLabel.Location = New System.Drawing.Point(18, 291)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(50, 23)
        DOBLabel.TabIndex = 25
        DOBLabel.Text = "DOB:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(449, 337)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(78, 23)
        AddressLabel.TabIndex = 27
        AddressLabel.Text = "Address:"
        '
        'State_Of_BirthLabel
        '
        State_Of_BirthLabel.AutoSize = True
        State_Of_BirthLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        State_Of_BirthLabel.Location = New System.Drawing.Point(474, 286)
        State_Of_BirthLabel.Name = "State_Of_BirthLabel"
        State_Of_BirthLabel.Size = New System.Drawing.Size(118, 23)
        State_Of_BirthLabel.TabIndex = 29
        State_Of_BirthLabel.Text = "State Of Birth:"
        '
        'AGELabel
        '
        AGELabel.AutoSize = True
        AGELabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AGELabel.Location = New System.Drawing.Point(323, 291)
        AGELabel.Name = "AGELabel"
        AGELabel.Size = New System.Drawing.Size(47, 23)
        AGELabel.TabIndex = 31
        AGELabel.Text = "AGE:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(630, 157)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(72, 23)
        GenderLabel.TabIndex = 33
        GenderLabel.Text = "Gender:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactLabel.Location = New System.Drawing.Point(16, 340)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(74, 23)
        ContactLabel.TabIndex = 35
        ContactLabel.Text = "Contact:"
        '
        'Email_idLabel
        '
        Email_idLabel.AutoSize = True
        Email_idLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Email_idLabel.Location = New System.Drawing.Point(474, 47)
        Email_idLabel.Name = "Email_idLabel"
        Email_idLabel.Size = New System.Drawing.Size(74, 23)
        Email_idLabel.TabIndex = 37
        Email_idLabel.Text = "Email id:"
        '
        'Stu_tableBindingNavigator
        '
        Me.Stu_tableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Stu_tableBindingNavigator.BindingSource = Me.Stu_tableBindingSource
        Me.Stu_tableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Stu_tableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Stu_tableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Stu_tableBindingNavigatorSaveItem})
        Me.Stu_tableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Stu_tableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Stu_tableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Stu_tableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Stu_tableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Stu_tableBindingNavigator.Name = "Stu_tableBindingNavigator"
        Me.Stu_tableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Stu_tableBindingNavigator.Size = New System.Drawing.Size(1075, 25)
        Me.Stu_tableBindingNavigator.TabIndex = 0
        Me.Stu_tableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(58, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'Stu_tableBindingSource
        '
        Me.Stu_tableBindingSource.DataMember = "stu_table"
        Me.Stu_tableBindingSource.DataSource = Me.StudentDBDataSet
        '
        'StudentDBDataSet
        '
        Me.StudentDBDataSet.DataSetName = "StudentDBDataSet"
        Me.StudentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Stu_tableBindingNavigatorSaveItem
        '
        Me.Stu_tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Stu_tableBindingNavigatorSaveItem.Image = CType(resources.GetObject("Stu_tableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Stu_tableBindingNavigatorSaveItem.Name = "Stu_tableBindingNavigatorSaveItem"
        Me.Stu_tableBindingNavigatorSaveItem.Size = New System.Drawing.Size(62, 22)
        Me.Stu_tableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "Student ID", True))
        Me.Student_IDTextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(184, 47)
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.Size = New System.Drawing.Size(200, 31)
        Me.Student_IDTextBox.TabIndex = 2
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "First_Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(184, 84)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(200, 31)
        Me.First_NameTextBox.TabIndex = 4
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(598, 76)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(215, 31)
        Me.Last_NameTextBox.TabIndex = 6
        '
        'Course_AppliedTextBox
        '
        Me.Course_AppliedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "Course_Applied", True))
        Me.Course_AppliedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Stu_tableBindingSource, "Course_Applied", True))
        Me.Course_AppliedTextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course_AppliedTextBox.Location = New System.Drawing.Point(765, 115)
        Me.Course_AppliedTextBox.Name = "Course_AppliedTextBox"
        Me.Course_AppliedTextBox.Size = New System.Drawing.Size(98, 31)
        Me.Course_AppliedTextBox.TabIndex = 8
        '
        'Fathers_NameTextBox
        '
        Me.Fathers_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "Fathers_Name", True))
        Me.Fathers_NameTextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fathers_NameTextBox.Location = New System.Drawing.Point(184, 123)
        Me.Fathers_NameTextBox.Name = "Fathers_NameTextBox"
        Me.Fathers_NameTextBox.Size = New System.Drawing.Size(200, 31)
        Me.Fathers_NameTextBox.TabIndex = 10
        '
        'Mothers_NameTextBox
        '
        Me.Mothers_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "Mothers_Name", True))
        Me.Mothers_NameTextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mothers_NameTextBox.Location = New System.Drawing.Point(184, 160)
        Me.Mothers_NameTextBox.Name = "Mothers_NameTextBox"
        Me.Mothers_NameTextBox.Size = New System.Drawing.Size(200, 31)
        Me.Mothers_NameTextBox.TabIndex = 12
        '
        'School_10_NameTextBox
        '
        Me.School_10_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "School_10_Name", True))
        Me.School_10_NameTextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.School_10_NameTextBox.Location = New System.Drawing.Point(184, 197)
        Me.School_10_NameTextBox.Name = "School_10_NameTextBox"
        Me.School_10_NameTextBox.Size = New System.Drawing.Size(215, 31)
        Me.School_10_NameTextBox.TabIndex = 14
        '
        'Year_Pass_10TextBox
        '
        Me.Year_Pass_10TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "Year_Pass_10", True))
        Me.Year_Pass_10TextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Year_Pass_10TextBox.Location = New System.Drawing.Point(765, 194)
        Me.Year_Pass_10TextBox.Name = "Year_Pass_10TextBox"
        Me.Year_Pass_10TextBox.Size = New System.Drawing.Size(98, 31)
        Me.Year_Pass_10TextBox.TabIndex = 16
        '
        'Marks_10TextBox
        '
        Me.Marks_10TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "Marks_10", True))
        Me.Marks_10TextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Marks_10TextBox.Location = New System.Drawing.Point(521, 199)
        Me.Marks_10TextBox.Name = "Marks_10TextBox"
        Me.Marks_10TextBox.Size = New System.Drawing.Size(86, 31)
        Me.Marks_10TextBox.TabIndex = 18
        '
        'School_12_NameTextBox
        '
        Me.School_12_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "School_12_Name", True))
        Me.School_12_NameTextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.School_12_NameTextBox.Location = New System.Drawing.Point(184, 237)
        Me.School_12_NameTextBox.Name = "School_12_NameTextBox"
        Me.School_12_NameTextBox.Size = New System.Drawing.Size(200, 31)
        Me.School_12_NameTextBox.TabIndex = 20
        '
        'Year_Pass_12TextBox
        '
        Me.Year_Pass_12TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "Year_Pass_12", True))
        Me.Year_Pass_12TextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Year_Pass_12TextBox.Location = New System.Drawing.Point(765, 237)
        Me.Year_Pass_12TextBox.Name = "Year_Pass_12TextBox"
        Me.Year_Pass_12TextBox.Size = New System.Drawing.Size(98, 31)
        Me.Year_Pass_12TextBox.TabIndex = 22
        '
        'Marks_12TextBox
        '
        Me.Marks_12TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "Marks_12", True))
        Me.Marks_12TextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Marks_12TextBox.Location = New System.Drawing.Point(521, 239)
        Me.Marks_12TextBox.Name = "Marks_12TextBox"
        Me.Marks_12TextBox.Size = New System.Drawing.Size(86, 31)
        Me.Marks_12TextBox.TabIndex = 24
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Stu_tableBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(74, 285)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 31)
        Me.DOBDateTimePicker.TabIndex = 26
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(555, 337)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(332, 124)
        Me.AddressTextBox.TabIndex = 28
        '
        'State_Of_BirthTextBox
        '
        Me.State_Of_BirthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "State_Of_Birth", True))
        Me.State_Of_BirthTextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.State_Of_BirthTextBox.Location = New System.Drawing.Point(598, 283)
        Me.State_Of_BirthTextBox.Name = "State_Of_BirthTextBox"
        Me.State_Of_BirthTextBox.Size = New System.Drawing.Size(200, 31)
        Me.State_Of_BirthTextBox.TabIndex = 30
        '
        'AGETextBox
        '
        Me.AGETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "AGE", True))
        Me.AGETextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AGETextBox.Location = New System.Drawing.Point(376, 283)
        Me.AGETextBox.Name = "AGETextBox"
        Me.AGETextBox.Size = New System.Drawing.Size(63, 31)
        Me.AGETextBox.TabIndex = 32
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "gender", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(765, 157)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(98, 31)
        Me.GenderTextBox.TabIndex = 34
        '
        'ContactTextBox
        '
        Me.ContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "Contact", True))
        Me.ContactTextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactTextBox.Location = New System.Drawing.Point(107, 332)
        Me.ContactTextBox.Name = "ContactTextBox"
        Me.ContactTextBox.Size = New System.Drawing.Size(200, 31)
        Me.ContactTextBox.TabIndex = 36
        '
        'Email_idTextBox
        '
        Me.Email_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stu_tableBindingSource, "Email_id", True))
        Me.Email_idTextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_idTextBox.Location = New System.Drawing.Point(598, 39)
        Me.Email_idTextBox.Name = "Email_idTextBox"
        Me.Email_idTextBox.Size = New System.Drawing.Size(289, 31)
        Me.Email_idTextBox.TabIndex = 38
        '
        'Btn_Home
        '
        Me.Btn_Home.Location = New System.Drawing.Point(376, 2)
        Me.Btn_Home.Name = "Btn_Home"
        Me.Btn_Home.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Home.TabIndex = 39
        Me.Btn_Home.Text = "Home"
        Me.Btn_Home.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(431, 485)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(75, 36)
        Me.ClearBtn.TabIndex = 40
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(327, 485)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(75, 36)
        Me.EditBtn.TabIndex = 41
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = True
        Me.EditBtn.Visible = False
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(634, 485)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(75, 36)
        Me.CloseBtn.TabIndex = 42
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
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
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(532, 485)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(75, 36)
        Me.Btn_Save.TabIndex = 43
        Me.Btn_Save.Text = "Save"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(1075, 581)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.Btn_Home)
        Me.Controls.Add(Student_IDLabel)
        Me.Controls.Add(Me.Student_IDTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Course_AppliedLabel)
        Me.Controls.Add(Me.Course_AppliedTextBox)
        Me.Controls.Add(Fathers_NameLabel)
        Me.Controls.Add(Me.Fathers_NameTextBox)
        Me.Controls.Add(Mothers_NameLabel)
        Me.Controls.Add(Me.Mothers_NameTextBox)
        Me.Controls.Add(School_10_NameLabel)
        Me.Controls.Add(Me.School_10_NameTextBox)
        Me.Controls.Add(Year_Pass_10Label)
        Me.Controls.Add(Me.Year_Pass_10TextBox)
        Me.Controls.Add(Marks_10Label)
        Me.Controls.Add(Me.Marks_10TextBox)
        Me.Controls.Add(School_12_NameLabel)
        Me.Controls.Add(Me.School_12_NameTextBox)
        Me.Controls.Add(Year_Pass_12Label)
        Me.Controls.Add(Me.Year_Pass_12TextBox)
        Me.Controls.Add(Marks_12Label)
        Me.Controls.Add(Me.Marks_12TextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(State_Of_BirthLabel)
        Me.Controls.Add(Me.State_Of_BirthTextBox)
        Me.Controls.Add(AGELabel)
        Me.Controls.Add(Me.AGETextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(ContactLabel)
        Me.Controls.Add(Me.ContactTextBox)
        Me.Controls.Add(Email_idLabel)
        Me.Controls.Add(Me.Email_idTextBox)
        Me.Controls.Add(Me.Stu_tableBindingNavigator)
        Me.Name = "RegistrationForm"
        Me.ShowIcon = False
        Me.Text = "RegistrationForm"
        CType(Me.Stu_tableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Stu_tableBindingNavigator.ResumeLayout(False)
        Me.Stu_tableBindingNavigator.PerformLayout()
        CType(Me.Stu_tableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentDBDataSet As StudentDBDataSet
    Friend WithEvents Stu_tableBindingSource As BindingSource
    Friend WithEvents Stu_tableTableAdapter As StudentDBDataSetTableAdapters.stu_tableTableAdapter
    Friend WithEvents TableAdapterManager As StudentDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Stu_tableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Stu_tableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Student_IDTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents Course_AppliedTextBox As TextBox
    Friend WithEvents Fathers_NameTextBox As TextBox
    Friend WithEvents Mothers_NameTextBox As TextBox
    Friend WithEvents School_10_NameTextBox As TextBox
    Friend WithEvents Year_Pass_10TextBox As TextBox
    Friend WithEvents Marks_10TextBox As TextBox
    Friend WithEvents School_12_NameTextBox As TextBox
    Friend WithEvents Year_Pass_12TextBox As TextBox
    Friend WithEvents Marks_12TextBox As TextBox
    Friend WithEvents DOBDateTimePicker As DateTimePicker
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents State_Of_BirthTextBox As TextBox
    Friend WithEvents AGETextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents ContactTextBox As TextBox
    Friend WithEvents Email_idTextBox As TextBox
    Friend WithEvents Btn_Home As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents CloseBtn As Button
    Friend WithEvents Btn_Save As Button
End Class
