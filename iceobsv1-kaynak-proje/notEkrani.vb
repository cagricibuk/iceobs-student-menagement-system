Imports System.Data.SqlClient
Public Class notEkrani
    Dim baglanti As New SqlClient.SqlConnection("Data Source=CAGRI-SAMSUNG\Cagri;Initial Catalog=db1;Integrated Security=True")
    Dim komut As New SqlClient.SqlCommand

    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim cm As CurrencyManager
    Public id As String

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
    Private Sub SetupListView()

        ListView1.Columns.Add("ders_kodu", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("vize1", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("final1", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("proje1", 100, HorizontalAlignment.Left)



        ListView1.View = View.Details

        ListView1.GridLines = True

        ListView1.FullRowSelect = True
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DilKontrol()
        Dim Form1 As New login()
        Label1.Text = "Debug mod id " & login.Numara & "  rank " & login.rutbe
        id = login.Numara
        bilgiler()
        SetupListView()
        Dim dr As SqlDataReader
        baglanti.ConnectionString = ("Data Source=CAGRI-SAMSUNG\Cagri;Initial Catalog=db1;Integrated Security=True")
        Dim komut As New SqlCommand("SELECT * FROM notlar WHERE ogrenci_numara='" & id & "'", baglanti)
        baglanti.Open()
        dr = komut.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Dim newitem As New ListViewItem()
                newitem.Text = dr.GetValue(0) 'first column
                newitem.SubItems.Add(dr.GetValue(1)) 'second column
                newitem.SubItems.Add(dr.GetValue(3))
                newitem.SubItems.Add(dr.GetValue(6))
                ListView1.Items.Add(newitem)

            End While
        End If
        baglanti.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        dersSecim.Show()
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        danisman.Show()
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()

        Close()
    End Sub
End Class