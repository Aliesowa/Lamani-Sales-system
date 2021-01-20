<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Post
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
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
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.deletebtn = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.Savebtn = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.BarEditItem3 = New DevExpress.XtraBars.BarEditItem()
        Me.productgrid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RibbonControl2 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinPaletteRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem()
        Me.SkinDropDownButtonItem1 = New DevExpress.XtraBars.SkinDropDownButtonItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.ProId = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        CType(Me.productgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'deletebtn
        '
        Me.deletebtn.Caption = "Delete"
        Me.deletebtn.Id = 12
        Me.deletebtn.ImageOptions.Image = Global.My.Resources.Resources.trash_16x16
        Me.deletebtn.ImageOptions.LargeImage = Global.My.Resources.Resources.trash_32x32
        Me.deletebtn.Name = "deletebtn"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 14
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Home"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ImageOptions.ImageIndex = 100
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.Savebtn)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem7)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem8)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.deletebtn)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Export"
        Me.BarButtonItem5.Id = 1
        Me.BarButtonItem5.ImageOptions.Image = Global.My.Resources.Resources.addfile_16x16
        Me.BarButtonItem5.ImageOptions.LargeImage = Global.My.Resources.Resources.addfile_32x32
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'Savebtn
        '
        Me.Savebtn.Caption = "Save"
        Me.Savebtn.Id = 3
        Me.Savebtn.ImageOptions.Image = Global.My.Resources.Resources.save_16x16
        Me.Savebtn.ImageOptions.LargeImage = Global.My.Resources.Resources.save_32x32
        Me.Savebtn.Name = "Savebtn"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Save As"
        Me.BarButtonItem7.Id = 4
        Me.BarButtonItem7.ImageOptions.Image = Global.My.Resources.Resources.saveas_16x16
        Me.BarButtonItem7.ImageOptions.LargeImage = Global.My.Resources.Resources.saveas_32x32
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Print"
        Me.BarButtonItem8.Id = 5
        Me.BarButtonItem8.ImageOptions.Image = Global.My.Resources.Resources.printer_16x16
        Me.BarButtonItem8.ImageOptions.LargeImage = Global.My.Resources.Resources.printer_32x32
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "View"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        '
        '
        '
        Me.SkinRibbonGalleryBarItem1.Gallery.ImageSize = New System.Drawing.Size(150, 0)
        Me.SkinRibbonGalleryBarItem1.Gallery.ShowItemText = True
        Me.SkinRibbonGalleryBarItem1.Id = 7
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'BarEditItem3
        '
        Me.BarEditItem3.Caption = "BarEditItem3"
        Me.BarEditItem3.Edit = Nothing
        Me.BarEditItem3.Id = 13
        Me.BarEditItem3.Name = "BarEditItem3"
        '
        'productgrid
        '
        Me.productgrid.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.productgrid.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productgrid.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.productgrid.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.productgrid.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.productgrid.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.productgrid.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.productgrid.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.productgrid.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.productgrid.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.productgrid.Location = New System.Drawing.Point(451, 20)
        Me.productgrid.MainView = Me.GridView1
        Me.productgrid.MenuManager = Me.RibbonControl2
        Me.productgrid.Name = "productgrid"
        Me.productgrid.Size = New System.Drawing.Size(771, 422)
        Me.productgrid.TabIndex = 45
        Me.productgrid.UseEmbeddedNavigator = True
        Me.productgrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView1.GridControl = Me.productgrid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        '
        'RibbonControl2
        '
        Me.RibbonControl2.ExpandCollapseItem.Id = 0
        Me.RibbonControl2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl2.ExpandCollapseItem, Me.BarButtonItem5, Me.BarButtonItem6, Me.Savebtn, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.SkinRibbonGalleryBarItem1, Me.SkinPaletteRibbonGalleryBarItem1, Me.SkinDropDownButtonItem1, Me.BarEditItem1, Me.BarEditItem2, Me.deletebtn, Me.BarEditItem3, Me.BarButtonItem1})
        Me.RibbonControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl2.MaxItemId = 15
        Me.RibbonControl2.Name = "RibbonControl2"
        Me.RibbonControl2.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage3, Me.RibbonPage4})
        Me.RibbonControl2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal
        Me.RibbonControl2.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl2.Size = New System.Drawing.Size(1230, 79)
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Open"
        Me.BarButtonItem6.Id = 2
        Me.BarButtonItem6.ImageOptions.Image = Global.My.Resources.Resources.open_16x16
        Me.BarButtonItem6.ImageOptions.LargeImage = Global.My.Resources.Resources.open_32x32
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Logout"
        Me.BarButtonItem9.Id = 6
        Me.BarButtonItem9.ImageOptions.Image = Global.My.Resources.Resources.bopermission_16x16
        Me.BarButtonItem9.ImageOptions.LargeImage = Global.My.Resources.Resources.bopermission_32x32
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'SkinPaletteRibbonGalleryBarItem1
        '
        Me.SkinPaletteRibbonGalleryBarItem1.Caption = "SkinPaletteRibbonGalleryBarItem1"
        '
        '
        '
        Me.SkinPaletteRibbonGalleryBarItem1.Gallery.ImageSize = New System.Drawing.Size(100, 50)
        Me.SkinPaletteRibbonGalleryBarItem1.Gallery.ShowItemText = True
        Me.SkinPaletteRibbonGalleryBarItem1.Id = 8
        Me.SkinPaletteRibbonGalleryBarItem1.Name = "SkinPaletteRibbonGalleryBarItem1"
        '
        'SkinDropDownButtonItem1
        '
        Me.SkinDropDownButtonItem1.Id = 9
        Me.SkinDropDownButtonItem1.Name = "SkinDropDownButtonItem1"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "Search"
        Me.BarEditItem1.Edit = Nothing
        Me.BarEditItem1.EditWidth = 200
        Me.BarEditItem1.Id = 10
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'BarEditItem2
        '
        Me.BarEditItem2.Caption = "Search By"
        Me.BarEditItem2.Edit = Nothing
        Me.BarEditItem2.EditWidth = 100
        Me.BarEditItem2.Id = 11
        Me.BarEditItem2.Name = "BarEditItem2"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.DateTimePicker1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.productgrid)
        Me.GroupControl1.Controls.Add(Me.TextEdit3)
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(Me.ProId)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 79)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1230, 466)
        Me.GroupControl1.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(194, 94)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker1.TabIndex = 58
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton1.Location = New System.Drawing.Point(219, 302)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(106, 34)
        Me.SimpleButton1.TabIndex = 57
        Me.SimpleButton1.Text = "Post"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(110, 262)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 18)
        Me.LabelControl4.TabIndex = 56
        Me.LabelControl4.Text = "Total"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(15, 221)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(128, 18)
        Me.LabelControl2.TabIndex = 56
        Me.LabelControl2.Text = "Management Credit"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(60, 186)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(83, 18)
        Me.LabelControl1.TabIndex = 56
        Me.LabelControl1.Text = "Expenditures"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(110, 141)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(33, 18)
        Me.LabelControl6.TabIndex = 56
        Me.LabelControl6.Text = "Sales"
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(149, 259)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit3.Properties.Appearance.Options.UseFont = True
        Me.TextEdit3.Size = New System.Drawing.Size(245, 24)
        Me.TextEdit3.TabIndex = 26
        Me.TextEdit3.Visible = False
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(149, 218)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Size = New System.Drawing.Size(245, 24)
        Me.TextEdit2.TabIndex = 26
        Me.TextEdit2.Visible = False
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(149, 180)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Size = New System.Drawing.Size(245, 24)
        Me.TextEdit1.TabIndex = 26
        Me.TextEdit1.Visible = False
        '
        'ProId
        '
        Me.ProId.Location = New System.Drawing.Point(149, 138)
        Me.ProId.Name = "ProId"
        Me.ProId.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProId.Properties.Appearance.Options.UseFont = True
        Me.ProId.Size = New System.Drawing.Size(245, 24)
        Me.ProId.TabIndex = 26
        Me.ProId.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(162, 96)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(26, 16)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "Date"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage2"
        '
        'Post
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 545)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl2)
        Me.Name = "Post"
        Me.Ribbon = Me.RibbonControl2
        Me.Text = "Post"
        CType(Me.productgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents deletebtn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Savebtn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents BarEditItem3 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents productgrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RibbonControl2 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SkinPaletteRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem
    Friend WithEvents SkinDropDownButtonItem1 As DevExpress.XtraBars.SkinDropDownButtonItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem2 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
End Class
