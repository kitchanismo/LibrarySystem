<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountSet
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
        Me.pnheader = New System.Windows.Forms.Panel()
        Me.SlcClose1 = New LibSys.SLCClose()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GhostButton2 = New LibSys.GhostButton()
        Me.btncancel = New LibSys.GhostButton()
        Me.btnsave = New LibSys.GhostButton()
        Me.lblpword = New gLabel.gLabel()
        Me.tbpword = New System.Windows.Forms.TextBox()
        Me.lbladdr = New gLabel.gLabel()
        Me.tbaddr = New System.Windows.Forms.TextBox()
        Me.lblcont = New gLabel.gLabel()
        Me.tbcont = New System.Windows.Forms.TextBox()
        Me.lbllname = New gLabel.gLabel()
        Me.tblname = New System.Windows.Forms.TextBox()
        Me.lblfname = New gLabel.gLabel()
        Me.tbfname = New System.Windows.Forms.TextBox()
        Me.cboutype = New System.Windows.Forms.ComboBox()
        Me.lblutype = New gLabel.gLabel()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.lbluid = New System.Windows.Forms.Label()
        Me.lbluname = New gLabel.gLabel()
        Me.tbuname = New System.Windows.Forms.TextBox()
        Me.lblidx = New gLabel.gLabel()
        Me.OrangeGroupBox1 = New LibSys.OrangeGroupBox()
        Me.OrangeSeperator1 = New LibSys.OrangeSeperator()
        Me.OrangeSeperator3 = New LibSys.OrangeSeperator()
        Me.pnheader.SuspendLayout()
        Me.OrangeGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnheader
        '
        Me.pnheader.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.pnheader.Controls.Add(Me.SlcClose1)
        Me.pnheader.Controls.Add(Me.Label1)
        Me.pnheader.Location = New System.Drawing.Point(0, 0)
        Me.pnheader.Name = "pnheader"
        Me.pnheader.Size = New System.Drawing.Size(515, 35)
        Me.pnheader.TabIndex = 2
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New LibSys.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(476, 8)
        Me.SlcClose1.Name = "SlcClose1"
        Me.SlcClose1.NoRounding = False
        Me.SlcClose1.Size = New System.Drawing.Size(20, 20)
        Me.SlcClose1.TabIndex = 3
        Me.SlcClose1.Text = "SlcClose1"
        Me.ToolTip1.SetToolTip(Me.SlcClose1, "Close")
        Me.SlcClose1.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Settings"
        '
        'GhostButton2
        '
        Me.GhostButton2.Color = System.Drawing.Color.Empty
        Me.GhostButton2.Colors = New LibSys.Bloom(-1) {}
        Me.GhostButton2.Customization = ""
        Me.GhostButton2.EnableGlass = True
        Me.GhostButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostButton2.Image = Nothing
        Me.GhostButton2.Location = New System.Drawing.Point(426, 217)
        Me.GhostButton2.Name = "GhostButton2"
        Me.GhostButton2.NoRounding = False
        Me.GhostButton2.Size = New System.Drawing.Size(37, 26)
        Me.GhostButton2.TabIndex = 49
        Me.GhostButton2.Text = "..."
        Me.ToolTip1.SetToolTip(Me.GhostButton2, "Change password ...")
        Me.GhostButton2.Transparent = False
        '
        'btncancel
        '
        Me.btncancel.Color = System.Drawing.Color.Empty
        Me.btncancel.Colors = New LibSys.Bloom(-1) {}
        Me.btncancel.Customization = ""
        Me.btncancel.EnableGlass = True
        Me.btncancel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btncancel.Image = Nothing
        Me.btncancel.Location = New System.Drawing.Point(365, 270)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.NoRounding = False
        Me.btncancel.Size = New System.Drawing.Size(83, 32)
        Me.btncancel.TabIndex = 48
        Me.btncancel.Text = "Cancel"
        Me.btncancel.Transparent = False
        '
        'btnsave
        '
        Me.btnsave.Color = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsave.Colors = New LibSys.Bloom(-1) {}
        Me.btnsave.Customization = ""
        Me.btnsave.EnableGlass = True
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnsave.Image = Nothing
        Me.btnsave.Location = New System.Drawing.Point(272, 270)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.NoRounding = False
        Me.btnsave.Size = New System.Drawing.Size(83, 32)
        Me.btnsave.TabIndex = 47
        Me.btnsave.Text = "Save"
        Me.btnsave.Transparent = False
        '
        'lblpword
        '
        Me.lblpword.BackColor = System.Drawing.Color.Transparent
        Me.lblpword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpword.ForeColor = System.Drawing.Color.White
        Me.lblpword.Glow = 6
        Me.lblpword.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblpword.GlowState = False
        Me.lblpword.Location = New System.Drawing.Point(244, 194)
        Me.lblpword.Name = "lblpword"
        Me.lblpword.Size = New System.Drawing.Size(91, 21)
        Me.lblpword.TabIndex = 46
        Me.lblpword.Text = "Password"
        Me.lblpword.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'tbpword
        '
        Me.tbpword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbpword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbpword.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbpword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbpword.Location = New System.Drawing.Point(246, 218)
        Me.tbpword.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbpword.MaxLength = 30
        Me.tbpword.Name = "tbpword"
        Me.tbpword.Size = New System.Drawing.Size(171, 25)
        Me.tbpword.TabIndex = 45
        Me.tbpword.UseSystemPasswordChar = True
        '
        'lbladdr
        '
        Me.lbladdr.BackColor = System.Drawing.Color.Transparent
        Me.lbladdr.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdr.ForeColor = System.Drawing.Color.White
        Me.lbladdr.Glow = 6
        Me.lbladdr.GlowColor = System.Drawing.Color.DarkOrange
        Me.lbladdr.GlowState = False
        Me.lbladdr.Location = New System.Drawing.Point(244, 90)
        Me.lbladdr.Name = "lbladdr"
        Me.lbladdr.Size = New System.Drawing.Size(91, 21)
        Me.lbladdr.TabIndex = 42
        Me.lbladdr.Text = "Address"
        Me.lbladdr.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'tbaddr
        '
        Me.tbaddr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbaddr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbaddr.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbaddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbaddr.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbaddr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbaddr.Location = New System.Drawing.Point(247, 114)
        Me.tbaddr.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbaddr.MaxLength = 30
        Me.tbaddr.Multiline = True
        Me.tbaddr.Name = "tbaddr"
        Me.tbaddr.Size = New System.Drawing.Size(216, 77)
        Me.tbaddr.TabIndex = 41
        '
        'lblcont
        '
        Me.lblcont.BackColor = System.Drawing.Color.Transparent
        Me.lblcont.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcont.ForeColor = System.Drawing.Color.White
        Me.lblcont.Glow = 6
        Me.lblcont.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblcont.GlowState = False
        Me.lblcont.Location = New System.Drawing.Point(243, 36)
        Me.lblcont.Name = "lblcont"
        Me.lblcont.Size = New System.Drawing.Size(91, 21)
        Me.lblcont.TabIndex = 40
        Me.lblcont.Text = "Contact No."
        Me.lblcont.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'tbcont
        '
        Me.tbcont.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbcont.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbcont.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbcont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbcont.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcont.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbcont.Location = New System.Drawing.Point(246, 59)
        Me.tbcont.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbcont.MaxLength = 30
        Me.tbcont.Name = "tbcont"
        Me.tbcont.Size = New System.Drawing.Size(217, 25)
        Me.tbcont.TabIndex = 39
        '
        'lbllname
        '
        Me.lbllname.BackColor = System.Drawing.Color.Transparent
        Me.lbllname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllname.ForeColor = System.Drawing.Color.White
        Me.lbllname.Glow = 6
        Me.lbllname.GlowColor = System.Drawing.Color.DarkOrange
        Me.lbllname.GlowState = False
        Me.lbllname.Location = New System.Drawing.Point(10, 194)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(91, 21)
        Me.lbllname.TabIndex = 38
        Me.lbllname.Text = "Last Name"
        Me.lbllname.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'tblname
        '
        Me.tblname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tblname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tblname.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tblname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tblname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tblname.Location = New System.Drawing.Point(13, 218)
        Me.tblname.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tblname.MaxLength = 30
        Me.tblname.Name = "tblname"
        Me.tblname.Size = New System.Drawing.Size(179, 25)
        Me.tblname.TabIndex = 37
        '
        'lblfname
        '
        Me.lblfname.BackColor = System.Drawing.Color.Transparent
        Me.lblfname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.ForeColor = System.Drawing.Color.White
        Me.lblfname.Glow = 6
        Me.lblfname.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblfname.GlowState = False
        Me.lblfname.Location = New System.Drawing.Point(10, 142)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(91, 21)
        Me.lblfname.TabIndex = 36
        Me.lblfname.Text = "First Name"
        Me.lblfname.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'tbfname
        '
        Me.tbfname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbfname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbfname.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbfname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbfname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbfname.Location = New System.Drawing.Point(13, 166)
        Me.tbfname.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbfname.MaxLength = 30
        Me.tbfname.Name = "tbfname"
        Me.tbfname.Size = New System.Drawing.Size(179, 25)
        Me.tbfname.TabIndex = 35
        '
        'cboutype
        '
        Me.cboutype.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cboutype.Enabled = False
        Me.cboutype.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboutype.ForeColor = System.Drawing.Color.Silver
        Me.cboutype.FormattingEnabled = True
        Me.cboutype.Items.AddRange(New Object() {"Student", "Faculty"})
        Me.cboutype.Location = New System.Drawing.Point(14, 270)
        Me.cboutype.Name = "cboutype"
        Me.cboutype.Size = New System.Drawing.Size(178, 28)
        Me.cboutype.TabIndex = 32
        Me.cboutype.Text = " ..."
        '
        'lblutype
        '
        Me.lblutype.BackColor = System.Drawing.Color.Transparent
        Me.lblutype.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblutype.ForeColor = System.Drawing.Color.White
        Me.lblutype.Glow = 6
        Me.lblutype.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblutype.GlowState = False
        Me.lblutype.Location = New System.Drawing.Point(10, 246)
        Me.lblutype.Name = "lblutype"
        Me.lblutype.Size = New System.Drawing.Size(80, 21)
        Me.lblutype.TabIndex = 30
        Me.lblutype.Text = "User Type"
        Me.lblutype.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.BackColor = System.Drawing.Color.Transparent
        Me.lblresult.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult.ForeColor = System.Drawing.Color.Silver
        Me.lblresult.Location = New System.Drawing.Point(175, 23)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(0, 17)
        Me.lblresult.TabIndex = 29
        Me.lblresult.Visible = False
        '
        'lbluid
        '
        Me.lbluid.AutoSize = True
        Me.lbluid.BackColor = System.Drawing.Color.Transparent
        Me.lbluid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbluid.Location = New System.Drawing.Point(10, 61)
        Me.lbluid.Name = "lbluid"
        Me.lbluid.Size = New System.Drawing.Size(17, 17)
        Me.lbluid.TabIndex = 23
        Me.lbluid.Text = "..."
        '
        'lbluname
        '
        Me.lbluname.BackColor = System.Drawing.Color.Transparent
        Me.lbluname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluname.ForeColor = System.Drawing.Color.White
        Me.lbluname.Glow = 6
        Me.lbluname.GlowColor = System.Drawing.Color.DarkOrange
        Me.lbluname.GlowState = False
        Me.lbluname.Location = New System.Drawing.Point(10, 90)
        Me.lbluname.Name = "lbluname"
        Me.lbluname.Size = New System.Drawing.Size(91, 21)
        Me.lbluname.TabIndex = 18
        Me.lbluname.Text = "User Name"
        Me.lbluname.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'tbuname
        '
        Me.tbuname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbuname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbuname.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbuname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbuname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbuname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbuname.Location = New System.Drawing.Point(13, 114)
        Me.tbuname.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbuname.MaxLength = 30
        Me.tbuname.Name = "tbuname"
        Me.tbuname.Size = New System.Drawing.Size(179, 25)
        Me.tbuname.TabIndex = 17
        '
        'lblidx
        '
        Me.lblidx.BackColor = System.Drawing.Color.Transparent
        Me.lblidx.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidx.ForeColor = System.Drawing.Color.White
        Me.lblidx.Glow = 6
        Me.lblidx.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblidx.GlowState = False
        Me.lblidx.Location = New System.Drawing.Point(10, 36)
        Me.lblidx.Name = "lblidx"
        Me.lblidx.Size = New System.Drawing.Size(91, 21)
        Me.lblidx.TabIndex = 10
        Me.lblidx.Text = "User ID"
        Me.lblidx.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'OrangeGroupBox1
        '
        Me.OrangeGroupBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.OrangeGroupBox1.Controls.Add(Me.OrangeSeperator1)
        Me.OrangeGroupBox1.Controls.Add(Me.OrangeSeperator3)
        Me.OrangeGroupBox1.Controls.Add(Me.lblidx)
        Me.OrangeGroupBox1.Controls.Add(Me.GhostButton2)
        Me.OrangeGroupBox1.Controls.Add(Me.tbuname)
        Me.OrangeGroupBox1.Controls.Add(Me.btncancel)
        Me.OrangeGroupBox1.Controls.Add(Me.lbluname)
        Me.OrangeGroupBox1.Controls.Add(Me.btnsave)
        Me.OrangeGroupBox1.Controls.Add(Me.lbluid)
        Me.OrangeGroupBox1.Controls.Add(Me.lblpword)
        Me.OrangeGroupBox1.Controls.Add(Me.lblresult)
        Me.OrangeGroupBox1.Controls.Add(Me.tbpword)
        Me.OrangeGroupBox1.Controls.Add(Me.lblutype)
        Me.OrangeGroupBox1.Controls.Add(Me.lbladdr)
        Me.OrangeGroupBox1.Controls.Add(Me.cboutype)
        Me.OrangeGroupBox1.Controls.Add(Me.tbaddr)
        Me.OrangeGroupBox1.Controls.Add(Me.tbfname)
        Me.OrangeGroupBox1.Controls.Add(Me.lblcont)
        Me.OrangeGroupBox1.Controls.Add(Me.lblfname)
        Me.OrangeGroupBox1.Controls.Add(Me.tbcont)
        Me.OrangeGroupBox1.Controls.Add(Me.tblname)
        Me.OrangeGroupBox1.Controls.Add(Me.lbllname)
        Me.OrangeGroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.OrangeGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.OrangeGroupBox1.Location = New System.Drawing.Point(9, 45)
        Me.OrangeGroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.OrangeGroupBox1.Name = "OrangeGroupBox1"
        Me.OrangeGroupBox1.Size = New System.Drawing.Size(480, 315)
        Me.OrangeGroupBox1.TabIndex = 26
        Me.OrangeGroupBox1.Text = "Account Details"
        Me.OrangeGroupBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'OrangeSeperator1
        '
        Me.OrangeSeperator1.Alignment = LibSys.OrangeSeperator.Style.Horizontal
        Me.OrangeSeperator1.BackColor = System.Drawing.Color.Transparent
        Me.OrangeSeperator1.Location = New System.Drawing.Point(258, 253)
        Me.OrangeSeperator1.Name = "OrangeSeperator1"
        Me.OrangeSeperator1.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.OrangeSeperator1.Size = New System.Drawing.Size(194, 10)
        Me.OrangeSeperator1.TabIndex = 72
        Me.OrangeSeperator1.Text = "OrangeSeperator1"
        Me.OrangeSeperator1.Thickness = 1.0!
        '
        'OrangeSeperator3
        '
        Me.OrangeSeperator3.Alignment = LibSys.OrangeSeperator.Style.Verticle
        Me.OrangeSeperator3.BackColor = System.Drawing.Color.Transparent
        Me.OrangeSeperator3.Location = New System.Drawing.Point(214, 49)
        Me.OrangeSeperator3.Name = "OrangeSeperator3"
        Me.OrangeSeperator3.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.OrangeSeperator3.Size = New System.Drawing.Size(12, 248)
        Me.OrangeSeperator3.TabIndex = 71
        Me.OrangeSeperator3.Text = "OrangeSeperator3"
        Me.OrangeSeperator3.Thickness = 1.0!
        '
        'frmAccountSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(499, 372)
        Me.Controls.Add(Me.OrangeGroupBox1)
        Me.Controls.Add(Me.pnheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAccountSet"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAccountSet"
        Me.pnheader.ResumeLayout(False)
        Me.pnheader.PerformLayout()
        Me.OrangeGroupBox1.ResumeLayout(False)
        Me.OrangeGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnheader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblpword As gLabel.gLabel
    Friend WithEvents tbpword As System.Windows.Forms.TextBox
    Friend WithEvents lbladdr As gLabel.gLabel
    Friend WithEvents tbaddr As System.Windows.Forms.TextBox
    Friend WithEvents lblcont As gLabel.gLabel
    Friend WithEvents tbcont As System.Windows.Forms.TextBox
    Friend WithEvents lbllname As gLabel.gLabel
    Friend WithEvents tblname As System.Windows.Forms.TextBox
    Friend WithEvents lblfname As gLabel.gLabel
    Friend WithEvents tbfname As System.Windows.Forms.TextBox
    Friend WithEvents cboutype As System.Windows.Forms.ComboBox
    Friend WithEvents lblutype As gLabel.gLabel
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents lbluid As System.Windows.Forms.Label
    Friend WithEvents lbluname As gLabel.gLabel
    Friend WithEvents tbuname As System.Windows.Forms.TextBox
    Friend WithEvents lblidx As gLabel.gLabel
    Friend WithEvents btncancel As LibSys.GhostButton
    Friend WithEvents btnsave As LibSys.GhostButton
    Friend WithEvents GhostButton2 As LibSys.GhostButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SlcClose1 As LibSys.SLCClose
    Friend WithEvents OrangeGroupBox1 As LibSys.OrangeGroupBox
    Friend WithEvents OrangeSeperator1 As LibSys.OrangeSeperator
    Friend WithEvents OrangeSeperator3 As LibSys.OrangeSeperator
End Class
