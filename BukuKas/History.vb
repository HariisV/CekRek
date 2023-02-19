Imports System.Buffers

Public Class History
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileNumber As Integer
        Dim filePath As String
        filePath = Application.StartupPath & "\example.txt" 'mengatur path file berada di folder project
        Debug.WriteLine(filePath, 9998)
        fileNumber = FreeFile()
        FileOpen(fileNumber, filePath, OpenMode.Input)

        Dim fileContent As String
        fileContent = InputString(fileNumber, LOF(fileNumber))

        historyTxt.Text = fileContent
        FileClose(fileNumber)
    End Sub

End Class