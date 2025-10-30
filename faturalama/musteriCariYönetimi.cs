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
    public partial class musteriCariYönetimi : Form
    {
        string connectionString = @"Server=CEMRE\SQLEXPRESS02;Database=StajDB;Trusted_Connection=True;";
        private string accountId;

        public musteriCariYönetimi(string accountId) // PARAMETRE alıyor
        {
            InitializeComponent();
            this.accountId = accountId;
        }
        private void musteriCariYönetimi_Load(object sender, EventArgs e)
        {
            dgvCari.Columns.Clear();
            dgvCari.AutoGenerateColumns = false;

            // Gizli ACCOUNTADDRESSID kolonu
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "ACCOUNTADDRESSID";
            colId.HeaderText = "ACCOUNTADDRESSID";
            colId.Name = "ACCOUNTADDRESSID";
            colId.Visible = false;
            dgvCari.Columns.Add(colId);

            // Cari adı kolonu
            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.DataPropertyName = "NAME";
            colName.HeaderText = "Cari";
            colName.Name = "NAME";
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCari.Columns.Add(colName);

            CariListesiniGetir();
        }

        private void CariListesiniGetir()
        {
            string query = @"SELECT ACCOUNTADDRESSID, NAME 
                     FROM ACCOUNTADDRESS 
                     WHERE ACCOUNTID = @accountId 
                       AND (AUDIT_DELETED = 0 OR AUDIT_DELETED IS NULL)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@accountId", accountId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCari.DataSource = dt;
            }
        }
        private void dgvCari_SelectionChanged(object sender, EventArgs e)
        {
            // Sadece 1 satır seçiliyse buton aktif olsun
            btnSil.Enabled = (dgvCari.SelectedRows.Count == 1);
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvCari.SelectedRows.Count == 0)
                return;

            string selectedId = dgvCari.SelectedRows[0].Cells["ACCOUNTADDRESSID"].Value.ToString();

            DialogResult result = MessageBox.Show("Seçilen cari kaydı silmek istediğinize emin misiniz?",
                                                  "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(@"UPDATE ACCOUNTADDRESS
                                                 SET ACTIVE_VERSION = 0, AUDIT_DELETED = 1
                                                 WHERE ACCOUNTADDRESSID = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Kayıt başarıyla silindi (soft delete).", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CariListesiniGetir(); // Grid’i güncelle
            }
        }
        private string selectedAccountAddressId = null;

        private void btnDuzenleEkle_Click(object sender, EventArgs e)
        {
            if (dgvCari.SelectedRows.Count == 1)
            {
                // SEÇİLİ satır varsa -> GÜNCELLEME MODU
                selectedAccountAddressId = dgvCari.SelectedRows[0].Cells["ACCOUNTADDRESSID"].Value.ToString();
                BilgileriDoldur(selectedAccountAddressId);
            }
            else
            {
                // Seçim yoksa -> YENİ KAYIT MODU
                selectedAccountAddressId = null;
                AlanlariTemizle();
            }
        }
        private void BilgileriDoldur(string accountAddressId)
        {
            string query = @"SELECT NAME, TAX_OFFICE, TAX_NUMBER,PHONE1, MOBILE_PHONE, EMAIL1 ,ADDRESS
                     FROM ACCOUNTADDRESS 
                     WHERE ACCOUNTADDRESSID = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", accountAddressId);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCariAdi.Text = dr["NAME"].ToString();
                    txtVergiOfisi.Text = dr["TAX_OFFICE"].ToString();
                    txtVergiNumarası.Text = dr["TAX_NUMBER"].ToString();
                    txtSabitTel.Text = dr["PHONE1"].ToString();
                    txtMobilTel.Text = dr["MOBILE_PHONE"].ToString();
                    txtEmail.Text = dr["EMAIL1"].ToString();
                    rtxtAdres.Text = dr["ADDRESS"].ToString();
                }
            }
        }
        private void AlanlariTemizle()
        {
            txtCariAdi.Text = "";
            txtVergiOfisi.Text = "";
            txtVergiNumarası.Text = "";
            txtSabitTel.Text = "";
            txtMobilTel.Text = "";
            txtEmail.Text = "";
            rtxtAdres.Text = "";
        }
        private void txtSabitTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam ve kontrol tuşlarına izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Müşteri kodu alanına sadece numerik değerler girebilirsiniz.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Sadece rakam girişine izin ver
        private void txtMobilTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kontrol tuşlarına izin ver 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // rakam değilse engelle
            }
        }
        // Alanı terk edince format kontrolü yap
        private void txtMobilTel_Leave(object sender, EventArgs e)
        {
            string mobilTel = txtMobilTel.Text.Trim();

            if (!string.IsNullOrEmpty(mobilTel)) // Alan doluysa kontrol et
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(mobilTel, @"^905\d{9}$"))
                {
                    MessageBox.Show("Lütfen telefon numarasını kontrol ediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMobilTel.Focus();
                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCariAdi.Text) ||
                string.IsNullOrWhiteSpace(txtVergiOfisi.Text) ||
                string.IsNullOrWhiteSpace(txtVergiNumarası.Text) ||
                string.IsNullOrWhiteSpace(txtMobilTel.Text))
            {
                MessageBox.Show("Cari Adı, Vergi Bilgileri ve İletişim Bilgileri doldurulmalıdır.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                if (string.IsNullOrEmpty(selectedAccountAddressId)) //  YENİ KAYIT
                {
                    string insertQuery = @"INSERT INTO ACCOUNTADDRESS 
                                   (ACCOUNTADDRESSID, ACCOUNTID, NAME, TAX_OFFICE, TAX_NUMBER, PHONE1, MOBILE_PHONE, EMAIL1, ADDRESS, ACTIVE_VERSION, AUDIT_DELETED) 
                                   VALUES (NEWID(), @accountId, @name, @taxOffice, @taxNumber, @phone1, @mobile, @mail, @address, 1, 0)";

                    using (SqlCommand cmdIns = new SqlCommand(insertQuery, conn))
                    {
                        cmdIns.Parameters.AddWithValue("@accountId", accountId);
                        cmdIns.Parameters.AddWithValue("@name", txtCariAdi.Text.Trim());
                        cmdIns.Parameters.AddWithValue("@taxOffice", txtVergiOfisi.Text.Trim());
                        cmdIns.Parameters.AddWithValue("@taxNumber", txtVergiNumarası.Text.Trim());
                        cmdIns.Parameters.AddWithValue("@phone1", txtSabitTel.Text.Trim());
                        cmdIns.Parameters.AddWithValue("@mobile", txtMobilTel.Text.Trim());
                        cmdIns.Parameters.AddWithValue("@mail", txtEmail.Text.Trim());
                        cmdIns.Parameters.AddWithValue("@address", rtxtAdres.Text.Trim());

                        cmdIns.ExecuteNonQuery();
                    }

                    MessageBox.Show("Yeni cari başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else //  GÜNCELLEME
                {
                    string updateQuery = @"UPDATE ACCOUNTADDRESS
                                   SET NAME = @name,
                                       TAX_OFFICE = @taxOffice,
                                       TAX_NUMBER = @taxNumber,
                                       PHONE1 = @phone1,
                                       MOBILE_PHONE = @mobile,
                                       EMAIL1 = @mail,
                                       ADDRESS = @address
                                   WHERE ACCOUNTADDRESSID = @id";

                    using (SqlCommand cmdUpd = new SqlCommand(updateQuery, conn))
                    {
                        cmdUpd.Parameters.AddWithValue("@id", selectedAccountAddressId);
                        cmdUpd.Parameters.AddWithValue("@name", txtCariAdi.Text.Trim());
                        cmdUpd.Parameters.AddWithValue("@taxOffice", txtVergiOfisi.Text.Trim());
                        cmdUpd.Parameters.AddWithValue("@taxNumber", txtVergiNumarası.Text.Trim());
                        cmdUpd.Parameters.AddWithValue("@phone1", txtSabitTel.Text.Trim());
                        cmdUpd.Parameters.AddWithValue("@mobile", txtMobilTel.Text.Trim());
                        cmdUpd.Parameters.AddWithValue("@mail", txtEmail.Text.Trim());
                        cmdUpd.Parameters.AddWithValue("@address", rtxtAdres.Text.Trim());

                        cmdUpd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cari kaydı güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //  Güncelleme maili gönder
                    //SendUpdateMail(txtCariAdi.Text.Trim());
                }

                CariListesiniGetir();

            }
        }
        private void SendUpdateMail(string cariAdi)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("a@gmail.com");  // Gönderen
                mail.To.Add("b@hotmail.com"); // Alıcı
                mail.Subject = "Cari Kaydı Güncelleme";
                mail.Body = $"'{cariAdi}' adlı cari kaydı güncellenmiştir.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("a@gmail.com", "uygulama şifresi");
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderilemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
