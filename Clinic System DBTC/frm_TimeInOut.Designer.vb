<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_TimeInOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_TimeInOut))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTimeInOut = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(20, 314)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1214, 363)
        Me.DataGridView1.TabIndex = 172
        '
        'txtStudentId
        '
        Me.txtStudentId.Location = New System.Drawing.Point(203, 269)
        Me.txtStudentId.Multiline = True
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(480, 30)
        Me.txtStudentId.TabIndex = 170
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(54, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 19)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "Search School ID:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(410, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(498, 55)
        Me.Label10.TabIndex = 175
        Me.Label10.Text = "TIME IN / TIME OUT"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1052, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 29)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "..."
        Me.Label1.Visible = False
        '
        'btnTimeInOut
        '
        Me.btnTimeInOut.BackColor = System.Drawing.SystemColors.Control
        Me.btnTimeInOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTimeInOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnTimeInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeInOut.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnTimeInOut.Image = CType(resources.GetObject("btnTimeInOut.Image"), System.Drawing.Image)
        Me.btnTimeInOut.Location = New System.Drawing.Point(703, 206)
        Me.btnTimeInOut.Name = "btnTimeInOut"
        Me.btnTimeInOut.Size = New System.Drawing.Size(179, 93)
        Me.btnTimeInOut.TabIndex = 171
        Me.btnTimeInOut.Text = "CLICK " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TIME IN / TIMEOUT"
        Me.btnTimeInOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnTimeInOut.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(-60, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1489, 84)
        Me.PictureBox1.TabIndex = 174
        Me.PictureBox1.TabStop = False
        '
        'frm_TimeInOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 709)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTimeInOut)
        Me.Controls.Add(Me.txtStudentId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frm_TimeInOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TimeIn & TimeOut"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnTimeInOut As Button
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
