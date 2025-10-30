using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faturalama
{
    public partial class faturaAramaFormu : Form
    {
        string connectionString = @"Server=CEMRE\SQLEXPRESS02;Database=StajDB;Trusted_Connection=True;";
        PrintDocument printDoc = new PrintDocument();
        public faturaAramaFormu()
        {
            InitializeComponent();
            printDoc.PrintPage += PrintDoc_PrintPage;
        }
        private void faturaAramaFormu_Load(object sender, EventArgs e)
        {
            LoadMusteriAdi();

            dgvAramaSonucu.Columns.Add("accountName", "Müşteri Adı");
            dgvAramaSonucu.Columns.Add("accountAdressName", "Cari Hesap");
            dgvAramaSonucu.Columns.Add("documentSerial", "Fatura Seri");
            dgvAramaSonucu.Columns.Add("documentNumber", "Fatura No");
            dgvAramaSonucu.Columns.Add("documentDate", "Tarih");

            dgvAramaSonucu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAramaSonucu.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvAramaSonucu.AutoGenerateColumns = false;  //data ekleyince fazladan satır eklemesin diye
            dgvAramaSonucu.RowHeadersVisible = false;
        }
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

                    cmbMusteriAdi.DisplayMember = "name";
                    cmbMusteriAdi.ValueMember = "ACCOUNTID";
                    cmbMusteriAdi.DataSource = dt;

                    cmbMusteriAdi.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void btnFaturaIadeFormaGit_Click(object sender, EventArgs e)
        {
            musteriFaturaİadeFormu iadeFormu = new musteriFaturaİadeFormu();
            iadeFormu.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblBitisTarihi_Click(object sender, EventArgs e)
        {
             
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                musteriAdinaGore();
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                tariheGore();
            }
        }
        private void musteriAdinaGore()
        {
            if (cmbMusteriAdi.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir müşteri seçin!");
                return;
            }

            string selectedAccountId = cmbMusteriAdi.SelectedValue.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    A.NAME AS MusteriAdi,
                    AD.NAME AS CariHesap,
                    IR.DOCUMENT_SERIAL,
                    IR.DOCUMENT_NUMBER,
                    IR.DOCUMENT_DATE
                FROM INVOICERETURN IR
                INNER JOIN ACCOUNT A ON IR.ACCOUNTID = A.ACCOUNTID
                INNER JOIN ACCOUNTADDRESS AD ON IR.ACCOUNTADDRESSVERSIONID = AD.ACCOUNTADDRESSVERSIONID
                WHERE IR.ACCOUNTID = @accountId
            ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@accountId", selectedAccountId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvAramaSonucu.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvAramaSonucu.Rows.Add(
                            row["MusteriAdi"],
                            row["CariHesap"],
                            row["DOCUMENT_SERIAL"],
                            row["DOCUMENT_NUMBER"],
                            Convert.ToDateTime(row["DOCUMENT_DATE"]).ToString("dd/MM/yyyy")
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void tariheGore()
        {
            DateTime baslangic = dtpBaslangicTarihi.Value.Date;
            DateTime bitis = dtpBitisTarihi.Value.Date;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    A.NAME AS MusteriAdi,
                    AD.NAME AS CariHesap,
                    IR.DOCUMENT_SERIAL,
                    IR.DOCUMENT_NUMBER,
                    IR.DOCUMENT_DATE
                FROM INVOICERETURN IR
                INNER JOIN ACCOUNT A ON IR.ACCOUNTID = A.ACCOUNTID
                INNER JOIN ACCOUNTADDRESS AD ON IR.ACCOUNTADDRESSVERSIONID = AD.ACCOUNTADDRESSVERSIONID
                WHERE IR.DOCUMENT_DATE BETWEEN @baslangic AND @bitis
            ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@baslangic", baslangic);
                    cmd.Parameters.AddWithValue("@bitis", bitis);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvAramaSonucu.Rows.Clear();

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Seçilen tarih aralığında fatura bulunamadı.");
                        return;
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        dgvAramaSonucu.Rows.Add(
                            row["MusteriAdi"],
                            row["CariHesap"],
                            row["DOCUMENT_SERIAL"],
                            row["DOCUMENT_NUMBER"],
                            Convert.ToDateTime(row["DOCUMENT_DATE"]).ToString("dd/MM/yyyy")
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = printDoc; // En önemli kısım: belgeyi bağla
            ppd.Width = 1000;
            ppd.Height = 800;
            ppd.ShowDialog();
        }

        private int currentRow = 0; // sayfa taşması için takip

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int y = topMargin;
            int rowHeight = 30;

            Font headerFont = new Font("Segoe UI", 10, FontStyle.Bold);
            Font cellFont = new Font("Segoe UI", 9);

            // --- Başlık çiz ---
            int x = leftMargin;
            foreach (DataGridViewColumn col in dgvAramaSonucu.Columns)
            {
                e.Graphics.DrawString(col.HeaderText, headerFont, Brushes.Black, x, y);
                x += col.Width; // Kolon genişliği kadar kay
            }
            y += rowHeight;

            // --- Satırları yazdır ---
            while (currentRow < dgvAramaSonucu.Rows.Count)
            {
                DataGridViewRow row = dgvAramaSonucu.Rows[currentRow];
                if (row.IsNewRow) { currentRow++; continue; }

                x = leftMargin;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string text = cell.Value?.ToString() ?? "";
                    e.Graphics.DrawString(text, cellFont, Brushes.Black, x, y);
                    x += cell.OwningColumn.Width;
                }

                y += rowHeight;
                currentRow++;

                // Sayfa bitti mi?
                if (y + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return; // sonraki PrintPage çağrısında devam eder
                }
            }

            // Hepsi yazıldı
            currentRow = 0;
            e.HasMorePages = false;
        }
        private void btnMusteriGirisFormu_Click(object sender, EventArgs e)
        {
            musteriFormu musteriFormu = new musteriFormu();
            musteriFormu.ShowDialog();
        }
    }
}
