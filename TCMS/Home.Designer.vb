<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.kyorugi_button = New System.Windows.Forms.Button()
        Me.poomsae_button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.age_category_textbox = New System.Windows.Forms.TextBox()
        Me.vanue_textbox = New System.Windows.Forms.TextBox()
        Me.origanized_by_textbox = New System.Windows.Forms.TextBox()
        Me.name_of_championship_textbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Comptition_Date_To_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Comptition_Date_From_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Data_Entry_kyorugi_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'kyorugi_button
        '
        Me.kyorugi_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kyorugi_button.Location = New System.Drawing.Point(337, 182)
        Me.kyorugi_button.Name = "kyorugi_button"
        Me.kyorugi_button.Size = New System.Drawing.Size(302, 59)
        Me.kyorugi_button.TabIndex = 0
        Me.kyorugi_button.Text = "Kyorugi (Sparring)"
        Me.kyorugi_button.UseVisualStyleBackColor = True
        '
        'poomsae_button
        '
        Me.poomsae_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poomsae_button.Location = New System.Drawing.Point(337, 283)
        Me.poomsae_button.Name = "poomsae_button"
        Me.poomsae_button.Size = New System.Drawing.Size(302, 59)
        Me.poomsae_button.TabIndex = 1
        Me.poomsae_button.Text = "Poomsae"
        Me.poomsae_button.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.CausesValidation = False
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.age_category_textbox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.vanue_textbox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.origanized_by_textbox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.name_of_championship_textbox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Comptition_Date_To_DateTimePicker, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Comptition_Date_From_DateTimePicker, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(774, 103)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(446, 425)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Label1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Championship Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 50)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name of Championship"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 50)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Origanized By"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'age_category_textbox
        '
        Me.age_category_textbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.age_category_textbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.age_category_textbox.Location = New System.Drawing.Point(233, 230)
        Me.age_category_textbox.Name = "age_category_textbox"
        Me.age_category_textbox.Size = New System.Drawing.Size(200, 20)
        Me.age_category_textbox.TabIndex = 4
        '
        'vanue_textbox
        '
        Me.vanue_textbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.vanue_textbox.AutoCompleteCustomSource.AddRange(New String() {"Andhra Pradesh (AP)", "Arunachal Pradesh (AR)", "Assam (AS)", "Bihar (BR)", "Chhattisgarh (CG)", "Goa (GA)", "Gujarat (GJ)", "Haryana (HR)", "Himachal Pradesh (HP)", "Jammu and Kashmir (JK)", "Jharkhand (JH)", "Karnataka (KA)", "Kerala (KL)", "Madhya Pradesh (MP)", "Maharashtra (MH)", "Manipur (MN)", "Meghalaya (ML)", "Mizoram (MZ)", "Nagaland (NL)", "Odisha(OR)", "Punjab (PB)", "Rajasthan (RJ)", "Sikkim (SK)", "Tamil Nadu (TN)", "Telangana (TS)", "Tripura (TR)", "Uttar Pradesh (UP)", "Uttarakhand (UK)", "West Bengal (WB)", "Andaman and Nicobar Islands(AN)", "Chandigarh (CH)", "Dadra and Nagar Haveli (DN)", "Daman and Diu (DD)", "National Capital Territory of Delhi (DL)", "Lakshadweep (LD)", "Pondicherry (PY)", "Agra", "Aligarh", "Allahabad", "Ambedkar Nagar", "Amethi (Chatrapati Sahuji Mahraj Nagar)", "Amroha (J.P. Nagar)", "Auraiya", "Azamgarh", "Baghpat", "Bahraich", "Ballia", "Balrampur", "Banda", "Barabanki", "Bareilly", "Basti", "Bhadohi", "Bijnor", "Budaun", "Bulandshahr", "Chandauli", "Chitrakoot", "Deoria", "Etah", "Etawah", "Faizabad", "Farrukhabad", "Fatehpur", "Firozabad", "Gautam Buddha Nagar", "Ghaziabad", "Ghazipur", "Gonda", "Gorakhpur", "Hamirpur", "Collapse Hapur (Panchsheel Nagar)", "Hardoi", "Hathras", "Jalaun", "Jaunpur", "Jhansi", "Kannauj", "Kanpur Dehat", "Kanpur Nagar", "Kanshiram Nagar (Kasganj)", "Kaushambi", "Kushinagar (Padrauna)", "Lakhimpur - Kheri", "Lalitpur", "Lucknow", "Maharajganj", "Mahoba", "Mainpuri", "Mathura", "Mau", "Meerut", "Mirzapur", "Moradabad", "Muzaffarnagar", "Pilibhit", "Pratapgarh", "RaeBareli", "Rampur", "Saharanpur", "Collapse Sambhal (Bhim Nagar)", "Sant Kabir Nagar", "Shahjahanpur", "Collapse Shamali (Prabuddh Nagar)", "Shravasti", "Siddharth Nagar", "Sitapur", "Sonbhadra", "Sultanpur", "Unnao", "Varanasi"})
        Me.vanue_textbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.vanue_textbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.vanue_textbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.vanue_textbox.Location = New System.Drawing.Point(233, 177)
        Me.vanue_textbox.Name = "vanue_textbox"
        Me.vanue_textbox.Size = New System.Drawing.Size(200, 20)
        Me.vanue_textbox.TabIndex = 3
        '
        'origanized_by_textbox
        '
        Me.origanized_by_textbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.origanized_by_textbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.origanized_by_textbox.Location = New System.Drawing.Point(233, 124)
        Me.origanized_by_textbox.Name = "origanized_by_textbox"
        Me.origanized_by_textbox.Size = New System.Drawing.Size(200, 20)
        Me.origanized_by_textbox.TabIndex = 2
        '
        'name_of_championship_textbox
        '
        Me.name_of_championship_textbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.name_of_championship_textbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.name_of_championship_textbox.Location = New System.Drawing.Point(233, 71)
        Me.name_of_championship_textbox.Name = "name_of_championship_textbox"
        Me.name_of_championship_textbox.Size = New System.Drawing.Size(200, 20)
        Me.name_of_championship_textbox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 50)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Vanue"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 50)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Age Category"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 45)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Comptition Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Comptition_Date_To_DateTimePicker
        '
        Me.Comptition_Date_To_DateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Comptition_Date_To_DateTimePicker.Location = New System.Drawing.Point(233, 389)
        Me.Comptition_Date_To_DateTimePicker.MinDate = New Date(2018, 9, 7, 18, 50, 35, 0)
        Me.Comptition_Date_To_DateTimePicker.Name = "Comptition_Date_To_DateTimePicker"
        Me.Comptition_Date_To_DateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Comptition_Date_To_DateTimePicker.TabIndex = 6
        Me.Comptition_Date_To_DateTimePicker.Value = New Date(2018, 9, 7, 18, 50, 35, 0)
        '
        'Comptition_Date_From_DateTimePicker
        '
        Me.Comptition_Date_From_DateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Comptition_Date_From_DateTimePicker.Location = New System.Drawing.Point(233, 283)
        Me.Comptition_Date_From_DateTimePicker.MinDate = New Date(2018, 9, 7, 18, 50, 35, 0)
        Me.Comptition_Date_From_DateTimePicker.Name = "Comptition_Date_From_DateTimePicker"
        Me.Comptition_Date_From_DateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Comptition_Date_From_DateTimePicker.TabIndex = 5
        Me.Comptition_Date_From_DateTimePicker.Value = New Date(2018, 9, 7, 18, 50, 35, 0)
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(227, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 50)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "To"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Data_Entry_kyorugi_Button
        '
        Me.Data_Entry_kyorugi_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_Entry_kyorugi_Button.Location = New System.Drawing.Point(37, 74)
        Me.Data_Entry_kyorugi_Button.Name = "Data_Entry_kyorugi_Button"
        Me.Data_Entry_kyorugi_Button.Size = New System.Drawing.Size(227, 50)
        Me.Data_Entry_kyorugi_Button.TabIndex = 3
        Me.Data_Entry_kyorugi_Button.Text = "Kyorugi Players Data Entry"
        Me.Data_Entry_kyorugi_Button.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 661)
        Me.Controls.Add(Me.Data_Entry_kyorugi_Button)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.poomsae_button)
        Me.Controls.Add(Me.kyorugi_button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Taekwondo Championship Management System"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents kyorugi_button As Button
    Friend WithEvents poomsae_button As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents name_of_championship_textbox As TextBox
    Friend WithEvents origanized_by_textbox As TextBox
    Friend WithEvents vanue_textbox As TextBox
    Friend WithEvents age_category_textbox As TextBox
    Friend WithEvents Comptition_Date_To_DateTimePicker As DateTimePicker
    Friend WithEvents Comptition_Date_From_DateTimePicker As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Data_Entry_kyorugi_Button As Button
End Class
