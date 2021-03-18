<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class configuration
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
        Me.RibbonControl2 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.user = New System.Windows.Forms.TextBox()
        Me.database = New System.Windows.Forms.TextBox()
        Me.ServerName = New System.Windows.Forms.TextBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'RibbonControl2
        '
        Me.RibbonControl2.ExpandCollapseItem.Id = 0
        Me.RibbonControl2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl2.ExpandCollapseItem})
        Me.RibbonControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl2.MaxItemId = 15
        Me.RibbonControl2.Name = "RibbonControl2"
        Me.RibbonControl2.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl2.Size = New System.Drawing.Size(356, 49)
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.pass)
        Me.GroupControl1.Controls.Add(Me.user)
        Me.GroupControl1.Controls.Add(Me.database)
        Me.GroupControl1.Controls.Add(Me.ServerName)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 49)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(356, 315)
        Me.GroupControl1.TabIndex = 2
        '
        'pass
        '
        Me.pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pass.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Settings.Default, "password", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.pass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.Location = New System.Drawing.Point(99, 186)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(201, 16)
        Me.pass.TabIndex = 3
        Me.pass.Text = Global.Settings.Default.password
        Me.pass.UseSystemPasswordChar = True
        '
        'user
        '
        Me.user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.user.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Settings.Default, "Username", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.user.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(99, 142)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(201, 16)
        Me.user.TabIndex = 3
        Me.user.Text = Global.Settings.Default.Username
        '
        'database
        '
        Me.database.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.database.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Settings.Default, "Data", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.database.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.database.Location = New System.Drawing.Point(99, 98)
        Me.database.Name = "database"
        Me.database.Size = New System.Drawing.Size(201, 16)
        Me.database.TabIndex = 3
        Me.database.Text = Global.Settings.Default.Data
        '
        'ServerName
        '
        Me.ServerName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ServerName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Settings.Default, "Server", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ServerName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerName.Location = New System.Drawing.Point(99, 54)
        Me.ServerName.Name = "ServerName"
        Me.ServerName.Size = New System.Drawing.Size(201, 16)
        Me.ServerName.TabIndex = 3
        Me.ServerName.Text = Global.Settings.Default.Server
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton2.Location = New System.Drawing.Point(192, 238)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(108, 26)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "Save"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton1.Location = New System.Drawing.Point(35, 238)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(108, 26)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "Test Connection"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(38, 189)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "Password"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(35, 142)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Username"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(40, 98)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Database"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(55, 55)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Server"
        '
        'configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 364)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl2)
        Me.MaximizeBox = False
        Me.Name = "configuration"
        Me.Ribbon = Me.RibbonControl2
        Me.ShowIcon = False
        Me.Text = "Configuration"
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonControl2 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pass As TextBox
    Friend WithEvents user As TextBox
    Friend WithEvents database As TextBox
    Friend WithEvents ServerName As TextBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
