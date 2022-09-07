<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Anasayfa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Anasayfa))
        Me.Html_Text = New System.Windows.Forms.RichTextBox()
        Me.Gonderici_Mail_Text = New System.Windows.Forms.TextBox()
        Me.Gonderici_Mail_Sifre = New System.Windows.Forms.TextBox()
        Me.Mail_Protokol_Text = New System.Windows.Forms.TextBox()
        Me.SSL_Aktif = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Gonder_Buton = New System.Windows.Forms.Button()
        Me.Mail_Adresleri_Text = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Mail_Port_Text = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Resim_Yolu_Text = New System.Windows.Forms.TextBox()
        Me.Foto_Sec_Buton = New System.Windows.Forms.Button()
        Me.Gmail_Varsayilan_Buton = New System.Windows.Forms.Button()
        Me.Hotmail_Varsayilan_Buton = New System.Windows.Forms.Button()
        Me.Ayar_Kaydet_Buton = New System.Windows.Forms.Button()
        Me.Asenkron_Gonder_Check = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Html_Text
        '
        Me.Html_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Html_Text.Location = New System.Drawing.Point(12, 116)
        Me.Html_Text.Name = "Html_Text"
        Me.Html_Text.Size = New System.Drawing.Size(668, 414)
        Me.Html_Text.TabIndex = 0
        Me.Html_Text.Text = resources.GetString("Html_Text.Text")
        '
        'Gonderici_Mail_Text
        '
        Me.Gonderici_Mail_Text.Location = New System.Drawing.Point(125, 10)
        Me.Gonderici_Mail_Text.Name = "Gonderici_Mail_Text"
        Me.Gonderici_Mail_Text.Size = New System.Drawing.Size(162, 20)
        Me.Gonderici_Mail_Text.TabIndex = 1
        '
        'Gonderici_Mail_Sifre
        '
        Me.Gonderici_Mail_Sifre.Location = New System.Drawing.Point(125, 36)
        Me.Gonderici_Mail_Sifre.Name = "Gonderici_Mail_Sifre"
        Me.Gonderici_Mail_Sifre.Size = New System.Drawing.Size(162, 20)
        Me.Gonderici_Mail_Sifre.TabIndex = 2
        '
        'Mail_Protokol_Text
        '
        Me.Mail_Protokol_Text.Location = New System.Drawing.Point(382, 9)
        Me.Mail_Protokol_Text.Name = "Mail_Protokol_Text"
        Me.Mail_Protokol_Text.Size = New System.Drawing.Size(162, 20)
        Me.Mail_Protokol_Text.TabIndex = 3
        '
        'SSL_Aktif
        '
        Me.SSL_Aktif.AutoSize = True
        Me.SSL_Aktif.Location = New System.Drawing.Point(382, 64)
        Me.SSL_Aktif.Name = "SSL_Aktif"
        Me.SSL_Aktif.Size = New System.Drawing.Size(47, 17)
        Me.SSL_Aktif.TabIndex = 4
        Me.SSL_Aktif.Text = "Aktif"
        Me.SSL_Aktif.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(304, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SSL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mail Protokol"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Gönderici Mail"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Gönderici Mail Şifre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(367, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(367, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(112, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(112, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = ":"
        '
        'Gonder_Buton
        '
        Me.Gonder_Buton.Location = New System.Drawing.Point(13, 555)
        Me.Gonder_Buton.Name = "Gonder_Buton"
        Me.Gonder_Buton.Size = New System.Drawing.Size(666, 61)
        Me.Gonder_Buton.TabIndex = 14
        Me.Gonder_Buton.Text = "Gönder"
        Me.Gonder_Buton.UseVisualStyleBackColor = True
        '
        'Mail_Adresleri_Text
        '
        Me.Mail_Adresleri_Text.Location = New System.Drawing.Point(125, 61)
        Me.Mail_Adresleri_Text.Name = "Mail_Adresleri_Text"
        Me.Mail_Adresleri_Text.Size = New System.Drawing.Size(162, 20)
        Me.Mail_Adresleri_Text.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Gönderilecek Mailler"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(112, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(367, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(304, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Mail Port"
        '
        'Mail_Port_Text
        '
        Me.Mail_Port_Text.Location = New System.Drawing.Point(382, 35)
        Me.Mail_Port_Text.Name = "Mail_Port_Text"
        Me.Mail_Port_Text.Size = New System.Drawing.Size(162, 20)
        Me.Mail_Port_Text.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(112, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Fotoğraf Yolu"
        '
        'Resim_Yolu_Text
        '
        Me.Resim_Yolu_Text.Location = New System.Drawing.Point(125, 87)
        Me.Resim_Yolu_Text.Name = "Resim_Yolu_Text"
        Me.Resim_Yolu_Text.Size = New System.Drawing.Size(329, 20)
        Me.Resim_Yolu_Text.TabIndex = 22
        '
        'Foto_Sec_Buton
        '
        Me.Foto_Sec_Buton.Location = New System.Drawing.Point(460, 84)
        Me.Foto_Sec_Buton.Name = "Foto_Sec_Buton"
        Me.Foto_Sec_Buton.Size = New System.Drawing.Size(84, 26)
        Me.Foto_Sec_Buton.TabIndex = 25
        Me.Foto_Sec_Buton.Text = "Foto Seç"
        Me.Foto_Sec_Buton.UseVisualStyleBackColor = True
        '
        'Gmail_Varsayilan_Buton
        '
        Me.Gmail_Varsayilan_Buton.Location = New System.Drawing.Point(550, 6)
        Me.Gmail_Varsayilan_Buton.Name = "Gmail_Varsayilan_Buton"
        Me.Gmail_Varsayilan_Buton.Size = New System.Drawing.Size(130, 26)
        Me.Gmail_Varsayilan_Buton.TabIndex = 26
        Me.Gmail_Varsayilan_Buton.Text = "G-Mail Varsayılan"
        Me.Gmail_Varsayilan_Buton.UseVisualStyleBackColor = True
        '
        'Hotmail_Varsayilan_Buton
        '
        Me.Hotmail_Varsayilan_Buton.Location = New System.Drawing.Point(550, 38)
        Me.Hotmail_Varsayilan_Buton.Name = "Hotmail_Varsayilan_Buton"
        Me.Hotmail_Varsayilan_Buton.Size = New System.Drawing.Size(130, 26)
        Me.Hotmail_Varsayilan_Buton.TabIndex = 27
        Me.Hotmail_Varsayilan_Buton.Text = "Hotmail Varsayılan"
        Me.Hotmail_Varsayilan_Buton.UseVisualStyleBackColor = True
        '
        'Ayar_Kaydet_Buton
        '
        Me.Ayar_Kaydet_Buton.Location = New System.Drawing.Point(550, 70)
        Me.Ayar_Kaydet_Buton.Name = "Ayar_Kaydet_Buton"
        Me.Ayar_Kaydet_Buton.Size = New System.Drawing.Size(130, 40)
        Me.Ayar_Kaydet_Buton.TabIndex = 28
        Me.Ayar_Kaydet_Buton.Text = "Ayarları_Kaydet"
        Me.Ayar_Kaydet_Buton.UseVisualStyleBackColor = True
        '
        'Asenkron_Gonder_Check
        '
        Me.Asenkron_Gonder_Check.AutoSize = True
        Me.Asenkron_Gonder_Check.Location = New System.Drawing.Point(14, 536)
        Me.Asenkron_Gonder_Check.Name = "Asenkron_Gonder_Check"
        Me.Asenkron_Gonder_Check.Size = New System.Drawing.Size(109, 17)
        Me.Asenkron_Gonder_Check.TabIndex = 29
        Me.Asenkron_Gonder_Check.Text = "Asenkron Gönder"
        Me.Asenkron_Gonder_Check.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 625)
        Me.Controls.Add(Me.Asenkron_Gonder_Check)
        Me.Controls.Add(Me.Ayar_Kaydet_Buton)
        Me.Controls.Add(Me.Hotmail_Varsayilan_Buton)
        Me.Controls.Add(Me.Gmail_Varsayilan_Buton)
        Me.Controls.Add(Me.Foto_Sec_Buton)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Resim_Yolu_Text)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Mail_Port_Text)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Mail_Adresleri_Text)
        Me.Controls.Add(Me.Gonder_Buton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SSL_Aktif)
        Me.Controls.Add(Me.Mail_Protokol_Text)
        Me.Controls.Add(Me.Gonderici_Mail_Sifre)
        Me.Controls.Add(Me.Gonderici_Mail_Text)
        Me.Controls.Add(Me.Html_Text)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anasayfa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Html_Text As RichTextBox
    Friend WithEvents Gonderici_Mail_Text As TextBox
    Friend WithEvents Gonderici_Mail_Sifre As TextBox
    Friend WithEvents Mail_Protokol_Text As TextBox
    Friend WithEvents SSL_Aktif As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Gonder_Buton As Button
    Friend WithEvents Mail_Adresleri_Text As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Mail_Port_Text As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Resim_Yolu_Text As TextBox
    Friend WithEvents Foto_Sec_Buton As Button
    Friend WithEvents Gmail_Varsayilan_Buton As Button
    Friend WithEvents Hotmail_Varsayilan_Buton As Button
    Friend WithEvents Ayar_Kaydet_Buton As Button
    Friend WithEvents Asenkron_Gonder_Check As CheckBox
End Class
