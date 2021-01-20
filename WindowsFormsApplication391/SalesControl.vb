Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient

Namespace WindowsFormsApplication391
    Partial Public Class salesControl
        Inherits UserControl
        Public connection As New SqlConnection("server = '" & My.Settings.Server & "'; User = '" & My.Settings.Username & "' ;Password = '" & My.Settings.password & "'; 
                                    Database = '" & My.Settings.Data & "' ")

        Public Sub New()
            InitializeComponent()
            loadsalesgrid()

        End Sub

        Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            loadsalesgrid()

        End Sub



        Sub loadsalesgrid()
            ' Make the grid read-only. 
            GridView1.OptionsBehavior.Editable = False
            ' Prevent the focused cell from being highlighted. 
            GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            ' Draw a dotted focus rectangle around the entire row. 
            GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus


            Dim tb As New DataTable
            Dim cmd As New SqlCommand
            cmd.Connection = connection

            Dim adpt As New SqlDataAdapter(" select * from Sales", connection)

            adpt.Fill(tb)

            customergrid.DataSource = tb

            GridView1.Columns("SalesId").Visible = False

        End Sub


    End Class
End Namespace
