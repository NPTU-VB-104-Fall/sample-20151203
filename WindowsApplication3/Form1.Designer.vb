<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbDrives = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDriveType = New System.Windows.Forms.Label()
        Me.lblDriveLabel = New System.Windows.Forms.Label()
        Me.lblDriveCapacity = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "磁碟機："
        '
        'lbDrives
        '
        Me.lbDrives.FormattingEnabled = True
        Me.lbDrives.ItemHeight = 12
        Me.lbDrives.Location = New System.Drawing.Point(30, 44)
        Me.lbDrives.Name = "lbDrives"
        Me.lbDrives.Size = New System.Drawing.Size(154, 112)
        Me.lbDrives.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "磁碟類型："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(214, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "磁碟標記："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "容量："
        '
        'lblDriveType
        '
        Me.lblDriveType.AutoSize = True
        Me.lblDriveType.Location = New System.Drawing.Point(285, 59)
        Me.lblDriveType.Name = "lblDriveType"
        Me.lblDriveType.Size = New System.Drawing.Size(0, 12)
        Me.lblDriveType.TabIndex = 5
        '
        'lblDriveLabel
        '
        Me.lblDriveLabel.AutoSize = True
        Me.lblDriveLabel.Location = New System.Drawing.Point(285, 89)
        Me.lblDriveLabel.Name = "lblDriveLabel"
        Me.lblDriveLabel.Size = New System.Drawing.Size(0, 12)
        Me.lblDriveLabel.TabIndex = 6
        '
        'lblDriveCapacity
        '
        Me.lblDriveCapacity.AutoSize = True
        Me.lblDriveCapacity.Location = New System.Drawing.Point(285, 119)
        Me.lblDriveCapacity.Name = "lblDriveCapacity"
        Me.lblDriveCapacity.Size = New System.Drawing.Size(0, 12)
        Me.lblDriveCapacity.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 185)
        Me.Controls.Add(Me.lblDriveCapacity)
        Me.Controls.Add(Me.lblDriveLabel)
        Me.Controls.Add(Me.lblDriveType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbDrives)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbDrives As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDriveType As System.Windows.Forms.Label
    Friend WithEvents lblDriveLabel As System.Windows.Forms.Label
    Friend WithEvents lblDriveCapacity As System.Windows.Forms.Label

End Class
