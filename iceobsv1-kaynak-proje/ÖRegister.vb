
Imports System.Data.SqlClient
Imports System.IO

Public Class ÖRegister
    Public Sub DilKontrol()
        If login.dilDurumu = 1 Then

            Button1.Text = "Browse"
            Button2.Text = "Register"
            Label1.Text = "Teacher No:"
            Label2.Text = "Teacher Name:"
            Label3.Text = "Teacher Surname:"
            Label4.Text = "Grender:"
            Label5.Text = "Department:"
            Label6.Text = "Password"
            CinsiyetC.Items.Clear()
            CinsiyetC.Items.Add("Man")
            CinsiyetC.Items.Add("Woman")
            CinsiyetC.Items.Add("Other")
            CheckBox1.Text = "Show Password"
            Label10.Text = "Registration Form"

        Else

            Button1.Text = "Gözat..."
            Button2.Text = "Kayıt Ol"
            Label1.Text = "Öğretmen No:"
            Label2.Text = "Öğretmen Adı:"
            Label3.Text = "Öğretmen Soyadı:"
            Label4.Text = "Cinsiyet:"
            Label5.Text = "Bölümü:"
            Label6.Text = "Şifre"
            CinsiyetC.Items.Clear()
            CinsiyetC.Items.Add("Erkek")
            CinsiyetC.Items.Add("Kadın")
            CinsiyetC.Items.Add("Diğer")
            CheckBox1.Text = "Şifreyi Göster"
            Label10.Text = "KAYIT FORMU"
        End If
    End Sub
    Private Sub ÖRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DilKontrol()
        SifreText.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Server= CAGRI-SAMSUNG\Cagri; Database = db1; Integrated Security = True"
        con.Open()
        cmd.Connection = con
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "Select ogretmen_numara from ogretmenler where ogretmen_numara ='" & NoText.Text & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("Kullanıcı Adı zaten bulunmaktadır", MsgBoxStyle.Critical)
            con.Close()
        Else
            con.Close()
            con.Open()
            cmd = New SqlCommand("INSERT INTO  ogretmenler ( ogretmen_numara , ogretmen_adi , ogretmen_soyadi , ogretmen_cinsiyet , bolum_kodu ,  ogretmen_sifre , ogretmen_img) values('" & NoText.Text & "','" & AdText.Text & "','" & SoyadText.Text & "','" & CinsiyetC.Text & "','" & BölümC.Text & "','" & SifreText.Text & "',@img)", con)
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

            cmd.Parameters.Add("@img", SqlDbType.Image).Value = ms.ToArray()

            If (NoText.Text = "" And SifreText.Text = "" And CinsiyetC.Text = "" And AdText.Text = "" And SoyadText.Text = "" And BölümC.Text = "") Then
                MessageBox.Show("Değerler biribine eşit olamaz")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Kayıt Başarılı.", MsgBoxStyle.Information, "Success")
                Me.Hide()
                login.Show()
                NoText.Clear()
                AdText.Clear()
                CinsiyetC.Text = " "
                BölümC.Text = ""
                SifreText.Clear()
            End If
            con.Close()
        End If
        con.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        SifreText.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Application.Exit()
    End Sub
End Class