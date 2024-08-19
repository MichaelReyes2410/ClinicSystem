<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_UserDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_UserDashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGuest = New System.Windows.Forms.Button()
        Me.btnAddPnt = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnBed = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        Me.Panel1.Controls.Add(Me.btnAddPnt)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnBed)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 831)
        Me.Panel1.TabIndex = 2
        '
        'btnGuest
        '
        Me.btnGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle
        Me.btnGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle
        Me.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuest.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnGuest.Image = CType(resources.GetObject("btnGuest.Image"), System.Drawing.Image)
        Me.btnGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuest.Location = New System.Drawing.Point(12, 424)
        Me.btnGuest.Name = "btnGuest"
        Me.btnGuest.Size = New System.Drawing.Size(142, 61)
        Me.btnGuest.TabIndex = 11
        Me.btnGuest.Text = "GUEST LOGBOOK"
        Me.btnGuest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuest.UseVisualStyleBackColor = True
        '
        'btnAddPnt
        '
        Me.btnAddPnt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
        Me.btnAddPnt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnAddPnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPnt.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnAddPnt.Image = CType(resources.GetObject("btnAddPnt.Image"), System.Drawing.Image)
        Me.btnAddPnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddPnt.Location = New System.Drawing.Point(12, 331)
        Me.btnAddPnt.Name = "btnAddPnt"
        Me.btnAddPnt.Size = New System.Drawing.Size(142, 61)
        Me.btnAddPnt.TabIndex = 10
        Me.btnAddPnt.Text = "PATIENTS LOGBOOK"
        Me.btnAddPnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddPnt.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Clinic_System_DBTC.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 129)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.White
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(27, 766)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(127, 54)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.UseVisualStyleBackColor = False
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
        Me.btnBed.Location = New System.Drawing.Point(12, 238)
        Me.btnBed.Name = "btnBed"
        Me.btnBed.Size = New System.Drawing.Size(142, 61)
        Me.btnBed.TabIndex = 2
        Me.btnBed.Text = "LOGS"
        Me.btnBed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBed.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Stencil", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1033, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome to Don Bosco Technical College School!!"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(175, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1385, 748)
        Me.Panel2.TabIndex = 6
        '
        'frm_UserDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 831)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_UserDashboard"
        Me.Text = "User Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGuest As Button
    Friend WithEvents btnAddPnt As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnBed As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
End Class
