Imports System.Data.SqlClient
Imports System.IO
Public Class İçerik
    Dim baglanti As New SqlClient.SqlConnection("Data Source=CAGRI-SAMSUNG\Cagri;Initial Catalog=db1;Integrated Security=True")
    Dim komut As New SqlClient.SqlCommand

    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim cm As CurrencyManager
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        BPRiçerik.Show()
        Hide()
    End Sub
    Public Sub DilKontrol()
        If login.dilDurumu = 1 Then
            Label8.Text = "Technical Sciences Vocational College Course Info"
            Button1.Text = "My Students"
            Button2.Text = "Registration Confirmation"
            Button3.Text = "My Courses"
            Button4.Text = "Grade Entry"
            Button5.Text = "Course Catalog Description"
            Button6.Text = "Course Presentation"
            Button7.Text = "Computer Programming Grade Content"
            Button8.Text = "Radio and Television Programming"
            Button9.Text = "Architecture Programming"
        Else
            Label8.Text = "Teknik Bilimler Meslek Yüksekokulu Ders İçerikleri"
            Button1.Text = "Danışmanı Olduğum"
            Button2.Text = "Kayıt Onay"
            Button3.Text = "Verdiğim Dersler"
            Button4.Text = "Not Girişi"
            Button5.Text = "Ders Katalog Tanım"
            Button6.Text = "Ders Sunum"
            Button7.Text = "Bilgisayar Programcılığı Ders İçeriği"
            Button8.Text = "Radyo ve Televizyon Programcılığı"
            Button9.Text = "Mimarlık Programcılığı"
        End If
    End Sub
    Public Sub bilgiler()
        komut.CommandText = "Select * From ogretmenler Where ogretmen_numara='" & login.Numara & "'"
        komut.Connection = baglanti
        baglanti.Open()
        dt.Load(komut.ExecuteReader)
        Label2.DataBindings.Add("Text", dt, "ogretmen_adi")
        Label3.DataBindings.Add("Text", dt, "ogretmen_soyadi")
        Label4.DataBindings.Add("Text", dt, "bolum_kodu")
        cm = BindingContext(dt)
        baglanti.Close()
        komut.Dispose()
    End Sub
    Public Sub resimYukle()
        Dim komut As New SqlClient.SqlCommand("SELECT ogretmen_img FROM ogretmenler WHERE ogretmen_numara='" & login.Numara & "'", baglanti)
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(komut)
        adapter.Fill(table)
        If table.Rows(0)(0) Is DBNull.Value Then
            MessageBox.Show("fotoğraf yüklenemedi")
        Else
            Dim img() As Byte
            img = table.Rows(0)(0)

            Dim ms As New MemoryStream(img)
            PictureBox1.Image = Image.FromStream(ms)
        End If


    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RTViçerik.Show()
        Hide()


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Hide()
        Mimariçerik.Show()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        danismaniOldugum.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        verdigimDersler.Show()
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        notGir.Show()
        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        dersSunum.Show()
        Close()
    End Sub

    Private Sub İçerik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bilgiler()
        resimYukle()
        DilKontrol()
    End Sub
End Class