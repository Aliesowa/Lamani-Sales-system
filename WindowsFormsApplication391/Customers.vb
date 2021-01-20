



Imports System.Data.SqlClient



Public Class Customers
    Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")



    Friend Sub Customer()
        Dim rd As SqlDataReader
        Dim cmd As New SqlCommand



        connection.Open()


        Try
            If customerID.Text = Nothing Then


                If business.Checked = True Then

                    cmd.CommandText = "Insert into Customers values ( '" & customerName.Text + business.Text & "','" & business.Text & "', '" & customerName.Text & "',
                            '" & customerAddress.Text & "', '" & CustomerMobile.Text & "', '" & CustomerEmail.Text & "', '" & CustOwner.Text & "',
                            ' " & CustOwnerMob.Text & "',' " & CustContact.Text & "',' " & CustContactNo.Text & "' ,' " & CustomerStatus.Text & "') "
                    cmd.Connection = connection

                    rd = cmd.ExecuteReader
                    MessageBox.Show("Saved Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    rd.Close()



                ElseIf individual.Checked = True Then
                    cmd.CommandText = "Insert into Customers (Customerid,CustomerCategory,CustomerName, Address,EmailAddress,Tel,Status)  
                                    values ( '" & customerName.Text + individual.Text & "',' " & individual.Text & "', ' " & customerName.Text & "',' 
                                            " & customerAddress.Text & "',' " & CustomerEmail.Text & "', ' " & CustomerMobile.Text & "', ' " & CustomerStatus.Text & "' )"
                    cmd.Connection = connection

                    rd = cmd.ExecuteReader
                    MessageBox.Show("Saved Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    rd.Close()

                Else
                    MsgBox("Select a Category")
                End If

            Else
                If business.Checked = True Then

                    cmd.CommandText = "update Customers set CustomerCategory = '" & business.Text & "',  CustomerName = '" & customerName.Text & "', 
                                        Address = '" & customerAddress.Text & "', Tel ='" & CustomerMobile.Text & "',EmailAddress = '" & CustomerEmail.Text & "', 
                                        OwnerName= '" & CustOwner.Text & "',OwnerMobile = ' " & CustOwnerMob.Text & "', ContactPersonName = ' " & CustContact.Text & "',
                                        ContactPersonMobile = ' " & CustContactNo.Text & "',Status = ' " & CustomerStatus.Text & "' 
                                        where  Customerid = '" & customerID.Text & "' "

                    cmd.Connection = connection

                    rd = cmd.ExecuteReader
                    MessageBox.Show("Updated Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    rd.Close()



                ElseIf individual.Checked = True Then
                    cmd.CommandText = "update Customers  set CustomerCategory= ' " & individual.Text & "',  CustomerName= ' " & customerName.Text & "',
                                         Address = '" & customerAddress.Text & "',EmailAddress = ' " & CustomerEmail.Text & "', Tel = ' " & CustomerMobile.Text & "',
                                         Status = ' " & CustomerStatus.Text & "'  where  Customerid = '" & customerID.Text & "' "

                    cmd.Connection = connection

                    rd = cmd.ExecuteReader
                    MessageBox.Show("Updated Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    rd.Close()

                End If

            End If

        Catch ex As Exception


            MsgBox(ex.Message)
        Finally
            CustomerDatagrid()
            connection.Close()
        End Try

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

        Dim adpt As New SqlDataAdapter(" select Customerid,CustomerCategory as 'Category', CustomerName as 'Customer Name',Address, Tel as 'Mobile',EmailAddress as 'Email Address',OwnerName as 'Owner',
                                            OwnerMobile as 'Owners Mobile', ContactPersonName as 'Contact Person', ContactPersonMobile as'Contact Persons Mobile',Status
                            from Customers", connection)

        adpt.Fill(tb)

        customergrid.DataSource = tb
        adpt.Dispose()

        GridView1.Columns("Customerid").Visible = False


    End Sub

    Private Sub customergrid_Click(sender As Object, e As EventArgs) Handles customergrid.Click
        customerID.Text = GridView1.GetFocusedRowCellValue("Customerid").ToString
        customerName.Text = GridView1.GetFocusedRowCellValue("Customer Name").ToString
        customerAddress.Text = GridView1.GetFocusedRowCellValue("Address").ToString
        CustomerEmail.Text = GridView1.GetFocusedRowCellValue("Email Address").ToString
        CustomerMobile.Text = GridView1.GetFocusedRowCellValue("Mobile").ToString
        CustOwner.Text = GridView1.GetFocusedRowCellValue("Owner").ToString
        CustOwnerMob.Text = GridView1.GetFocusedRowCellValue("Owners Mobile").ToString
        CustContact.Text = GridView1.GetFocusedRowCellValue("Contact Person").ToString
        CustContactNo.Text = GridView1.GetFocusedRowCellValue("Contact Persons Mobile").ToString
        CustomerStatus.Text = GridView1.GetFocusedRowCellValue("Status").ToString


        Dim Dr As DataRow = GridView1.GetFocusedDataRow

        If Dr(1).ToString = individual.Text Then
            individual.Checked = True

        ElseIf Dr(1).ToString = business.Text Then
            business.Checked = True

        End If


    End Sub

    Private Sub business_CheckedChanged(sender As Object, e As EventArgs) Handles business.CheckedChanged
        If business.Checked Then
            CustOwner.ReadOnly = False
            CustOwnerMob.ReadOnly = False
            CustContactNo.ReadOnly = False
            CustContact.ReadOnly = False
        End If
    End Sub


    Friend Sub clear()
        customerName.Text = ""
        customerAddress.Text = ""
        CustomerEmail.Text = ""
        CustContact.Text = ""
        CustomerMobile.Text = ""
        CustomerStatus.Text = ""
        CustOwner.Text = ""
        CustOwnerMob.Text = ""
        CustContactNo.Text = ""
        customerID.Text = ""
        business.Checked = False
        individual.Checked = False

        CustomerDatagrid()


    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        clear()

    End Sub

    Private Sub deletebtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)



    End Sub

    Private Sub individual_CheckedChanged(sender As Object, e As EventArgs) Handles individual.CheckedChanged
        If individual.Checked Then
            CustOwner.ReadOnly = True
            CustOwnerMob.ReadOnly = True
            CustContactNo.ReadOnly = True
            CustContact.ReadOnly = True
        End If
    End Sub

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomerDatagrid()

    End Sub

    Private Sub Savebtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Savebtn.ItemClick
        Customer()

    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        If customerID.Text <> Nothing Then

            MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo, "System")

            If MsgBoxResult.Yes = MsgBoxResult.Yes Then
                Dim cmd As New SqlCommand
                Dim rd As SqlDataReader

                cmd.Connection = connection

                cmd.CommandText = "delete from customers where CustomerId = '" & customerID.Text & "' "
                connection.Open()

                rd = cmd.ExecuteReader
                rd.Close()

                MessageBox.Show("Deleted Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
                connection.Close()

            End If

        Else
            MsgBox("Select a Record to Delete", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick

        customergrid.ExportToXlsx("export.xlsx")
        Process.Start("export.xlsx")
        MsgBox("Exported Successfully.", MsgBoxStyle.Information)
    End Sub
End Class
