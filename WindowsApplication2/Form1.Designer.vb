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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 32)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(588, 218)
        Me.TextBox1.TabIndex = 0
        '
        'cmdOpen
        '
        Me.cmdOpen.Location = New System.Drawing.Point(12, 3)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(75, 23)
        Me.cmdOpen.TabIndex = 1
        Me.cmdOpen.Text = "Open"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(103, 3)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 262)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdOpen)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdOpen As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button

End Class
