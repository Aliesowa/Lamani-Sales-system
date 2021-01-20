Imports System.Data.SqlClient



Public Class Form2

    Public connection As New SqlConnection("server=ADMINRG-RKGDBT7\SQLEXPRESS; Database= SalesSystem; Integrated security = true  ")

    Private Sub CustomersContro1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CustomerDatagrid()


    End Sub

    Private Sub Savebtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Savebtn.ItemClick
        Customer()
        CustomerDatagrid()


    End Sub

    Friend Sub Customer()
        Dim rd As SqlDataReader
        Dim cmd As New SqlCommand



        connection.Open()
        If ConnectionState.Open Then
            MsgBox(connection.ToString)

        End If

        Try


            If business.Checked = True Then

                cmd.CommandText = "Insert into Customers values ( '" & customerName.Text + business.Text & "','" & business.Text & "', '" & customerName.Text & "',
                            '" & customerAddress.Text & "', '" & CustomerMobile.Text & "', '" & CustomerEmail.Text & "', '" & CustOwner.Text & "',
                            ' " & CustOwnerMob.Text & "',' " & CustContact.Text & "',' " & CustContactNo.Text & "' ,' " & CustomerStatus.Text & "') "
                cmd.Connection = connection

                rd = cmd.ExecuteReader
                MsgBox("Saved" + customerName.Text)

                rd.Close()



            ElseIf individual.Checked = True Then
                cmd.CommandText = "Insert into Customers (Customerid,CustomerCategory,CustomerName, Address,EmailAddress,Tel)  
                                    values ( '" & customerName.Text + individual.Text & "',' " & individual.Text & "', ' " & customerName.Text & "',' 
                                            " & customerAddress.Text & "',' " & CustomerEmail.Text & "', ' " & CustomerMobile.Text & "' )"
                cmd.Connection = connection

                rd = cmd.ExecuteReader
                MsgBox("Saved" + customerName.Text)
                rd.Close()


            End If

        Catch ex As Exception


            MsgBox(ex.Message)
        End Try

        connection.Close()

    End Sub

    Friend Sub CustomerDatagrid()


        ' Make the grid read-only. 
        GridView1.OptionsBehavior.Editable = False
        ' Prevent the focused cell from being highlighted. 
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        ' Draw a dotted focus rectangle around the entire row. 
        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus


        Dim tb As New DataTable
        Dim cmd As New SqlCommand
        cmd.Connection = connection

        Dim adpt As New SqlDataAdapter(" select CustomerCategory as 'Category', CustomerName as 'Customer Name',Address, Tel as 'Mobile',EmailAddress as 'Email Address',OwnerName as 'Owner',
                                            OwnerMobile as 'Owners Mobile', ContactPersonName as 'Contact Person', ContactPersonMobile as'Contact Persons Mobile',Status
                            from Customers", connection)

        adpt.Fill(tb)

        customergrid.DataSource = tb



    End Sub

    Private Sub customergrid_Click(sender As Object, e As EventArgs) Handles customergrid.Click

        CustomerMobile = GridView1.GetRowCellValue(3, 3).ToString

        customerName.Text = customergrid.get

        .Rows(e.RowIndex).Cells(0).Value '1st column
        itembox.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value '2nd column
        quantity.Value = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        price.Value = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        discount.Value = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        total.Text = "Le " + DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString


    End Sub
End Class