using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq; // SequenceEqual metodu için gerekli
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faturalama
{
    public partial class girisFormu : Form
    {
        // Veritabanı bağlantı dizesi
        string connectionString = @"Server=CEMRE\SQLEXPRESS02;Database=StajDB;Trusted_Connection=True;";

        public girisFormu()
        {
            InitializeComponent();
        }

        private void girisFormu_Load(object sender, EventArgs e)
        {
            // İsteğe bağlı, formu yüklendiğinde çalışacak kod
            dtpCalismaTarihi.Value = DateTime.Today;
            dtpCalismaTarihi.Enabled = false;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifreyi boşluklardan arındırarak al
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Giriş alanlarının boş olup olmadığını kontrol et
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi giriniz.");
                txtUsername.Focus();
                return;
            }

            // Veritabanında kullanıcıyı doğrula
            if (KullaniciKontrol(username, password))
            {
                
                MessageBox.Show("Giriş başarılı!");
                
                // this.Hide();
                faturaAramaFormu frm = new faturaAramaFormu();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                // Kullanıcı adı veya şifre hatalı
                MessageBox.Show("Lütfen giriş bilgilerinizi kontrol ediniz.");
                txtUsername.Focus();
            }
        }

        private bool KullaniciKontrol(string kullaniciAdi, string sifre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT PASSWORD_HASH FROM USERS WHERE USERNAME=@u";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@u", kullaniciAdi);

                    try
                    {
                        conn.Open();
                        object passwordHashObj = cmd.ExecuteScalar();

                        if (passwordHashObj != null)
                        {
                            // 1. Veritabanından gelen hash (Byte Dizisi)
                            byte[] storedHash = (byte[])passwordHashObj;

                            // 2. Girilen şifreden hesaplanan hash (Byte Dizisi)
                            byte[] calculatedHash = CalculateHashBytes(sifre);

                            // Debug için her iki hash'i de Hex String'e çevirip gösterelim
                            string storedHashHex = ByteArrayToHexString(storedHash);
                            string calculatedHashHex = ByteArrayToHexString(calculatedHash);

                            // Hata ayıklama mesajı
                            MessageBox.Show(
                                $"Kullanıcı Adı: {kullaniciAdi}\n" +
                                $"DB Hash: {storedHashHex}\n" +
                                $"Hesaplanan Hash: {calculatedHashHex}",
                                "Hash Karşılaştırma (DEBUG)",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            // Byte dizilerini doğrudan karşılaştır
                            return storedHash.SequenceEqual(calculatedHash);
                        }
                        else
                        {
                            // Kullanıcı bulunamadıysa uyarı göster
                            MessageBox.Show($"'{kullaniciAdi}' isimli kullanıcı bulunamadı!", "Hata: Kullanıcı Yok");
                            return false;
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Veritabanı hatası: {ex.Message}");
                        return false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}");
                        return false;
                    }
                }
            }
        }
        
        private static string ByteArrayToHexString(byte[] bytes)
        {
            StringBuilder hex = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }

        
        // Şifrenin SHA256 hash'ini byte dizisi olarak hesaplayan yardımcı metod
        private byte[] CalculateHashBytes(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //SQL'deki N'string' ifadesine uyum sağlamak için 
                
                byte[] passwordBytes = Encoding.Unicode.GetBytes(password);

                // Hash'i hesapla ve byte dizisi olarak döndür
                return sha256Hash.ComputeHash(passwordBytes);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}