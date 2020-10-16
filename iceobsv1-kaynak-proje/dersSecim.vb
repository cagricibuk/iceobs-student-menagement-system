Imports System.Data.SqlClient
Imports System.IO
Public Class dersSecim


    Public id As String
    Dim baglanti As New SqlClient.SqlConnection("Data Source=CAGRI-SAMSUNG\Cagri;Initial Catalog=db1;Integrated Security=True")
    Dim komut As New SqlClient.SqlCommand

    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim cm As CurrencyManager

    Dim dt2 As New DataTable
    Public Sub DilKontrol()
        If login.dilDurumu = 1 Then
            Button1.Text = "Transcript"
            Button2.Text = "Course Grade"
            Button3.Text = "Supervisor"
            Button4.Text = "Select Course"
            Button5.Text = "Add Selected"
            Button6.Text = "Delete Selected"
            Button7.Text = "Complete Registration"

        Else
            Button1.Text = "Transkript"
            Button2.Text = "Not Görüntüle"
            Button3.Text = "Danışman"
            Button4.Text = "Ders Seçim"
            Button5.Text = "Seçilenleri Ekle"
            Button6.Text = "Seçilenleri Kaldır"
            Button7.Text = "Kaydı Tamamla"

        End If
    End Sub
    Private Sub Yukle2()

        Dim dr As SqlDataReader

        baglanti.ConnectionString = ("Data Source=CAGRI-SAMSUNG\Cagri;Initial Catalog=db1;Integrated Security=True")
        Dim komut As New SqlCommand("SELECT * FROM ogrencidersler WHERE ogrenci_numara ='" & id & "'", baglanti)
        baglanti.Open()
        dr = komut.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Dim newitem As New ListViewItem()
                newitem.Text = dr.GetValue(1) 'first column
                newitem.SubItems.Add(dr.GetValue(2)) 'second column
                newitem.SubItems.Add(dr.GetValue(3))
                newitem.SubItems.Add(dr.GetValue(4))
                newitem.SubItems.Add(dr.GetValue(5))
                ListView2.Items.Add(newitem)

            End While
        End If

        baglanti.Close()

    End Sub
    Private Sub Yukle1()
        Dim dr As SqlDataReader

        baglanti.ConnectionString = ("Data Source=CAGRI-SAMSUNG\Cagri;Initial Catalog=db1;Integrated Security=True")
        Dim komut As New SqlCommand("SELECT * FROM sunulandersler WHERE bolum_kodu IN (SELECT bolum_kodu FROM ogrenciler WHERE ogrenci_numara='" & id & "')", baglanti)
        baglanti.Open()
        dr = komut.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Dim newitem As New ListViewItem()
                newitem.Text = dr.GetValue(0) 'first column
                newitem.SubItems.Add(dr.GetValue(1)) 'second column
                newitem.SubItems.Add(dr.GetValue(2))
                newitem.SubItems.Add(dr.GetValue(3))
                newitem.SubItems.Add(dr.GetValue(4))
                newitem.SubItems.Add(dr.GetValue(6))
                newitem.SubItems.Add(dr.GetValue(7))
                ListView1.Items.Add(newitem)

            End While
        End If

        baglanti.Close()
    End Sub
    Private Sub SetupListView1()
        'add columns to the listview
        ListView1.Columns.Add("ders_kodu", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Ders Adı", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("akts", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("kredi", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("ders saati", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("bolum kodu", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("öğretmen numara", 100, HorizontalAlignment.Left)


        'Display listview in details view
        ListView1.View = View.Details
        'display grid lines
        ListView1.GridLines = True
        'allow full row selection
        ListView1.FullRowSelect = True
    End Sub
    Private Sub SetupListView2()
        'add columns to the listview
        ListView2.Columns.Add("ders_kodu", 100, HorizontalAlignment.Left)
        ListView2.Columns.Add("Ders Adı", 100, HorizontalAlignment.Left)
        ListView2.Columns.Add("akts", 100, HorizontalAlignment.Left)
        ListView2.Columns.Add("kredi", 100, HorizontalAlignment.Left)
        ListView2.Columns.Add("ders saati", 100, HorizontalAlignment.Left)




        'Display listview in details view
        ListView2.View = View.Details
        'display grid lines
        ListView2.GridLines = True
        'allow full row selection
        ListView2.FullRowSelect = True
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
            'MessageBox.Show("fotoğraf yüklenemedi")
        Else
            Dim img() As Byte
            img = table.Rows(0)(0)

            Dim ms As New MemoryStream(img)
            PictureBox1.Image = Image.FromStream(ms)
        End If


    End Sub

    Private Sub dersSecim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DilKontrol()
        id = login.Numara
        bilgiler()
        resimYukle()
        SetupListView1()
        SetupListView2()
        Yukle1()
        Yukle2()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        baglanti.ConnectionString = ("Data Source=CAGRI-SAMSUNG\Cagri;Initial Catalog=db1;Integrated Security=True")
        Try
            If ListView1.SelectedItems.Count > 1 Then

                For i As Integer = 0 To ListView1.SelectedItems.Count - 1
                    baglanti.Open()
                    Dim komut As New SqlCommand("INSERT INTO ogrencidersler (ders_kodu,ders_adi,akts,kredi,ders_saati,ogrenci_numara) SELECT ders_kodu,ders_adi,akts,kredi,ders_saati,'" & id.ToString & "' FROM sunulandersler WHERE ders_kodu='" & ListView1.SelectedItems(i).Text & "';", baglanti)
                    'MessageBox.Show(komut.CommandText)
                    komut.ExecuteNonQuery()
                    baglanti.Close()
                Next
            Else
                baglanti.Open()
                Dim komut As New SqlCommand("INSERT INTO ogrencidersler (ders_kodu,ders_adi,akts,kredi,ders_saati,ogrenci_numara) SELECT ders_kodu,ders_adi,akts,kredi,ders_saati,'" & id.ToString & "' FROM sunulandersler WHERE ders_kodu='" & ListView1.SelectedItems(0).Text & "';", baglanti)
                'MessageBox.Show(komut.CommandText)
                komut.ExecuteNonQuery()
                baglanti.Close()
            End If
            MessageBox.Show("Aktarma Başarılı")
            ListView2.Clear()
            SetupListView2()
            Yukle2()
        Catch ex As Exception
            MessageBox.Show("Aynı dersten bir tane seçebilirsiniz !")
            'MessageBox.Show(ex.ToString)
            baglanti.Close()
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        baglanti.ConnectionString = ("Data Source=CAGRI-SAMSUNG\Cagri;Initial Catalog=db1;Integrated Security=True")
        If ListView2.SelectedItems.Count > 1 Then

            For i As Integer = 0 To ListView2.SelectedItems.Count - 1
                baglanti.Open()
                Dim komut As New SqlCommand("DELETE FROM ogrencidersler WHERE ders_kodu='" & ListView2.SelectedItems(i).Text & "' AND ogrenci_numara='" & id & "'", baglanti)
                MsgBox(komut.CommandText)

                komut.ExecuteNonQuery()
                baglanti.Close()
            Next
        Else
            baglanti.Open()
            Dim komut As New SqlCommand("DELETE FROM ogrencidersler WHERE ders_kodu='" & ListView2.SelectedItems(0).Text & "' AND ogrenci_numara='" & id & "'", baglanti)
            MsgBox(komut.CommandText)
            komut.ExecuteNonQuery()
            baglanti.Close()
        End If
        MessageBox.Show("Silme Başarılı")
        ListView2.Clear()
        SetupListView2()
        Yukle2()
    End Sub





    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        baglanti.ConnectionString = ("Data Source=CAGRI-SAMSUNG\Cagri;Initial Catalog=db1;Integrated Security=True")
        baglanti.Open()
        Dim komut As New SqlCommand("UPDATE ogrenciler SET ders_sec =1 WHERE ogrenci_numara='" & login.Numara & "'", baglanti)
        MsgBox(komut.CommandText)
        komut.ExecuteNonQuery()
        baglanti.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ogrenciNot.Show()
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

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub
End Class