Option Strict On
Public Class Kyorugi_form
    Private Sub Kyorugi_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Screen.AllScreens().Length > 1 Then  'If more than one monitor/screen
            Dim Kyorugi_display_form As New Form
            Dim screen As Screen
            ' We want to display a form on screen 1
            screen = Screen.AllScreens(1)
            ' Set the StartPosition to Manual otherwise the system will assign an automatic start position
            Kyorugi_display_form.StartPosition = FormStartPosition.Manual
            ' Set the form location so it appears at Location (0, 0) on the screen 1
            Kyorugi_display_form.Location = screen.Bounds.Location '+ New Point(0, 0)   ' remove '  if error occurs
            ' Show the form
            Kyorugi_display_form.Show()
        Else
            'set start position to manual
            Kyorugi_display_form.StartPosition = FormStartPosition.Manual
            'set form2 location the same as current form
            Kyorugi_display_form.DesktopLocation = Me.DesktopLocation
            Kyorugi_display_form.Show()
        End If
    End Sub

    Private Sub back_poomsae_form_button_Click(sender As Object, e As EventArgs) Handles back_kyorugi_form_button.Click
        Home.Show()
        Me.Hide()
        Kyorugi_display_form.Hide()
    End Sub

    Private Sub display__kyorugi_button_Click(sender As Object, e As EventArgs) Handles display__kyorugi_button.Click
        Kyorugi_display_form.Show()
    End Sub
End Class