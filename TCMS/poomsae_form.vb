'Option Strict On
Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports System.Xml
Imports Excel = Microsoft.Office.Interop.Excel


Public Class poomsae_form

    Public millisecond As Integer = 0
    Public second As Integer = 0
    Public minute As Integer = 0
    Public millisecond_string As String
    Public second_string As String
    Public minute_string As String
    Public timer_value As String = "00:00:00"
    Public form2 As New poomsae_display_form
    Public click_counter As Integer = 0
    Public gam_Jeom_1_button_counter As Integer = 0
    Public gam_Jeom_2_button_counter As Integer = 0
    Public total_score_p1 As Single = 0.0F
    Public total_score_p2 As Single = 0.0F
    Public final_score As Single = 0.0F
    Public player_data_file As String = ""

    Public Function gam_Jeom() As Boolean

        form2.Panel1.Hide()
        form2.Panel2.Hide()
        form2.disqualified_label.Show()
        form2.disqualified_label.Visible = True

        Return True
        Exit Function
    End Function



    Public Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


        If millisecond > 99 Then
            millisecond = 0
            second = second + 1
        End If

        If second > 60 Then
            second = 0
            minute = minute + 1
        End If

        If millisecond < 10 Then
            millisecond_string = "0" + millisecond.ToString()
        End If

        If millisecond > 9 Then
            millisecond_string = millisecond.ToString()
        End If

        If second < 10 Then
            second_string = "0" + second.ToString()
        End If

        If second > 9 Then
            second_string = second.ToString()
        End If

        If minute < 10 Then
            minute_string = "0" + minute.ToString()
        End If

        If minute > 9 Then
            minute_string = minute.ToString()
        End If

        timer_value = minute_string + ":" + second_string + ":" + millisecond_string

        timer_display_output.Text = timer_value
        form2.timer_display_output.Text = timer_value


        millisecond = millisecond + 1

    End Sub
    Private Sub Judge_name_j1_1_text_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_name_j1_1_text_input.GotFocus
        If Judge_name_j1_1_text_input.Text = "Judge Name" Then
            Judge_name_j1_1_text_input.Text = ""
        End If
    End Sub
    Private Sub Judge_name_j1_1_text_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_name_j1_1_text_input.LostFocus
        If Judge_name_j1_1_text_input.Text = "" Then
            Judge_name_j1_1_text_input.Text = "Judge Name"
        End If
    End Sub

    Private Sub Judge_name_j2_1_text_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_name_j2_1_text_input.GotFocus
        If Judge_name_j2_1_text_input.Text = "Judge Name" Then
            Judge_name_j2_1_text_input.Text = ""
        End If
    End Sub
    Private Sub Judge_name_j2_1_text_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_name_j2_1_text_input.LostFocus
        If Judge_name_j2_1_text_input.Text = "" Then
            Judge_name_j2_1_text_input.Text = "Judge Name"
        End If
    End Sub

    Private Sub Judge_name_j3_1_text_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_name_j3_1_text_input.GotFocus
        If Judge_name_j3_1_text_input.Text = "Judge Name" Then
            Judge_name_j3_1_text_input.Text = ""
        End If
    End Sub
    Private Sub Judge_name_j3_1_text_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_name_j3_1_text_input.LostFocus
        If Judge_name_j3_1_text_input.Text = "" Then
            Judge_name_j3_1_text_input.Text = "Judge Name"
        End If
    End Sub

    Private Sub Judge_name_j4_1_text_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_name_j4_1_text_input.GotFocus
        If Judge_name_j4_1_text_input.Text = "Judge Name" Then
            Judge_name_j4_1_text_input.Text = ""
        End If
    End Sub
    Private Sub Judge_name_j4_1_text_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_name_j4_1_text_input.LostFocus
        If Judge_name_j4_1_text_input.Text = "" Then
            Judge_name_j4_1_text_input.Text = "Judge Name"
        End If
    End Sub

    Private Sub Judge_name_j5_1_text_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_name_j5_1_text_input.GotFocus
        If Judge_name_j5_1_text_input.Text = "Judge Name" Then
            Judge_name_j5_1_text_input.Text = ""
        End If
    End Sub
    Private Sub Judge_name_j5_1_text_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_name_j5_1_text_input.LostFocus
        If Judge_name_j5_1_text_input.Text = "" Then
            Judge_name_j5_1_text_input.Text = "Judge Name"
        End If
    End Sub

    Private Sub Judge_name_j6_1_text_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_name_j6_1_text_input.GotFocus
        If Judge_name_j6_1_text_input.Text = "Judge Name" Then
            Judge_name_j6_1_text_input.Text = ""
        End If
    End Sub
    Private Sub Judge_name_j6_1_text_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_name_j6_1_text_input.LostFocus
        If Judge_name_j6_1_text_input.Text = "" Then
            Judge_name_j6_1_text_input.Text = "Judge Name"
        End If
    End Sub

    Private Sub Judge_name_j7_1_text_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_name_j7_1_text_input.GotFocus
        If Judge_name_j7_1_text_input.Text = "Judge Name" Then
            Judge_name_j7_1_text_input.Text = ""
        End If
    End Sub
    Private Sub Judge_name_j7_1_text_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_name_j7_1_text_input.LostFocus
        If Judge_name_j7_1_text_input.Text = "" Then
            Judge_name_j7_1_text_input.Text = "Judge Name"
        End If
    End Sub


    Private Sub Judge_score_j1_1_number_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j1_1_number_input.GotFocus
        If Judge_score_j1_1_number_input.Text = "0.00" Then
            Judge_score_j1_1_number_input.Text = ""
        End If
    End Sub
    Private Sub Judge_score_j1_1_number_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j1_1_number_input.LostFocus
        If Judge_score_j1_1_number_input.Text = "" Then
            Judge_score_j1_1_number_input.Text = "0.00"
        End If


        Dim sum_score As Single
        Dim average_score_p1 As Single
        sum_score = Convert.ToSingle(Judge_score_j1_1_number_input.Text) + Convert.ToSingle(Judge_score_j2_1_number_input.Text) + Convert.ToSingle(Judge_score_j3_1_number_input.Text) + Convert.ToSingle(Judge_score_j4_1_number_input.Text) + Convert.ToSingle(Judge_score_j5_1_number_input.Text) + Convert.ToSingle(Judge_score_j6_1_number_input.Text) + Convert.ToSingle(Judge_score_j7_1_number_input.Text)
        average_score_p1 = sum_score / Convert.ToSingle(no_of_refree_p1_combo_box.SelectedItem)

        total_score_p1_text_output.Text = Convert.ToString(average_score_p1)

        Dim average_score_total As Single
        Dim sum_score_total As Single
        sum_score_total = Convert.ToSingle(total_score_p1_text_output.Text) + Convert.ToSingle(total_score_p2_text_output.Text)
        average_score_total = sum_score_total / Convert.ToSingle(no_of_poomsae_combo_box.SelectedItem)
        final_score_text_output.Text = Convert.ToString(average_score_total)

    End Sub

    Private Sub Judge_score_j2_1_number_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j2_1_number_input.GotFocus
        If Judge_score_j2_1_number_input.Text = "0.00" Then
            Judge_score_j2_1_number_input.Text = ""
        End If
    End Sub
    Private Sub Judge_score_j2_1_number_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j2_1_number_input.LostFocus
        If Judge_score_j2_1_number_input.Text = "" Then
            Judge_score_j2_1_number_input.Text = "0.00"
        End If

        Dim average_score_p1 As Single
        Dim sum_score As Single
        sum_score = Convert.ToSingle(Judge_score_j1_1_number_input.Text) + Convert.ToSingle(Judge_score_j2_1_number_input.Text) + Convert.ToSingle(Judge_score_j3_1_number_input.Text) + Convert.ToSingle(Judge_score_j4_1_number_input.Text) + Convert.ToSingle(Judge_score_j5_1_number_input.Text) + Convert.ToSingle(Judge_score_j6_1_number_input.Text) + Convert.ToSingle(Judge_score_j7_1_number_input.Text)
        average_score_p1 = sum_score / Convert.ToSingle(no_of_refree_p1_combo_box.SelectedItem)

        total_score_p1_text_output.Text = Convert.ToString(average_score_p1)

        Dim average_score_total As Single
        Dim sum_score_total As Single
        sum_score_total = Convert.ToSingle(total_score_p1_text_output.Text) + Convert.ToSingle(total_score_p2_text_output.Text)
        average_score_total = sum_score_total / Convert.ToSingle(no_of_poomsae_combo_box.SelectedItem)
        final_score_text_output.Text = Convert.ToString(average_score_total)

    End Sub

    Private Sub Judge_score_j3_1_number_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j3_1_number_input.GotFocus
        If Judge_score_j3_1_number_input.Text = "0.00" Then
            Judge_score_j3_1_number_input.Text = ""
        End If

    End Sub
    Private Sub Judge_score_j3_1_number_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j3_1_number_input.LostFocus
        If Judge_score_j3_1_number_input.Text = "" Then
            Judge_score_j3_1_number_input.Text = "0.00"
        End If

        Dim average_score_p1 As Single
        Dim sum_score As Single
        sum_score = Convert.ToSingle(Judge_score_j1_1_number_input.Text) + Convert.ToSingle(Judge_score_j2_1_number_input.Text) + Convert.ToSingle(Judge_score_j3_1_number_input.Text) + Convert.ToSingle(Judge_score_j4_1_number_input.Text) + Convert.ToSingle(Judge_score_j5_1_number_input.Text) + Convert.ToSingle(Judge_score_j6_1_number_input.Text) + Convert.ToSingle(Judge_score_j7_1_number_input.Text)
        average_score_p1 = sum_score / Convert.ToSingle(no_of_refree_p1_combo_box.SelectedItem)

        total_score_p1_text_output.Text = Convert.ToString(average_score_p1)

        Dim average_score_total As Single
        Dim sum_score_total As Single
        sum_score_total = Convert.ToSingle(total_score_p1_text_output.Text) + Convert.ToSingle(total_score_p2_text_output.Text)
        average_score_total = sum_score_total / Convert.ToSingle(no_of_poomsae_combo_box.SelectedItem)
        final_score_text_output.Text = Convert.ToString(average_score_total)

    End Sub

    Private Sub Judge_score_j4_1_number_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j4_1_number_input.GotFocus
        If Judge_score_j4_1_number_input.Text = "0.00" Then
            Judge_score_j4_1_number_input.Text = ""
        End If
    End Sub
    Private Sub Judge_score_j4_1_number_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j4_1_number_input.LostFocus
        If Judge_score_j4_1_number_input.Text = "" Then
            Judge_score_j4_1_number_input.Text = "0.00"
        End If

        Dim average_score_p1 As Single
        Dim sum_score As Single
        sum_score = Convert.ToSingle(Judge_score_j1_1_number_input.Text) + Convert.ToSingle(Judge_score_j2_1_number_input.Text) + Convert.ToSingle(Judge_score_j3_1_number_input.Text) + Convert.ToSingle(Judge_score_j4_1_number_input.Text) + Convert.ToSingle(Judge_score_j5_1_number_input.Text) + Convert.ToSingle(Judge_score_j6_1_number_input.Text) + Convert.ToSingle(Judge_score_j7_1_number_input.Text)
        average_score_p1 = sum_score / Convert.ToSingle(no_of_refree_p1_combo_box.SelectedItem)

        total_score_p1_text_output.Text = Convert.ToString(average_score_p1)

        Dim average_score_total As Single
        Dim sum_score_total As Single
        sum_score_total = Convert.ToSingle(total_score_p1_text_output.Text) + Convert.ToSingle(total_score_p2_text_output.Text)
        average_score_total = sum_score_total / Convert.ToSingle(no_of_poomsae_combo_box.SelectedItem)
        final_score_text_output.Text = Convert.ToString(average_score_total)

    End Sub

    Private Sub Judge_score_j5_1_number_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j5_1_number_input.GotFocus
        If Judge_score_j5_1_number_input.Text = "0.00" Then
            Judge_score_j5_1_number_input.Text = ""
        End If
    End Sub
    Private Sub Judge_score_j5_1_number_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j5_1_number_input.LostFocus
        If Judge_score_j5_1_number_input.Text = "" Then
            Judge_score_j5_1_number_input.Text = "0.00"
        End If

        Dim average_score_p1 As Single
        Dim sum_score As Single
        sum_score = Convert.ToSingle(Judge_score_j1_1_number_input.Text) + Convert.ToSingle(Judge_score_j2_1_number_input.Text) + Convert.ToSingle(Judge_score_j3_1_number_input.Text) + Convert.ToSingle(Judge_score_j4_1_number_input.Text) + Convert.ToSingle(Judge_score_j5_1_number_input.Text) + Convert.ToSingle(Judge_score_j6_1_number_input.Text) + Convert.ToSingle(Judge_score_j7_1_number_input.Text)
        average_score_p1 = sum_score / Convert.ToSingle(no_of_refree_p1_combo_box.SelectedItem)

        total_score_p1_text_output.Text = Convert.ToString(average_score_p1)

        Dim average_score_total As Single
        Dim sum_score_total As Single
        sum_score_total = Convert.ToSingle(total_score_p1_text_output.Text) + Convert.ToSingle(total_score_p2_text_output.Text)
        average_score_total = sum_score_total / Convert.ToSingle(no_of_poomsae_combo_box.SelectedItem)
        final_score_text_output.Text = Convert.ToString(average_score_total)

    End Sub

    Private Sub Judge_score_j6_1_number_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j6_1_number_input.GotFocus
        If Judge_score_j6_1_number_input.Text = "0.00" Then
            Judge_score_j6_1_number_input.Text = ""
        End If
    End Sub
    Private Sub Judge_score_j6_1_number_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j6_1_number_input.LostFocus
        If Judge_score_j6_1_number_input.Text = "" Then
            Judge_score_j6_1_number_input.Text = "0.00"
        End If

        Dim average_score_p1 As Single
        Dim sum_score As Single
        sum_score = Convert.ToSingle(Judge_score_j1_1_number_input.Text) + Convert.ToSingle(Judge_score_j2_1_number_input.Text) + Convert.ToSingle(Judge_score_j3_1_number_input.Text) + Convert.ToSingle(Judge_score_j4_1_number_input.Text) + Convert.ToSingle(Judge_score_j5_1_number_input.Text) + Convert.ToSingle(Judge_score_j6_1_number_input.Text) + Convert.ToSingle(Judge_score_j7_1_number_input.Text)
        average_score_p1 = sum_score / Convert.ToSingle(no_of_refree_p1_combo_box.SelectedItem)

        total_score_p1_text_output.Text = Convert.ToString(average_score_p1)

        Dim average_score_total As Single
        Dim sum_score_total As Single
        sum_score_total = Convert.ToSingle(total_score_p1_text_output.Text) + Convert.ToSingle(total_score_p2_text_output.Text)
        average_score_total = sum_score_total / Convert.ToSingle(no_of_poomsae_combo_box.SelectedItem)
        final_score_text_output.Text = Convert.ToString(average_score_total)

    End Sub

    Private Sub Judge_score_j7_1_number_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j7_1_number_input.GotFocus
        If Judge_score_j7_1_number_input.Text = "0.00" Then
            Judge_score_j7_1_number_input.Text = ""
        End If
    End Sub
    Private Sub Judge_score_j7_1_number_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j7_1_number_input.LostFocus
        If Judge_score_j7_1_number_input.Text = "" Then
            Judge_score_j7_1_number_input.Text = "0.00"
        End If

        Dim average_score_p1 As Single
        Dim sum_score As Single
        sum_score = Convert.ToSingle(Judge_score_j1_1_number_input.Text) + Convert.ToSingle(Judge_score_j2_1_number_input.Text) + Convert.ToSingle(Judge_score_j3_1_number_input.Text) + Convert.ToSingle(Judge_score_j4_1_number_input.Text) + Convert.ToSingle(Judge_score_j5_1_number_input.Text) + Convert.ToSingle(Judge_score_j6_1_number_input.Text) + Convert.ToSingle(Judge_score_j7_1_number_input.Text)
        average_score_p1 = sum_score / Convert.ToSingle(no_of_refree_p1_combo_box.SelectedItem)

        total_score_p1_text_output.Text = Convert.ToString(average_score_p1)

        Dim average_score_total As Single
        Dim sum_score_total As Single
        sum_score_total = Convert.ToSingle(total_score_p1_text_output.Text) + Convert.ToSingle(total_score_p2_text_output.Text)
        average_score_total = sum_score_total / Convert.ToSingle(no_of_poomsae_combo_box.SelectedItem)
        final_score_text_output.Text = Convert.ToString(average_score_total)

    End Sub

    Private Sub Judge_score_j1_2_number_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j1_2_number_input.GotFocus
        If Judge_score_j1_2_number_input.Text = "0.00" Then
            Judge_score_j1_2_number_input.Text = ""
        End If
    End Sub
    Private Sub Judge_score_j1_2_number_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j1_2_number_input.LostFocus
        If Judge_score_j1_2_number_input.Text = "" Then
            Judge_score_j1_2_number_input.Text = "0.00"
        End If

        Dim average_score_p2 As Single
        Dim sum_score_2 As Single
        sum_score_2 = Convert.ToSingle(Judge_score_j1_2_number_input.Text) + Convert.ToSingle(Judge_score_j2_2_number_input.Text) + Convert.ToSingle(Judge_score_j3_2_number_input.Text) + Convert.ToSingle(Judge_score_j4_2_number_input.Text) + Convert.ToSingle(Judge_score_j5_2_number_input.Text) + Convert.ToSingle(Judge_score_j6_2_number_input.Text) + Convert.ToSingle(Judge_score_j7_2_number_input.Text)
        average_score_p2 = sum_score_2 / Convert.ToSingle(no_of_refree_p2_combo_box.SelectedItem)

        total_score_p2_text_output.Text = Convert.ToString(average_score_p2)

        Dim average_score_total As Single
        Dim sum_score_total As Single
        sum_score_total = Convert.ToSingle(total_score_p1_text_output.Text) + Convert.ToSingle(total_score_p2_text_output.Text)
        average_score_total = sum_score_total / Convert.ToSingle(no_of_poomsae_combo_box.SelectedItem)
        final_score_text_output.Text = Convert.ToString(average_score_total)

    End Sub

    Private Sub Judge_score_j2_2_number_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j2_2_number_input.GotFocus
        If Judge_score_j2_2_number_input.Text = "0.00" Then
            Judge_score_j2_2_number_input.Text = ""
        End If
    End Sub
    Private Sub Judge_score_j2_2_number_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j2_2_number_input.LostFocus
        If Judge_score_j2_2_number_input.Text = "" Then
            Judge_score_j2_2_number_input.Text = "0.00"
        End If

        Dim average_score_p2 As Single
        Dim sum_score_2 As Single
        sum_score_2 = Convert.ToSingle(Judge_score_j1_2_number_input.Text) + Convert.ToSingle(Judge_score_j2_2_number_input.Text) + Convert.ToSingle(Judge_score_j3_2_number_input.Text) + Convert.ToSingle(Judge_score_j4_2_number_input.Text) + Convert.ToSingle(Judge_score_j5_2_number_input.Text) + Convert.ToSingle(Judge_score_j6_2_number_input.Text) + Convert.ToSingle(Judge_score_j7_2_number_input.Text)
        average_score_p2 = sum_score_2 / Convert.ToSingle(no_of_refree_p2_combo_box.SelectedItem)

        total_score_p2_text_output.Text = Convert.ToString(average_score_p2)

        Dim average_score_total As Single
        Dim sum_score_total As Single
        sum_score_total = Convert.ToSingle(total_score_p1_text_output.Text) + Convert.ToSingle(total_score_p2_text_output.Text)
        average_score_total = sum_score_total / Convert.ToSingle(no_of_poomsae_combo_box.SelectedItem)
        final_score_text_output.Text = Convert.ToString(average_score_total)

    End Sub

    Private Sub Judge_score_j3_2_number_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j3_2_number_input.GotFocus
        If Judge_score_j3_2_number_input.Text = "0.00" Then
            Judge_score_j3_2_number_input.Text = ""
        End If
    End Sub
    Private Sub Judge_score_j3_2_number_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j3_2_number_input.LostFocus
        If Judge_score_j3_2_number_input.Text = "" Then
            Judge_score_j3_2_number_input.Text = "0.00"
        End If

        Dim average_score_p2 As Single
        Dim sum_score_2 As Single
        sum_score_2 = Convert.ToSingle(Judge_score_j1_2_number_input.Text) + Convert.ToSingle(Judge_score_j2_2_number_input.Text) + Convert.ToSingle(Judge_score_j3_2_number_input.Text) + Convert.ToSingle(Judge_score_j4_2_number_input.Text) + Convert.ToSingle(Judge_score_j5_2_number_input.Text) + Convert.ToSingle(Judge_score_j6_2_number_input.Text) + Convert.ToSingle(Judge_score_j7_2_number_input.Text)
        average_score_p2 = sum_score_2 / Convert.ToSingle(no_of_refree_p2_combo_box.SelectedItem)

        total_score_p2_text_output.Text = Convert.ToString(average_score_p2)

        Dim average_score_total As Single
        Dim sum_score_total As Single
        sum_score_total = Convert.ToSingle(total_score_p1_text_output.Text) + Convert.ToSingle(total_score_p2_text_output.Text)
        average_score_total = sum_score_total / Convert.ToSingle(no_of_poomsae_combo_box.SelectedItem)
        final_score_text_output.Text = Convert.ToString(average_score_total)

    End Sub

    Private Sub Judge_score_j4_2_number_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j4_2_number_input.GotFocus
        If Judge_score_j4_2_number_input.Text = "0.00" Then
            Judge_score_j4_2_number_input.Text = ""
        End If
    End Sub
    Private Sub Judge_score_j4_2_number_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j4_2_number_input.LostFocus
        If Judge_score_j4_2_number_input.Text = "" Then
            Judge_score_j4_2_number_input.Text = "0.00"
        End If

        Dim average_score_p2 As Single
        Dim sum_score_2 As Single
        sum_score_2 = Convert.ToSingle(Judge_score_j1_2_number_input.Text) + Convert.ToSingle(Judge_score_j2_2_number_input.Text) + Convert.ToSingle(Judge_score_j3_2_number_input.Text) + Convert.ToSingle(Judge_score_j4_2_number_input.Text) + Convert.ToSingle(Judge_score_j5_2_number_input.Text) + Convert.ToSingle(Judge_score_j6_2_number_input.Text) + Convert.ToSingle(Judge_score_j7_2_number_input.Text)
        average_score_p2 = sum_score_2 / Convert.ToSingle(no_of_refree_p2_combo_box.SelectedItem)

        total_score_p2_text_output.Text = Convert.ToString(average_score_p2)

        Dim average_score_total As Single
        Dim sum_score_total As Single
        sum_score_total = Convert.ToSingle(total_score_p1_text_output.Text) + Convert.ToSingle(total_score_p2_text_output.Text)
        average_score_total = sum_score_total / Convert.ToSingle(no_of_poomsae_combo_box.SelectedItem)
        final_score_text_output.Text = Convert.ToString(average_score_total)

    End Sub

    Private Sub Judge_score_j5_2_number_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j5_2_number_input.GotFocus
        If Judge_score_j5_2_number_input.Text = "0.00" Then
            Judge_score_j5_2_number_input.Text = ""
        End If
    End Sub
    Private Sub Judge_score_j5_2_number_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j5_2_number_input.LostFocus
        If Judge_score_j5_2_number_input.Text = "" Then
            Judge_score_j5_2_number_input.Text = "0.00"
        End If

        Dim average_score_p2 As Single
        Dim sum_score_2 As Single
        sum_score_2 = Convert.ToSingle(Judge_score_j1_2_number_input.Text) + Convert.ToSingle(Judge_score_j2_2_number_input.Text) + Convert.ToSingle(Judge_score_j3_2_number_input.Text) + Convert.ToSingle(Judge_score_j4_2_number_input.Text) + Convert.ToSingle(Judge_score_j5_2_number_input.Text) + Convert.ToSingle(Judge_score_j6_2_number_input.Text) + Convert.ToSingle(Judge_score_j7_2_number_input.Text)
        average_score_p2 = sum_score_2 / Convert.ToSingle(no_of_refree_p2_combo_box.SelectedItem)

        total_score_p2_text_output.Text = Convert.ToString(average_score_p2)

        Dim average_score_total As Single
        Dim sum_score_total As Single
        sum_score_total = Convert.ToSingle(total_score_p1_text_output.Text) + Convert.ToSingle(total_score_p2_text_output.Text)
        average_score_total = sum_score_total / Convert.ToSingle(no_of_poomsae_combo_box.SelectedItem)
        final_score_text_output.Text = Convert.ToString(average_score_total)

    End Sub

    Private Sub Judge_score_j6_2_number_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j6_2_number_input.GotFocus
        If Judge_score_j6_2_number_input.Text = "0.00" Then
            Judge_score_j6_2_number_input.Text = ""
        End If
    End Sub
    Private Sub Judge_score_j6_2_number_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j6_2_number_input.LostFocus
        If Judge_score_j6_2_number_input.Text = "" Then
            Judge_score_j6_2_number_input.Text = "0.00"
        End If

        Dim average_score_p2 As Single
        Dim sum_score_2 As Single
        sum_score_2 = Convert.ToSingle(Judge_score_j1_2_number_input.Text) + Convert.ToSingle(Judge_score_j2_2_number_input.Text) + Convert.ToSingle(Judge_score_j3_2_number_input.Text) + Convert.ToSingle(Judge_score_j4_2_number_input.Text) + Convert.ToSingle(Judge_score_j5_2_number_input.Text) + Convert.ToSingle(Judge_score_j6_2_number_input.Text) + Convert.ToSingle(Judge_score_j7_2_number_input.Text)
        average_score_p2 = sum_score_2 / Convert.ToSingle(no_of_refree_p2_combo_box.SelectedItem)

        total_score_p2_text_output.Text = Convert.ToString(average_score_p2)

        Dim average_score_total As Single
        Dim sum_score_total As Single
        sum_score_total = Convert.ToSingle(total_score_p1_text_output.Text) + Convert.ToSingle(total_score_p2_text_output.Text)
        average_score_total = sum_score_total / Convert.ToSingle(no_of_poomsae_combo_box.SelectedItem)
        final_score_text_output.Text = Convert.ToString(average_score_total)

    End Sub

    Private Sub Judge_score_j7_2_number_input_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j7_2_number_input.GotFocus
        If Judge_score_j7_2_number_input.Text = "0.00" Then
            Judge_score_j7_2_number_input.Text = ""
        End If
    End Sub
    Private Sub Judge_score_j7_2_number_input_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Judge_score_j7_2_number_input.LostFocus
        If Judge_score_j7_2_number_input.Text = "" Then
            Judge_score_j7_2_number_input.Text = "0.00"
        End If

        Dim average_score_p2 As Single
        Dim sum_score_2 As Single
        sum_score_2 = Convert.ToSingle(Judge_score_j1_2_number_input.Text) + Convert.ToSingle(Judge_score_j2_2_number_input.Text) + Convert.ToSingle(Judge_score_j3_2_number_input.Text) + Convert.ToSingle(Judge_score_j4_2_number_input.Text) + Convert.ToSingle(Judge_score_j5_2_number_input.Text) + Convert.ToSingle(Judge_score_j6_2_number_input.Text) + Convert.ToSingle(Judge_score_j7_2_number_input.Text)
        average_score_p2 = sum_score_2 / Convert.ToSingle(no_of_refree_p2_combo_box.SelectedItem)

        total_score_p2_text_output.Text = Convert.ToString(average_score_p2)

        Dim average_score_total As Single
        Dim sum_score_total As Single
        sum_score_total = Convert.ToSingle(total_score_p1_text_output.Text) + Convert.ToSingle(total_score_p2_text_output.Text)
        average_score_total = sum_score_total / Convert.ToSingle(no_of_poomsae_combo_box.SelectedItem)
        final_score_text_output.Text = Convert.ToString(average_score_total)

    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Screen.AllScreens().Length > 1 Then  'If more than one monitor/screen
            Dim form As New Form
            Dim screen As Screen
            ' We want to display a form on screen 1
            screen = Screen.AllScreens(1)
            ' Set the StartPosition to Manual otherwise the system will assign an automatic start position
            form2.StartPosition = FormStartPosition.Manual
            ' Set the form location so it appears at Location (0, 0) on the screen 1
            form2.Location = screen.Bounds.Location '+ New Point(0, 0)
            ' Show the form
            form2.Show()
        Else
            'set start position to manual
            form2.StartPosition = FormStartPosition.Manual
            'set form2 location the same as current form
            form2.DesktopLocation = Me.DesktopLocation
            form2.Show()
        End If


        form2.Panel2.Visible = False

        poomsae_type_combo_box.Items.Add("Individual")
        poomsae_type_combo_box.Items.Add("Pair")
        poomsae_type_combo_box.Items.Add("Team")

        no_of_poomsae_combo_box.Items.Add("1")
        no_of_poomsae_combo_box.Items.Add("2")

        name_of_poomsae_p1_combo_box.Items.Add("Taegeuk Il Jang")
        name_of_poomsae_p1_combo_box.Items.Add("Taegeuk Ee Jang")
        name_of_poomsae_p1_combo_box.Items.Add("Taegeuk Sam Jang")
        name_of_poomsae_p1_combo_box.Items.Add("Taegeuk Saw Jang")
        name_of_poomsae_p1_combo_box.Items.Add("Taegeuk Oh Jang")
        name_of_poomsae_p1_combo_box.Items.Add("Taegeuk Yuk Jang")
        name_of_poomsae_p1_combo_box.Items.Add("Taegeuk Chil Jang")
        name_of_poomsae_p1_combo_box.Items.Add("Taegeuk Pal Jang")
        name_of_poomsae_p1_combo_box.Items.Add("Koryo")
        name_of_poomsae_p1_combo_box.Items.Add("Keumgang")
        name_of_poomsae_p1_combo_box.Items.Add("Taebaek")
        name_of_poomsae_p1_combo_box.Items.Add("Pyongwon")
        name_of_poomsae_p1_combo_box.Items.Add("Sipjin")
        name_of_poomsae_p1_combo_box.Items.Add("Jitae")
        name_of_poomsae_p1_combo_box.Items.Add("Cheonkwon")
        name_of_poomsae_p1_combo_box.Items.Add("Hansu")
        name_of_poomsae_p1_combo_box.Items.Add("Ilyeo")

        name_of_poomsae_p2_combo_box.Items.Add("Taegeuk Il Jang")
        name_of_poomsae_p2_combo_box.Items.Add("Taegeuk Ee Jang")
        name_of_poomsae_p2_combo_box.Items.Add("Taegeuk Sam Jang")
        name_of_poomsae_p2_combo_box.Items.Add("Taegeuk Saw Jang")
        name_of_poomsae_p2_combo_box.Items.Add("Taegeuk Oh Jang")
        name_of_poomsae_p2_combo_box.Items.Add("Taegeuk Yuk Jang")
        name_of_poomsae_p2_combo_box.Items.Add("Taegeuk Chil Jang")
        name_of_poomsae_p2_combo_box.Items.Add("Taegeuk Pal Jang")
        name_of_poomsae_p2_combo_box.Items.Add("Koryo")
        name_of_poomsae_p2_combo_box.Items.Add("Keumgang")
        name_of_poomsae_p2_combo_box.Items.Add("Taebaek")
        name_of_poomsae_p2_combo_box.Items.Add("Pyongwon")
        name_of_poomsae_p2_combo_box.Items.Add("Sipjin")
        name_of_poomsae_p2_combo_box.Items.Add("Jitae")
        name_of_poomsae_p2_combo_box.Items.Add("Cheonkwon")
        name_of_poomsae_p2_combo_box.Items.Add("Hansu")
        name_of_poomsae_p2_combo_box.Items.Add("Ilyeo")

        no_of_refree_p1_combo_box.Items.Add("1")
        no_of_refree_p1_combo_box.Items.Add("2")
        no_of_refree_p1_combo_box.Items.Add("3")
        no_of_refree_p1_combo_box.Items.Add("4")
        no_of_refree_p1_combo_box.Items.Add("5")
        no_of_refree_p1_combo_box.Items.Add("6")
        no_of_refree_p1_combo_box.Items.Add("7")

        no_of_refree_p2_combo_box.Items.Add("1")
        no_of_refree_p2_combo_box.Items.Add("2")
        no_of_refree_p2_combo_box.Items.Add("3")
        no_of_refree_p2_combo_box.Items.Add("4")
        no_of_refree_p2_combo_box.Items.Add("5")
        no_of_refree_p2_combo_box.Items.Add("6")
        no_of_refree_p2_combo_box.Items.Add("7")

        Panel9.Hide()

        Panel2.Show()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
        Panel6.Hide()
        Panel7.Hide()
        Panel8.Hide()

        Panel16.Show()
        Panel15.Hide()
        Panel14.Hide()
        Panel13.Hide()
        Panel12.Hide()
        Panel11.Hide()
        Panel10.Hide()

        name_of_poomse_1_label.Show()
        name_of_poomsae_p1_combo_box.Show()
        name_of_poomse_2_label.Hide()
        name_of_poomsae_p2_combo_box.Hide()

        form2.disqualified_label.Visible = False



    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles age_group_label.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles no_of_poomsae_label.TextChanged

    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub TextBox39_TextChanged(sender As Object, e As EventArgs) Handles Judge_score_j5_2_number_input.TextChanged

    End Sub

    Private Sub poomsae_type_combo_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles poomsae_type_combo_box.SelectedIndexChanged
        form2.poomsea_type2_label.Text = Convert.ToString(poomsae_type_combo_box.SelectedItem)

        If Convert.ToString(poomsae_type_combo_box.SelectedItem) = "Individual" Then
            age_group_combo_box.Items.Clear()
            age_group_combo_box.Items.Add("Sub Junior (U-12)")
            age_group_combo_box.Items.Add("Cadet       (12 - 14)")
            age_group_combo_box.Items.Add("Junior       (15 - 17)")
            age_group_combo_box.Items.Add("Under 30   (18 - 30)")
            age_group_combo_box.Items.Add("Under 40   (31 - 40)")
            age_group_combo_box.Items.Add("Under 50   (41 - 50)")
            age_group_combo_box.Items.Add("Under 60   (51 - 60)")
            age_group_combo_box.Items.Add("Under 65   (61 - 65)")
            age_group_combo_box.Items.Add("Over   65")
        End If

        If Convert.ToString(poomsae_type_combo_box.SelectedItem) = "Pair" Then
            age_group_combo_box.Items.Clear()
            age_group_combo_box.Items.Add("Sub Junior (U-12)")
            age_group_combo_box.Items.Add("Cadet (12 - 14)")
            age_group_combo_box.Items.Add("Junior (15 - 17)")
            age_group_combo_box.Items.Add("Senior Under 30")
            age_group_combo_box.Items.Add("Senior Over  30")
        End If

        If Convert.ToString(poomsae_type_combo_box.SelectedItem) = "Team" Then
            age_group_combo_box.Items.Clear()
            age_group_combo_box.Items.Add("Sub Junior (U-12)")
            age_group_combo_box.Items.Add("Cadet (12 - 14)")
            age_group_combo_box.Items.Add("Junior (15 - 17)")
            age_group_combo_box.Items.Add("Senior Under 30")
            age_group_combo_box.Items.Add("Senior Over  30")
        End If

    End Sub

    Private Sub show_button_p1_Click(sender As Object, e As EventArgs) Handles show_button_p1.Click
        Me.time_ended_1_label.Text = timer_value
        form2.time_ended_1_label.Text = timer_value

        form2.score_poomse_1_label.Text = total_score_p1_text_output.Text
    End Sub

    Private Sub no_of_poomsae_combo_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles no_of_poomsae_combo_box.SelectedIndexChanged

        If Convert.ToString(no_of_poomsae_combo_box.SelectedItem) = "1" Then
            Panel1.Show()
            Panel9.Hide()

            name_of_poomse_1_label.Show()
            name_of_poomsae_p1_combo_box.Show()
            name_of_poomse_2_label.Hide()
            name_of_poomsae_p2_combo_box.Hide()
            form2.Panel2.Visible = False
        End If

        If Convert.ToString(no_of_poomsae_combo_box.SelectedItem) = "2" Then
            Panel1.Show()
            Panel9.Show()

            name_of_poomse_1_label.Show()
            name_of_poomsae_p1_combo_box.Show()
            name_of_poomse_2_label.Show()
            name_of_poomsae_p2_combo_box.Show()
            form2.Panel2.Visible = True
        End If


    End Sub

    Private Sub no_of_refree_p1_combo_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles no_of_refree_p1_combo_box.SelectedIndexChanged
        no_of_refree_p2_combo_box.SelectedItem = no_of_refree_p1_combo_box.SelectedItem
        If Convert.ToString(no_of_refree_p1_combo_box.SelectedItem) = "1" Then
            Panel2.Show()
            Panel3.Hide()
            Panel4.Hide()
            Panel5.Hide()
            Panel6.Hide()
            Panel7.Hide()
            Panel8.Hide()

            Panel16.Show()
            Panel15.Hide()
            Panel14.Hide()
            Panel13.Hide()
            Panel12.Hide()
            Panel11.Hide()
            Panel10.Hide()
        End If

        If Convert.ToString(no_of_refree_p1_combo_box.SelectedItem) = "2" Then
            Panel2.Show()
            Panel3.Show()
            Panel4.Hide()
            Panel5.Hide()
            Panel6.Hide()
            Panel7.Hide()
            Panel8.Hide()

            Panel16.Show()
            Panel15.Show()
            Panel14.Hide()
            Panel13.Hide()
            Panel12.Hide()
            Panel11.Hide()
            Panel10.Hide()
        End If

        If Convert.ToString(no_of_refree_p1_combo_box.SelectedItem) = "3" Then
            Panel2.Show()
            Panel3.Show()
            Panel4.Show()
            Panel5.Hide()
            Panel6.Hide()
            Panel7.Hide()
            Panel8.Hide()

            Panel16.Show()
            Panel15.Show()
            Panel14.Show()
            Panel13.Hide()
            Panel12.Hide()
            Panel11.Hide()
            Panel10.Hide()
        End If

        If Convert.ToString(no_of_refree_p1_combo_box.SelectedItem) = "4" Then
            Panel2.Show()
            Panel3.Show()
            Panel4.Show()
            Panel5.Show()
            Panel6.Hide()
            Panel7.Hide()
            Panel8.Hide()

            Panel16.Show()
            Panel15.Show()
            Panel14.Show()
            Panel13.Show()
            Panel12.Hide()
            Panel11.Hide()
            Panel10.Hide()
        End If

        If Convert.ToString(no_of_refree_p1_combo_box.SelectedItem) = "5" Then
            Panel2.Show()
            Panel3.Show()
            Panel4.Show()
            Panel5.Show()
            Panel6.Show()
            Panel7.Hide()
            Panel8.Hide()

            Panel16.Show()
            Panel15.Show()
            Panel14.Show()
            Panel13.Show()
            Panel12.Show()
            Panel11.Hide()
            Panel10.Hide()
        End If

        If Convert.ToString(no_of_refree_p1_combo_box.SelectedItem) = "6" Then
            Panel2.Show()
            Panel3.Show()
            Panel4.Show()
            Panel5.Show()
            Panel6.Show()
            Panel7.Show()
            Panel8.Hide()

            Panel16.Show()
            Panel15.Show()
            Panel14.Show()
            Panel13.Show()
            Panel12.Show()
            Panel11.Show()
            Panel10.Hide()
        End If

        If Convert.ToString(no_of_refree_p1_combo_box.SelectedItem) = "7" Then
            Panel2.Show()
            Panel3.Show()
            Panel4.Show()
            Panel5.Show()
            Panel6.Show()
            Panel7.Show()
            Panel8.Show()

            Panel16.Show()
            Panel15.Show()
            Panel14.Show()
            Panel13.Show()
            Panel12.Show()
            Panel11.Show()
            Panel10.Show()
        End If




    End Sub

    Private Sub Judge_name_j1_1_text_input_TextChanged(sender As Object, e As EventArgs) Handles Judge_name_j1_1_text_input.TextChanged
        Judge_name_j1_2_text_input.Text = Judge_name_j1_1_text_input.Text
    End Sub

    Private Sub name_of_poomsae_1_combo_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles name_of_poomsae_p1_combo_box.SelectedIndexChanged
        'name_of_poomsae_p2_combo_box.SelectedItem = name_of_poomsae_p1_combo_box.SelectedItem
        form2.name_of_1st_poomsae_label.Text = Convert.ToString(name_of_poomsae_p1_combo_box.SelectedItem)

    End Sub

    Private Sub Judge_name_j2_1_text_input_TextChanged(sender As Object, e As EventArgs) Handles Judge_name_j2_1_text_input.TextChanged
        Judge_name_j2_2_text_input.Text = Judge_name_j2_1_text_input.Text
    End Sub

    Private Sub Judge_name_j3_1_text_input_TextChanged(sender As Object, e As EventArgs) Handles Judge_name_j3_1_text_input.TextChanged
        Judge_name_j3_2_text_input.Text = Judge_name_j3_1_text_input.Text
    End Sub

    Private Sub Judge_name_j4_1_text_input_TextChanged(sender As Object, e As EventArgs) Handles Judge_name_j4_1_text_input.TextChanged
        Judge_name_j4_2_text_input.Text = Judge_name_j4_1_text_input.Text
    End Sub

    Private Sub Judge_name_j5_1_text_input_TextChanged(sender As Object, e As EventArgs) Handles Judge_name_j5_1_text_input.TextChanged
        Judge_name_j5_2_text_input.Text = Judge_name_j5_1_text_input.Text
    End Sub

    Private Sub Judge_name_j6_1_text_input_TextChanged(sender As Object, e As EventArgs) Handles Judge_name_j6_1_text_input.TextChanged
        Judge_name_j6_2_text_input.Text = Judge_name_j6_1_text_input.Text
    End Sub

    Private Sub Judge_name_j7_1_text_input_TextChanged(sender As Object, e As EventArgs) Handles Judge_name_j7_1_text_input.TextChanged
        Judge_name_j7_2_text_input.Text = Judge_name_j7_1_text_input.Text
    End Sub

    Private Sub Start_timer_button_Click(sender As Object, e As EventArgs) Handles start_timer_button.Click

        click_counter = click_counter + 1

        If (Timer1.Enabled = False And click_counter = 1) Or (Timer1.Enabled = False And timer_value = "00:00:00") Then
            Timer1.Enabled = True
            Timer1.Start() 'Timer starts functioning'
            start_timer_button.Text = "Stop Timer"

        Else
            Timer1.Stop()  'Timer stops functioning'
            Timer1.Enabled = False

        End If

    End Sub


    Private Sub reset_button_Click(sender As Object, e As EventArgs) Handles reset_button.Click
        If Timer1.Enabled = False Then
            Timer1.Stop() 'Timer stops functioning'
            start_timer_button.Text = "Start Timer"
            timer_value = "00:00:00"
            millisecond = 0
            second = 0
            minute = 0
            timer_display_output.Text = timer_value
            form2.timer_display_output.Text = timer_value
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles display_button.Click

        form2.Show()
    End Sub

    Private Sub name_of_poomsae_p2_combo_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles name_of_poomsae_p2_combo_box.SelectedIndexChanged
        form2.name_of_2st_poomsae_label.Text = Convert.ToString(name_of_poomsae_p2_combo_box.SelectedItem)
    End Sub

    Private Sub player_name_text_input_TextChanged(sender As Object, e As EventArgs) Handles player_name_text_input.TextChanged
        form2.name_label.Text = player_name_text_input.Text
    End Sub

    Private Sub age_group_combo_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles age_group_combo_box.SelectedIndexChanged
        form2.age_group_label.Text = Convert.ToString(age_group_combo_box.SelectedItem)
    End Sub

    Private Sub distric_text_input_TextChanged(sender As Object, e As EventArgs) Handles distric_text_input.TextChanged
        form2.nation_state_district_label.Text = distric_text_input.Text
    End Sub


    Private Sub total_score_p1_text_output_TextChanged(sender As Object, e As EventArgs) Handles total_score_p1_text_output.TextChanged
        form2.name_of_1st_poomsae_label.Text = Convert.ToString(name_of_poomsae_p1_combo_box.SelectedItem)

        If (gam_Jeom_1_button_counter + gam_Jeom_2_button_counter) = 1 Then
            form2.final_score_label.Text = Convert.ToString(Convert.ToSingle(final_score_text_output.Text) + 1)
        End If

    End Sub

    Private Sub total_score_p2_text_output_TextChanged(sender As Object, e As EventArgs) Handles total_score_p2_text_output.TextChanged
        form2.name_of_2st_poomsae_label.Text = Convert.ToString(name_of_poomsae_p2_combo_box.SelectedItem)

        If (gam_Jeom_1_button_counter + gam_Jeom_2_button_counter) = 1 Then
            form2.final_score_label.Text = Convert.ToString(Convert.ToSingle(final_score_text_output.Text) + 1)
        End If

    End Sub

    Private Sub show_button_p2_Click(sender As Object, e As EventArgs) Handles show_button_p2.Click
        Me.time_ended_2_label.Text = timer_value
        form2.time_ended_2_label.Text = timer_value
        form2.score_poomse_2_label.Text = total_score_p2_text_output.Text
    End Sub


    Private Sub show_button_Final_score_Click(sender As Object, e As EventArgs) Handles show_button_Final_score.Click
        form2.final_score_label.Text = final_score_text_output.Text

        form2.Panel1.Show()
        form2.Panel2.Show()
        form2.disqualified_label.Visible = False

    End Sub

    Private Sub new_match_button_Click(sender As Object, e As EventArgs) Handles new_match_button.Click

        If Convert.ToString(no_of_poomsae_combo_box.SelectedItem) = "1" Then
            form2.Panel1.Show()
            form2.Panel2.Hide()
            form2.disqualified_label.Visible = False
        End If

        If Convert.ToString(no_of_poomsae_combo_box.SelectedItem) = "2" Then
            form2.Panel1.Show()
            form2.Panel2.Show()
            form2.disqualified_label.Visible = False
        End If

        'Clear form1 data
        Me.player_name_text_input.Text = ""
        Me.distric_text_input.Text = ""
        Me.Judge_score_j1_1_number_input.Text = "0.00"
        Me.Judge_score_j2_1_number_input.Text = "0.00"
        Me.Judge_score_j3_1_number_input.Text = "0.00"
        Me.Judge_score_j4_1_number_input.Text = "0.00"
        Me.Judge_score_j5_1_number_input.Text = "0.00"
        Me.Judge_score_j6_1_number_input.Text = "0.00"
        Me.Judge_score_j7_1_number_input.Text = "0.00"
        Me.Judge_score_j1_2_number_input.Text = "0.00"
        Me.Judge_score_j2_2_number_input.Text = "0.00"
        Me.Judge_score_j3_2_number_input.Text = "0.00"
        Me.Judge_score_j4_2_number_input.Text = "0.00"
        Me.Judge_score_j5_2_number_input.Text = "0.00"
        Me.Judge_score_j6_2_number_input.Text = "0.00"
        Me.Judge_score_j7_2_number_input.Text = "0.00"
        Me.total_score_p1_text_output.Text = "0.00"
        Me.total_score_p2_text_output.Text = "0.00"
        Me.time_ended_1_label.Text = "00:00:00"
        Me.time_ended_2_label.Text = "00:00:00"
        Me.final_score_text_output.Text = "0.00"
        Me.match_number_text_input.Text = ""
        form2.final_score_label.Text = final_score_text_output.Text

        'Clear form1 data
        form2.name_label.Text = "Player Name"
        form2.nation_state_district_label.Text = "Name"
        form2.nation_state_district_label.Text = "Nation/State/District"
        form2.poomsea_type2_label.Text = "Poomsea Type"
        form2.age_group_label.Text = "Age Group"
        form2.name_of_1st_poomsae_label.Text = "Name of 1st Poomsae"
        form2.name_of_2st_poomsae_label.Text = "Name of 2nd Poomsae"
        form2.score_poomse_1_label.Text = "0.00"
        form2.score_poomse_2_label.Text = "0.00"
        form2.final_score_label.Text = "0.00"
        form2.time_ended_1_label.Text = "00:00:00"
        form2.time_ended_2_label.Text = "00:00:00"


        'Reset The Timer also
        Timer1.Stop() 'Timer stops functioning'
        start_timer_button.Text = "Start Timer"
        timer_value = "00:00:00"
        millisecond = 0
        second = 0
        minute = 0
        timer_display_output.Text = timer_value
        form2.timer_display_output.Text = timer_value

        'Reset varables
        click_counter = 0
        gam_Jeom_1_button_counter = 0
        gam_Jeom_2_button_counter = 0
        total_score_p1 = 0.0F
        total_score_p2 = 0.0F
        gam_Jeom_1_button_counter = 0
        gam_Jeom_2_button_counter = 0
        gam_Jeom_1_button.BackColor = Color.LightGray
        gam_Jeom_2_button.BackColor = Color.LightGray

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim myOpenFileDialog As New OpenFileDialog()


        myOpenFileDialog.CheckFileExists = True
        myOpenFileDialog.DefaultExt = "xml"
        myOpenFileDialog.Multiselect = False
        'Set the title of the dialog box. 
        myOpenFileDialog.Title = "Please select one or more files"

        'Clear out the current filters, and add our own. 
        myOpenFileDialog.Filter = "XML Files|*.xml"

        If myOpenFileDialog.ShowDialog = DialogResult.OK Then
            Dim xml_file_name As String
            Dim xml_file_path As String
            xml_file_name = myOpenFileDialog.FileName
            xml_file_path = System.IO.Path.GetFullPath(myOpenFileDialog.FileName)

            Dim xr As XmlReader = XmlReader.Create(xml_file_name)
            Do While xr.Read()
                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "poomsae_type_combo_box" Then
                    Me.poomsae_type_combo_box.SelectedItem = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "age_group_combo_box" Then
                    Me.age_group_combo_box.SelectedItem = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "no_of_poomsae_combo_box" Then
                    Me.no_of_poomsae_combo_box.SelectedItem = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "name_of_poomsae_p1_combo_box" Then
                    Me.name_of_poomsae_p1_combo_box.SelectedItem = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "name_of_poomsae_p2_combo_box" Then
                    Me.name_of_poomsae_p2_combo_box.SelectedItem = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "no_of_refree_p1_combo_box" Then
                    Me.no_of_refree_p1_combo_box.SelectedItem = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "no_of_refree_p2_combo_box" Then
                    Me.no_of_refree_p2_combo_box.SelectedItem = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "Judge_name_j1_1_text_input" Then
                    Me.Judge_name_j1_1_text_input.Text = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "Judge_name_j2_1_text_input" Then
                    Me.Judge_name_j2_1_text_input.Text = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "Judge_name_j3_1_text_input" Then
                    Me.Judge_name_j3_1_text_input.Text = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "Judge_name_j4_1_text_input" Then
                    Me.Judge_name_j4_1_text_input.Text = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "Judge_name_j5_1_text_input" Then
                    Me.Judge_name_j5_1_text_input.Text = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "Judge_name_j6_1_text_input" Then
                    Me.Judge_name_j6_1_text_input.Text = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "Judge_name_j7_1_text_input" Then
                    Me.Judge_name_j7_1_text_input.Text = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "Judge_name_j1_2_text_input" Then
                    Me.Judge_name_j1_2_text_input.Text = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "Judge_name_j2_2_text_input" Then
                    Me.Judge_name_j2_2_text_input.Text = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "Judge_name_j3_2_text_input" Then
                    Me.Judge_name_j3_2_text_input.Text = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "Judge_name_j4_2_text_input" Then
                    Me.Judge_name_j4_2_text_input.Text = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "Judge_name_j5_2_text_input" Then
                    Me.Judge_name_j5_2_text_input.Text = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "Judge_name_j6_2_text_input" Then
                    Me.Judge_name_j6_2_text_input.Text = xr.ReadElementString
                End If

                If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "Judge_name_j7_2_text_input" Then
                    Me.Judge_name_j7_2_text_input.Text = xr.ReadElementString
                End If

            Loop
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "XML files (*.xml)|*.xml"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog = DialogResult.OK Then

            Dim xml_file_name As String
            xml_file_name = saveFileDialog1.FileName

            Dim xws As XmlWriterSettings = New XmlWriterSettings()
            xws.Indent = True
            xws.NewLineOnAttributes = True
            Dim xw As XmlWriter = XmlWriter.Create(xml_file_name, xws)
            xw.WriteStartDocument()
            xw.WriteStartElement("settings")

            xw.WriteElementString("poomsae_type_combo_box", Convert.ToString(Me.poomsae_type_combo_box.SelectedItem))
            xw.WriteElementString("age_group_combo_box", Convert.ToString(Me.age_group_combo_box.SelectedItem))
            xw.WriteElementString("no_of_poomsae_combo_box", Convert.ToString(Me.no_of_poomsae_combo_box.SelectedItem))
            xw.WriteElementString("name_of_poomsae_p1_combo_box", Convert.ToString(Me.name_of_poomsae_p1_combo_box.SelectedItem))
            xw.WriteElementString("name_of_poomsae_p2_combo_box", Convert.ToString(Me.name_of_poomsae_p2_combo_box.SelectedItem))
            xw.WriteElementString("no_of_refree_p1_combo_box", Convert.ToString(Me.no_of_refree_p1_combo_box.SelectedItem))
            xw.WriteElementString("no_of_refree_p2_combo_box", Convert.ToString(Me.no_of_refree_p2_combo_box.SelectedItem))
            xw.WriteElementString("Judge_name_j1_1_text_input", Me.Judge_name_j1_1_text_input.Text)
            xw.WriteElementString("Judge_name_j2_1_text_input", Me.Judge_name_j2_1_text_input.Text)
            xw.WriteElementString("Judge_name_j3_1_text_input", Me.Judge_name_j3_1_text_input.Text)
            xw.WriteElementString("Judge_name_j4_1_text_input", Me.Judge_name_j4_1_text_input.Text)
            xw.WriteElementString("Judge_name_j5_1_text_input", Me.Judge_name_j5_1_text_input.Text)
            xw.WriteElementString("Judge_name_j6_1_text_input", Me.Judge_name_j6_1_text_input.Text)
            xw.WriteElementString("Judge_name_j7_1_text_input", Me.Judge_name_j7_1_text_input.Text)
            xw.WriteElementString("Judge_name_j1_2_text_input", Me.Judge_name_j1_2_text_input.Text)
            xw.WriteElementString("Judge_name_j2_2_text_input", Me.Judge_name_j2_2_text_input.Text)
            xw.WriteElementString("Judge_name_j3_2_text_input", Me.Judge_name_j3_2_text_input.Text)
            xw.WriteElementString("Judge_name_j4_2_text_input", Me.Judge_name_j4_2_text_input.Text)
            xw.WriteElementString("Judge_name_j5_2_text_input", Me.Judge_name_j5_2_text_input.Text)
            xw.WriteElementString("Judge_name_j6_2_text_input", Me.Judge_name_j6_2_text_input.Text)
            xw.WriteElementString("Judge_name_j7_2_text_input", Me.Judge_name_j7_2_text_input.Text)

            xw.WriteEndElement()
            xw.WriteEndDocument()
            xw.Flush()
            xw.Close()
            'WebBrowser1.Url = New Uri(AppDomain.CurrentDomain.BaseDirectory + "authors.xml")


        End If

    End Sub



    Private Sub gam_Jeom_1_button_Click(sender As Object, e As EventArgs) Handles gam_Jeom_1_button.Click
        gam_Jeom_1_button_counter = gam_Jeom_1_button_counter + 1

        If (gam_Jeom_1_button_counter + gam_Jeom_2_button_counter) = 1 Then
            gam_Jeom_1_button.BackColor = Color.Yellow
            Me.time_ended_1_label.Text = timer_value
            form2.time_ended_1_label.Text = timer_value
            total_score_p1 = Convert.ToSingle(total_score_p1_text_output.Text)
            total_score_p1 = total_score_p1 - 1
            Me.total_score_p1_text_output.Text = Convert.ToString(total_score_p1)
            'form2.score_poomse_1_label.Text = total_score_p1_text_output.Text
        Else
            gam_Jeom_1_button.BackColor = Color.Red
            gam_Jeom()
        End If
    End Sub

    Private Sub gam_Jeom_2_button_Click(sender As Object, e As EventArgs) Handles gam_Jeom_2_button.Click
        gam_Jeom_2_button_counter = gam_Jeom_2_button_counter + 1

        If (gam_Jeom_1_button_counter + gam_Jeom_2_button_counter) = 1 Then
            gam_Jeom_1_button.BackColor = Color.Yellow
            Me.time_ended_2_label.Text = timer_value
            form2.time_ended_2_label.Text = timer_value
            total_score_p2 = Convert.ToSingle(total_score_p2_text_output.Text)
            total_score_p2 = total_score_p2 - 1
            Me.total_score_p2_text_output.Text = Convert.ToString(total_score_p2)
            'form2.score_poomse_2_label.Text = total_score_p2_text_output.Text
        Else
            gam_Jeom_1_button.BackColor = Color.Red
            gam_Jeom()
        End If


    End Sub

    Private Sub save_result_button_Click(sender As Object, e As EventArgs) Handles save_result_button.Click

        If (Me.player_name_text_input.Text = "") And (Me.distric_text_input.Text = "") Then
            Exit Sub
        End If

        Dim player_name As String
        Dim player_district As String
        Dim player_age_group As String
        Dim player_found As Boolean = False
        Dim Header_found As Boolean = False

        If player_data_file = "" Then
            Dim saveFileDialog2 As New SaveFileDialog()
            saveFileDialog2.Filter = "Excel File(*.xlsx)|*.xlsx|Excel File(*.xls)|*.xls"
            saveFileDialog2.FilterIndex = 2
            saveFileDialog2.RestoreDirectory = True
            saveFileDialog2.CheckFileExists = False

            If saveFileDialog2.ShowDialog = DialogResult.OK Then
                player_data_file = saveFileDialog2.FileName
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If

        'test player details exist in excel(player name + age group + nationality)
        'If player exist Update the details

        'Read excel file

        ' The code below requires you to add references to Office Interop assemblies
        ' into your VB.NET project  (if you don't know how to do that search Google)

        Try

            Dim SourcePath As String = player_data_file 'This is just an example string and could be anything, it maps to fileToCopy in your code.
            If System.IO.File.Exists(SourcePath) Then
                'The file exists
                Dim xlApp = New Excel.Application
                Dim xlWorkBook = xlApp.Workbooks.Open(player_data_file)


                Dim xlWorkSheet = xlWorkBook.Worksheets("Sheet1")

                'If xlWorkSheet = xlWorkBook.Sheets("Sheet1") Then
                ' Dim xlWorkSheet = xlWorkBook.Sheets("Sheet1") '
                'End If

                Dim Range = xlWorkSheet.UsedRange


                'Check Header exist
                For cCnt = 1 To Range.Columns.Count

                    If CType(Range.Cells(1, cCnt), Excel.Range).Value.ToString = "Name" Then
                        Header_found = True
                        Exit For
                    End If
                Next

                For rCnt = 1 To Range.Rows.Count
                    player_name = CType(Range.Cells(rCnt, 5), Excel.Range).Value.ToString
                    player_district = CType(Range.Cells(rCnt, 6), Excel.Range).Value.ToString
                    player_age_group = CType(Range.Cells(rCnt, 7), Excel.Range).Value.ToString

                    ' Obj.value now contains the value in the cell.. 

                    If (player_name = Me.player_name_text_input.Text) And (player_district = Me.distric_text_input.Text) Then
                        player_found = True

                        'Player found update the row rCnt


                        Exit For
                    End If

                Next

                'If Header_found = False Write headers
                If Header_found = False Then
                    Range.Cells(1, 1).Value = "Match Number"
                    Range.Cells(1, 2).Value = "Final Score"
                    Range.Cells(1, 3).Value = "Total Score - P1"
                    Range.Cells(1, 4).Value = "Total Score - P2"
                    Range.Cells(1, 5).Value = "Name"
                    Range.Cells(1, 6).Value = "Nation/State/District"
                    Range.Cells(1, 7).Value = "Age Group"
                    Range.Cells(1, 8).Value = "Poomsae Type"
                    Range.Cells(1, 9).Value = "Number of Poomsae"
                    Range.Cells(1, 10).Value = "Name of Poomsae 1"
                    Range.Cells(1, 11).Value = "Name of Poomsae 2"
                    Range.Cells(1, 12).Value = "Number of Referee"
                    Range.Cells(1, 13).Value = "J1-P1"
                    Range.Cells(1, 14).Value = "J2-P1"
                    Range.Cells(1, 15).Value = "J3-P1"
                    Range.Cells(1, 16).Value = "J4-P1"
                    Range.Cells(1, 17).Value = "J5-P1"
                    Range.Cells(1, 18).Value = "J6-P1"
                    Range.Cells(1, 19).Value = "J7-P1"
                    Range.Cells(1, 20).Value = "J1-P2"
                    Range.Cells(1, 21).Value = "J2-P2"
                    Range.Cells(1, 22).Value = "J3-P2"
                    Range.Cells(1, 23).Value = "J4-P2"
                    Range.Cells(1, 24).Value = "J5-P2"
                    Range.Cells(1, 25).Value = "J6-P2"
                    Range.Cells(1, 26).Value = "J7-P2"
                    Range.Cells(1, 27).Value = "Time Ended – P1"
                    Range.Cells(1, 28).Value = "Time Ended – P2"
                End If


                'If player does not exist Create new entry appand entry in the last
                Dim total_columns = Range.Rows.Count + 1

                Range.Cells(total_columns, 1).Value = Me.match_number_text_input.Text
                Range.Cells(total_columns, 2).Value = Me.final_score_text_output.Text
                Range.Cells(total_columns, 3).Value = Me.total_score_p1_text_output.Text
                Range.Cells(total_columns, 4).Value = Me.total_score_p2_text_output.Text
                Range.Cells(total_columns, 5).Value = Me.player_name_text_input.Text
                Range.Cells(total_columns, 6).Value = Me.distric_text_input.Text
                Range.Cells(total_columns, 7).Value = Convert.ToString(Me.age_group_combo_box.SelectedItem)
                Range.Cells(total_columns, 8).Value = Convert.ToString(Me.poomsae_type_combo_box.SelectedItem)
                Range.Cells(total_columns, 9).Value = Convert.ToString(Me.no_of_poomsae_combo_box.SelectedItem)
                Range.Cells(total_columns, 10).Value = Convert.ToString(Me.name_of_poomsae_p1_combo_box.SelectedItem)
                Range.Cells(total_columns, 11).Value = Convert.ToString(Me.name_of_poomsae_p2_combo_box.SelectedItem)
                Range.Cells(total_columns, 12).Value = Convert.ToString(Me.no_of_refree_p1_combo_box.SelectedItem)
                Range.Cells(total_columns, 13).Value = Me.Judge_score_j1_1_number_input.Text
                Range.Cells(total_columns, 14).Value = Me.Judge_score_j2_1_number_input.Text
                Range.Cells(total_columns, 15).Value = Me.Judge_score_j3_1_number_input.Text
                Range.Cells(total_columns, 16).Value = Me.Judge_score_j4_1_number_input.Text
                Range.Cells(total_columns, 17).Value = Me.Judge_score_j5_1_number_input.Text
                Range.Cells(total_columns, 18).Value = Me.Judge_score_j6_1_number_input.Text
                Range.Cells(total_columns, 19).Value = Me.Judge_score_j7_1_number_input.Text
                Range.Cells(total_columns, 20).Value = Me.Judge_score_j1_2_number_input.Text
                Range.Cells(total_columns, 21).Value = Me.Judge_score_j2_2_number_input.Text
                Range.Cells(total_columns, 22).Value = Me.Judge_score_j3_2_number_input.Text
                Range.Cells(total_columns, 23).Value = Me.Judge_score_j4_2_number_input.Text
                Range.Cells(total_columns, 24).Value = Me.Judge_score_j5_2_number_input.Text
                Range.Cells(total_columns, 25).Value = Me.Judge_score_j6_2_number_input.Text
                Range.Cells(total_columns, 26).Value = Me.Judge_score_j7_2_number_input.Text
                Range.Cells(total_columns, 27).Value = Me.time_ended_1_label.Text
                Range.Cells(total_columns, 28).Value = Me.time_ended_2_label.Text

                xlApp.SaveAs(player_data_file)

                ' Release object references.
                xlApp = Nothing
                xlWorkBook = Nothing
                xlWorkSheet = Nothing
                Range = Nothing

            Else

                'the file doesn't exist
                Dim appXL As Excel.Application
                Dim wbXl As Excel.Workbook
                Dim shXL As Excel.Worksheet
                Dim raXL As Excel.Range

                ' Start Excel and get Application object.
                appXL = CType(CreateObject("Excel.Application"), Excel.Application)
                appXL.Visible = False

                ' Add a New workbook.
                wbXl = appXL.Workbooks.Add
                shXL = CType(wbXl.ActiveSheet, Excel.Worksheet)

                ' Add table headers going cell by cell.
                shXL.Cells(1, 1).Value = "Match Number"
                shXL.Cells(1, 2).Value = "Final Score"
                shXL.Cells(1, 3).Value = "Total Score - P1"
                shXL.Cells(1, 4).Value = "Total Score - P2"
                shXL.Cells(1, 5).Value = "Name"
                shXL.Cells(1, 6).Value = "Nation/State/District"
                shXL.Cells(1, 7).Value = "Age Group"
                shXL.Cells(1, 8).Value = "Poomsae Type"
                shXL.Cells(1, 9).Value = "Number of Poomsae"
                shXL.Cells(1, 10).Value = "Name of Poomsae 1"
                shXL.Cells(1, 11).Value = "Name of Poomsae 2"
                shXL.Cells(1, 12).Value = "Number of Referee"
                shXL.Cells(1, 13).Value = "J1-P1"
                shXL.Cells(1, 14).Value = "J2-P1"
                shXL.Cells(1, 15).Value = "J3-P1"
                shXL.Cells(1, 16).Value = "J4-P1"
                shXL.Cells(1, 17).Value = "J5-P1"
                shXL.Cells(1, 18).Value = "J6-P1"
                shXL.Cells(1, 19).Value = "J7-P1"
                shXL.Cells(1, 20).Value = "J1-P2"
                shXL.Cells(1, 21).Value = "J2-P2"
                shXL.Cells(1, 22).Value = "J3-P2"
                shXL.Cells(1, 23).Value = "J4-P2"
                shXL.Cells(1, 24).Value = "J5-P2"
                shXL.Cells(1, 25).Value = "J6-P2"
                shXL.Cells(1, 26).Value = "J7-P2"
                shXL.Cells(1, 27).Value = "Time Ended – P1"
                shXL.Cells(1, 28).Value = "Time Ended – P2"



                Dim total_columns = 2

                shXL.Cells(total_columns, 1).Value = Me.match_number_text_input.Text
                shXL.Cells(total_columns, 2).Value = Me.final_score_text_output.Text
                shXL.Cells(total_columns, 3).Value = Me.total_score_p1_text_output.Text
                shXL.Cells(total_columns, 4).Value = Me.total_score_p2_text_output.Text
                shXL.Cells(total_columns, 5).Value = Me.player_name_text_input.Text
                shXL.Cells(total_columns, 6).Value = Me.distric_text_input.Text
                shXL.Cells(total_columns, 7).Value = Convert.ToString(Me.age_group_combo_box.SelectedItem)
                shXL.Cells(total_columns, 8).Value = Convert.ToString(Me.poomsae_type_combo_box.SelectedItem)
                shXL.Cells(total_columns, 9).Value = Convert.ToString(Me.no_of_poomsae_combo_box.SelectedItem)
                shXL.Cells(total_columns, 10).Value = Convert.ToString(Me.name_of_poomsae_p1_combo_box.SelectedItem)
                shXL.Cells(total_columns, 11).Value = Convert.ToString(Me.name_of_poomsae_p2_combo_box.SelectedItem)
                shXL.Cells(total_columns, 12).Value = Convert.ToString(Me.no_of_refree_p1_combo_box.SelectedItem)
                shXL.Cells(total_columns, 13).Value = Me.Judge_score_j1_1_number_input.Text
                shXL.Cells(total_columns, 14).Value = Me.Judge_score_j2_1_number_input.Text
                shXL.Cells(total_columns, 15).Value = Me.Judge_score_j3_1_number_input.Text
                shXL.Cells(total_columns, 16).Value = Me.Judge_score_j4_1_number_input.Text
                shXL.Cells(total_columns, 17).Value = Me.Judge_score_j5_1_number_input.Text
                shXL.Cells(total_columns, 18).Value = Me.Judge_score_j6_1_number_input.Text
                shXL.Cells(total_columns, 19).Value = Me.Judge_score_j7_1_number_input.Text
                shXL.Cells(total_columns, 20).Value = Me.Judge_score_j1_2_number_input.Text
                shXL.Cells(total_columns, 21).Value = Me.Judge_score_j2_2_number_input.Text
                shXL.Cells(total_columns, 22).Value = Me.Judge_score_j3_2_number_input.Text
                shXL.Cells(total_columns, 23).Value = Me.Judge_score_j4_2_number_input.Text
                shXL.Cells(total_columns, 24).Value = Me.Judge_score_j5_2_number_input.Text
                shXL.Cells(total_columns, 25).Value = Me.Judge_score_j6_2_number_input.Text
                shXL.Cells(total_columns, 26).Value = Me.Judge_score_j7_2_number_input.Text
                shXL.Cells(total_columns, 27).Value = Me.time_ended_1_label.Text
                shXL.Cells(total_columns, 28).Value = Me.time_ended_2_label.Text

                wbXl.SaveAs(player_data_file)

                ' Release object references.
                raXL = Nothing
                shXL = Nothing
                wbXl = Nothing
                appXL.Quit()

            End If


        Catch err As Exception
            MessageBox.Show("Player Details no save.")
        End Try

        'test file exit


    End Sub

    Private Sub back_poomsae_form_button_Click(sender As Object, e As EventArgs) Handles back_poomsae_form_button.Click
        Home.Show()
        Me.Hide()
        form2.Hide()
    End Sub
End Class