<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookMaint
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
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.btnsearch = New LibSys.GhostButton()
        Me.btnedit = New LibSys.GhostButton()
        Me.btndelete = New LibSys.GhostButton()
        Me.btnclear = New LibSys.GhostButton()
        Me.btnrefresh = New LibSys.GhostButton()
        Me.btnadd = New LibSys.GhostButton()
        Me.tbis = New System.Windows.Forms.TextBox()
        Me.tbtot = New System.Windows.Forms.TextBox()
        Me.tbavai = New System.Windows.Forms.TextBox()
        Me.lblqty = New gLabel.gLabel()
        Me.cbopub = New System.Windows.Forms.ComboBox()
        Me.btnpub = New LibSys.GhostButton()
        Me.lblpublisher = New gLabel.gLabel()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.cboven = New System.Windows.Forms.ComboBox()
        Me.cboaut = New System.Windows.Forms.ComboBox()
        Me.cbocat = New System.Windows.Forms.ComboBox()
        Me.btnven = New LibSys.GhostButton()
        Me.btnaut = New LibSys.GhostButton()
        Me.btncat = New LibSys.GhostButton()
        Me.lblid = New System.Windows.Forms.Label()
        Me.dtppub = New System.Windows.Forms.DateTimePicker()
        Me.lbltitle = New gLabel.gLabel()
        Me.tbtitle = New System.Windows.Forms.TextBox()
        Me.lblvendor = New gLabel.gLabel()
        Me.lbldate = New gLabel.gLabel()
        Me.lblcat = New gLabel.gLabel()
        Me.lblidx = New gLabel.gLabel()
        Me.lblaut = New gLabel.gLabel()
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
        Me.pnheader.Size = New System.Drawing.Size(792, 35)
        Me.pnheader.TabIndex = 0
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New LibSys.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(764, 8)
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
        Me.Label1.Size = New System.Drawing.Size(138, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Maintenance"
        '
        'lv
        '
        Me.lv.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv.ForeColor = System.Drawing.Color.Gainsboro
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.Location = New System.Drawing.Point(11, 80)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(466, 384)
        Me.lv.TabIndex = 15
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
        'tbsearch
        '
        Me.tbsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbsearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbsearch.Location = New System.Drawing.Point(11, 48)
        Me.tbsearch.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbsearch.MaxLength = 30
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(466, 27)
        Me.tbsearch.TabIndex = 19
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
        Me.btnsearch.Location = New System.Drawing.Point(445, 49)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.NoRounding = False
        Me.btnsearch.Size = New System.Drawing.Size(32, 25)
        Me.btnsearch.TabIndex = 20
        Me.btnsearch.Text = "Q"
        Me.btnsearch.Transparent = False
        '
        'btnedit
        '
        Me.btnedit.Color = System.Drawing.Color.Empty
        Me.btnedit.Colors = New LibSys.Bloom(-1) {}
        Me.btnedit.Customization = ""
        Me.btnedit.EnableGlass = True
        Me.btnedit.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnedit.Image = Nothing
        Me.btnedit.Location = New System.Drawing.Point(106, 470)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.NoRounding = False
        Me.btnedit.Size = New System.Drawing.Size(83, 32)
        Me.btnedit.TabIndex = 19
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
        Me.btndelete.Location = New System.Drawing.Point(202, 470)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.NoRounding = False
        Me.btndelete.Size = New System.Drawing.Size(83, 32)
        Me.btndelete.TabIndex = 18
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
        Me.btnclear.Location = New System.Drawing.Point(298, 470)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.NoRounding = False
        Me.btnclear.Size = New System.Drawing.Size(83, 32)
        Me.btnclear.TabIndex = 17
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
        Me.btnrefresh.Location = New System.Drawing.Point(394, 470)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.NoRounding = False
        Me.btnrefresh.Size = New System.Drawing.Size(83, 32)
        Me.btnrefresh.TabIndex = 16
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.Transparent = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnadd.Color = System.Drawing.Color.Empty
        Me.btnadd.Colors = New LibSys.Bloom(-1) {}
        Me.btnadd.Customization = ""
        Me.btnadd.EnableGlass = True
        Me.btnadd.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnadd.Image = Nothing
        Me.btnadd.Location = New System.Drawing.Point(11, 470)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.NoRounding = False
        Me.btnadd.Size = New System.Drawing.Size(83, 32)
        Me.btnadd.TabIndex = 13
        Me.btnadd.Text = "Add"
        Me.btnadd.Transparent = False
        '
        'tbis
        '
        Me.tbis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbis.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbis.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbis.Location = New System.Drawing.Point(208, 403)
        Me.tbis.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbis.MaxLength = 3
        Me.tbis.Name = "tbis"
        Me.tbis.Size = New System.Drawing.Size(32, 25)
        Me.tbis.TabIndex = 36
        '
        'tbtot
        '
        Me.tbtot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbtot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbtot.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbtot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbtot.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbtot.Location = New System.Drawing.Point(246, 403)
        Me.tbtot.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbtot.MaxLength = 3
        Me.tbtot.Name = "tbtot"
        Me.tbtot.Size = New System.Drawing.Size(32, 25)
        Me.tbtot.TabIndex = 35
        '
        'tbavai
        '
        Me.tbavai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbavai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbavai.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbavai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbavai.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbavai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbavai.Location = New System.Drawing.Point(169, 403)
        Me.tbavai.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbavai.MaxLength = 3
        Me.tbavai.Name = "tbavai"
        Me.tbavai.Size = New System.Drawing.Size(32, 25)
        Me.tbavai.TabIndex = 34
        '
        'lblqty
        '
        Me.lblqty.BackColor = System.Drawing.Color.Transparent
        Me.lblqty.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.ForeColor = System.Drawing.Color.White
        Me.lblqty.Glow = 6
        Me.lblqty.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblqty.GlowState = False
        Me.lblqty.Location = New System.Drawing.Point(162, 379)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(127, 21)
        Me.lblqty.TabIndex = 33
        Me.lblqty.Text = "Avail/Issued/Total"
        Me.lblqty.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cbopub
        '
        Me.cbopub.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cbopub.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbopub.ForeColor = System.Drawing.Color.Silver
        Me.cbopub.FormattingEnabled = True
        Me.cbopub.Location = New System.Drawing.Point(19, 345)
        Me.cbopub.Name = "cbopub"
        Me.cbopub.Size = New System.Drawing.Size(216, 28)
        Me.cbopub.TabIndex = 32
        Me.cbopub.Text = " ..."
        '
        'btnpub
        '
        Me.btnpub.Color = System.Drawing.Color.Empty
        Me.btnpub.Colors = New LibSys.Bloom(-1) {}
        Me.btnpub.Customization = ""
        Me.btnpub.EnableGlass = True
        Me.btnpub.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnpub.Image = Nothing
        Me.btnpub.Location = New System.Drawing.Point(241, 345)
        Me.btnpub.Name = "btnpub"
        Me.btnpub.NoRounding = False
        Me.btnpub.Size = New System.Drawing.Size(37, 26)
        Me.btnpub.TabIndex = 31
        Me.btnpub.Text = "..."
        Me.btnpub.Transparent = False
        '
        'lblpublisher
        '
        Me.lblpublisher.BackColor = System.Drawing.Color.Transparent
        Me.lblpublisher.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpublisher.ForeColor = System.Drawing.Color.White
        Me.lblpublisher.Glow = 6
        Me.lblpublisher.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblpublisher.GlowState = False
        Me.lblpublisher.Location = New System.Drawing.Point(14, 321)
        Me.lblpublisher.Name = "lblpublisher"
        Me.lblpublisher.Size = New System.Drawing.Size(80, 21)
        Me.lblpublisher.TabIndex = 30
        Me.lblpublisher.Text = "Publisher"
        Me.lblpublisher.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.BackColor = System.Drawing.Color.Transparent
        Me.lblresult.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult.ForeColor = System.Drawing.Color.Silver
        Me.lblresult.Location = New System.Drawing.Point(179, 67)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(0, 17)
        Me.lblresult.TabIndex = 29
        Me.lblresult.Visible = False
        '
        'cboven
        '
        Me.cboven.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cboven.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboven.ForeColor = System.Drawing.Color.Silver
        Me.cboven.FormattingEnabled = True
        Me.cboven.Location = New System.Drawing.Point(20, 289)
        Me.cboven.Name = "cboven"
        Me.cboven.Size = New System.Drawing.Size(216, 28)
        Me.cboven.TabIndex = 28
        Me.cboven.Text = " ..."
        '
        'cboaut
        '
        Me.cboaut.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cboaut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboaut.ForeColor = System.Drawing.Color.Silver
        Me.cboaut.FormattingEnabled = True
        Me.cboaut.Location = New System.Drawing.Point(19, 234)
        Me.cboaut.Name = "cboaut"
        Me.cboaut.Size = New System.Drawing.Size(216, 28)
        Me.cboaut.TabIndex = 27
        Me.cboaut.Text = " ..."
        '
        'cbocat
        '
        Me.cbocat.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cbocat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbocat.ForeColor = System.Drawing.Color.Silver
        Me.cbocat.FormattingEnabled = True
        Me.cbocat.Location = New System.Drawing.Point(20, 176)
        Me.cbocat.Name = "cbocat"
        Me.cbocat.Size = New System.Drawing.Size(216, 28)
        Me.cbocat.TabIndex = 26
        Me.cbocat.Text = " ..."
        '
        'btnven
        '
        Me.btnven.Color = System.Drawing.Color.Empty
        Me.btnven.Colors = New LibSys.Bloom(-1) {}
        Me.btnven.Customization = ""
        Me.btnven.EnableGlass = True
        Me.btnven.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnven.Image = Nothing
        Me.btnven.Location = New System.Drawing.Point(242, 289)
        Me.btnven.Name = "btnven"
        Me.btnven.NoRounding = False
        Me.btnven.Size = New System.Drawing.Size(37, 26)
        Me.btnven.TabIndex = 25
        Me.btnven.Text = "..."
        Me.btnven.Transparent = False
        '
        'btnaut
        '
        Me.btnaut.Color = System.Drawing.Color.Empty
        Me.btnaut.Colors = New LibSys.Bloom(-1) {}
        Me.btnaut.Customization = ""
        Me.btnaut.EnableGlass = True
        Me.btnaut.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnaut.Image = Nothing
        Me.btnaut.Location = New System.Drawing.Point(242, 233)
        Me.btnaut.Name = "btnaut"
        Me.btnaut.NoRounding = False
        Me.btnaut.Size = New System.Drawing.Size(37, 26)
        Me.btnaut.TabIndex = 24
        Me.btnaut.Text = "..."
        Me.btnaut.Transparent = False
        '
        'btncat
        '
        Me.btncat.Color = System.Drawing.Color.Empty
        Me.btncat.Colors = New LibSys.Bloom(-1) {}
        Me.btncat.Customization = ""
        Me.btncat.EnableGlass = True
        Me.btncat.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btncat.Image = Nothing
        Me.btncat.Location = New System.Drawing.Point(242, 176)
        Me.btncat.Name = "btncat"
        Me.btncat.NoRounding = False
        Me.btncat.Size = New System.Drawing.Size(37, 26)
        Me.btncat.TabIndex = 21
        Me.btncat.Text = "..."
        Me.btncat.Transparent = False
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.BackColor = System.Drawing.Color.Transparent
        Me.lblid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblid.Location = New System.Drawing.Point(16, 67)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(17, 17)
        Me.lblid.TabIndex = 23
        Me.lblid.Text = "..."
        '
        'dtppub
        '
        Me.dtppub.CalendarMonthBackground = System.Drawing.Color.Red
        Me.dtppub.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtppub.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtppub.Location = New System.Drawing.Point(18, 401)
        Me.dtppub.Name = "dtppub"
        Me.dtppub.Size = New System.Drawing.Size(121, 27)
        Me.dtppub.TabIndex = 22
        '
        'lbltitle
        '
        Me.lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.lbltitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.White
        Me.lbltitle.Glow = 6
        Me.lbltitle.GlowColor = System.Drawing.Color.DarkOrange
        Me.lbltitle.GlowState = False
        Me.lbltitle.Location = New System.Drawing.Point(16, 96)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(91, 21)
        Me.lbltitle.TabIndex = 18
        Me.lbltitle.Text = "Book Title"
        Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'tbtitle
        '
        Me.tbtitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbtitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbtitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbtitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbtitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbtitle.Location = New System.Drawing.Point(19, 120)
        Me.tbtitle.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbtitle.MaxLength = 100
        Me.tbtitle.Name = "tbtitle"
        Me.tbtitle.Size = New System.Drawing.Size(260, 25)
        Me.tbtitle.TabIndex = 17
        '
        'lblvendor
        '
        Me.lblvendor.BackColor = System.Drawing.Color.Transparent
        Me.lblvendor.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvendor.ForeColor = System.Drawing.Color.White
        Me.lblvendor.Glow = 6
        Me.lblvendor.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblvendor.GlowState = False
        Me.lblvendor.Location = New System.Drawing.Point(15, 265)
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
        Me.lbldate.Location = New System.Drawing.Point(16, 379)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(91, 21)
        Me.lbldate.TabIndex = 15
        Me.lbldate.Text = "Publish Date"
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblcat
        '
        Me.lblcat.BackColor = System.Drawing.Color.Transparent
        Me.lblcat.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcat.ForeColor = System.Drawing.Color.White
        Me.lblcat.Glow = 6
        Me.lblcat.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblcat.GlowState = False
        Me.lblcat.Location = New System.Drawing.Point(16, 152)
        Me.lblcat.Name = "lblcat"
        Me.lblcat.Size = New System.Drawing.Size(91, 21)
        Me.lblcat.TabIndex = 12
        Me.lblcat.Text = "Category"
        Me.lblcat.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblidx
        '
        Me.lblidx.BackColor = System.Drawing.Color.Transparent
        Me.lblidx.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidx.ForeColor = System.Drawing.Color.White
        Me.lblidx.Glow = 6
        Me.lblidx.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblidx.GlowState = False
        Me.lblidx.Location = New System.Drawing.Point(16, 42)
        Me.lblidx.Name = "lblidx"
        Me.lblidx.Size = New System.Drawing.Size(91, 21)
        Me.lblidx.TabIndex = 10
        Me.lblidx.Text = "ID"
        Me.lblidx.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'lblaut
        '
        Me.lblaut.BackColor = System.Drawing.Color.Transparent
        Me.lblaut.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaut.ForeColor = System.Drawing.Color.White
        Me.lblaut.Glow = 6
        Me.lblaut.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblaut.GlowState = False
        Me.lblaut.Location = New System.Drawing.Point(15, 210)
        Me.lblaut.Name = "lblaut"
        Me.lblaut.Size = New System.Drawing.Size(91, 21)
        Me.lblaut.TabIndex = 11
        Me.lblaut.Text = "Author"
        Me.lblaut.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'groupbook
        '
        Me.groupbook.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.groupbook.Controls.Add(Me.tbis)
        Me.groupbook.Controls.Add(Me.cbocat)
        Me.groupbook.Controls.Add(Me.tbtot)
        Me.groupbook.Controls.Add(Me.lblaut)
        Me.groupbook.Controls.Add(Me.tbavai)
        Me.groupbook.Controls.Add(Me.lblidx)
        Me.groupbook.Controls.Add(Me.lblqty)
        Me.groupbook.Controls.Add(Me.lblcat)
        Me.groupbook.Controls.Add(Me.cbopub)
        Me.groupbook.Controls.Add(Me.lbldate)
        Me.groupbook.Controls.Add(Me.btnpub)
        Me.groupbook.Controls.Add(Me.lblvendor)
        Me.groupbook.Controls.Add(Me.lblpublisher)
        Me.groupbook.Controls.Add(Me.tbtitle)
        Me.groupbook.Controls.Add(Me.lblresult)
        Me.groupbook.Controls.Add(Me.lbltitle)
        Me.groupbook.Controls.Add(Me.cboven)
        Me.groupbook.Controls.Add(Me.dtppub)
        Me.groupbook.Controls.Add(Me.cboaut)
        Me.groupbook.Controls.Add(Me.lblid)
        Me.groupbook.Controls.Add(Me.btncat)
        Me.groupbook.Controls.Add(Me.btnven)
        Me.groupbook.Controls.Add(Me.btnaut)
        Me.groupbook.Enabled = False
        Me.groupbook.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.groupbook.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.groupbook.Location = New System.Drawing.Point(485, 48)
        Me.groupbook.MainColour = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.groupbook.Name = "groupbook"
        Me.groupbook.Size = New System.Drawing.Size(296, 454)
        Me.groupbook.TabIndex = 27
        Me.groupbook.Text = "Book Details"
        Me.groupbook.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'frmBookMaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 515)
        Me.Controls.Add(Me.groupbook)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.tbsearch)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.pnheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBookMaint"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBookMaint"
        Me.pnheader.ResumeLayout(False)
        Me.pnheader.PerformLayout()
        Me.groupbook.ResumeLayout(False)
        Me.groupbook.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnheader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnadd As LibSys.GhostButton
    Friend WithEvents lblaut As gLabel.gLabel
    Friend WithEvents lblvendor As gLabel.gLabel
    Friend WithEvents lbldate As gLabel.gLabel
    Friend WithEvents lblcat As gLabel.gLabel
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbltitle As gLabel.gLabel
    Friend WithEvents btnven As LibSys.GhostButton
    Friend WithEvents btnaut As LibSys.GhostButton
    Friend WithEvents btncat As LibSys.GhostButton
    Friend WithEvents dtppub As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnrefresh As LibSys.GhostButton
    Friend WithEvents btnclear As LibSys.GhostButton
    Friend WithEvents btndelete As LibSys.GhostButton
    Friend WithEvents btnedit As LibSys.GhostButton
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As LibSys.GhostButton
    Friend WithEvents cboven As System.Windows.Forms.ComboBox
    Friend WithEvents cboaut As System.Windows.Forms.ComboBox
    Friend WithEvents cbocat As System.Windows.Forms.ComboBox
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents lblidx As gLabel.gLabel
    Friend WithEvents cbopub As System.Windows.Forms.ComboBox
    Friend WithEvents btnpub As LibSys.GhostButton
    Friend WithEvents lblpublisher As gLabel.gLabel
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tbtitle As System.Windows.Forms.TextBox
    Friend WithEvents lblqty As gLabel.gLabel
    Friend WithEvents tbavai As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tbis As System.Windows.Forms.TextBox
    Friend WithEvents tbtot As System.Windows.Forms.TextBox
    Friend WithEvents SlcClose1 As LibSys.SLCClose
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents groupbook As LibSys.OrangeGroupBox
End Class
