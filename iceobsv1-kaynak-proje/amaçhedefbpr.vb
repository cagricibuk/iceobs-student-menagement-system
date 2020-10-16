Public Class amaçhedefbpr
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BPRiçerik.Show()
        Close()
    End Sub
    Public Sub DilKontrol()
        If login.dilDurumu = 1 Then
            Button3.Text = "Back"
            Button2.Text = "Grade Information"
            Button1.Text = "Goals and Target"
            Label1.Text = "Goals"
            Label2.Text = "Target"
            RichTextBox1.Text = "Within the scope of Human Resources Development through Vocational Education and Training Project (HRD-VET), based on European Qualifications Framework (EQF) Level 5, it is aimed to develop curricula that are oriented towards the needs of the labour market in cooperation between post-secondary vocational education schools and Secondary Vocational and Technical Schools. IT sector is in steady and dynamic progress due to rapidy changing market and competitive requirements globally. With these defining characteristics of the IT sector, it attracts close interest as a key industrial element for the countries and customized plans are devised to promote progress. In particular, competition has become intensive in rapidly globalizing business world, and industrialized coutries has applied special policies to preserve continuity and improve competitive power in the IT sector. Computer Programming Program aims to train inter-labour force in order to gather information, process information and analyse problems via computers intended for the needs of business life and communial life reqirements."
            RichTextBox2.Text = "This program mainly aims to educate graduates who are enthusiastic, respectful, skilled, creative and innovative towards their profession. Our mission in this program is also to train graduates who are highy competent and can easily adapt themselves into the rapidly changing situations in the field of IT."
        Else
            Button3.Text = "Geri"
            Button2.Text = "Ders Bilgileri"
            Button1.Text = "Amaçlar ve Hedefler"
            Label1.Text = "Amaç"
            Label2.Text = "Hedefler"
            RichTextBox1.Text = "İnsan Kaynaklarının Mesleki Eğitim Yoluyla Geliştirilmesi Projesi (İKMEP) kapsamında, beşinci seviye meslek standartlarına dayalı olarak, işgücü piyasası ile meslek yüksekokulları ve mesleki teknik ortaöğretim kurumları arasında istihdama yönelik öğretim programlarının geliştirilmesi amaçlanmıştır. Bilgisayar teknolojileri sektörü, küresel düzeyde hızla değişen pazar ve rekabet koşulları nedeni ile sürekli ve dinamik bir gelişim içindedir. Bu özellikleri nedeni ile bilgisayar teknolojileri sektörü, stratejik bir sanayi olarak ülkelerin yakın ilgisini çekmekte ve bu sektör için devletler tarafından özel planlamalar yapılmaktadır. Özellikle hızla küreselleşen iş dünyasında rekabet büyük yoğunluk kazanmakta ve sanayileşmiş ülkeler bu sektörün korunması ve rekabet gücünün geliştirilmesi için özel politikalar uygulamaktadır. Bilgisayar Programcılığı programının amacı, iş hayatının ve toplumsal yaşamın bilgi toplama ve bu bilgileri işleme ile ilgili konularındaki problemlerinin bilgisayarda çözümlenmesi alanlarında çalışacak ara insan gücünü yetiştirmektir."
            RichTextBox2.Text = "Dürüst, mesleğini severek yürütecek, donanımlı, saygılı, yaratıcı, yenilikçi; ülkemize, üniversitemize ve bölümümüze layık, etik ilkelerden ve bilim ahlakından ödün vermeyen mezunlar yetiştirmek bölümümüzün başlıca hedefidir. Mesleki hedefimiz, bilgisayar dünyasında kendisini yeniliklere hızlı bir şekilde adapte edebilen, bilgisayar programcılığı konusunda bilgi sahibi bireyler yetiştirmektir."

        End If
    End Sub
    Private Sub amaçhedefbpr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DilKontrol()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        İçerik.Show()
        Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class