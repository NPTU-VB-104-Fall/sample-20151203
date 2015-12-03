Imports System.IO

Public Class Form1

    Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click

        Dim ofd As New OpenFileDialog

        ofd.Filter = "文字檔|*.txt"
        Dim result As DialogResult = ofd.ShowDialog()

        If (result = Windows.Forms.DialogResult.Cancel) Then
            Return
        End If

        Dim stream As FileStream = ofd.OpenFile()
        Dim reader As New StreamReader(stream)

        Me.TextBox1.Text = reader.ReadToEnd()

        reader.Close()

    End Sub


    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Dim sfd As New SaveFileDialog

        sfd.Filter = "文字檔|*.txt"
        Dim result As DialogResult = sfd.ShowDialog()

        If (result = Windows.Forms.DialogResult.Cancel) Then
            Return
        End If

        Dim stream As New FileStream(sfd.FileName, FileMode.Create)
        Dim writer As New StreamWriter(stream)

        writer.Write(Me.TextBox1.Text)
        writer.Close()

    End Sub

End Class
