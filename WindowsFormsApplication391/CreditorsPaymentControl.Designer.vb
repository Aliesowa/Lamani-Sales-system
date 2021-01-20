<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditorsPaymentControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CreditPaymentGrid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.CreditPaymentGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CreditPaymentGrid
        '
        Me.CreditPaymentGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CreditPaymentGrid.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CreditPaymentGrid.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditPaymentGrid.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.CreditPaymentGrid.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.CreditPaymentGrid.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.CreditPaymentGrid.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.CreditPaymentGrid.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.CreditPaymentGrid.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.CreditPaymentGrid.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.CreditPaymentGrid.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.CreditPaymentGrid.Location = New System.Drawing.Point(0, 0)
        Me.CreditPaymentGrid.MainView = Me.GridView1
        Me.CreditPaymentGrid.Name = "CreditPaymentGrid"
        Me.CreditPaymentGrid.Size = New System.Drawing.Size(1124, 549)
        Me.CreditPaymentGrid.TabIndex = 47
        Me.CreditPaymentGrid.UseEmbeddedNavigator = True
        Me.CreditPaymentGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView1.GridControl = Me.CreditPaymentGrid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        '
        'CreditorsPaymentControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CreditPaymentGrid)
        Me.Name = "CreditorsPaymentControl"
        Me.Size = New System.Drawing.Size(1124, 549)
        CType(Me.CreditPaymentGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CreditPaymentGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
