Imports System.Data.SqlClient
Imports System.IO
Public Class Register
    Public Sub DilKontrol()
        If login.dilDurumu = 1 Then
            Label1.Text = "User Number:"
            Label2.Text = "Password:"
            Label3.Text = "Name:"
            Label5.Text = "Surname:"
            Label4.Text = "Gender:"
            Label6.Text = "Department:"
            Label8.Text = "Registration Date:"
            Label7.Text = "Adviser Teacher"
            Cınsıyetc.Items.Add("Man")
            Cınsıyetc.Items.Add("Woman")
            Cınsıyetc.Items.Add("Other")
            Label10.Text = "Registration Form"
            Button1.Text = "Register"
            Button2.Text = "Browse..."
        Else
            Label1.Text = "Kullanıcı No:"
            Label2.Text = "Şifre:"
            Label3.Text = "Adı:"
            Label5.Text = "Soyadı:"
            Label4.Text = "Cinsiyet:"
            Label6.Text = "Bölüm:"
            Label8.Text = "Kayıt Tarihi:"
            Label7.Text = "Danışman Öğretmen"
            Cınsıyetc.Items.Add("Erkek")
            Cınsıyetc.Items.Add("Kadın")
            Cınsıyetc.Items.Add("Diğer")
            Label10.Text = "KAYIT FORMU"
            Button1.Text = "Kayıt Ol"
            Button2.Text = "Gözat..."
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Server= CAGRI-SAMSUNG\Cagri; Database = db1; Integrated Security = True"
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "Select ogrenci_numara from ogrenciler where ogrenci_numara ='" & IdText.Text & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("Kullanıcı Adı zaten bulunmaktadır", MsgBoxStyle.Critical)
            con.Close()
        Else
            con.Close()
            con.Open()
            cmd = New SqlCommand("INSERT INTO  ogrenciler ( ogrenci_numara , ogrenci_adi , ogrenci_soyadi , ogrenci_cinsiyet , bolum_kodu , kayıt_tarih , ogrenci_sifre , danisman_ogretmen_numara,ders_sec,ogrenci_img) values('" & IdText.Text & "','" & Adtext.Text & "','" & Soyadtext.Text & "','" & Cınsıyetc.Text & "','" & bolumc.Text & "','" & KayıtText.Text & "','" & Sifretext.Text & "','" & ComboBox1.Text & "',0,@img)", con)

            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

            cmd.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()
            If (IdText.Text = "" And Sifretext.Text = "" And Cınsıyetc.Text = "" And Adtext.Text = "" And Soyadtext.Text = "" And bolumc.Text = "") Then
                MessageBox.Show("Değerler biribine eşit olamaz")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Kayıt Başarılı.", MsgBoxStyle.Information, "Success")
                Me.Hide()
                login.Show()
                IdText.Clear()
                Adtext.Clear()
                Cınsıyetc.Text = " "
                bolumc.Text = ""
                Sifretext.Clear()
            End If
            con.Close()
        End If
        con.Close()






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)

        End If
    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Sifretext.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DilKontrol()
        Sifretext.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub bolumc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bolumc.SelectedIndexChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Application.Exit()
    End Sub
End Class