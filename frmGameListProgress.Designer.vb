<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameListProgress
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameListProgress))
        Me.pbMain = New System.Windows.Forms.ProgressBar()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pbMain
        '
        Me.pbMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMain.Location = New System.Drawing.Point(12, 38)
        Me.pbMain.Name = "pbMain"
        Me.pbMain.Size = New System.Drawing.Size(415, 48)
        Me.pbMain.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 97)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(439, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Location = New System.Drawing.Point(12, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(80, 13)
        Me.lblMain.TabIndex = 2
        Me.lblMain.Text = "Current Action: "
        '
        'frmGameListProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 119)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pbMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGameListProgress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GameList Creation Progress"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbMain As ProgressBar
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblMain As Label
End Class
