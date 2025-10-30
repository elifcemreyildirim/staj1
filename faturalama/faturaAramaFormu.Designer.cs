namespace faturalama
{
    partial class faturaAramaFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFaturaIadeFormaGit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbMusteriAdi = new System.Windows.Forms.ComboBox();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.lblFaturaKesimTarihi = new System.Windows.Forms.Label();
            this.grpFiltrelenecekAlan = new System.Windows.Forms.GroupBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.dgvAramaSonucu = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnMusteriGirisFormu = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpFiltrelenecekAlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAramaSonucu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFaturaIadeFormaGit
            // 
            this.btnFaturaIadeFormaGit.Location = new System.Drawing.Point(178, 12);
            this.btnFaturaIadeFormaGit.Name = "btnFaturaIadeFormaGit";
            this.btnFaturaIadeFormaGit.Size = new System.Drawing.Size(113, 28);
            this.btnFaturaIadeFormaGit.TabIndex = 0;
            this.btnFaturaIadeFormaGit.Text = "Fatura Kesme";
            this.btnFaturaIadeFormaGit.UseVisualStyleBackColor = true;
            this.btnFaturaIadeFormaGit.Click += new System.EventHandler(this.btnFaturaIadeFormaGit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(382, 163);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbMusteriAdi);
            this.tabPage1.Controls.Add(this.lblMusteriAdi);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(374, 134);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbMusteriAdi
            // 
            this.cmbMusteriAdi.FormattingEnabled = true;
            this.cmbMusteriAdi.Location = new System.Drawing.Point(120, 54);
            this.cmbMusteriAdi.Name = "cmbMusteriAdi";
            this.cmbMusteriAdi.Size = new System.Drawing.Size(208, 24);
            this.cmbMusteriAdi.TabIndex = 1;
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(24, 59);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(76, 16);
            this.lblMusteriAdi.TabIndex = 0;
            this.lblMusteriAdi.Text = "Müşteri Adı:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtpBitisTarihi);
            this.tabPage2.Controls.Add(this.dtpBaslangicTarihi);
            this.tabPage2.Controls.Add(this.lblBitisTarihi);
            this.tabPage2.Controls.Add(this.lblBaslangicTarihi);
            this.tabPage2.Controls.Add(this.lblFaturaKesimTarihi);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(374, 134);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Location = new System.Drawing.Point(134, 90);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpBitisTarihi.TabIndex = 4;
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(134, 54);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpBaslangicTarihi.TabIndex = 3;
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.Location = new System.Drawing.Point(19, 94);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(72, 16);
            this.lblBitisTarihi.TabIndex = 2;
            this.lblBitisTarihi.Text = "Bitiş Tarihi:";
            this.lblBitisTarihi.Click += new System.EventHandler(this.lblBitisTarihi_Click);
            // 
            // lblBaslangicTarihi
            // 
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(15, 56);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(107, 16);
            this.lblBaslangicTarihi.TabIndex = 1;
            this.lblBaslangicTarihi.Text = "Baslangiç Tarihi:";
            // 
            // lblFaturaKesimTarihi
            // 
            this.lblFaturaKesimTarihi.AutoSize = true;
            this.lblFaturaKesimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaturaKesimTarihi.Location = new System.Drawing.Point(15, 19);
            this.lblFaturaKesimTarihi.Name = "lblFaturaKesimTarihi";
            this.lblFaturaKesimTarihi.Size = new System.Drawing.Size(156, 20);
            this.lblFaturaKesimTarihi.TabIndex = 0;
            this.lblFaturaKesimTarihi.Text = "Fatura Kesim Tarihi";
            // 
            // grpFiltrelenecekAlan
            // 
            this.grpFiltrelenecekAlan.Controls.Add(this.tabControl1);
            this.grpFiltrelenecekAlan.Location = new System.Drawing.Point(12, 59);
            this.grpFiltrelenecekAlan.Name = "grpFiltrelenecekAlan";
            this.grpFiltrelenecekAlan.Size = new System.Drawing.Size(388, 184);
            this.grpFiltrelenecekAlan.TabIndex = 2;
            this.grpFiltrelenecekAlan.TabStop = false;
            this.grpFiltrelenecekAlan.Text = "Filtrelenecek Alan";
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKapat.Location = new System.Drawing.Point(881, 427);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(92, 31);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // dgvAramaSonucu
            // 
            this.dgvAramaSonucu.AllowUserToAddRows = false;
            this.dgvAramaSonucu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAramaSonucu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAramaSonucu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAramaSonucu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAramaSonucu.EnableHeadersVisualStyles = false;
            this.dgvAramaSonucu.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAramaSonucu.Location = new System.Drawing.Point(22, 263);
            this.dgvAramaSonucu.Name = "dgvAramaSonucu";
            this.dgvAramaSonucu.RowHeadersWidth = 51;
            this.dgvAramaSonucu.RowTemplate.Height = 24;
            this.dgvAramaSonucu.Size = new System.Drawing.Size(831, 150);
            this.dgvAramaSonucu.TabIndex = 4;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(750, 204);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(86, 32);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYazdir.Location = new System.Drawing.Point(783, 427);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(92, 31);
            this.btnYazdir.TabIndex = 6;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnMusteriGirisFormu
            // 
            this.btnMusteriGirisFormu.Location = new System.Drawing.Point(15, 12);
            this.btnMusteriGirisFormu.Name = "btnMusteriGirisFormu";
            this.btnMusteriGirisFormu.Size = new System.Drawing.Size(157, 28);
            this.btnMusteriGirisFormu.TabIndex = 7;
            this.btnMusteriGirisFormu.Text = "Müşteri Giriş Formu";
            this.btnMusteriGirisFormu.UseVisualStyleBackColor = true;
            this.btnMusteriGirisFormu.Click += new System.EventHandler(this.btnMusteriGirisFormu_Click);
            // 
            // faturaAramaFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 481);
            this.Controls.Add(this.btnMusteriGirisFormu);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dgvAramaSonucu);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.grpFiltrelenecekAlan);
            this.Controls.Add(this.btnFaturaIadeFormaGit);
            this.Name = "faturaAramaFormu";
            this.Text = "Fatura Arama Formu";
            this.Load += new System.EventHandler(this.faturaAramaFormu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpFiltrelenecekAlan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAramaSonucu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFaturaIadeFormaGit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpFiltrelenecekAlan;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.ComboBox cmbMusteriAdi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.Label lblFaturaKesimTarihi;
        private System.Windows.Forms.DataGridView dgvAramaSonucu;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnMusteriGirisFormu;
    }
}