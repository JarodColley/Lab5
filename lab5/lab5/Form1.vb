Option Strict On
Public Class frmMain
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub OpenCtrlOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenCtrlOToolStripMenuItem.Click
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then

        End If

    End Sub
End Class
