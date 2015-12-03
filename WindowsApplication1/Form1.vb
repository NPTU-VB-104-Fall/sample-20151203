Imports System.IO

Public Class Form1

    Private Sub cmdBrowseFolder_Click(sender As Object, e As EventArgs) Handles cmdBrowseFolder.Click

        Dim dlg As New FolderBrowserDialog()

        dlg.Description = "請選擇一個目錄。"
        dlg.ShowNewFolderButton = True
        dlg.ShowDialog()

        Me.txtDirectoryPath.Text = dlg.SelectedPath
        Me.lbFiles.Items.Clear()
        Me.lbFileNames.Items.Clear()

        Dim myDir As New DirectoryInfo(dlg.SelectedPath)
        Dim files As FileInfo() = myDir.GetFiles("*.*", SearchOption.AllDirectories)
        Dim size As Double = 0

        For i As Integer = 0 To files.Length - 1

            size += files(i).Length
            Me.lbFiles.Items.Add(files(i).FullName)
            Me.lbFileNames.Items.Add(files(i).Name)

        Next

        Me.lblSize.Text = (size / 1024 / 1024).ToString("###,###,##0.00") + "MB"

    End Sub
End Class
