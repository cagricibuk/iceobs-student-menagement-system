Imports System.IO
Imports System.Data.SqlClient
Public Class ogretmenMain
    Public id As String
    Dim baglanti As New SqlClient.SqlConnection("Data Source=CAGRI-SAMSUNG\Cagri;Initial Catalog=db1;Integrated Security=True")
    Dim komut As New SqlClient.SqlCommand

    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim cm As CurrencyManager
    Public Sub DilKontrol()
        If login.dilDurumu = 1 Then
            Button1.Text = "My Students"
            Button2.Text = "Registration Confirmation"
            Button3.Text = "My Courses"
            Button4.Text = "Grade Entry"
            Button5.Text = "Course Catalog Description"
            Button6.Text = "Course Presentation"
        Else
            Button1.Text = "Danışmanı Olduğum"
            Button2.Text = "Kayıt Onay"
            Button3.Text = "Verdiğim Dersler"
            Button4.Text = "Not Girişi"
            Button5.Text = "Ders Katalog Tanım"
            Button6.Text = "Ders Sunum"
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
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DilKontrol()
        bilgiler()
        resimYukle()
        Dim Form1 As New login()
        id = login.Numara
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        danismaniOldugum.Show()
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        kayitOnay.Show()
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
        İçerik.Show()
        Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        dersSunum.Show()
        Close()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub
End Class