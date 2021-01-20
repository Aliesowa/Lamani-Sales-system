Imports System.Data.SqlClient

Public Class Stock



    Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")

    Sub category()
        Dim tb As New DataTable
        Dim adpt As New SqlDataAdapter("select distinct Category from ProductSettings", connection)
        connection.Open()

        adpt.Fill(tb)
        StockCategory.Properties.DataSource = tb
        StockCategory.Properties.DisplayMember = "Category"
        StockCategory.Properties.ValueMember = "Category"

        connection.Close()
    End Sub


    Sub brand()

        Dim tb As New DataTable
        Dim cmd As String = "select Brand from ProductSettings where category = '" & StockCategory.SelectedText & "' "
        Dim adpt As New SqlDataAdapter(cmd, connection)
        connection.Open()

        adpt.Fill(tb)

        StockBrand.Properties.DisplayMember = "Brand".ToString
        StockBrand.Properties.ValueMember = "Brand"
        StockBrand.Properties.DataSource = tb

        connection.Close()

        'Dim rd As SqlDataReader
        'Dim cmd As New SqlCommand("select Brand from ProductSettings where category = '" & StockCategory.Text & "' ")
        'cmd.Connection = connection


        'connection.Open()

        'rd = cmd.ExecuteReader

        'If rd.HasRows Then
        '    While rd.Read
        '        StockBrand.Properties.DataSource = rd("Brand").ToString
        '        StockBrand.Properties.DisplayMember = rd("Brand").ToString
        '        StockBrand.Properties.ValueMember = rd("Brand").ToString
        '    End While
        'End If
        'connection.Close()
    End Sub

    Sub reset()
        StockAlcohol.ResetText()
        StockBrand.ResetText()
        StockCategory.ResetText()
        ProId.ResetText()
        StockItem.ResetText()
        StockManu.ResetText()
        StockExpiry.ResetText()
        Qtypercase.ResetText()
        cases.ResetText()
        bottles.ResetText()
        stockVolume.ResetText()
        StockPrice.ResetText()
        category()

        Stockgrid()
        stockCurrency.ResetText()

    End Sub


    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        category()
        brand()
        Stockgrid()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        reset()

    End Sub

    Sub AddProduct()
        Dim rd As SqlDataReader
        Dim cmd As New SqlCommand



        connection.Open()


        Try
            If ProId.Text = Nothing Then




                cmd.CommandText = "Insert into Products values ( '" & StockCategory.Text & "','" & StockItem.Text & "', '" & StockBrand.Text & "', 
                                    '" & Qtypercase.Value & "', '" & cases.Value & "', '" & bottles.Value & "','" & QtyDamage.Value & "',
                            '" & stockVolume.Text & "', '" & stockCurrency.Text & "','" & StockPrice.Value & "', '" & StockAlcohol.Text & "', '" & StockManu.Text & "',
                            ' " & StockExpiry.Text & "', '" & Date.Now.ToString & " ') "
                cmd.Connection = connection

                rd = cmd.ExecuteReader
                MessageBox.Show("Saved Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                rd.Close()

                connection.Close()

            Else
                'cmd.CommandText = "update sales  set Datesold = ' " & SalesDate.Text & "',  Customer = ' " & salesCustomer.Text & "',
                '                         Item = '" & salesItems.Text & "', Quantity = ' " & salesQuantity.Value & "', price= ' " & SalesPrice.Value & "',
                '                                discount = '" & Salesdiscount.Value & "' , Total= '" & (SalesPrice.Value * salesQuantity.Value) - Salesdiscount.Value & "'
                '                           where  SalesId = '" & SalesId.Text & "'  "

                'cmd.Connection = connection

                'rd = cmd.ExecuteReader
                'MessageBox.Show("Updated Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'rd.Close()


            End If

        Catch ex As Exception


            MsgBox(ex.Message)
        Finally

            connection.Close()
            reset()

        End Try
    End Sub

    Private Sub Savebtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Savebtn.ItemClick
        AddProduct()

    End Sub

    Sub Stockgrid()
        ' Make the grid read-only. 
        GridView1.OptionsBehavior.Editable = False
        ' Prevent the focused cell from being highlighted. 
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        ' Draw a dotted focus rectangle around the entire row. 
        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus


        Dim tb As New DataTable
        Dim cmd As New SqlCommand
        cmd.Connection = connection


        Dim adpt As New SqlDataAdapter(" select *  from products", connection)

        adpt.Fill(tb)

        productgrid.DataSource = tb
        adpt.Dispose()

        GridView1.Columns("ProductId").Visible = False
    End Sub

    Sub gridClick()
        ProId.Text = GridView1.GetFocusedRowCellValue("ProductId").ToString
        StockItem.Text = GridView1.GetFocusedRowCellValue("ProductName").ToString
        StockCategory.Text = GridView1.GetFocusedRowCellValue("ProductCategory").ToString
        StockBrand.Text = GridView1.GetFocusedRowCellValue("ProductBrand").ToString
        stockVolume.Text = GridView1.GetFocusedRowCellValue("Volume").ToString
        Qtypercase.Text = GridView1.GetFocusedRowCellValue("QuantityPerCase").ToString
        QtyDamage.Text = GridView1.GetFocusedRowCellValue("DamageQuantity").ToString
        cases.Text = GridView1.GetFocusedRowCellValue("QuantityCases").ToString
        bottles.Text = GridView1.GetFocusedRowCellValue("QuantityBottles").ToString
        StockPrice.Text = GridView1.GetFocusedRowCellValue("Price").ToString
        StockAlcohol.Text = GridView1.GetFocusedRowCellValue("AlcoholPercentage").ToString
        StockManu.Text = GridView1.GetFocusedRowCellValue("ManufacturingDate").ToString
        StockExpiry.Text = GridView1.GetFocusedRowCellValue("ExpiryDate").ToString
    End Sub

    Private Sub productgrid_Click(sender As Object, e As EventArgs) Handles productgrid.Click
        gridClick()

    End Sub


    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deletebtn.ItemClick
        MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo, "System")

        If MsgBoxResult.Yes = MsgBoxResult.Yes Then

            Dim cmd As New SqlCommand
            Dim rd As SqlDataReader

            cmd.Connection = connection

            cmd.CommandText = "Delete from Products where ProductId = '" & ProId.Text & "' "
            connection.Open()

            rd = cmd.ExecuteReader

            rd.Close()

            MessageBox.Show("Deleted Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            reset()

        End If
    End Sub





    Private Sub RibbonControl2_Click(sender As Object, e As EventArgs) Handles RibbonControl2.Click
        Dim stk As New StockControl

        stk.StockGrid.Refresh()

    End Sub


    Private Sub StockCategory_EditValueChanged(sender As Object, e As EventArgs) Handles StockCategory.EditValueChanged
        brand()
    End Sub
End Class