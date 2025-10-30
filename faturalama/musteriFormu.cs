using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faturalama
{
    public partial class musteriFormu : Form
    {
        string connectionString = @"Server=CEMRE\SQLEXPRESS02;Database=StajDB;Trusted_Connection=True;";
        public musteriFormu()
        {
            InitializeComponent();
        }

        private void musteriFormu_Load(object sender, EventArgs e)
        {
            cmbFiltrelenecekAlan.Items.Add("Müşteri Adı");
            cmbFiltrelenecekAlan.Items.Add("Müşteri Kodu");
            cmbFiltrelenecekAlan.SelectedIndex = -1;

            dgvMusteriFormu.Columns.Add("ACCOUNTID", "Account ID");
            dgvMusteriFormu.Columns["ACCOUNTID"].Visible = false;
            dgvMusteriFormu.Columns.Add("ser", "Müşteri Kodu");
            dgvMusteriFormu.Columns.Add("seri", "Musteri Adı");

        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            string aramaTuru = cmbFiltrelenecekAlan.SelectedItem?.ToString();
            string girilenDeger = txtFiltre.Text.Trim(); // txtFiltre: arama yapılacak TextBox

            if (string.IsNullOrEmpty(aramaTuru))
            {
                MessageBox.Show("Lütfen arama türünü seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (aramaTuru == "Müşteri Adı")
            {
                if (girilenDeger.Length < 5)
                {
                    MessageBox.Show("Arama yapmak için yeterli karakter yoktur!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    // Müşteri adıyla arama işlemi
                    AramaYap("ADI", girilenDeger);
                }
            }
            else if (aramaTuru == "Müşteri Kodu")
            {
                if (girilenDeger.Length == 0 || girilenDeger.Contains(" ")) // Kod tam girilmemişse
                {
                    MessageBox.Show("Lütfen bilgileri kontrol ediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    // Müşteri kodu ile arama işlemi
                    AramaYap("KODU", girilenDeger);
                }
            }
        }

        // arama fonksiyonu
        private void AramaYap(string alan, string deger)
        {
            dgvMusteriFormu.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "";

                if (alan == "ADI")
                    query = "SELECT ACCOUNTID, code, name FROM account WHERE name LIKE @deger + '%'";
                else if (alan == "KODU")
                    query = "SELECT ACCOUNTID, code, name FROM account WHERE code = @deger";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@deger", deger);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvMusteriFormu.Rows.Add(reader["ACCOUNTID"], reader["code"], reader["name"]);
                    }
                }
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteriEklemeFormu musteriEkle=new musteriEklemeFormu();
            musteriEkle.ShowDialog();
        }
        private void dgvMusteriFormu_SelectionChanged(object sender, EventArgs e)
        {
            // Sadece 1 satır seçiliyse buton aktif olsun
            btnDetay.Enabled = (dgvMusteriFormu.SelectedRows.Count == 1);
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriFormu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için müşteri seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string musteriKodu = dgvMusteriFormu.SelectedRows[0].Cells["ser"].Value.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1. ACCOUNTID bul
                string accountIdQuery = "SELECT ACCOUNTID FROM ACCOUNT WHERE CODE = @code";
                string accountId = null;
                using (SqlCommand cmdId = new SqlCommand(accountIdQuery, conn))
                {
                    cmdId.Parameters.AddWithValue("@code", musteriKodu);
                    var result = cmdId.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Seçili müşteri bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    accountId = result.ToString();
                }

                // 2. Cari (ACCOUNTADDRESS) kontrolü
                string cariQuery = "SELECT COUNT(*) FROM ACCOUNTADDRESS WHERE ACCOUNTID = @id AND ACTIVE_VERSION = 1 AND AUDIT_DELETED = 0";
                using (SqlCommand cmdCari = new SqlCommand(cariQuery, conn))
                {
                    cmdCari.Parameters.AddWithValue("@id", accountId);
                    int cariVarMi = (int)cmdCari.ExecuteScalar();

                    if (cariVarMi > 0)
                    {
                        MessageBox.Show("Açıkta carisi olan müşteriyi silemezsiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 3. Update → Silinmiş gibi işaretle
                string updateQuery = @"
            UPDATE ACCOUNT
            SET ACTIVE_VERSION = 0,
                AUDIT_DELETED = 1,
                LAST_VERSION = 0
            WHERE CODE = @code";

                using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@code", musteriKodu);
                     int affected = cmdUpdate.ExecuteNonQuery();

                    if (affected > 0)
                    {
                        MessageBox.Show("Müşteri silinmiş gibi işaretlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvMusteriFormu.Rows.RemoveAt(dgvMusteriFormu.SelectedRows[0].Index);
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (dgvMusteriFormu.SelectedRows.Count != 1)
            {
                MessageBox.Show("Lütfen sadece bir müşteri seçiniz!",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçili satırdan ACCOUNTID al
            string accountId = dgvMusteriFormu.SelectedRows[0].Cells["ACCOUNTID"].Value.ToString();

            // Detay formunu açarken accountId parametre olarak gönder
            musteriCariYönetimi detayForm = new musteriCariYönetimi(accountId);
            detayForm.ShowDialog(); ;
        }

    }
}
