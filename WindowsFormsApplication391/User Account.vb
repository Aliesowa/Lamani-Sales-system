Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Navigation

Public Class User_Account

    Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")


    Private Sub User_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        populateStaff()
    End Sub

    Sub populateStaff()
        Dim tb As New DataTable
        Dim adpt As New SqlDataAdapter("select StaffID , FirstName+ ' ' +OtherName + ' ' +LastName as 'StaffName', Contact From Staff", connection)
        connection.Open()

        adpt.Fill(tb)
        stafflookup.Properties.DataSource = tb
        stafflookup.Properties.DisplayMember = "StaffID"
        stafflookup.Properties.ValueMember = "StaffID"

        connection.Close()



    End Sub

    Sub reset()
        username.Text = Nothing
        pass.Text = Nothing
        userGroup.Text = ""
        stafflookup.Text = ""
        populateStaff()


    End Sub

    Private Sub stafflookup_TextChanged(sender As Object, e As EventArgs) Handles stafflookup.TextChanged

        Dim rd As SqlDataReader
        Dim cmd As New SqlCommand("select Username,UserPassword,UserCategory from Users inner join Staff on Staff.StaffID = Users.StaffID")
        cmd.Connection = connection
        connection.Open()

        rd = cmd.ExecuteReader()

        If rd.HasRows Then
            While rd.Read
                username.Text = rd("Username").ToString
                pass.Text = rd("UserPassword").ToString
                userGroup.Text = rd("UserCategory").ToString
            End While
        End If
        rd.Close()

        connection.Close()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        reset()



    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick

        If stafflookup.Text <> Nothing Then

            MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo)

            If MsgBoxResult.Yes = 6 Then
                Dim cmd As New SqlCommand
                Dim rd As SqlDataReader

                cmd.Connection = connection

                cmd.CommandText = "delete from Users where StaffID = '" & stafflookup.Text & "' "
                connection.Open()

                rd = cmd.ExecuteReader
                rd.Close()

                MsgBox("Deleted Successfully", MsgBoxStyle.OkOnly)



            End If

        Else
            MsgBox("Select a Staff ID to Delete", MsgBoxStyle.OkOnly)
        End If
        connection.Close()
        reset()
    End Sub


    Private Sub Savebtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Savebtn.ItemClick
        Dim rd As SqlDataReader
        Dim cmd As New SqlCommand



        connection.Open()


        Try
            If stafflookup.Text = Nothing Then



                cmd.CommandText = "Insert into Users values ( '" & stafflookup.Text & "','" & username.Text & "', '" & pass.Text & "', '" & userGroup.Text & " ') "
                cmd.Connection = connection

                rd = cmd.ExecuteReader
                    MessageBox.Show("Saved Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    rd.Close()





                'MessageBox.Show("Must fill all", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)






            Else
                cmd.CommandText = "update Users  set StaffID = ' " & stafflookup.Text & "',  Username = ' " & username.Text & "',UserPassword=' " & pass.Text & "',
                                         UserCategory = '" & userGroup.Text & "'  "

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
End Class
