Option Strict On
Imports System.Xml.Serialization
Imports System.IO

Public Class data_entry_kyorugi_form

    Dim ds As DataSet
    Dim ds_girls As DataSet
    Public Kyorugi_Player_girls() As Player_Class
    Public Kyorugi_Player_boys() As Player_Class

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Load_data_Button.Text = "Load Data"
        Add_Data_Button.Text = "Add data"
        Save_Data_Button.Text = "Save Data"
        'Create Dataset
        ds = CreateDataset()
        'Set DataGridView1 
        DataGridView1.DataSource = ds.Tables("Kyorugi_Player_boys")
        DataGridView1.Columns.Item(0).Width = 205
        DataGridView1.Columns.Item(0).HeaderText = "Player Name"
        DataGridView1.Columns.Item(0).HeaderText = "District/State/Nation"
        DataGridView1.Columns.Item(0).HeaderText = "Year Of Birth"
        DataGridView1.Columns.Item(0).HeaderText = "Weight"

        'Create Dataset_girls
        ds_girls = CreateDataset_girls()
        'Set DataGridView2 
        DataGridView2.DataSource = ds_girls.Tables("Kyorugi_Player_girls")
        DataGridView2.Columns.Item(0).Width = 205
        DataGridView2.Columns.Item(0).HeaderText = "Player Name"
        DataGridView2.Columns.Item(0).HeaderText = "District/State/Nation"
        DataGridView2.Columns.Item(0).HeaderText = "Year Of Birth"
        DataGridView2.Columns.Item(0).HeaderText = "Weight"
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Load_data_Button.Click
        LoadFromXMLfile("temp_player_data_boys.xml")
        LoadFromXMLfile_girls("temp_player_data_girls.xml")
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Add_Data_Button.Click
        AddDataToDataSetDynamically(ds)
        AddDataToDataset_girlsDynamically(ds_girls)
    End Sub
    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Save_Data_Button.Click
        SaveToXMLFile("temp_player_data_boys.xml", ds)
        SaveToXMLFile_girls("temp_player_data_girls.xml", ds_girls)
        SaveTo_Player_Class_Object_boys(ds)
        SaveTo_Player_Class_Object_girls(ds_girls)
    End Sub
    Private Function SaveTo_Player_Class_Object_boys(ds As DataSet) As Object

        For j As Integer = 0 To ds.Tables(0).Rows.Count - 1
            ReDim Preserve Kyorugi_Player_boys(j)
            Kyorugi_Player_boys(j) = New Player_Class()
            If Not IsDBNull(ds.Tables(0).Rows(j)(0)) Then
                Kyorugi_Player_boys(j).Name = ds.Tables(0).Rows(j)(0).ToString()
            End If

            If Not IsDBNull(ds.Tables(0).Rows(j)(1)) Then
                Kyorugi_Player_boys(j).District_State_Nation = ds.Tables(0).Rows(j)(1).ToString()
            End If

            If Not IsDBNull(ds.Tables(0).Rows(j)(2)) Then
                Kyorugi_Player_boys(j).Year_Of_Birth = Convert.ToInt16(ds.Tables(0).Rows(j)(2))
            End If

            If Not IsDBNull(ds.Tables(0).Rows(j)(3)) Then
                Kyorugi_Player_boys(j).Weight = Convert.ToSingle(ds.Tables(0).Rows(j)(3))
            End If

            'MessageBox.Show(Convert.ToString(Kyorugi_Player_boys.Length))
        Next
        Return Kyorugi_Player_boys
    End Function
    Private Function SaveTo_Player_Class_Object_girls(ds As DataSet) As Object

        'Static Dim Player() As Object
        For j As Integer = 0 To ds.Tables(0).Rows.Count - 1
            ReDim Preserve Kyorugi_Player_girls(j)
            Kyorugi_Player_girls(j) = New Player_Class()
            If Not IsDBNull(ds.Tables(0).Rows(j)(0)) Then
                Kyorugi_Player_girls(j).Name = ds.Tables(0).Rows(j)(0).ToString()
            End If

            If Not IsDBNull(ds.Tables(0).Rows(j)(1)) Then
                Kyorugi_Player_girls(j).District_State_Nation = ds.Tables(0).Rows(j)(1).ToString()
            End If

            If Not IsDBNull(ds.Tables(0).Rows(j)(2)) Then
                Kyorugi_Player_girls(j).Year_Of_Birth = Convert.ToInt16(ds.Tables(0).Rows(j)(2))
            End If

            If Not IsDBNull(ds.Tables(0).Rows(j)(3)) Then
                Kyorugi_Player_girls(j).Weight = Convert.ToSingle(ds.Tables(0).Rows(j)(3))
            End If

            'MessageBox.Show(Convert.ToString(Kyorugi_Player_girls.Length))
        Next
        Return Kyorugi_Player_girls
    End Function
    Private Function CreateDataset() As DataSet
        Dim dataset1 As New DataSet("Players_boys")
        Dim table1 As New DataTable("Kyorugi_Player_boys")
        table1.Columns.Add("Player Name")
        table1.Columns.Add("District/State/Nation")
        table1.Columns.Add("Year Of Birth")
        table1.Columns.Add("Weight")
        '...
        dataset1.Tables.Add(table1)
        Return dataset1

    End Function
    Private Function CreateDataset_girls() As DataSet
        Dim Dataset_girls1 As New DataSet("Players_girls")
        Dim table1 As New DataTable("Kyorugi_Player_girls")
        table1.Columns.Add("Player Name")
        table1.Columns.Add("District/State/Nation")
        table1.Columns.Add("Year Of Birth")
        table1.Columns.Add("Weight")
        '...
        Dataset_girls1.Tables.Add(table1)
        Return Dataset_girls1

    End Function
    Private Sub AddDataToDataSetDynamically(d As DataSet)
        d.Tables("Kyorugi_Player_boys").Rows.Add("Ramesh Kumar", "Allahabad", 1989, 76)
    End Sub
    Private Sub SaveToXMLFile(filename As String, d As DataSet)
        Dim ser As XmlSerializer = New XmlSerializer(GetType(DataSet))
        Dim writer As TextWriter = New StreamWriter(filename)
        ser.Serialize(writer, d)
        writer.Close()
    End Sub
    Private Sub LoadFromXMLfile(filename As String)
        If System.IO.File.Exists(filename) Then
            Dim xmlSerializer As XmlSerializer = New XmlSerializer(ds.GetType)
            Dim readStream As FileStream = New FileStream(filename, FileMode.Open)
            ds = CType(xmlSerializer.Deserialize(readStream), DataSet)
            readStream.Close()
            DataGridView1.DataSource = ds.Tables("Kyorugi_Player_boys")
        Else
            MsgBox("file not found! add data and press save button first.", MsgBoxStyle.Exclamation, "")
        End If
    End Sub
    Private Sub AddDataToDataset_girlsDynamically(d As DataSet)
        d.Tables("Kyorugi_Player_girls").Rows.Add("Sunita", "Allahabad", 1990, 56)
    End Sub
    Private Sub SaveToXMLFile_girls(filename As String, d As DataSet)
        Dim ser As XmlSerializer = New XmlSerializer(GetType(DataSet))
        Dim writer As TextWriter = New StreamWriter(filename)
        ser.Serialize(writer, d)
        writer.Close()
    End Sub
    Private Sub LoadFromXMLfile_girls(filename As String)
        If System.IO.File.Exists(filename) Then
            Dim xmlSerializer As XmlSerializer = New XmlSerializer(ds_girls.GetType)
            Dim readStream As FileStream = New FileStream(filename, FileMode.Open)
            ds_girls = CType(xmlSerializer.Deserialize(readStream), DataSet)
            readStream.Close()
            DataGridView2.DataSource = ds_girls.Tables("Kyorugi_Player_girls")
        Else
            MsgBox("file not found! add data and press save button first.", MsgBoxStyle.Exclamation, "")
        End If
    End Sub

    Private Sub DataGridView1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint

        Dim strRowNumber As String = (e.RowIndex + 1).ToString

        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)

        If DataGridView1.RowHeadersWidth < CInt((size.Width + 20)) Then
            DataGridView1.RowHeadersWidth = CInt((size.Width + 20))
        End If

        Dim b As Brush = SystemBrushes.ControlText


        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15,
                                  e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) _
                                                            / 2))

    End Sub
    Private Sub DataGridView2_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView2.RowPostPaint

        Dim strRowNumber As String = (e.RowIndex + 1).ToString

        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)

        If DataGridView2.RowHeadersWidth < CInt((size.Width + 20)) Then
            DataGridView2.RowHeadersWidth = CInt((size.Width + 20))
        End If

        Dim b As Brush = SystemBrushes.ControlText


        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15,
                                  e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) _
                                                            / 2))

    End Sub
    Private Sub data_entry_kyorugi_form_back_Button_Click(sender As Object, e As EventArgs) Handles data_entry_kyorugi_form_back_Button.Click
        Home.Show()
        Me.Hide()
    End Sub


    Private Sub appData(ByVal data As AutoCompleteStringCollection, ByVal c As String)
        data.Add("Allahabad")
        data.Add("Kanpur")
        data.Add("Lucknow")
        data.Add("Delhi")
    End Sub


    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        'If Not IsNothing(DataGridView1.Columns.Item("Player_Name").Index) Then

        If DataGridView1.CurrentCell.ColumnIndex = 1 Then
            Dim text As TextBox = TryCast(e.Control, TextBox)
            If text IsNot Nothing Then
                text.AutoCompleteMode = AutoCompleteMode.Suggest
                text.AutoCompleteSource = AutoCompleteSource.CustomSource

                Dim data As AutoCompleteStringCollection = New AutoCompleteStringCollection()
                appData(data, DataGridView1.CurrentCellAddress.ToString)
                text.AutoCompleteCustomSource = data
            End If
        ElseIf TypeOf e.Control Is TextBox Then
            Dim text As TextBox = TryCast(e.Control, TextBox)
            text.AutoCompleteCustomSource = Nothing
            text.AutoCompleteSource = AutoCompleteSource.None
            text.AutoCompleteMode = AutoCompleteMode.None
        End If
        'End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If (e.ColumnIndex = 2) Then   ' Checking numeric value for Column2 only
            Dim value As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            For Each c As Char In value
                If Not Char.IsDigit(c) Then
                    MessageBox.Show("Please enter numeric value.")
                    DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty
                    DataGridView1.ClearSelection()
                    'DataGridView1.CurrentCell = DataGridView1.Item(e.ColumnIndex, e.RowIndex)
                    ' DataGridView1.BeginEdit(True)
                    Exit Sub
                End If
            Next
        End If

        If (e.ColumnIndex = 3) Then   ' Checking numeric value for Column3 only
            Dim value As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            For Each c As Char In value
                If (Not Char.IsDigit(c)) Then

                    If ((Convert.ToString(c) = ".")) Then
                        Exit For
                    End If


                    MessageBox.Show("Please enter numeric value.")
                    DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty
                    DataGridView1.ClearSelection()
                    'DataGridView1.CurrentCell = DataGridView1.Item(e.ColumnIndex, e.RowIndex)
                    ' DataGridView1.BeginEdit(True)
                    Exit Sub
                End If
            Next

        End If

    End Sub

    Private Sub DataGridView2_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView2.EditingControlShowing
        'If Not IsNothing(DataGridView2.Columns.Item("Player_Name").Index) Then

        If DataGridView2.CurrentCell.ColumnIndex = 1 Then
            Dim text As TextBox = TryCast(e.Control, TextBox)
            If text IsNot Nothing Then
                text.AutoCompleteMode = AutoCompleteMode.Suggest
                text.AutoCompleteSource = AutoCompleteSource.CustomSource

                Dim data As AutoCompleteStringCollection = New AutoCompleteStringCollection()
                appData(data, DataGridView2.CurrentCellAddress.ToString)
                text.AutoCompleteCustomSource = data
            End If
        ElseIf TypeOf e.Control Is TextBox Then
            Dim text As TextBox = TryCast(e.Control, TextBox)
            text.AutoCompleteCustomSource = Nothing
            text.AutoCompleteSource = AutoCompleteSource.None
            text.AutoCompleteMode = AutoCompleteMode.None
        End If
        'End If
    End Sub

    Private Sub DataGridView2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        If (e.ColumnIndex = 2) Then   ' Checking numeric value for Column2 only
            Dim value As String = DataGridView2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            For Each c As Char In value
                If Not Char.IsDigit(c) Then
                    MessageBox.Show("Please enter numeric value.")
                    DataGridView2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty
                    DataGridView2.ClearSelection()
                    'DataGridView2.CurrentCell = DataGridView2.Item(e.ColumnIndex, e.RowIndex)
                    ' DataGridView2.BeginEdit(True)
                    Exit Sub
                End If
            Next
        End If

        If (e.ColumnIndex = 3) Then   ' Checking numeric value for Column3 only
            Dim value As String = DataGridView2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            For Each c As Char In value
                If (Not Char.IsDigit(c)) Then

                    If ((Convert.ToString(c) = ".")) Then
                        Exit For
                    End If


                    MessageBox.Show("Please enter numeric value.")
                    DataGridView2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = String.Empty
                    DataGridView2.ClearSelection()
                    'DataGridView2.CurrentCell = DataGridView2.Item(e.ColumnIndex, e.RowIndex)
                    ' DataGridView2.BeginEdit(True)
                    Exit Sub
                End If
            Next

        End If

    End Sub

    Private Sub Print_Preview_Boys_Data_Button_Click(sender As Object, e As EventArgs) Handles Print_Preview_Boys_Data_Button.Click
        Dim ppd As New PrintPreviewDialog
        ppd.Document = PrintDocument1
        ppd.WindowState = FormWindowState.Maximized
        ppd.ShowDialog()
    End Sub

    Private Sub Print_Boys_Data_Button_Click(sender As Object, e As EventArgs) Handles Print_Boys_Data_Button.Click
        PrintDocument1.Print()
    End Sub

    ''' <summary>
    ''' structire to hold printed page details
    ''' </summary>
    ''' <remarks></remarks>
    Private Structure pageDetails
        Dim columns As Integer
        Dim rows As Integer
        Dim startCol As Integer
        Dim startRow As Integer
    End Structure

    ''' <summary>
    ''' dictionary to hold printed page details, with index key
    ''' </summary>
    ''' <remarks></remarks>
    Private pages As Dictionary(Of Integer, pageDetails)

    Dim maxPagesWide As Integer
    Dim maxPagesTall As Integer



    ''' <summary>
    ''' the majority of this Sub is calculating printed page ranges
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        ''this removes the printed page margins
        PrintDocument1.OriginAtMargins = True
        PrintDocument1.DefaultPageSettings.Margins = New Drawing.Printing.Margins(0, 0, 0, 0)

        pages = New Dictionary(Of Integer, pageDetails)

        Dim maxWidth As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width) - 40
        Dim maxHeight As Integer = CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Height) - 40 + Boys_Label.Height

        Dim pageCounter As Integer = 0
        pages.Add(pageCounter, New pageDetails)

        Dim columnCounter As Integer = 0

        Dim columnSum As Integer = DataGridView1.RowHeadersWidth

        For c As Integer = 0 To DataGridView1.Columns.Count - 1
            If columnSum + DataGridView1.Columns(c).Width < maxWidth Then
                columnSum += DataGridView1.Columns(c).Width
                columnCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                columnSum = DataGridView1.RowHeadersWidth + DataGridView1.Columns(c).Width
                columnCounter = 1
                pageCounter += 1
                pages.Add(pageCounter, New pageDetails With {.startCol = c})
            End If
            If c = DataGridView1.Columns.Count - 1 Then
                If pages(pageCounter).columns = 0 Then
                    pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
                End If
            End If
        Next

        maxPagesWide = pages.Keys.Max + 1

        pageCounter = 0

        Dim rowCounter As Integer = 0

        Dim rowSum As Integer = DataGridView1.ColumnHeadersHeight

        For r As Integer = 0 To DataGridView1.Rows.Count - 2
            If rowSum + DataGridView1.Rows(r).Height < maxHeight Then
                rowSum += DataGridView1.Rows(r).Height
                rowCounter += 1
            Else
                pages(pageCounter) = New pageDetails With {.columns = pages(pageCounter).columns, .rows = rowCounter, .startCol = pages(pageCounter).startCol, .startRow = pages(pageCounter).startRow}
                For x As Integer = 1 To maxPagesWide - 1
                    pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter).startRow}
                Next

                pageCounter += maxPagesWide
                For x As Integer = 0 To maxPagesWide - 1
                    pages.Add(pageCounter + x, New pageDetails With {.columns = pages(x).columns, .rows = 0, .startCol = pages(x).startCol, .startRow = r})
                Next

                rowSum = DataGridView1.ColumnHeadersHeight + DataGridView1.Rows(r).Height
                rowCounter = 1
            End If
            If r = DataGridView1.Rows.Count - 2 Then
                For x As Integer = 0 To maxPagesWide - 1
                    If pages(pageCounter + x).rows = 0 Then
                        pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter + x).startRow}
                    End If
                Next
            End If
        Next

        maxPagesTall = pages.Count \ maxPagesWide

    End Sub

    ''' <summary>
    ''' this is the actual printing routine.
    ''' using the pagedetails i calculated earlier, it prints a title,
    ''' + as much of the datagridview as will fit on 1 page, then moves to the next page.
    ''' this is setup to be dynamic. try resizing the dgv columns or rows
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim rect As New Rectangle(20, 20, CInt(PrintDocument1.DefaultPageSettings.PrintableArea.Width), Boys_Label.Height) 'replace Boys_Label.Height with Label1.Height
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        e.Graphics.DrawString(Boys_Label.Text, Boys_Label.Font, Brushes.Black, rect, sf)

        sf.Alignment = StringAlignment.Near

        Dim startX As Integer = 50
        Dim startY As Integer = rect.Bottom

        Static startPage As Integer = 0

        For p As Integer = startPage To pages.Count - 1
            Dim cell As New Rectangle(startX, startY, DataGridView1.RowHeadersWidth, DataGridView1.ColumnHeadersHeight)
            e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
            e.Graphics.DrawRectangle(Pens.Black, cell)

            startY += DataGridView1.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows - 1
                cell = New Rectangle(startX, startY, DataGridView1.RowHeadersWidth, DataGridView1.Rows(r).Height)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                'e.Graphics.DrawString(DataGridView1.Rows(r).HeaderCell.Value.ToString, DataGridView1.Font, Brushes.Black, cell, sf)

                startY += DataGridView1.Rows(r).Height
            Next

            startX += cell.Width
            startY = rect.Bottom

            For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                cell = New Rectangle(startX, startY, DataGridView1.Columns(c).Width, DataGridView1.ColumnHeadersHeight)
                e.Graphics.FillRectangle(New SolidBrush(SystemColors.ControlLight), cell)
                e.Graphics.DrawRectangle(Pens.Black, cell)
                e.Graphics.DrawString(DataGridView1.Columns(c).HeaderCell.Value.ToString, DataGridView1.Font, Brushes.Black, cell, sf)
                startX += DataGridView1.Columns(c).Width
            Next

            startY = rect.Bottom + DataGridView1.ColumnHeadersHeight

            For r As Integer = pages(p).startRow To pages(p).startRow + pages(p).rows - 1
                startX = 50 + DataGridView1.RowHeadersWidth
                For c As Integer = pages(p).startCol To pages(p).startCol + pages(p).columns - 1
                    cell = New Rectangle(startX, startY, DataGridView1.Columns(c).Width, DataGridView1.Rows(r).Height)
                    e.Graphics.DrawRectangle(Pens.Black, cell)
                    e.Graphics.DrawString(DataGridView1(c, r).Value.ToString, DataGridView1.Font, Brushes.Black, cell, sf)
                    startX += DataGridView1.Columns(c).Width
                Next
                startY += DataGridView1.Rows(r).Height
            Next

            If p <> pages.Count - 1 Then
                startPage = p + 1
                e.HasMorePages = True
                Return
            Else
                startPage = 0
            End If

        Next

    End Sub

    Private Sub generate_category_Button_Click(sender As Object, e As EventArgs) Handles generate_category_Button.Click
        If Player_Class.Total_Players = 0 Then
            MsgBox("Players Data are Not saved, Please Save the Data.")
        Else
            generate_category_kyorugi_form.Show()
            Me.Hide()
        End If

    End Sub
End Class