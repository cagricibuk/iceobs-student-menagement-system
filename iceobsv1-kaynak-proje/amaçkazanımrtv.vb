Public Class amaçkazanımrtv
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        İçerik.Show()
        Close()
    End Sub
    Public Sub DilKontrol()
        If login.dilDurumu = 1 Then
            Button3.Text = "Back"
            Button2.Text = "Grade Information"
            Button1.Text = "Goals and Target"
            Label1.Text = "Goals"
            Label2.Text = "Target"
            RichTextBox1.Text = "Program aims to train technical staff who follow new technology; know Radio, television electronical technology. It also aims good quality staff who have knowledge, abilities and working discipline, ethic and responsible values; who are open to technological developments for audiovisual and written media sector.
"
            RichTextBox2.Text = "The students graduated from Technical Vocational School, Radio and Television Technology Program will have all kind of knowledge and experience about broadcast for media sector and production firms. They can work for audiovisual and written media sector as director, vise director, productor, vise productor, voice ,vision and lighting technician and their assistants and e.t.c."

        Else
            Button3.Text = "Geri"
            Button2.Text = "Ders Bilgileri"
            Button1.Text = "Amaçlar ve Hedefler"
            Label1.Text = "Amaçlar"
            Label2.Text = "Hedefler"
            RichTextBox1.Text = "Programının amacı; teknolojik ve bilimsel gelişmelere paralel olarak, radyo ve televizyon alanında gerekli mesleki yeterlilikler ile ilgili bilgi, beceri ve çalışma disiplini ile donatılmış, etik değerlere ve sorumluluk bilincine sahip, teknolojik gelişmelere açık, görsel, işitsel ve yazılı medya kuruluşlarına sektörün ihtiyacı olan, nitelikli teknik yapım ve yayın meslek elemanları yetiştirmektir.
"
            RichTextBox2.Text = "Teknik Bilimler Meslek Yüksekokulu Radyo ve Televizyon Teknolojisi Programından mezun olan öğrencilerimiz, medya kurum ve kuruluşlarında, prodüksiyon şirketlerinde yapım ve yayıncılıkla ilgili her türlü bilgiye ve deneyime sahip olacaklardır. Mezunlarımız, görsel ve işitsel medya kurum ve kuruluşlarında yönetmen, yapımcı, yapım- yönetim yardımcısı, görüntü yönetmeni, kameraman, kurgu operatörü, ses teknikeri, ışık teknikeri, resim seçici vb. işlerde çalışabilirler.
"

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RTViçerik.Show()
        Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub amaçkazanımrtv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DilKontrol()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class