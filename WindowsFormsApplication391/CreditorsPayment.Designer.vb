<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditorsPayment
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
        Me.creditpaymentGrid = New DevExpress.XtraGrid.GridControl()
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
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.currency = New System.Windows.Forms.ComboBox()
        Me.TotalCredit = New DevExpress.XtraEditors.SpinEdit()
        Me.payAmount = New DevExpress.XtraEditors.SpinEdit()
        Me.paymentId = New DevExpress.XtraEditors.TextEdit()
        Me.TotalSalesTxt = New DevExpress.XtraEditors.TextEdit()
        Me.paymentDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.credit = New DevExpress.XtraEditors.LookUpEdit()
        Me.stafflookup = New DevExpress.XtraEditors.LookUpEdit()
        Me.creditor = New DevExpress.XtraEditors.LookUpEdit()
        Me.balanceCredit = New DevExpress.XtraEditors.SpinEdit()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        CType(Me.creditpaymentGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.payAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paymentId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalSalesTxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paymentDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paymentDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.credit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stafflookup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.creditor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.balanceCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'creditpaymentGrid
        '
        Me.creditpaymentGrid.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.creditpaymentGrid.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creditpaymentGrid.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.creditpaymentGrid.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.creditpaymentGrid.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.creditpaymentGrid.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.creditpaymentGrid.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.creditpaymentGrid.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.creditpaymentGrid.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.creditpaymentGrid.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.creditpaymentGrid.Location = New System.Drawing.Point(451, 20)
        Me.creditpaymentGrid.MainView = Me.GridView1
        Me.creditpaymentGrid.MenuManager = Me.RibbonControl2
        Me.creditpaymentGrid.Name = "creditpaymentGrid"
        Me.creditpaymentGrid.Size = New System.Drawing.Size(771, 422)
        Me.creditpaymentGrid.TabIndex = 45
        Me.creditpaymentGrid.UseEmbeddedNavigator = True
        Me.creditpaymentGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GridView1.GridControl = Me.creditpaymentGrid
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
        Me.RibbonControl2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl2.ExpandCollapseItem, Me.BarButtonItem5, Me.BarButtonItem6, Me.Savebtn, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.SkinRibbonGalleryBarItem1, Me.SkinPaletteRibbonGalleryBarItem1, Me.SkinDropDownButtonItem1, Me.BarEditItem1, Me.BarEditItem2, Me.BarButtonItem10, Me.BarEditItem3})
        Me.RibbonControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl2.MaxItemId = 14
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
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem10)
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
        'currency
        '
        Me.currency.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currency.FormattingEnabled = True
        Me.currency.Items.AddRange(New Object() {"Leones (Le)", "U.S. Dollars ($)", "Pounds (£)", "Euros (€)"})
        Me.currency.Location = New System.Drawing.Point(84, 187)
        Me.currency.Name = "currency"
        Me.currency.Size = New System.Drawing.Size(125, 26)
        Me.currency.TabIndex = 29
        '
        'TotalCredit
        '
        Me.TotalCredit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TotalCredit.Location = New System.Drawing.Point(84, 231)
        Me.TotalCredit.Name = "TotalCredit"
        Me.TotalCredit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCredit.Properties.Appearance.Options.UseFont = True
        Me.TotalCredit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TotalCredit.Properties.ReadOnly = True
        Me.TotalCredit.Size = New System.Drawing.Size(135, 24)
        Me.TotalCredit.TabIndex = 28
        '
        'payAmount
        '
        Me.payAmount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.payAmount.Location = New System.Drawing.Point(289, 189)
        Me.payAmount.Name = "payAmount"
        Me.payAmount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payAmount.Properties.Appearance.Options.UseFont = True
        Me.payAmount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.payAmount.Size = New System.Drawing.Size(125, 24)
        Me.payAmount.TabIndex = 27
        '
        'paymentId
        '
        Me.paymentId.Location = New System.Drawing.Point(8, 23)
        Me.paymentId.Name = "paymentId"
        Me.paymentId.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentId.Properties.Appearance.Options.UseFont = True
        Me.paymentId.Size = New System.Drawing.Size(74, 24)
        Me.paymentId.TabIndex = 26
        '
        'TotalSalesTxt
        '
        Me.TotalSalesTxt.Location = New System.Drawing.Point(192, 345)
        Me.TotalSalesTxt.Name = "TotalSalesTxt"
        Me.TotalSalesTxt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSalesTxt.Properties.Appearance.Options.UseFont = True
        Me.TotalSalesTxt.Properties.ReadOnly = True
        Me.TotalSalesTxt.Size = New System.Drawing.Size(249, 36)
        Me.TotalSalesTxt.TabIndex = 25
        '
        'paymentDate
        '
        Me.paymentDate.EditValue = Nothing
        Me.paymentDate.Location = New System.Drawing.Point(285, 71)
        Me.paymentDate.Name = "paymentDate"
        Me.paymentDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentDate.Properties.Appearance.Options.UseFont = True
        Me.paymentDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.paymentDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.paymentDate.Size = New System.Drawing.Size(129, 24)
        Me.paymentDate.TabIndex = 23
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(45, 234)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(33, 18)
        Me.LabelControl9.TabIndex = 21
        Me.LabelControl9.Text = "Total"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(259, 192)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 18)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "Pay"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(38, 353)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(148, 23)
        Me.LabelControl7.TabIndex = 22
        Me.LabelControl7.Text = "Total Payments"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(233, 234)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(50, 18)
        Me.LabelControl2.TabIndex = 20
        Me.LabelControl2.Text = "Balance"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(20, 190)
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
        Me.LabelControl5.Location = New System.Drawing.Point(41, 155)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(37, 18)
        Me.LabelControl5.TabIndex = 17
        Me.LabelControl5.Text = "Credit"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(28, 114)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 18)
        Me.LabelControl4.TabIndex = 16
        Me.LabelControl4.Text = "Creditor"
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
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.credit)
        Me.GroupControl1.Controls.Add(Me.stafflookup)
        Me.GroupControl1.Controls.Add(Me.creditor)
        Me.GroupControl1.Controls.Add(Me.creditpaymentGrid)
        Me.GroupControl1.Controls.Add(Me.currency)
        Me.GroupControl1.Controls.Add(Me.balanceCredit)
        Me.GroupControl1.Controls.Add(Me.TotalCredit)
        Me.GroupControl1.Controls.Add(Me.payAmount)
        Me.GroupControl1.Controls.Add(Me.paymentId)
        Me.GroupControl1.Controls.Add(Me.TotalSalesTxt)
        Me.GroupControl1.Controls.Add(Me.paymentDate)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 79)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1230, 450)
        Me.GroupControl1.TabIndex = 3
        '
        'credit
        '
        Me.credit.Location = New System.Drawing.Point(84, 152)
        Me.credit.Name = "credit"
        Me.credit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.credit.Properties.Appearance.Options.UseFont = True
        Me.credit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.credit.Properties.DropDownRows = 20
        Me.credit.Properties.NullText = ""
        Me.credit.Size = New System.Drawing.Size(330, 24)
        Me.credit.TabIndex = 46
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
        Me.stafflookup.Size = New System.Drawing.Size(148, 24)
        Me.stafflookup.TabIndex = 46
        '
        'creditor
        '
        Me.creditor.Location = New System.Drawing.Point(84, 111)
        Me.creditor.MenuManager = Me.RibbonControl2
        Me.creditor.Name = "creditor"
        Me.creditor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creditor.Properties.Appearance.Options.UseFont = True
        Me.creditor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.creditor.Properties.DropDownRows = 20
        Me.creditor.Properties.NullText = ""
        Me.creditor.Size = New System.Drawing.Size(330, 24)
        Me.creditor.TabIndex = 46
        '
        'balanceCredit
        '
        Me.balanceCredit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.balanceCredit.Location = New System.Drawing.Point(289, 231)
        Me.balanceCredit.Name = "balanceCredit"
        Me.balanceCredit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balanceCredit.Properties.Appearance.Options.UseFont = True
        Me.balanceCredit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.balanceCredit.Properties.ReadOnly = True
        Me.balanceCredit.Size = New System.Drawing.Size(135, 24)
        Me.balanceCredit.TabIndex = 28
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 529)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Nothing
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1230, 20)
        '
        'CreditorsPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 549)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl2)
        Me.Name = "CreditorsPayment"
        Me.Ribbon = Me.RibbonControl2
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Creditor's Payment"
        CType(Me.creditpaymentGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.payAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paymentId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalSalesTxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paymentDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paymentDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.credit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stafflookup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.creditor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.balanceCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents creditpaymentGrid As DevExpress.XtraGrid.GridControl
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
    Friend WithEvents currency As ComboBox
    Friend WithEvents TotalCredit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents payAmount As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents paymentId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TotalSalesTxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents paymentDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents credit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents stafflookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents creditor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents balanceCredit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
End Class
