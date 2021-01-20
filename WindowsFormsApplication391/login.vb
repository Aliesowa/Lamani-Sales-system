Imports System.Data.SqlClient

Public Class login

    Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")

    Public user As String
    Public pass As String

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frm As New configuration
        frm.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = DateTime.Now().ToString


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try



            user = username.Text()
            pass = userpass.Text()



            If (username.Text() = Nothing) Then
                MessageBox.Show("Please enter Username", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            ElseIf (userpass.Text() = Nothing) Then
                MessageBox.Show("Please enter " + user + "'s" + " password", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)


            Else


                Dim cmd As New SqlCommand
                cmd.Connection = connection

                cmd.CommandText = "select * from Users where Username = '" & user & "' and UserPassword = '" & pass & "' "

                Dim rd As SqlDataReader

                connection.Open()


                rd = cmd.ExecuteReader

                If rd.HasRows Then
                    Me.Hide()
                    Dim frm As New WindowsFormsApplication391.Form1
                    frm.Show()

                    rd.Close()
                Else

                    MsgBox("Wrong Username or Password")
                    username.ResetText()
                    userpass.ResetText()

                    rd.Close()

                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally

            connection.Close()
        End Try


    End Sub
End Class