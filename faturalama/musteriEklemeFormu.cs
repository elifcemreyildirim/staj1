using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faturalama
{
    public partial class musteriEklemeFormu : Form
    {
        string connectionString = @"Server=CEMRE\SQLEXPRESS02;Database=StajDB;Trusted_Connection=True;";
        public musteriEklemeFormu()
        {
            InitializeComponent();
        }
        private void txtMusteriKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam ve kontrol tuşlarına izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Müşteri kodu alanına sadece numerik değerler girebilirsiniz.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string musteriKodu = txtMusteriKodu.Text.Trim();
            string musteriAdi = txtMusteriAdi.Text.Trim();

            if (string.IsNullOrWhiteSpace(musteriKodu) || string.IsNullOrWhiteSpace(musteriAdi))
            {
                MessageBox.Show("Müşteri Bilgilerini Eksiksiz Giriniz.",
                                "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Aynı müşteri kodu kontrolü
                string checkQuery = "SELECT COUNT(*) FROM ACCOUNT WHERE CODE = @code";
                using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@code", musteriKodu);
                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Müşteri Daha Önce Kayıt Edilmiştir.",
                                        "Zaten Kayıtlı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                // GUID üret
                string newAccountId = Guid.NewGuid().ToString();

                // Kayıt ekleme
                string insertQuery = "INSERT INTO ACCOUNT (ACCOUNTID, CODE, NAME) VALUES (@id, @code, @name)";
                using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@id", newAccountId);
                    cmdInsert.Parameters.AddWithValue("@code", musteriKodu);
                    cmdInsert.Parameters.AddWithValue("@name", musteriAdi);
                    cmdInsert.ExecuteNonQuery();
                }

                MessageBox.Show("Müşteri başarıyla kaydedildi.",
                                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("a40@gmail.com");  // Gönderen
                mail.To.Add("b@hotmail.com"); // Alıcı
                mail.Subject = "Yeni Müşteri Kaydı";
                mail.Body = $"Yeni müşteri kaydedildi:\n\nMüşteri Kodu: {musteriKodu}\nMüşteri Adı: {musteriAdi}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("a@gmail.com", "uygulama şifresi");
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Müşteri kaydı için mail gönderildi.",
                                "Mail Gönderimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderiminde hata: " + ex.Message,
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
