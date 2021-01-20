Imports System.Data.SqlClient

Public Class Staff

    Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")


    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()

    End Sub

    Sub staffgrid()
        ' Make the grid read-only. 
        GridView1.OptionsBehavior.Editable = False
        ' Prevent the focused cell from being highlighted. 
        GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        ' Draw a dotted focus rectangle around the entire row. 
        GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus


        Dim tb As New DataTable
        Dim cmd As New SqlCommand
        cmd.Connection = connection

        Dim adpt As New SqlDataAdapter("select *  from Staff", connection)

        adpt.Fill(tb)

        SalesGrid.DataSource = tb
        adpt.Dispose()


    End Sub
    Sub reset()
        SatfDOB.Text = Nothing
        gender.Text = ""
        firstname.Text = Nothing
        othername.Text = Nothing
        lastname.Text = Nothing
        staffAddress.Text = Nothing
        StaffEmail.Text = Nothing
        Staffmobile.Text = Nothing
        StaffID.Text = Nothing
        id.Text = Nothing


        staffgrid()

    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        reset()

        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        cmd.Connection = connection

        cmd.CommandText = "select max(StaffID) + 1 as 'Max' from Staff "
        connection.Open()

        rd = cmd.ExecuteReader
        While rd.Read
            StaffID.Text = rd("Max").ToString
        End While

        rd.Close()
        connection.Close()
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        If StaffID.Text <> Nothing Then

            MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo)

            If MsgBoxResult.Yes = 6 Then
                Dim cmd As New SqlCommand
                Dim rd As SqlDataReader

                cmd.Connection = connection

                cmd.CommandText = "delete from Staff where StaffID= '" & StaffID.Text & "' "
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

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        SalesGrid.ExportToXlsx("export.xlsx")
        Process.Start("export.xlsx")
        MsgBox("Exported Successfully.", MsgBoxStyle.Information)
    End Sub

    Private Sub Savebtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Savebtn.ItemClick
        StaffSave()
    End Sub

    Sub StaffSave()
        Dim rd As SqlDataReader
        Dim cmd As New SqlCommand



        connection.Open()


        Try
            If id.Text = Nothing Then
                If firstname.Text <> Nothing And lastname.Text <> Nothing Then

                    cmd.CommandText = "Insert into staff values ( '" & firstname.Text & "','" & othername.Text & "', '" & lastname.Text & "',
                            '" & gender.Text & "', '" & Staffmobile.Text & "',' " & staffAddress.Text & "', '" & StaffEmail.Text & " ', '" & SatfDOB.Text & " ' ) "
                    cmd.Connection = connection

                    rd = cmd.ExecuteReader
                    MessageBox.Show("Saved Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    rd.Close()

                Else
                    MessageBox.Show("Must fill all", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If

            Else

                cmd.CommandText = "update staff  set FirstName = ' " & firstname.Text & "',  OtherName = ' " & othername.Text & "',
                                LastName =' " & lastname.Text & "', Gender = '" & gender.Text & "', 
                                Contact = ' " & Staffmobile.Text & "', StaffAddress = ' " & staffAddress.Text & "',
                                                Email = '" & StaffEmail.Text & "', DOB = '" & SatfDOB.Text & "'
                                           where  staffID = '" & StaffID.Text & "'  "

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

    Private Sub SalesGrid_Click(sender As Object, e As EventArgs) Handles SalesGrid.Click
        StaffID.Text = GridView1.GetFocusedRowCellValue("StaffID").ToString
        id.Text = GridView1.GetFocusedRowCellValue("StaffID").ToString
        firstname.Text = GridView1.GetFocusedRowCellValue("FirstName").ToString
        othername.Text = GridView1.GetFocusedRowCellValue("OtherName").ToString
        lastname.Text = GridView1.GetFocusedRowCellValue("LastName").ToString
        gender.Text = GridView1.GetFocusedRowCellValue("Gender").ToString
        Staffmobile.Text = GridView1.GetFocusedRowCellValue("Contact").ToString
        staffAddress.Text = GridView1.GetFocusedRowCellValue("StaffAddress").ToString
        StaffEmail.Text = GridView1.GetFocusedRowCellValue("Email").ToString

    End Sub
End Class