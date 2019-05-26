<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class data_entry_kyorugi_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(data_entry_kyorugi_form))
        Me.Load_data_Button = New System.Windows.Forms.Button()
        Me.Add_Data_Button = New System.Windows.Forms.Button()
        Me.Save_Data_Button = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.data_entry_kyorugi_form_back_Button = New System.Windows.Forms.Button()
        Me.Boys_Label = New System.Windows.Forms.Label()
        Me.Girls_Label = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Print_Preview_Boys_Data_Button = New System.Windows.Forms.Button()
        Me.Print_Preview_Girls_Data_Button = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Print_Boys_Data_Button = New System.Windows.Forms.Button()
        Me.Print_Girls_Data_Button = New System.Windows.Forms.Button()
        Me.generate_category_Button = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Load_data_Button
        '
        Me.Load_data_Button.Location = New System.Drawing.Point(12, 135)
        Me.Load_data_Button.Name = "Load_data_Button"
        Me.Load_data_Button.Size = New System.Drawing.Size(107, 23)
        Me.Load_data_Button.TabIndex = 0
        Me.Load_data_Button.Text = "Load data"
        Me.Load_data_Button.UseVisualStyleBackColor = True
        '
        'Add_Data_Button
        '
        Me.Add_Data_Button.Location = New System.Drawing.Point(12, 196)
        Me.Add_Data_Button.Name = "Add_Data_Button"
        Me.Add_Data_Button.Size = New System.Drawing.Size(107, 23)
        Me.Add_Data_Button.TabIndex = 1
        Me.Add_Data_Button.Text = "Add Data"
        Me.Add_Data_Button.UseVisualStyleBackColor = True
        '
        'Save_Data_Button
        '
        Me.Save_Data_Button.Location = New System.Drawing.Point(12, 73)
        Me.Save_Data_Button.Name = "Save_Data_Button"
        Me.Save_Data_Button.Size = New System.Drawing.Size(107, 23)
        Me.Save_Data_Button.TabIndex = 2
        Me.Save_Data_Button.Text = "Save Data"
        Me.Save_Data_Button.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(140, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(552, 556)
        Me.DataGridView1.TabIndex = 3
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 267)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 320)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 20)
        Me.TextBox1.TabIndex = 5
        '
        'data_entry_kyorugi_form_back_Button
        '
        Me.data_entry_kyorugi_form_back_Button.Location = New System.Drawing.Point(12, 597)
        Me.data_entry_kyorugi_form_back_Button.Name = "data_entry_kyorugi_form_back_Button"
        Me.data_entry_kyorugi_form_back_Button.Size = New System.Drawing.Size(107, 23)
        Me.data_entry_kyorugi_form_back_Button.TabIndex = 6
        Me.data_entry_kyorugi_form_back_Button.Text = "Back"
        Me.data_entry_kyorugi_form_back_Button.UseVisualStyleBackColor = True
        '
        'Boys_Label
        '
        Me.Boys_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boys_Label.Location = New System.Drawing.Point(140, 38)
        Me.Boys_Label.Name = "Boys_Label"
        Me.Boys_Label.Size = New System.Drawing.Size(552, 23)
        Me.Boys_Label.TabIndex = 7
        Me.Boys_Label.Text = "Boys"
        Me.Boys_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Girls_Label
        '
        Me.Girls_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Girls_Label.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Girls_Label.Location = New System.Drawing.Point(704, 38)
        Me.Girls_Label.Name = "Girls_Label"
        Me.Girls_Label.Size = New System.Drawing.Size(548, 23)
        Me.Girls_Label.TabIndex = 8
        Me.Girls_Label.Text = "Girls"
        Me.Girls_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(704, 64)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(552, 556)
        Me.DataGridView2.TabIndex = 9
        '
        'Print_Preview_Boys_Data_Button
        '
        Me.Print_Preview_Boys_Data_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Print_Preview_Boys_Data_Button.Location = New System.Drawing.Point(144, 626)
        Me.Print_Preview_Boys_Data_Button.Name = "Print_Preview_Boys_Data_Button"
        Me.Print_Preview_Boys_Data_Button.Size = New System.Drawing.Size(260, 23)
        Me.Print_Preview_Boys_Data_Button.TabIndex = 10
        Me.Print_Preview_Boys_Data_Button.Text = "Print Preview Boys Data"
        Me.Print_Preview_Boys_Data_Button.UseVisualStyleBackColor = True
        '
        'Print_Preview_Girls_Data_Button
        '
        Me.Print_Preview_Girls_Data_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Print_Preview_Girls_Data_Button.Location = New System.Drawing.Point(704, 626)
        Me.Print_Preview_Girls_Data_Button.Name = "Print_Preview_Girls_Data_Button"
        Me.Print_Preview_Girls_Data_Button.Size = New System.Drawing.Size(255, 23)
        Me.Print_Preview_Girls_Data_Button.TabIndex = 11
        Me.Print_Preview_Girls_Data_Button.Text = "Print Preview Girls Data"
        Me.Print_Preview_Girls_Data_Button.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "Boys Data"
        '
        'PrintDocument2
        '
        Me.PrintDocument2.DocumentName = "Girls Data"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintPreviewDialog2
        '
        Me.PrintPreviewDialog2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog2.Document = Me.PrintDocument2
        Me.PrintPreviewDialog2.Enabled = True
        Me.PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog2"
        Me.PrintPreviewDialog2.Visible = False
        '
        'Print_Boys_Data_Button
        '
        Me.Print_Boys_Data_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Print_Boys_Data_Button.Location = New System.Drawing.Point(424, 626)
        Me.Print_Boys_Data_Button.Name = "Print_Boys_Data_Button"
        Me.Print_Boys_Data_Button.Size = New System.Drawing.Size(268, 23)
        Me.Print_Boys_Data_Button.TabIndex = 12
        Me.Print_Boys_Data_Button.Text = "Print Boys Data"
        Me.Print_Boys_Data_Button.UseVisualStyleBackColor = True
        '
        'Print_Girls_Data_Button
        '
        Me.Print_Girls_Data_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Print_Girls_Data_Button.Location = New System.Drawing.Point(999, 626)
        Me.Print_Girls_Data_Button.Name = "Print_Girls_Data_Button"
        Me.Print_Girls_Data_Button.Size = New System.Drawing.Size(257, 23)
        Me.Print_Girls_Data_Button.TabIndex = 13
        Me.Print_Girls_Data_Button.Text = "Print Girls Data"
        Me.Print_Girls_Data_Button.UseVisualStyleBackColor = True
        '
        'generate_category_Button
        '
        Me.generate_category_Button.Location = New System.Drawing.Point(12, 381)
        Me.generate_category_Button.Name = "generate_category_Button"
        Me.generate_category_Button.Size = New System.Drawing.Size(107, 23)
        Me.generate_category_Button.TabIndex = 14
        Me.generate_category_Button.Text = "Generate Category"
        Me.generate_category_Button.UseVisualStyleBackColor = True
        '
        'data_entry_kyorugi_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 661)
        Me.Controls.Add(Me.generate_category_Button)
        Me.Controls.Add(Me.Print_Girls_Data_Button)
        Me.Controls.Add(Me.Print_Boys_Data_Button)
        Me.Controls.Add(Me.Print_Preview_Girls_Data_Button)
        Me.Controls.Add(Me.Print_Preview_Boys_Data_Button)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Girls_Label)
        Me.Controls.Add(Me.Boys_Label)
        Me.Controls.Add(Me.data_entry_kyorugi_form_back_Button)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Save_Data_Button)
        Me.Controls.Add(Me.Add_Data_Button)
        Me.Controls.Add(Me.Load_data_Button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "data_entry_kyorugi_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Taekwondo Championship Management System"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Load_data_Button As Button
    Friend WithEvents Add_Data_Button As Button
    Friend WithEvents Save_Data_Button As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents data_entry_kyorugi_form_back_Button As Button
    Public WithEvents Boys_Label As Label
    Public WithEvents Girls_Label As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Print_Preview_Boys_Data_Button As Button
    Friend WithEvents Print_Preview_Girls_Data_Button As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintPreviewDialog2 As PrintPreviewDialog
    Friend WithEvents Print_Boys_Data_Button As Button
    Friend WithEvents Print_Girls_Data_Button As Button
    Friend WithEvents generate_category_Button As Button
End Class
