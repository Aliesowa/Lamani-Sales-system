<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expenditures
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
        Me.components = New System.ComponentModel.Container()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.expenGrid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.expenCurrency = New System.Windows.Forms.ComboBox()
        Me.expenAmount = New DevExpress.XtraEditors.SpinEdit()
        Me.expenId = New DevExpress.XtraEditors.TextEdit()
        Me.TotalSalesTxt = New DevExpress.XtraEditors.TextEdit()
        Me.SalesDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.expenPurpose = New System.Windows.Forms.TextBox()
        Me.stafflookup = New DevExpress.XtraEditors.LookUpEdit()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        CType(Me.expenGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.expenAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.expenId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalSalesTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.stafflookup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'expenGrid
        '
        Me.expenGrid.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.expenGrid.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expenGrid.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.expenGrid.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.expenGrid.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.expenGrid.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.expenGrid.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.expenGrid.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.expenGrid.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.expenGrid.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.expenGrid.Location = New System.Drawing.Point(451, 0)
        Me.expenGrid.MainView = Me.GridView1
        Me.expenGrid.MenuManager = Me.RibbonControl2
        Me.expenGrid.Name = "expenGrid"
        Me.expenGrid.Size = New System.Drawing.Size(771, 461)
        Me.expenGrid.TabIndex = 45
        Me.expenGrid.UseEmbeddedNavigator = True
        Me.expenGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView1.GridControl = Me.expenGrid
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
        Me.RibbonControl2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl2.ExpandCollapseItem, Me.BarButtonItem5, Me.BarButtonItem6, Me.Savebtn, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.SkinRibbonGalleryBarItem1, Me.SkinPaletteRibbonGalleryBarItem1, Me.SkinDropDownButtonItem1, Me.BarEditItem1, Me.BarEditItem2, Me.BarButtonItem10, Me.BarEditItem3, Me.BarButtonItem1})
        Me.RibbonControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl2.MaxItemId = 15
        Me.RibbonControl2.Name = "RibbonControl2"
        Me.RibbonControl2.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage3, Me.RibbonPage4})
        Me.RibbonControl2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal
        Me.RibbonControl2.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl2.Size = New System.Drawing.Size(1230, 79)
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
        Me.BarButtonItem1.Caption = "Export To Excel"
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
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem10)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
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
        'expenCurrency
        '
        Me.expenCurrency.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expenCurrency.FormattingEnabled = True
        Me.expenCurrency.Items.AddRange(New Object() {"Leones (Le)", "U.S. Dollars ($)", "Pounds (£)", "Euros (€)"})
        Me.expenCurrency.Location = New System.Drawing.Point(84, 246)
        Me.expenCurrency.Name = "expenCurrency"
        Me.expenCurrency.Size = New System.Drawing.Size(125, 26)
        Me.expenCurrency.TabIndex = 29
        '
        'expenAmount
        '
        Me.expenAmount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.expenAmount.Location = New System.Drawing.Point(288, 248)
        Me.expenAmount.Name = "expenAmount"
        Me.expenAmount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expenAmount.Properties.Appearance.Options.UseFont = True
        Me.expenAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.expenAmount.Size = New System.Drawing.Size(126, 24)
        Me.expenAmount.TabIndex = 27
        '
        'expenId
        '
        Me.expenId.Location = New System.Drawing.Point(8, 23)
        Me.expenId.Name = "expenId"
        Me.expenId.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expenId.Properties.Appearance.Options.UseFont = True
        Me.expenId.Size = New System.Drawing.Size(152, 24)
        Me.expenId.TabIndex = 26
        '
        'TotalSalesTxt
        '
        Me.TotalSalesTxt.Location = New System.Drawing.Point(166, 345)
        Me.TotalSalesTxt.Name = "TotalSalesTxt"
        Me.TotalSalesTxt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSalesTxt.Properties.Appearance.Options.UseFont = True
        Me.TotalSalesTxt.Properties.ReadOnly = True
        Me.TotalSalesTxt.Size = New System.Drawing.Size(275, 36)
        Me.TotalSalesTxt.TabIndex = 25
        '
        'SalesDate
        '
        Me.SalesDate.EditValue = Nothing
        Me.SalesDate.Location = New System.Drawing.Point(285, 71)
        Me.SalesDate.Name = "SalesDate"
        Me.SalesDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesDate.Properties.Appearance.Options.UseFont = True
        Me.SalesDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SalesDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SalesDate.Size = New System.Drawing.Size(129, 24)
        Me.SalesDate.TabIndex = 23
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(5, 353)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(155, 19)
        Me.LabelControl7.TabIndex = 22
        Me.LabelControl7.Text = "Total Expenditures"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(229, 251)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 18)
        Me.LabelControl2.TabIndex = 20
        Me.LabelControl2.Text = "Amount"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(20, 249)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(58, 18)
        Me.LabelControl8.TabIndex = 19
        Me.LabelControl8.Text = "Currency"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(45, 74)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(33, 18)
        Me.LabelControl10.TabIndex = 16
        Me.LabelControl10.Text = "Staff"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(26, 165)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(52, 18)
        Me.LabelControl5.TabIndex = 17
        Me.LabelControl5.Text = "Purpose"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(248, 74)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(31, 18)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "Date"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.expenPurpose)
        Me.GroupControl1.Controls.Add(Me.stafflookup)
        Me.GroupControl1.Controls.Add(Me.expenGrid)
        Me.GroupControl1.Controls.Add(Me.expenCurrency)
        Me.GroupControl1.Controls.Add(Me.expenAmount)
        Me.GroupControl1.Controls.Add(Me.expenId)
        Me.GroupControl1.Controls.Add(Me.TotalSalesTxt)
        Me.GroupControl1.Controls.Add(Me.SalesDate)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 79)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1230, 466)
        Me.GroupControl1.TabIndex = 4
        '
        'expenPurpose
        '
        Me.expenPurpose.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.expenPurpose.Location = New System.Drawing.Point(84, 119)
        Me.expenPurpose.Multiline = True
        Me.expenPurpose.Name = "expenPurpose"
        Me.expenPurpose.Size = New System.Drawing.Size(330, 108)
        Me.expenPurpose.TabIndex = 47
        '
        'stafflookup
        '
        Me.stafflookup.Location = New System.Drawing.Point(84, 71)
        Me.stafflookup.Name = "stafflookup"
        Me.stafflookup.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stafflookup.Properties.Appearance.Options.UseFont = True
        Me.stafflookup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.stafflookup.Properties.DropDownRows = 20
        Me.stafflookup.Properties.NullText = ""
        Me.stafflookup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.stafflookup.Size = New System.Drawing.Size(148, 24)
        Me.stafflookup.TabIndex = 46
        '
        'Expenditures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 545)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl2)
        Me.Name = "Expenditures"
        Me.Ribbon = Me.RibbonControl2
        Me.ShowIcon = False
        Me.Text = "Expenditures"
        CType(Me.expenGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.expenAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.expenId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalSalesTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.stafflookup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents expenGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents expenCurrency As ComboBox
    Friend WithEvents expenAmount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents expenId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TotalSalesTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SalesDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents stafflookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents expenPurpose As TextBox
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
