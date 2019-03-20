Option Strict On
Imports System.IO
Public Class frmMain





    Private Sub OpenCtrlOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenCtrlOToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Text Files|*.txt"
        Try
            If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
                Dim strFullPath As String = OpenFileDialog1.FileName
                Dim fileRead As New FileStream(strFullPath, FileMode.Open, FileAccess.Read)
                Dim reader As New StreamReader(fileRead)
                txtMain.Text = reader.ReadToEnd()
                reader.Close()
            End If
        Catch ex As Exception
            txtMain.Text = "error"
        End Try

    End Sub




    Private Sub SaveCtrlSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveCtrlSToolStripMenuItem.Click

    End Sub

    Public Sub Save()

    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
