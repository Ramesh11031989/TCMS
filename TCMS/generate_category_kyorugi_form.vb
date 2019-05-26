Option Strict On
Public Class generate_category_kyorugi_form

    Dim oldPos As Integer
    Dim count_StringBuilder_called As Integer = 0
    Dim builder As New Text.StringBuilder
    Public cat_length As Integer = 0

    Private Sub generate_category_kyorugi_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.RichTextBox1.Enabled = False
        'Me.RichTextBox2.Enabled = False
        Dim Category_Class_0_12 = New Category_Class(data_entry_kyorugi_form.Kyorugi_Player_girls, "Sub Jonior (0-12)", 0, 12)

        For i As Integer = 0 To Category_Class_0_12.players_in_category_array_of_player_object.Length - 1
            'MsgBox(data_entry_kyorugi_form.Kyorugi_Player_girls.Length)
            Write_In_RichTextBox_girls(Category_Class_0_12.players_in_category_array_of_player_object(i))
            cat_length = Category_Class_0_12.players_in_category_array_of_player_object.Length
        Next

        '        For i As Integer = 0 To data_entry_kyorugi_form.Kyorugi_Player_girls.Length - 1
        '       'MsgBox(data_entry_kyorugi_form.Kyorugi_Player_girls.Length)
        '       Write_In_RichTextBox_girls(data_entry_kyorugi_form.Kyorugi_Player_girls(i))
        '        Next
    End Sub
    Private Sub data_entry_kyorugi_form_back_Button_Click(sender As Object, e As EventArgs) Handles data_entry_kyorugi_form_back_Button.Click
        data_entry_kyorugi_form.Show()
        Me.Hide()
    End Sub
    Private Function StringBuilder(Text_Line As String) As String
        count_StringBuilder_called += 1
        builder.Append(Text_Line & vbCrLf)
        If count_StringBuilder_called = cat_length Then
            RichTextBox2.Text = builder.ToString
            Return builder.ToString
        End If
        Return ""
    End Function
    Private Function Write_In_RichTextBox_girls(Input_player As Player_Class) As String
        Dim Text_Line As String = ""
        Text_Line += " "
        Text_Line += Input_player.Name
        Text_Line += " "
        Text_Line += Input_player.District_State_Nation
        Text_Line += " "
        Text_Line += Convert.ToString(Input_player.Year_Of_Birth)
        Text_Line += " "
        Text_Line += Convert.ToString(Input_player.Weight)
        Text_Line += ""
        StringBuilder(Text_Line)
        Return Text_Line
    End Function

End Class