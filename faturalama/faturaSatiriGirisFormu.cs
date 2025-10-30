using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faturalama
{
    public partial class faturaSatiriGirisFormu : Form
    {
        string connectionString = @"Server=CEMRE\SQLEXPRESS02;Database=StajDB;Trusted_Connection=True;";

        private string seriNo;
        private string mevcutDovizTuru;
        private HashSet<string> mevcutIrsaliyeler;
        public faturaSatiriGirisFormu(string seriNo, string mevcutDovizTuru, IEnumerable<string> irsaliyeListesi)
        {
            InitializeComponent();
            this.seriNo = seriNo; 
            this.mevcutDovizTuru = mevcutDovizTuru;
            mevcutIrsaliyeler = new HashSet<string>(irsaliyeListesi);
        }
        private void faturaSatiriGirisFormu_Load(object sender, EventArgs e)
        {
            LoadDövizTürü();
        }

        public string Aciklama => txtAçıklama.Text;
        public bool DovizliFatura => chkDövizliFatura.Checked;
        public decimal DovizKuru => decimal.TryParse(txtDövizKuru.Text, out var dkur) ? dkur : 0;
        public int Adet => (int)nmrAdet.Value;
        public decimal DovizliTutar => decimal.TryParse(txtDövizTutar.Text, out var dtutar) ? dtutar : 0;
        public decimal Tutar => decimal.TryParse(txtTutarTL.Text, out var tutar) ? tutar : 0;
        public int KdvOrani => int.Parse(cmbKdvOrani.SelectedItem?.ToString() ?? "0");
        public string Irsaliye => txtİrsaliye.Text;
        public int DovizTuruId
        {
            get
            {
                if (!chkDövizliFatura.Checked)
                    return 1; // TL'nin ID'si

                if (cmbDövizTürü.SelectedValue != null)
                    return Convert.ToInt32(cmbDövizTürü.SelectedValue);

                return 1; // fallback
            }
        }

        public string DovizTuru
        {
            get
            {
                if (!chkDövizliFatura.Checked)
                    return "TL";

                if (cmbDövizTürü.SelectedItem != null)
                    return ((DataRowView)cmbDövizTürü.SelectedItem)["name"].ToString();

                return "TL";
            }
        }

        //check dövizli fatura
        private void chkDövizliFatura_CheckedChanged(object sender, EventArgs e)
        {
            bool aktif = chkDövizliFatura.Checked;

            cmbDövizTürü.Enabled = aktif;
            txtDövizKuru.Enabled = aktif;
            txtDövizTutar.Enabled = aktif;

            if (!aktif)
            {
                // Dövizli değilse, TL varsay
                txtDövizKuru.Text = "1";
                txtDövizTutar.Clear();
                txtTutarTL.ReadOnly = false;
            }
            else
            {
                // Dövizli seçildiyse combobox'tan kullanıcı seçsin
                cmbDövizTürü.SelectedIndex = -1;
                txtDövizKuru.Clear();
                txtDövizTutar.Clear();
                txtTutarTL.ReadOnly = true;
            }
        }
    //DövizTürü
        private void LoadDövizTürü()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Sadece ID'si 1 olmayan döviz türlerini getir
                    string query = "SELECT LOVCURRENCYTYPEID, name FROM LOVCURRENCYTYPE WHERE LOVCURRENCYTYPEID != 1";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbDövizTürü.DisplayMember = "name";
                    cmbDövizTürü.ValueMember = "LOVCURRENCYTYPEID";
                    cmbDövizTürü.DataSource = dt;

                    cmbDövizTürü.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }   
        }
        
    //Dövizkuru
        private void txtDövizKuru_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam ve virgül kabul et
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Birden fazla virgül girilmesin
            if (e.KeyChar == ',' && txtDövizKuru.Text.Contains(','))
            {
                e.Handled = true;
            }
        }
        private void txtDövizKuru_Validating(object sender, CancelEventArgs e)
        {
            if (decimal.TryParse(txtDövizKuru.Text, out decimal kur))
            {
                // Virgülden sonra 4 basamak kontrolü
                int virgulIndex = txtDövizKuru.Text.IndexOf(',');

                if (virgulIndex >= 0)
                {
                    string ondalikKisim = txtDövizKuru.Text.Substring(virgulIndex + 1);
                    if (ondalikKisim.Length > 4)
                    {
                        MessageBox.Show("Lütfen Döviz Kurunu Düzgün Formatta Girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                        return;
                    }
                }

                // Formatla (virgülden sonra 4 hane)
                txtDövizKuru.Text = kur.ToString("N4");
            }
            else
            {
                MessageBox.Show("Lütfen Döviz Kurunu Düzgün Formatta Girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
        private void txtDövizKuru_TextChanged(object sender, EventArgs e)
        {
            if (chkDövizliFatura.Checked)
            {
                HesaplaTL();
            }
        }
        private void txtDövizKuru_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtDövizKuru.Text, @"^\d+([,]\d{1,4})?$"))
            {
                MessageBox.Show("Lütfen Döviz Kurunu Düzgün Formatta Girin!\nÖrn: 27,1234", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDövizKuru.Focus();
            }
        }
    //number adet
        private void nmrAdet_ValueChanged(object sender, EventArgs e)
        {
            if (chkDövizliFatura.Checked)
                HesaplaTL();
        }
    //Döviz tutar
        private void txtDövizTutar_Validating(object sender, CancelEventArgs e)
        {
            if (decimal.TryParse(txtDövizTutar.Text, out decimal dovizliTutar))
            {
                txtDövizTutar.Text = dovizliTutar.ToString("N2"); // 2 ondalık
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir Dövizli Tutar girin!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Odaktan çıkmasını engelle
            }
        }
        private void txtDövizTutar_TextChanged(object sender, EventArgs e)
        {
            if (chkDövizliFatura.Checked)
            {
                HesaplaTL();
            }
        }
    //Tutar
        private void txtTutarTL_Validating(object sender, CancelEventArgs e)
        {
            if (decimal.TryParse(txtTutarTL.Text, out decimal tlTutar))
            {
                txtTutarTL.Text = tlTutar.ToString("N2"); // 2 ondalık
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir Tutar (TL) girin!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
        private void txtTutarTL_TextChanged(object sender, EventArgs e)
        {
            if (chkDövizliFatura.Checked)
            {
                txtTutarTL.ReadOnly = true; // Kullanıcı giremesin
                HesaplaTL();
            }
            else
            {
                txtTutarTL.ReadOnly = false; // Kullanıcı girebilir
                HesaplaTL();
            }
        }
        private void HesaplaTL()
        {
            if (decimal.TryParse(txtDövizTutar.Text, out decimal dovizTutar) &&
                decimal.TryParse(txtDövizKuru.Text, out decimal dovizKuru))
            {
                decimal adet = nmrAdet.Value;
                decimal tutarTL = dovizTutar * dovizKuru * adet;
                txtTutarTL.Text = tutarTL.ToString("N2");
            }
            else if(decimal.TryParse(txtTutarTL.Text, out decimal TlTutar))
            {
                decimal adet = nmrAdet.Value;
                decimal tutarTL =  TlTutar* adet;
                txtTutarTL.Text = tutarTL.ToString("N2");
            }
        }
        private void txtİrsaliye_KeyPress(object sender, KeyPressEventArgs e)
        {
            // İlk 2 karakter için sadece harf kabul et
            if (txtİrsaliye.SelectionStart < 2)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    // otomatik büyük harf yap
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
            }
            else
            {
                // Sonraki 6 karakter için sadece rakam kabul et
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            // Maksimum uzunluk 8 karakter (2 harf + 6 rakam)
            if (!char.IsControl(e.KeyChar) && txtİrsaliye.Text.Length >= 8)
            {
                e.Handled = true;
            }
        }

        //kaydet Buton
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Açiklama alanı kontrolü
            if (string.IsNullOrWhiteSpace(txtAçıklama.Text))
            {
                MessageBox.Show("Açıklama alanını mutlaka giriniz!");
                txtAçıklama.Focus();
                return;
            }

            //DövizTürü ve DövizKuru kontrolü
            if (chkDövizliFatura.Checked)
            {
                if (cmbDövizTürü.SelectedIndex == -1)
                {
                    MessageBox.Show("Döviz kuru ve tutar alanları boş bırakılamaz.", "Zorunlu Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbDövizTürü.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDövizKuru.Text) || string.IsNullOrWhiteSpace(txtDövizTutar.Text))
                {
                    MessageBox.Show("Döviz kuru ve tutar alanları boş bırakılamaz.", "Zorunlu Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (decimal.TryParse(txtTutarTL.Text, out decimal tlTutar))
            {
                if (tlTutar == 0)
                {
                    MessageBox.Show("0 tutarlı fatura kesemezsiniz!", 
                        "Geçersiz Tutar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTutarTL.Focus();
                    return; // Kaydetme işlemini durdur
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir Tutar (TL) girin!", 
                    "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTutarTL.Focus();
                return;
            }

            string mevcut = (mevcutDovizTuru ?? "").Trim();
            bool faturadaDovizliSatirVar =
                !string.IsNullOrEmpty(mevcut) &&
                !mevcut.Equals("TL", StringComparison.OrdinalIgnoreCase);

            if (faturadaDovizliSatirVar)
            {
                // Faturada dövizli satır(lar) var ,yeni satır da dövizli olmalı ve türü aynı olmalı
                if (!chkDövizliFatura.Checked)
                {
                    MessageBox.Show(
                        $"Faturada zaten dövizli satırlar mevcut. Yeni satır da dövizli olmalı ve aynı döviz türüne sahip olmalıdır: {mevcut}",
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    chkDövizliFatura.Focus();
                    return;
                }

                var secilenDovizAdi = DovizTuru; // combobox'tan güvenli isim
                if (!string.Equals(secilenDovizAdi, mevcut, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        $"Tüm satırlar aynı döviz türüne sahip olmalıdır!\nMevcut döviz türü: {mevcut}",
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


            string irsaliye = txtİrsaliye.Text.Trim().ToUpper();

            // Format kontrolü: 2 harf + 6 rakam
            if (!Regex.IsMatch(irsaliye, @"^[A-Z]{2}\d{6}$"))
            {
                MessageBox.Show("İrsaliye formatı hatalı! Örn: AB123456",
                                "Hatalı Format",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtİrsaliye.Focus();
                return;
            }

            // Daha önce eklenmiş mi?
            if (mevcutIrsaliyeler.Contains(irsaliye))
            {
                MessageBox.Show("Bu irsaliye listeye daha önce eklenmiştir.",
                                "İrsaliye tekrarı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtİrsaliye.Focus();
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    //kapat buton
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
