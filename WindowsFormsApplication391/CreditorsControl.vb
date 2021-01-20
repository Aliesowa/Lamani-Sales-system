Imports System.Data.SqlClient

Public Class CreditorsControl
    Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")

    Private Sub CreditorsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make the grid read-only. 
        GridView1.OptionsBehavior.Editable = False
        ' Prevent the focused cell from being highlighted. 
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        ' Draw a dotted focus rectangle around the entire row. 
        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus


        Dim tb As New DataTable
        Dim cmd As New SqlCommand
        cmd.Connection = connection

        Dim adpt As New SqlDataAdapter("select * from Creditors ", connection)

        adpt.Fill(tb)

        CreditorGrid.DataSource = tb

        GridView1.Columns("CreditorsID").Visible = False
    End Sub
End Class
