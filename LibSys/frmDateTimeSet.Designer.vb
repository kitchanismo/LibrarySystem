<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDateTimeSet
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
        Me.pnheader = New System.Windows.Forms.Panel()
        Me.GhostButton1 = New LibSys.GhostButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnheader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnheader
        '
        Me.pnheader.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnheader.Controls.Add(Me.GhostButton1)
        Me.pnheader.Controls.Add(Me.Label1)
        Me.pnheader.Location = New System.Drawing.Point(1, 0)
        Me.pnheader.Name = "pnheader"
        Me.pnheader.Size = New System.Drawing.Size(401, 35)
        Me.pnheader.TabIndex = 2
        '
        'GhostButton1
        '
        Me.GhostButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GhostButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GhostButton1.Color = System.Drawing.Color.Red
        Me.GhostButton1.Colors = New LibSys.Bloom(-1) {}
        Me.GhostButton1.Customization = ""
        Me.GhostButton1.EnableGlass = True
        Me.GhostButton1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.GhostButton1.Image = Nothing
        Me.GhostButton1.Location = New System.Drawing.Point(361, 5)
        Me.GhostButton1.Name = "GhostButton1"
        Me.GhostButton1.NoRounding = False
        Me.GhostButton1.Size = New System.Drawing.Size(34, 23)
        Me.GhostButton1.TabIndex = 2
        Me.GhostButton1.Text = "r"
        Me.GhostButton1.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date-Time Settings"
        '
        'frmDateTimeSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(402, 381)
        Me.Controls.Add(Me.pnheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDateTimeSet"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDateTimeSet"
        Me.pnheader.ResumeLayout(False)
        Me.pnheader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnheader As System.Windows.Forms.Panel
    Friend WithEvents GhostButton1 As LibSys.GhostButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
