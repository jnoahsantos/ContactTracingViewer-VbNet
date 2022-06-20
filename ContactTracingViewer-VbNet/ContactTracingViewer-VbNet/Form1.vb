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

    Private Function ListToString(ByVal lines As List(Of String)) As String
        Dim x As String = ""

        For Each line As String In lines
            x = x & line & vbLf
        Next

        Return x
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim keyWord As String = txtBxSearch.Text
        Dim listOfNames As List(Of String) = New List(Of String)()
        labelSearchWarning.Text = ""
        Dim dialogbox1

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
                dialogbox1 = MessageBox.Show("Name not found", "Notification", MessageBoxButtons.OK)
                If dialogbox1 = DialogResult.OK Then
                    txtBxSearch.Text = " "
                End If
            End If
        Else
            labelSearchWarning.Location = New Point(170, 106)
            labelSearchWarning.Text = "Please enter atleast three characters"
        End If
    End Sub


    Private Sub btnViewData_click(sender As Object, e As EventArgs) Handles btnViewData.Click
        labelSearchWarning.Text = ""
        Dim dialogbox2

        If listBox.Text <> "" Then
            Dim filePath As String = "C:\Users\Computer\Documents\ContactTracing-Logs\" & listBox.Text & ".txt"
            Dim lines As List(Of String) = New List(Of String)()
            lines = File.ReadAllLines(filePath).ToList()
            dialogbox2 = MessageBox.Show(ListToString(lines), listBox.Text, MessageBoxButtons.OK)
            If dialogbox2 = DialogResult.OK Then
                txtBxSearch.Text = " "
            End If
        Else
            labelSearchWarning.Location = New Point(159, 308)
            labelSearchWarning.Text = "Please select a name"
        End If

    End Sub
End Class
