Option Strict On
Public Class Home
    Private Sub poomsae_button_Click(sender As Object, e As EventArgs) Handles poomsae_button.Click
        poomsae_form.Show()
        If poomsae_display_form.Visible = False Then
            'poomsae_display_form.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub kyorugi_button_Click(sender As Object, e As EventArgs) Handles kyorugi_button.Click
        Kyorugi_form.Show()
        If Kyorugi_display_form.Visible = False Then
            Kyorugi_display_form.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub Data_Entry_Button_Click(sender As Object, e As EventArgs) Handles Data_Entry_kyorugi_Button.Click
        data_entry_kyorugi_form.Show()
        Me.Hide()
    End Sub

    Private Sub vanue_textbox_KeyDown(sender As Object, e As KeyEventArgs) Handles vanue_textbox.KeyDown
        If e.KeyCode = Keys.Space Then
            'AutoFillNames(TextBox1)

        End If
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class