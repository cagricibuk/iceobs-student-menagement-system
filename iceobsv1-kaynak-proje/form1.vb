Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Imports System.Data.SqlClient
Public Class Form1
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
            'MessageBox.Show("fotoğraf yüklenemedi")
        Else
            Dim img() As Byte
            img = table.Rows(0)(0)

            Dim ms As New MemoryStream(img)
            PictureBox1.Image = Image.FromStream(ms)
        End If


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DilKontrol()
        resimYukle()
        bilgiler()
        Dim cryRpt As New ReportDocument

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        crParameterDiscreteValue.Value = login.Numara
        crParameterFieldDefinitions = CrystalReport51.DataDefinition.ParameterFields
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("ogrenci_no")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        Dim crParameterFieldDefinitions2 As ParameterFieldDefinitions
        Dim crParameterFieldDefinition2 As ParameterFieldDefinition
        Dim crParameterValues2 As New ParameterValues
        Dim crParameterDiscreteValue2 As New ParameterDiscreteValue

        crParameterDiscreteValue2.Value = login.Numara
        crParameterFieldDefinitions2 = CrystalReport51.DataDefinition.ParameterFields
        crParameterFieldDefinition2 = crParameterFieldDefinitions2.Item("ogrenci_no2")
        crParameterValues2 = crParameterFieldDefinition2.CurrentValues

        crParameterValues2.Clear()
        crParameterValues2.Add(crParameterDiscreteValue2)
        crParameterFieldDefinition2.ApplyCurrentValues(crParameterValues2)

        CrystalReportViewer1.ReportSource = CrystalReport51
        CrystalReportViewer1.Refresh()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ogrenciNot.Show()
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