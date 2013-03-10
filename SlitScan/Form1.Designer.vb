<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplitScan
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.picScan = New System.Windows.Forms.PictureBox()
        Me.picResult = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkBlack = New System.Windows.Forms.CheckBox()
        Me.chkVertical = New System.Windows.Forms.CheckBox()
        Me.txtSpeed = New System.Windows.Forms.TextBox()
        Me.lblSpeed = New System.Windows.Forms.Label()
        CType(Me.picScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(116, 275)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'picScan
        '
        Me.picScan.Location = New System.Drawing.Point(13, 13)
        Me.picScan.Name = "picScan"
        Me.picScan.Size = New System.Drawing.Size(302, 256)
        Me.picScan.TabIndex = 1
        Me.picScan.TabStop = False
        '
        'picResult
        '
        Me.picResult.Location = New System.Drawing.Point(353, 13)
        Me.picResult.Name = "picResult"
        Me.picResult.Size = New System.Drawing.Size(302, 256)
        Me.picResult.TabIndex = 1
        Me.picResult.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(467, 282)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkBlack
        '
        Me.chkBlack.AutoSize = True
        Me.chkBlack.Checked = True
        Me.chkBlack.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBlack.Location = New System.Drawing.Point(13, 333)
        Me.chkBlack.Name = "chkBlack"
        Me.chkBlack.Size = New System.Drawing.Size(154, 21)
        Me.chkBlack.TabIndex = 3
        Me.chkBlack.Text = "Toggle Black Guide"
        Me.chkBlack.UseVisualStyleBackColor = True
        '
        'chkVertical
        '
        Me.chkVertical.AutoSize = True
        Me.chkVertical.Checked = True
        Me.chkVertical.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVertical.Location = New System.Drawing.Point(12, 360)
        Me.chkVertical.Name = "chkVertical"
        Me.chkVertical.Size = New System.Drawing.Size(256, 21)
        Me.chkVertical.TabIndex = 3
        Me.chkVertical.Text = "Toggle Vertical/Horizontal Scanning"
        Me.chkVertical.UseVisualStyleBackColor = True
        '
        'txtSpeed
        '
        Me.txtSpeed.Location = New System.Drawing.Point(555, 331)
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.Size = New System.Drawing.Size(100, 22)
        Me.txtSpeed.TabIndex = 4
        Me.txtSpeed.Text = "10"
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(489, 334)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(53, 17)
        Me.lblSpeed.TabIndex = 5
        Me.lblSpeed.Text = "Speed:"
        '
        'frmSplitScan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 432)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.txtSpeed)
        Me.Controls.Add(Me.chkVertical)
        Me.Controls.Add(Me.chkBlack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.picResult)
        Me.Controls.Add(Me.picScan)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "frmSplitScan"
        Me.Text = "SlitScan"
        CType(Me.picScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents picScan As System.Windows.Forms.PictureBox
    Friend WithEvents picResult As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents chkBlack As System.Windows.Forms.CheckBox
    Friend WithEvents chkVertical As System.Windows.Forms.CheckBox
    Friend WithEvents txtSpeed As System.Windows.Forms.TextBox
    Friend WithEvents lblSpeed As System.Windows.Forms.Label

End Class
