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
        Me.labelName = New System.Windows.Forms.Label()
        Me.inputName = New System.Windows.Forms.TextBox()
        Me.labelAddress = New System.Windows.Forms.Label()
        Me.inputAddress = New System.Windows.Forms.TextBox()
        Me.labelNumber = New System.Windows.Forms.Label()
        Me.inputNumber = New System.Windows.Forms.TextBox()
        Me.lableEmail = New System.Windows.Forms.Label()
        Me.inputEmail = New System.Windows.Forms.TextBox()
        Me.labelSummary = New System.Windows.Forms.Label()
        Me.inputSummary = New System.Windows.Forms.TextBox()
        Me.tableEducational = New System.Windows.Forms.DataGridView()
        Me.groupWorkingExperience = New System.Windows.Forms.GroupBox()
        Me.tableExperience = New System.Windows.Forms.DataGridView()
        Me.inputJobPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inputJobDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inputCompanyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inputCompanyAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inputJobYear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.checkEnableWorkingExperience = New System.Windows.Forms.CheckBox()
        Me.buttonUploadJSON = New System.Windows.Forms.Button()
        Me.buttonGenerateResume = New System.Windows.Forms.Button()
        Me.buttonGenerateJSON = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buttonAddRowEducational = New System.Windows.Forms.Button()
        Me.buttonAddRowExperience = New System.Windows.Forms.Button()
        Me.buttonRemoveRowEducational = New System.Windows.Forms.Button()
        Me.buttonRemoveRowExperience = New System.Windows.Forms.Button()
        Me.labelEducationalAttainment = New System.Windows.Forms.Label()
        Me.inputSchool = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inputDegree = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inputYearAttended = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.tableEducational, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupWorkingExperience.SuspendLayout()
        CType(Me.tableExperience, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelName
        '
        Me.labelName.AutoSize = True
        Me.labelName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelName.Location = New System.Drawing.Point(12, 41)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(53, 17)
        Me.labelName.TabIndex = 0
        Me.labelName.Text = "Name:"
        '
        'inputName
        '
        Me.inputName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inputName.Location = New System.Drawing.Point(71, 38)
        Me.inputName.Name = "inputName"
        Me.inputName.Size = New System.Drawing.Size(453, 24)
        Me.inputName.TabIndex = 1
        '
        'labelAddress
        '
        Me.labelAddress.AutoSize = True
        Me.labelAddress.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelAddress.Location = New System.Drawing.Point(12, 71)
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
        Me.inputAddress.Location = New System.Drawing.Point(98, 68)
        Me.inputAddress.Name = "inputAddress"
        Me.inputAddress.Size = New System.Drawing.Size(426, 24)
        Me.inputAddress.TabIndex = 3
        '
        'labelNumber
        '
        Me.labelNumber.AutoSize = True
        Me.labelNumber.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelNumber.Location = New System.Drawing.Point(11, 101)
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
        Me.inputNumber.Location = New System.Drawing.Point(160, 98)
        Me.inputNumber.Name = "inputNumber"
        Me.inputNumber.Size = New System.Drawing.Size(364, 24)
        Me.inputNumber.TabIndex = 5
        '
        'lableEmail
        '
        Me.lableEmail.AutoSize = True
        Me.lableEmail.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lableEmail.Location = New System.Drawing.Point(11, 131)
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
        Me.inputEmail.Location = New System.Drawing.Point(151, 128)
        Me.inputEmail.Name = "inputEmail"
        Me.inputEmail.Size = New System.Drawing.Size(373, 24)
        Me.inputEmail.TabIndex = 7
        '
        'labelSummary
        '
        Me.labelSummary.AutoSize = True
        Me.labelSummary.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelSummary.Location = New System.Drawing.Point(11, 161)
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
        Me.inputSummary.Location = New System.Drawing.Point(11, 181)
        Me.inputSummary.Multiline = True
        Me.inputSummary.Name = "inputSummary"
        Me.inputSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.inputSummary.Size = New System.Drawing.Size(513, 134)
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
        Me.tableEducational.Location = New System.Drawing.Point(13, 340)
        Me.tableEducational.Name = "tableEducational"
        Me.tableEducational.RowTemplate.Height = 25
        Me.tableEducational.Size = New System.Drawing.Size(511, 150)
        Me.tableEducational.TabIndex = 10
        '
        'groupWorkingExperience
        '
        Me.groupWorkingExperience.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupWorkingExperience.Controls.Add(Me.tableExperience)
        Me.groupWorkingExperience.Controls.Add(Me.checkEnableWorkingExperience)
        Me.groupWorkingExperience.Location = New System.Drawing.Point(13, 496)
        Me.groupWorkingExperience.Name = "groupWorkingExperience"
        Me.groupWorkingExperience.Size = New System.Drawing.Size(511, 212)
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
        Me.tableExperience.Enabled = False
        Me.tableExperience.Location = New System.Drawing.Point(7, 49)
        Me.tableExperience.Name = "tableExperience"
        Me.tableExperience.RowTemplate.Height = 25
        Me.tableExperience.Size = New System.Drawing.Size(498, 150)
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
        'checkEnableWorkingExperience
        '
        Me.checkEnableWorkingExperience.AutoSize = True
        Me.checkEnableWorkingExperience.Location = New System.Drawing.Point(7, 23)
        Me.checkEnableWorkingExperience.Name = "checkEnableWorkingExperience"
        Me.checkEnableWorkingExperience.Size = New System.Drawing.Size(61, 19)
        Me.checkEnableWorkingExperience.TabIndex = 0
        Me.checkEnableWorkingExperience.Text = "Enable"
        Me.checkEnableWorkingExperience.UseVisualStyleBackColor = True
        '
        'buttonUploadJSON
        '
        Me.buttonUploadJSON.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonUploadJSON.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buttonUploadJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonUploadJSON.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonUploadJSON.Location = New System.Drawing.Point(454, 9)
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
        Me.buttonGenerateResume.Location = New System.Drawing.Point(427, 714)
        Me.buttonGenerateResume.Name = "buttonGenerateResume"
        Me.buttonGenerateResume.Size = New System.Drawing.Size(157, 23)
        Me.buttonGenerateResume.TabIndex = 13
        Me.buttonGenerateResume.Text = "Generate Resume"
        Me.buttonGenerateResume.UseVisualStyleBackColor = False
        '
        'buttonGenerateJSON
        '
        Me.buttonGenerateJSON.BackColor = System.Drawing.Color.Gray
        Me.buttonGenerateJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.buttonGenerateJSON.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.buttonGenerateJSON.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.buttonGenerateJSON.Location = New System.Drawing.Point(20, 714)
        Me.buttonGenerateJSON.Name = "buttonGenerateJSON"
        Me.buttonGenerateJSON.Size = New System.Drawing.Size(134, 23)
        Me.buttonGenerateJSON.TabIndex = 14
        Me.buttonGenerateJSON.Text = "Generate JSON"
        Me.buttonGenerateJSON.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(221, 748)
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
        Me.buttonAddRowEducational.Location = New System.Drawing.Point(530, 467)
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
        Me.buttonAddRowExperience.Location = New System.Drawing.Point(530, 672)
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
        Me.buttonRemoveRowEducational.Location = New System.Drawing.Point(560, 467)
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
        Me.buttonRemoveRowExperience.Location = New System.Drawing.Point(560, 672)
        Me.buttonRemoveRowExperience.Name = "buttonRemoveRowExperience"
        Me.buttonRemoveRowExperience.Size = New System.Drawing.Size(24, 23)
        Me.buttonRemoveRowExperience.TabIndex = 19
        Me.buttonRemoveRowExperience.Text = "-"
        Me.buttonRemoveRowExperience.UseVisualStyleBackColor = False
        '
        'labelEducationalAttainment
        '
        Me.labelEducationalAttainment.AutoSize = True
        Me.labelEducationalAttainment.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelEducationalAttainment.Location = New System.Drawing.Point(20, 320)
        Me.labelEducationalAttainment.Name = "labelEducationalAttainment"
        Me.labelEducationalAttainment.Size = New System.Drawing.Size(215, 17)
        Me.labelEducationalAttainment.TabIndex = 20
        Me.labelEducationalAttainment.Text = "Educational Attainment:"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(630, 466)
        Me.Controls.Add(Me.labelEducationalAttainment)
        Me.Controls.Add(Me.buttonRemoveRowExperience)
        Me.Controls.Add(Me.buttonRemoveRowEducational)
        Me.Controls.Add(Me.buttonAddRowExperience)
        Me.Controls.Add(Me.buttonAddRowEducational)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonGenerateJSON)
        Me.Controls.Add(Me.buttonGenerateResume)
        Me.Controls.Add(Me.buttonUploadJSON)
        Me.Controls.Add(Me.groupWorkingExperience)
        Me.Controls.Add(Me.tableEducational)
        Me.Controls.Add(Me.inputSummary)
        Me.Controls.Add(Me.labelSummary)
        Me.Controls.Add(Me.inputEmail)
        Me.Controls.Add(Me.lableEmail)
        Me.Controls.Add(Me.inputNumber)
        Me.Controls.Add(Me.labelNumber)
        Me.Controls.Add(Me.inputAddress)
        Me.Controls.Add(Me.labelAddress)
        Me.Controls.Add(Me.inputName)
        Me.Controls.Add(Me.labelName)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resume Maker"
        CType(Me.tableEducational, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupWorkingExperience.ResumeLayout(False)
        Me.groupWorkingExperience.PerformLayout()
        CType(Me.tableExperience, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelName As Label
    Friend WithEvents inputName As TextBox
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
    Friend WithEvents checkEnableWorkingExperience As CheckBox
    Friend WithEvents buttonUploadJSON As Button
    Friend WithEvents buttonGenerateResume As Button
    Friend WithEvents buttonGenerateJSON As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents buttonAddRowEducational As Button
    Friend WithEvents buttonAddRowExperience As Button
    Friend WithEvents buttonRemoveRowEducational As Button
    Friend WithEvents buttonRemoveRowExperience As Button
    Friend WithEvents labelEducationalAttainment As Label
    Friend WithEvents inputSchool As DataGridViewTextBoxColumn
    Friend WithEvents inputDegree As DataGridViewTextBoxColumn
    Friend WithEvents inputYearAttended As DataGridViewTextBoxColumn
End Class
