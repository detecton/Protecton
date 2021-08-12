'
' Created by SharpDevelop.
' User: Ariel
' Date: 05/03/2021
' Time: 13:45
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label2 = New System.Windows.Forms.Label()
		Me.guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
		Me.guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
		Me.guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
		Me.guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
		Me.guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
		Me.statusStrip1.SuspendLayout
		Me.guna2Panel1.SuspendLayout
		Me.panel1.SuspendLayout
		Me.SuspendLayout
		'
		'statusStrip1
		'
		Me.statusStrip1.BackColor = System.Drawing.Color.Black
		Me.statusStrip1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1})
		Me.statusStrip1.Location = New System.Drawing.Point(0, 473)
		Me.statusStrip1.Name = "statusStrip1"
		Me.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
		Me.statusStrip1.Size = New System.Drawing.Size(673, 24)
		Me.statusStrip1.TabIndex = 5
		Me.statusStrip1.Text = "statusStrip1"
		'
		'toolStripStatusLabel1
		'
		Me.toolStripStatusLabel1.Font = New System.Drawing.Font("Calibri", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
		Me.toolStripStatusLabel1.Size = New System.Drawing.Size(146, 19)
		Me.toolStripStatusLabel1.Text = "toolStripStatusLabel1"
		Me.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'guna2Panel1
		'
		Me.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke
		Me.guna2Panel1.BorderThickness = 5
		Me.guna2Panel1.Controls.Add(Me.panel1)
		Me.guna2Panel1.Controls.Add(Me.guna2ComboBox1)
		Me.guna2Panel1.Controls.Add(Me.label1)
		Me.guna2Panel1.Controls.Add(Me.guna2TextBox1)
		Me.guna2Panel1.Controls.Add(Me.guna2Button2)
		Me.guna2Panel1.Controls.Add(Me.guna2Button1)
		Me.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(24,Byte),Integer), CType(CType(40,Byte),Integer), CType(CType(46,Byte),Integer))
		Me.guna2Panel1.Location = New System.Drawing.Point(0, 0)
		Me.guna2Panel1.Name = "guna2Panel1"
		Me.guna2Panel1.ShadowDecoration.Parent = Me.guna2Panel1
		Me.guna2Panel1.Size = New System.Drawing.Size(673, 473)
		Me.guna2Panel1.TabIndex = 6
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.Teal
		Me.panel1.Controls.Add(Me.label2)
		Me.panel1.Controls.Add(Me.guna2Button4)
		Me.panel1.Controls.Add(Me.guna2Button3)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panel1.Location = New System.Drawing.Point(0, 0)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(673, 39)
		Me.panel1.TabIndex = 10
		AddHandler Me.panel1.MouseMove, AddressOf Me.panel1_MouseMove
		'
		'label2
		'
		Me.label2.Dock = System.Windows.Forms.DockStyle.Left
		Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.label2.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.ForeColor = System.Drawing.Color.White
		Me.label2.Location = New System.Drawing.Point(0, 0)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(83, 39)
		Me.label2.TabIndex = 4
		Me.label2.Text = "Protectom"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'guna2Button4
		'
		Me.guna2Button4.BackColor = System.Drawing.Color.Transparent
		Me.guna2Button4.CheckedState.Parent = Me.guna2Button4
		Me.guna2Button4.CustomImages.Parent = Me.guna2Button4
		Me.guna2Button4.Dock = System.Windows.Forms.DockStyle.Right
		Me.guna2Button4.FillColor = System.Drawing.Color.Transparent
		Me.guna2Button4.Font = New System.Drawing.Font("Segoe UI Black", 14.25!)
		Me.guna2Button4.ForeColor = System.Drawing.Color.White
		Me.guna2Button4.HoverState.Parent = Me.guna2Button4
		Me.guna2Button4.Location = New System.Drawing.Point(597, 0)
		Me.guna2Button4.Name = "guna2Button4"
		Me.guna2Button4.ShadowDecoration.Parent = Me.guna2Button4
		Me.guna2Button4.Size = New System.Drawing.Size(38, 39)
		Me.guna2Button4.TabIndex = 3
		Me.guna2Button4.Text = "-"
		AddHandler Me.guna2Button4.Click, AddressOf Me.Guna2Button4Click
		'
		'guna2Button3
		'
		Me.guna2Button3.BackColor = System.Drawing.Color.Transparent
		Me.guna2Button3.CheckedState.Parent = Me.guna2Button3
		Me.guna2Button3.CustomImages.Parent = Me.guna2Button3
		Me.guna2Button3.Dock = System.Windows.Forms.DockStyle.Right
		Me.guna2Button3.FillColor = System.Drawing.Color.Transparent
		Me.guna2Button3.Font = New System.Drawing.Font("Segoe UI Black", 14.25!)
		Me.guna2Button3.ForeColor = System.Drawing.Color.White
		Me.guna2Button3.HoverState.Parent = Me.guna2Button3
		Me.guna2Button3.Location = New System.Drawing.Point(635, 0)
		Me.guna2Button3.Name = "guna2Button3"
		Me.guna2Button3.ShadowDecoration.Parent = Me.guna2Button3
		Me.guna2Button3.Size = New System.Drawing.Size(38, 39)
		Me.guna2Button3.TabIndex = 2
		Me.guna2Button3.Text = "X"
		AddHandler Me.guna2Button3.Click, AddressOf Me.Guna2Button3Click
		'
		'guna2ComboBox1
		'
		Me.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
		Me.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
		Me.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.guna2ComboBox1.FillColor = System.Drawing.Color.Black
		Me.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty
		Me.guna2ComboBox1.FocusedState.Parent = Me.guna2ComboBox1
		Me.guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.guna2ComboBox1.ForeColor = System.Drawing.Color.White
		Me.guna2ComboBox1.FormattingEnabled = true
		Me.guna2ComboBox1.HoverState.Parent = Me.guna2ComboBox1
		Me.guna2ComboBox1.ItemHeight = 30
		Me.guna2ComboBox1.ItemsAppearance.Parent = Me.guna2ComboBox1
		Me.guna2ComboBox1.Location = New System.Drawing.Point(307, 49)
		Me.guna2ComboBox1.Name = "guna2ComboBox1"
		Me.guna2ComboBox1.ShadowDecoration.Parent = Me.guna2ComboBox1
		Me.guna2ComboBox1.Size = New System.Drawing.Size(116, 36)
		Me.guna2ComboBox1.TabIndex = 9
		AddHandler Me.guna2ComboBox1.SelectedIndexChanged, AddressOf Me.Guna2ComboBox1SelectedIndexChanged
		'
		'label1
		'
		Me.label1.BackColor = System.Drawing.Color.Transparent
		Me.label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.label1.Location = New System.Drawing.Point(4, 59)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(282, 26)
		Me.label1.TabIndex = 8
		Me.label1.Text = "Posibles ejecutables infectados:"
		'
		'guna2TextBox1
		'
		Me.guna2TextBox1.BackColor = System.Drawing.Color.White
		Me.guna2TextBox1.BorderColor = System.Drawing.Color.Transparent
		Me.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.guna2TextBox1.DefaultText = ""
		Me.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(208,Byte),Integer))
		Me.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226,Byte),Integer), CType(CType(226,Byte),Integer), CType(CType(226,Byte),Integer))
		Me.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer))
		Me.guna2TextBox1.DisabledState.Parent = Me.guna2TextBox1
		Me.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer), CType(CType(138,Byte),Integer))
		Me.guna2TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.guna2TextBox1.FillColor = System.Drawing.Color.Black
		Me.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.guna2TextBox1.FocusedState.Parent = Me.guna2TextBox1
		Me.guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.guna2TextBox1.ForeColor = System.Drawing.Color.White
		Me.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(148,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.guna2TextBox1.HoverState.Parent = Me.guna2TextBox1
		Me.guna2TextBox1.Location = New System.Drawing.Point(0, 94)
		Me.guna2TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.guna2TextBox1.Multiline = true
		Me.guna2TextBox1.Name = "guna2TextBox1"
		Me.guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.guna2TextBox1.PlaceholderText = ""
		Me.guna2TextBox1.ReadOnly = true
		Me.guna2TextBox1.SelectedText = ""
		Me.guna2TextBox1.ShadowDecoration.Parent = Me.guna2TextBox1
		Me.guna2TextBox1.Size = New System.Drawing.Size(673, 379)
		Me.guna2TextBox1.TabIndex = 7
		'
		'guna2Button2
		'
		Me.guna2Button2.CheckedState.Parent = Me.guna2Button2
		Me.guna2Button2.CustomImages.Parent = Me.guna2Button2
		Me.guna2Button2.FillColor = System.Drawing.Color.Teal
		Me.guna2Button2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.guna2Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.guna2Button2.HoverState.Parent = Me.guna2Button2
		Me.guna2Button2.Location = New System.Drawing.Point(565, 49)
		Me.guna2Button2.Name = "guna2Button2"
		Me.guna2Button2.ShadowDecoration.Parent = Me.guna2Button2
		Me.guna2Button2.Size = New System.Drawing.Size(99, 36)
		Me.guna2Button2.TabIndex = 6
		Me.guna2Button2.Text = "Verificar"
		AddHandler Me.guna2Button2.Click, AddressOf Me.Guna2Button2Click
		'
		'guna2Button1
		'
		Me.guna2Button1.CheckedState.Parent = Me.guna2Button1
		Me.guna2Button1.CustomImages.Parent = Me.guna2Button1
		Me.guna2Button1.FillColor = System.Drawing.Color.Teal
		Me.guna2Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.guna2Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
		Me.guna2Button1.HoverState.Parent = Me.guna2Button1
		Me.guna2Button1.Location = New System.Drawing.Point(441, 49)
		Me.guna2Button1.Name = "guna2Button1"
		Me.guna2Button1.ShadowDecoration.Parent = Me.guna2Button1
		Me.guna2Button1.Size = New System.Drawing.Size(116, 36)
		Me.guna2Button1.TabIndex = 5
		Me.guna2Button1.Text = "Recopilar datos"
		AddHandler Me.guna2Button1.Click, AddressOf Me.Guna2Button1Click
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(673, 497)
		Me.Controls.Add(Me.guna2Panel1)
		Me.Controls.Add(Me.statusStrip1)
		Me.DoubleBuffered = true
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MaximizeBox = false
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Protectom"
		Me.statusStrip1.ResumeLayout(false)
		Me.statusStrip1.PerformLayout
		Me.guna2Panel1.ResumeLayout(false)
		Me.panel1.ResumeLayout(false)
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label2 As System.Windows.Forms.Label
	Private guna2Button4 As Guna.UI2.WinForms.Guna2Button
	Private guna2Button3 As Guna.UI2.WinForms.Guna2Button
	Private panel1 As System.Windows.Forms.Panel
	Private guna2Button1 As Guna.UI2.WinForms.Guna2Button
	Private guna2Button2 As Guna.UI2.WinForms.Guna2Button
	Private guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
	Private label1 As System.Windows.Forms.Label
	Private guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
	Private guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
	Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	

End Class
