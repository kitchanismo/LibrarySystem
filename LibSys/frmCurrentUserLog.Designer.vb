<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurrentUserLog
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OrangeTabControl1 = New LibSys.OrangeTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.OrangeGroupBox1 = New LibSys.OrangeGroupBox()
        Me.lbllog = New System.Windows.Forms.Label()
        Me.GLabel1 = New gLabel.gLabel()
        Me.GLabel5 = New gLabel.gLabel()
        Me.lblidx = New gLabel.gLabel()
        Me.lbletime = New System.Windows.Forms.Label()
        Me.lbltitle = New gLabel.gLabel()
        Me.lbledate = New System.Windows.Forms.Label()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.GhostButton2 = New LibSys.GhostButton()
        Me.GLabel2 = New gLabel.gLabel()
        Me.btnsave = New LibSys.GhostButton()
        Me.tbbag = New System.Windows.Forms.TextBox()
        Me.lbl2uid = New System.Windows.Forms.Label()
        Me.GLabel3 = New gLabel.gLabel()
        Me.lbluname = New System.Windows.Forms.Label()
        Me.GhostButton1 = New LibSys.GhostButton()
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.lv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.OrangeGroupBox2 = New LibSys.OrangeGroupBox()
        Me.OrangeSeperator3 = New LibSys.OrangeSeperator()
        Me.tbpword = New System.Windows.Forms.TextBox()
        Me.GLabel9 = New gLabel.gLabel()
        Me.lblpword = New gLabel.gLabel()
        Me.GLabel10 = New gLabel.gLabel()
        Me.lbl2stat = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl2bag = New System.Windows.Forms.Label()
        Me.GLabel8 = New gLabel.gLabel()
        Me.lbl2exit = New System.Windows.Forms.Label()
        Me.GLabel7 = New gLabel.gLabel()
        Me.GLabel4 = New gLabel.gLabel()
        Me.GLabel6 = New gLabel.gLabel()
        Me.lbl2etime = New System.Windows.Forms.Label()
        Me.lbl2uname = New System.Windows.Forms.Label()
        Me.lbl2edate = New System.Windows.Forms.Label()
        Me.lbl2log = New System.Windows.Forms.Label()
        Me.GhostButton4 = New LibSys.GhostButton()
        Me.btnlogout = New LibSys.GhostButton()
        Me.lvlog = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnheader.SuspendLayout()
        Me.OrangeTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.OrangeGroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.OrangeGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnheader
        '
        Me.pnheader.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.pnheader.Controls.Add(Me.SlcClose1)
        Me.pnheader.Controls.Add(Me.Label1)
        Me.pnheader.Location = New System.Drawing.Point(-1, -1)
        Me.pnheader.Name = "pnheader"
        Me.pnheader.Size = New System.Drawing.Size(876, 35)
        Me.pnheader.TabIndex = 1
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New LibSys.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(669, 8)
        Me.SlcClose1.Name = "SlcClose1"
        Me.SlcClose1.NoRounding = False
        Me.SlcClose1.Size = New System.Drawing.Size(20, 20)
        Me.SlcClose1.TabIndex = 1
        Me.SlcClose1.Text = "SlcClose1"
        Me.SlcClose1.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current User Logs"
        '
        'Timer1
        '
        '
        'OrangeTabControl1
        '
        Me.OrangeTabControl1.ActiveColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.OrangeTabControl1.BackTabColour = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.OrangeTabControl1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.OrangeTabControl1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.OrangeTabControl1.Controls.Add(Me.TabPage1)
        Me.OrangeTabControl1.Controls.Add(Me.TabPage2)
        Me.OrangeTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.OrangeTabControl1.HorizontalLineColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.OrangeTabControl1.ItemSize = New System.Drawing.Size(240, 32)
        Me.OrangeTabControl1.Location = New System.Drawing.Point(9, 42)
        Me.OrangeTabControl1.Name = "OrangeTabControl1"
        Me.OrangeTabControl1.SelectedIndex = 0
        Me.OrangeTabControl1.Size = New System.Drawing.Size(675, 368)
        Me.OrangeTabControl1.TabIndex = 26
        Me.OrangeTabControl1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OrangeTabControl1.UpLineColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.OrangeGroupBox1)
        Me.TabPage1.Controls.Add(Me.GhostButton1)
        Me.TabPage1.Controls.Add(Me.tbsearch)
        Me.TabPage1.Controls.Add(Me.lv)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(667, 328)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Login"
        '
        'OrangeGroupBox1
        '
        Me.OrangeGroupBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.OrangeGroupBox1.Controls.Add(Me.lbllog)
        Me.OrangeGroupBox1.Controls.Add(Me.GLabel1)
        Me.OrangeGroupBox1.Controls.Add(Me.GLabel5)
        Me.OrangeGroupBox1.Controls.Add(Me.lblidx)
        Me.OrangeGroupBox1.Controls.Add(Me.lbletime)
        Me.OrangeGroupBox1.Controls.Add(Me.lbltitle)
        Me.OrangeGroupBox1.Controls.Add(Me.lbledate)
        Me.OrangeGroupBox1.Controls.Add(Me.lblresult)
        Me.OrangeGroupBox1.Controls.Add(Me.GhostButton2)
        Me.OrangeGroupBox1.Controls.Add(Me.GLabel2)
        Me.OrangeGroupBox1.Controls.Add(Me.btnsave)
        Me.OrangeGroupBox1.Controls.Add(Me.tbbag)
        Me.OrangeGroupBox1.Controls.Add(Me.lbl2uid)
        Me.OrangeGroupBox1.Controls.Add(Me.GLabel3)
        Me.OrangeGroupBox1.Controls.Add(Me.lbluname)
        Me.OrangeGroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.OrangeGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.OrangeGroupBox1.Location = New System.Drawing.Point(409, 12)
        Me.OrangeGroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.OrangeGroupBox1.Name = "OrangeGroupBox1"
        Me.OrangeGroupBox1.Size = New System.Drawing.Size(248, 304)
        Me.OrangeGroupBox1.TabIndex = 25
        Me.OrangeGroupBox1.Text = "Login Details"
        Me.OrangeGroupBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'lbllog
        '
        Me.lbllog.AutoSize = True
        Me.lbllog.BackColor = System.Drawing.Color.Transparent
        Me.lbllog.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbllog.Location = New System.Drawing.Point(16, 75)
        Me.lbllog.Name = "lbllog"
        Me.lbllog.Size = New System.Drawing.Size(17, 17)
        Me.lbllog.TabIndex = 55
        Me.lbllog.Text = "..."
        '
        'GLabel1
        '
        Me.GLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel1.ForeColor = System.Drawing.Color.White
        Me.GLabel1.Glow = 6
        Me.GLabel1.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel1.GlowState = False
        Me.GLabel1.Location = New System.Drawing.Point(137, 122)
        Me.GLabel1.Name = "GLabel1"
        Me.GLabel1.Size = New System.Drawing.Size(105, 21)
        Me.GLabel1.TabIndex = 31
        Me.GLabel1.Text = "Entry Date"
        Me.GLabel1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GLabel5
        '
        Me.GLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GLabel5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel5.ForeColor = System.Drawing.Color.White
        Me.GLabel5.Glow = 6
        Me.GLabel5.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel5.GlowState = False
        Me.GLabel5.Location = New System.Drawing.Point(12, 45)
        Me.GLabel5.Name = "GLabel5"
        Me.GLabel5.Size = New System.Drawing.Size(91, 21)
        Me.GLabel5.TabIndex = 54
        Me.GLabel5.Text = "Log No"
        Me.GLabel5.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblidx
        '
        Me.lblidx.BackColor = System.Drawing.Color.Transparent
        Me.lblidx.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidx.ForeColor = System.Drawing.Color.White
        Me.lblidx.Glow = 6
        Me.lblidx.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblidx.GlowState = False
        Me.lblidx.Location = New System.Drawing.Point(12, 122)
        Me.lblidx.Name = "lblidx"
        Me.lblidx.Size = New System.Drawing.Size(91, 21)
        Me.lblidx.TabIndex = 10
        Me.lblidx.Text = "User ID"
        Me.lblidx.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lbletime
        '
        Me.lbletime.AutoSize = True
        Me.lbletime.BackColor = System.Drawing.Color.Transparent
        Me.lbletime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbletime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbletime.Location = New System.Drawing.Point(141, 215)
        Me.lbletime.Name = "lbletime"
        Me.lbletime.Size = New System.Drawing.Size(17, 17)
        Me.lbletime.TabIndex = 53
        Me.lbletime.Text = "..."
        '
        'lbltitle
        '
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.White
        Me.lbltitle.Glow = 6
        Me.lbltitle.GlowColor = System.Drawing.Color.DarkOrange
        Me.lbltitle.GlowState = False
        Me.lbltitle.Location = New System.Drawing.Point(12, 192)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(105, 21)
        Me.lbltitle.TabIndex = 18
        Me.lbltitle.Text = "User Name"
        Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lbledate
        '
        Me.lbledate.AutoSize = True
        Me.lbledate.BackColor = System.Drawing.Color.Transparent
        Me.lbledate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbledate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbledate.Location = New System.Drawing.Point(141, 145)
        Me.lbledate.Name = "lbledate"
        Me.lbledate.Size = New System.Drawing.Size(17, 17)
        Me.lbledate.TabIndex = 52
        Me.lbledate.Text = "..."
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.BackColor = System.Drawing.Color.Transparent
        Me.lblresult.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult.ForeColor = System.Drawing.Color.Silver
        Me.lblresult.Location = New System.Drawing.Point(172, 80)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(0, 17)
        Me.lblresult.TabIndex = 29
        Me.lblresult.Visible = False
        '
        'GhostButton2
        '
        Me.GhostButton2.Color = System.Drawing.Color.Empty
        Me.GhostButton2.Colors = New LibSys.Bloom(-1) {}
        Me.GhostButton2.Customization = ""
        Me.GhostButton2.EnableGlass = True
        Me.GhostButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostButton2.Image = Nothing
        Me.GhostButton2.Location = New System.Drawing.Point(129, 256)
        Me.GhostButton2.Name = "GhostButton2"
        Me.GhostButton2.NoRounding = False
        Me.GhostButton2.Size = New System.Drawing.Size(83, 32)
        Me.GhostButton2.TabIndex = 51
        Me.GhostButton2.Text = "Refresh"
        Me.GhostButton2.Transparent = False
        '
        'GLabel2
        '
        Me.GLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel2.ForeColor = System.Drawing.Color.White
        Me.GLabel2.Glow = 6
        Me.GLabel2.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel2.GlowState = False
        Me.GLabel2.Location = New System.Drawing.Point(137, 45)
        Me.GLabel2.Name = "GLabel2"
        Me.GLabel2.Size = New System.Drawing.Size(105, 21)
        Me.GLabel2.TabIndex = 33
        Me.GLabel2.Text = "Baggage No."
        Me.GLabel2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'btnsave
        '
        Me.btnsave.Color = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsave.Colors = New LibSys.Bloom(-1) {}
        Me.btnsave.Customization = ""
        Me.btnsave.EnableGlass = True
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnsave.Image = Nothing
        Me.btnsave.Location = New System.Drawing.Point(33, 256)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.NoRounding = False
        Me.btnsave.Size = New System.Drawing.Size(83, 32)
        Me.btnsave.TabIndex = 50
        Me.btnsave.Text = "Save"
        Me.btnsave.Transparent = False
        '
        'tbbag
        '
        Me.tbbag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbbag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbbag.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbbag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbbag.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbbag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbbag.Location = New System.Drawing.Point(141, 72)
        Me.tbbag.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbbag.MaxLength = 30
        Me.tbbag.Name = "tbbag"
        Me.tbbag.Size = New System.Drawing.Size(71, 25)
        Me.tbbag.TabIndex = 34
        '
        'lbl2uid
        '
        Me.lbl2uid.AutoSize = True
        Me.lbl2uid.BackColor = System.Drawing.Color.Transparent
        Me.lbl2uid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2uid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl2uid.Location = New System.Drawing.Point(16, 145)
        Me.lbl2uid.Name = "lbl2uid"
        Me.lbl2uid.Size = New System.Drawing.Size(17, 17)
        Me.lbl2uid.TabIndex = 40
        Me.lbl2uid.Text = "..."
        '
        'GLabel3
        '
        Me.GLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel3.ForeColor = System.Drawing.Color.White
        Me.GLabel3.Glow = 6
        Me.GLabel3.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel3.GlowState = False
        Me.GLabel3.Location = New System.Drawing.Point(137, 192)
        Me.GLabel3.Name = "GLabel3"
        Me.GLabel3.Size = New System.Drawing.Size(105, 21)
        Me.GLabel3.TabIndex = 35
        Me.GLabel3.Text = "Entry Time "
        Me.GLabel3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lbluname
        '
        Me.lbluname.AutoSize = True
        Me.lbluname.BackColor = System.Drawing.Color.Transparent
        Me.lbluname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbluname.Location = New System.Drawing.Point(16, 215)
        Me.lbluname.Name = "lbluname"
        Me.lbluname.Size = New System.Drawing.Size(17, 17)
        Me.lbluname.TabIndex = 39
        Me.lbluname.Text = "..."
        '
        'GhostButton1
        '
        Me.GhostButton1.Color = System.Drawing.Color.Empty
        Me.GhostButton1.Colors = New LibSys.Bloom(-1) {}
        Me.GhostButton1.Customization = ""
        Me.GhostButton1.EnableGlass = True
        Me.GhostButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostButton1.Image = Nothing
        Me.GhostButton1.Location = New System.Drawing.Point(371, 13)
        Me.GhostButton1.Name = "GhostButton1"
        Me.GhostButton1.NoRounding = False
        Me.GhostButton1.Size = New System.Drawing.Size(32, 25)
        Me.GhostButton1.TabIndex = 24
        Me.GhostButton1.Text = "Q"
        Me.GhostButton1.Transparent = False
        '
        'tbsearch
        '
        Me.tbsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbsearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbsearch.Location = New System.Drawing.Point(8, 12)
        Me.tbsearch.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbsearch.MaxLength = 30
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(395, 27)
        Me.tbsearch.TabIndex = 22
        Me.tbsearch.Text = " Search ..."
        '
        'lv
        '
        Me.lv.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv.ForeColor = System.Drawing.Color.Silver
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.Location = New System.Drawing.Point(9, 45)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(394, 271)
        Me.lv.TabIndex = 21
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 68
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "UserName"
        Me.ColumnHeader2.Width = 157
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "FirstName"
        Me.ColumnHeader3.Width = 135
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "LastName"
        Me.ColumnHeader4.Width = 116
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.OrangeGroupBox2)
        Me.TabPage2.Controls.Add(Me.lvlog)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(667, 328)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Current Logs"
        '
        'OrangeGroupBox2
        '
        Me.OrangeGroupBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.OrangeGroupBox2.Controls.Add(Me.OrangeSeperator3)
        Me.OrangeGroupBox2.Controls.Add(Me.tbpword)
        Me.OrangeGroupBox2.Controls.Add(Me.GLabel9)
        Me.OrangeGroupBox2.Controls.Add(Me.lblpword)
        Me.OrangeGroupBox2.Controls.Add(Me.GLabel10)
        Me.OrangeGroupBox2.Controls.Add(Me.lbl2stat)
        Me.OrangeGroupBox2.Controls.Add(Me.Label10)
        Me.OrangeGroupBox2.Controls.Add(Me.lbl2bag)
        Me.OrangeGroupBox2.Controls.Add(Me.GLabel8)
        Me.OrangeGroupBox2.Controls.Add(Me.lbl2exit)
        Me.OrangeGroupBox2.Controls.Add(Me.GLabel7)
        Me.OrangeGroupBox2.Controls.Add(Me.GLabel4)
        Me.OrangeGroupBox2.Controls.Add(Me.GLabel6)
        Me.OrangeGroupBox2.Controls.Add(Me.lbl2etime)
        Me.OrangeGroupBox2.Controls.Add(Me.lbl2uname)
        Me.OrangeGroupBox2.Controls.Add(Me.lbl2edate)
        Me.OrangeGroupBox2.Controls.Add(Me.lbl2log)
        Me.OrangeGroupBox2.Controls.Add(Me.GhostButton4)
        Me.OrangeGroupBox2.Controls.Add(Me.btnlogout)
        Me.OrangeGroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.OrangeGroupBox2.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.OrangeGroupBox2.Location = New System.Drawing.Point(413, 6)
        Me.OrangeGroupBox2.MainColour = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.OrangeGroupBox2.Name = "OrangeGroupBox2"
        Me.OrangeGroupBox2.Size = New System.Drawing.Size(248, 312)
        Me.OrangeGroupBox2.TabIndex = 57
        Me.OrangeGroupBox2.Text = "Log Details"
        Me.OrangeGroupBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'OrangeSeperator3
        '
        Me.OrangeSeperator3.Alignment = LibSys.OrangeSeperator.Style.Verticle
        Me.OrangeSeperator3.BackColor = System.Drawing.Color.Transparent
        Me.OrangeSeperator3.Location = New System.Drawing.Point(114, 43)
        Me.OrangeSeperator3.Name = "OrangeSeperator3"
        Me.OrangeSeperator3.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.OrangeSeperator3.Size = New System.Drawing.Size(12, 174)
        Me.OrangeSeperator3.TabIndex = 71
        Me.OrangeSeperator3.Text = "OrangeSeperator3"
        Me.OrangeSeperator3.Thickness = 1.0!
        '
        'tbpword
        '
        Me.tbpword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbpword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbpword.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbpword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbpword.Location = New System.Drawing.Point(20, 230)
        Me.tbpword.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbpword.MaxLength = 1000
        Me.tbpword.Name = "tbpword"
        Me.tbpword.Size = New System.Drawing.Size(209, 25)
        Me.tbpword.TabIndex = 61
        Me.tbpword.UseSystemPasswordChar = True
        '
        'GLabel9
        '
        Me.GLabel9.BackColor = System.Drawing.Color.Transparent
        Me.GLabel9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel9.ForeColor = System.Drawing.Color.White
        Me.GLabel9.Glow = 6
        Me.GLabel9.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel9.GlowState = False
        Me.GLabel9.Location = New System.Drawing.Point(17, 102)
        Me.GLabel9.Name = "GLabel9"
        Me.GLabel9.Size = New System.Drawing.Size(76, 21)
        Me.GLabel9.TabIndex = 18
        Me.GLabel9.Text = "User Name "
        Me.GLabel9.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblpword
        '
        Me.lblpword.BackColor = System.Drawing.Color.Transparent
        Me.lblpword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpword.ForeColor = System.Drawing.Color.White
        Me.lblpword.Glow = 6
        Me.lblpword.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblpword.GlowState = False
        Me.lblpword.Location = New System.Drawing.Point(19, 206)
        Me.lblpword.Name = "lblpword"
        Me.lblpword.Size = New System.Drawing.Size(105, 21)
        Me.lblpword.TabIndex = 60
        Me.lblpword.Text = "Password"
        Me.lblpword.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GLabel10
        '
        Me.GLabel10.BackColor = System.Drawing.Color.Transparent
        Me.GLabel10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel10.ForeColor = System.Drawing.Color.White
        Me.GLabel10.Glow = 6
        Me.GLabel10.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel10.GlowState = False
        Me.GLabel10.Location = New System.Drawing.Point(17, 45)
        Me.GLabel10.Name = "GLabel10"
        Me.GLabel10.Size = New System.Drawing.Size(91, 21)
        Me.GLabel10.TabIndex = 10
        Me.GLabel10.Text = "Log ID -"
        Me.GLabel10.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lbl2stat
        '
        Me.lbl2stat.AutoSize = True
        Me.lbl2stat.BackColor = System.Drawing.Color.Transparent
        Me.lbl2stat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2stat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl2stat.Location = New System.Drawing.Point(76, 47)
        Me.lbl2stat.Name = "lbl2stat"
        Me.lbl2stat.Size = New System.Drawing.Size(0, 17)
        Me.lbl2stat.TabIndex = 59
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Silver
        Me.Label10.Location = New System.Drawing.Point(191, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 17)
        Me.Label10.TabIndex = 29
        Me.Label10.Visible = False
        '
        'lbl2bag
        '
        Me.lbl2bag.AutoSize = True
        Me.lbl2bag.BackColor = System.Drawing.Color.Transparent
        Me.lbl2bag.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2bag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl2bag.Location = New System.Drawing.Point(21, 183)
        Me.lbl2bag.Name = "lbl2bag"
        Me.lbl2bag.Size = New System.Drawing.Size(17, 17)
        Me.lbl2bag.TabIndex = 58
        Me.lbl2bag.Text = "..."
        '
        'GLabel8
        '
        Me.GLabel8.BackColor = System.Drawing.Color.Transparent
        Me.GLabel8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel8.ForeColor = System.Drawing.Color.White
        Me.GLabel8.Glow = 6
        Me.GLabel8.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel8.GlowState = False
        Me.GLabel8.Location = New System.Drawing.Point(154, 45)
        Me.GLabel8.Name = "GLabel8"
        Me.GLabel8.Size = New System.Drawing.Size(105, 21)
        Me.GLabel8.TabIndex = 31
        Me.GLabel8.Text = "Entry Date"
        Me.GLabel8.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lbl2exit
        '
        Me.lbl2exit.AutoSize = True
        Me.lbl2exit.BackColor = System.Drawing.Color.Transparent
        Me.lbl2exit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2exit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl2exit.Location = New System.Drawing.Point(158, 183)
        Me.lbl2exit.Name = "lbl2exit"
        Me.lbl2exit.Size = New System.Drawing.Size(17, 17)
        Me.lbl2exit.TabIndex = 57
        Me.lbl2exit.Text = "..."
        '
        'GLabel7
        '
        Me.GLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GLabel7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel7.ForeColor = System.Drawing.Color.White
        Me.GLabel7.Glow = 6
        Me.GLabel7.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel7.GlowState = False
        Me.GLabel7.Location = New System.Drawing.Point(17, 156)
        Me.GLabel7.Name = "GLabel7"
        Me.GLabel7.Size = New System.Drawing.Size(105, 21)
        Me.GLabel7.TabIndex = 33
        Me.GLabel7.Text = "Baggage No."
        Me.GLabel7.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GLabel4
        '
        Me.GLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GLabel4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel4.ForeColor = System.Drawing.Color.White
        Me.GLabel4.Glow = 6
        Me.GLabel4.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel4.GlowState = False
        Me.GLabel4.Location = New System.Drawing.Point(154, 156)
        Me.GLabel4.Name = "GLabel4"
        Me.GLabel4.Size = New System.Drawing.Size(105, 21)
        Me.GLabel4.TabIndex = 56
        Me.GLabel4.Text = "Time Exit"
        Me.GLabel4.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GLabel6
        '
        Me.GLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GLabel6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel6.ForeColor = System.Drawing.Color.White
        Me.GLabel6.Glow = 6
        Me.GLabel6.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel6.GlowState = False
        Me.GLabel6.Location = New System.Drawing.Point(154, 102)
        Me.GLabel6.Name = "GLabel6"
        Me.GLabel6.Size = New System.Drawing.Size(105, 21)
        Me.GLabel6.TabIndex = 35
        Me.GLabel6.Text = "Entry Time "
        Me.GLabel6.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lbl2etime
        '
        Me.lbl2etime.AutoSize = True
        Me.lbl2etime.BackColor = System.Drawing.Color.Transparent
        Me.lbl2etime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2etime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl2etime.Location = New System.Drawing.Point(158, 125)
        Me.lbl2etime.Name = "lbl2etime"
        Me.lbl2etime.Size = New System.Drawing.Size(17, 17)
        Me.lbl2etime.TabIndex = 53
        Me.lbl2etime.Text = "..."
        '
        'lbl2uname
        '
        Me.lbl2uname.AutoSize = True
        Me.lbl2uname.BackColor = System.Drawing.Color.Transparent
        Me.lbl2uname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2uname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl2uname.Location = New System.Drawing.Point(21, 125)
        Me.lbl2uname.Name = "lbl2uname"
        Me.lbl2uname.Size = New System.Drawing.Size(17, 17)
        Me.lbl2uname.TabIndex = 39
        Me.lbl2uname.Text = "..."
        '
        'lbl2edate
        '
        Me.lbl2edate.AutoSize = True
        Me.lbl2edate.BackColor = System.Drawing.Color.Transparent
        Me.lbl2edate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2edate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl2edate.Location = New System.Drawing.Point(158, 68)
        Me.lbl2edate.Name = "lbl2edate"
        Me.lbl2edate.Size = New System.Drawing.Size(17, 17)
        Me.lbl2edate.TabIndex = 52
        Me.lbl2edate.Text = "..."
        '
        'lbl2log
        '
        Me.lbl2log.AutoSize = True
        Me.lbl2log.BackColor = System.Drawing.Color.Transparent
        Me.lbl2log.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2log.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl2log.Location = New System.Drawing.Point(21, 68)
        Me.lbl2log.Name = "lbl2log"
        Me.lbl2log.Size = New System.Drawing.Size(17, 17)
        Me.lbl2log.TabIndex = 40
        Me.lbl2log.Text = "..."
        '
        'GhostButton4
        '
        Me.GhostButton4.Color = System.Drawing.Color.Empty
        Me.GhostButton4.Colors = New LibSys.Bloom(-1) {}
        Me.GhostButton4.Customization = ""
        Me.GhostButton4.EnableGlass = True
        Me.GhostButton4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostButton4.Image = Nothing
        Me.GhostButton4.Location = New System.Drawing.Point(130, 266)
        Me.GhostButton4.Name = "GhostButton4"
        Me.GhostButton4.NoRounding = False
        Me.GhostButton4.Size = New System.Drawing.Size(83, 32)
        Me.GhostButton4.TabIndex = 51
        Me.GhostButton4.Text = "Refresh"
        Me.GhostButton4.Transparent = False
        '
        'btnlogout
        '
        Me.btnlogout.Color = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnlogout.Colors = New LibSys.Bloom(-1) {}
        Me.btnlogout.Customization = ""
        Me.btnlogout.EnableGlass = True
        Me.btnlogout.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnlogout.Image = Nothing
        Me.btnlogout.Location = New System.Drawing.Point(41, 266)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.NoRounding = False
        Me.btnlogout.Size = New System.Drawing.Size(83, 32)
        Me.btnlogout.TabIndex = 50
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.Transparent = False
        '
        'lvlog
        '
        Me.lvlog.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lvlog.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lvlog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlog.ForeColor = System.Drawing.Color.Gainsboro
        Me.lvlog.FullRowSelect = True
        Me.lvlog.GridLines = True
        Me.lvlog.Location = New System.Drawing.Point(13, 6)
        Me.lvlog.Name = "lvlog"
        Me.lvlog.Size = New System.Drawing.Size(394, 312)
        Me.lvlog.TabIndex = 25
        Me.lvlog.UseCompatibleStateImageBehavior = False
        Me.lvlog.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Log No"
        Me.ColumnHeader5.Width = 68
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "User ID"
        Me.ColumnHeader6.Width = 86
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Username"
        Me.ColumnHeader7.Width = 101
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Status"
        Me.ColumnHeader8.Width = 78
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Entry Date"
        Me.ColumnHeader9.Width = 88
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Entry Time"
        Me.ColumnHeader10.Width = 78
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Time Exit"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Baggage No."
        '
        'frmCurrentUserLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(693, 420)
        Me.Controls.Add(Me.OrangeTabControl1)
        Me.Controls.Add(Me.pnheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCurrentUserLog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogUser"
        Me.TopMost = True
        Me.pnheader.ResumeLayout(False)
        Me.pnheader.PerformLayout()
        Me.OrangeTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.OrangeGroupBox1.ResumeLayout(False)
        Me.OrangeGroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.OrangeGroupBox2.ResumeLayout(False)
        Me.OrangeGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnheader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GLabel1 As gLabel.gLabel
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents lbltitle As gLabel.gLabel
    Friend WithEvents lblidx As gLabel.gLabel
    Friend WithEvents lbl2uid As System.Windows.Forms.Label
    Friend WithEvents lbluname As System.Windows.Forms.Label
    Friend WithEvents GLabel3 As gLabel.gLabel
    Friend WithEvents tbbag As System.Windows.Forms.TextBox
    Friend WithEvents GLabel2 As gLabel.gLabel
    Friend WithEvents GhostButton2 As LibSys.GhostButton
    Friend WithEvents btnsave As LibSys.GhostButton
    Friend WithEvents lbletime As System.Windows.Forms.Label
    Friend WithEvents lbledate As System.Windows.Forms.Label
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvlog As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl2etime As System.Windows.Forms.Label
    Friend WithEvents lbl2edate As System.Windows.Forms.Label
    Friend WithEvents GhostButton4 As LibSys.GhostButton
    Friend WithEvents btnlogout As LibSys.GhostButton
    Friend WithEvents lbl2log As System.Windows.Forms.Label
    Friend WithEvents lbl2uname As System.Windows.Forms.Label
    Friend WithEvents GLabel6 As gLabel.gLabel
    Friend WithEvents GLabel7 As gLabel.gLabel
    Friend WithEvents GLabel8 As gLabel.gLabel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GLabel9 As gLabel.gLabel
    Friend WithEvents GLabel10 As gLabel.gLabel
    Friend WithEvents lbllog As System.Windows.Forms.Label
    Friend WithEvents GLabel5 As gLabel.gLabel
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl2bag As System.Windows.Forms.Label
    Friend WithEvents lbl2exit As System.Windows.Forms.Label
    Friend WithEvents GLabel4 As gLabel.gLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl2stat As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblpword As gLabel.gLabel
    Friend WithEvents tbpword As System.Windows.Forms.TextBox
    Friend WithEvents SlcClose1 As LibSys.SLCClose
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OrangeTabControl1 As LibSys.OrangeTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GhostButton1 As LibSys.GhostButton
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents OrangeGroupBox1 As LibSys.OrangeGroupBox
    Friend WithEvents OrangeGroupBox2 As LibSys.OrangeGroupBox
    Friend WithEvents OrangeSeperator3 As LibSys.OrangeSeperator
End Class
