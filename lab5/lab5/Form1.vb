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
            MessageBox.Show("error")
        End Try

    End Sub




    Private Sub SaveCtrlSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveCtrlSToolStripMenuItem.Click
        Save()
    End Sub

    Public Sub Save()
        Try
            Dim strFullPath As String = SaveFileDialog1.FileName
            If File.Exists(strFullPath) Then
                Dim fileWrite As New FileStream(strFullPath, FileMode.Create, FileAccess.Write)
                Dim writer As New StreamWriter(fileWrite)
                writer.WriteLine(txtMain.Text)
                writer.Close()
            Else
                SaveFileDialog1.Filter = "Text Files|*.txt"
                SaveFileDialog1.ShowDialog()
                System.IO.File.WriteAllText(SaveFileDialog1.FileName, txtMain.Text)

            End If
        Catch ex As Exception
            MessageBox.Show("error")
        End Try
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        If (SaveFileDialog1.ShowDialog() = DialogResult.OK) Then
            Save()
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        txtMain.Text = ""
        SaveFileDialog1.FileName = ""
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        If (txtMain.SelectedText = "") Then
            MessageBox.Show("error please select something to cut")
        Else
            My.Computer.Clipboard.SetText(txtMain.SelectedText)
            txtMain.SelectedText = ""
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        If (txtMain.SelectedText = "") Then
            MessageBox.Show("error please select something to copy")
        Else
            My.Computer.Clipboard.SetText(txtMain.SelectedText)
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        txtMain.Text += My.Computer.Clipboard.GetText()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("NETD 2202
Lab #5
Jarod Colley")
    End Sub
End Class
