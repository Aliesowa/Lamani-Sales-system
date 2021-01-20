Imports System.Data.SqlClient




Public Class expenControl


    Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")







    Private Sub expen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make the grid read-only. 
        GridView1.OptionsBehavior.Editable = False
        ' Prevent the focused cell from being highlighted. 
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        ' Draw a dotted focus rectangle around the entire row. 
        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus

        Dim tb As New DataTable
        Dim cmd As New SqlCommand
        cmd.Connection = connection

        Dim adpt As New SqlDataAdapter(" select * from Expenditures", connection)

        adpt.Fill(tb)

        expengrid.DataSource = tb

        GridView1.Columns("ExpenditureID").Visible = False
    End Sub


End Class
