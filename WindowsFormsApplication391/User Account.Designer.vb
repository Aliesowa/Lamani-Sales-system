<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Account
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
        Me.RibbonControl2 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.Savebtn = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.SkinPaletteRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem()
        Me.SkinDropDownButtonItem1 = New DevExpress.XtraBars.SkinDropDownButtonItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem3 = New DevExpress.XtraBars.BarEditItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.stafflookup = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.pass = New DevExpress.XtraEditors.TextEdit()
        Me.username = New DevExpress.XtraEditors.TextEdit()
        Me.userGroup = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stafflookup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.pass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl2
        '
        Me.RibbonControl2.ExpandCollapseItem.Id = 0
        Me.RibbonControl2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl2.ExpandCollapseItem, Me.BarButtonItem5, Me.BarButtonItem6, Me.Savebtn, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.SkinRibbonGalleryBarItem1, Me.SkinPaletteRibbonGalleryBarItem1, Me.SkinDropDownButtonItem1, Me.BarEditItem1, Me.BarEditItem2, Me.BarButtonItem10, Me.BarEditItem3, Me.BarButtonItem1})
        Me.RibbonControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl2.MaxItemId = 15
        Me.RibbonControl2.Name = "RibbonControl2"
        Me.RibbonControl2.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage3})
        Me.RibbonControl2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal
        Me.RibbonControl2.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl2.Size = New System.Drawing.Size(1124, 52)
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "New"
        Me.BarButtonItem5.Id = 1
        Me.BarButtonItem5.ImageOptions.Image = Global.My.Resources.Resources.addfile_16x16
        Me.BarButtonItem5.ImageOptions.LargeImage = Global.My.Resources.Resources.addfile_32x32
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Open"
        Me.BarButtonItem6.Id = 2
        Me.BarButtonItem6.ImageOptions.Image = Global.My.Resources.Resources.open_16x16
        Me.BarButtonItem6.ImageOptions.LargeImage = Global.My.Resources.Resources.open_32x32
        Me.BarButtonItem6.Name = "BarButtonItem6"
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
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Logout"
        Me.BarButtonItem9.Id = 6
        Me.BarButtonItem9.ImageOptions.Image = Global.My.Resources.Resources.bopermission_16x16
        Me.BarButtonItem9.ImageOptions.LargeImage = Global.My.Resources.Resources.bopermission_32x32
        Me.BarButtonItem9.Name = "BarButtonItem9"
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
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Delete"
        Me.BarButtonItem10.Id = 12
        Me.BarButtonItem10.ImageOptions.Image = Global.My.Resources.Resources.trash_16x16
        Me.BarButtonItem10.ImageOptions.LargeImage = Global.My.Resources.Resources.trash_32x32
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarEditItem3
        '
        Me.BarEditItem3.Caption = "BarEditItem3"
        Me.BarEditItem3.Edit = Nothing
        Me.BarEditItem3.Id = 13
        Me.BarEditItem3.Name = "BarEditItem3"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Export to Excel"
        Me.BarButtonItem1.Id = 14
        Me.BarButtonItem1.ImageOptions.Image = Global.My.Resources.Resources.exporttoxls_32x32
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
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem10)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        '
        'stafflookup
        '
        Me.stafflookup.Location = New System.Drawing.Point(112, 89)
        Me.stafflookup.MenuManager = Me.RibbonControl2
        Me.stafflookup.Name = "stafflookup"
        Me.stafflookup.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stafflookup.Properties.Appearance.Options.UseFont = True
        Me.stafflookup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.stafflookup.Properties.DropDownRows = 20
        Me.stafflookup.Properties.NullText = ""
        Me.stafflookup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.stafflookup.Size = New System.Drawing.Size(178, 24)
        Me.stafflookup.TabIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(49, 137)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 14)
        Me.LabelControl1.TabIndex = 43
        Me.LabelControl1.Text = "Username"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(52, 177)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(51, 14)
        Me.LabelControl8.TabIndex = 41
        Me.LabelControl8.Text = "Password"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.pass)
        Me.GroupControl1.Controls.Add(Me.username)
        Me.GroupControl1.Controls.Add(Me.userGroup)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.stafflookup)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 58)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(428, 491)
        Me.GroupControl1.TabIndex = 48
        Me.GroupControl1.Text = "User Account"
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(112, 175)
        Me.pass.Margin = New System.Windows.Forms.Padding(0)
        Me.pass.MenuManager = Me.RibbonControl2
        Me.pass.Name = "pass"
        Me.pass.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.Properties.Appearance.Options.UseFont = True
        Me.pass.Properties.UseSystemPasswordChar = True
        Me.pass.Size = New System.Drawing.Size(178, 22)
        Me.pass.TabIndex = 51
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(112, 137)
        Me.username.Margin = New System.Windows.Forms.Padding(0)
        Me.username.MenuManager = Me.RibbonControl2
        Me.username.Name = "username"
        Me.username.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Properties.Appearance.Options.UseFont = True
        Me.username.Size = New System.Drawing.Size(178, 22)
        Me.username.TabIndex = 50
        '
        'userGroup
        '
        Me.userGroup.Location = New System.Drawing.Point(112, 217)
        Me.userGroup.MenuManager = Me.RibbonControl2
        Me.userGroup.Name = "userGroup"
        Me.userGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.userGroup.Properties.Items.AddRange(New Object() {"Standard User", "Super User"})
        Me.userGroup.Size = New System.Drawing.Size(178, 20)
        Me.userGroup.TabIndex = 49
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(42, 220)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(61, 14)
        Me.LabelControl11.TabIndex = 48
        Me.LabelControl11.Text = "User Group"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(55, 92)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 14)
        Me.LabelControl3.TabIndex = 40
        Me.LabelControl3.Text = "Staff ID"
        '
        'User_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl2)
        Me.Name = "User_Account"
        Me.Size = New System.Drawing.Size(1124, 549)
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stafflookup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.pass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl2 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Savebtn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents SkinPaletteRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem
    Friend WithEvents SkinDropDownButtonItem1 As DevExpress.XtraBars.SkinDropDownButtonItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem2 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarEditItem3 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents stafflookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents userGroup As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents pass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents username As DevExpress.XtraEditors.TextEdit
End Class
