Imports System.Net.Http
Imports System.Text
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports Newtonsoft.Json.Linq

Public Class Baru

    Public myGlobalVariable As Integer = 0

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles no_rek.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bank_converted As String = ""
        Dim client As New HttpClient()
        Dim bank_mapping(,) As String = {
            {"BCA", "bca"},
            {"Blu By BCA", "royal"},
            {"BNI", "bni"},
            {"BRI", "bri"},
            {"Mandiri", "mandiri"},
            {"CIMB Niaga", "cimb"},
            {"Permata", "permata"},
            {"Danamon", "danamon"},
            {"Bank DKI", "dki"},
            {"BTPN/Jenius", "tabungan_pensiunan_nasional"},
            {"Bank NOBU", "nationalnobu"},
            {"Bank Jago", "artos"},
            {"Line Bank", "hana"},
            {"LinkAja!", "linkaja"},
            {"GoPay", "gopay"},
            {"OVO", "ovo"},
            {"DANA", "dana"}
        }

        For i As Integer = 0 To bank_mapping.GetLength(0) - 1
            If bank_mapping(i, 0) = bank.Text Then
                bank_converted = bank_mapping(i, 1)
                Exit For
            End If
        Next

        client.BaseAddress = New Uri($"https://cekrek.heirro.dev/api/check")

        Dim formContent As New FormUrlEncodedContent(New Dictionary(Of String, String) From {
            {"accountBank", bank_converted},
            {"accountNumber", no_rek.Text}
        })


        Try
            Dim response As HttpResponseMessage = Await client.PostAsync($"https://cekrek.heirro.dev/api/check", formContent)
            Dim requestUrl As String = response.RequestMessage.RequestUri.ToString()
            Dim responseString As String = Await response.Content.ReadAsStringAsync()


            Dim json As JObject = JObject.Parse(responseString)

            If json.GetValue("message").ToString() = "Account number not found" Then
                MessageBox.Show(json.GetValue("message").ToString(), "Success !")
            Else
                Dim data = json.GetValue("data")
                Hasil.ewallet.Text = data(0)("accountBank")
                Hasil.norek.Text = data(0)("accountNumber")
                Hasil.name.Text = data(0)("accountName")
                Hasil.StartPosition = FormStartPosition.CenterParent
                Hasil.ShowDialog()
            End If


        Catch ex As Exception
            Debug.WriteLine(ex, 9998)
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bank.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


End Class