<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.labelFirstName = New System.Windows.Forms.Label()
        Me.inputFirstName = New System.Windows.Forms.TextBox()
        Me.labelAddress = New System.Windows.Forms.Label()
        Me.inputAddress = New System.Windows.Forms.TextBox()
        Me.labelNumber = New System.Windows.Forms.Label()
        Me.inputNumber = New System.Windows.Forms.TextBox()
        Me.lableEmail = New System.Windows.Forms.Label()
        Me.inputEmail = New System.Windows.Forms.TextBox()
        Me.labelSummary = New System.Windows.Forms.Label()
        Me.inputSummary = New System.Windows.Forms.TextBox()
        Me.tableEducational = New System.Windows.Forms.DataGridView()
        Me.inputSchool = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inputDegree = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inputYearAttended = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.groupWorkingExperience = New System.Windows.Forms.GroupBox()
        Me.tableExperience = New System.Windows.Forms.DataGridView()
        Me.inputJobPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inputJobDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inputCompanyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inputCompanyAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inputJobYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buttonUploadJSON = New System.Windows.Forms.Button()
        Me.buttonGenerateResume = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonAddRowEducational = New System.Windows.Forms.Button()
        Me.buttonAddRowExperience = New System.Windows.Forms.Button()
        Me.buttonRemoveRowEducational = New System.Windows.Forms.Button()
        Me.buttonRemoveRowExperience = New System.Windows.Forms.Button()
        Me.inputMiddleName = New System.Windows.Forms.TextBox()
        Me.labelMiddleName = New System.Windows.Forms.Label()
        Me.inputLastName = New System.Windows.Forms.TextBox()
        Me.labelLastName = New System.Windows.Forms.Label()
        Me.jsonFolderSelect = New System.Windows.Forms.FolderBrowserDialog()
        Me.jsonFileSelect = New System.Windows.Forms.OpenFileDialog()
        Me.buttonRemoveRowCertificates = New System.Windows.Forms.Button()
        Me.buttonAddRowCertificates = New System.Windows.Forms.Button()
        Me.groupCertificates = New System.Windows.Forms.GroupBox()
        Me.tableCertificates = New System.Windows.Forms.DataGridView()
        Me.inputTitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inputIssued = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buttonRemoveRowSkills = New System.Windows.Forms.Button()
        Me.buttonAddRowSkills = New System.Windows.Forms.Button()
        Me.groupSkills = New System.Windows.Forms.GroupBox()
        Me.tableSkills = New System.Windows.Forms.DataGridView()
        Me.inputSkill = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.buttonGenerateJSON = New System.Windows.Forms.Button()
        Me.buttonReset = New System.Windows.Forms.Button()
        CType(Me.tableEducational, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupWorkingExperience.SuspendLayout()
        CType(Me.tableExperience, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupCertificates.SuspendLayout()
        CType(Me.tableCertificates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupSkills.SuspendLayout()
        CType(Me.tableSkills, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelFirstName
        '
        Me.labelFirstName.AutoSize = True
        Me.labelFirstName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelFirstName.Location = New System.Drawing.Point(12, 41)
        Me.labelFirstName.Name = "labelFirstName"
        Me.labelFirstName.Size = New System.Drawing.Size(107, 17)
        Me.labelFirstName.TabIndex = 0
        Me.labelFirstName.Text = "First Name:"
        '
        'inputFirstName
        '
        Me.inputFirstName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputFirstName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inputFirstName.Location = New System.Drawing.Point(125, 38)
        Me.inputFirstName.Name = "inputFirstName"
        Me.inputFirstName.Size = New System.Drawing.Size(526, 24)
        Me.inputFirstName.TabIndex = 1
        '
        'labelAddress
        '
        Me.labelAddress.AutoSize = True
        Me.labelAddress.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelAddress.Location = New System.Drawing.Point(12, 131)
        Me.labelAddress.Name = "labelAddress"
        Me.labelAddress.Size = New System.Drawing.Size(80, 17)
        Me.labelAddress.TabIndex = 2
        Me.labelAddress.Text = "Address:"
        '
        'inputAddress
        '
        Me.inputAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputAddress.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inputAddress.Location = New System.Drawing.Point(98, 128)
        Me.inputAddress.Name = "inputAddress"
        Me.inputAddress.Size = New System.Drawing.Size(553, 24)
        Me.inputAddress.TabIndex = 4
        '
        'labelNumber
        '
        Me.labelNumber.AutoSize = True
        Me.labelNumber.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelNumber.Location = New System.Drawing.Point(11, 161)
        Me.labelNumber.Name = "labelNumber"
        Me.labelNumber.Size = New System.Drawing.Size(143, 17)
        Me.labelNumber.TabIndex = 4
        Me.labelNumber.Text = "Contact Number:"
        '
        'inputNumber
        '
        Me.inputNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputNumber.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inputNumber.Location = New System.Drawing.Point(160, 158)
        Me.inputNumber.Name = "inputNumber"
        Me.inputNumber.Size = New System.Drawing.Size(491, 24)
        Me.inputNumber.TabIndex = 5
        '
        'lableEmail
        '
        Me.lableEmail.AutoSize = True
        Me.lableEmail.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lableEmail.Location = New System.Drawing.Point(11, 191)
        Me.lableEmail.Name = "lableEmail"
        Me.lableEmail.Size = New System.Drawing.Size(134, 17)
        Me.lableEmail.TabIndex = 6
        Me.lableEmail.Text = "Email Address:"
        '
        'inputEmail
        '
        Me.inputEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputEmail.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inputEmail.Location = New System.Drawing.Point(151, 188)
        Me.inputEmail.Name = "inputEmail"
        Me.inputEmail.Size = New System.Drawing.Size(500, 24)
        Me.inputEmail.TabIndex = 7
        '
        'labelSummary
        '
        Me.labelSummary.AutoSize = True
        Me.labelSummary.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelSummary.Location = New System.Drawing.Point(11, 221)
        Me.labelSummary.Name = "labelSummary"
        Me.labelSummary.Size = New System.Drawing.Size(170, 17)
        Me.labelSummary.TabIndex = 8
        Me.labelSummary.Text = "Objective/Summary:"
        '
        'inputSummary
        '
        Me.inputSummary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputSummary.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inputSummary.Location = New System.Drawing.Point(11, 241)
        Me.inputSummary.Multiline = True
        Me.inputSummary.Name = "inputSummary"
        Me.inputSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.inputSummary.Size = New System.Drawing.Size(640, 134)
        Me.inputSummary.TabIndex = 9
        '
        'tableEducational
        '
        Me.tableEducational.AllowUserToAddRows = False
        Me.tableEducational.AllowUserToDeleteRows = False
        Me.tableEducational.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableEducational.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tableEducational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableEducational.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.inputSchool, Me.inputDegree, Me.inputYearAttended})
        Me.tableEducational.Location = New System.Drawing.Point(6, 22)
        Me.tableEducational.Name = "tableEducational"
        Me.tableEducational.RowTemplate.Height = 25
        Me.tableEducational.Size = New System.Drawing.Size(626, 169)
        Me.tableEducational.TabIndex = 10
        '
        'inputSchool
        '
        Me.inputSchool.HeaderText = "School"
        Me.inputSchool.Name = "inputSchool"
        '
        'inputDegree
        '
        Me.inputDegree.HeaderText = "Degree"
        Me.inputDegree.Name = "inputDegree"
        '
        'inputYearAttended
        '
        Me.inputYearAttended.HeaderText = "Year Attended (ex: 2001-2005)"
        Me.inputYearAttended.Name = "inputYearAttended"
        '
        'groupWorkingExperience
        '
        Me.groupWorkingExperience.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupWorkingExperience.Controls.Add(Me.tableExperience)
        Me.groupWorkingExperience.Location = New System.Drawing.Point(13, 586)
        Me.groupWorkingExperience.Name = "groupWorkingExperience"
        Me.groupWorkingExperience.Size = New System.Drawing.Size(638, 199)
        Me.groupWorkingExperience.TabIndex = 11
        Me.groupWorkingExperience.TabStop = False
        Me.groupWorkingExperience.Text = "Working Experience"
        '
        'tableExperience
        '
        Me.tableExperience.AllowUserToAddRows = False
        Me.tableExperience.AllowUserToDeleteRows = False
        Me.tableExperience.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableExperience.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tableExperience.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableExperience.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.inputJobPosition, Me.inputJobDescription, Me.inputCompanyName, Me.inputCompanyAddress, Me.inputJobYear})
        Me.tableExperience.Location = New System.Drawing.Point(6, 22)
        Me.tableExperience.Name = "tableExperience"
        Me.tableExperience.RowTemplate.Height = 25
        Me.tableExperience.Size = New System.Drawing.Size(625, 171)
        Me.tableExperience.TabIndex = 1
        '
        'inputJobPosition
        '
        Me.inputJobPosition.HeaderText = "Job Position"
        Me.inputJobPosition.Name = "inputJobPosition"
        '
        'inputJobDescription
        '
        Me.inputJobDescription.HeaderText = "Job Description"
        Me.inputJobDescription.Name = "inputJobDescription"
        '
        'inputCompanyName
        '
        Me.inputCompanyName.HeaderText = "Company Name"
        Me.inputCompanyName.Name = "inputCompanyName"
        '
        'inputCompanyAddress
        '
        Me.inputCompanyAddress.HeaderText = "Company Address"
        Me.inputCompanyAddress.Name = "inputCompanyAddress"
        '
        'inputJobYear
        '
        Me.inputJobYear.HeaderText = "Working Years (ex: 2011-2012)"
        Me.inputJobYear.Name = "inputJobYear"
        '
        'buttonUploadJSON
        '
        Me.buttonUploadJSON.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonUploadJSON.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buttonUploadJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonUploadJSON.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonUploadJSON.Location = New System.Drawing.Point(521, 12)
        Me.buttonUploadJSON.Name = "buttonUploadJSON"
        Me.buttonUploadJSON.Size = New System.Drawing.Size(130, 23)
        Me.buttonUploadJSON.TabIndex = 12
        Me.buttonUploadJSON.Text = "Upload JSON"
        Me.buttonUploadJSON.UseVisualStyleBackColor = False
        '
        'buttonGenerateResume
        '
        Me.buttonGenerateResume.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonGenerateResume.BackColor = System.Drawing.Color.Aqua
        Me.buttonGenerateResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonGenerateResume.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonGenerateResume.Location = New System.Drawing.Point(494, 1218)
        Me.buttonGenerateResume.Name = "buttonGenerateResume"
        Me.buttonGenerateResume.Size = New System.Drawing.Size(157, 23)
        Me.buttonGenerateResume.TabIndex = 13
        Me.buttonGenerateResume.Text = "Generate Resume"
        Me.buttonGenerateResume.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(221, 1252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 15
        '
        'buttonAddRowEducational
        '
        Me.buttonAddRowEducational.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAddRowEducational.BackColor = System.Drawing.Color.Aqua
        Me.buttonAddRowEducational.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonAddRowEducational.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonAddRowEducational.Location = New System.Drawing.Point(658, 546)
        Me.buttonAddRowEducational.Name = "buttonAddRowEducational"
        Me.buttonAddRowEducational.Size = New System.Drawing.Size(24, 23)
        Me.buttonAddRowEducational.TabIndex = 16
        Me.buttonAddRowEducational.Text = "+"
        Me.buttonAddRowEducational.UseVisualStyleBackColor = False
        '
        'buttonAddRowExperience
        '
        Me.buttonAddRowExperience.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAddRowExperience.BackColor = System.Drawing.Color.Aqua
        Me.buttonAddRowExperience.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonAddRowExperience.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonAddRowExperience.Location = New System.Drawing.Point(658, 756)
        Me.buttonAddRowExperience.Name = "buttonAddRowExperience"
        Me.buttonAddRowExperience.Size = New System.Drawing.Size(24, 23)
        Me.buttonAddRowExperience.TabIndex = 17
        Me.buttonAddRowExperience.Text = "+"
        Me.buttonAddRowExperience.UseVisualStyleBackColor = False
        '
        'buttonRemoveRowEducational
        '
        Me.buttonRemoveRowEducational.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonRemoveRowEducational.BackColor = System.Drawing.Color.Aqua
        Me.buttonRemoveRowEducational.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonRemoveRowEducational.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonRemoveRowEducational.Location = New System.Drawing.Point(688, 546)
        Me.buttonRemoveRowEducational.Name = "buttonRemoveRowEducational"
        Me.buttonRemoveRowEducational.Size = New System.Drawing.Size(24, 23)
        Me.buttonRemoveRowEducational.TabIndex = 18
        Me.buttonRemoveRowEducational.Text = "-"
        Me.buttonRemoveRowEducational.UseVisualStyleBackColor = False
        '
        'buttonRemoveRowExperience
        '
        Me.buttonRemoveRowExperience.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonRemoveRowExperience.BackColor = System.Drawing.Color.Aqua
        Me.buttonRemoveRowExperience.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonRemoveRowExperience.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonRemoveRowExperience.Location = New System.Drawing.Point(688, 756)
        Me.buttonRemoveRowExperience.Name = "buttonRemoveRowExperience"
        Me.buttonRemoveRowExperience.Size = New System.Drawing.Size(24, 23)
        Me.buttonRemoveRowExperience.TabIndex = 19
        Me.buttonRemoveRowExperience.Text = "-"
        Me.buttonRemoveRowExperience.UseVisualStyleBackColor = False
        '
        'inputMiddleName
        '
        Me.inputMiddleName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputMiddleName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inputMiddleName.Location = New System.Drawing.Point(134, 68)
        Me.inputMiddleName.Name = "inputMiddleName"
        Me.inputMiddleName.Size = New System.Drawing.Size(517, 24)
        Me.inputMiddleName.TabIndex = 2
        '
        'labelMiddleName
        '
        Me.labelMiddleName.AutoSize = True
        Me.labelMiddleName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelMiddleName.Location = New System.Drawing.Point(12, 71)
        Me.labelMiddleName.Name = "labelMiddleName"
        Me.labelMiddleName.Size = New System.Drawing.Size(116, 17)
        Me.labelMiddleName.TabIndex = 21
        Me.labelMiddleName.Text = "Middle Name:"
        '
        'inputLastName
        '
        Me.inputLastName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputLastName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inputLastName.Location = New System.Drawing.Point(134, 98)
        Me.inputLastName.Name = "inputLastName"
        Me.inputLastName.Size = New System.Drawing.Size(517, 24)
        Me.inputLastName.TabIndex = 3
        '
        'labelLastName
        '
        Me.labelLastName.AutoSize = True
        Me.labelLastName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelLastName.Location = New System.Drawing.Point(12, 101)
        Me.labelLastName.Name = "labelLastName"
        Me.labelLastName.Size = New System.Drawing.Size(98, 17)
        Me.labelLastName.TabIndex = 23
        Me.labelLastName.Text = "Last Name:"
        '
        'buttonRemoveRowCertificates
        '
        Me.buttonRemoveRowCertificates.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonRemoveRowCertificates.BackColor = System.Drawing.Color.Aqua
        Me.buttonRemoveRowCertificates.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonRemoveRowCertificates.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonRemoveRowCertificates.Location = New System.Drawing.Point(688, 961)
        Me.buttonRemoveRowCertificates.Name = "buttonRemoveRowCertificates"
        Me.buttonRemoveRowCertificates.Size = New System.Drawing.Size(24, 23)
        Me.buttonRemoveRowCertificates.TabIndex = 26
        Me.buttonRemoveRowCertificates.Text = "-"
        Me.buttonRemoveRowCertificates.UseVisualStyleBackColor = False
        '
        'buttonAddRowCertificates
        '
        Me.buttonAddRowCertificates.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAddRowCertificates.BackColor = System.Drawing.Color.Aqua
        Me.buttonAddRowCertificates.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonAddRowCertificates.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonAddRowCertificates.Location = New System.Drawing.Point(658, 961)
        Me.buttonAddRowCertificates.Name = "buttonAddRowCertificates"
        Me.buttonAddRowCertificates.Size = New System.Drawing.Size(24, 23)
        Me.buttonAddRowCertificates.TabIndex = 25
        Me.buttonAddRowCertificates.Text = "+"
        Me.buttonAddRowCertificates.UseVisualStyleBackColor = False
        '
        'groupCertificates
        '
        Me.groupCertificates.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupCertificates.Controls.Add(Me.tableCertificates)
        Me.groupCertificates.Location = New System.Drawing.Point(13, 791)
        Me.groupCertificates.Name = "groupCertificates"
        Me.groupCertificates.Size = New System.Drawing.Size(638, 199)
        Me.groupCertificates.TabIndex = 24
        Me.groupCertificates.TabStop = False
        Me.groupCertificates.Text = "Certificates"
        '
        'tableCertificates
        '
        Me.tableCertificates.AllowUserToAddRows = False
        Me.tableCertificates.AllowUserToDeleteRows = False
        Me.tableCertificates.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableCertificates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tableCertificates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableCertificates.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.inputTitle, Me.inputIssued})
        Me.tableCertificates.Location = New System.Drawing.Point(6, 22)
        Me.tableCertificates.Name = "tableCertificates"
        Me.tableCertificates.RowTemplate.Height = 25
        Me.tableCertificates.Size = New System.Drawing.Size(625, 171)
        Me.tableCertificates.TabIndex = 1
        '
        'inputTitle
        '
        Me.inputTitle.HeaderText = "Title"
        Me.inputTitle.Name = "inputTitle"
        '
        'inputIssued
        '
        Me.inputIssued.HeaderText = "Issue Date (Month, Year)"
        Me.inputIssued.Name = "inputIssued"
        '
        'buttonRemoveRowSkills
        '
        Me.buttonRemoveRowSkills.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonRemoveRowSkills.BackColor = System.Drawing.Color.Aqua
        Me.buttonRemoveRowSkills.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonRemoveRowSkills.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonRemoveRowSkills.Location = New System.Drawing.Point(688, 1166)
        Me.buttonRemoveRowSkills.Name = "buttonRemoveRowSkills"
        Me.buttonRemoveRowSkills.Size = New System.Drawing.Size(24, 23)
        Me.buttonRemoveRowSkills.TabIndex = 29
        Me.buttonRemoveRowSkills.Text = "-"
        Me.buttonRemoveRowSkills.UseVisualStyleBackColor = False
        '
        'buttonAddRowSkills
        '
        Me.buttonAddRowSkills.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAddRowSkills.BackColor = System.Drawing.Color.Aqua
        Me.buttonAddRowSkills.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonAddRowSkills.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonAddRowSkills.Location = New System.Drawing.Point(658, 1166)
        Me.buttonAddRowSkills.Name = "buttonAddRowSkills"
        Me.buttonAddRowSkills.Size = New System.Drawing.Size(24, 23)
        Me.buttonAddRowSkills.TabIndex = 28
        Me.buttonAddRowSkills.Text = "+"
        Me.buttonAddRowSkills.UseVisualStyleBackColor = False
        '
        'groupSkills
        '
        Me.groupSkills.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupSkills.Controls.Add(Me.tableSkills)
        Me.groupSkills.Location = New System.Drawing.Point(13, 996)
        Me.groupSkills.Name = "groupSkills"
        Me.groupSkills.Size = New System.Drawing.Size(638, 199)
        Me.groupSkills.TabIndex = 27
        Me.groupSkills.TabStop = False
        Me.groupSkills.Text = "Skills"
        '
        'tableSkills
        '
        Me.tableSkills.AllowUserToAddRows = False
        Me.tableSkills.AllowUserToDeleteRows = False
        Me.tableSkills.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tableSkills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tableSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableSkills.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.inputSkill})
        Me.tableSkills.Location = New System.Drawing.Point(6, 22)
        Me.tableSkills.Name = "tableSkills"
        Me.tableSkills.RowTemplate.Height = 25
        Me.tableSkills.Size = New System.Drawing.Size(625, 171)
        Me.tableSkills.TabIndex = 1
        '
        'inputSkill
        '
        Me.inputSkill.HeaderText = "Skill"
        Me.inputSkill.Name = "inputSkill"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.tableEducational)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 381)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 199)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Educational Attainment"
        '
        'buttonGenerateJSON
        '
        Me.buttonGenerateJSON.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonGenerateJSON.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.buttonGenerateJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonGenerateJSON.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonGenerateJSON.Location = New System.Drawing.Point(331, 1218)
        Me.buttonGenerateJSON.Name = "buttonGenerateJSON"
        Me.buttonGenerateJSON.Size = New System.Drawing.Size(157, 23)
        Me.buttonGenerateJSON.TabIndex = 31
        Me.buttonGenerateJSON.Text = "Generate JSON"
        Me.buttonGenerateJSON.UseVisualStyleBackColor = False
        '
        'buttonReset
        '
        Me.buttonReset.BackColor = System.Drawing.Color.Silver
        Me.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonReset.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonReset.Location = New System.Drawing.Point(13, 1218)
        Me.buttonReset.Name = "buttonReset"
        Me.buttonReset.Size = New System.Drawing.Size(64, 23)
        Me.buttonReset.TabIndex = 32
        Me.buttonReset.Text = "Reset"
        Me.buttonReset.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(758, 466)
        Me.Controls.Add(Me.buttonReset)
        Me.Controls.Add(Me.buttonGenerateJSON)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.buttonRemoveRowSkills)
        Me.Controls.Add(Me.buttonAddRowSkills)
        Me.Controls.Add(Me.groupSkills)
        Me.Controls.Add(Me.buttonRemoveRowCertificates)
        Me.Controls.Add(Me.buttonAddRowCertificates)
        Me.Controls.Add(Me.groupCertificates)
        Me.Controls.Add(Me.inputLastName)
        Me.Controls.Add(Me.labelLastName)
        Me.Controls.Add(Me.inputMiddleName)
        Me.Controls.Add(Me.labelMiddleName)
        Me.Controls.Add(Me.buttonRemoveRowExperience)
        Me.Controls.Add(Me.buttonRemoveRowEducational)
        Me.Controls.Add(Me.buttonAddRowExperience)
        Me.Controls.Add(Me.buttonAddRowEducational)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonGenerateResume)
        Me.Controls.Add(Me.buttonUploadJSON)
        Me.Controls.Add(Me.groupWorkingExperience)
        Me.Controls.Add(Me.inputSummary)
        Me.Controls.Add(Me.labelSummary)
        Me.Controls.Add(Me.inputEmail)
        Me.Controls.Add(Me.lableEmail)
        Me.Controls.Add(Me.inputNumber)
        Me.Controls.Add(Me.labelNumber)
        Me.Controls.Add(Me.inputAddress)
        Me.Controls.Add(Me.labelAddress)
        Me.Controls.Add(Me.inputFirstName)
        Me.Controls.Add(Me.labelFirstName)
        Me.MinimumSize = New System.Drawing.Size(774, 505)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resume Maker"
        CType(Me.tableEducational, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupWorkingExperience.ResumeLayout(False)
        CType(Me.tableExperience, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupCertificates.ResumeLayout(False)
        CType(Me.tableCertificates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupSkills.ResumeLayout(False)
        CType(Me.tableSkills, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelFirstName As Label
    Friend WithEvents inputFirstName As TextBox
    Friend WithEvents labelAddress As Label
    Friend WithEvents inputAddress As TextBox
    Friend WithEvents labelNumber As Label
    Friend WithEvents inputNumber As TextBox
    Friend WithEvents lableEmail As Label
    Friend WithEvents inputEmail As TextBox
    Friend WithEvents labelSummary As Label
    Friend WithEvents inputSummary As TextBox
    Friend WithEvents tableEducational As DataGridView
    Friend WithEvents groupWorkingExperience As GroupBox
    Friend WithEvents tableExperience As DataGridView
    Friend WithEvents inputJobPosition As DataGridViewTextBoxColumn
    Friend WithEvents inputJobDescription As DataGridViewTextBoxColumn
    Friend WithEvents inputCompanyName As DataGridViewTextBoxColumn
    Friend WithEvents inputCompanyAddress As DataGridViewTextBoxColumn
    Friend WithEvents inputJobYear As DataGridViewTextBoxColumn
    Friend WithEvents buttonUploadJSON As Button
    Friend WithEvents buttonGenerateResume As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents buttonAddRowEducational As Button
    Friend WithEvents buttonAddRowExperience As Button
    Friend WithEvents buttonRemoveRowEducational As Button
    Friend WithEvents buttonRemoveRowExperience As Button
    Friend WithEvents inputSchool As DataGridViewTextBoxColumn
    Friend WithEvents inputDegree As DataGridViewTextBoxColumn
    Friend WithEvents inputYearAttended As DataGridViewTextBoxColumn
    Friend WithEvents inputMiddleName As TextBox
    Friend WithEvents labelMiddleName As Label
    Friend WithEvents inputLastName As TextBox
    Friend WithEvents labelLastName As Label
    Friend WithEvents jsonFolderSelect As FolderBrowserDialog
    Friend WithEvents jsonFileSelect As OpenFileDialog
    Friend WithEvents buttonRemoveRowCertificates As Button
    Friend WithEvents buttonAddRowCertificates As Button
    Friend WithEvents groupCertificates As GroupBox
    Friend WithEvents tableCertificates As DataGridView
    Friend WithEvents buttonRemoveRowSkills As Button
    Friend WithEvents buttonAddRowSkills As Button
    Friend WithEvents groupSkills As GroupBox
    Friend WithEvents tableSkills As DataGridView
    Friend WithEvents inputSkill As DataGridViewTextBoxColumn
    Friend WithEvents inputTitle As DataGridViewTextBoxColumn
    Friend WithEvents inputIssued As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents buttonGenerateJSON As Button
    Friend WithEvents buttonReset As Button
End Class
