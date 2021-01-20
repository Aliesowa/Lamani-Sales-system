Imports System.Data.SqlClient

Public Class CustomersContro
    Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")



    Private Sub CustomersControlling_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Make the grid read-only. 
        GridView1.OptionsBehavior.Editable = False
        ' Prevent the focused cell from being highlighted. 
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        ' Draw a dotted focus rectangle around the entire row. 
        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus


        Dim tb As New DataTable
        Dim cmd As New SqlCommand
        cmd.Connection = connection

        Dim adpt As New SqlDataAdapter(" select Customerid,CustomerCategory as 'Category', CustomerName as 'Customer Name',Address, Tel as 'Mobile',EmailAddress as 'Email Address',OwnerName as 'Owner',
                                            OwnerMobile as 'Owners Mobile', ContactPersonName as 'Contact Person', ContactPersonMobile as'Contact Persons Mobile',Status
                            from Customers", connection)

        adpt.Fill(tb)

        customergrid.DataSource = tb

        GridView1.Columns("Customerid").Visible = False
    End Sub
End Class
