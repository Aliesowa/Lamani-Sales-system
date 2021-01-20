Imports System.Data.SqlClient
Public Class Manage

    Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                  Database = '" & My.Settings.Data & "' ")







    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim cre As Double
        Dim sale As Double
        Dim exp As Double
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        cmd.CommandText = "select sum(TotalAmount)as 'sold' from sales where DateSold between '" & frmdate.Text & "' and '" & Todate.Text & "' "

        cmd.Connection = connection
        connection.Open()

        rd = cmd.ExecuteReader


        If rd.HasRows Then



            While rd.Read
                sale = rd("sold")
                Salestxt.Text = CDbl(rd("sold")).ToString("#,##0.00")
            End While

        End If
        rd.Close()

        Dim cmd2 As New SqlCommand


        cmd2.CommandText = "select COALESCE(sum(Amount), 0)as 'expen' from expenditures where ExpenditureDate between '" & frmdate.Text & "' and '" & Todate.Text & "' "

        cmd2.Connection = connection


        rd = cmd2.ExecuteReader


        If rd.HasRows Then


            While rd.Read
                exp = rd("expen")

                expentxt.Text = CDbl(rd("expen")).ToString("#,##0.00")
            End While

        End If
        rd.Close()



        Dim cmd3 As New SqlCommand


        cmd3.CommandText = "select COALESCE(sum(Total),0) as 'credit' from creditors  where creditDate between '" & frmdate.Text & "' and '" & Todate.Text & "' "

        cmd3.Connection = connection


        rd = cmd3.ExecuteReader


        If rd.HasRows Then



            While rd.Read
                cre = rd("credit")
                credit_txt.Text = CDbl(rd("credit")).ToString("#,##0.00")
            End While

        End If
        rd.Close()





        Dim tota As Double = sale + cre - exp

        profit_loss.Text = CDbl(tota.ToString("#,##0.00"))

        If tota > 1000 Then
            Label7.Text = "Profit"
            Label7.Visible = True
            Label7.ForeColor = Color.Green

        Else
            Label7.Text = "Loss"
            Label7.Visible = True
            Label7.ForeColor = Color.Red
        End If

        connection.Close()

    End Sub
End Class
