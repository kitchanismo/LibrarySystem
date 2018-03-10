<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangepword
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
        Me.lblnpword = New gLabel.gLabel()
        Me.tbnpword = New System.Windows.Forms.TextBox()
        Me.lblcpword = New gLabel.gLabel()
        Me.tbcpword = New System.Windows.Forms.TextBox()
        Me.lblpword = New gLabel.gLabel()
        Me.tbpword = New System.Windows.Forms.TextBox()
        Me.btncancel = New LibSys.GhostButton()
        Me.btnsave = New LibSys.GhostButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnheader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnheader
        '
        Me.pnheader.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnheader.Controls.Add(Me.SlcClose1)
        Me.pnheader.Controls.Add(Me.Label1)
        Me.pnheader.Location = New System.Drawing.Point(-1, 0)
        Me.pnheader.Name = "pnheader"
        Me.pnheader.Size = New System.Drawing.Size(316, 35)
        Me.pnheader.TabIndex = 3
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New LibSys.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(291, 9)
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
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change Password"
        '
        'lblnpword
        '
        Me.lblnpword.BackColor = System.Drawing.Color.Transparent
        Me.lblnpword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnpword.ForeColor = System.Drawing.Color.White
        Me.lblnpword.Glow = 6
        Me.lblnpword.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblnpword.GlowState = False
        Me.lblnpword.Location = New System.Drawing.Point(26, 106)
        Me.lblnpword.Name = "lblnpword"
        Me.lblnpword.Size = New System.Drawing.Size(126, 21)
        Me.lblnpword.TabIndex = 54
        Me.lblnpword.Text = "New"
        Me.lblnpword.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'tbnpword
        '
        Me.tbnpword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbnpword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbnpword.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbnpword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbnpword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnpword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbnpword.Location = New System.Drawing.Point(28, 130)
        Me.tbnpword.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbnpword.MaxLength = 30
        Me.tbnpword.Name = "tbnpword"
        Me.tbnpword.Size = New System.Drawing.Size(256, 25)
        Me.tbnpword.TabIndex = 53
        Me.tbnpword.UseSystemPasswordChar = True
        '
        'lblcpword
        '
        Me.lblcpword.BackColor = System.Drawing.Color.Transparent
        Me.lblcpword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcpword.ForeColor = System.Drawing.Color.White
        Me.lblcpword.Glow = 6
        Me.lblcpword.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblcpword.GlowState = False
        Me.lblcpword.Location = New System.Drawing.Point(27, 156)
        Me.lblcpword.Name = "lblcpword"
        Me.lblcpword.Size = New System.Drawing.Size(126, 21)
        Me.lblcpword.TabIndex = 52
        Me.lblcpword.Text = "Confirm"
        Me.lblcpword.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'tbcpword
        '
        Me.tbcpword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tbcpword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tbcpword.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tbcpword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbcpword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcpword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbcpword.Location = New System.Drawing.Point(29, 180)
        Me.tbcpword.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbcpword.MaxLength = 30
        Me.tbcpword.Name = "tbcpword"
        Me.tbcpword.Size = New System.Drawing.Size(256, 25)
        Me.tbcpword.TabIndex = 51
        Me.tbcpword.UseSystemPasswordChar = True
        '
        'lblpword
        '
        Me.lblpword.BackColor = System.Drawing.Color.Transparent
        Me.lblpword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpword.ForeColor = System.Drawing.Color.White
        Me.lblpword.Glow = 6
        Me.lblpword.GlowColor = System.Drawing.Color.DarkOrange
        Me.lblpword.GlowState = False
        Me.lblpword.Location = New System.Drawing.Point(26, 54)
        Me.lblpword.Name = "lblpword"
        Me.lblpword.Size = New System.Drawing.Size(126, 21)
        Me.lblpword.TabIndex = 56
        Me.lblpword.Text = "Current"
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
        Me.tbpword.Location = New System.Drawing.Point(28, 78)
        Me.tbpword.Margin = New System.Windows.Forms.Padding(8, 3, 3, 3)
        Me.tbpword.MaxLength = 30
        Me.tbpword.Name = "tbpword"
        Me.tbpword.Size = New System.Drawing.Size(256, 25)
        Me.tbpword.TabIndex = 55
        Me.tbpword.UseSystemPasswordChar = True
        '
        'btncancel
        '
        Me.btncancel.Color = System.Drawing.Color.Empty
        Me.btncancel.Colors = New LibSys.Bloom(-1) {}
        Me.btncancel.Customization = ""
        Me.btncancel.EnableGlass = True
        Me.btncancel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btncancel.Image = Nothing
        Me.btncancel.Location = New System.Drawing.Point(162, 225)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.NoRounding = False
        Me.btncancel.Size = New System.Drawing.Size(83, 32)
        Me.btncancel.TabIndex = 58
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
        Me.btnsave.Location = New System.Drawing.Point(69, 225)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.NoRounding = False
        Me.btnsave.Size = New System.Drawing.Size(83, 32)
        Me.btnsave.TabIndex = 57
        Me.btnsave.Text = "Save"
        Me.btnsave.Transparent = False
        '
        'frmChangepword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(315, 275)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.lblpword)
        Me.Controls.Add(Me.tbpword)
        Me.Controls.Add(Me.lblnpword)
        Me.Controls.Add(Me.tbnpword)
        Me.Controls.Add(Me.lblcpword)
        Me.Controls.Add(Me.tbcpword)
        Me.Controls.Add(Me.pnheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChangepword"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChangepword"
        Me.pnheader.ResumeLayout(False)
        Me.pnheader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnheader As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblnpword As gLabel.gLabel
    Friend WithEvents tbnpword As System.Windows.Forms.TextBox
    Friend WithEvents lblcpword As gLabel.gLabel
    Friend WithEvents tbcpword As System.Windows.Forms.TextBox
    Friend WithEvents lblpword As gLabel.gLabel
    Friend WithEvents tbpword As System.Windows.Forms.TextBox
    Friend WithEvents btncancel As LibSys.GhostButton
    Friend WithEvents btnsave As LibSys.GhostButton
    Friend WithEvents SlcClose1 As LibSys.SLCClose
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
