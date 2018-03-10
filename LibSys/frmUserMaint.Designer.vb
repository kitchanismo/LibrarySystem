<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserMaint
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
        Me.btnsearch = New LibSys.GhostButton()
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.lv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblpwordx = New System.Windows.Forms.Label()
        Me.lblpword = New gLabel.gLabel()
        Me.tbpword = New System.Windows.Forms.TextBox()
        Me.lblcpword = New gLabel.gLabel()
        Me.tbcpword = New System.Windows.Forms.TextBox()
        Me.lbladdr = New gLabel.gLabel()
        Me.tbaddr = New System.Windows.Forms.TextBox()
        Me.lblcont = New gLabel.gLabel()
        Me.tbcont = New System.Windows.Forms.TextBox()
        Me.lbllname = New gLabel.gLabel()
        Me.tblname = New System.Windows.Forms.TextBox()
        Me.lblfname = New gLabel.gLabel()
        Me.tbfname = New System.Windows.Forms.TextBox()
        Me.cboutype = New System.Windows.Forms.ComboBox()
        Me.btntype = New LibSys.GhostButton()
        Me.lblutype = New gLabel.gLabel()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.lbluid = New System.Windows.Forms.Label()
        Me.lbluname = New gLabel.gLabel()
        Me.tbuname = New System.Windows.Forms.TextBox()
        Me.lblidx = New gLabel.gLabel()
        Me.btnedit = New LibSys.GhostButton()
        Me.btndelete = New LibSys.GhostButton()
        Me.btnclear = New LibSys.GhostButton()
        Me.btnrefresh = New LibSys.GhostButton()
        Me.btnadd = New LibSys.GhostButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.groupbook = New LibSys.OrangeGroupBox()
        Me.pnheader.SuspendLayout()
        Me.groupbook.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnheader
        '
        Me.pnheader.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.pnheader.Controls.Add(Me.SlcClose1)
        Me.pnheader.Controls.Add(Me.Label1)
        Me.pnheader.Location = New System.Drawing.Point(0, 0)
        Me.pnheader.Name = "pnheader"
        Me.pnheader.Size = New System.Drawing.Size(780, 35)
        Me.pnheader.TabIndex = 1
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New LibSys.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(750, 8)
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
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Maintenance"
        '
        'btnsearch
        '
        Me.btnsearch.Color = System.Drawing.Color.Empty
        Me.btnsearch.Colors = New LibSys.Bloom(-1) {}
        Me.btnsearch.Customization = ""
        Me.btnsearch.EnableGlass = True
        Me.btnsearch.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnsearch.Image = Nothing
        Me.btnsearch.Location = New System.Drawing.Point(443, 45)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.NoRounding = False
        Me.btnsearch.Size = New System.Drawing.Size(32, 25)
        Me.btnsearch.TabIndex = 24
        Me.btnsearch.Text = "Q"
        Me.btnsearch.Transparent = False
        '
        'tbsearch
        '
        Me.tbsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbsearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbsearch.Location = New System.Drawing.Point(9, 44)
        Me.tbsearch.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbsearch.MaxLength = 30
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(466, 27)
        Me.tbsearch.TabIndex = 23
        Me.tbsearch.Text = " Search ..."
        '
        'lv
        '
        Me.lv.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv.ForeColor = System.Drawing.Color.Gainsboro
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.Location = New System.Drawing.Point(9, 76)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(466, 389)
        Me.lv.TabIndex = 22
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "UserID"
        Me.ColumnHeader1.Width = 76
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Username"
        Me.ColumnHeader2.Width = 109
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Firstname"
        Me.ColumnHeader3.Width = 104
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Lastname"
        Me.ColumnHeader4.Width = 112
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "User Type"
        Me.ColumnHeader5.Width = 106
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Contact No"
        Me.ColumnHeader6.Width = 124
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Address"
        Me.ColumnHeader7.Width = 175
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Password"
        Me.ColumnHeader8.Width = 0
        '
        'lblpwordx
        '
        Me.lblpwordx.AutoSize = True
        Me.lblpwordx.BackColor = System.Drawing.Color.Transparent
        Me.lblpwordx.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpwordx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblpwordx.Location = New System.Drawing.Point(123, 88)
        Me.lblpwordx.Name = "lblpwordx"
        Me.lblpwordx.Size = New System.Drawing.Size(17, 17)
        Me.lblpwordx.TabIndex = 47
        Me.lblpwordx.Text = "..."
        Me.lblpwordx.Visible = False
        '
        'lblpword
        '
        Me.lblpword.BackColor = System.Drawing.Color.Transparent
        Me.lblpword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpword.ForeColor = System.Drawing.Color.White
        Me.lblpword.Glow = 6
        Me.lblpword.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblpword.GlowState = False
        Me.lblpword.Location = New System.Drawing.Point(9, 348)
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
        Me.tbpword.Location = New System.Drawing.Point(11, 372)
        Me.tbpword.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbpword.MaxLength = 30
        Me.tbpword.Name = "tbpword"
        Me.tbpword.Size = New System.Drawing.Size(260, 25)
        Me.tbpword.TabIndex = 45
        Me.tbpword.UseSystemPasswordChar = True
        '
        'lblcpword
        '
        Me.lblcpword.BackColor = System.Drawing.Color.Transparent
        Me.lblcpword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcpword.ForeColor = System.Drawing.Color.White
        Me.lblcpword.Glow = 6
        Me.lblcpword.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblcpword.GlowState = False
        Me.lblcpword.Location = New System.Drawing.Point(8, 400)
        Me.lblcpword.Name = "lblcpword"
        Me.lblcpword.Size = New System.Drawing.Size(126, 21)
        Me.lblcpword.TabIndex = 44
        Me.lblcpword.Text = "Confirm Password"
        Me.lblcpword.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblcpword.Visible = False
        '
        'tbcpword
        '
        Me.tbcpword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbcpword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbcpword.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbcpword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbcpword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcpword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbcpword.Location = New System.Drawing.Point(10, 424)
        Me.tbcpword.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbcpword.MaxLength = 30
        Me.tbcpword.Name = "tbcpword"
        Me.tbcpword.Size = New System.Drawing.Size(260, 25)
        Me.tbcpword.TabIndex = 43
        Me.tbcpword.UseSystemPasswordChar = True
        Me.tbcpword.Visible = False
        '
        'lbladdr
        '
        Me.lbladdr.BackColor = System.Drawing.Color.Transparent
        Me.lbladdr.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdr.ForeColor = System.Drawing.Color.White
        Me.lbladdr.Glow = 6
        Me.lbladdr.GlowColor = System.Drawing.Color.DarkOrange
        Me.lbladdr.GlowState = False
        Me.lbladdr.Location = New System.Drawing.Point(8, 296)
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
        Me.tbaddr.Location = New System.Drawing.Point(11, 320)
        Me.tbaddr.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbaddr.MaxLength = 30
        Me.tbaddr.Name = "tbaddr"
        Me.tbaddr.Size = New System.Drawing.Size(260, 25)
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
        Me.lblcont.Location = New System.Drawing.Point(8, 244)
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
        Me.tbcont.Location = New System.Drawing.Point(11, 268)
        Me.tbcont.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbcont.MaxLength = 30
        Me.tbcont.Name = "tbcont"
        Me.tbcont.Size = New System.Drawing.Size(109, 25)
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
        Me.lbllname.Location = New System.Drawing.Point(9, 192)
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
        Me.tblname.Location = New System.Drawing.Point(12, 216)
        Me.tblname.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tblname.MaxLength = 30
        Me.tblname.Name = "tblname"
        Me.tblname.Size = New System.Drawing.Size(260, 25)
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
        Me.lblfname.Location = New System.Drawing.Point(9, 140)
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
        Me.tbfname.Location = New System.Drawing.Point(12, 164)
        Me.tbfname.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbfname.MaxLength = 30
        Me.tbfname.Name = "tbfname"
        Me.tbfname.Size = New System.Drawing.Size(260, 25)
        Me.tbfname.TabIndex = 35
        '
        'cboutype
        '
        Me.cboutype.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cboutype.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboutype.ForeColor = System.Drawing.Color.Silver
        Me.cboutype.FormattingEnabled = True
        Me.cboutype.Items.AddRange(New Object() {"Librarian", "Student", "Faculty"})
        Me.cboutype.Location = New System.Drawing.Point(126, 268)
        Me.cboutype.Name = "cboutype"
        Me.cboutype.Size = New System.Drawing.Size(103, 28)
        Me.cboutype.TabIndex = 32
        Me.cboutype.Text = " ..."
        '
        'btntype
        '
        Me.btntype.Color = System.Drawing.Color.Empty
        Me.btntype.Colors = New LibSys.Bloom(-1) {}
        Me.btntype.Customization = ""
        Me.btntype.EnableGlass = True
        Me.btntype.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btntype.Image = Nothing
        Me.btntype.Location = New System.Drawing.Point(235, 267)
        Me.btntype.Name = "btntype"
        Me.btntype.NoRounding = False
        Me.btntype.Size = New System.Drawing.Size(37, 26)
        Me.btntype.TabIndex = 31
        Me.btntype.Text = "..."
        Me.btntype.Transparent = False
        '
        'lblutype
        '
        Me.lblutype.BackColor = System.Drawing.Color.Transparent
        Me.lblutype.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblutype.ForeColor = System.Drawing.Color.White
        Me.lblutype.Glow = 6
        Me.lblutype.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblutype.GlowState = False
        Me.lblutype.Location = New System.Drawing.Point(122, 244)
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
        Me.lblresult.Location = New System.Drawing.Point(176, 73)
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
        Me.lbluid.Location = New System.Drawing.Point(9, 59)
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
        Me.lbluname.Location = New System.Drawing.Point(9, 88)
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
        Me.tbuname.Location = New System.Drawing.Point(12, 112)
        Me.tbuname.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbuname.MaxLength = 30
        Me.tbuname.Name = "tbuname"
        Me.tbuname.Size = New System.Drawing.Size(260, 25)
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
        Me.lblidx.Location = New System.Drawing.Point(9, 34)
        Me.lblidx.Name = "lblidx"
        Me.lblidx.Size = New System.Drawing.Size(91, 21)
        Me.lblidx.TabIndex = 10
        Me.lblidx.Text = "User ID"
        Me.lblidx.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'btnedit
        '
        Me.btnedit.Color = System.Drawing.Color.Empty
        Me.btnedit.Colors = New LibSys.Bloom(-1) {}
        Me.btnedit.Customization = ""
        Me.btnedit.EnableGlass = True
        Me.btnedit.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnedit.Image = Nothing
        Me.btnedit.Location = New System.Drawing.Point(104, 472)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.NoRounding = False
        Me.btnedit.Size = New System.Drawing.Size(83, 32)
        Me.btnedit.TabIndex = 29
        Me.btnedit.Text = "Update"
        Me.btnedit.Transparent = False
        '
        'btndelete
        '
        Me.btndelete.Color = System.Drawing.Color.Empty
        Me.btndelete.Colors = New LibSys.Bloom(-1) {}
        Me.btndelete.Customization = ""
        Me.btndelete.EnableGlass = True
        Me.btndelete.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btndelete.Image = Nothing
        Me.btndelete.Location = New System.Drawing.Point(200, 472)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.NoRounding = False
        Me.btndelete.Size = New System.Drawing.Size(83, 32)
        Me.btndelete.TabIndex = 28
        Me.btndelete.Text = "Delete"
        Me.btndelete.Transparent = False
        '
        'btnclear
        '
        Me.btnclear.Color = System.Drawing.Color.Empty
        Me.btnclear.Colors = New LibSys.Bloom(-1) {}
        Me.btnclear.Customization = ""
        Me.btnclear.EnableGlass = True
        Me.btnclear.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnclear.Image = Nothing
        Me.btnclear.Location = New System.Drawing.Point(296, 472)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.NoRounding = False
        Me.btnclear.Size = New System.Drawing.Size(83, 32)
        Me.btnclear.TabIndex = 27
        Me.btnclear.Text = "Clear"
        Me.btnclear.Transparent = False
        '
        'btnrefresh
        '
        Me.btnrefresh.Color = System.Drawing.Color.Empty
        Me.btnrefresh.Colors = New LibSys.Bloom(-1) {}
        Me.btnrefresh.Customization = ""
        Me.btnrefresh.EnableGlass = True
        Me.btnrefresh.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnrefresh.Image = Nothing
        Me.btnrefresh.Location = New System.Drawing.Point(392, 472)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.NoRounding = False
        Me.btnrefresh.Size = New System.Drawing.Size(83, 32)
        Me.btnrefresh.TabIndex = 26
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.Transparent = False
        '
        'btnadd
        '
        Me.btnadd.Color = System.Drawing.Color.Empty
        Me.btnadd.Colors = New LibSys.Bloom(-1) {}
        Me.btnadd.Customization = ""
        Me.btnadd.EnableGlass = True
        Me.btnadd.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnadd.Image = Nothing
        Me.btnadd.Location = New System.Drawing.Point(9, 472)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.NoRounding = False
        Me.btnadd.Size = New System.Drawing.Size(83, 32)
        Me.btnadd.TabIndex = 25
        Me.btnadd.Text = "Add"
        Me.btnadd.Transparent = False
        '
        'groupbook
        '
        Me.groupbook.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.groupbook.Controls.Add(Me.lblpwordx)
        Me.groupbook.Controls.Add(Me.lblutype)
        Me.groupbook.Controls.Add(Me.lblpword)
        Me.groupbook.Controls.Add(Me.lblidx)
        Me.groupbook.Controls.Add(Me.tbpword)
        Me.groupbook.Controls.Add(Me.tbuname)
        Me.groupbook.Controls.Add(Me.lblcpword)
        Me.groupbook.Controls.Add(Me.lbluname)
        Me.groupbook.Controls.Add(Me.tbcpword)
        Me.groupbook.Controls.Add(Me.lbluid)
        Me.groupbook.Controls.Add(Me.lbladdr)
        Me.groupbook.Controls.Add(Me.lblresult)
        Me.groupbook.Controls.Add(Me.tbaddr)
        Me.groupbook.Controls.Add(Me.btntype)
        Me.groupbook.Controls.Add(Me.lblcont)
        Me.groupbook.Controls.Add(Me.cboutype)
        Me.groupbook.Controls.Add(Me.tbcont)
        Me.groupbook.Controls.Add(Me.tbfname)
        Me.groupbook.Controls.Add(Me.lbllname)
        Me.groupbook.Controls.Add(Me.lblfname)
        Me.groupbook.Controls.Add(Me.tblname)
        Me.groupbook.Enabled = False
        Me.groupbook.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.groupbook.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.groupbook.Location = New System.Drawing.Point(481, 44)
        Me.groupbook.MainColour = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.groupbook.Name = "groupbook"
        Me.groupbook.Size = New System.Drawing.Size(284, 460)
        Me.groupbook.TabIndex = 30
        Me.groupbook.Text = "User Details"
        Me.groupbook.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'frmUserMaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(774, 513)
        Me.Controls.Add(Me.groupbook)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.tbsearch)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.pnheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUserMaint"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUserMaint"
        Me.pnheader.ResumeLayout(False)
        Me.pnheader.PerformLayout()
        Me.groupbook.ResumeLayout(False)
        Me.groupbook.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnheader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsearch As LibSys.GhostButton
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboutype As System.Windows.Forms.ComboBox
    Friend WithEvents btntype As LibSys.GhostButton
    Friend WithEvents lblutype As gLabel.gLabel
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents lbluid As System.Windows.Forms.Label
    Friend WithEvents lbluname As gLabel.gLabel
    Friend WithEvents tbuname As System.Windows.Forms.TextBox
    Friend WithEvents lblidx As gLabel.gLabel
    Friend WithEvents lbllname As gLabel.gLabel
    Friend WithEvents tblname As System.Windows.Forms.TextBox
    Friend WithEvents lblfname As gLabel.gLabel
    Friend WithEvents tbfname As System.Windows.Forms.TextBox
    Friend WithEvents lblpword As gLabel.gLabel
    Friend WithEvents tbpword As System.Windows.Forms.TextBox
    Friend WithEvents lblcpword As gLabel.gLabel
    Friend WithEvents tbcpword As System.Windows.Forms.TextBox
    Friend WithEvents lbladdr As gLabel.gLabel
    Friend WithEvents tbaddr As System.Windows.Forms.TextBox
    Friend WithEvents lblcont As gLabel.gLabel
    Friend WithEvents tbcont As System.Windows.Forms.TextBox
    Friend WithEvents btnedit As LibSys.GhostButton
    Friend WithEvents btndelete As LibSys.GhostButton
    Friend WithEvents btnclear As LibSys.GhostButton
    Friend WithEvents btnrefresh As LibSys.GhostButton
    Friend WithEvents btnadd As LibSys.GhostButton
    Friend WithEvents SlcClose1 As LibSys.SLCClose
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblpwordx As System.Windows.Forms.Label
    Friend WithEvents groupbook As LibSys.OrangeGroupBox
End Class
