Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim drives As DriveInfo() = DriveInfo.GetDrives()

        For Each drive As DriveInfo In drives

            If drive.IsReady Then
                Me.lbDrives.Items.Add(drive.Name + " (" + drive.DriveType.ToString() + ")")
            End If

        Next

    End Sub

    Private Sub lbDrives_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbDrives.SelectedIndexChanged

        Dim drive As New DriveInfo(Me.lbDrives.SelectedItem.ToString())

        Dim dirRoot As DirectoryInfo = drive.RootDirectory

        Me.lblDriveType.Text = drive.DriveType.ToString()
        Me.lblDriveLabel.Text = drive.VolumeLabel
        Me.lblDriveCapacity.Text = _
            (drive.TotalSize / 1024 / 1024).ToString("###,###,###") + " MB"

    End Sub


End Class
