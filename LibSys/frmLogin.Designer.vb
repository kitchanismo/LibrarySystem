<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.pnheader = New System.Windows.Forms.Panel()
        Me.SlcClose1 = New LibSys.SLCClose()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbuname = New System.Windows.Forms.TextBox()
        Me.tbpword = New System.Windows.Forms.TextBox()
        Me.lbluname = New gLabel.gLabel()
        Me.lblpword = New gLabel.gLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GhostButton2 = New LibSys.GhostButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OrangeSeperator2 = New LibSys.OrangeSeperator()
        Me.pnheader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnheader
        '
        Me.pnheader.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.pnheader.Controls.Add(Me.SlcClose1)
        Me.pnheader.Controls.Add(Me.Label1)
        Me.pnheader.Location = New System.Drawing.Point(0, -1)
        Me.pnheader.Name = "pnheader"
        Me.pnheader.Size = New System.Drawing.Size(519, 35)
        Me.pnheader.TabIndex = 1
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New LibSys.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(456, 9)
        Me.SlcClose1.Name = "SlcClose1"
        Me.SlcClose1.NoRounding = False
        Me.SlcClose1.Size = New System.Drawing.Size(20, 20)
        Me.SlcClose1.TabIndex = 1
        Me.SlcClose1.Text = "SlcClose1"
        Me.ToolTip1.SetToolTip(Me.SlcClose1, "Close")
        Me.SlcClose1.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'tbuname
        '
        Me.tbuname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbuname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbuname.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbuname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbuname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbuname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbuname.Location = New System.Drawing.Point(271, 87)
        Me.tbuname.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbuname.MaxLength = 30
        Me.tbuname.Name = "tbuname"
        Me.tbuname.Size = New System.Drawing.Size(189, 27)
        Me.tbuname.TabIndex = 2
        '
        'tbpword
        '
        Me.tbpword.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbpword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbpword.Location = New System.Drawing.Point(271, 147)
        Me.tbpword.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbpword.MaxLength = 30
        Me.tbpword.Name = "tbpword"
        Me.tbpword.Size = New System.Drawing.Size(189, 27)
        Me.tbpword.TabIndex = 3
        Me.tbpword.UseSystemPasswordChar = True
        '
        'lbluname
        '
        Me.lbluname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluname.ForeColor = System.Drawing.Color.White
        Me.lbluname.Glow = 6
        Me.lbluname.GlowColor = System.Drawing.Color.DarkOrange
        Me.lbluname.GlowState = False
        Me.lbluname.Location = New System.Drawing.Point(269, 63)
        Me.lbluname.Name = "lbluname"
        Me.lbluname.Size = New System.Drawing.Size(84, 21)
        Me.lbluname.TabIndex = 4
        Me.lbluname.Text = "USERNAME"
        Me.lbluname.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblpword
        '
        Me.lblpword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpword.ForeColor = System.Drawing.Color.White
        Me.lblpword.Glow = 6
        Me.lblpword.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblpword.GlowState = False
        Me.lblpword.Location = New System.Drawing.Point(268, 123)
        Me.lblpword.Name = "lblpword"
        Me.lblpword.Size = New System.Drawing.Size(84, 21)
        Me.lblpword.TabIndex = 5
        Me.lblpword.Text = "PASSWORD"
        Me.lblpword.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(13, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 197)
        Me.Panel1.TabIndex = 8
        '
        'GhostButton2
        '
        Me.GhostButton2.Color = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GhostButton2.Colors = New LibSys.Bloom(-1) {}
        Me.GhostButton2.Customization = ""
        Me.GhostButton2.EnableGlass = True
        Me.GhostButton2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GhostButton2.Image = Nothing
        Me.GhostButton2.Location = New System.Drawing.Point(410, 203)
        Me.GhostButton2.Name = "GhostButton2"
        Me.GhostButton2.NoRounding = False
        Me.GhostButton2.Size = New System.Drawing.Size(50, 32)
        Me.GhostButton2.TabIndex = 6
        Me.GhostButton2.Text = "GO"
        Me.GhostButton2.Transparent = False
        '
        'OrangeSeperator2
        '
        Me.OrangeSeperator2.Alignment = LibSys.OrangeSeperator.Style.Verticle
        Me.OrangeSeperator2.BackColor = System.Drawing.Color.Transparent
        Me.OrangeSeperator2.Location = New System.Drawing.Point(242, 59)
        Me.OrangeSeperator2.Name = "OrangeSeperator2"
        Me.OrangeSeperator2.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.OrangeSeperator2.Size = New System.Drawing.Size(12, 172)
        Me.OrangeSeperator2.TabIndex = 10
        Me.OrangeSeperator2.Text = "OrangeSeperator2"
        Me.OrangeSeperator2.Thickness = 1.0!
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(482, 258)
        Me.Controls.Add(Me.OrangeSeperator2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GhostButton2)
        Me.Controls.Add(Me.lblpword)
        Me.Controls.Add(Me.lbluname)
        Me.Controls.Add(Me.tbpword)
        Me.Controls.Add(Me.tbuname)
        Me.Controls.Add(Me.pnheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.pnheader.ResumeLayout(False)
        Me.pnheader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnheader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbuname As System.Windows.Forms.TextBox
    Friend WithEvents tbpword As System.Windows.Forms.TextBox
    Friend WithEvents lbluname As gLabel.gLabel
    Friend WithEvents lblpword As gLabel.gLabel
    Friend WithEvents GhostButton2 As LibSys.GhostButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SlcClose1 As LibSys.SLCClose
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OrangeSeperator2 As LibSys.OrangeSeperator
End Class
