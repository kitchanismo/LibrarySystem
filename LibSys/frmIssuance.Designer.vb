<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIssuance
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
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.dtpdue = New System.Windows.Forms.DateTimePicker()
        Me.lblduedate = New gLabel.gLabel()
        Me.dtpdatebor = New System.Windows.Forms.DateTimePicker()
        Me.lbldatebor = New gLabel.gLabel()
        Me.lblidissue = New System.Windows.Forms.Label()
        Me.GLabel1 = New gLabel.gLabel()
        Me.lv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnclear = New LibSys.GhostButton()
        Me.btnsave = New LibSys.GhostButton()
        Me.btnrefresh = New LibSys.GhostButton()
        Me.lblis = New System.Windows.Forms.Label()
        Me.btnborrow = New LibSys.GhostButton()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.btnsearch = New LibSys.GhostButton()
        Me.lblissued = New System.Windows.Forms.Label()
        Me.lblavail = New System.Windows.Forms.Label()
        Me.GLabel2 = New gLabel.gLabel()
        Me.GLabel3 = New gLabel.gLabel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.labelx = New gLabel.gLabel()
        Me.lblxx = New gLabel.gLabel()
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
        Me.pnheader.Location = New System.Drawing.Point(0, -1)
        Me.pnheader.Name = "pnheader"
        Me.pnheader.Size = New System.Drawing.Size(709, 35)
        Me.pnheader.TabIndex = 1
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New LibSys.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(684, 8)
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
        Me.Label1.Size = New System.Drawing.Size(69, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Issuance"
        '
        'tbsearch
        '
        Me.tbsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbsearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbsearch.Location = New System.Drawing.Point(9, 42)
        Me.tbsearch.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbsearch.MaxLength = 30
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(393, 27)
        Me.tbsearch.TabIndex = 39
        Me.tbsearch.Text = " Search Book ..."
        '
        'dtpdue
        '
        Me.dtpdue.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdue.CalendarMonthBackground = System.Drawing.Color.Red
        Me.dtpdue.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdue.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdue.Location = New System.Drawing.Point(558, 345)
        Me.dtpdue.Name = "dtpdue"
        Me.dtpdue.Size = New System.Drawing.Size(142, 27)
        Me.dtpdue.TabIndex = 50
        '
        'lblduedate
        '
        Me.lblduedate.BackColor = System.Drawing.Color.Transparent
        Me.lblduedate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblduedate.ForeColor = System.Drawing.Color.White
        Me.lblduedate.Glow = 6
        Me.lblduedate.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblduedate.GlowState = False
        Me.lblduedate.Location = New System.Drawing.Point(554, 321)
        Me.lblduedate.Name = "lblduedate"
        Me.lblduedate.Size = New System.Drawing.Size(91, 21)
        Me.lblduedate.TabIndex = 49
        Me.lblduedate.Text = "Due Date"
        Me.lblduedate.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'dtpdatebor
        '
        Me.dtpdatebor.CalendarMonthBackground = System.Drawing.Color.Red
        Me.dtpdatebor.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdatebor.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdatebor.Location = New System.Drawing.Point(409, 345)
        Me.dtpdatebor.Name = "dtpdatebor"
        Me.dtpdatebor.Size = New System.Drawing.Size(142, 27)
        Me.dtpdatebor.TabIndex = 48
        '
        'lbldatebor
        '
        Me.lbldatebor.BackColor = System.Drawing.Color.Transparent
        Me.lbldatebor.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatebor.ForeColor = System.Drawing.Color.White
        Me.lbldatebor.Glow = 6
        Me.lbldatebor.GlowColor = System.Drawing.Color.DarkOrange
        Me.lbldatebor.GlowState = False
        Me.lbldatebor.Location = New System.Drawing.Point(407, 321)
        Me.lbldatebor.Name = "lbldatebor"
        Me.lbldatebor.Size = New System.Drawing.Size(91, 21)
        Me.lbldatebor.TabIndex = 47
        Me.lbldatebor.Text = "Date Borrow"
        Me.lbldatebor.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblidissue
        '
        Me.lblidissue.AutoSize = True
        Me.lblidissue.BackColor = System.Drawing.Color.Transparent
        Me.lblidissue.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidissue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblidissue.Location = New System.Drawing.Point(495, 48)
        Me.lblidissue.Name = "lblidissue"
        Me.lblidissue.Size = New System.Drawing.Size(18, 20)
        Me.lblidissue.TabIndex = 28
        Me.lblidissue.Text = "..."
        '
        'GLabel1
        '
        Me.GLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel1.ForeColor = System.Drawing.Color.White
        Me.GLabel1.Glow = 6
        Me.GLabel1.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel1.GlowState = False
        Me.GLabel1.Location = New System.Drawing.Point(409, 46)
        Me.GLabel1.Name = "GLabel1"
        Me.GLabel1.Size = New System.Drawing.Size(89, 21)
        Me.GLabel1.TabIndex = 28
        Me.GLabel1.Text = "Issuance ID:"
        Me.GLabel1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lv
        '
        Me.lv.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv.ForeColor = System.Drawing.Color.Gainsboro
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.Location = New System.Drawing.Point(9, 75)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(394, 348)
        Me.lv.TabIndex = 51
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
        Me.ColumnHeader2.Text = "Book Title"
        Me.ColumnHeader2.Width = 157
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Category"
        Me.ColumnHeader3.Width = 135
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Author"
        Me.ColumnHeader4.Width = 116
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Vendor"
        Me.ColumnHeader5.Width = 122
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Publisher"
        Me.ColumnHeader6.Width = 112
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Publish Date"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Available Books"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Issued Books"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Total Books"
        '
        'btnclear
        '
        Me.btnclear.Color = System.Drawing.Color.Empty
        Me.btnclear.Colors = New LibSys.Bloom(-1) {}
        Me.btnclear.Customization = ""
        Me.btnclear.EnableGlass = True
        Me.btnclear.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnclear.Image = Nothing
        Me.btnclear.Location = New System.Drawing.Point(604, 391)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.NoRounding = False
        Me.btnclear.Size = New System.Drawing.Size(83, 32)
        Me.btnclear.TabIndex = 43
        Me.btnclear.Text = "Clear"
        Me.btnclear.Transparent = False
        '
        'btnsave
        '
        Me.btnsave.Color = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsave.Colors = New LibSys.Bloom(-1) {}
        Me.btnsave.Customization = ""
        Me.btnsave.EnableGlass = True
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnsave.Image = Nothing
        Me.btnsave.Location = New System.Drawing.Point(513, 391)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.NoRounding = False
        Me.btnsave.Size = New System.Drawing.Size(83, 32)
        Me.btnsave.TabIndex = 42
        Me.btnsave.Text = "Save"
        Me.btnsave.Transparent = False
        '
        'btnrefresh
        '
        Me.btnrefresh.Color = System.Drawing.Color.Empty
        Me.btnrefresh.Colors = New LibSys.Bloom(-1) {}
        Me.btnrefresh.Customization = ""
        Me.btnrefresh.EnableGlass = True
        Me.btnrefresh.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnrefresh.Image = Nothing
        Me.btnrefresh.Location = New System.Drawing.Point(422, 391)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.NoRounding = False
        Me.btnrefresh.Size = New System.Drawing.Size(83, 32)
        Me.btnrefresh.TabIndex = 41
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.Transparent = False
        '
        'lblis
        '
        Me.lblis.AutoSize = True
        Me.lblis.BackColor = System.Drawing.Color.Transparent
        Me.lblis.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblis.Location = New System.Drawing.Point(206, 40)
        Me.lblis.Name = "lblis"
        Me.lblis.Size = New System.Drawing.Size(15, 17)
        Me.lblis.TabIndex = 29
        Me.lblis.Text = "0"
        Me.lblis.Visible = False
        '
        'btnborrow
        '
        Me.btnborrow.Color = System.Drawing.Color.Empty
        Me.btnborrow.Colors = New LibSys.Bloom(-1) {}
        Me.btnborrow.Customization = ""
        Me.btnborrow.EnableGlass = True
        Me.btnborrow.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrow.Image = Nothing
        Me.btnborrow.Location = New System.Drawing.Point(39, 66)
        Me.btnborrow.Name = "btnborrow"
        Me.btnborrow.NoRounding = False
        Me.btnborrow.Size = New System.Drawing.Size(216, 25)
        Me.btnborrow.TabIndex = 44
        Me.btnborrow.Text = "Click Here to Search Borrower"
        Me.btnborrow.Transparent = False
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.BackColor = System.Drawing.Color.Transparent
        Me.lblqty.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblqty.Location = New System.Drawing.Point(174, 40)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(15, 17)
        Me.lblqty.TabIndex = 28
        Me.lblqty.Text = "0"
        Me.lblqty.Visible = False
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.BackColor = System.Drawing.Color.Transparent
        Me.lblresult.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblresult.Location = New System.Drawing.Point(139, 40)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(15, 17)
        Me.lblresult.TabIndex = 27
        Me.lblresult.Text = "0"
        Me.lblresult.Visible = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblname.Location = New System.Drawing.Point(36, 40)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(17, 17)
        Me.lblname.TabIndex = 30
        Me.lblname.Text = "..."
        '
        'btnsearch
        '
        Me.btnsearch.Color = System.Drawing.Color.Empty
        Me.btnsearch.Colors = New LibSys.Bloom(-1) {}
        Me.btnsearch.Customization = ""
        Me.btnsearch.EnableGlass = True
        Me.btnsearch.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnsearch.Image = Nothing
        Me.btnsearch.Location = New System.Drawing.Point(370, 43)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.NoRounding = False
        Me.btnsearch.Size = New System.Drawing.Size(32, 25)
        Me.btnsearch.TabIndex = 40
        Me.btnsearch.Text = "Q"
        Me.btnsearch.Transparent = False
        '
        'lblissued
        '
        Me.lblissued.AutoSize = True
        Me.lblissued.BackColor = System.Drawing.Color.Transparent
        Me.lblissued.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblissued.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblissued.Location = New System.Drawing.Point(181, 104)
        Me.lblissued.Name = "lblissued"
        Me.lblissued.Size = New System.Drawing.Size(17, 17)
        Me.lblissued.TabIndex = 30
        Me.lblissued.Text = "..."
        '
        'lblavail
        '
        Me.lblavail.AutoSize = True
        Me.lblavail.BackColor = System.Drawing.Color.Transparent
        Me.lblavail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblavail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblavail.Location = New System.Drawing.Point(180, 59)
        Me.lblavail.Name = "lblavail"
        Me.lblavail.Size = New System.Drawing.Size(17, 17)
        Me.lblavail.TabIndex = 29
        Me.lblavail.Text = "..."
        '
        'GLabel2
        '
        Me.GLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel2.ForeColor = System.Drawing.Color.White
        Me.GLabel2.Glow = 6
        Me.GLabel2.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel2.GlowState = False
        Me.GLabel2.Location = New System.Drawing.Point(180, 35)
        Me.GLabel2.Name = "GLabel2"
        Me.GLabel2.Size = New System.Drawing.Size(91, 21)
        Me.GLabel2.TabIndex = 28
        Me.GLabel2.Text = "Available"
        Me.GLabel2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'GLabel3
        '
        Me.GLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel3.ForeColor = System.Drawing.Color.White
        Me.GLabel3.Glow = 6
        Me.GLabel3.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel3.GlowState = False
        Me.GLabel3.Location = New System.Drawing.Point(180, 82)
        Me.GLabel3.Name = "GLabel3"
        Me.GLabel3.Size = New System.Drawing.Size(91, 21)
        Me.GLabel3.TabIndex = 27
        Me.GLabel3.Text = "Issued"
        Me.GLabel3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltitle.Location = New System.Drawing.Point(24, 104)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(17, 17)
        Me.lbltitle.TabIndex = 26
        Me.lbltitle.Text = "..."
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.BackColor = System.Drawing.Color.Transparent
        Me.lblid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblid.Location = New System.Drawing.Point(23, 59)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(17, 17)
        Me.lblid.TabIndex = 25
        Me.lblid.Text = "..."
        '
        'labelx
        '
        Me.labelx.BackColor = System.Drawing.Color.Transparent
        Me.labelx.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelx.ForeColor = System.Drawing.Color.White
        Me.labelx.Glow = 6
        Me.labelx.GlowColor = System.Drawing.Color.DarkOrange
        Me.labelx.GlowState = False
        Me.labelx.Location = New System.Drawing.Point(23, 35)
        Me.labelx.Name = "labelx"
        Me.labelx.Size = New System.Drawing.Size(91, 21)
        Me.labelx.TabIndex = 24
        Me.labelx.Text = "ID"
        Me.labelx.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblxx
        '
        Me.lblxx.BackColor = System.Drawing.Color.Transparent
        Me.lblxx.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblxx.ForeColor = System.Drawing.Color.White
        Me.lblxx.Glow = 6
        Me.lblxx.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblxx.GlowState = False
        Me.lblxx.Location = New System.Drawing.Point(23, 82)
        Me.lblxx.Name = "lblxx"
        Me.lblxx.Size = New System.Drawing.Size(91, 21)
        Me.lblxx.TabIndex = 20
        Me.lblxx.Text = "Title"
        Me.lblxx.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'OrangeGroupBox1
        '
        Me.OrangeGroupBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.OrangeGroupBox1.Controls.Add(Me.OrangeSeperator3)
        Me.OrangeGroupBox1.Controls.Add(Me.lblissued)
        Me.OrangeGroupBox1.Controls.Add(Me.labelx)
        Me.OrangeGroupBox1.Controls.Add(Me.lblavail)
        Me.OrangeGroupBox1.Controls.Add(Me.lblxx)
        Me.OrangeGroupBox1.Controls.Add(Me.GLabel2)
        Me.OrangeGroupBox1.Controls.Add(Me.lblid)
        Me.OrangeGroupBox1.Controls.Add(Me.GLabel3)
        Me.OrangeGroupBox1.Controls.Add(Me.lbltitle)
        Me.OrangeGroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.OrangeGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.OrangeGroupBox1.Location = New System.Drawing.Point(409, 75)
        Me.OrangeGroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.OrangeGroupBox1.Name = "OrangeGroupBox1"
        Me.OrangeGroupBox1.Size = New System.Drawing.Size(291, 132)
        Me.OrangeGroupBox1.TabIndex = 52
        Me.OrangeGroupBox1.Text = "Book Details"
        Me.OrangeGroupBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'OrangeSeperator3
        '
        Me.OrangeSeperator3.Alignment = LibSys.OrangeSeperator.Style.Verticle
        Me.OrangeSeperator3.BackColor = System.Drawing.Color.Transparent
        Me.OrangeSeperator3.Location = New System.Drawing.Point(138, 42)
        Me.OrangeSeperator3.Name = "OrangeSeperator3"
        Me.OrangeSeperator3.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.OrangeSeperator3.Size = New System.Drawing.Size(12, 75)
        Me.OrangeSeperator3.TabIndex = 70
        Me.OrangeSeperator3.Text = "OrangeSeperator3"
        Me.OrangeSeperator3.Thickness = 1.0!
        '
        'OrangeGroupBox2
        '
        Me.OrangeGroupBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.OrangeGroupBox2.Controls.Add(Me.lblis)
        Me.OrangeGroupBox2.Controls.Add(Me.btnborrow)
        Me.OrangeGroupBox2.Controls.Add(Me.lblname)
        Me.OrangeGroupBox2.Controls.Add(Me.lblqty)
        Me.OrangeGroupBox2.Controls.Add(Me.lblresult)
        Me.OrangeGroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.OrangeGroupBox2.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.OrangeGroupBox2.Location = New System.Drawing.Point(409, 214)
        Me.OrangeGroupBox2.MainColour = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.OrangeGroupBox2.Name = "OrangeGroupBox2"
        Me.OrangeGroupBox2.Size = New System.Drawing.Size(291, 102)
        Me.OrangeGroupBox2.TabIndex = 53
        Me.OrangeGroupBox2.Text = "Borrower Name"
        Me.OrangeGroupBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'frmIssuance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(709, 434)
        Me.Controls.Add(Me.OrangeGroupBox2)
        Me.Controls.Add(Me.OrangeGroupBox1)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.GLabel1)
        Me.Controls.Add(Me.lblidissue)
        Me.Controls.Add(Me.dtpdue)
        Me.Controls.Add(Me.lblduedate)
        Me.Controls.Add(Me.dtpdatebor)
        Me.Controls.Add(Me.lbldatebor)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.tbsearch)
        Me.Controls.Add(Me.pnheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIssuance"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIssuance"
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
    Friend WithEvents btnsearch As LibSys.GhostButton
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnrefresh As LibSys.GhostButton
    Friend WithEvents btnsave As LibSys.GhostButton
    Friend WithEvents btnclear As LibSys.GhostButton
    Friend WithEvents lblxx As gLabel.gLabel
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents labelx As gLabel.gLabel
    Friend WithEvents btnborrow As LibSys.GhostButton
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents dtpdue As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblduedate As gLabel.gLabel
    Friend WithEvents dtpdatebor As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldatebor As gLabel.gLabel
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents lblidissue As System.Windows.Forms.Label
    Friend WithEvents GLabel1 As gLabel.gLabel
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblis As System.Windows.Forms.Label
    Friend WithEvents lblissued As System.Windows.Forms.Label
    Friend WithEvents lblavail As System.Windows.Forms.Label
    Friend WithEvents GLabel2 As gLabel.gLabel
    Friend WithEvents GLabel3 As gLabel.gLabel
    Friend WithEvents SlcClose1 As LibSys.SLCClose
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OrangeGroupBox1 As LibSys.OrangeGroupBox
    Friend WithEvents OrangeGroupBox2 As LibSys.OrangeGroupBox
    Friend WithEvents OrangeSeperator3 As LibSys.OrangeSeperator
End Class
