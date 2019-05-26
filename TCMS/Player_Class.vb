Option Strict On
Public Class Player_Class
    'For total players
    Public Shared Total_Players As Integer = 0

    'This class can store all the player info and results

    Public match_number_text_input As String
    Public Sex As String   'Male  or Female
    Public Name As String
    Public Name_HeaderText As String = "Player Name"
    Public District_State_Nation As String
    Public District_State_Nation_HeaderText As String = "District/State/Nation"
    Public Year_Of_Birth As Integer
    Public Year_Of_Birth_HeaderText As String = "Year Of Birth"
    Public Weight As Single
    Public Weight_HeaderText As String = "Weight"
    Public Team_Name As String
    Public Kyorugi_player As Boolean       'True if player participate in Kyorugi
    Public Poomsae_Player As Boolean       'True if player participate in Poomsae
    '...


    'Player Poomsae game data and Result
    Public Poomsae_champianship_date As Date
    Public Poomsae_Result As String
    Public poomsae_type_combo_box As String
    Public age_group_combo_box As String
    Public no_of_poomsae_combo_box As Integer
    Public name_of_poomsae_p1_combo_box As String
    Public name_of_poomsae_p2_combo_box As String
    Public no_of_refree_p1_combo_box As Integer
    Public Judge_name_j1_1_text_input As String
    Public Judge_score_j1_1_number_input As Single
    Public Judge_name_j2_1_text_input As String
    Public Judge_score_j2_1_number_input As Single
    Public Judge_name_j3_1_text_input As String
    Public Judge_score_j3_1_number_input As Single
    Public Judge_name_j4_1_text_input As String
    Public Judge_score_j4_1_number_input As Single
    Public Judge_name_j5_1_text_input As String
    Public Judge_score_j5_1_number_input As Single
    Public Judge_name_j6_1_text_input As String
    Public Judge_score_j6_1_number_input As Single
    Public Judge_name_j7_1_text_input As String
    Public Judge_score_j7_1_number_input As Single
    Public no_of_refree_p2_combo_box As Integer
    Public Judge_name_j1_2_text_input As String
    Public Judge_score_j1_2_number_input As Single
    Public Judge_name_j2_2_text_input As String
    Public Judge_score_j2_2_number_input As Single
    Public Judge_name_j3_2_text_input As String
    Public Judge_score_j3_2_number_input As Single
    Public Judge_name_j4_2_text_input As String
    Public Judge_score_j4_2_number_input As Single
    Public Judge_name_j5_2_text_input As String
    Public Judge_score_j5_2_number_input As Single
    Public Judge_name_j6_2_text_input As String
    Public Judge_score_j6_2_number_input As Single
    Public Judge_name_j7_2_text_input As String
    Public Judge_score_j7_2_number_input As Single
    Public total_score_p1_text_output As Single
    Public time_ended_1_label As String
    Public total_score_p2_text_output As Single
    Public time_ended_2_label As String
    Public final_score_text_output As Single

    'Player kyorugi game data and Result
    Public kyorugi_champianship_date As Date
    Public kyorugi_Result As String
    '...


    'Public constructor for the class to initialize the args to variables
    Public Sub New(Optional ByVal Sex_Args As String = Nothing,
                   Optional ByVal match_number_text_input_Args As String = Nothing,
                   Optional ByVal Name_Args As String = Nothing,
                   Optional ByVal Name_HeaderText_Args As String = Nothing,
                   Optional ByVal District_State_Nation_Args As String = Nothing,
                   Optional ByVal District_State_Nation_HeaderText_Args As String = Nothing,
                   Optional ByVal Year_Of_Birth_Args As Integer = Nothing,
                   Optional ByVal Year_Of_Birth_HeaderText_Args As String = Nothing,
                   Optional ByVal Weight_Args As Single = Nothing,
                   Optional ByVal Weight_HeaderText_Args As String = Nothing,
                   Optional ByVal Team_Name_Args As String = Nothing,
                   Optional ByVal Kyorugi_player_Args As Boolean = Nothing,
                   Optional ByVal Poomsae_Player_Args As Boolean = Nothing,
                   Optional ByVal Poomsae_champianship_date_Args As Date = Nothing,
                   Optional ByVal Poomsae_Result_Args As String = Nothing,
                   Optional ByVal poomsae_type_combo_box_Args As String = Nothing,
                   Optional ByVal age_group_combo_box_Args As String = Nothing,
                   Optional ByVal no_of_poomsae_combo_box_Args As Integer = Nothing,
                   Optional ByVal name_of_poomsae_p1_combo_box_Args As String = Nothing,
                   Optional ByVal name_of_poomsae_p2_combo_box_Args As String = Nothing,
                   Optional ByVal no_of_refree_p1_combo_box_Args As Integer = Nothing,
                   Optional ByVal Judge_name_j1_1_text_input_Args As String = Nothing,
                   Optional ByVal Judge_score_j1_1_number_input_Args As Single = Nothing,
                   Optional ByVal Judge_name_j2_1_text_input_Args As String = Nothing,
                   Optional ByVal Judge_score_j2_1_number_input_Args As Single = Nothing,
                   Optional ByVal Judge_name_j3_1_text_input_Args As String = Nothing,
                   Optional ByVal Judge_score_j3_1_number_input_Args As Single = Nothing,
                   Optional ByVal Judge_name_j4_1_text_input_Args As String = Nothing,
                   Optional ByVal Judge_score_j4_1_number_input_Args As Single = Nothing,
                   Optional ByVal Judge_name_j5_1_text_input_Args As String = Nothing,
                   Optional ByVal Judge_score_j5_1_number_input_Args As Single = Nothing,
                   Optional ByVal Judge_name_j6_1_text_input_Args As String = Nothing,
                   Optional ByVal Judge_score_j6_1_number_input_Args As Single = Nothing,
                   Optional ByVal Judge_name_j7_1_text_input_Args As String = Nothing,
                   Optional ByVal Judge_score_j7_1_number_input_Args As Single = Nothing,
                   Optional ByVal no_of_refree_p2_combo_box_Args As Integer = Nothing,
                   Optional ByVal Judge_name_j1_2_text_input_Args As String = Nothing,
                   Optional ByVal Judge_score_j1_2_number_input_Args As Single = Nothing,
                   Optional ByVal Judge_name_j2_2_text_input_Args As String = Nothing,
                   Optional ByVal Judge_score_j2_2_number_input_Args As Single = Nothing,
                   Optional ByVal Judge_name_j3_2_text_input_Args As String = Nothing,
                   Optional ByVal Judge_score_j3_2_number_input_Args As Single = Nothing,
                   Optional ByVal Judge_name_j4_2_text_input_Args As String = Nothing,
                   Optional ByVal Judge_score_j4_2_number_input_Args As Single = Nothing,
                   Optional ByVal Judge_name_j5_2_text_input_Args As String = Nothing,
                   Optional ByVal Judge_score_j5_2_number_input_Args As Single = Nothing,
                   Optional ByVal Judge_name_j6_2_text_input_Args As String = Nothing,
                   Optional ByVal Judge_score_j6_2_number_input_Args As Single = Nothing,
                   Optional ByVal Judge_name_j7_2_text_input_Args As String = Nothing,
                   Optional ByVal Judge_score_j7_2_number_input_Args As Single = Nothing,
                   Optional ByVal total_score_p1_text_output_Args As Single = Nothing,
                   Optional ByVal time_ended_1_label_Args As String = Nothing,
                   Optional ByVal total_score_p2_text_output_Args As Single = Nothing,
                   Optional ByVal time_ended_2_label_Args As String = Nothing,
                   Optional ByVal final_score_text_output_Args As Single = Nothing,
                   Optional ByVal kyorugi_champianship_date_Args As Date = Nothing,
                   Optional ByVal kyorugi_Result_Args As String = Nothing)
        'Add 1 for every instance of player object
        Total_Players = Total_Players + 1

        If match_number_text_input_Args <> Nothing Then
            match_number_text_input = match_number_text_input_Args
        End If
        If Poomsae_champianship_date_Args <> Nothing Then
            Poomsae_champianship_date = Poomsae_champianship_date_Args
        End If
        If Poomsae_Result_Args <> Nothing Then
            Poomsae_Result = Poomsae_Result_Args
        End If
        If poomsae_type_combo_box_Args <> Nothing Then
            poomsae_type_combo_box = poomsae_type_combo_box_Args
        End If
        If age_group_combo_box_Args <> Nothing Then
            age_group_combo_box = age_group_combo_box_Args
        End If
        If no_of_poomsae_combo_box_Args <> Nothing Then
            no_of_poomsae_combo_box = no_of_poomsae_combo_box_Args
        End If
        If name_of_poomsae_p1_combo_box_Args <> Nothing Then
            name_of_poomsae_p1_combo_box = name_of_poomsae_p1_combo_box_Args
        End If
        If name_of_poomsae_p2_combo_box_Args <> Nothing Then
            name_of_poomsae_p2_combo_box = name_of_poomsae_p2_combo_box_Args
        End If
        If no_of_refree_p1_combo_box_Args <> Nothing Then
            no_of_refree_p1_combo_box = no_of_refree_p1_combo_box_Args
        End If
        If no_of_refree_p2_combo_box_Args <> Nothing Then
            no_of_refree_p2_combo_box = no_of_refree_p2_combo_box_Args
        End If
        If Judge_name_j1_1_text_input_Args <> Nothing Then
            Judge_name_j1_1_text_input = Judge_name_j1_1_text_input_Args
        End If
        If Judge_score_j1_1_number_input_Args <> Nothing Then
            Judge_score_j1_1_number_input = Judge_score_j1_1_number_input_Args
        End If
        If Judge_name_j2_1_text_input_Args <> Nothing Then
            Judge_name_j2_1_text_input = Judge_name_j2_1_text_input_Args
        End If
        If Judge_score_j2_1_number_input_Args <> Nothing Then
            Judge_score_j2_1_number_input = Judge_score_j2_1_number_input_Args
        End If
        If Judge_name_j3_1_text_input_Args <> Nothing Then
            Judge_name_j3_1_text_input = Judge_name_j3_1_text_input_Args
        End If
        If Judge_score_j3_1_number_input_Args <> Nothing Then
            Judge_score_j3_1_number_input = Judge_score_j3_1_number_input_Args
        End If
        If Judge_name_j4_1_text_input_Args <> Nothing Then
            Judge_name_j4_1_text_input = Judge_name_j4_1_text_input_Args
        End If
        If Judge_score_j4_1_number_input_Args <> Nothing Then
            Judge_score_j4_1_number_input = Judge_score_j4_1_number_input_Args
        End If
        If Judge_name_j5_1_text_input_Args <> Nothing Then
            Judge_name_j5_1_text_input = Judge_name_j5_1_text_input_Args
        End If
        If Judge_score_j5_1_number_input_Args <> Nothing Then
            Judge_score_j5_1_number_input = Judge_score_j5_1_number_input_Args
        End If
        If Judge_name_j6_1_text_input_Args <> Nothing Then
            Judge_name_j6_1_text_input = Judge_name_j6_1_text_input_Args
        End If
        If Judge_score_j6_1_number_input_Args <> Nothing Then
            Judge_score_j6_1_number_input = Judge_score_j6_1_number_input_Args
        End If
        If Judge_name_j7_1_text_input_Args <> Nothing Then
            Judge_name_j7_1_text_input = Judge_name_j7_1_text_input_Args
        End If
        If Judge_score_j7_1_number_input_Args <> Nothing Then
            Judge_score_j7_1_number_input = Judge_score_j7_1_number_input_Args
        End If
        If no_of_refree_p2_combo_box_Args <> Nothing Then
            no_of_refree_p2_combo_box = no_of_refree_p2_combo_box_Args
        End If
        If Judge_name_j1_2_text_input_Args <> Nothing Then
            Judge_name_j1_2_text_input = Judge_name_j1_2_text_input_Args
        End If
        If Judge_score_j1_2_number_input_Args <> Nothing Then
            Judge_score_j1_2_number_input = Judge_score_j1_2_number_input_Args
        End If
        If Judge_name_j2_2_text_input_Args <> Nothing Then
            Judge_name_j2_2_text_input = Judge_name_j2_2_text_input_Args
        End If
        If Judge_score_j2_2_number_input_Args <> Nothing Then
            Judge_score_j2_2_number_input = Judge_score_j2_2_number_input_Args
        End If
        If Judge_name_j3_2_text_input_Args <> Nothing Then
            Judge_name_j3_2_text_input = Judge_name_j3_2_text_input_Args
        End If
        If Judge_score_j3_2_number_input_Args <> Nothing Then
            Judge_score_j3_2_number_input = Judge_score_j3_2_number_input_Args
        End If
        If Judge_name_j4_2_text_input_Args <> Nothing Then
            Judge_name_j4_2_text_input = Judge_name_j4_2_text_input_Args
        End If
        If Judge_score_j4_2_number_input_Args <> Nothing Then
            Judge_score_j4_2_number_input = Judge_score_j4_2_number_input_Args
        End If
        If Judge_name_j5_2_text_input_Args <> Nothing Then
            Judge_name_j5_2_text_input = Judge_name_j5_2_text_input_Args
        End If
        If Judge_score_j5_2_number_input_Args <> Nothing Then
            Judge_score_j5_2_number_input = Judge_score_j5_2_number_input_Args
        End If
        If Judge_name_j6_2_text_input_Args <> Nothing Then
            Judge_name_j6_2_text_input = Judge_name_j6_2_text_input_Args
        End If
        If Judge_score_j6_2_number_input_Args <> Nothing Then
            Judge_score_j6_2_number_input = Judge_score_j6_2_number_input_Args
        End If
        If Judge_name_j7_2_text_input_Args <> Nothing Then
            Judge_name_j7_2_text_input = Judge_name_j7_2_text_input_Args
        End If
        If Judge_score_j7_2_number_input_Args <> Nothing Then
            Judge_score_j7_2_number_input = Judge_score_j7_2_number_input_Args
        End If
        If total_score_p1_text_output_Args <> Nothing Then
            total_score_p1_text_output = total_score_p1_text_output_Args
        End If
        If time_ended_1_label_Args <> Nothing Then
            time_ended_1_label = time_ended_1_label_Args
        End If
        If total_score_p2_text_output_Args <> Nothing Then
            total_score_p2_text_output = total_score_p2_text_output_Args
        End If
        If time_ended_2_label_Args <> Nothing Then
            time_ended_2_label = time_ended_2_label_Args
        End If
        If final_score_text_output_Args <> Nothing Then
            final_score_text_output = final_score_text_output_Args
        End If
        If kyorugi_champianship_date_Args <> Nothing Then
            kyorugi_champianship_date = kyorugi_champianship_date_Args
        End If
        If kyorugi_Result_Args <> Nothing Then
            kyorugi_Result = kyorugi_Result_Args
        End If

    End Sub

    Protected Overrides Sub Finalize()
        Total_Players = Total_Players - 1
    End Sub

End Class
