using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using EPPlus = OfficeOpenXml;
using System.IO;
using OfficeOpenXml;
using ExcelDataReader;

namespace faturalama
{
    public partial class musteriFaturaİadeFormu : Form
    {
        string connectionString = @"Server=CEMRE\SQLEXPRESS02;Database=StajDB;Trusted_Connection=True;";
        public musteriFaturaİadeFormu()
        {
            InitializeComponent();

            // Validating olayını bağla
            this.txtFaturaSeri.Validating += new CancelEventHandler(txtFaturaSeri_Validating);

            // Otomatik doğrulamayı aktif et
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private DateTime lastValidDate = DateTime.Today;
        //Form Load
        private void musteriFaturaİadeFormu_Load(object sender, EventArgs e)
        {
            LoadMusteriAdi();
            LoadFaturaGrubu();
            LoadİadeNedenleri();

            //dtpFaturaTarihi ayarı
            dtpFaturaTarihi.Value = DateTime.Today;
            lastValidDate = dtpFaturaTarihi.Value;

            //dtpMfisTarihi ayarı
            dtpMFisTarihi.Value = DateTime.Today;
            lastValidDate = dtpMFisTarihi.Value;

            dgvFaturaSatirlari.Columns.Add("seri", "SERİ");
            dgvFaturaSatirlari.Columns.Add("irsaliye", "İRSALİYE");
            dgvFaturaSatirlari.Columns.Add("aciklama", "AÇIKLAMA");
            dgvFaturaSatirlari.Columns.Add("adet", "ADET");
            dgvFaturaSatirlari.Columns.Add("kdvorani", "KDV ORANI");
            dgvFaturaSatirlari.Columns.Add("kdvtutari", "KDV TUTARI");
            dgvFaturaSatirlari.Columns.Add("tutar", "TUTAR");
            dgvFaturaSatirlari.Columns.Add("dovizlikdvtutari", "DÖVİZLİ KDV TUTARI");
            dgvFaturaSatirlari.Columns.Add("dovizKuru", "DÖVİZ KURU");
            dgvFaturaSatirlari.Columns.Add("dovizTutar", "DÖVİZ TUTARI");
            dgvFaturaSatirlari.Columns.Add("DovizTuru", "Döviz Türü");

            dgvFaturaSatirlari.Columns.Add("DovizTuruId", "DovizTuruId");
            dgvFaturaSatirlari.Columns["DovizTuruId"].Visible = false;

            dgvFaturaSatirlari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

            dgvFaturaSatirlari.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvFaturaSatirlari.AutoGenerateColumns = false;  //data ekleyince fazladan satır eklemesin diye

            dgvFaturaSatirlari.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFaturaSatirlari.MultiSelect = true;
            dgvFaturaSatirlari.ClearSelection();
        }

        //Müşteri Bilgileri
        //Müşteri adı Db
        private void LoadMusteriAdi()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT name, ACCOUNTID FROM ACCOUNT ";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbMusteriAdi.DisplayMember = "name"; // Gösterilecek değer
                    cmbMusteriAdi.ValueMember = "ACCOUNTID"; // Arka planda tutulacak değer
                    cmbMusteriAdi.DataSource = dt; // Veri kaynağı

                    cmbMusteriAdi.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void cmbMusteriAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMusteriAdi.SelectedValue != null)
            {
                string accountId = cmbMusteriAdi.SelectedValue.ToString();
                LoadAccountAddressNames(accountId);
            }
            MusteriBilgisiKontrolEt();
        }
        //Cari Hesap Db
        private void LoadAccountAddressNames(string accountId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Name, ACCOUNTADDRESSVERSIONID FROM ACCOUNTADDRESS WHERE ACCOUNTID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", accountId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCariHesap.DisplayMember = "Name"; 
                    cmbCariHesap.ValueMember = "ACCOUNTADDRESSVERSIONID";
                    cmbCariHesap.DataSource = dt;

                    cmbCariHesap.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void cmbCariHesap_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusteriBilgisiKontrolEt();
        }
        //musteri bilgileri boşsa cmb ler disable
        private void MusteriBilgisiKontrolEt()
        {
            bool bilgiTam =
                !string.IsNullOrWhiteSpace(cmbMusteriAdi.Text) &&
                !string.IsNullOrWhiteSpace(cmbCariHesap.Text);

            grpFaturaUstBilgisi.Enabled = bilgiTam;
            grpFaturaSatiri.Enabled = bilgiTam;
        }

        //Fatura üst bilgisi
        //Fatura Seri
        private void txtFaturaSeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Harf değilse engelle, harfse büyük yap
            if (char.IsLetter(e.KeyChar))
                e.KeyChar = char.ToUpper(e.KeyChar);
            else if (!char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtFaturaSeri_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtFaturaSeri.Text.Trim().ToUpper(), @"^[A-Z]{3}$"))
            {
                MessageBox.Show("Fatura Serisi 3 harf olmalıdır (sadece harf).",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        //Fatura Numarası Alanı Sadece sayısal
        private void txtFaturaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }
        //Fatura tarihi
        private void dtpFaturaTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFaturaTarihi.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Bugünden ileri bir tarih seçemezsiniz!", "Geçersiz tarih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Seçimi geçerli tarihe geri al
                dtpFaturaTarihi.Value = lastValidDate;
            }
            else
            {
                // Geçerli tarih ise kaydet
                lastValidDate = dtpFaturaTarihi.Value;
            }
        }
        //M. Fiş Tarihi check
        private void chkMFisTarihi_CheckedChanged(object sender, EventArgs e)
        {
            dtpMFisTarihi.Enabled = chkMFisTarihi.Checked;
            lblMFisTarihi.Enabled = chkMFisTarihi.Checked;
        }
        
        //M. Fis Tarihi
        private void dtpMFisTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (dtpMFisTarihi.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Bugünden ileri bir tarih seçemezsiniz!", "Geçersiz tarih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Seçimi geçerli tarihe geri al
                dtpMFisTarihi.Value = lastValidDate;
            }
            else
            {
                // Geçerli tarih ise kaydet
                lastValidDate = dtpMFisTarihi.Value;
            }
        }
        //Fatura Grubu
        private void LoadFaturaGrubu()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT LOVINVOICETYPEID, name FROM LOVINVOICESUBTYPE";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbFaturaGrubu.DisplayMember = "name";
                    cmbFaturaGrubu.ValueMember = "LOVINVOICETYPEID"; 
                    cmbFaturaGrubu.DataSource = dt;

                    cmbFaturaGrubu.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        //İade Nedenleri
        private void LoadİadeNedenleri()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT LOVINVOICERETURNREASONID, name FROM LOVINVOICERETURNREASON";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbIadeNedenleri.DisplayMember = "name"; 
                    cmbIadeNedenleri.ValueMember = "LOVINVOICERETURNREASONID"; 
                    cmbIadeNedenleri.DataSource = dt;

                    cmbIadeNedenleri.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        //Fatura satırı


        //ekle butonu
        private void btnEkle_Click(object sender, EventArgs e)
        {
            var mevcutIrsaliyeler = dgvFaturaSatirlari.Rows
       .Cast<DataGridViewRow>()
       .Select(r => r.Cells["irsaliye"].Value?.ToString())
       .Where(s => !string.IsNullOrEmpty(s))
       .ToList();

            string mevcutDovizTuru = "";
            if (dgvFaturaSatirlari.Rows.Count > 0 && dgvFaturaSatirlari.Rows[0].Cells["DovizTuru"].Value != null)
            {
                mevcutDovizTuru = dgvFaturaSatirlari.Rows[0].Cells["DovizTuru"].Value.ToString();
            }

            string seriNo = txtFaturaSeri.Text;  // Ana formdaki seri no
            using (var frm = new faturaSatiriGirisFormu(seriNo, mevcutDovizTuru, mevcutIrsaliyeler))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Döviz türü kontrolü
                    if (dgvFaturaSatirlari.Rows.Count > 0)
                    {
                        if (mevcutDovizTuru != frm.DovizTuru)
                        {
                            MessageBox.Show($"Tüm satırlar aynı döviz türüne sahip olmalıdır!",
                                            "Döviz Türü Uyuşmazlığı",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        mevcutDovizTuru = frm.DovizTuru; // İlk satırda ata
                    }

                    // KDV tutarını hesapla
                    decimal kdvTutari = (frm.Tutar * frm.KdvOrani) / 100;

                    kdvTutari = Math.Round(kdvTutari, 2);

                    // dövizli kDV tutarını hesapla
                    decimal dövizliKdvTutari = frm.DovizliFatura
                        ? (frm.DovizliTutar * frm.KdvOrani) / 100
                        : 0;

                    dgvFaturaSatirlari.Rows.Add(
                        txtFaturaSeri.Text,
                        frm.Irsaliye,
                        frm.Aciklama,
                        frm.Adet,
                        frm.KdvOrani,
                        kdvTutari,
                        frm.Tutar,
                        dövizliKdvTutari,
                        frm.DovizKuru,
                        frm.DovizliTutar,
                        frm.DovizTuru,
                        frm.DovizTuruId
                    );
                    UpdateTotals();
                }
                dgvFaturaSatirlari.ClearSelection();
            }
        }
        //Kaldır butonu
        bool secimModu = false;
        private void btnKaldir_Click(object sender, EventArgs e)
        {
            if (!secimModu)
            {
                // Seçim moduna geç
                dgvFaturaSatirlari.ClearSelection();
                dgvFaturaSatirlari.Enabled = true;
                secimModu = true;
                MessageBox.Show("Lütfen silinecek satır(lar)ı seçin ve tekrar 'Kaldır' butonuna basın.",
                                "Seçim Modu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                if (dgvFaturaSatirlari.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show(
                        "Seçilen satır(lar)ı kaldırmak istediğinize emin misiniz?",
                        "Onay",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dgvFaturaSatirlari.SelectedRows.Cast<DataGridViewRow>().OrderByDescending(r => r.Index))
                        {
                            dgvFaturaSatirlari.Rows.RemoveAt(row.Index);
                        }
                        UpdateTotals();
                    }
                }
                else
                {
                    MessageBox.Show("Herhangi bir satır seçilmedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Seçim modu kapat
                dgvFaturaSatirlari.ClearSelection();
                secimModu = false;
            }
        }
        //En alt kısım
        private void ToplamDovizTutarHesapla()
        {
            decimal toplam = 0;

            foreach (DataGridViewRow row in dgvFaturaSatirlari.Rows)
            {
                if (row.Cells["dovizTutar"].Value != null &&
                    decimal.TryParse(row.Cells["dovizTutar"].Value.ToString(), out decimal tutar))
                {
                    toplam += tutar;
                }
            }

            txtToplamDovizTutar.Text = toplam.ToString("N2"); // Virgülden sonra 2 basamak
        }

        private void ToplamTutarHesapla()
        {
            decimal toplam = 0;

            foreach (DataGridViewRow row in dgvFaturaSatirlari.Rows)
            {
                if (row.Cells["tutar"].Value != null &&
                    decimal.TryParse(row.Cells["tutar"].Value.ToString(), out decimal tutar))
                {
                    toplam += tutar;
                }
            }

            txtToplamTutarTL.Text = toplam.ToString("N2"); // Virgülden sonra 2 basamak
        }

        private void ToplamKdvHesapla()
        {
            decimal toplam = 0;

            foreach (DataGridViewRow row in dgvFaturaSatirlari.Rows)
            {
                if (row.Cells["kdvtutari"].Value != null &&
                    decimal.TryParse(row.Cells["kdvtutari"].Value.ToString(), out decimal tutar))
                {
                    toplam += tutar;
                }
            }
            txtKdvTL.Text = toplam.ToString("N2"); 
        }

        private void ToplamDövizliKdvHesapla()
        {
            decimal toplam = 0;

            foreach (DataGridViewRow row in dgvFaturaSatirlari.Rows)
            {
                if (row.Cells["dovizlikdvtutari"].Value != null &&
                    decimal.TryParse(row.Cells["dovizlikdvtutari"].Value.ToString(), out decimal tutar))
                {
                    toplam += tutar;
                }
            }

            txtKdvKur.Text = toplam.ToString("N2"); 
        }
        private void GenelToplamHesapla()
        {
            decimal genelToplam = 0;

            foreach (DataGridViewRow row in dgvFaturaSatirlari.Rows)
            {
                if (row.Cells["Tutar"].Value != null &&
                    decimal.TryParse(row.Cells["Tutar"].Value.ToString(), out decimal tutar) &&
                    row.Cells["KdvTutari"].Value != null &&
                    decimal.TryParse(row.Cells["KdvTutari"].Value.ToString(), out decimal kdv))
                {
                    genelToplam += (tutar + kdv);
                }
            }

            txtGenelToplamTL.Text = genelToplam.ToString("N2");
        }
        private void GenelDövizliToplamHesapla()
        {
            decimal genelDövizliToplam = 0;

            foreach (DataGridViewRow row in dgvFaturaSatirlari.Rows)
            {
                if (row.Cells["dovizTutar"].Value != null &&
                    decimal.TryParse(row.Cells["dovizTutar"].Value.ToString(), out decimal dovizTutar) &&
                    row.Cells["dovizlikdvtutari"].Value != null &&
                    decimal.TryParse(row.Cells["dovizlikdvtutari"].Value.ToString(), out decimal dovizlikdvtutari))
                {
                    genelDövizliToplam += (dovizTutar + dovizlikdvtutari);
                }
            }

            txtGenelToplamKur.Text = genelDövizliToplam.ToString("N2");
        }
        private void UpdateTotals()
        {
            ToplamTutarHesapla();
            ToplamDovizTutarHesapla();
            ToplamKdvHesapla();
            ToplamDövizliKdvHesapla();
            GenelToplamHesapla();
            GenelDövizliToplamHesapla();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Zorunlu alan kontrolleri
            if (string.IsNullOrWhiteSpace(txtAciklama.Text))
            {
                MessageBox.Show("Açıklama alanı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAciklama.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFaturaSeri.Text))
            {
                MessageBox.Show("Fatura Seri alanı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFaturaSeri.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFaturaNo.Text))
            {
                MessageBox.Show("Fatura No alanı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFaturaNo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbMusteriAdi.Text))
            {
                MessageBox.Show("Lütfen bir Müşteri Adı seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMusteriAdi.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbCariHesap.Text))
            {
                MessageBox.Show("Lütfen bir Cari Hesap seçiniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCariHesap.Focus();
                return;
            }

            // Veritabanına veri gönderimi
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string invoiceReturnID = null;

                    // Fatura iade üst bilgilerini ekle
                    string insertInvoiceReturnSql = @"
                INSERT INTO INVOICERETURN
                (
                    ACCOUNTID,
                    ACCOUNTADDRESSVERSIONID,
                    DOCUMENT_SERIAL,
                    DOCUMENT_NUMBER,
                    DOCUMENT_DATE,
                    DESCRIPTION,
                    LOVINVOICESUBTYPEID,
                    OPERATION_DATE,
                    LOVINVOICERETURNREASONID,
                    ISMATBU
                )
                OUTPUT INSERTED.INVOICERETURNID
                VALUES
                (
                    @ACCOUNTID,
                    @ACCOUNTADDRESSVERSIONID,
                    @DOCUMENT_SERIAL,
                    @DOCUMENT_NUMBER,
                    @DOCUMENT_DATE,
                    @DESCRIPTION,
                    @LOVINVOICESUBTYPEID,
                    @OPERATION_DATE,
                    @LOVINVOICERETURNREASONID,
                    @ISMATBU
                );";

                    SqlCommand cmdInvoiceReturn = new SqlCommand(insertInvoiceReturnSql, conn, transaction);
                    cmdInvoiceReturn.Parameters.Add("@ACCOUNTID", SqlDbType.VarChar, 32).Value = new Guid(cmbMusteriAdi.SelectedValue.ToString()).ToString("N");
                    cmdInvoiceReturn.Parameters.Add("@ACCOUNTADDRESSVERSIONID", SqlDbType.VarChar, 32).Value = new Guid(cmbCariHesap.SelectedValue.ToString()).ToString("N");
                    cmdInvoiceReturn.Parameters.Add("@DOCUMENT_SERIAL", SqlDbType.NVarChar, 3).Value = txtFaturaSeri.Text;
                    cmdInvoiceReturn.Parameters.Add("@DOCUMENT_NUMBER", SqlDbType.NVarChar, 16).Value = txtFaturaNo.Text;
                    cmdInvoiceReturn.Parameters.Add("@DOCUMENT_DATE", SqlDbType.Date).Value = dtpFaturaTarihi.Value;
                    cmdInvoiceReturn.Parameters.Add("@DESCRIPTION", SqlDbType.NVarChar, 256).Value = txtAciklama.Text;
                    cmdInvoiceReturn.Parameters.Add("@LOVINVOICESUBTYPEID", SqlDbType.SmallInt).Value = cmbFaturaGrubu.SelectedValue;
                    cmdInvoiceReturn.Parameters.Add("@OPERATION_DATE", SqlDbType.Date).Value = DateTime.Now.Date;
                    cmdInvoiceReturn.Parameters.Add("@LOVINVOICERETURNREASONID", SqlDbType.SmallInt).Value = cmbIadeNedenleri.SelectedValue;
                    cmdInvoiceReturn.Parameters.Add("@ISMATBU", SqlDbType.TinyInt).Value = (cmbMatbuFaturaMi.SelectedIndex == 0);

                    invoiceReturnID = cmdInvoiceReturn.ExecuteScalar()?.ToString();

                    if (string.IsNullOrEmpty(invoiceReturnID))
                    {
                        throw new Exception("Fatura üst bilgileri kaydedilirken bir sorun oluştu.");
                    }

                    // Döviz türü adından ID'yi bulacak yardımcı metot
                    int GetCurrencyId(string currencyName, SqlConnection connection, SqlTransaction tran)
                    {
                        if (string.IsNullOrEmpty(currencyName)) return 0;

                        string query = "SELECT LOVCURRENCYTYPEID FROM LOVCURRENCYTYPE WHERE name = @name";
                        SqlCommand cmd = new SqlCommand(query, connection, tran);
                        cmd.Parameters.AddWithValue("@name", currencyName);

                        var result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            return id;
                        }
                        return 0;
                    }

                    // Fatura satırlarını ekle
                    string insertLineSql = @"
                INSERT INTO INVOICERETURNLINE
                (
                    INVOICERETURNID,DESCRIPTION,COUNT,VAT_RATE,PRICE,EXCHANGE_RATE, EXCHANGE_PRICE, EXCHANGE_VAT,
                    LOVCURRENCYTYPEID,AUDIT_CREATE_DATE, AUDITCREATEDBY,AUDITCREATEUNITID
                )
                VALUES
                (
                    @INVOICERETURNID, @DESCRIPTION, @COUNT, @VAT_RATE, @PRICE, @EXCHANGE_RATE, @EXCHANGE_PRICE,
                    @EXCHANGE_VAT, @LOVCURRENCYTYPEID, @AUDIT_CREATE_DATE, @AUDITCREATEDBY,  @AUDITCREATEUNITID
                )";

                    foreach (DataGridViewRow row in dgvFaturaSatirlari.Rows)
                    {
                        if (row.IsNewRow) continue;

                        SqlCommand cmdLine = new SqlCommand(insertLineSql, conn, transaction);
                        cmdLine.Parameters.Add("@INVOICERETURNID", SqlDbType.VarChar, 32).Value = invoiceReturnID;
                        cmdLine.Parameters.Add("@DESCRIPTION", SqlDbType.NVarChar, 256).Value = row.Cells["aciklama"].Value?.ToString() ?? "";
                        cmdLine.Parameters.Add("@COUNT", SqlDbType.Decimal).Value = Convert.ToDecimal(row.Cells["adet"].Value ?? 0);
                        cmdLine.Parameters.Add("@VAT_RATE", SqlDbType.Decimal).Value = Convert.ToDecimal(row.Cells["kdvorani"].Value ?? 0);
                        cmdLine.Parameters.Add("@PRICE", SqlDbType.Decimal).Value = Convert.ToDecimal(row.Cells["tutar"].Value ?? 0);
                        cmdLine.Parameters.Add("@EXCHANGE_RATE", SqlDbType.Decimal).Value = Convert.ToDecimal(row.Cells["dovizKuru"].Value ?? 0);
                        cmdLine.Parameters.Add("@EXCHANGE_PRICE", SqlDbType.Decimal).Value = Convert.ToDecimal(row.Cells["dovizTutar"].Value ?? 0);
                        cmdLine.Parameters.Add("@EXCHANGE_VAT", SqlDbType.Decimal).Value = Convert.ToDecimal(row.Cells["dovizlikdvtutari"].Value ?? 0);

                        // Döviz türü adını kullanarak ID'yi bul ve parametreye ekle
                        int dovizTuruId = Convert.ToInt32(row.Cells["DovizTuruId"].Value);
                        cmdLine.Parameters.Add("@LOVCURRENCYTYPEID", SqlDbType.SmallInt).Value = dovizTuruId;

                        cmdLine.Parameters.Add("@AUDIT_CREATE_DATE", SqlDbType.DateTime2).Value = DateTime.Now;
                        cmdLine.Parameters.Add("@AUDITCREATEDBY", SqlDbType.Int).Value = 0;
                        cmdLine.Parameters.Add("@AUDITCREATEUNITID", SqlDbType.SmallInt).Value = 0;

                        cmdLine.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Fatura iade kaydı başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Kayıt sırasında genel bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExceldenAl_Click(object sender, EventArgs e)
        {
            ImportFromExcel();
            UpdateTotals(); 
        }
        private int GetDovizIdFromName(string dovizAdi)
        {
            int dovizId = 1; // Varsayılan: TL için ID 1

            string query = "SELECT LOVCURRENCYTYPEID FROM LOVCURRENCYTYPE WHERE name = @DovizAdi";

            using (SqlConnection conn = new SqlConnection(connectionString)) // connectionString kullanıldı
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@DovizAdi", dovizAdi.Trim());

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        dovizId = id;
                    }
                }
                catch (Exception ex)
                {
                    // Hata mesajı sadece konsola yazdırıldı, formda pop-up açmadı.
                    Console.WriteLine("Döviz ID çekilirken hata: " + ex.Message);
                }
            }
            return dovizId;
        }
        private void ImportFromExcel()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel Files|*.xls";
            openFileDialog1.Title = "Excel Dosyası Seçin";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            DialogResult confirm = MessageBox.Show(
                "Seçilen dosya: " + openFileDialog1.FileName + " dosyasıdır. Onaylıyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            string filePath = openFileDialog1.FileName;
            DataTable tempTable = new DataTable();

            try
            {
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var conf = new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration { UseHeaderRow = true }
                    };
                    tempTable = reader.AsDataSet(conf).Tables[0];
                }

                // --- DÖVİZ TÜRÜ KONTROLÜ ---
                // --- EXCEL VERİSİNE GÖRE DÖVİZ TÜRÜ BELİRLEME ---
                bool dovizliMi = false;
                string excelDovizTuru = "TL";

                if (tempTable.Columns.Contains("DÖVİZ TÜRÜ"))
                {
                    dovizliMi = true;
                    var excelDovizTurleri = tempTable.AsEnumerable()
                        .Select(r => r["DÖVİZ TÜRÜ"].ToString().Trim())
                        .Where(x => !string.IsNullOrEmpty(x))
                        .Distinct()
                        .ToList();

                    if (excelDovizTurleri.Count > 1)
                    {
                        MessageBox.Show("Seçtiğiniz Excel'de farklı döviz türlerinde kayıtlar mevcuttur, ekleme yapamazsınız. Lütfen kontrol ediniz!",
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    excelDovizTuru = excelDovizTurleri.FirstOrDefault() ?? "TL";
                }


                // --- GRID'DEKİ VE EXCEL'DEKİ DÖVİZ TÜRÜ KONTROLÜ ---
                if (dgvFaturaSatirlari.Rows.Count > 0)
                {
                    var gridDovizTuru = dgvFaturaSatirlari.Rows[0].Cells["dovizTuru"].Value?.ToString();
                    if (!string.IsNullOrEmpty(gridDovizTuru) && gridDovizTuru != excelDovizTuru)
                    {
                        MessageBox.Show("Farklı döviz türünde kayıt ekleyemezsiniz. Lütfen Excel’inizi kontrol edip tekrar deneyin!",
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // --- EXCEL İRSALİYE KONTROLÜ ---
                var excelIrsaliyeNoList = tempTable.AsEnumerable()
                .Select(r => r["İRSALİYENO"].ToString().Trim())
                .Where(x => !string.IsNullOrEmpty(x))
                .ToList();

                var gridIrsaliyeNoList = dgvFaturaSatirlari.Rows
                    .Cast<DataGridViewRow>()
                    .Select(r => r.Cells["irsaliye"].Value?.ToString().Trim()) 
                    .Where(x => !string.IsNullOrEmpty(x))
                    .ToList();

                if (excelIrsaliyeNoList.Any(i => gridIrsaliyeNoList.Contains(i)))
                {
                    MessageBox.Show("Seçtiğiniz Excel'de, gridde zaten mevcut olan irsaliyeler var!",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // --- KDV VE ZORUNLU ALAN KONTROLLERİ ---
                foreach (DataRow row in tempTable.Rows)
                {
                    // KDV kontrolü
                    if (!int.TryParse(row["KDV"].ToString(), out int kdv) || !(kdv == 0 || kdv == 8 || kdv == 10 || kdv == 20))
                    {
                        MessageBox.Show("KDV oranı yanlıştır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Zorunlu alan kontrolü
                    bool eksikAlan = false;
                    if (dovizliMi)
                    {
                        if (string.IsNullOrWhiteSpace(row["KDV"].ToString()) ||
                            string.IsNullOrWhiteSpace(row["AÇIKLAMA"].ToString()) ||
                            string.IsNullOrWhiteSpace(row["İRSALİYENO"].ToString()) ||
                            string.IsNullOrWhiteSpace(row["DÖVİZLİ TUTAR"].ToString()) ||
                            string.IsNullOrWhiteSpace(row["DÖVİZ KURU"].ToString()) ||
                            string.IsNullOrWhiteSpace(row["DÖVİZ TÜRÜ"].ToString()))
                            eksikAlan = true;
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(row["KDV"].ToString()) ||
                            string.IsNullOrWhiteSpace(row["AÇIKLAMA"].ToString()) ||
                            string.IsNullOrWhiteSpace(row["TUTAR"].ToString()) ||
                            string.IsNullOrWhiteSpace(row["İRSALİYENO"].ToString()))
                            eksikAlan = true;
                    }

                    if (eksikAlan)
                    {
                        MessageBox.Show("Excel'deki bilgileri kontrol ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }


                foreach (DataRow row in tempTable.Rows)
                {
                    int idx = dgvFaturaSatirlari.Rows.Add();
                    DataGridViewRow gridRow = dgvFaturaSatirlari.Rows[idx];

                    // Genel alanlar
                    gridRow.Cells["seri"].Value = row["SERİ"].ToString();
                    gridRow.Cells["irsaliye"].Value = row["İRSALİYENO"].ToString();
                    gridRow.Cells["aciklama"].Value = row["AÇIKLAMA"].ToString();

                    decimal kdvOrani = 0;
                    decimal.TryParse(row["KDV"].ToString(), out kdvOrani);

                    decimal tutar = 0;
                    decimal kdvtutari = 0;

                    if (dovizliMi)
                    {
                        decimal dovizliTutar = 0, dovizKuru = 0;
                        decimal.TryParse(row["DÖVİZLİ TUTAR"].ToString(), out dovizliTutar);
                        decimal.TryParse(row["DÖVİZ KURU"].ToString(), out dovizKuru);

                        // Tutar hesaplama (Dövizli)
                        tutar = dovizliTutar * dovizKuru;
                        kdvtutari = tutar * kdvOrani / 100;

                        gridRow.Cells["dovizTutar"].Value = dovizliTutar;
                        gridRow.Cells["dovizKuru"].Value = dovizKuru;
                        gridRow.Cells["DovizTuru"].Value = row["DÖVİZ TÜRÜ"].ToString();
                        gridRow.Cells["DovizTuruId"].Value = GetDovizIdFromName(row["DÖVİZ TÜRÜ"].ToString());

                        // Dövizli KDV tutarı
                        gridRow.Cells["dovizlikdvtutari"].Value = dovizliTutar * kdvOrani / 100;
                    }
                    else
                    {
                        decimal.TryParse(row["TUTAR"].ToString(), out tutar);
                        kdvtutari = tutar * kdvOrani / 100;

                        gridRow.Cells["dovizTutar"].Value = 0;
                        gridRow.Cells["dovizKuru"].Value = 0;
                        gridRow.Cells["DovizTuru"].Value = "TL";
                        gridRow.Cells["DovizTuruId"].Value = GetDovizIdFromName("TL");
                        gridRow.Cells["dovizlikdvtutari"].Value = 0;
                    }

                    // Ortak alanlar
                    gridRow.Cells["kdvorani"].Value = kdvOrani;
                    gridRow.Cells["tutar"].Value = tutar;
                    gridRow.Cells["kdvtutari"].Value = kdvtutari;
                    gridRow.Cells["adet"].Value = 0;
                }


                MessageBox.Show("Excel'den veriler başarıyla aktarıldı.",
                    "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbFaturaGrubu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
