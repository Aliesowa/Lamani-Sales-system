Imports System.Data.SqlClient
Public Class CreditorsPaymentControl
    Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")

    Private Sub CreditPaymentGrid_Click(sender As Object, e As EventArgs) Handles CreditPaymentGrid.Click

    End Sub

    Private Sub CreditorsPaymentControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Sub loadcreditpaymentgrid()
        ' Make the grid read-only. 
        GridView1.OptionsBehavior.Editable = False
        ' Prevent the focused cell from being highlighted. 
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        ' Draw a dotted focus rectangle around the entire row. 
        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus


        Dim tb As New DataTable
        Dim cmd As New SqlCommand
        cmd.Connection = connection

        Dim adpt As New SqlDataAdapter(" select * from Sales", connection)

        adpt.Fill(tb)

        CreditPaymentGrid.DataSource = tb

        GridView1.Columns(" ").Visible = False

    End Sub
End Class
