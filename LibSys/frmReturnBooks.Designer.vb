<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnBooks
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
        Me.lv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbldatebor = New System.Windows.Forms.Label()
        Me.GLabel3 = New gLabel.gLabel()
        Me.lblidbook = New System.Windows.Forms.Label()
        Me.GLabel2 = New gLabel.gLabel()
        Me.lbldueborrow = New System.Windows.Forms.Label()
        Me.GLabel6 = New gLabel.gLabel()
        Me.lblmember = New System.Windows.Forms.Label()
        Me.GLabel8 = New gLabel.gLabel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.GLabel1 = New gLabel.gLabel()
        Me.lblisid = New System.Windows.Forms.Label()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.lblissuance = New gLabel.gLabel()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblidx = New gLabel.gLabel()
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.btnsearch = New LibSys.GhostButton()
        Me.tbrem = New System.Windows.Forms.TextBox()
        Me.lblrem = New gLabel.gLabel()
        Me.lblfine = New gLabel.gLabel()
        Me.lbldate = New gLabel.gLabel()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.btnrefresh = New LibSys.GhostButton()
        Me.btnreturn = New LibSys.GhostButton()
        Me.btnclear = New LibSys.GhostButton()
        Me.cbofine = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OrangeGroupBox1 = New LibSys.OrangeGroupBox()
        Me.OrangeSeperator3 = New LibSys.OrangeSeperator()
        Me.OrangeGroupBox2 = New LibSys.OrangeGroupBox()
        Me.pnheader.SuspendLayout()
        Me.OrangeGroupBox1.SuspendLayout()
        Me.OrangeGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnheader
        '
        Me.pnheader.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.pnheader.Controls.Add(Me.SlcClose1)
        Me.pnheader.Controls.Add(Me.Label1)
        Me.pnheader.Location = New System.Drawing.Point(-1, 1)
        Me.pnheader.Name = "pnheader"
        Me.pnheader.Size = New System.Drawing.Size(755, 35)
        Me.pnheader.TabIndex = 1
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New LibSys.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(729, 7)
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
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Return Books"
        '
        'lv
        '
        Me.lv.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv.ForeColor = System.Drawing.Color.Gainsboro
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.Location = New System.Drawing.Point(7, 74)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(434, 381)
        Me.lv.TabIndex = 27
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
        Me.ColumnHeader2.Text = "Book ID"
        Me.ColumnHeader2.Width = 91
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Book Title"
        Me.ColumnHeader3.Width = 133
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Member Name"
        Me.ColumnHeader4.Width = 116
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date Borrow"
        Me.ColumnHeader5.Width = 122
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Due Date"
        Me.ColumnHeader6.Width = 115
        '
        'lbldatebor
        '
        Me.lbldatebor.AutoSize = True
        Me.lbldatebor.BackColor = System.Drawing.Color.Transparent
        Me.lbldatebor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatebor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbldatebor.Location = New System.Drawing.Point(174, 104)
        Me.lbldatebor.Name = "lbldatebor"
        Me.lbldatebor.Size = New System.Drawing.Size(17, 17)
        Me.lbldatebor.TabIndex = 51
        Me.lbldatebor.Text = "..."
        '
        'GLabel3
        '
        Me.GLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel3.ForeColor = System.Drawing.Color.White
        Me.GLabel3.Glow = 6
        Me.GLabel3.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel3.GlowState = False
        Me.GLabel3.Location = New System.Drawing.Point(172, 82)
        Me.GLabel3.Name = "GLabel3"
        Me.GLabel3.Size = New System.Drawing.Size(111, 21)
        Me.GLabel3.TabIndex = 50
        Me.GLabel3.Text = "Date Borrowed"
        Me.GLabel3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblidbook
        '
        Me.lblidbook.AutoSize = True
        Me.lblidbook.BackColor = System.Drawing.Color.Transparent
        Me.lblidbook.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidbook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblidbook.Location = New System.Drawing.Point(20, 103)
        Me.lblidbook.Name = "lblidbook"
        Me.lblidbook.Size = New System.Drawing.Size(17, 17)
        Me.lblidbook.TabIndex = 49
        Me.lblidbook.Text = "..."
        '
        'GLabel2
        '
        Me.GLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel2.ForeColor = System.Drawing.Color.White
        Me.GLabel2.Glow = 6
        Me.GLabel2.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel2.GlowState = False
        Me.GLabel2.Location = New System.Drawing.Point(18, 82)
        Me.GLabel2.Name = "GLabel2"
        Me.GLabel2.Size = New System.Drawing.Size(111, 21)
        Me.GLabel2.TabIndex = 48
        Me.GLabel2.Text = "Book ID"
        Me.GLabel2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lbldueborrow
        '
        Me.lbldueborrow.AutoSize = True
        Me.lbldueborrow.BackColor = System.Drawing.Color.Transparent
        Me.lbldueborrow.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldueborrow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbldueborrow.Location = New System.Drawing.Point(174, 150)
        Me.lbldueborrow.Name = "lbldueborrow"
        Me.lbldueborrow.Size = New System.Drawing.Size(17, 17)
        Me.lbldueborrow.TabIndex = 47
        Me.lbldueborrow.Text = "..."
        '
        'GLabel6
        '
        Me.GLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GLabel6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel6.ForeColor = System.Drawing.Color.White
        Me.GLabel6.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel6.GlowState = False
        Me.GLabel6.Location = New System.Drawing.Point(172, 128)
        Me.GLabel6.Name = "GLabel6"
        Me.GLabel6.PulseSpeed = 1
        Me.GLabel6.Size = New System.Drawing.Size(87, 21)
        Me.GLabel6.TabIndex = 46
        Me.GLabel6.Text = "Due Date"
        Me.GLabel6.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblmember
        '
        Me.lblmember.AutoSize = True
        Me.lblmember.BackColor = System.Drawing.Color.Transparent
        Me.lblmember.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblmember.Location = New System.Drawing.Point(173, 59)
        Me.lblmember.Name = "lblmember"
        Me.lblmember.Size = New System.Drawing.Size(17, 17)
        Me.lblmember.TabIndex = 45
        Me.lblmember.Text = "..."
        '
        'GLabel8
        '
        Me.GLabel8.BackColor = System.Drawing.Color.Transparent
        Me.GLabel8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel8.ForeColor = System.Drawing.Color.White
        Me.GLabel8.Glow = 6
        Me.GLabel8.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel8.GlowState = False
        Me.GLabel8.Location = New System.Drawing.Point(173, 38)
        Me.GLabel8.Name = "GLabel8"
        Me.GLabel8.Size = New System.Drawing.Size(106, 21)
        Me.GLabel8.TabIndex = 44
        Me.GLabel8.Text = "Member Name"
        Me.GLabel8.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltitle.Location = New System.Drawing.Point(20, 149)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(17, 17)
        Me.lbltitle.TabIndex = 43
        Me.lbltitle.Text = "..."
        '
        'GLabel1
        '
        Me.GLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel1.ForeColor = System.Drawing.Color.White
        Me.GLabel1.Glow = 6
        Me.GLabel1.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel1.GlowState = False
        Me.GLabel1.Location = New System.Drawing.Point(18, 128)
        Me.GLabel1.Name = "GLabel1"
        Me.GLabel1.Size = New System.Drawing.Size(111, 21)
        Me.GLabel1.TabIndex = 42
        Me.GLabel1.Text = "Book Title"
        Me.GLabel1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblisid
        '
        Me.lblisid.AutoSize = True
        Me.lblisid.BackColor = System.Drawing.Color.Transparent
        Me.lblisid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblisid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblisid.Location = New System.Drawing.Point(20, 60)
        Me.lblisid.Name = "lblisid"
        Me.lblisid.Size = New System.Drawing.Size(17, 17)
        Me.lblisid.TabIndex = 39
        Me.lblisid.Text = "..."
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.BackColor = System.Drawing.Color.Transparent
        Me.lblresult.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult.ForeColor = System.Drawing.Color.Silver
        Me.lblresult.Location = New System.Drawing.Point(178, 68)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(0, 17)
        Me.lblresult.TabIndex = 29
        Me.lblresult.Visible = False
        '
        'lblissuance
        '
        Me.lblissuance.BackColor = System.Drawing.Color.Transparent
        Me.lblissuance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblissuance.ForeColor = System.Drawing.Color.White
        Me.lblissuance.Glow = 6
        Me.lblissuance.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblissuance.GlowState = False
        Me.lblissuance.Location = New System.Drawing.Point(18, 38)
        Me.lblissuance.Name = "lblissuance"
        Me.lblissuance.Size = New System.Drawing.Size(111, 21)
        Me.lblissuance.TabIndex = 18
        Me.lblissuance.Text = "Issuance ID"
        Me.lblissuance.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.BackColor = System.Drawing.Color.Transparent
        Me.lblid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblid.Location = New System.Drawing.Point(16, 54)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(17, 17)
        Me.lblid.TabIndex = 23
        Me.lblid.Text = "..."
        '
        'lblidx
        '
        Me.lblidx.BackColor = System.Drawing.Color.Transparent
        Me.lblidx.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidx.ForeColor = System.Drawing.Color.White
        Me.lblidx.Glow = 6
        Me.lblidx.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblidx.GlowState = False
        Me.lblidx.Location = New System.Drawing.Point(15, 33)
        Me.lblidx.Name = "lblidx"
        Me.lblidx.Size = New System.Drawing.Size(76, 21)
        Me.lblidx.TabIndex = 10
        Me.lblidx.Text = "Return ID"
        Me.lblidx.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'tbsearch
        '
        Me.tbsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbsearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbsearch.Location = New System.Drawing.Point(7, 42)
        Me.tbsearch.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbsearch.MaxLength = 30
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(434, 27)
        Me.tbsearch.TabIndex = 31
        Me.tbsearch.Text = " Search ..."
        '
        'btnsearch
        '
        Me.btnsearch.Color = System.Drawing.Color.Empty
        Me.btnsearch.Colors = New LibSys.Bloom(-1) {}
        Me.btnsearch.Customization = ""
        Me.btnsearch.EnableGlass = True
        Me.btnsearch.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnsearch.Image = Nothing
        Me.btnsearch.Location = New System.Drawing.Point(409, 43)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.NoRounding = False
        Me.btnsearch.Size = New System.Drawing.Size(32, 25)
        Me.btnsearch.TabIndex = 45
        Me.btnsearch.Text = "Q"
        Me.btnsearch.Transparent = False
        '
        'tbrem
        '
        Me.tbrem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbrem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbrem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbrem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbrem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbrem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbrem.Location = New System.Drawing.Point(17, 98)
        Me.tbrem.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbrem.MaxLength = 1000
        Me.tbrem.Name = "tbrem"
        Me.tbrem.Size = New System.Drawing.Size(264, 25)
        Me.tbrem.TabIndex = 30
        '
        'lblrem
        '
        Me.lblrem.BackColor = System.Drawing.Color.Transparent
        Me.lblrem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrem.ForeColor = System.Drawing.Color.White
        Me.lblrem.Glow = 6
        Me.lblrem.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblrem.GlowState = False
        Me.lblrem.Location = New System.Drawing.Point(15, 74)
        Me.lblrem.Name = "lblrem"
        Me.lblrem.Size = New System.Drawing.Size(111, 21)
        Me.lblrem.TabIndex = 31
        Me.lblrem.Text = "Remarks"
        Me.lblrem.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblfine
        '
        Me.lblfine.BackColor = System.Drawing.Color.Transparent
        Me.lblfine.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfine.ForeColor = System.Drawing.Color.White
        Me.lblfine.Glow = 6
        Me.lblfine.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblfine.GlowState = False
        Me.lblfine.Location = New System.Drawing.Point(15, 129)
        Me.lblfine.Name = "lblfine"
        Me.lblfine.Size = New System.Drawing.Size(111, 21)
        Me.lblfine.TabIndex = 33
        Me.lblfine.Text = "Fine"
        Me.lblfine.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lbldate
        '
        Me.lbldate.BackColor = System.Drawing.Color.Transparent
        Me.lbldate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Glow = 6
        Me.lbldate.GlowColor = System.Drawing.Color.DarkOrange
        Me.lbldate.GlowState = False
        Me.lbldate.Location = New System.Drawing.Point(147, 129)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(95, 21)
        Me.lbldate.TabIndex = 34
        Me.lbldate.Text = "Return Date"
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'dtpdate
        '
        Me.dtpdate.CalendarMonthBackground = System.Drawing.Color.Red
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdate.Location = New System.Drawing.Point(151, 153)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(131, 27)
        Me.dtpdate.TabIndex = 35
        '
        'btnrefresh
        '
        Me.btnrefresh.Color = System.Drawing.Color.Empty
        Me.btnrefresh.Colors = New LibSys.Bloom(-1) {}
        Me.btnrefresh.Customization = ""
        Me.btnrefresh.EnableGlass = True
        Me.btnrefresh.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnrefresh.Image = Nothing
        Me.btnrefresh.Location = New System.Drawing.Point(509, 427)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.NoRounding = False
        Me.btnrefresh.Size = New System.Drawing.Size(82, 28)
        Me.btnrefresh.TabIndex = 36
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.Transparent = False
        '
        'btnreturn
        '
        Me.btnreturn.Color = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnreturn.Colors = New LibSys.Bloom(-1) {}
        Me.btnreturn.Customization = ""
        Me.btnreturn.EnableGlass = True
        Me.btnreturn.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnreturn.Image = Nothing
        Me.btnreturn.Location = New System.Drawing.Point(600, 427)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.NoRounding = False
        Me.btnreturn.Size = New System.Drawing.Size(82, 28)
        Me.btnreturn.TabIndex = 37
        Me.btnreturn.Text = "Return"
        Me.btnreturn.Transparent = False
        '
        'btnclear
        '
        Me.btnclear.Color = System.Drawing.Color.Empty
        Me.btnclear.Colors = New LibSys.Bloom(-1) {}
        Me.btnclear.Customization = ""
        Me.btnclear.EnableGlass = True
        Me.btnclear.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnclear.Image = Nothing
        Me.btnclear.Location = New System.Drawing.Point(261, 327)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.NoRounding = False
        Me.btnclear.Size = New System.Drawing.Size(82, 28)
        Me.btnclear.TabIndex = 38
        Me.btnclear.Text = "Clear"
        Me.btnclear.Transparent = False
        '
        'cbofine
        '
        Me.cbofine.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cbofine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbofine.ForeColor = System.Drawing.Color.Silver
        Me.cbofine.FormattingEnabled = True
        Me.cbofine.Items.AddRange(New Object() {"0", "50", "100", "200", "500", "1000"})
        Me.cbofine.Location = New System.Drawing.Point(18, 153)
        Me.cbofine.Name = "cbofine"
        Me.cbofine.Size = New System.Drawing.Size(117, 28)
        Me.cbofine.TabIndex = 41
        Me.cbofine.Text = " ..."
        '
        'OrangeGroupBox1
        '
        Me.OrangeGroupBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.OrangeGroupBox1.Controls.Add(Me.OrangeSeperator3)
        Me.OrangeGroupBox1.Controls.Add(Me.lbldatebor)
        Me.OrangeGroupBox1.Controls.Add(Me.lbldueborrow)
        Me.OrangeGroupBox1.Controls.Add(Me.GLabel3)
        Me.OrangeGroupBox1.Controls.Add(Me.lblissuance)
        Me.OrangeGroupBox1.Controls.Add(Me.lblidbook)
        Me.OrangeGroupBox1.Controls.Add(Me.lblresult)
        Me.OrangeGroupBox1.Controls.Add(Me.GLabel2)
        Me.OrangeGroupBox1.Controls.Add(Me.lblisid)
        Me.OrangeGroupBox1.Controls.Add(Me.GLabel1)
        Me.OrangeGroupBox1.Controls.Add(Me.GLabel6)
        Me.OrangeGroupBox1.Controls.Add(Me.lbltitle)
        Me.OrangeGroupBox1.Controls.Add(Me.lblmember)
        Me.OrangeGroupBox1.Controls.Add(Me.GLabel8)
        Me.OrangeGroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.OrangeGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.OrangeGroupBox1.Location = New System.Drawing.Point(449, 42)
        Me.OrangeGroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.OrangeGroupBox1.Name = "OrangeGroupBox1"
        Me.OrangeGroupBox1.Size = New System.Drawing.Size(296, 177)
        Me.OrangeGroupBox1.TabIndex = 53
        Me.OrangeGroupBox1.Text = "Issuance Details"
        Me.OrangeGroupBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'OrangeSeperator3
        '
        Me.OrangeSeperator3.Alignment = LibSys.OrangeSeperator.Style.Verticle
        Me.OrangeSeperator3.BackColor = System.Drawing.Color.Transparent
        Me.OrangeSeperator3.Location = New System.Drawing.Point(136, 45)
        Me.OrangeSeperator3.Name = "OrangeSeperator3"
        Me.OrangeSeperator3.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.OrangeSeperator3.Size = New System.Drawing.Size(12, 116)
        Me.OrangeSeperator3.TabIndex = 70
        Me.OrangeSeperator3.Text = "OrangeSeperator3"
        Me.OrangeSeperator3.Thickness = 1.0!
        '
        'OrangeGroupBox2
        '
        Me.OrangeGroupBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.OrangeGroupBox2.Controls.Add(Me.lblrem)
        Me.OrangeGroupBox2.Controls.Add(Me.lblidx)
        Me.OrangeGroupBox2.Controls.Add(Me.dtpdate)
        Me.OrangeGroupBox2.Controls.Add(Me.tbrem)
        Me.OrangeGroupBox2.Controls.Add(Me.lblid)
        Me.OrangeGroupBox2.Controls.Add(Me.cbofine)
        Me.OrangeGroupBox2.Controls.Add(Me.lbldate)
        Me.OrangeGroupBox2.Controls.Add(Me.lblfine)
        Me.OrangeGroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.OrangeGroupBox2.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.OrangeGroupBox2.Location = New System.Drawing.Point(449, 225)
        Me.OrangeGroupBox2.MainColour = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.OrangeGroupBox2.Name = "OrangeGroupBox2"
        Me.OrangeGroupBox2.Size = New System.Drawing.Size(296, 192)
        Me.OrangeGroupBox2.TabIndex = 54
        Me.OrangeGroupBox2.Text = "Return Details"
        Me.OrangeGroupBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'frmReturnBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(753, 465)
        Me.Controls.Add(Me.OrangeGroupBox2)
        Me.Controls.Add(Me.OrangeGroupBox1)
        Me.Controls.Add(Me.btnreturn)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.tbsearch)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.pnheader)
        Me.Controls.Add(Me.btnclear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReturnBooks"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReturn"
        Me.pnheader.ResumeLayout(False)
        Me.pnheader.PerformLayout()
        Me.OrangeGroupBox1.ResumeLayout(False)
        Me.OrangeGroupBox1.PerformLayout()
        Me.OrangeGroupBox2.ResumeLayout(False)
        Me.OrangeGroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnheader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents lblissuance As gLabel.gLabel
    Friend WithEvents lblidx As gLabel.gLabel
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As LibSys.GhostButton
    Friend WithEvents lblisid As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents GLabel1 As gLabel.gLabel
    Friend WithEvents lbldueborrow As System.Windows.Forms.Label
    Friend WithEvents GLabel6 As gLabel.gLabel
    Friend WithEvents lblmember As System.Windows.Forms.Label
    Friend WithEvents GLabel8 As gLabel.gLabel
    Friend WithEvents tbrem As System.Windows.Forms.TextBox
    Friend WithEvents lblrem As gLabel.gLabel
    Friend WithEvents lblfine As gLabel.gLabel
    Friend WithEvents lbldate As gLabel.gLabel
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnrefresh As LibSys.GhostButton
    Friend WithEvents btnreturn As LibSys.GhostButton
    Friend WithEvents btnclear As LibSys.GhostButton
    Friend WithEvents cbofine As System.Windows.Forms.ComboBox
    Friend WithEvents lblidbook As System.Windows.Forms.Label
    Friend WithEvents GLabel2 As gLabel.gLabel
    Friend WithEvents lbldatebor As System.Windows.Forms.Label
    Friend WithEvents GLabel3 As gLabel.gLabel
    Friend WithEvents SlcClose1 As LibSys.SLCClose
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OrangeGroupBox1 As LibSys.OrangeGroupBox
    Friend WithEvents OrangeGroupBox2 As LibSys.OrangeGroupBox
    Friend WithEvents OrangeSeperator3 As LibSys.OrangeSeperator
End Class
