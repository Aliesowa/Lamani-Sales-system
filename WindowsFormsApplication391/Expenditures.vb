Imports System.Data.SqlClient
Public Class Expenditures

    Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")

    Private Sub Expenditures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()

    End Sub

    Sub loadexpengrid()
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

        expenGrid.DataSource = tb

        GridView1.Columns("ExpenditureID").Visible = False

    End Sub

    Sub reset()
        SalesDate.Text = DateTime.Now.ToShortDateString
        expenCurrency.Text = ""
        expenPurpose.Text = ""
        stafflookup.Text = ""
        expenId.ResetText()
        expenAmount.ResetText()
        loadexpengrid()
        populateStaff()
        TotalExpen()
    End Sub

    Sub populateStaff()
        Dim tb As New DataTable
        Dim adpt As New SqlDataAdapter("select FirstName+ ' ' +OtherName + ' ' +LastName as 'StaffName', Contact From Staff", connection)
        connection.Open()

        adpt.Fill(tb)
        stafflookup.Properties.DataSource = tb
        stafflookup.Properties.DisplayMember = "StaffName"
        stafflookup.Properties.ValueMember = "StaffName"

        connection.Close()
    End Sub

    Private Sub Savebtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Savebtn.ItemClick

        saveExpen()


    End Sub


    Sub saveExpen()
        Dim rd As SqlDataReader
        Dim cmd As New SqlCommand

        Dim frm As New login

        connection.Open()


        Try
            If expenId.Text = Nothing Then


                If expenPurpose.Text <> Nothing And stafflookup.Text <> Nothing Then

                    cmd.CommandText = "Insert into Expenditures values (  '" & frm.user & "' + '" & DateTime.Now.ToString & "','" & SalesDate.Text & "',
                            '" & expenPurpose.Text & "', '" & expenCurrency.Text & "',' " & expenAmount.Value & "', '" & stafflookup.Text & "' ) "
                    cmd.Connection = connection

                    rd = cmd.ExecuteReader
                    MessageBox.Show("Saved Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    rd.Close()



                Else

                    MessageBox.Show("Must fill all", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)




                End If

            Else
                cmd.CommandText = "update Expenditures  set ExpenditureDate = ' " & SalesDate.Text & "',  Purpose = ' " & expenPurpose.Text & "',Currency =' " & expenCurrency.Text & "',
                                        staffName = '" & stafflookup.Text & "', Amount = ' " & expenAmount.Value & "'
                                           where  ExpenditureID = '" & expenId.Text & "'  "

                cmd.Connection = connection

                rd = cmd.ExecuteReader
                MessageBox.Show("Updated Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                rd.Close()


            End If

        Catch ex As Exception


            MsgBox(ex.Message)
        Finally
            connection.Close()
            reset()

        End Try
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        expenGrid.ExportToXlsx("export.xlsx")
        Process.Start("export.xlsx")
        MsgBox("Exported Successfully.", MsgBoxStyle.Information)


    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        If expenId.Text <> Nothing Then

            MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo)

            If MsgBoxResult.Yes = 6 Then
                Dim cmd As New SqlCommand
                Dim rd As SqlDataReader

                cmd.Connection = connection

                cmd.CommandText = "delete from Expenditures where ExpenditureID = '" & expenId.Text & "' "
                connection.Open()

                rd = cmd.ExecuteReader
                rd.Close()

                MsgBox("Deleted Successfully", MsgBoxStyle.OkOnly)



            End If

        Else
            MsgBox("Select a Record to Delete", MsgBoxStyle.OkOnly)
        End If
        connection.Close()
        reset()

    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        Dim View As New DevExpress.XtraGrid.Views.Grid.GridView
        View = expenGrid.MainView
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

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        reset()
    End Sub

    Private Sub expenGrid_Click(sender As Object, e As EventArgs) Handles expenGrid.Click
        expenId.Text = GridView1.GetFocusedRowCellValue("ExpenditureID").ToString
        SalesDate.Text = GridView1.GetFocusedRowCellValue("ExpenditureDate").ToString
        expenPurpose.Text = GridView1.GetFocusedRowCellValue("Purpose").ToString
        expenCurrency.Text = GridView1.GetFocusedRowCellValue("Currency").ToString
        expenAmount.Text = GridView1.GetFocusedRowCellValue("Amount").ToString
        stafflookup.Text = GridView1.GetFocusedRowCellValue("StaffName").ToString

    End Sub

    Sub TotalExpen()

        If SalesDate.Text <> Nothing Then


            Dim cmd As New SqlCommand
            Dim adapter As SqlDataAdapter
            Dim ds As New DataSet

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "TotalExpenditures"
            cmd.Connection = connection


            connection.Open()


            cmd.Parameters.AddWithValue("@DateExpend", SalesDate.Text)

            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(ds)



            TotalSalesTxt.Text = ds.Tables(0).Rows(0).Item(0).ToString

            If cmd IsNot Nothing Then cmd.Dispose()




        End If

        connection.Close()

    End Sub
End Class