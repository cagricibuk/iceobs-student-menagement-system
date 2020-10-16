Imports System.Data.SqlClient
Imports System.IO
Public Class ogrenciNot
    Dim id As String
    Dim baglanti As New SqlClient.SqlConnection("Data Source=CAGRI-SAMSUNG\Cagri;Initial Catalog=db1;Integrated Security=True")
    Dim komut As New SqlClient.SqlCommand

    Dim ds As New DataSet
    Dim dt As New DataTable

    Dim cm As CurrencyManager
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
    Public Sub resimYukle()
        Dim komut As New SqlClient.SqlCommand("SELECT ogrenci_img FROM ogrenciler WHERE ogrenci_numara='" & login.Numara & "'", baglanti)
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


    Public Sub notlarigoster()

        '  Dim da As New SqlClient.SqlDataAdapter("Select ogrenci_numara,vize1,final1,but,proje1 From notlar ", baglanti)
        Dim da As New SqlClient.SqlDataAdapter("Select ders_kodu,vize1,final1,proje1 From notlar Where ogrenci_numara='" & id & "'", baglanti)
        ds.Clear()
        da.Fill(ds, "Table_1")
        DataGridView1.DataSource = ds.Tables("Table_1")
    End Sub



    Private Sub ogrenciNot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DilKontrol()
        bilgiler()
        resimYukle()
        DataGridView1.ReadOnly = True
        Dim Form1 As New login()
        Label1.Text = "Debug mod id " & login.Numara & "  rank " & login.rutbe
        id = login.Numara
        notlarigoster()
    End Sub







    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        danisman.Show()
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        dersSecim.Show()
        Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub
End Class