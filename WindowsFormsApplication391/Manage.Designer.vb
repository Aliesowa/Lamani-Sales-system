<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Todate = New DevExpress.XtraEditors.DateEdit()
        Me.frmdate = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.profit_loss = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.credit_txt = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.expentxt = New DevExpress.XtraEditors.TextEdit()
        Me.Salestxt = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.Todate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Todate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frmdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.profit_loss.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.credit_txt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.expentxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salestxt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Todate)
        Me.PanelControl1.Controls.Add(Me.frmdate)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(715, 549)
        Me.PanelControl1.TabIndex = 0
        '
        'Todate
        '
        Me.Todate.EditValue = Nothing
        Me.Todate.Location = New System.Drawing.Point(324, 63)
        Me.Todate.Name = "Todate"
        Me.Todate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Todate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Todate.Size = New System.Drawing.Size(119, 20)
        Me.Todate.TabIndex = 7
        '
        'frmdate
        '
        Me.frmdate.EditValue = Nothing
        Me.frmdate.Location = New System.Drawing.Point(78, 63)
        Me.frmdate.Name = "frmdate"
        Me.frmdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.frmdate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.frmdate.Size = New System.Drawing.Size(121, 20)
        Me.frmdate.TabIndex = 6
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton1.Location = New System.Drawing.Point(477, 56)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(65, 30)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "GO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(361, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "From"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.profit_loss)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.credit_txt)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.expentxt)
        Me.GroupControl1.Controls.Add(Me.Salestxt)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Location = New System.Drawing.Point(42, 99)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(512, 374)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Summary"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(167, 339)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Label7"
        Me.Label7.Visible = False
        '
        'profit_loss
        '
        Me.profit_loss.Location = New System.Drawing.Point(163, 304)
        Me.profit_loss.Name = "profit_loss"
        Me.profit_loss.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profit_loss.Properties.Appearance.Options.UseFont = True
        Me.profit_loss.Size = New System.Drawing.Size(288, 32)
        Me.profit_loss.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Gross Profit / Loss"
        '
        'credit_txt
        '
        Me.credit_txt.Location = New System.Drawing.Point(163, 177)
        Me.credit_txt.Name = "credit_txt"
        Me.credit_txt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.credit_txt.Properties.Appearance.Options.UseFont = True
        Me.credit_txt.Properties.ReadOnly = True
        Me.credit_txt.Size = New System.Drawing.Size(276, 26)
        Me.credit_txt.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(106, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Credit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Expenditures"
        '
        'expentxt
        '
        Me.expentxt.Location = New System.Drawing.Point(157, 117)
        Me.expentxt.Name = "expentxt"
        Me.expentxt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expentxt.Properties.Appearance.Options.UseFont = True
        Me.expentxt.Properties.DisplayFormat.FormatString = "###,###.##"
        Me.expentxt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.expentxt.Properties.EditFormat.FormatString = "###,###.##"
        Me.expentxt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.expentxt.Properties.ReadOnly = True
        Me.expentxt.Size = New System.Drawing.Size(282, 26)
        Me.expentxt.TabIndex = 0
        '
        'Salestxt
        '
        Me.Salestxt.Location = New System.Drawing.Point(157, 61)
        Me.Salestxt.Name = "Salestxt"
        Me.Salestxt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salestxt.Properties.Appearance.Options.UseFont = True
        Me.Salestxt.Properties.DisplayFormat.FormatString = "###,###.##"
        Me.Salestxt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Salestxt.Properties.EditFormat.FormatString = "###,###.##"
        Me.Salestxt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Salestxt.Properties.ReadOnly = True
        Me.Salestxt.Size = New System.Drawing.Size(282, 26)
        Me.Salestxt.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sales"
        '
        'Manage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "Manage"
        Me.Size = New System.Drawing.Size(715, 549)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.Todate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Todate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmdate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frmdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.profit_loss.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.credit_txt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.expentxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salestxt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents profit_loss As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents credit_txt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Salestxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Todate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents frmdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents expentxt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As Label
End Class
