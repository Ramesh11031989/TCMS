<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class poomsae_display_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Me.Hide()
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(poomsae_display_form))
        Me.poomsea_type2_label = New System.Windows.Forms.Label()
        Me.timer_display_output = New System.Windows.Forms.TextBox()
        Me.name_label = New System.Windows.Forms.Label()
        Me.nation_state_district_label = New System.Windows.Forms.Label()
        Me.time_ended_1_label = New System.Windows.Forms.Label()
        Me.age_group_label = New System.Windows.Forms.Label()
        Me.name_of_1st_poomsae_label = New System.Windows.Forms.Label()
        Me.name_of_2st_poomsae_label = New System.Windows.Forms.Label()
        Me.time_ended_2_label = New System.Windows.Forms.Label()
        Me.score_poomse_1_label = New System.Windows.Forms.Label()
        Me.score_poomse_2_label = New System.Windows.Forms.Label()
        Me.final_score_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.disqualified_label = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'poomsea_type2_label
        '
        Me.poomsea_type2_label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.poomsea_type2_label.BackColor = System.Drawing.Color.Red
        Me.poomsea_type2_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.poomsea_type2_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.poomsea_type2_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poomsea_type2_label.ForeColor = System.Drawing.Color.White
        Me.poomsea_type2_label.Location = New System.Drawing.Point(779, 85)
        Me.poomsea_type2_label.Name = "poomsea_type2_label"
        Me.poomsea_type2_label.Size = New System.Drawing.Size(193, 83)
        Me.poomsea_type2_label.TabIndex = 0
        Me.poomsea_type2_label.Text = "Individual"
        Me.poomsea_type2_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'timer_display_output
        '
        Me.timer_display_output.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timer_display_output.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.timer_display_output.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.timer_display_output.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.timer_display_output.Enabled = False
        Me.timer_display_output.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timer_display_output.ForeColor = System.Drawing.Color.White
        Me.timer_display_output.Location = New System.Drawing.Point(897, 526)
        Me.timer_display_output.Margin = New System.Windows.Forms.Padding(0)
        Me.timer_display_output.Name = "timer_display_output"
        Me.timer_display_output.Size = New System.Drawing.Size(322, 91)
        Me.timer_display_output.TabIndex = 1
        Me.timer_display_output.TabStop = False
        Me.timer_display_output.Text = "00:00:00"
        Me.timer_display_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'name_label
        '
        Me.name_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.name_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_label.ForeColor = System.Drawing.Color.White
        Me.name_label.Location = New System.Drawing.Point(17, 85)
        Me.name_label.Name = "name_label"
        Me.name_label.Size = New System.Drawing.Size(487, 83)
        Me.name_label.TabIndex = 2
        Me.name_label.Text = "Player Name"
        Me.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nation_state_district_label
        '
        Me.nation_state_district_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nation_state_district_label.ForeColor = System.Drawing.Color.White
        Me.nation_state_district_label.Location = New System.Drawing.Point(541, 85)
        Me.nation_state_district_label.Name = "nation_state_district_label"
        Me.nation_state_district_label.Size = New System.Drawing.Size(232, 83)
        Me.nation_state_district_label.TabIndex = 3
        Me.nation_state_district_label.Text = "Nation/State/District"
        Me.nation_state_district_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'time_ended_1_label
        '
        Me.time_ended_1_label.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.time_ended_1_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.time_ended_1_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_ended_1_label.ForeColor = System.Drawing.Color.Lime
        Me.time_ended_1_label.Location = New System.Drawing.Point(305, 96)
        Me.time_ended_1_label.Name = "time_ended_1_label"
        Me.time_ended_1_label.Size = New System.Drawing.Size(164, 47)
        Me.time_ended_1_label.TabIndex = 4
        Me.time_ended_1_label.Text = "00:00:00"
        Me.time_ended_1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'age_group_label
        '
        Me.age_group_label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.age_group_label.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.age_group_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.age_group_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age_group_label.ForeColor = System.Drawing.Color.White
        Me.age_group_label.Location = New System.Drawing.Point(978, 85)
        Me.age_group_label.Name = "age_group_label"
        Me.age_group_label.Size = New System.Drawing.Size(274, 83)
        Me.age_group_label.TabIndex = 5
        Me.age_group_label.Text = "Under 65   (61 - 65)"
        Me.age_group_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'name_of_1st_poomsae_label
        '
        Me.name_of_1st_poomsae_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_of_1st_poomsae_label.ForeColor = System.Drawing.Color.Yellow
        Me.name_of_1st_poomsae_label.Location = New System.Drawing.Point(10, 51)
        Me.name_of_1st_poomsae_label.Name = "name_of_1st_poomsae_label"
        Me.name_of_1st_poomsae_label.Size = New System.Drawing.Size(289, 125)
        Me.name_of_1st_poomsae_label.TabIndex = 6
        Me.name_of_1st_poomsae_label.Text = "Name of 1st Poomsae"
        Me.name_of_1st_poomsae_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'name_of_2st_poomsae_label
        '
        Me.name_of_2st_poomsae_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_of_2st_poomsae_label.ForeColor = System.Drawing.Color.Yellow
        Me.name_of_2st_poomsae_label.Location = New System.Drawing.Point(-6, 49)
        Me.name_of_2st_poomsae_label.Name = "name_of_2st_poomsae_label"
        Me.name_of_2st_poomsae_label.Size = New System.Drawing.Size(305, 133)
        Me.name_of_2st_poomsae_label.TabIndex = 7
        Me.name_of_2st_poomsae_label.Text = "Name of 2nd Poomsae"
        Me.name_of_2st_poomsae_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'time_ended_2_label
        '
        Me.time_ended_2_label.BackColor = System.Drawing.Color.Red
        Me.time_ended_2_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.time_ended_2_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_ended_2_label.ForeColor = System.Drawing.Color.Lime
        Me.time_ended_2_label.Location = New System.Drawing.Point(305, 94)
        Me.time_ended_2_label.Name = "time_ended_2_label"
        Me.time_ended_2_label.Size = New System.Drawing.Size(164, 44)
        Me.time_ended_2_label.TabIndex = 8
        Me.time_ended_2_label.Text = "00:00:00"
        Me.time_ended_2_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'score_poomse_1_label
        '
        Me.score_poomse_1_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 75.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score_poomse_1_label.ForeColor = System.Drawing.Color.Lime
        Me.score_poomse_1_label.Location = New System.Drawing.Point(596, 39)
        Me.score_poomse_1_label.Name = "score_poomse_1_label"
        Me.score_poomse_1_label.Size = New System.Drawing.Size(262, 163)
        Me.score_poomse_1_label.TabIndex = 9
        Me.score_poomse_1_label.Text = "0.00"
        Me.score_poomse_1_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'score_poomse_2_label
        '
        Me.score_poomse_2_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 75.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score_poomse_2_label.ForeColor = System.Drawing.Color.Lime
        Me.score_poomse_2_label.Location = New System.Drawing.Point(596, 38)
        Me.score_poomse_2_label.Name = "score_poomse_2_label"
        Me.score_poomse_2_label.Size = New System.Drawing.Size(265, 152)
        Me.score_poomse_2_label.TabIndex = 10
        Me.score_poomse_2_label.Text = "0.00"
        Me.score_poomse_2_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'final_score_label
        '
        Me.final_score_label.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.final_score_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.final_score_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 115.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.final_score_label.ForeColor = System.Drawing.Color.Yellow
        Me.final_score_label.Location = New System.Drawing.Point(865, 287)
        Me.final_score_label.Margin = New System.Windows.Forms.Padding(0)
        Me.final_score_label.Name = "final_score_label"
        Me.final_score_label.Size = New System.Drawing.Size(378, 239)
        Me.final_score_label.TabIndex = 11
        Me.final_score_label.Text = "0.00"
        Me.final_score_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(1, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1262, 78)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Poomsae"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Blue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(289, 32)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Name of 1st Poomsae"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(289, 33)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Name of 2nd Poomsae"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Blue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(305, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 32)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Time Ended"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Blue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(632, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 32)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "1st Score"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Red
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(305, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 33)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Time Ended"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Red
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(632, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 32)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "2nd Score"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.Yellow
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(992, 226)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 32)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Final Score"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Viner Hand ITC", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(-2, 617)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1265, 44)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "        Taekwondo Association Allahabad"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel1.Controls.Add(Me.time_ended_1_label)
        Me.Panel1.Controls.Add(Me.name_of_1st_poomsae_label)
        Me.Panel1.Controls.Add(Me.score_poomse_1_label)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(12, 171)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(837, 202)
        Me.Panel1.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.name_of_2st_poomsae_label)
        Me.Panel2.Controls.Add(Me.time_ended_2_label)
        Me.Panel2.Controls.Add(Me.score_poomse_2_label)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(12, 400)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(837, 190)
        Me.Panel2.TabIndex = 26
        '
        'disqualified_label
        '
        Me.disqualified_label.AutoSize = True
        Me.disqualified_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 90.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disqualified_label.ForeColor = System.Drawing.Color.Red
        Me.disqualified_label.Location = New System.Drawing.Point(5, 314)
        Me.disqualified_label.Name = "disqualified_label"
        Me.disqualified_label.Size = New System.Drawing.Size(827, 135)
        Me.disqualified_label.TabIndex = 21
        Me.disqualified_label.Text = "Disqualified !!!"
        Me.disqualified_label.Visible = False
        '
        'poomsae_display_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1264, 661)
        Me.Controls.Add(Me.disqualified_label)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.final_score_label)
        Me.Controls.Add(Me.age_group_label)
        Me.Controls.Add(Me.nation_state_district_label)
        Me.Controls.Add(Me.name_label)
        Me.Controls.Add(Me.timer_display_output)
        Me.Controls.Add(Me.poomsea_type2_label)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "poomsae_display_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Taekwondo Championship Management System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents poomsea_type2_label As Label
    Public WithEvents timer_display_output As TextBox
    Public WithEvents name_label As Label
    Public WithEvents nation_state_district_label As Label
    Public WithEvents time_ended_1_label As Label
    Public WithEvents age_group_label As Label
    Public WithEvents name_of_1st_poomsae_label As Label
    Public WithEvents name_of_2st_poomsae_label As Label
    Public WithEvents time_ended_2_label As Label
    Public WithEvents score_poomse_1_label As Label
    Public WithEvents score_poomse_2_label As Label
    Public WithEvents final_score_label As Label
    Friend WithEvents Label1 As Label
    Public WithEvents Label4 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label8 As Label
    Public WithEvents Label9 As Label
    Public WithEvents Label10 As Label
    Public WithEvents Label11 As Label
    Public WithEvents Label12 As Label
    Public WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents disqualified_label As Label
End Class
