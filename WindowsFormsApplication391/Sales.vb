Imports System.Data.SqlClient

Imports Excel = Microsoft.Office.Interop.Excel




Public Class Sales

    Dim fom As New Form2

    Public conn As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")

    Private Sub Savebtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Savebtn.ItemClick
        saveSales()

    End Sub

    Sub saveSales()
        Dim rd As SqlDataReader
        Dim cmd As New SqlCommand



        conn.Open()


        Try
            If SalesId.Text = Nothing Then


                If salesCustomer.Text <> Nothing And salesItems.Text <> Nothing Then

                    cmd.CommandText = "Insert into sales values ( '" & DateTime.Now.ToString & "','" & SalesDate.Text & "', '" & salesCustomer.Text & "',
                            '" & salesItems.Text & "', '" & cases.Value & "','" & bottles.Value & "', '" & salesQuantity.Value & "',' " & salesCurrency.Text & "', '" & SalesPrice.Value & "', '" & Salesdiscount.Value & "',
                            ' " & (SalesPrice.Value * salesQuantity.Value) - Salesdiscount.Value & "', '" & stafflookup.Text & " ') "
                    cmd.Connection = conn

                    rd = cmd.ExecuteReader
                    MessageBox.Show("Saved Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    rd.Close()



                Else

                    MessageBox.Show("Must fill all", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)




                End If

            Else
                cmd.CommandText = "update sales  set Datesold = ' " & SalesDate.Text & "',  Customer = ' " & salesCustomer.Text & "',Currency =' " & salesCurrency.Text & "',
                                         Item = '" & salesItems.Text & "', QuantityCases = ' " & cases.Value & "', QuantityBottles = ' " & bottles.Value & "',
                                                            TotalQuantity = ' " & salesQuantity.Value & "',price= ' " & SalesPrice.Value & "',
                                                discount = '" & Salesdiscount.Value & "' , TotalAmount= '" & (SalesPrice.Value * salesQuantity.Value) - Salesdiscount.Value & "'
                                           where  SalesId = '" & SalesId.Text & "'  "

                cmd.Connection = conn

                rd = cmd.ExecuteReader
                MessageBox.Show("Updated Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                rd.Close()


            End If

        Catch ex As Exception


            MsgBox(ex.Message)
        Finally
            conn.Close()
            reset()

        End Try
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

    Sub populateitembox()
        Dim tb As New DataTable
        Dim adpt As New SqlDataAdapter("select ProductName, ProductCategory, volume , AlcoholPercentage From Products", conn)

        If ConnectionState.Closed Then

            conn.Open()
        End If


        adpt.Fill(tb)
        salesItems.Properties.DataSource = tb
        salesItems.Properties.DisplayMember = "ProductName"
        salesItems.Properties.ValueMember = "ProductName"

        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        cmd.CommandText = "select price from products where productName = '" & salesItems.Text & "' "
        cmd.Connection = conn
        conn.Open()

        rd = cmd.ExecuteReader
        If rd.HasRows Then

            While rd.Read
                SalesPrice.Text = rd("Price").ToString
            End While

        End If
        rd.Close()

        conn.Close()

    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()


    End Sub

    Dim Currency As String

    Private Sub quantityedit_EditValueChanged(sender As Object, e As EventArgs) Handles salesQuantity.EditValueChanged
        Dim sum As Double

        Currency = salesCurrency.Text

        sum = (SalesPrice.Value * salesQuantity.Value) - Salesdiscount.Value
        SalesTotal.Text = Currency + " " + sum.ToString + ".00"

    End Sub


    Private Sub Salesdiscount_EditValueChanged_1(sender As Object, e As EventArgs) Handles Salesdiscount.EditValueChanged
        Dim sum As Double

        Currency = salesCurrency.Text

        sum = (SalesPrice.Value * salesQuantity.Value) - Salesdiscount.Value
        SalesTotal.Text = Currency + " " + sum.ToString + ".00"

    End Sub

    Private Sub salesItems_EditValueChanged(sender As Object, e As EventArgs) Handles salesItems.EditValueChanged
        cases.ResetText()
        bottles.ResetText()

    End Sub


    Private Sub salesCurrency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles salesCurrency.SelectedIndexChanged
        Dim sum As Double

        Currency = salesCurrency.Text

        sum = (SalesPrice.Value * salesQuantity.Value) - Salesdiscount.Value
        SalesTotal.Text = Currency + " " + sum.ToString + ".00"
    End Sub

    Sub reset()
        SalesDate.Text = DateTime.Now.ToShortDateString
        salesCurrency.Text = ""
        salesCustomer.Text = ""
        salesItems.Text = ""
        SalesId.ResetText()
        salesQuantity.ResetText()
        cases.ResetText()
        bottles.ResetText()
        SalesPrice.ResetText()
        SalesTotal.ResetText()
        Salesdiscount.ResetText()
        populateCustomerbox()
        populateitembox()
        populateStaff()
        salegrid()
        TotalSales()
        stafflookup.Text = ""
        SalesPrice.ReadOnly = True

    End Sub

    Sub populateStaff()
        Dim tb As New DataTable
        Dim adpt As New SqlDataAdapter("select FirstName+ ' ' + OtherName + ' ' + LastName as 'StaffName', Contact From Staff", conn)
        conn.Open()

        adpt.Fill(tb)
        stafflookup.Properties.DataSource = tb
        stafflookup.Properties.DisplayMember = "StaffName"
        stafflookup.Properties.ValueMember = "StaffName"

        conn.Close()
    End Sub

    Sub salegrid()
        ' Make the grid read-only. 
        GridView1.OptionsBehavior.Editable = False
        ' Prevent the focused cell from being highlighted. 
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        ' Draw a dotted focus rectangle around the entire row. 
        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus


        Dim tb As New DataTable
        Dim cmd As New SqlCommand
        cmd.Connection = conn

        Dim adpt As New SqlDataAdapter(" select *  from sales", conn)

        adpt.Fill(tb)

        SalesGrid.DataSource = tb
        adpt.Dispose()

        GridView1.Columns("SalesId").Visible = False

    End Sub

    Private Sub SalesGrid_Click(sender As Object, e As EventArgs) Handles SalesGrid.Click
        SalesId.Text = GridView1.GetFocusedRowCellValue("SalesId").ToString
        SalesDate.Text = GridView1.GetFocusedRowCellValue("DateSold").ToString
        salesCustomer.Text = GridView1.GetFocusedRowCellValue("Customer").ToString
        salesItems.Text = GridView1.GetFocusedRowCellValue("Item").ToString
        SalesPrice.Text = GridView1.GetFocusedRowCellValue("Price").ToString
        cases.Text = GridView1.GetFocusedRowCellValue("QuantityCases").ToString
        bottles.Text = GridView1.GetFocusedRowCellValue("QuantityBottles").ToString
        Salesdiscount.Text = GridView1.GetFocusedRowCellValue("Discount").ToString
        SalesTotal.Text = GridView1.GetFocusedRowCellValue("TotalAmount").ToString
        stafflookup.Text = GridView1.GetFocusedRowCellValue("Staff").ToString
        salesCurrency.Text = GridView1.GetFocusedRowCellValue("Currency").ToString

        SalesPrice.ReadOnly = False

    End Sub

    Private Sub SalesDate_EditValueChanged(sender As Object, e As EventArgs) Handles SalesDate.EditValueChanged
        TotalSales()

    End Sub

    Sub TotalSales()

        If SalesDate.Text <> Nothing Then


            Dim cmd As New SqlCommand
            Dim adapter As SqlDataAdapter
            Dim ds As New DataSet

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "TotalSales"
            cmd.Connection = conn


            conn.Open()


            cmd.Parameters.AddWithValue("@DateSold", SalesDate.Text)

            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(ds)



            totalSalestxt.Text = ds.Tables(0).Rows(0).Item(0).ToString

            If cmd IsNot Nothing Then cmd.Dispose()




        End If

        conn.Close()

    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        reset()

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        SalesGrid.ExportToXlsx("export.xlsx")
        Process.Start("export.xlsx")
        MsgBox("Exported Successfully.", MsgBoxStyle.Information)
    End Sub




    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        If SalesId.Text <> Nothing Then

            MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo)

            If MsgBoxResult.Yes = 6 Then
                Dim cmd As New SqlCommand
                Dim rd As SqlDataReader

                cmd.Connection = conn

                cmd.CommandText = "delete from Sales where SalesId = '" & SalesId.Text & "' "
                conn.Open()

                rd = cmd.ExecuteReader
                rd.Close()

                MsgBox("Deleted Successfully", MsgBoxStyle.OkOnly)



            End If

        Else
            MsgBox("Select a Record to Delete", MsgBoxStyle.OkOnly)
        End If
        conn.Close()
        reset()

    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick


        Dim View As New DevExpress.XtraGrid.Views.Grid.GridView
        View = SalesGrid.MainView
        View.ExportToXls(SaveAs() & ".xls")
        Dim xlsprocess As New Process
        xlsprocess.StartInfo.FileName = "Excel.exe"

    End Sub
    Public Function SaveAs()
        Dim SaveFileDialog1 As New System.Windows.Forms.SaveFileDialog
        SaveFileDialog1.Filter = "All Files (*.*) |*.*|ExcelFile (*.xls)|*.xls"
        '  SaveFileDialog1.Filter( = 1
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Return SaveFileDialog1.FileName
        Else
            Return ""
        End If
    End Function


    Private Sub salesCustomer_Enter(sender As Object, e As EventArgs) Handles salesCustomer.Enter
        populateCustomerbox()
    End Sub

    Private Sub SalesItems_Enter(sender As Object, e As EventArgs) Handles SalesItems.Enter
        populateitembox()
    End Sub

    Private Sub bottles_EditValueChanged(sender As Object, e As EventArgs) Handles bottles.EditValueChanged
        Dim rd As SqlDataReader
        Dim cmd As New SqlCommand
        Dim res As Integer

        cmd.Connection = conn

        cmd.CommandText = "select QuantityPerCase as 'case' from Products where ProductName = '" & SalesItems.Text & "' "
        conn.Open()
        rd = cmd.ExecuteReader

        While rd.Read
            res = CInt(rd("case"))
        End While



        Dim sum As Double




        sum = cases.Value * res + bottles.Value

        salesQuantity.Value = CDec(sum)

        conn.Close()
    End Sub

    Private Sub cases_EditValueChanged(sender As Object, e As EventArgs) Handles cases.EditValueChanged

        Dim rd As SqlDataReader
        Dim cmd As New SqlCommand
        Dim res As Integer

        cmd.Connection = conn

        cmd.CommandText = "select QuantityPerCase as 'case' from Products where ProductName = '" & SalesItems.Text & "' "
        conn.Open()
        rd = cmd.ExecuteReader

        While rd.Read
            res = CInt(rd("case"))
        End While



        Dim sum As Double




        sum = cases.Value * res + bottles.Value

        salesQuantity.Value = CDec(sum)

        conn.Close()
    End Sub

    Private Sub SalesPrice_EditValueChanged(sender As Object, e As EventArgs) Handles SalesPrice.EditValueChanged
        Dim sum As Double

        Currency = salesCurrency.Text

        sum = (SalesPrice.Value * salesQuantity.Value) - Salesdiscount.Value
        SalesTotal.Text = Currency + " " + sum.ToString("#,##0.00")
    End Sub

    Private Sub stafflookup_EditValueChanged(sender As Object, e As EventArgs) Handles stafflookup.EditValueChanged

    End Sub
End Class
