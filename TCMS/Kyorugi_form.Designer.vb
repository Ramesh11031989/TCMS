<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kyorugi_form
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
        Me.back_kyorugi_form_button = New System.Windows.Forms.Button()
        Me.display__kyorugi_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'back_kyorugi_form_button
        '
        Me.back_kyorugi_form_button.Location = New System.Drawing.Point(43, 617)
        Me.back_kyorugi_form_button.Name = "back_kyorugi_form_button"
        Me.back_kyorugi_form_button.Size = New System.Drawing.Size(131, 23)
        Me.back_kyorugi_form_button.TabIndex = 59
        Me.back_kyorugi_form_button.TabStop = False
        Me.back_kyorugi_form_button.Text = "Back"
        Me.back_kyorugi_form_button.UseVisualStyleBackColor = True
        '
        'display__kyorugi_button
        '
        Me.display__kyorugi_button.Location = New System.Drawing.Point(43, 588)
        Me.display__kyorugi_button.Name = "display__kyorugi_button"
        Me.display__kyorugi_button.Size = New System.Drawing.Size(131, 23)
        Me.display__kyorugi_button.TabIndex = 58
        Me.display__kyorugi_button.TabStop = False
        Me.display__kyorugi_button.Text = "Open Desplay Screen"
        Me.display__kyorugi_button.UseVisualStyleBackColor = True
        '
        'Kyorugi_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 661)
        Me.Controls.Add(Me.back_kyorugi_form_button)
        Me.Controls.Add(Me.display__kyorugi_button)
        Me.Name = "Kyorugi_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Taekwondo Championship Management System"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents back_kyorugi_form_button As Button
    Friend WithEvents display__kyorugi_button As Button
End Class
