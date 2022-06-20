Imports System.IO

Public Class ViewerApp

    Shared filePathRecords As String = "C:\Users\Computer\Documents\ContactTracing-Logs\"
    Shared files As String() = Directory.GetFiles(filePathRecords)

    Private Sub app_loader(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each file As String In files
            Dim filename As String = Path.GetFileName(file)
            filename = filename.Replace(".txt", "")
            listBox.Items.Add(filename)
        Next
    End Sub
End Class
