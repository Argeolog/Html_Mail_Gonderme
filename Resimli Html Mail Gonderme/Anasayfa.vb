Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Text
Imports System.Threading

Public Class Anasayfa

    Dim Smtp As SmtpClient
    Public Sub Gonder_Buton_Click(sender As Object, e As EventArgs) Handles Gonder_Buton.Click
        Try

            If File.Exists(Resim_Yolu_Text.Text) = False Then MsgBox(Resim_Yolu_Text.Text & " Yolunda Resim Bulunamadı !") : Exit Sub

            Dim imageConverter As New ImageConverter()
            Dim BytArray() As Byte = DirectCast(imageConverter.ConvertTo(New Bitmap(Image.FromFile(Resim_Yolu_Text.Text)), GetType(Byte())), Byte())
            Dim MemoryStreamImage As New MemoryStream(BytArray)
            Dim img As New LinkedResource(MemoryStreamImage, MediaTypeNames.Image.Jpeg) With {
                .ContentId = "Fotograf"
            }
            img.ContentType.MediaType = MediaTypeNames.Image.Jpeg
            img.TransferEncoding = TransferEncoding.Base64
            img.ContentType.Name = img.ContentId
            img.ContentLink = New Uri("cid:" & img.ContentId)


            Smtp = New SmtpClient With {
                .EnableSsl = SSL_Aktif.Checked,
                .Host = Mail_Protokol_Text.Text,
                .Port = Mail_Port_Text.Text,
                .Credentials = New NetworkCredential(Gonderici_Mail_Text.Text, Gonderici_Mail_Sifre.Text),
                .Timeout = 8000
                      }

            Dim MailMesaj As New MailMessage()
            Dim MailAdres As New MailAddress(Gonderici_Mail_Text.Text)
            MailMesaj.To.Add(Mail_Adresleri_Text.Text)
            Dim HtmlView As AlternateView = AlternateView.CreateAlternateViewFromString(Html_Text.Text, Encoding.UTF8, MediaTypeNames.Text.Html)
            HtmlView.LinkedResources.Add(img)
            MailMesaj.AlternateViews.Add(HtmlView)
            MailMesaj.IsBodyHtml = True
            MailMesaj.Subject = "Anlık Mail Bildirimi (" & TimeOfDay & ")" ' Konu Başlığını ve Mail İçeriğini Değiştirdiğinde Mail Spam'a Düşmez.
            MailMesaj.From = MailAdres
            Me.Text = "Mail Gönderiliyor..."

            If Asenkron_Gonder_Check.Checked = True Then
                AddHandler Smtp.SendCompleted, AddressOf Asenkron_Gonderildi
                Smtp.SendMailAsync(MailMesaj)
            Else
                Me.Cursor = Cursors.WaitCursor
                Smtp.Send(MailMesaj)
                Me.Text = "Mail Gönderildi."
            End If
        Catch ex As Exception
            Me.Text = "Anasayfa"
            MessageBox.Show(Me, ex.Message, "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default

    End Sub



    Sub Asenkron_Gonderildi(sender As Object, e As AsyncCompletedEventArgs)

        If e.Error IsNot Nothing Then
            Me.Text = "Anasayfa"
            MessageBox.Show(Me, e.Error.Message, "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Text = "Mail Gönderildi."
        End If

    End Sub


    Sub Ayarlari_Oku()
        Dim Ayarlar As New StreamReader(Application.StartupPath & "\Ayar.txt")
        Try
            Gonderici_Mail_Text.Text = Ayarlar.ReadLine
            Gonderici_Mail_Sifre.Text = Ayarlar.ReadLine
            Mail_Protokol_Text.Text = Ayarlar.ReadLine
            Mail_Port_Text.Text = Ayarlar.ReadLine
            SSL_Aktif.Checked = Ayarlar.ReadLine
            Mail_Adresleri_Text.Text = Ayarlar.ReadLine
            Resim_Yolu_Text.Text = Ayarlar.ReadLine
            Asenkron_Gonder_Check.Checked = Ayarlar.ReadLine
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Ayarlar.Close()
    End Sub

    Sub Ayarlari_Kaydet()
        Try


            Dim Ayarlar As New StreamWriter(Application.StartupPath & "\Ayar.txt")
            Ayarlar.WriteLine(Gonderici_Mail_Text.Text)
            Ayarlar.WriteLine(Gonderici_Mail_Sifre.Text)
            Ayarlar.WriteLine(Mail_Protokol_Text.Text)
            Ayarlar.WriteLine(Mail_Port_Text.Text)
            Ayarlar.WriteLine(SSL_Aktif.Checked)
            Ayarlar.WriteLine(Mail_Adresleri_Text.Text)
            Ayarlar.WriteLine(Resim_Yolu_Text.Text)
            Ayarlar.WriteLine(Asenkron_Gonder_Check.Checked)
            Ayarlar.Close()

        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Gmail_Varsayilan_Buton_Click(sender As Object, e As EventArgs) Handles Gmail_Varsayilan_Buton.Click
        SSL_Aktif.Checked = True
        Mail_Protokol_Text.Text = "smtp.gmail.com"
        Mail_Port_Text.Text = "587"
    End Sub

    Private Sub Hotmail_Varsayilan_Buton_Click(sender As Object, e As EventArgs) Handles Hotmail_Varsayilan_Buton.Click
        SSL_Aktif.Checked = True
        Mail_Protokol_Text.Text = "smtp-mail.outlook.com"
        Mail_Port_Text.Text = "587"
    End Sub

    Private Sub Foto_Sec_Buton_Click(sender As Object, e As EventArgs) Handles Foto_Sec_Buton.Click

        Dim Dizinsec As New OpenFileDialog With {
                .Filter = "Tüm Fotoğraflar |*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG",
                .InitialDirectory = Application.StartupPath & "\Ayarlar\Header"
            }

        If Dizinsec.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Resim_Yolu_Text.Text = Dizinsec.FileName
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ayarlari_Oku()
    End Sub

    Private Sub Ayar_Kaydet_Buton_Click(sender As Object, e As EventArgs) Handles Ayar_Kaydet_Buton.Click
        Ayarlari_Kaydet()
    End Sub



    Private Sub Asenkron_Gonder_Check_Click(sender As Object, e As EventArgs) Handles Asenkron_Gonder_Check.Click
        Ayarlari_Kaydet()
    End Sub
End Class
