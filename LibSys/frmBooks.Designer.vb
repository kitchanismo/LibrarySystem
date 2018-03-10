<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooks
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
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbltot = New System.Windows.Forms.Label()
        Me.lblis = New System.Windows.Forms.Label()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.GLabel1 = New gLabel.gLabel()
        Me.lblpub = New System.Windows.Forms.Label()
        Me.lblpublisher = New System.Windows.Forms.Label()
        Me.lblven = New System.Windows.Forms.Label()
        Me.lblaut = New System.Windows.Forms.Label()
        Me.lblcat = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.sdrgrg = New gLabel.gLabel()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.xcxcxcc = New gLabel.gLabel()
        Me.lblvendor = New gLabel.gLabel()
        Me.lbldate = New gLabel.gLabel()
        Me.df = New gLabel.gLabel()
        Me.lblidx = New gLabel.gLabel()
        Me.asds = New gLabel.gLabel()
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.GhostButton2 = New LibSys.GhostButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OrangeGroupBox1 = New LibSys.OrangeGroupBox()
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
        Me.pnheader.Size = New System.Drawing.Size(723, 35)
        Me.pnheader.TabIndex = 1
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New LibSys.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(696, 8)
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
        Me.Label1.Size = New System.Drawing.Size(52, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Books"
        '
        'lv
        '
        Me.lv.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv.ForeColor = System.Drawing.Color.Gainsboro
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.Location = New System.Drawing.Point(10, 76)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(435, 373)
        Me.lv.TabIndex = 16
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
        'lbltot
        '
        Me.lbltot.AutoSize = True
        Me.lbltot.BackColor = System.Drawing.Color.Transparent
        Me.lbltot.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltot.Location = New System.Drawing.Point(97, 374)
        Me.lbltot.Name = "lbltot"
        Me.lbltot.Size = New System.Drawing.Size(17, 17)
        Me.lbltot.TabIndex = 40
        Me.lbltot.Text = "..."
        '
        'lblis
        '
        Me.lblis.AutoSize = True
        Me.lblis.BackColor = System.Drawing.Color.Transparent
        Me.lblis.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblis.Location = New System.Drawing.Point(54, 374)
        Me.lblis.Name = "lblis"
        Me.lblis.Size = New System.Drawing.Size(17, 17)
        Me.lblis.TabIndex = 39
        Me.lblis.Text = "..."
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.BackColor = System.Drawing.Color.Transparent
        Me.lblqty.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblqty.Location = New System.Drawing.Point(16, 374)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(17, 17)
        Me.lblqty.TabIndex = 38
        Me.lblqty.Text = "..."
        '
        'GLabel1
        '
        Me.GLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel1.ForeColor = System.Drawing.Color.White
        Me.GLabel1.Glow = 6
        Me.GLabel1.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel1.GlowState = False
        Me.GLabel1.Location = New System.Drawing.Point(14, 350)
        Me.GLabel1.Name = "GLabel1"
        Me.GLabel1.Size = New System.Drawing.Size(192, 21)
        Me.GLabel1.TabIndex = 37
        Me.GLabel1.Text = "Available/Issued/Total Books"
        Me.GLabel1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblpub
        '
        Me.lblpub.AutoSize = True
        Me.lblpub.BackColor = System.Drawing.Color.Transparent
        Me.lblpub.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblpub.Location = New System.Drawing.Point(16, 194)
        Me.lblpub.Name = "lblpub"
        Me.lblpub.Size = New System.Drawing.Size(17, 17)
        Me.lblpub.TabIndex = 36
        Me.lblpub.Text = "..."
        '
        'lblpublisher
        '
        Me.lblpublisher.AutoSize = True
        Me.lblpublisher.BackColor = System.Drawing.Color.Transparent
        Me.lblpublisher.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpublisher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblpublisher.Location = New System.Drawing.Point(16, 329)
        Me.lblpublisher.Name = "lblpublisher"
        Me.lblpublisher.Size = New System.Drawing.Size(17, 17)
        Me.lblpublisher.TabIndex = 35
        Me.lblpublisher.Text = "..."
        '
        'lblven
        '
        Me.lblven.AutoSize = True
        Me.lblven.BackColor = System.Drawing.Color.Transparent
        Me.lblven.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblven.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblven.Location = New System.Drawing.Point(16, 152)
        Me.lblven.Name = "lblven"
        Me.lblven.Size = New System.Drawing.Size(17, 17)
        Me.lblven.TabIndex = 34
        Me.lblven.Text = "..."
        '
        'lblaut
        '
        Me.lblaut.AutoSize = True
        Me.lblaut.BackColor = System.Drawing.Color.Transparent
        Me.lblaut.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblaut.Location = New System.Drawing.Point(16, 280)
        Me.lblaut.Name = "lblaut"
        Me.lblaut.Size = New System.Drawing.Size(17, 17)
        Me.lblaut.TabIndex = 33
        Me.lblaut.Text = "..."
        '
        'lblcat
        '
        Me.lblcat.AutoSize = True
        Me.lblcat.BackColor = System.Drawing.Color.Transparent
        Me.lblcat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblcat.Location = New System.Drawing.Point(16, 105)
        Me.lblcat.Name = "lblcat"
        Me.lblcat.Size = New System.Drawing.Size(17, 17)
        Me.lblcat.TabIndex = 32
        Me.lblcat.Text = "..."
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltitle.Location = New System.Drawing.Point(16, 241)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(17, 17)
        Me.lbltitle.TabIndex = 31
        Me.lbltitle.Text = "..."
        '
        'sdrgrg
        '
        Me.sdrgrg.BackColor = System.Drawing.Color.Transparent
        Me.sdrgrg.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sdrgrg.ForeColor = System.Drawing.Color.White
        Me.sdrgrg.Glow = 6
        Me.sdrgrg.GlowColor = System.Drawing.Color.DarkOrange
        Me.sdrgrg.GlowState = False
        Me.sdrgrg.Location = New System.Drawing.Point(14, 308)
        Me.sdrgrg.Name = "sdrgrg"
        Me.sdrgrg.Size = New System.Drawing.Size(80, 21)
        Me.sdrgrg.TabIndex = 30
        Me.sdrgrg.Text = "Publisher"
        Me.sdrgrg.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.BackColor = System.Drawing.Color.Transparent
        Me.lblresult.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult.ForeColor = System.Drawing.Color.Silver
        Me.lblresult.Location = New System.Drawing.Point(194, 25)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(0, 17)
        Me.lblresult.TabIndex = 29
        Me.lblresult.Visible = False
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.BackColor = System.Drawing.Color.Transparent
        Me.lblid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblid.Location = New System.Drawing.Point(16, 62)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(17, 17)
        Me.lblid.TabIndex = 23
        Me.lblid.Text = "..."
        '
        'xcxcxcc
        '
        Me.xcxcxcc.BackColor = System.Drawing.Color.Transparent
        Me.xcxcxcc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xcxcxcc.ForeColor = System.Drawing.Color.White
        Me.xcxcxcc.Glow = 6
        Me.xcxcxcc.GlowColor = System.Drawing.Color.DarkOrange
        Me.xcxcxcc.GlowState = False
        Me.xcxcxcc.Location = New System.Drawing.Point(15, 219)
        Me.xcxcxcc.Name = "xcxcxcc"
        Me.xcxcxcc.Size = New System.Drawing.Size(91, 21)
        Me.xcxcxcc.TabIndex = 18
        Me.xcxcxcc.Text = "Book Title"
        Me.xcxcxcc.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblvendor
        '
        Me.lblvendor.BackColor = System.Drawing.Color.Transparent
        Me.lblvendor.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvendor.ForeColor = System.Drawing.Color.White
        Me.lblvendor.Glow = 6
        Me.lblvendor.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblvendor.GlowState = False
        Me.lblvendor.Location = New System.Drawing.Point(14, 131)
        Me.lblvendor.Name = "lblvendor"
        Me.lblvendor.Size = New System.Drawing.Size(91, 21)
        Me.lblvendor.TabIndex = 16
        Me.lblvendor.Text = "Sponsor"
        Me.lblvendor.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lbldate
        '
        Me.lbldate.BackColor = System.Drawing.Color.Transparent
        Me.lbldate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.White
        Me.lbldate.Glow = 6
        Me.lbldate.GlowColor = System.Drawing.Color.DarkOrange
        Me.lbldate.GlowState = False
        Me.lbldate.Location = New System.Drawing.Point(14, 173)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(91, 21)
        Me.lbldate.TabIndex = 15
        Me.lbldate.Text = "Publish Date"
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'df
        '
        Me.df.BackColor = System.Drawing.Color.Transparent
        Me.df.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.df.ForeColor = System.Drawing.Color.White
        Me.df.Glow = 6
        Me.df.GlowColor = System.Drawing.Color.DarkOrange
        Me.df.GlowState = False
        Me.df.Location = New System.Drawing.Point(15, 83)
        Me.df.Name = "df"
        Me.df.Size = New System.Drawing.Size(91, 21)
        Me.df.TabIndex = 12
        Me.df.Text = "Category"
        Me.df.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblidx
        '
        Me.lblidx.BackColor = System.Drawing.Color.Transparent
        Me.lblidx.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidx.ForeColor = System.Drawing.Color.White
        Me.lblidx.Glow = 6
        Me.lblidx.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblidx.GlowState = False
        Me.lblidx.Location = New System.Drawing.Point(16, 41)
        Me.lblidx.Name = "lblidx"
        Me.lblidx.Size = New System.Drawing.Size(41, 21)
        Me.lblidx.TabIndex = 10
        Me.lblidx.Text = "ID"
        Me.lblidx.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'asds
        '
        Me.asds.BackColor = System.Drawing.Color.Transparent
        Me.asds.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asds.ForeColor = System.Drawing.Color.White
        Me.asds.Glow = 6
        Me.asds.GlowColor = System.Drawing.Color.DarkOrange
        Me.asds.GlowState = False
        Me.asds.Location = New System.Drawing.Point(14, 260)
        Me.asds.Name = "asds"
        Me.asds.Size = New System.Drawing.Size(91, 21)
        Me.asds.TabIndex = 11
        Me.asds.Text = "Author"
        Me.asds.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'tbsearch
        '
        Me.tbsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbsearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbsearch.Location = New System.Drawing.Point(10, 43)
        Me.tbsearch.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbsearch.MaxLength = 30
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(435, 27)
        Me.tbsearch.TabIndex = 21
        Me.tbsearch.Text = " Search ..."
        '
        'GhostButton2
        '
        Me.GhostButton2.Color = System.Drawing.Color.Empty
        Me.GhostButton2.Colors = New LibSys.Bloom(-1) {}
        Me.GhostButton2.Customization = ""
        Me.GhostButton2.EnableGlass = True
        Me.GhostButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.GhostButton2.Image = Nothing
        Me.GhostButton2.Location = New System.Drawing.Point(382, 44)
        Me.GhostButton2.Name = "GhostButton2"
        Me.GhostButton2.NoRounding = False
        Me.GhostButton2.Size = New System.Drawing.Size(63, 25)
        Me.GhostButton2.TabIndex = 23
        Me.GhostButton2.Text = "Refresh"
        Me.GhostButton2.Transparent = False
        '
        'OrangeGroupBox1
        '
        Me.OrangeGroupBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.OrangeGroupBox1.Controls.Add(Me.lbltot)
        Me.OrangeGroupBox1.Controls.Add(Me.lbldate)
        Me.OrangeGroupBox1.Controls.Add(Me.lblis)
        Me.OrangeGroupBox1.Controls.Add(Me.asds)
        Me.OrangeGroupBox1.Controls.Add(Me.lblqty)
        Me.OrangeGroupBox1.Controls.Add(Me.lblidx)
        Me.OrangeGroupBox1.Controls.Add(Me.GLabel1)
        Me.OrangeGroupBox1.Controls.Add(Me.df)
        Me.OrangeGroupBox1.Controls.Add(Me.lblpub)
        Me.OrangeGroupBox1.Controls.Add(Me.lblvendor)
        Me.OrangeGroupBox1.Controls.Add(Me.lblpublisher)
        Me.OrangeGroupBox1.Controls.Add(Me.xcxcxcc)
        Me.OrangeGroupBox1.Controls.Add(Me.lblven)
        Me.OrangeGroupBox1.Controls.Add(Me.lblid)
        Me.OrangeGroupBox1.Controls.Add(Me.lblaut)
        Me.OrangeGroupBox1.Controls.Add(Me.lblresult)
        Me.OrangeGroupBox1.Controls.Add(Me.lblcat)
        Me.OrangeGroupBox1.Controls.Add(Me.sdrgrg)
        Me.OrangeGroupBox1.Controls.Add(Me.lbltitle)
        Me.OrangeGroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.OrangeGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.OrangeGroupBox1.Location = New System.Drawing.Point(451, 43)
        Me.OrangeGroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.OrangeGroupBox1.Name = "OrangeGroupBox1"
        Me.OrangeGroupBox1.Size = New System.Drawing.Size(261, 407)
        Me.OrangeGroupBox1.TabIndex = 28
        Me.OrangeGroupBox1.Text = "Book Details"
        Me.OrangeGroupBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'frmBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(721, 459)
        Me.Controls.Add(Me.OrangeGroupBox1)
        Me.Controls.Add(Me.GhostButton2)
        Me.Controls.Add(Me.tbsearch)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.pnheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBooks"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "v"
        Me.pnheader.ResumeLayout(False)
        Me.pnheader.PerformLayout()
        Me.OrangeGroupBox1.ResumeLayout(False)
        Me.OrangeGroupBox1.PerformLayout()
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
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblpub As System.Windows.Forms.Label
    Friend WithEvents lblpublisher As System.Windows.Forms.Label
    Friend WithEvents lblven As System.Windows.Forms.Label
    Friend WithEvents lblaut As System.Windows.Forms.Label
    Friend WithEvents lblcat As System.Windows.Forms.Label
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents sdrgrg As gLabel.gLabel
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents xcxcxcc As gLabel.gLabel
    Friend WithEvents lblvendor As gLabel.gLabel
    Friend WithEvents lbldate As gLabel.gLabel
    Friend WithEvents df As gLabel.gLabel
    Friend WithEvents lblidx As gLabel.gLabel
    Friend WithEvents asds As gLabel.gLabel
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents GLabel1 As gLabel.gLabel
    Friend WithEvents GhostButton2 As LibSys.GhostButton
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbltot As System.Windows.Forms.Label
    Friend WithEvents lblis As System.Windows.Forms.Label
    Friend WithEvents SlcClose1 As LibSys.SLCClose
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OrangeGroupBox1 As LibSys.OrangeGroupBox
End Class
