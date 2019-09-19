Public Class Form1

    Dim konf As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim angka As Integer
        ListBox1.Items.Clear()
        If TextBox1.Text = "" Then
            MsgBox("Anda Belum Memasukan Angka", vbCritical, "Salah")
            TextBox1.Text = Nothing
        Else
            For angka = 65 To TextBox1.Text + 64
                ListBox1.Items.Add(Chr(angka))
            Next

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = Nothing
        ListBox1.Items.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        konf = MsgBox("Apakah Anda ingin keluar", vbQuestion + vbYesNo, "Konfirmasi")
        If konf = vbYes Then
            Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("Program Ini Menggunakan metode ASCII dimnana di mulai dengan Angka 97 yaitu A Uncapital dan setelah itu inputan di lakuakn dengan bebas ", MsgBoxStyle.Information, "Pemberitahuan")
    End Sub
End Class
