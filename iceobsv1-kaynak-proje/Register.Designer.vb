<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.IdText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cınsıyetc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Sifretext = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Adtext = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Soyadtext = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bolumc = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.KayıtText = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdText
        '
        Me.IdText.Location = New System.Drawing.Point(163, 53)
        Me.IdText.Name = "IdText"
        Me.IdText.Size = New System.Drawing.Size(100, 20)
        Me.IdText.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(69, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kullanıcı NO"
        '
        'Cınsıyetc
        '
        Me.Cınsıyetc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cınsıyetc.FormattingEnabled = True
        Me.Cınsıyetc.Items.AddRange(New Object() {"Erkek", "Kadın", "Diğer"})
        Me.Cınsıyetc.Location = New System.Drawing.Point(142, 249)
        Me.Cınsıyetc.Name = "Cınsıyetc"
        Me.Cınsıyetc.Size = New System.Drawing.Size(121, 21)
        Me.Cınsıyetc.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(134, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Şifre"
        '
        'Sifretext
        '
        Me.Sifretext.Location = New System.Drawing.Point(163, 104)
        Me.Sifretext.Name = "Sifretext"
        Me.Sifretext.Size = New System.Drawing.Size(100, 20)
        Me.Sifretext.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(134, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Adı"
        '
        'Adtext
        '
        Me.Adtext.Location = New System.Drawing.Point(163, 155)
        Me.Adtext.Name = "Adtext"
        Me.Adtext.Size = New System.Drawing.Size(100, 20)
        Me.Adtext.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(134, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cinsiyet"
        '
        'Soyadtext
        '
        Me.Soyadtext.Location = New System.Drawing.Point(163, 202)
        Me.Soyadtext.Name = "Soyadtext"
        Me.Soyadtext.Size = New System.Drawing.Size(100, 20)
        Me.Soyadtext.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(134, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Soyad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(135, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Bolum"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(163, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 31)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Kayıt Ol"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bolumc
        '
        Me.bolumc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bolumc.FormattingEnabled = True
        Me.bolumc.Items.AddRange(New Object() {"BPR", "RTV", "MIM"})
        Me.bolumc.Location = New System.Drawing.Point(142, 300)
        Me.bolumc.Name = "bolumc"
        Me.bolumc.Size = New System.Drawing.Size(121, 21)
        Me.bolumc.TabIndex = 13
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(302, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(299, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Danışman Ögretmen"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09"})
        Me.ComboBox1.Location = New System.Drawing.Point(302, 326)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(140, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Kayıt Tarihi"
        '
        'KayıtText
        '
        Me.KayıtText.Location = New System.Drawing.Point(163, 327)
        Me.KayıtText.Name = "KayıtText"
        Me.KayıtText.Size = New System.Drawing.Size(100, 20)
        Me.KayıtText.TabIndex = 18
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(177, 130)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(86, 17)
        Me.CheckBox1.TabIndex = 20
        Me.CheckBox1.Text = "Şifreyi göster"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 32)
        Me.Panel1.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("NSimSun", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(143, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 24)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "KAYIT FORMU"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox5.Location = New System.Drawing.Point(401, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(31, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 35
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox6.Location = New System.Drawing.Point(429, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(35, 30)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 34
        Me.PictureBox6.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(302, 229)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 21)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Gözat..."
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(77, 324)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox3.Location = New System.Drawing.Point(137, 324)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(52, 49)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(-65, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(633, 399)
        Me.Panel2.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Label9"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 431)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.KayıtText)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bolumc)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Soyadtext)
        Me.Controls.Add(Me.Adtext)
        Me.Controls.Add(Me.Sifretext)
        Me.Controls.Add(Me.Cınsıyetc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IdText)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Register"
        Me.Text = "Register"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IdText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cınsıyetc As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Sifretext As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Adtext As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Soyadtext As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents bolumc As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents KayıtText As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
