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
        Me.txtDirectoryPath = New System.Windows.Forms.TextBox()
        Me.cmdBrowseFolder = New System.Windows.Forms.Button()
        Me.lbFiles = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbFileNames = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "目錄路徑："
        '
        'txtDirectoryPath
        '
        Me.txtDirectoryPath.Location = New System.Drawing.Point(160, 38)
        Me.txtDirectoryPath.Name = "txtDirectoryPath"
        Me.txtDirectoryPath.Size = New System.Drawing.Size(428, 22)
        Me.txtDirectoryPath.TabIndex = 1
        '
        'cmdBrowseFolder
        '
        Me.cmdBrowseFolder.Location = New System.Drawing.Point(594, 38)
        Me.cmdBrowseFolder.Name = "cmdBrowseFolder"
        Me.cmdBrowseFolder.Size = New System.Drawing.Size(34, 23)
        Me.cmdBrowseFolder.TabIndex = 2
        Me.cmdBrowseFolder.Text = "..."
        Me.cmdBrowseFolder.UseVisualStyleBackColor = True
        '
        'lbFiles
        '
        Me.lbFiles.FormattingEnabled = True
        Me.lbFiles.ItemHeight = 12
        Me.lbFiles.Location = New System.Drawing.Point(91, 160)
        Me.lbFiles.Name = "lbFiles"
        Me.lbFiles.Size = New System.Drawing.Size(247, 172)
        Me.lbFiles.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "檔案清單 (FullName)："
        '
        'lbFileNames
        '
        Me.lbFileNames.FormattingEnabled = True
        Me.lbFileNames.ItemHeight = 12
        Me.lbFileNames.Location = New System.Drawing.Point(381, 160)
        Me.lbFileNames.Name = "lbFileNames"
        Me.lbFileNames.Size = New System.Drawing.Size(247, 172)
        Me.lbFileNames.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(379, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "檔案清單 (FileName)："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "資料夾佔用大小: "
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(190, 88)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(0, 12)
        Me.lblSize.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 387)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbFileNames)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbFiles)
        Me.Controls.Add(Me.cmdBrowseFolder)
        Me.Controls.Add(Me.txtDirectoryPath)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDirectoryPath As System.Windows.Forms.TextBox
    Friend WithEvents cmdBrowseFolder As System.Windows.Forms.Button
    Friend WithEvents lbFiles As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbFileNames As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSize As System.Windows.Forms.Label

End Class
