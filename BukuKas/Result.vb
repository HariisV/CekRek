Imports System.IO

Public Class Hasil
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles norek.Click

    End Sub

    Private Sub ewallet_Click(sender As Object, e As EventArgs) Handles ewallet.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filePath = Application.StartupPath & "\example.txt" 'mengatur path file berada di folder project
        Dim content As String = $"{Me.name.Text} - {Me.ewallet.Text} - {Me.norek.Text}"

        Using writer As StreamWriter = File.AppendText(filePath)
            writer.WriteLine(content)
        End Using
        Me.Close()

    End Sub
End Class