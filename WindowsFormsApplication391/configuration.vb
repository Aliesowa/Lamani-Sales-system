
Imports System.Data.SqlClient
Public Class configuration


    'Dim connection As New SqlConnection(" Persist Security Info=False; User ID='" & My.Settings.Dbuser & " '; Initial Catalog='" & My.Settings.Dbdatabase & "'; 
    'Data Source = '" & My.Settings.Dbserver & "';Initial File Name="";Server SPN=""")



    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        My.Settings.Server = ServerName.Text
        My.Settings.Data = database.Text
        My.Settings.Username = user.Text
        My.Settings.password = pass.Text




        My.Settings.Save()

        My.Settings.Reload()

        Try
            connection.Open()
            If ConnectionState.Open Then
                MsgBox("Connected")


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")
End Class