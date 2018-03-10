<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchBorrower
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
        Me.lv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.btncancel = New LibSys.GhostButton()
        Me.btnapply = New LibSys.GhostButton()
        Me.btnrefresh = New LibSys.GhostButton()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnheader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnheader
        '
        Me.pnheader.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.pnheader.Controls.Add(Me.SlcClose1)
        Me.pnheader.Controls.Add(Me.Label1)
        Me.pnheader.Location = New System.Drawing.Point(-1, 0)
        Me.pnheader.Name = "pnheader"
        Me.pnheader.Size = New System.Drawing.Size(413, 35)
        Me.pnheader.TabIndex = 2
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New LibSys.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(390, 8)
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
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User List"
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
        Me.btnsearch.TabIndex = 43
        Me.btnsearch.Text = "Q"
        Me.btnsearch.Transparent = False
        '
        'lv
        '
        Me.lv.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv.ForeColor = System.Drawing.Color.Silver
        Me.lv.FullRowSelect = True
        Me.lv.GridLines = True
        Me.lv.Location = New System.Drawing.Point(10, 99)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(393, 222)
        Me.lv.TabIndex = 41
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 89
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "UserName"
        Me.ColumnHeader2.Width = 108
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Firstname"
        Me.ColumnHeader3.Width = 97
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Lastname"
        Me.ColumnHeader4.Width = 116
        '
        'tbsearch
        '
        Me.tbsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbsearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbsearch.Location = New System.Drawing.Point(10, 42)
        Me.tbsearch.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbsearch.MaxLength = 30
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(393, 27)
        Me.tbsearch.TabIndex = 42
        Me.tbsearch.Text = " Search ..."
        '
        'btncancel
        '
        Me.btncancel.Color = System.Drawing.Color.Empty
        Me.btncancel.Colors = New LibSys.Bloom(-1) {}
        Me.btncancel.Customization = ""
        Me.btncancel.EnableGlass = True
        Me.btncancel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btncancel.Image = Nothing
        Me.btncancel.Location = New System.Drawing.Point(255, 329)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.NoRounding = False
        Me.btncancel.Size = New System.Drawing.Size(83, 32)
        Me.btncancel.TabIndex = 44
        Me.btncancel.Text = "Cancel"
        Me.btncancel.Transparent = False
        '
        'btnapply
        '
        Me.btnapply.Color = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnapply.Colors = New LibSys.Bloom(-1) {}
        Me.btnapply.Customization = ""
        Me.btnapply.EnableGlass = True
        Me.btnapply.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnapply.Image = Nothing
        Me.btnapply.Location = New System.Drawing.Point(77, 329)
        Me.btnapply.Name = "btnapply"
        Me.btnapply.NoRounding = False
        Me.btnapply.Size = New System.Drawing.Size(83, 32)
        Me.btnapply.TabIndex = 45
        Me.btnapply.Text = "Apply"
        Me.btnapply.Transparent = False
        '
        'btnrefresh
        '
        Me.btnrefresh.Color = System.Drawing.Color.Empty
        Me.btnrefresh.Colors = New LibSys.Bloom(-1) {}
        Me.btnrefresh.Customization = ""
        Me.btnrefresh.EnableGlass = True
        Me.btnrefresh.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnrefresh.Image = Nothing
        Me.btnrefresh.Location = New System.Drawing.Point(166, 329)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.NoRounding = False
        Me.btnrefresh.Size = New System.Drawing.Size(83, 32)
        Me.btnrefresh.TabIndex = 46
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.Transparent = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblname.Location = New System.Drawing.Point(77, 78)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(17, 17)
        Me.lblname.TabIndex = 48
        Me.lblname.Text = "..."
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.BackColor = System.Drawing.Color.Transparent
        Me.lblresult.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblresult.Location = New System.Drawing.Point(294, 76)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(15, 17)
        Me.lblresult.TabIndex = 49
        Me.lblresult.Text = "0"
        Me.lblresult.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Username:"
        '
        'frmSearchBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(413, 370)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnapply)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.tbsearch)
        Me.Controls.Add(Me.pnheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSearchBorrower"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSearchBorrower"
        Me.pnheader.ResumeLayout(False)
        Me.pnheader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnheader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsearch As LibSys.GhostButton
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
    Friend WithEvents btncancel As LibSys.GhostButton
    Friend WithEvents btnapply As LibSys.GhostButton
    Friend WithEvents btnrefresh As LibSys.GhostButton
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SlcClose1 As LibSys.SLCClose
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
