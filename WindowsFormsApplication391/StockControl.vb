Imports System.Data.SqlClient

Public Class StockControl

    Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")

    Public Sub StockControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
        loadstockgrid()
        connection.Close()

    End Sub

    'Sub stocklist()

    '    Try



    '        Dim tb As New DataTable
    '        Dim adpt As New SqlDataAdapter("select * From Products", connection)

    '        adpt.Fill(tb)
    '        stockbox.DataSource = tb
    '        stockbox.DisplayMember = "productName"
    '        stockbox.ValueMember = "productName"


    '    Catch ex As Exception
    '        MsgBox(ex.Message)



    '    End Try


    'End Sub

    Sub loadstockgrid()
        ' Make the grid read-only. 
        GridView1.OptionsBehavior.Editable = False
        ' Prevent the focused cell from being highlighted. 
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        ' Draw a dotted focus rectangle around the entire row. 
        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus


        Dim tb As New DataTable
        Dim cmd As New SqlCommand
        cmd.Connection = connection

        Dim adpt As New SqlDataAdapter(" select * from Instock", connection)

        adpt.Fill(tb)

        StockGrid.DataSource = tb



    End Sub


    'Private Sub SearchControl1_TextChanged(sender As Object, e As EventArgs)
    '    If SearchControl1.Text <> String.Empty Then


    '        Dim index As Integer = stockbox.FindString(SearchControl1.Text)
    '        Determine If a valid index is returned. Select the item if it is valid. 
    '        If index <> -1 Then
    '            stockbox.SetSelected(index, True)
    '        Else

    '        End If


    '    End If
    'End Sub


    'Private Sub stockbox_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    'get the selected value from the listbox in stock And display total stock And stock available

    '    Dim cmds As New SqlCommand

    '    cmds.Connection = connection

    '    Dim stockboxlist As String = stockbox.SelectedValue.ToString()


    '    cmds.CommandText = "select * from instock where ProductName = '" & stockboxlist & "' "



    '    Dim rds As SqlDataReader

    '    rds = cmds.ExecuteReader
    '    'displaying to the textbox in stock

    '    While rds.Read
    '        totalstock.Text = rds("Total Stock").ToString

    '        stocksold.Text = rds("Stock Sold").ToString
    '        stockavail.Text = rds("Stock Available").ToString
    '        currentprice.Text = "Le " + rds("Current Price").ToString()
    '    End While

    '    rds.Close()







    'End Sub

End Class
