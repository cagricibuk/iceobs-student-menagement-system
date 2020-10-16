Imports System.Data.SqlClient
Imports Microsoft.Win32

Public Class login
    Public Shared dilDurumu As Integer = 0
    Public Shared rutbe As Integer = 0
    Public Shared Numara As String
    Dim deneme As Integer = 3
    Private Sub RegCheck()
        Dim deger As String
        If Registry.CurrentUser.OpenSubKey("iceobs-lang") Is Nothing Then
            ' MessageBox.Show("Dil keyi bulunamadı!!!")


        Else
            ' MessageBox.Show("Dil keyi bulundu")
            If Registry.CurrentUser.OpenSubKey("iceobs-lang", True).GetValue("lang") Is Nothing Then
                '    MessageBox.Show("Dil keyi değer bulunamadı!!!")
            Else
                deger = Registry.CurrentUser.OpenSubKey("iceobs-lang", True).GetValue("lang").ToString
            End If
        End If
        'MsgBox(deger)
        If deger = "EN" Then
            dilDurumu = 1
        ElseIf deger = "TR" Then
            dilDurumu = 0
        End If
        'MsgBox(dilDurumu)
    End Sub
    Private Sub DilKontrol()
        If dilDurumu = 1 Then
            Label1.Text = "Number"
            Label2.Text = "Password"
            CheckBox1.Text = "Show Password"
            Button1.Text = "Login"
            Button4.Text = "Teacher Register"
            Button5.Text = "Student Register"

        Else
            Label1.Text = "Numara"
            Label2.Text = "Şifre"
            CheckBox1.Text = "Şifreyi Göster"
            Button1.Text = "Giriş"
            Button4.Text = "Öğretmen Kayıt"
            Button5.Text = "Öğrenci Kayıt"

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        deneme -= 1
        If deneme < 0 Then
            MessageBox.Show("bir kerede 3 kere giriş denemesi yapabilirsiniz !")


        Else
            If (TextBox1.Text.Length > 3) Then


                Dim connection As New SqlConnection("Server= CAGRI-SAMSUNG\Cagri; Database = db1; Integrated Security = True")
                connection.Open()
                Dim command As New SqlCommand("select ogrenci_numara , ogrenci_sifre from ogrenciler where ogrenci_numara = @username and ogrenci_sifre = @password", connection)



                command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBox1.Text
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBox2.Text

                Numara = TextBox1.Text
                Dim adapter As New SqlDataAdapter(command)

                Dim table As New DataTable()


                adapter.Fill(table)


                If table.Rows.Count() <= 0 Then

                    MessageBox.Show("Kullanıcı Adınız ve ya Şifreniz yanlış")

                Else

                    ' MessageBox.Show("Giriş Başarılı" & Numara)
                    rutbe = 0
                    ogrenciMain.Show()
                    Close()
                    connection.Close()

                End If
            Else

                Dim connection As New SqlConnection("Data Source=CAGRI-SAMSUNG\Cagri;Initial Catalog=db1;Integrated Security=True")
                connection.Open()
                Dim command As New SqlCommand("select ogretmen_numara , ogretmen_sifre from ogretmenler where ogretmen_numara = @username and ogretmen_sifre = @password", connection)



                command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBox1.Text
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBox2.Text
                Numara = TextBox1.Text
                Dim adapter As New SqlDataAdapter(command)

                Dim table As New DataTable()


                adapter.Fill(table)


                If table.Rows.Count() <= 0 Then

                    MessageBox.Show("Kullanıcı Adınız ve ya Şifreniz yanlış")

                Else

                    




                    rutbe = 1
                    ogretmenMain.Show()
                    Close()
                    connection.Close()

                End If

            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked


    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked
        RegCheck()
        DilKontrol()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ÖRegister.Show()
        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Register.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim deger As String
        If Registry.CurrentUser.OpenSubKey("iceobs-lang") Is Nothing Then
            ' MessageBox.Show("Dil keyi bulunamadı!!!")
            Registry.CurrentUser.CreateSubKey("iceobs-lang", True).SetValue("lang", "EN")

        Else
            MessageBox.Show("Dil keyi bulundu")
            If Registry.CurrentUser.OpenSubKey("iceobs-lang", True).GetValue("lang") Is Nothing Then
                Registry.CurrentUser.OpenSubKey("iceobs-lang", True).SetValue("lang", "EN")
            Else
                Registry.CurrentUser.OpenSubKey("iceobs-lang", True).SetValue("lang", "EN")
                deger = Registry.CurrentUser.OpenSubKey("iceobs-lang", True).GetValue("lang").ToString
                Registry.CurrentUser.OpenSubKey("iceobs-lang", True).Close()
            End If
        End If
        'MsgBox(deger)
        If deger = "EN" Then
            dilDurumu = 1
        ElseIf deger = "TR" Then
            dilDurumu = 0
        End If
        'MsgBox(dilDurumu)
        DilKontrol()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim deger As String
        If Registry.CurrentUser.OpenSubKey("iceobs-lang") Is Nothing Then
            '  MessageBox.Show("Dil keyi bulunamadı!!!")
            Registry.CurrentUser.CreateSubKey("iceobs-lang", True).SetValue("lang", "TR")

        Else
            ' MessageBox.Show("Dil keyi bulundu")
            If Registry.CurrentUser.OpenSubKey("iceobs-lang", True).GetValue("lang") Is Nothing Then
                Registry.CurrentUser.OpenSubKey("iceobs-lang", True).SetValue("lang", "TR")
            Else
                Registry.CurrentUser.OpenSubKey("iceobs-lang", True).SetValue("lang", "TR")
                deger = Registry.CurrentUser.OpenSubKey("iceobs-lang", True).GetValue("lang").ToString
                Registry.CurrentUser.OpenSubKey("iceobs-lang", True).Close()
            End If
        End If
        'MsgBox(deger)
        If deger = "EN" Then
            dilDurumu = 1
        ElseIf deger = "TR" Then
            dilDurumu = 0
        End If
        'MsgBox(dilDurumu)
        DilKontrol()
    End Sub


End Class
