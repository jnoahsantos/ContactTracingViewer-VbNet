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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim keyWord As String = txtBxSearch.Text
        Dim listOfNames As List(Of String) = New List(Of String)()
        labelSearchWarning.Text = ""

        For Each file As String In files
            Dim filename As String = Path.GetFileName(file)
            filename = filename.Replace(".txt", "")
            listOfNames.Add(filename)
        Next

        Dim arrayOfNames As String() = listOfNames.ToArray()

        If keyWord.Length >= 3 Then

            For Each x As String In arrayOfNames

                If (x.ToLower()).Contains(keyWord.ToLower()) Then
                    listBox.Text = x
                End If
            Next

            If Not ((listBox.Text).ToLower()).Contains(keyWord.ToLower()) Then
                MessageBox.Show("Name Not Found", "Notification")
            End If
        Else
            labelSearchWarning.Location = New Point(170, 106)
            labelSearchWarning.Text = "Please enter atleast 3 character"
        End If
    End Sub

End Class
