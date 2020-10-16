Public Class RTViçerik
	Private Sub Button1_Click(sender As Object, e As EventArgs)
		Close()
		İçerik.Show()

	End Sub
    Public Sub DilKontrol()
        If login.dilDurumu = 1 Then
            Button1.Text = "Goals and Target"
            Button2.Text = "Grade Information"
        Else
            Button1.Text = "Amaç ve Hedefler"
            Button2.Text = "Ders Bilgileri"
        End If
    End Sub
    Private Sub RTViçerik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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



        'Add second item
        arr(0) = "RTP101"
        arr(1) = "Temel Kamera"
        arr(2) = "4"
        arr(3) = "3"
        arr(4) = "Emre Hıma"
        arr(5) = "3"
        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)

        arr(0) = "RTP103"
        arr(1) = "Kurgu Teknikleri I"
        arr(2) = "3"
        arr(3) = "3"
        arr(4) = "Emre Hıma"
        arr(5) = "2"
        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)

        arr(0) = "RTP105"
        arr(1) = "Radyo ve Televizyon PRG. Temelleri"
        arr(2) = "3"
        arr(3) = "3"
        arr(4) = "Gunay Sena"
        arr(5) = "2"
        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)

        arr(0) = "RTP107"
        arr(1) = "İletişim"
        arr(2) = "2"
        arr(3) = "3"
        arr(4) = "Gunay Sena"
        arr(5) = "3"
        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)

        arr(0) = "ZYD101"
        arr(1) = "Yabancı Dil I"
        arr(2) = "3"
        arr(3) = "2"
        arr(4) = "Kolin Kazım"
        arr(5) = "3"
        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)

        arr(0) = "ZAİ101"
        arr(1) = "Atatürk İlke ve İnkılapları"
        arr(2) = "3"
        arr(3) = "2"
        arr(4) = "Oya Gezer"
        arr(5) = "2"
        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		İçerik.Show()
		Close()
	End Sub

	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
		amaçkazanımrtv.Show()
		Close()
	End Sub

	Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class