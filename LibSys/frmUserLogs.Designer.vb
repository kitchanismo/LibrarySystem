<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserLogs
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
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnrefresh = New LibSys.GhostButton()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.cbodatelog = New System.Windows.Forms.ComboBox()
        Me.GLabel11 = New gLabel.gLabel()
        Me.OrangeGroupBox1 = New LibSys.OrangeGroupBox()
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
        Me.pnheader.Size = New System.Drawing.Size(704, 35)
        Me.pnheader.TabIndex = 2
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New LibSys.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(613, 8)
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
        Me.Label1.Size = New System.Drawing.Size(79, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Logs"
        '
        'lv
        '
        Me.lv.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv.ForeColor = System.Drawing.Color.Gainsboro
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.Location = New System.Drawing.Point(8, 150)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(620, 243)
        Me.lv.TabIndex = 61
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
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
        Me.ColumnHeader11.Width = 68
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Baggage No."
        Me.ColumnHeader12.Width = 84
        '
        'btnrefresh
        '
        Me.btnrefresh.Color = System.Drawing.Color.Empty
        Me.btnrefresh.Colors = New LibSys.Bloom(-1) {}
        Me.btnrefresh.Customization = ""
        Me.btnrefresh.EnableGlass = True
        Me.btnrefresh.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnrefresh.Image = Nothing
        Me.btnrefresh.Location = New System.Drawing.Point(547, 60)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.NoRounding = False
        Me.btnrefresh.Size = New System.Drawing.Size(60, 25)
        Me.btnrefresh.TabIndex = 68
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.Transparent = False
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.Location = New System.Drawing.Point(351, 36)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(17, 20)
        Me.lblresult.TabIndex = 67
        Me.lblresult.Text = "0"
        Me.lblresult.Visible = False
        '
        'tbsearch
        '
        Me.tbsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbsearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbsearch.Location = New System.Drawing.Point(254, 59)
        Me.tbsearch.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbsearch.MaxLength = 30
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(353, 27)
        Me.tbsearch.TabIndex = 64
        Me.tbsearch.Text = " Search ..."
        '
        'cbodatelog
        '
        Me.cbodatelog.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cbodatelog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbodatelog.Font = New System.Drawing.Font("Segoe UI", 9.85!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodatelog.ForeColor = System.Drawing.Color.Silver
        Me.cbodatelog.FormattingEnabled = True
        Me.cbodatelog.Items.AddRange(New Object() {"Librarian", "User"})
        Me.cbodatelog.Location = New System.Drawing.Point(14, 60)
        Me.cbodatelog.Name = "cbodatelog"
        Me.cbodatelog.Size = New System.Drawing.Size(186, 25)
        Me.cbodatelog.TabIndex = 62
        Me.cbodatelog.Text = " ..."
        '
        'GLabel11
        '
        Me.GLabel11.BackColor = System.Drawing.Color.Transparent
        Me.GLabel11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GLabel11.ForeColor = System.Drawing.Color.White
        Me.GLabel11.Glow = 6
        Me.GLabel11.GlowColor = System.Drawing.Color.DarkOrange
        Me.GLabel11.GlowState = False
        Me.GLabel11.Location = New System.Drawing.Point(10, 38)
        Me.GLabel11.Name = "GLabel11"
        Me.GLabel11.Size = New System.Drawing.Size(140, 21)
        Me.GLabel11.TabIndex = 63
        Me.GLabel11.Text = "Date Logs "
        Me.GLabel11.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'OrangeGroupBox1
        '
        Me.OrangeGroupBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.OrangeGroupBox1.Controls.Add(Me.OrangeSeperator3)
        Me.OrangeGroupBox1.Controls.Add(Me.btnrefresh)
        Me.OrangeGroupBox1.Controls.Add(Me.tbsearch)
        Me.OrangeGroupBox1.Controls.Add(Me.lblresult)
        Me.OrangeGroupBox1.Controls.Add(Me.GLabel11)
        Me.OrangeGroupBox1.Controls.Add(Me.cbodatelog)
        Me.OrangeGroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.OrangeGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.OrangeGroupBox1.Location = New System.Drawing.Point(8, 41)
        Me.OrangeGroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.OrangeGroupBox1.Name = "OrangeGroupBox1"
        Me.OrangeGroupBox1.Size = New System.Drawing.Size(620, 103)
        Me.OrangeGroupBox1.TabIndex = 65
        Me.OrangeGroupBox1.Text = "Search Option"
        Me.OrangeGroupBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'OrangeSeperator3
        '
        Me.OrangeSeperator3.Alignment = LibSys.OrangeSeperator.Style.Verticle
        Me.OrangeSeperator3.BackColor = System.Drawing.Color.Transparent
        Me.OrangeSeperator3.Location = New System.Drawing.Point(220, 36)
        Me.OrangeSeperator3.Name = "OrangeSeperator3"
        Me.OrangeSeperator3.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.OrangeSeperator3.Size = New System.Drawing.Size(12, 57)
        Me.OrangeSeperator3.TabIndex = 69
        Me.OrangeSeperator3.Text = "OrangeSeperator3"
        Me.OrangeSeperator3.Thickness = 1.0!
        '
        'frmUserLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(638, 405)
        Me.Controls.Add(Me.OrangeGroupBox1)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.pnheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUserLogs"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUserLogs"
        Me.pnheader.ResumeLayout(False)
        Me.pnheader.PerformLayout()
        Me.OrangeGroupBox1.ResumeLayout(False)
        Me.OrangeGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnheader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GLabel11 As gLabel.gLabel
    Friend WithEvents cbodatelog As System.Windows.Forms.ComboBox
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents btnrefresh As LibSys.GhostButton
    Friend WithEvents SlcClose1 As LibSys.SLCClose
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OrangeGroupBox1 As LibSys.OrangeGroupBox
    Friend WithEvents OrangeSeperator3 As LibSys.OrangeSeperator
End Class
