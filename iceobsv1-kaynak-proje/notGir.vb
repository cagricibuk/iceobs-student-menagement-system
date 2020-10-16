Imports System.Data.SqlClient
Public Class notGir
    Dim baglanti As New SqlClient.SqlConnection("Data Source=CAGRI-SAMSUNG\Cagri;Initial Catalog=db1;Integrated Security=True")
    Dim komut As New SqlClient.SqlCommand
   
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim durum As Integer = 0

    Public Sub DilKontrol()
        If login.dilDurumu = 1 Then
            GroupBox1.Text = "Class"
            Label1.Text = "Class"
            Label2.Text = "Depart"
            Button1.Text = "List"
            GroupBox2.Text = "Point"
            Label3.Text = "Student Number"
            Label7.Text = "Project"
            Button2.Text = "Save"
            Button3.Text = "Back"
        Else
            GroupBox1.Text = "Ders"
            Label1.Text = "Ders"
            Label2.Text = "Bölüm"
            Button1.Text = "Listele"
            GroupBox2.Text = "Puan"
            Label3.Text = "Öğrenci Numarası"
            Label7.Text = "Proje"
            Button2.Text = "Kaydet"
            Button3.Text = "Geri"
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DilKontrol()
        ComboBox2.Text = "BPR"


        dersleriGoster()
        notlarigoster()


    End Sub

    Public Sub notlarigoster()

        '  Dim da As New SqlClient.SqlDataAdapter("Select ogrenci_numara,vize1,final1,but,proje1 From notlar ", baglanti)
        Dim da As New SqlClient.SqlDataAdapter("Select ders_kodu,ogrenci_numara,vize1,final1,but,proje1 From notlar Where ders_kodu='" & ComboBox1.Text & "'", baglanti)
        ds.Clear()
        da.Fill(ds, "Table_1")
        DataGridView1.DataSource = ds.Tables("Table_1")
    End Sub

    Public Sub dersleriGoster()
        Dim da As New SqlClient.SqlDataAdapter("Select * From tumdersler Where Bolum_kodu='" & ComboBox2.Text & "'", baglanti)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox1.DataSource = dt
        ComboBox1.DisplayMember = "ders_kodu"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        notlarigoster()
        ' dersleriGoster()

    End Sub
    Dim ders_id As String
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim satır As Integer
            satır = DataGridView1.CurrentCell.RowIndex
            TextBox1.Text = DataGridView1(1, satır).Value
            TextBox2.Text = DataGridView1(2, satır).Value
            TextBox3.Text = DataGridView1(3, satır).Value
            TextBox4.Text = DataGridView1(4, satır).Value
            TextBox5.Text = DataGridView1(5, satır).Value
            ders_id = DataGridView1(0, satır).Value
            DataGridView1.ReadOnly = True
        Catch ex As Exception
            MsgBox("Hata")
        End Try
       


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        komut.Connection = baglanti
        komut.CommandText = "Update notlar set ogrenci_numara='" & TextBox1.Text & "', vize1='60', final1= '60', but='60',proje1='60' WHERE ogrenci_numara='" & TextBox1.Text & "' AND ders_kodu='" & ComboBox1.Text & "'"
        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()

        notlarigoster()

    End Sub

    Public Sub not_gir()
        komut.Connection = baglanti
        komut.CommandText = "Insert Into notlar(ders_kodu,ogrenci_numara,vize1,final1,but,proje1) VALUES ('" & ComboBox1.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()
        notlarigoster()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ogretmenMain.Show()
        Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class
