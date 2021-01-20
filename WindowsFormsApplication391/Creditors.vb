Imports System.Data.SqlClient

Public Class Creditors

    Public conn As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")


    Private Sub Savebtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Savebtn.ItemClick
        savecredit()

    End Sub

    Sub savecredit()
        Dim rd As SqlDataReader
        Dim cmd As New SqlCommand



        conn.Open()


        Try
            If creditId.Text = Nothing Then


                If salesCustomer.Text <> Nothing And salesItems.Text <> Nothing Then

                    cmd.CommandText = "Insert into Creditors values ( '" & DateTime.Now.ToString + salesCustomer.Text & "','" & SalesDate.Text & "', '" & salesCustomer.Text & "',
                            '" & salesItems.Text & "', '" & salesQuantity.Value & "', '" & salesCurrency.Text & "', '" & SalesPrice.Value & "', '" & Salesdiscount.Value & "',
                            ' " & (SalesPrice.Value * salesQuantity.Value) - Salesdiscount.Value & "', '" & stafflookup.Text & " ','" & status.Text & " ') "
                    cmd.Connection = conn

                    rd = cmd.ExecuteReader
                    MessageBox.Show("Saved Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    rd.Close()



                Else

                    MessageBox.Show("Must fill all", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)




                End If

            Else
                cmd.CommandText = "update sales  set CreditDate = ' " & SalesDate.Text & "',  CustomerName = ' " & salesCustomer.Text & "',
                                         Item = '" & salesItems.Text & "', Quantity = ' " & salesQuantity.Value & "', price= ' " & SalesPrice.Value & "',
                                                discount = '" & Salesdiscount.Value & "' , Total= '" & (SalesPrice.Value * salesQuantity.Value) - Salesdiscount.Value & "'
                                             , Currency =  '" & salesCurrency.Text & "', CreditorStatus ='" & status.Text & " '  where  CreditorsID = '" & creditId.Text & "'  "

                cmd.Connection = conn

                rd = cmd.ExecuteReader
                MessageBox.Show("Updated Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                rd.Close()


            End If

        Catch ex As Exception


            MsgBox(ex.Message)
        Finally
            conn.Close()
            Reset()

        End Try
    End Sub
    Dim Currency As String

    Private Sub salesQuantity_EditValueChanged(sender As Object, e As EventArgs) Handles salesQuantity.EditValueChanged
        Dim sum As Double

        Currency = salesCurrency.Text

        sum = (SalesPrice.Value * salesQuantity.Value) - Salesdiscount.Value
        SalesTotal.Text = Currency + " " + sum.ToString + ".00"
    End Sub

    Private Sub Salesdiscount_EditValueChanged(sender As Object, e As EventArgs) Handles Salesdiscount.EditValueChanged
        Dim sum As Double

        Currency = salesCurrency.Text

        sum = (SalesPrice.Value * salesQuantity.Value) - Salesdiscount.Value
        SalesTotal.Text = Currency + " " + sum.ToString + ".00"
    End Sub

    Sub populateCustomerbox()
        Dim tb As New DataTable
        Dim adpt As New SqlDataAdapter("select CustomerName, Address From Customers", conn)
        conn.Open()

        adpt.Fill(tb)
        salesCustomer.Properties.DataSource = tb
        salesCustomer.Properties.DisplayMember = "CustomerName"
        salesCustomer.Properties.ValueMember = "CustomerName"

        conn.Close()

    End Sub

    Sub populateStaff()
        Dim tb As New DataTable
        Dim adpt As New SqlDataAdapter("select FirstName+ ' ' +OtherName + ' ' +LastName as 'StaffName', Contact From Staff", conn)
        conn.Open()

        adpt.Fill(tb)
        stafflookup.Properties.DataSource = tb
        stafflookup.Properties.DisplayMember = "StaffName"
        stafflookup.Properties.ValueMember = "StaffName"

        conn.Close()
    End Sub

    Sub creditorgrid()
        ' Make the grid read-only. 
        GridView1.OptionsBehavior.Editable = False
        ' Prevent the focused cell from being highlighted. 
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        ' Draw a dotted focus rectangle around the entire row. 
        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus


        Dim tb As New DataTable
        Dim cmd As New SqlCommand
        cmd.Connection = conn

        Dim adpt As New SqlDataAdapter(" select *  from Creditors", conn)

        adpt.Fill(tb)

        CreditGrid.DataSource = tb
        adpt.Dispose()

        GridView1.Columns("CreditorsID").Visible = False

    End Sub
    Private Sub CreditGrid_Click(sender As Object, e As EventArgs) Handles CreditGrid.Click
        creditId.Text = GridView1.GetFocusedRowCellValue("CreditorsID").ToString
        SalesDate.Text = GridView1.GetFocusedRowCellValue("CreditDate").ToString
        salesCustomer.Text = GridView1.GetFocusedRowCellValue("CustomerName").ToString
        salesItems.Text = GridView1.GetFocusedRowCellValue("Item").ToString
        SalesPrice.Text = GridView1.GetFocusedRowCellValue("Price").ToString
        salesQuantity.Text = GridView1.GetFocusedRowCellValue("Quantity").ToString
        Salesdiscount.Text = GridView1.GetFocusedRowCellValue("Discount").ToString
        TotalSalesTxt.Text = GridView1.GetFocusedRowCellValue("Total").ToString
        stafflookup.Text = GridView1.GetFocusedRowCellValue("StaffName").ToString
        salesCurrency.Text = GridView1.GetFocusedRowCellValue("Currency").ToString

    End Sub

    Sub reset()

        SalesDate.Text = DateTime.Now.ToShortDateString
        salesCurrency.Text = " "
        salesCustomer.Text = " "
        salesItems.Text = " "
        creditId.ResetText()
        salesQuantity.ResetText()
        SalesPrice.ResetText()
        SalesTotal.ResetText()
        Salesdiscount.ResetText()
        populateCustomerbox()
        populateitembox()
        populateStaff()
        creditorgrid()
        status.Text = " "

    End Sub

    Sub populateitembox()
        Dim tb As New DataTable
        Dim adpt As New SqlDataAdapter("select ProductName, ProductCategory, volume , AlcoholPercentage From Products", conn)
        conn.Open()

        adpt.Fill(tb)
        salesItems.Properties.DataSource = tb
        salesItems.Properties.DisplayMember = "ProductName"
        salesItems.Properties.ValueMember = "ProductName"

        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        cmd.CommandText = "select price from products where productName = '" & salesItems.Text & "' "
        cmd.Connection = conn

        rd = cmd.ExecuteReader
        If rd.HasRows Then

            While rd.Read
                SalesPrice.Text = rd("Price").ToString
            End While

        End If
        rd.Close()

        conn.Close()

    End Sub

    Private Sub Creditors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()

    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        reset()

    End Sub

    Private Sub salesItems_EditValueChanged(sender As Object, e As EventArgs) Handles salesItems.EditValueChanged
        populateitembox()
    End Sub
End Class