Imports System.Data.SqlClient
Public Class BPRiçerik
    Private Sub BPRiçerik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DilKontrol()

        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.FullRowSelect = True

        'Add column header
        ListView1.Columns.Add("Ders Kodu", 100)
        ListView1.Columns.Add("Ders Adı", 130)
        ListView1.Columns.Add("Kredi", 70)
        ListView1.Columns.Add("AKTS", 70)
        ListView1.Columns.Add("Dersi Veren", 120)
        ListView1.Columns.Add("Ders Saati", 70)

        'Add items in the listview
        Dim arr(6) As String
        Dim itm As ListViewItem

        'Add first item
        arr(0) = "BPR105"
        arr(1) = "Programlama Temelleri"
        arr(2) = "6"
        arr(3) = "6"
        arr(4) = "Gürkan Tuna"
        arr(5) = "5"
        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)

        'Add second item
        arr(0) = "BPR106"
        arr(1) = "Bilgisayar Donanımı"
        arr(2) = "3"
        arr(3) = "3"
        arr(4) = "Rıdvan Ayaz"
        arr(5) = "3"
        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)

        arr(0) = "BPR107"
        arr(1) = "Veri Tabanı ve Yönetimi"
        arr(2) = "5"
        arr(3) = "5"
        arr(4) = "Ahmet Vatansever"
        arr(5) = "4"
        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)

        arr(0) = "BPR109"
        arr(1) = "İş Sağlığı ve Güvenliği"
        arr(2) = "3"
        arr(3) = "3"
        arr(4) = "Filiz Bayar"
        arr(5) = "2"
        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)

        arr(0) = "BPR111"
        arr(1) = "Ofis Yazılımları"
        arr(2) = "4"
        arr(3) = "4"
        arr(4) = "Rıdvan Ayaz"
        arr(5) = "3"
        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)

        arr(0) = "BPR113"
        arr(1) = "Mesleski Yabancı Dil I"
        arr(2) = "4"
        arr(3) = "4"
        arr(4) = "Colin Kazım"
        arr(5) = "3"
        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)

        arr(0) = "BPR115"
        arr(1) = "Ağ Temelleri"
        arr(2) = "2"
        arr(3) = "2"
        arr(4) = "Gürkan Tuna"
        arr(5) = "2"
        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)


    End Sub
    Public Sub DilKontrol()
        If login.dilDurumu = 1 Then
            Button3.Text = "Back"
            Button2.Text = "Grade Information"
            Button1.Text = "Goals and Target"

        Else
            Button3.Text = "Geri"
            Button2.Text = "Ders Bilgileri"
            Button1.Text = "Amaçlar ve Hedefler"

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
        İçerik.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        İçerik.Show()
        Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        amaçhedefbpr.Show()
        Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class