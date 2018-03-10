<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileMaintenenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssuanceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowedBooksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnedBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DueBooksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UserLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatToggle1 = New LibSys.FlatToggle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.utype = New System.Windows.Forms.Label()
        Me.lblutype = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SlcClose1 = New LibSys.SLCClose()
        Me.SlcMin1 = New LibSys.SLCMin()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlatAlertBox1 = New LibSys.FlatAlertBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(4, 4, 0, 4)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMaintenenceToolStripMenuItem, Me.TransactionStripMenuItem, Me.ReportsToolStripMenuItem, Me.SearchBooksToolStripMenuItem, Me.UserLogToolStripMenuItem, Me.AccountSettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 5, 0, 5)
        Me.MenuStrip1.Size = New System.Drawing.Size(808, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileMaintenenceToolStripMenuItem
        '
        Me.FileMaintenenceToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FileMaintenenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BooksToolStripMenuItem1, Me.UserToolStripMenuItem, Me.ToolStripSeparator2, Me.LogoutToolStripMenuItem})
        Me.FileMaintenenceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FileMaintenenceToolStripMenuItem.Image = CType(resources.GetObject("FileMaintenenceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileMaintenenceToolStripMenuItem.Name = "FileMaintenenceToolStripMenuItem"
        Me.FileMaintenenceToolStripMenuItem.Size = New System.Drawing.Size(28, 25)
        Me.FileMaintenenceToolStripMenuItem.Text = "File Maintenance"
        '
        'BooksToolStripMenuItem1
        '
        Me.BooksToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BooksToolStripMenuItem1.Name = "BooksToolStripMenuItem1"
        Me.BooksToolStripMenuItem1.Size = New System.Drawing.Size(225, 26)
        Me.BooksToolStripMenuItem1.Text = "Books Maintenance"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.UserToolStripMenuItem.Text = "User Maintenance"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(222, 6)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'TransactionStripMenuItem
        '
        Me.TransactionStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IssuanceToolStripMenuItem1, Me.ReturnBookToolStripMenuItem})
        Me.TransactionStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TransactionStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TransactionStripMenuItem.Name = "TransactionStripMenuItem"
        Me.TransactionStripMenuItem.Size = New System.Drawing.Size(109, 25)
        Me.TransactionStripMenuItem.Text = "Transactions"
        '
        'IssuanceToolStripMenuItem1
        '
        Me.IssuanceToolStripMenuItem1.Name = "IssuanceToolStripMenuItem1"
        Me.IssuanceToolStripMenuItem1.Size = New System.Drawing.Size(176, 26)
        Me.IssuanceToolStripMenuItem1.Text = "Issuance"
        '
        'ReturnBookToolStripMenuItem
        '
        Me.ReturnBookToolStripMenuItem.Name = "ReturnBookToolStripMenuItem"
        Me.ReturnBookToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.ReturnBookToolStripMenuItem.Text = "Return Book"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowedBooksToolStripMenuItem1, Me.ReturnedBooksToolStripMenuItem, Me.DueBooksToolStripMenuItem1, Me.ToolStripSeparator1, Me.UserLogsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(76, 25)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'BorrowedBooksToolStripMenuItem1
        '
        Me.BorrowedBooksToolStripMenuItem1.Name = "BorrowedBooksToolStripMenuItem1"
        Me.BorrowedBooksToolStripMenuItem1.Size = New System.Drawing.Size(204, 26)
        Me.BorrowedBooksToolStripMenuItem1.Text = "Borrowed Books"
        '
        'ReturnedBooksToolStripMenuItem
        '
        Me.ReturnedBooksToolStripMenuItem.Name = "ReturnedBooksToolStripMenuItem"
        Me.ReturnedBooksToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.ReturnedBooksToolStripMenuItem.Text = "Returned Books"
        '
        'DueBooksToolStripMenuItem1
        '
        Me.DueBooksToolStripMenuItem1.Name = "DueBooksToolStripMenuItem1"
        Me.DueBooksToolStripMenuItem1.Size = New System.Drawing.Size(204, 26)
        Me.DueBooksToolStripMenuItem1.Text = "Due Books"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(201, 6)
        '
        'UserLogsToolStripMenuItem
        '
        Me.UserLogsToolStripMenuItem.Name = "UserLogsToolStripMenuItem"
        Me.UserLogsToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.UserLogsToolStripMenuItem.Text = "User Logs"
        '
        'SearchBooksToolStripMenuItem
        '
        Me.SearchBooksToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SearchBooksToolStripMenuItem.Name = "SearchBooksToolStripMenuItem"
        Me.SearchBooksToolStripMenuItem.Size = New System.Drawing.Size(115, 25)
        Me.SearchBooksToolStripMenuItem.Text = "Search Books"
        '
        'UserLogToolStripMenuItem
        '
        Me.UserLogToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserLogToolStripMenuItem.Name = "UserLogToolStripMenuItem"
        Me.UserLogToolStripMenuItem.Size = New System.Drawing.Size(141, 25)
        Me.UserLogToolStripMenuItem.Text = "Current User Log"
        '
        'AccountSettingsToolStripMenuItem
        '
        Me.AccountSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AccountSettingsToolStripMenuItem.Name = "AccountSettingsToolStripMenuItem"
        Me.AccountSettingsToolStripMenuItem.Size = New System.Drawing.Size(138, 25)
        Me.AccountSettingsToolStripMenuItem.Text = "Account Settings"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FlatToggle1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.utype)
        Me.Panel1.Controls.Add(Me.lblutype)
        Me.Panel1.Location = New System.Drawing.Point(0, 397)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 38)
        Me.Panel1.TabIndex = 4
        '
        'FlatToggle1
        '
        Me.FlatToggle1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlatToggle1.BackColor = System.Drawing.Color.Transparent
        Me.FlatToggle1.Checked = True
        Me.FlatToggle1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatToggle1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatToggle1.Location = New System.Drawing.Point(2, 3)
        Me.FlatToggle1.Name = "FlatToggle1"
        Me.FlatToggle1.Options = LibSys.FlatToggle._Options.Style2
        Me.FlatToggle1.Size = New System.Drawing.Size(76, 33)
        Me.FlatToggle1.TabIndex = 59
        Me.FlatToggle1.Text = "FlatToggle1"
        Me.ToolTip1.SetToolTip(Me.FlatToggle1, "Click to Login")
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'utype
        '
        Me.utype.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.utype.AutoSize = True
        Me.utype.BackColor = System.Drawing.Color.Transparent
        Me.utype.Cursor = System.Windows.Forms.Cursors.Hand
        Me.utype.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.utype.ForeColor = System.Drawing.Color.White
        Me.utype.Location = New System.Drawing.Point(40, 11)
        Me.utype.Name = "utype"
        Me.utype.Size = New System.Drawing.Size(40, 17)
        Me.utype.TabIndex = 29
        Me.utype.Text = "utype"
        Me.utype.Visible = False
        '
        'lblutype
        '
        Me.lblutype.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblutype.AutoSize = True
        Me.lblutype.BackColor = System.Drawing.Color.Transparent
        Me.lblutype.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblutype.ForeColor = System.Drawing.Color.White
        Me.lblutype.Location = New System.Drawing.Point(576, 10)
        Me.lblutype.Name = "lblutype"
        Me.lblutype.Size = New System.Drawing.Size(17, 17)
        Me.lblutype.TabIndex = 25
        Me.lblutype.Text = "..."
        Me.lblutype.Visible = False
        '
        'SlcClose1
        '
        Me.SlcClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SlcClose1.Colors = New LibSys.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(783, 8)
        Me.SlcClose1.Name = "SlcClose1"
        Me.SlcClose1.NoRounding = False
        Me.SlcClose1.Size = New System.Drawing.Size(20, 20)
        Me.SlcClose1.TabIndex = 32
        Me.SlcClose1.Text = "SlcClose1"
        Me.ToolTip1.SetToolTip(Me.SlcClose1, "Close")
        Me.SlcClose1.Transparent = False
        '
        'SlcMin1
        '
        Me.SlcMin1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SlcMin1.Colors = New LibSys.Bloom(-1) {}
        Me.SlcMin1.Customization = ""
        Me.SlcMin1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcMin1.Image = Nothing
        Me.SlcMin1.Location = New System.Drawing.Point(760, 8)
        Me.SlcMin1.Name = "SlcMin1"
        Me.SlcMin1.NoRounding = False
        Me.SlcMin1.Size = New System.Drawing.Size(20, 20)
        Me.SlcMin1.TabIndex = 33
        Me.SlcMin1.Text = "SlcMin1"
        Me.ToolTip1.SetToolTip(Me.SlcMin1, "Minimize")
        Me.SlcMin1.Transparent = False
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(410, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 31
        Me.Label1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(301, 72)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(216, 273)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'Timer2
        '
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(724, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "vampiping.app"
        '
        'FlatAlertBox1
        '
        Me.FlatAlertBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatAlertBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatAlertBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatAlertBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatAlertBox1.kind = LibSys.FlatAlertBox._Kind.Success
        Me.FlatAlertBox1.Location = New System.Drawing.Point(0, 0)
        Me.FlatAlertBox1.Name = "FlatAlertBox1"
        Me.FlatAlertBox1.Size = New System.Drawing.Size(808, 42)
        Me.FlatAlertBox1.TabIndex = 34
        Me.FlatAlertBox1.Text = "FlatAlertBox1"
        Me.FlatAlertBox1.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(808, 435)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.FlatAlertBox1)
        Me.Controls.Add(Me.SlcMin1)
        Me.Controls.Add(Me.SlcClose1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LibSys"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TransactionStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents IssuanceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrowedBooksToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnedBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DueBooksToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents utype As System.Windows.Forms.Label
    Friend WithEvents AccountSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMaintenenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BooksToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UserLogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FlatToggle1 As LibSys.FlatToggle
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents SlcClose1 As LibSys.SLCClose
    Friend WithEvents SlcMin1 As LibSys.SLCMin
    Friend WithEvents FlatAlertBox1 As LibSys.FlatAlertBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblutype As System.Windows.Forms.Label

End Class
