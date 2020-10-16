Imports System.IO
Imports System.Data.SqlClient
Public Class danisman
    Dim baglanti As New SqlClient.SqlConnection("Data Source=CAGRI-SAMSUNG\Cagri;Initial Catalog=db1;Integrated Security=True")
    Dim komut As New SqlClient.SqlCommand

    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim dt2 As New DataTable
    Dim cm As CurrencyManager
    Dim cm2 As CurrencyManager
    Private Sub danisman_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        bilgiler()
        DanismanBilgi()
        resimYukle()
        DAnismanResimYukle()
        DilKontrol()

    End Sub
    Public Sub DilKontrol()
        If login.dilDurumu = 1 Then
            Button1.Text = "Transcript"
            Button2.Text = "Course Grade"
            Button3.Text = "Supervisor"
            Button4.Text = "Select Course"
        Else
            Button1.Text = "Transkript"
            Button2.Text = "Not Görüntüle"
            Button3.Text = "Danışman"
            Button4.Text = "Ders Seçim"
        End If
    End Sub
    Public Sub bilgiler()
        komut.CommandText = "Select * From ogrenciler Where ogrenci_numara='" & login.Numara & "'"
        komut.Connection = baglanti
        baglanti.Open()
        dt.Load(komut.ExecuteReader)
        Label2.DataBindings.Add("Text", dt, "ogrenci_adi")
        Label3.DataBindings.Add("Text", dt, "ogrenci_soyadi")
        Label4.DataBindings.Add("Text", dt, "Bolum_kodu")
        cm = BindingContext(dt)
        baglanti.Close()
        komut.Dispose()

    End Sub
    Public Sub DanismanBilgi()
        komut.CommandText = "Select ogretmen_adi,ogretmen_soyadi,bolum_kodu From ogretmenler Where ogretmen_numara IN (SELECT danisman_ogretmen_numara FROM ogrenciler WHERE ogrenci_numara='" & login.Numara & "')"
        komut.Connection = baglanti
        baglanti.Open()
        dt2.Load(komut.ExecuteReader)
        Label7.DataBindings.Add("Text", dt2, "ogretmen_adi")
        Label8.DataBindings.Add("Text", dt2, "ogretmen_soyadi")
        Label9.DataBindings.Add("Text", dt2, "bolum_kodu")
        cm2 = BindingContext(dt)

        baglanti.Close()
        komut.Dispose()
    End Sub
    Public Sub resimYukle()
        Dim komut As New SqlClient.SqlCommand("SELECT ogrenci_img FROM ogrenciler WHERE ogrenci_numara='" & login.Numara & "'", baglanti)
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(komut)
        adapter.Fill(table)
        If table.Rows(0)(0) Is DBNull.Value Then
            'MessageBox.Show("fotoğraf yüklenemedi")
        Else
            Dim img() As Byte
            img = table.Rows(0)(0)

            Dim ms As New MemoryStream(img)
            PictureBox1.Image = Image.FromStream(ms)
        End If


    End Sub
    Public Sub DanismanResimYukle()
        Dim komut As New SqlClient.SqlCommand("SELECT ogretmen_img FROM ogretmenler WHERE ogretmen_numara IN (SELECT danisman_ogretmen_numara FROM ogrenciler WHERE ogrenci_numara='" & login.Numara & "')", baglanti)
        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(komut)
        adapter.Fill(table)
        If table.Rows(0)(0) Is DBNull.Value Then
            MessageBox.Show("Danisman Öğretmen fotoğraf yüklenemedi")
        Else
            Dim img() As Byte
            img = table.Rows(0)(0)

            Dim ms As New MemoryStream(img)
            PictureBox2.Image = Image.FromStream(ms)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ogrenciNot.Show()
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        dersSecim.Show()
        Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Application.Exit()
    End Sub
End Class