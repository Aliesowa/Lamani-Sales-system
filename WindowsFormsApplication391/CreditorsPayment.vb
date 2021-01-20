Imports System.Data.SqlClient

Public Class CreditorsPayment
    Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")

    Private Sub CreditorsPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class