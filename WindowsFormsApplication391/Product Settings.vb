
Imports System.Data.SqlClient

Public Class Product_Settings

    Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")

    Private Sub Savebtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Savebtn.ItemClick
        productSetting()
        reset()

    End Sub

    Private Sub Product_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()

    End Sub




    Friend Sub productSetting()
        Dim rd As SqlDataReader
        Dim cmd As New SqlCommand



        connection.Open()


        Try
            If prosettingId.Text = Nothing Then




                cmd.CommandText = "Insert into ProductSettings values ( '" & proSetCategory.Text & "','" & proSetBrand.Text & "' ) "
                cmd.Connection = connection

                rd = cmd.ExecuteReader
                MessageBox.Show("Saved Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                rd.Close()





            Else


                cmd.CommandText = "Update ProductSettings set category = '" & proSetCategory.Text & "', brand = '" & proSetBrand.Text & "' 
                where  settingID = '" & prosettingId.Text & "'  "

                cmd.Connection = connection

                rd = cmd.ExecuteReader
                MessageBox.Show("Updated Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                rd.Close()



            End If

        Catch ex As Exception


            MsgBox(ex.Message)
        Finally

            connection.Close()
        End Try
    End Sub

    Sub gridClick()
        prosettingId.Text = GridView1.GetFocusedRowCellValue("settingId").ToString
        proSetCategory.Text = GridView1.GetFocusedRowCellValue("Category").ToString
        proSetBrand.Text = GridView1.GetFocusedRowCellValue("Brand").ToString

    End Sub

    Friend Sub productSettingDatagrid()


        ' Make the grid read-only. 
        GridView1.OptionsBehavior.Editable = False
        ' Prevent the focused cell from being highlighted. 
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        ' Draw a dotted focus rectangle around the entire row. 
        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus


        Dim tb As New DataTable
        Dim cmd As New SqlCommand
        cmd.Connection = connection

        Dim adpt As New SqlDataAdapter("select * from ProductSettings", connection)

        adpt.Fill(tb)

        customergrid.DataSource = tb
        adpt.Dispose()

        'GridView1.Columns("SettingId").Visible = False


    End Sub

    Sub reset()
        productSettingDatagrid()

        prosettingId.ResetText()
        proSetCategory.ResetText()
        proSetBrand.ResetText()

    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        reset()

    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        MessageBox.Show("Are you sure you wan to delete?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If DialogResult = DialogResult.Yes Then
            Dim cmd As New SqlCommand
            Dim rd As SqlDataReader

            cmd.Connection = connection

            cmd.CommandText = "delete from Product Settings where SettingID = '" & prosettingId.Text & "' "
            connection.Open()

            rd = cmd.ExecuteReader
            rd.Close()

            MessageBox.Show("Deleted Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            reset()
            connection.Close()

        End If
    End Sub
End Class