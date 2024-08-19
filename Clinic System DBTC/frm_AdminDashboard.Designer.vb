<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AdminDashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGuest = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnBackupDB = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAddPnt = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnCollege = New System.Windows.Forms.Button()
        Me.btnBed = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.Clinic_System_DBTC.My.Resources.Resources.Presentation1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.btnGuest)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.btnBackupDB)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnAddPnt)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnEmployee)
        Me.Panel1.Controls.Add(Me.btnCollege)
        Me.Panel1.Controls.Add(Me.btnBed)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 810)
        Me.Panel1.TabIndex = 1
        '
        'btnGuest
        '
        Me.btnGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle
        Me.btnGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle
        Me.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuest.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnGuest.Image = CType(resources.GetObject("btnGuest.Image"), System.Drawing.Image)
        Me.btnGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuest.Location = New System.Drawing.Point(12, 509)
        Me.btnGuest.Name = "btnGuest"
        Me.btnGuest.Size = New System.Drawing.Size(142, 61)
        Me.btnGuest.TabIndex = 17
        Me.btnGuest.Text = "GUEST LOGBOOK"
        Me.btnGuest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuest.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1321, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 29)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "DATE:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(1414, 28)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(31, 29)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "..."
        '
        'btnBackupDB
        '
        Me.btnBackupDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.btnBackupDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen
        Me.btnBackupDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackupDB.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnBackupDB.Image = CType(resources.GetObject("btnBackupDB.Image"), System.Drawing.Image)
        Me.btnBackupDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackupDB.Location = New System.Drawing.Point(12, 647)
        Me.btnBackupDB.Name = "btnBackupDB"
        Me.btnBackupDB.Size = New System.Drawing.Size(142, 61)
        Me.btnBackupDB.TabIndex = 13
        Me.btnBackupDB.Text = "BACKUP DATABASE"
        Me.btnBackupDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBackupDB.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Stencil", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(910, 46)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Don Bosco Technical College, Hello Admin!!"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Clinic_System_DBTC.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 129)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnAddPnt
        '
        Me.btnAddPnt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnAddPnt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnAddPnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPnt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnAddPnt.Image = CType(resources.GetObject("btnAddPnt.Image"), System.Drawing.Image)
        Me.btnAddPnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddPnt.Location = New System.Drawing.Point(12, 430)
        Me.btnAddPnt.Name = "btnAddPnt"
        Me.btnAddPnt.Size = New System.Drawing.Size(142, 61)
        Me.btnAddPnt.TabIndex = 9
        Me.btnAddPnt.Text = "PATIENTS LOGBOOK"
        Me.btnAddPnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddPnt.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.White
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnLogout.Image = Global.Clinic_System_DBTC.My.Resources.Resources.logout
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(27, 749)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnLogout.Size = New System.Drawing.Size(127, 51)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnEmployee
        '
        Me.btnEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink
        Me.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnEmployee.Image = CType(resources.GetObject("btnEmployee.Image"), System.Drawing.Image)
        Me.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployee.Location = New System.Drawing.Point(12, 352)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(142, 61)
        Me.btnEmployee.TabIndex = 5
        Me.btnEmployee.Text = "REPORTS"
        Me.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnCollege
        '
        Me.btnCollege.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin
        Me.btnCollege.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin
        Me.btnCollege.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCollege.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnCollege.Image = CType(resources.GetObject("btnCollege.Image"), System.Drawing.Image)
        Me.btnCollege.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCollege.Location = New System.Drawing.Point(12, 270)
        Me.btnCollege.Name = "btnCollege"
        Me.btnCollege.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCollege.Size = New System.Drawing.Size(142, 65)
        Me.btnCollege.TabIndex = 3
        Me.btnCollege.Text = "TIMEIN /" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " TIMOUT"
        Me.btnCollege.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCollege.UseVisualStyleBackColor = True
        '
        'btnBed
        '
        Me.btnBed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.btnBed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnBed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBed.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnBed.Image = CType(resources.GetObject("btnBed.Image"), System.Drawing.Image)
        Me.btnBed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBed.Location = New System.Drawing.Point(12, 187)
        Me.btnBed.Name = "btnBed"
        Me.btnBed.Size = New System.Drawing.Size(142, 61)
        Me.btnBed.TabIndex = 2
        Me.btnBed.Text = "MEDICAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RECORD"
        Me.btnBed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBed.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Location = New System.Drawing.Point(175, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1385, 748)
        Me.Panel2.TabIndex = 6
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frm_AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 810)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_AdminDashboard"
        Me.Text = "Admin Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGuest As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnBackupDB As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAddPnt As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnCollege As Button
    Friend WithEvents btnBed As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer1 As Timer
End Class
