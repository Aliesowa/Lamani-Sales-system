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

Namespace WindowsFormsApplication391
    Public Class Form1

        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")

        Friend Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            usercheck()
            pgcontorl()
        End Sub


        Public Sub New()




            InitializeComponent()





        End Sub

        Friend Sub pgcontorl()
            NavigationPage1.Controls.Add(New salesControl())
            NavigationPage2.Controls.Add(New expenControl())
            NavigationPage3.Controls.Add(New CreditorsControl)
            NavigationPage4.Controls.Add(New StockControl())
            NavigationPage5.Controls.Add(New CustomersContro())
            NavigationPage7.Controls.Add(New CreditorsPaymentControl())
            NavigationPage8.Controls.Add(New Manage())
            NavigationPage9.Controls.Add(New User_Account())
        End Sub


        Friend Sub accordionControl1_ElementClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Navigation.ElementClickEventArgs) Handles accordionControl1.ElementClick


            If e.Element.Text = "Daily Sales" Then
                NavigationPage1.Controls.Add(New salesControl())

                Dim frm As New WindowsFormsApplication391.Form1
                frm.Refresh()
                NavigationFrame1.SelectedPage = NavigationPage1

            End If

            If e.Element.Text = "Management Summary" Then
                NavigationFrame1.SelectedPage = NavigationPage8

            End If

            If e.Element.Text = "Expenditures" Then
                NavigationFrame1.SelectedPage = NavigationPage2
            End If
            If e.Element.Text = "Creditors" Then
                NavigationFrame1.SelectedPage = NavigationPage3
            End If

            If e.Element.Text = "Customers" Then
                NavigationFrame1.SelectedPage = NavigationPage5


            End If
            If e.Element.Text = "Stock / Inventory" Then
                NavigationFrame1.SelectedPage = NavigationPage4
            End If

            If e.Element.Text = "Product Settings" Then
                Dim frm As New Product_Settings
                frm.ShowDialog()
            End If

            If e.Element.Text = "Post" Then
                Dim frm As New Post
                frm.ShowDialog()
            End If

            If e.Element.Text = "Staff" Then
                Dim frm As New Staff
                frm.ShowDialog()
            End If

            If e.Element.Text = "Creditor's Payment" Then
                NavigationFrame1.SelectedPage = NavigationPage7
            End If

            If e.Element.Text = "Configuration Settings" Then
                Dim frm As New configuration
                frm.ShowDialog()
            End If

            If e.Element.Text = "User Account" Then
                NavigationFrame1.SelectedPage = NavigationPage9
            End If


        End Sub
        Public Sub usercheck()
            Dim cmd As New SqlCommand
            Dim rd As SqlDataReader

            cmd.CommandText = "select UserCategory as 'user' from Users where Username = '" & login.user & "' "

            cmd.Connection = connection
            connection.Open()

            rd = cmd.ExecuteReader

            Dim use As String
            If rd.HasRows Then
                While rd.Read
                    use = rd("user")

                End While
                If use <> "Super User" Then

                    AccordionControlElement18.Enabled = False
                    AccordionControlElement22.Enabled = False
                    AccordionControlElement11.Enabled = False
                    AccordionControlElement10.Enabled = False
                    AccordionControlElement12.Enabled = False
                End If

                rd.Close()
            End If


            connection.Close()

            Me.Refresh()

        End Sub




        Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles newbtn.ItemClick

            If accordionControl1.SelectedElement.Text = AccordionControlElement2.Text Then
                Dim frm As New Stock
                frm.ShowDialog()
            End If

            If accordionControl1.SelectedElement.Text = AccordionControlElement7.Text Then
                Dim frm As New Customers
                frm.ShowDialog()

            End If

            If accordionControl1.SelectedElement.Text = accordionControlElement3.Text Then
                Dim frm As New Sales
                frm.ShowDialog()

            End If

            If accordionControl1.SelectedElement.Text = AccordionControlElement14.Text Then
                Dim frm As New Product_Settings
                frm.ShowDialog()

            End If

            If accordionControl1.SelectedElement.Text = AccordionControlElement15.Text Then
                Dim frm As New CreditorsPayment
                frm.ShowDialog()

            End If

            If accordionControl1.SelectedElement.Text = accordionControlElement5.Text Then
                Dim frm As New Creditors
                frm.ShowDialog()

            End If

            If accordionControl1.SelectedElement.Text = accordionControlElement4.Text Then
                Dim frm As New Expenditures
                frm.ShowDialog()


            End If


        End Sub

        Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick


            If accordionControl1.SelectedElement.Text = AccordionControlElement2.Text Then
                Dim frm As New Stock
                frm.ShowDialog()
            End If

            If accordionControl1.SelectedElement.Text = AccordionControlElement7.Text Then
                Dim frm As New Customers
                frm.ShowDialog()

            End If

            If accordionControl1.SelectedElement.Text = accordionControlElement3.Text Then
                Dim frm As New Sales
                frm.ShowDialog()

            End If

            If accordionControl1.SelectedElement.Text = AccordionControlElement15.Text Then
                Dim frm As New CreditorsPayment
                frm.ShowDialog()

            End If

            If accordionControl1.SelectedElement.Text = accordionControlElement5.Text Then
                Dim frm As New Creditors
                frm.ShowDialog()

            End If


            If accordionControl1.SelectedElement.Text = accordionControlElement4.Text Then
                Dim frm As New Expenditures
                frm.ShowDialog()

            End If



        End Sub


        Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
            XtraSaveFileDialog1.ShowDialog()

        End Sub

        Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
            Dim frm As New login

            MsgBox("Are you sure you want to Logout?", MsgBoxStyle.YesNo)

            If MsgBoxResult.Yes = 6 Then
                Me.Close()
                frm.Show()
            End If
        End Sub


        Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
            usercheck()
            pgcontorl()

            Me.Refresh()
            NavigationPage1.Refresh()

        End Sub
    End Class
End Namespace
