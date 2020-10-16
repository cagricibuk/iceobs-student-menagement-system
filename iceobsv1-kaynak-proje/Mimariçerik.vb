Public Class Mimariçerik
	Private Sub Button1_Click(sender As Object, e As EventArgs)
		Hide()
		İçerik.Show()

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
	Private Sub Mimariçerik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
		arr(0) = "MIM101"
		arr(1) = "Mimari Projeye Giriş"
		arr(2) = "6"
		arr(3) = "8"
		arr(4) = "Emre Hamza"
		arr(5) = "8"
		itm = New ListViewItem(arr)
		ListView1.Items.Add(itm)

		arr(0) = "MIM102"
		arr(1) = "Temel Tasarım I"
		arr(2) = "3"
		arr(3) = "5"
		arr(4) = "Hande Yılmaz"
		arr(5) = "5"
		itm = New ListViewItem(arr)
		ListView1.Items.Add(itm)

		arr(0) = "MIM103"
		arr(1) = "Mimarı Anlatım Teknikleri"
		arr(2) = "3"
		arr(3) = "5"
		arr(4) = "Hande Yılmaz"
		arr(5) = "4"
		itm = New ListViewItem(arr)
		ListView1.Items.Add(itm)

		arr(0) = "MIM104"
		arr(1) = "MAT111"
		arr(2) = "3"
		arr(3) = "4"
		arr(4) = "Dost Kayaoğlu"
		arr(5) = "4"
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

	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
		amaçkazanımmım.Show()
		Close()

	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		İçerik.Show()
		Close()

	End Sub

	Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class