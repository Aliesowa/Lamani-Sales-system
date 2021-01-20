<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomersContro
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.customergrid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.customergrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'customergrid
        '
        Me.customergrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.customergrid.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.customergrid.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customergrid.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.customergrid.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.customergrid.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.customergrid.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.customergrid.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.customergrid.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.customergrid.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.customergrid.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.customergrid.Location = New System.Drawing.Point(0, 0)
        Me.customergrid.MainView = Me.GridView1
        Me.customergrid.Name = "customergrid"
        Me.customergrid.Size = New System.Drawing.Size(1059, 549)
        Me.customergrid.TabIndex = 45
        Me.customergrid.UseEmbeddedNavigator = True
        Me.customergrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView1.GridControl = Me.customergrid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        '
        'CustomersContro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.customergrid)
        Me.Name = "CustomersContro"
        Me.Size = New System.Drawing.Size(1059, 549)
        CType(Me.customergrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents customergrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
