<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AddReportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AddReportForm))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnMonthly = New System.Windows.Forms.Button()
        Me.btnWeekly = New System.Windows.Forms.Button()
        Me.btnDaily = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMonthly
        '
        Me.btnMonthly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMonthly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonthly.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnMonthly.Image = CType(resources.GetObject("btnMonthly.Image"), System.Drawing.Image)
        Me.btnMonthly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMonthly.Location = New System.Drawing.Point(880, 97)
        Me.btnMonthly.Name = "btnMonthly"
        Me.btnMonthly.Size = New System.Drawing.Size(152, 70)
        Me.btnMonthly.TabIndex = 2
        Me.btnMonthly.Text = "MONTHLY"
        Me.btnMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMonthly.UseVisualStyleBackColor = True
        '
        'btnWeekly
        '
        Me.btnWeekly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnWeekly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeekly.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnWeekly.Image = CType(resources.GetObject("btnWeekly.Image"), System.Drawing.Image)
        Me.btnWeekly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWeekly.Location = New System.Drawing.Point(589, 97)
        Me.btnWeekly.Name = "btnWeekly"
        Me.btnWeekly.Size = New System.Drawing.Size(143, 70)
        Me.btnWeekly.TabIndex = 1
        Me.btnWeekly.Text = "WEEKLY"
        Me.btnWeekly.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnWeekly.UseVisualStyleBackColor = True
        '
        'btnDaily
        '
        Me.btnDaily.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.btnDaily.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.btnDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDaily.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!)
        Me.btnDaily.Image = CType(resources.GetObject("btnDaily.Image"), System.Drawing.Image)
        Me.btnDaily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDaily.Location = New System.Drawing.Point(276, 97)
        Me.btnDaily.Name = "btnDaily"
        Me.btnDaily.Size = New System.Drawing.Size(143, 70)
        Me.btnDaily.TabIndex = 0
        Me.btnDaily.Text = "DAILY"
        Me.btnDaily.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDaily.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(51, 188)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1181, 194)
        Me.DataGridView1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PictureBox1.Location = New System.Drawing.Point(-20, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1473, 84)
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(520, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 55)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "REPORTS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(948, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 39)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Load Chart"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Chart1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.btnDaily)
        Me.Panel1.Controls.Add(Me.btnWeekly)
        Me.Panel1.Controls.Add(Me.btnMonthly)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1369, 749)
        Me.Panel1.TabIndex = 5
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(51, 423)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series1.Legend = "Legend1"
        Series1.Name = "AGE_VS_REASON"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(856, 300)
        Me.Chart1.TabIndex = 76
        Me.Chart1.Text = "Chart1"
        '
        'frm_AddReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1369, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_AddReportForm"
        Me.Text = "v"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMonthly As Button
    Friend WithEvents btnWeekly As Button
    Friend WithEvents btnDaily As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
