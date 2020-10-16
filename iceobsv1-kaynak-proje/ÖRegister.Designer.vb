<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ÖRegister
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ÖRegister))
        Me.NoText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AdText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SoyadText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CinsiyetC = New System.Windows.Forms.ComboBox()
        Me.BölümC = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SifreText = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoText
        '
        Me.NoText.Location = New System.Drawing.Point(128, 65)
        Me.NoText.Name = "NoText"
        Me.NoText.Size = New System.Drawing.Size(100, 20)
        Me.NoText.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Öğretmen No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Öğretmen Adı:"
        '
        'AdText
        '
        Me.AdText.Location = New System.Drawing.Point(128, 105)
        Me.AdText.Name = "AdText"
        Me.AdText.Size = New System.Drawing.Size(100, 20)
        Me.AdText.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Öğretmen Soyadı:"
        '
        'SoyadText
        '
        Me.SoyadText.Location = New System.Drawing.Point(128, 142)
        Me.SoyadText.Name = "SoyadText"
        Me.SoyadText.Size = New System.Drawing.Size(100, 20)
        Me.SoyadText.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(31, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cinsiyeti:"
        '
        'CinsiyetC
        '
        Me.CinsiyetC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CinsiyetC.FormattingEnabled = True
        Me.CinsiyetC.Items.AddRange(New Object() {"Erkek", "Kadın", "Diğer"})
        Me.CinsiyetC.Location = New System.Drawing.Point(128, 190)
        Me.CinsiyetC.Name = "CinsiyetC"
        Me.CinsiyetC.Size = New System.Drawing.Size(121, 21)
        Me.CinsiyetC.TabIndex = 7
        '
        'BölümC
        '
        Me.BölümC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BölümC.FormattingEnabled = True
        Me.BölümC.Items.AddRange(New Object() {"BPR", "RTV", "MIM"})
        Me.BölümC.Location = New System.Drawing.Point(128, 225)
        Me.BölümC.Name = "BölümC"
        Me.BölümC.Size = New System.Drawing.Size(121, 21)
        Me.BölümC.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(31, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Bölümü:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(31, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Şifre:"
        '
        'SifreText
        '
        Me.SifreText.Location = New System.Drawing.Point(128, 270)
        Me.SifreText.Name = "SifreText"
        Me.SifreText.Size = New System.Drawing.Size(100, 20)
        Me.SifreText.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(372, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 127)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(372, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Gözat..."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(400, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 30)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Kayıt OL"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(128, 293)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(84, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "şifreyi göster"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Location = New System.Drawing.Point(-5, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 32)
        Me.Panel1.TabIndex = 25
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
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(-74, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(633, 399)
        Me.Panel2.TabIndex = 26
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
        'ÖRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 431)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SifreText)
        Me.Controls.Add(Me.BölümC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CinsiyetC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SoyadText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AdText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NoText)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ÖRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ÖRegister"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NoText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AdText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents SoyadText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CinsiyetC As ComboBox
    Friend WithEvents BölümC As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SifreText As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
