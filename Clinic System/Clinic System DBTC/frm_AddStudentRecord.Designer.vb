<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AddStudentRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AddStudentRecord))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtAllergies = New System.Windows.Forms.TextBox()
        Me.txtMedication = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtOtherCond = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSignificantMed = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtMedProb = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.date_birth = New System.Windows.Forms.DateTimePicker()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtBirthPlace = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSize = True
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1369, 709)
        Me.Panel1.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(553, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(475, 55)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "MEDICAL RECORD"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1579, 84)
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.cmbGender)
        Me.Panel2.Controls.Add(Me.txtAddress)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.txtGender)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnInsert)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.txtAllergies)
        Me.Panel2.Controls.Add(Me.txtMedication)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.txtOtherCond)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.txtSignificantMed)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtWeight)
        Me.Panel2.Controls.Add(Me.txtMedProb)
        Me.Panel2.Controls.Add(Me.txtHeight)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.date_birth)
        Me.Panel2.Controls.Add(Me.txtState)
        Me.Panel2.Controls.Add(Me.txtContact)
        Me.Panel2.Controls.Add(Me.txtBirthPlace)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtCity)
        Me.Panel2.Controls.Add(Me.txtStreet)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1567, 1473)
        Me.Panel2.TabIndex = 0
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male" & Global.Microsoft.VisualBasic.ChrW(9), "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(753, 480)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(121, 21)
        Me.cmbGender.TabIndex = 175
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtAddress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.txtAddress.Location = New System.Drawing.Point(187, 249)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(240, 26)
        Me.txtAddress.TabIndex = 174
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.Location = New System.Drawing.Point(573, 479)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 19)
        Me.Label24.TabIndex = 173
        Me.Label24.Text = "Gender"
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtGender.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.txtGender.Location = New System.Drawing.Point(636, 476)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(90, 26)
        Me.txtGender.TabIndex = 172
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(534, 637)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(958, 469)
        Me.DataGridView1.TabIndex = 171
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(530, 556)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 19)
        Me.Label2.TabIndex = 168
        Me.Label2.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.txtSearch.Location = New System.Drawing.Point(534, 586)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(472, 26)
        Me.txtSearch.TabIndex = 167
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrint.BackgroundImage = CType(resources.GetObject("btnPrint.BackgroundImage"), System.Drawing.Image)
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(1161, 556)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(117, 56)
        Me.btnPrint.TabIndex = 170
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.SystemColors.Control
        Me.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnInsert.Image = CType(resources.GetObject("btnInsert.Image"), System.Drawing.Image)
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.Location = New System.Drawing.Point(534, 1117)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(128, 56)
        Me.btnInsert.TabIndex = 169
        Me.btnInsert.Text = "Save"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.Location = New System.Drawing.Point(64, 1253)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(170, 19)
        Me.Label23.TabIndex = 164
        Me.Label23.Text = "Other Health Condition:"
        '
        'txtAllergies
        '
        Me.txtAllergies.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtAllergies.Location = New System.Drawing.Point(66, 1116)
        Me.txtAllergies.Multiline = True
        Me.txtAllergies.Name = "txtAllergies"
        Me.txtAllergies.Size = New System.Drawing.Size(416, 83)
        Me.txtAllergies.TabIndex = 163
        '
        'txtMedication
        '
        Me.txtMedication.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtMedication.Location = New System.Drawing.Point(66, 943)
        Me.txtMedication.Multiline = True
        Me.txtMedication.Name = "txtMedication"
        Me.txtMedication.Size = New System.Drawing.Size(416, 83)
        Me.txtMedication.TabIndex = 162
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.Location = New System.Drawing.Point(62, 1089)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(129, 19)
        Me.Label22.TabIndex = 161
        Me.Label22.Text = "List any allergies:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(62, 921)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(250, 19)
        Me.Label21.TabIndex = 160
        Me.Label21.Text = "List any medication taken regularly:"
        '
        'txtOtherCond
        '
        Me.txtOtherCond.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtOtherCond.Location = New System.Drawing.Point(66, 1273)
        Me.txtOtherCond.Multiline = True
        Me.txtOtherCond.Name = "txtOtherCond"
        Me.txtOtherCond.Size = New System.Drawing.Size(416, 83)
        Me.txtOtherCond.TabIndex = 159
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(62, 747)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(395, 19)
        Me.Label15.TabIndex = 158
        Me.Label15.Text = "List any Medical Problems (asthma, seizures, headaches):"
        '
        'txtSignificantMed
        '
        Me.txtSignificantMed.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtSignificantMed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignificantMed.Location = New System.Drawing.Point(66, 591)
        Me.txtSignificantMed.Multiline = True
        Me.txtSignificantMed.Name = "txtSignificantMed"
        Me.txtSignificantMed.Size = New System.Drawing.Size(416, 83)
        Me.txtSignificantMed.TabIndex = 157
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(62, 569)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(420, 19)
        Me.Label11.TabIndex = 156
        Me.Label11.Text = "Significant Medical History (surgery, injuries, serious illness):"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(480, 479)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 19)
        Me.Label20.TabIndex = 137
        Me.Label20.Text = "KG"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(207, 479)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(36, 19)
        Me.Label19.TabIndex = 136
        Me.Label19.Text = "CM"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(33, 537)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(236, 19)
        Me.Label18.TabIndex = 135
        Me.Label18.Text = "Please Fill the condition you have:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(13, 417)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(314, 36)
        Me.Label17.TabIndex = 134
        Me.Label17.Text = "Past Medical History:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(221, 36)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Patient Record"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtWeight.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.txtWeight.Location = New System.Drawing.Point(381, 476)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(90, 26)
        Me.txtWeight.TabIndex = 130
        '
        'txtMedProb
        '
        Me.txtMedProb.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtMedProb.Location = New System.Drawing.Point(66, 775)
        Me.txtMedProb.Multiline = True
        Me.txtMedProb.Name = "txtMedProb"
        Me.txtMedProb.Size = New System.Drawing.Size(416, 83)
        Me.txtMedProb.TabIndex = 104
        '
        'txtHeight
        '
        Me.txtHeight.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtHeight.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.txtHeight.Location = New System.Drawing.Point(111, 476)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(90, 26)
        Me.txtHeight.TabIndex = 111
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(319, 479)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 19)
        Me.Label16.TabIndex = 129
        Me.Label16.Text = "Weight"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(51, 479)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 19)
        Me.Label12.TabIndex = 127
        Me.Label12.Text = "Height"
        '
        'date_birth
        '
        Me.date_birth.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.date_birth.Location = New System.Drawing.Point(732, 284)
        Me.date_birth.Name = "date_birth"
        Me.date_birth.Size = New System.Drawing.Size(284, 26)
        Me.date_birth.TabIndex = 20
        '
        'txtState
        '
        Me.txtState.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtState.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.txtState.Location = New System.Drawing.Point(732, 337)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(240, 26)
        Me.txtState.TabIndex = 17
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtContact.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.txtContact.Location = New System.Drawing.Point(732, 190)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(240, 26)
        Me.txtContact.TabIndex = 16
        '
        'txtBirthPlace
        '
        Me.txtBirthPlace.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtBirthPlace.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.txtBirthPlace.Location = New System.Drawing.Point(732, 238)
        Me.txtBirthPlace.Name = "txtBirthPlace"
        Me.txtBirthPlace.Size = New System.Drawing.Size(240, 26)
        Me.txtBirthPlace.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(664, 344)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 19)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "STATE:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(583, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 19)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "PLACE OF BIRTH:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(592, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "DATE OF BIRTH:"
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtCity.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.txtCity.Location = New System.Drawing.Point(187, 344)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(240, 26)
        Me.txtCity.TabIndex = 9
        '
        'txtStreet
        '
        Me.txtStreet.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtStreet.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.txtStreet.Location = New System.Drawing.Point(187, 292)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(240, 26)
        Me.txtStreet.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.txtName.Location = New System.Drawing.Point(187, 190)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(240, 26)
        Me.txtName.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(131, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CITY:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(107, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "STREET:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(505, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TELEPHONE CONTACT No. :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(27, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PATIENT ADDRESS:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(48, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PATIENT NAME:"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frm_AddStudentRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 709)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_AddStudentRecord"
        Me.Text = "Add Student Record"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents txtAllergies As TextBox
    Friend WithEvents txtMedication As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtOtherCond As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSignificantMed As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtMedProb As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents date_birth As DateTimePicker
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtBirthPlace As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
