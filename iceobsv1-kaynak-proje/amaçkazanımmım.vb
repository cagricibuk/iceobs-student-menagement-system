Public Class amaçkazanımmım
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Mimariçerik.Show()
        Close()
    End Sub
    Public Sub DilKontrol()
        If login.dilDurumu = 1 Then
            Button3.Text = "Back"
            Button2.Text = "Grade Information"
            Button1.Text = "Goals and Target"
            Label1.Text = "Goals"
            Label2.Text = "Target"
            RichTextBox1.Text = "Ulusal ve uluslararası çerçevede günümüz kent ve mimarlık konularını irdeleyebilen, çağdaş ve evrensel değerleri benimseyebilen, eleştirel ve bilimsel düşünebilen, bilgi birikimini insanlık yararına kullanabilen, disiplinler arası işbirliği yapabilen; yaratıcı, yenilikçi, araştırmacı, mimarlığı anlama ve yorumlama yetisine sahip mimarlar yetiştirmek."
            RichTextBox2.Text = "Bu program mimar olma bilincini geliştirerek değişen yaşam koşulları doğrultusunda toplumun ve bireyin beklentilerine cevap verebilmeyi, mimarlık alanındaki edinimleri doğru kullanabilmeyi ve kültürel değerlere saygılı olmayı içeren bir eğitimi hedeflemektedir."

        Else
            Button3.Text = "Geri"
            Button2.Text = "Ders Bilgileri"
            Button1.Text = "Amaçlar ve Hedefler"
            Label1.Text = "Amaç"
            Label2.Text = "Hedefler"
            RichTextBox1.Text = "To educate architects who are able to inquire issues on contemporary urbanization and architecture in national and international scale, to adopt modern and universal values, to think critically and scientifically, to use acquired knowledge fort the benefit of humanity, to cooperate in inter-disciplinary studies; creative, innovative, inquisitive architects who have the ability to understand and evaluate architecture."
            RichTextBox2.Text = "The aim of this program is to provide a kind of education which can meet the expectations of society and individuals with respect to the changing conditions of living by developing the consciousness of being an architect, use the accumulated knowledge of architecture properly and have respect for cultural values."

        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        İçerik.Show()
        Close()

    End Sub

    Private Sub İçerikkazançmım_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DilKontrol()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class