Option Strict On
Public Class Category_Class
    Private Category_Name As String
    Private Category_min_range_age As Integer
    Private Category_max_range_age As Integer
    Private Category_min_range_weight As Single
    Private Category_max_range_weight As Single
    Private Category_Player() As Player_Class

    'Declarering an array with unknown size
    'Then you use the Redim function to change the size of it at run time.
    'And just to add to Buzby's post, use ReDim Preserve to keep all your existing array elements when you extend your array

    'Dim New_Player As New Player_Class
    'ReDim Preserve players_in_category_array_of_player_object(players_in_category_array_of_player_object.Length) = New_Player

    Public players_in_category_array_of_player_object() As Player_Class

    'Public constructor for the class to initialize the args to variables
    Public Sub New(ByVal Player_Args As Player_Class(),
                   Optional ByVal Category_Name_Args As String = Nothing,
                   Optional ByVal Category_min_range_age_Args As Integer = -1,
                   Optional ByVal Category_max_range_age_Args As Integer = -1,
                   Optional ByVal Category_min_range_weight_Args As Single = -1.0F,
                   Optional ByVal Category_max_range_weight_Args As Single = -1.0F)

        If Player_Args IsNot Nothing Then
            Category_Player = Player_Args
        End If
        If Category_Name_Args IsNot Nothing Then
            Category_Name = Category_Name_Args
        End If
        If (Category_min_range_age_Args <> -1) And (Category_max_range_age_Args <> -1) Then
            Category_min_range_age = Category_min_range_age_Args
            Category_max_range_age = Category_max_range_age_Args
            For i = 0 To Category_Player.Length - 1
                Dim Current_Year As Integer = Date.Today.Year
                Dim Year_Of_Birth As Integer = Category_Player(i).Year_Of_Birth
                Dim Age As Integer = Current_Year - Year_Of_Birth
                If (Age > Category_min_range_age_Args) And (Age < Category_max_range_age_Args) Then
                    If players_in_category_array_of_player_object Is Nothing Then
                        ReDim Preserve players_in_category_array_of_player_object(0)
                    Else
                        ReDim Preserve players_in_category_array_of_player_object(players_in_category_array_of_player_object.Length)
                    End If

                    players_in_category_array_of_player_object(players_in_category_array_of_player_object.Length - 1) = Category_Player(i)
                End If
            Next
        Else
            Return
        End If
        If (Category_min_range_weight_Args <> -1.0F) And (Category_max_range_weight_Args <> -1.0F) Then
            Category_min_range_weight = Category_min_range_weight_Args
            Category_max_range_weight = Category_max_range_weight_Args
            For i = 0 To Category_Player.Length - 1
                Dim Weight As Single = Category_Player(i).Weight
                If (Weight > Category_min_range_weight_Args) And (Weight < Category_max_range_weight_Args) Then
                    ReDim Preserve players_in_category_array_of_player_object(players_in_category_array_of_player_object.Length)
                    players_in_category_array_of_player_object(players_in_category_array_of_player_object.Length - 1) = Category_Player(i)
                End If
            Next
        Else
            Return
        End If
    End Sub
End Class
