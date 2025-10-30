namespace faturalama
{
    partial class musteriFaturaİadeFormu
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
            this.cmbMusteriAdi = new System.Windows.Forms.ComboBox();
            this.grpMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.cmbCariHesap = new System.Windows.Forms.ComboBox();
            this.lblCariHesap = new System.Windows.Forms.Label();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.grpFaturaUstBilgisi = new System.Windows.Forms.GroupBox();
            this.grpMFisTarihi = new System.Windows.Forms.GroupBox();
            this.lblMFisTarihi = new System.Windows.Forms.Label();
            this.dtpMFisTarihi = new System.Windows.Forms.DateTimePicker();
            this.chkMFisTarihi = new System.Windows.Forms.CheckBox();
            this.cmbMatbuFaturaMi = new System.Windows.Forms.ComboBox();
            this.cmbIadeNedenleri = new System.Windows.Forms.ComboBox();
            this.cmbFaturaGrubu = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.txtFaturaSeri = new System.Windows.Forms.TextBox();
            this.dtpFaturaTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblMatbuFaturami = new System.Windows.Forms.Label();
            this.lblİadeNedenleri = new System.Windows.Forms.Label();
            this.lblFaturaGrubu = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblFaturaTarih = new System.Windows.Forms.Label();
            this.lblFaturaNumara = new System.Windows.Forms.Label();
            this.lblFaturaSeri = new System.Windows.Forms.Label();
            this.grpFaturaSatiri = new System.Windows.Forms.GroupBox();
            this.dgvFaturaSatirlari = new System.Windows.Forms.DataGridView();
            this.btnExceldenAl = new System.Windows.Forms.Button();
            this.btnKaldir = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtToplamTutarTL = new System.Windows.Forms.TextBox();
            this.txtToplamDovizTutar = new System.Windows.Forms.TextBox();
            this.txtKdvTL = new System.Windows.Forms.TextBox();
            this.txtKdvKur = new System.Windows.Forms.TextBox();
            this.txtGenelToplamTL = new System.Windows.Forms.TextBox();
            this.txtGenelToplamKur = new System.Windows.Forms.TextBox();
            this.grpMusteriBilgileri.SuspendLayout();
            this.grpFaturaUstBilgisi.SuspendLayout();
            this.grpMFisTarihi.SuspendLayout();
            this.grpFaturaSatiri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturaSatirlari)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMusteriAdi
            // 
            this.cmbMusteriAdi.FormattingEnabled = true;
            this.cmbMusteriAdi.Location = new System.Drawing.Point(184, 37);
            this.cmbMusteriAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMusteriAdi.Name = "cmbMusteriAdi";
            this.cmbMusteriAdi.Size = new System.Drawing.Size(429, 24);
            this.cmbMusteriAdi.TabIndex = 0;
            this.cmbMusteriAdi.SelectedIndexChanged += new System.EventHandler(this.cmbMusteriAdi_SelectedIndexChanged);
            // 
            // grpMusteriBilgileri
            // 
            this.grpMusteriBilgileri.Controls.Add(this.cmbCariHesap);
            this.grpMusteriBilgileri.Controls.Add(this.lblCariHesap);
            this.grpMusteriBilgileri.Controls.Add(this.cmbMusteriAdi);
            this.grpMusteriBilgileri.Controls.Add(this.lblMusteriAdi);
            this.grpMusteriBilgileri.Location = new System.Drawing.Point(26, 11);
            this.grpMusteriBilgileri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMusteriBilgileri.Name = "grpMusteriBilgileri";
            this.grpMusteriBilgileri.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMusteriBilgileri.Size = new System.Drawing.Size(873, 126);
            this.grpMusteriBilgileri.TabIndex = 1;
            this.grpMusteriBilgileri.TabStop = false;
            this.grpMusteriBilgileri.Text = "Müşteri Bilgiler";
            // 
            // cmbCariHesap
            // 
            this.cmbCariHesap.FormattingEnabled = true;
            this.cmbCariHesap.Location = new System.Drawing.Point(184, 71);
            this.cmbCariHesap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCariHesap.Name = "cmbCariHesap";
            this.cmbCariHesap.Size = new System.Drawing.Size(429, 24);
            this.cmbCariHesap.TabIndex = 2;
            this.cmbCariHesap.SelectedIndexChanged += new System.EventHandler(this.cmbCariHesap_SelectedIndexChanged);
            // 
            // lblCariHesap
            // 
            this.lblCariHesap.AutoSize = true;
            this.lblCariHesap.Location = new System.Drawing.Point(31, 79);
            this.lblCariHesap.Name = "lblCariHesap";
            this.lblCariHesap.Size = new System.Drawing.Size(78, 16);
            this.lblCariHesap.TabIndex = 3;
            this.lblCariHesap.Text = "Cari Hesap:";
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(31, 41);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(76, 16);
            this.lblMusteriAdi.TabIndex = 2;
            this.lblMusteriAdi.Text = "Müşteri Adı:";
            // 
            // grpFaturaUstBilgisi
            // 
            this.grpFaturaUstBilgisi.Controls.Add(this.grpMFisTarihi);
            this.grpFaturaUstBilgisi.Controls.Add(this.cmbMatbuFaturaMi);
            this.grpFaturaUstBilgisi.Controls.Add(this.cmbIadeNedenleri);
            this.grpFaturaUstBilgisi.Controls.Add(this.cmbFaturaGrubu);
            this.grpFaturaUstBilgisi.Controls.Add(this.txtAciklama);
            this.grpFaturaUstBilgisi.Controls.Add(this.txtFaturaNo);
            this.grpFaturaUstBilgisi.Controls.Add(this.txtFaturaSeri);
            this.grpFaturaUstBilgisi.Controls.Add(this.dtpFaturaTarihi);
            this.grpFaturaUstBilgisi.Controls.Add(this.lblMatbuFaturami);
            this.grpFaturaUstBilgisi.Controls.Add(this.lblİadeNedenleri);
            this.grpFaturaUstBilgisi.Controls.Add(this.lblFaturaGrubu);
            this.grpFaturaUstBilgisi.Controls.Add(this.lblAciklama);
            this.grpFaturaUstBilgisi.Controls.Add(this.lblFaturaTarih);
            this.grpFaturaUstBilgisi.Controls.Add(this.lblFaturaNumara);
            this.grpFaturaUstBilgisi.Controls.Add(this.lblFaturaSeri);
            this.grpFaturaUstBilgisi.Location = new System.Drawing.Point(26, 156);
            this.grpFaturaUstBilgisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFaturaUstBilgisi.Name = "grpFaturaUstBilgisi";
            this.grpFaturaUstBilgisi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFaturaUstBilgisi.Size = new System.Drawing.Size(873, 203);
            this.grpFaturaUstBilgisi.TabIndex = 2;
            this.grpFaturaUstBilgisi.TabStop = false;
            this.grpFaturaUstBilgisi.Text = "Fatura Üst Bilgisi";
            // 
            // grpMFisTarihi
            // 
            this.grpMFisTarihi.Controls.Add(this.lblMFisTarihi);
            this.grpMFisTarihi.Controls.Add(this.dtpMFisTarihi);
            this.grpMFisTarihi.Controls.Add(this.chkMFisTarihi);
            this.grpMFisTarihi.Location = new System.Drawing.Point(564, 20);
            this.grpMFisTarihi.Name = "grpMFisTarihi";
            this.grpMFisTarihi.Size = new System.Drawing.Size(283, 49);
            this.grpMFisTarihi.TabIndex = 18;
            this.grpMFisTarihi.TabStop = false;
            // 
            // lblMFisTarihi
            // 
            this.lblMFisTarihi.AutoSize = true;
            this.lblMFisTarihi.Enabled = false;
            this.lblMFisTarihi.Location = new System.Drawing.Point(56, 21);
            this.lblMFisTarihi.Name = "lblMFisTarihi";
            this.lblMFisTarihi.Size = new System.Drawing.Size(82, 16);
            this.lblMFisTarihi.TabIndex = 18;
            this.lblMFisTarihi.Text = "M. Fiş Tarihi:";
            // 
            // dtpMFisTarihi
            // 
            this.dtpMFisTarihi.Enabled = false;
            this.dtpMFisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMFisTarihi.Location = new System.Drawing.Point(145, 15);
            this.dtpMFisTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMFisTarihi.Name = "dtpMFisTarihi";
            this.dtpMFisTarihi.Size = new System.Drawing.Size(129, 22);
            this.dtpMFisTarihi.TabIndex = 16;
            this.dtpMFisTarihi.ValueChanged += new System.EventHandler(this.dtpMFisTarihi_ValueChanged);
            // 
            // chkMFisTarihi
            // 
            this.chkMFisTarihi.AutoSize = true;
            this.chkMFisTarihi.Location = new System.Drawing.Point(19, 20);
            this.chkMFisTarihi.Name = "chkMFisTarihi";
            this.chkMFisTarihi.Size = new System.Drawing.Size(18, 17);
            this.chkMFisTarihi.TabIndex = 17;
            this.chkMFisTarihi.UseVisualStyleBackColor = true;
            this.chkMFisTarihi.CheckedChanged += new System.EventHandler(this.chkMFisTarihi_CheckedChanged);
            // 
            // cmbMatbuFaturaMi
            // 
            this.cmbMatbuFaturaMi.FormattingEnabled = true;
            this.cmbMatbuFaturaMi.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cmbMatbuFaturaMi.Location = new System.Drawing.Point(669, 167);
            this.cmbMatbuFaturaMi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMatbuFaturaMi.Name = "cmbMatbuFaturaMi";
            this.cmbMatbuFaturaMi.Size = new System.Drawing.Size(178, 24);
            this.cmbMatbuFaturaMi.TabIndex = 14;
            // 
            // cmbIadeNedenleri
            // 
            this.cmbIadeNedenleri.FormattingEnabled = true;
            this.cmbIadeNedenleri.Location = new System.Drawing.Point(669, 133);
            this.cmbIadeNedenleri.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIadeNedenleri.Name = "cmbIadeNedenleri";
            this.cmbIadeNedenleri.Size = new System.Drawing.Size(178, 24);
            this.cmbIadeNedenleri.TabIndex = 13;
            // 
            // cmbFaturaGrubu
            // 
            this.cmbFaturaGrubu.FormattingEnabled = true;
            this.cmbFaturaGrubu.Location = new System.Drawing.Point(669, 100);
            this.cmbFaturaGrubu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFaturaGrubu.Name = "cmbFaturaGrubu";
            this.cmbFaturaGrubu.Size = new System.Drawing.Size(178, 24);
            this.cmbFaturaGrubu.TabIndex = 12;
            this.cmbFaturaGrubu.SelectedIndexChanged += new System.EventHandler(this.cmbFaturaGrubu_SelectedIndexChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(155, 158);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(387, 22);
            this.txtAciklama.TabIndex = 11;
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(155, 58);
            this.txtFaturaNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFaturaNo.MaxLength = 13;
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(156, 22);
            this.txtFaturaNo.TabIndex = 10;
            this.txtFaturaNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFaturaNo_KeyPress);
            // 
            // txtFaturaSeri
            // 
            this.txtFaturaSeri.Location = new System.Drawing.Point(155, 31);
            this.txtFaturaSeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFaturaSeri.MaxLength = 3;
            this.txtFaturaSeri.Name = "txtFaturaSeri";
            this.txtFaturaSeri.Size = new System.Drawing.Size(100, 22);
            this.txtFaturaSeri.TabIndex = 9;
            this.txtFaturaSeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFaturaSeri_KeyPress);
            // 
            // dtpFaturaTarihi
            // 
            this.dtpFaturaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFaturaTarihi.Location = new System.Drawing.Point(155, 87);
            this.dtpFaturaTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFaturaTarihi.Name = "dtpFaturaTarihi";
            this.dtpFaturaTarihi.Size = new System.Drawing.Size(156, 22);
            this.dtpFaturaTarihi.TabIndex = 8;
            this.dtpFaturaTarihi.ValueChanged += new System.EventHandler(this.dtpFaturaTarihi_ValueChanged);
            // 
            // lblMatbuFaturami
            // 
            this.lblMatbuFaturami.AutoSize = true;
            this.lblMatbuFaturami.Location = new System.Drawing.Point(552, 171);
            this.lblMatbuFaturami.Name = "lblMatbuFaturami";
            this.lblMatbuFaturami.Size = new System.Drawing.Size(102, 16);
            this.lblMatbuFaturami.TabIndex = 6;
            this.lblMatbuFaturami.Text = "MatbuFatura mı:";
            // 
            // lblİadeNedenleri
            // 
            this.lblİadeNedenleri.AutoSize = true;
            this.lblİadeNedenleri.Location = new System.Drawing.Point(552, 137);
            this.lblİadeNedenleri.Name = "lblİadeNedenleri";
            this.lblİadeNedenleri.Size = new System.Drawing.Size(99, 16);
            this.lblİadeNedenleri.TabIndex = 5;
            this.lblİadeNedenleri.Text = "İade Nedenleri:";
            // 
            // lblFaturaGrubu
            // 
            this.lblFaturaGrubu.AutoSize = true;
            this.lblFaturaGrubu.Location = new System.Drawing.Point(552, 103);
            this.lblFaturaGrubu.Name = "lblFaturaGrubu";
            this.lblFaturaGrubu.Size = new System.Drawing.Size(87, 16);
            this.lblFaturaGrubu.TabIndex = 4;
            this.lblFaturaGrubu.Text = "Fatura Grubu:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(31, 161);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(66, 16);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // lblFaturaTarih
            // 
            this.lblFaturaTarih.AutoSize = true;
            this.lblFaturaTarih.Location = new System.Drawing.Point(31, 84);
            this.lblFaturaTarih.Name = "lblFaturaTarih";
            this.lblFaturaTarih.Size = new System.Drawing.Size(82, 16);
            this.lblFaturaTarih.TabIndex = 2;
            this.lblFaturaTarih.Text = "Fatura Tarih:";
            // 
            // lblFaturaNumara
            // 
            this.lblFaturaNumara.AutoSize = true;
            this.lblFaturaNumara.Location = new System.Drawing.Point(31, 58);
            this.lblFaturaNumara.Name = "lblFaturaNumara";
            this.lblFaturaNumara.Size = new System.Drawing.Size(99, 16);
            this.lblFaturaNumara.TabIndex = 1;
            this.lblFaturaNumara.Text = "Fatura Numara:";
            // 
            // lblFaturaSeri
            // 
            this.lblFaturaSeri.AutoSize = true;
            this.lblFaturaSeri.Location = new System.Drawing.Point(31, 31);
            this.lblFaturaSeri.Name = "lblFaturaSeri";
            this.lblFaturaSeri.Size = new System.Drawing.Size(76, 16);
            this.lblFaturaSeri.TabIndex = 0;
            this.lblFaturaSeri.Text = "Farura Seri:";
            // 
            // grpFaturaSatiri
            // 
            this.grpFaturaSatiri.Controls.Add(this.dgvFaturaSatirlari);
            this.grpFaturaSatiri.Controls.Add(this.btnExceldenAl);
            this.grpFaturaSatiri.Controls.Add(this.btnKaldir);
            this.grpFaturaSatiri.Controls.Add(this.btnEkle);
            this.grpFaturaSatiri.Location = new System.Drawing.Point(26, 366);
            this.grpFaturaSatiri.Margin = new System.Windows.Forms.Padding(4);
            this.grpFaturaSatiri.Name = "grpFaturaSatiri";
            this.grpFaturaSatiri.Padding = new System.Windows.Forms.Padding(4);
            this.grpFaturaSatiri.Size = new System.Drawing.Size(873, 218);
            this.grpFaturaSatiri.TabIndex = 3;
            this.grpFaturaSatiri.TabStop = false;
            this.grpFaturaSatiri.Text = "Fatura Satırı";
            // 
            // dgvFaturaSatirlari
            // 
            this.dgvFaturaSatirlari.AllowUserToAddRows = false;
            this.dgvFaturaSatirlari.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFaturaSatirlari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFaturaSatirlari.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFaturaSatirlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaturaSatirlari.EnableHeadersVisualStyles = false;
            this.dgvFaturaSatirlari.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvFaturaSatirlari.Location = new System.Drawing.Point(34, 23);
            this.dgvFaturaSatirlari.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFaturaSatirlari.Name = "dgvFaturaSatirlari";
            this.dgvFaturaSatirlari.RowHeadersVisible = false;
            this.dgvFaturaSatirlari.RowHeadersWidth = 51;
            this.dgvFaturaSatirlari.Size = new System.Drawing.Size(813, 150);
            this.dgvFaturaSatirlari.TabIndex = 3;
            // 
            // btnExceldenAl
            // 
            this.btnExceldenAl.Location = new System.Drawing.Point(236, 182);
            this.btnExceldenAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnExceldenAl.Name = "btnExceldenAl";
            this.btnExceldenAl.Size = new System.Drawing.Size(100, 28);
            this.btnExceldenAl.TabIndex = 2;
            this.btnExceldenAl.Text = "Excelden Al";
            this.btnExceldenAl.UseVisualStyleBackColor = true;
            this.btnExceldenAl.Click += new System.EventHandler(this.btnExceldenAl_Click);
            // 
            // btnKaldir
            // 
            this.btnKaldir.Location = new System.Drawing.Point(128, 182);
            this.btnKaldir.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaldir.Name = "btnKaldir";
            this.btnKaldir.Size = new System.Drawing.Size(100, 28);
            this.btnKaldir.TabIndex = 1;
            this.btnKaldir.Text = "Kaldır";
            this.btnKaldir.UseVisualStyleBackColor = true;
            this.btnKaldir.Click += new System.EventHandler(this.btnKaldir_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(20, 182);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 28);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle...";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(658, 631);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Toplam Tutar:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(658, 668);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "KDV:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(658, 706);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Genel Toplam:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(763, 733);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(101, 34);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(870, 733);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(90, 34);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtToplamTutarTL
            // 
            this.txtToplamTutarTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToplamTutarTL.Location = new System.Drawing.Point(755, 628);
            this.txtToplamTutarTL.Name = "txtToplamTutarTL";
            this.txtToplamTutarTL.ReadOnly = true;
            this.txtToplamTutarTL.Size = new System.Drawing.Size(92, 22);
            this.txtToplamTutarTL.TabIndex = 9;
            this.txtToplamTutarTL.Text = "0.00";
            this.txtToplamTutarTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtToplamDovizTutar
            // 
            this.txtToplamDovizTutar.Location = new System.Drawing.Point(853, 628);
            this.txtToplamDovizTutar.Name = "txtToplamDovizTutar";
            this.txtToplamDovizTutar.ReadOnly = true;
            this.txtToplamDovizTutar.Size = new System.Drawing.Size(92, 22);
            this.txtToplamDovizTutar.TabIndex = 10;
            this.txtToplamDovizTutar.Text = "0.00";
            this.txtToplamDovizTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKdvTL
            // 
            this.txtKdvTL.Location = new System.Drawing.Point(755, 668);
            this.txtKdvTL.Name = "txtKdvTL";
            this.txtKdvTL.ReadOnly = true;
            this.txtKdvTL.Size = new System.Drawing.Size(92, 22);
            this.txtKdvTL.TabIndex = 11;
            this.txtKdvTL.Text = "0.00";
            this.txtKdvTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKdvKur
            // 
            this.txtKdvKur.Location = new System.Drawing.Point(853, 668);
            this.txtKdvKur.Name = "txtKdvKur";
            this.txtKdvKur.ReadOnly = true;
            this.txtKdvKur.Size = new System.Drawing.Size(92, 22);
            this.txtKdvKur.TabIndex = 12;
            this.txtKdvKur.Text = "0.00";
            this.txtKdvKur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGenelToplamTL
            // 
            this.txtGenelToplamTL.Location = new System.Drawing.Point(755, 703);
            this.txtGenelToplamTL.Name = "txtGenelToplamTL";
            this.txtGenelToplamTL.ReadOnly = true;
            this.txtGenelToplamTL.Size = new System.Drawing.Size(92, 22);
            this.txtGenelToplamTL.TabIndex = 13;
            this.txtGenelToplamTL.Text = "0.00";
            this.txtGenelToplamTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGenelToplamKur
            // 
            this.txtGenelToplamKur.Location = new System.Drawing.Point(853, 705);
            this.txtGenelToplamKur.Name = "txtGenelToplamKur";
            this.txtGenelToplamKur.ReadOnly = true;
            this.txtGenelToplamKur.Size = new System.Drawing.Size(92, 22);
            this.txtGenelToplamKur.TabIndex = 14;
            this.txtGenelToplamKur.Text = "0.00";
            this.txtGenelToplamKur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // musteriFaturaİadeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 784);
            this.Controls.Add(this.txtGenelToplamKur);
            this.Controls.Add(this.txtGenelToplamTL);
            this.Controls.Add(this.txtKdvKur);
            this.Controls.Add(this.txtKdvTL);
            this.Controls.Add(this.txtToplamDovizTutar);
            this.Controls.Add(this.txtToplamTutarTL);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grpFaturaSatiri);
            this.Controls.Add(this.grpFaturaUstBilgisi);
            this.Controls.Add(this.grpMusteriBilgileri);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "musteriFaturaİadeFormu";
            this.Text = "Müşteri Fatura İade Formu";
            this.Load += new System.EventHandler(this.musteriFaturaİadeFormu_Load);
            this.grpMusteriBilgileri.ResumeLayout(false);
            this.grpMusteriBilgileri.PerformLayout();
            this.grpFaturaUstBilgisi.ResumeLayout(false);
            this.grpFaturaUstBilgisi.PerformLayout();
            this.grpMFisTarihi.ResumeLayout(false);
            this.grpMFisTarihi.PerformLayout();
            this.grpFaturaSatiri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturaSatirlari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMusteriAdi;
        private System.Windows.Forms.GroupBox grpMusteriBilgileri;
        private System.Windows.Forms.Label lblCariHesap;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.ComboBox cmbCariHesap;
        private System.Windows.Forms.GroupBox grpFaturaUstBilgisi;
        private System.Windows.Forms.Label lblFaturaTarih;
        private System.Windows.Forms.Label lblFaturaNumara;
        private System.Windows.Forms.Label lblFaturaSeri;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.DateTimePicker dtpFaturaTarihi;
        private System.Windows.Forms.Label lblMatbuFaturami;
        private System.Windows.Forms.Label lblİadeNedenleri;
        private System.Windows.Forms.Label lblFaturaGrubu;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.TextBox txtFaturaSeri;
        private System.Windows.Forms.ComboBox cmbFaturaGrubu;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cmbMatbuFaturaMi;
        private System.Windows.Forms.ComboBox cmbIadeNedenleri;
        private System.Windows.Forms.DateTimePicker dtpMFisTarihi;
        private System.Windows.Forms.GroupBox grpFaturaSatiri;
        private System.Windows.Forms.Button btnExceldenAl;
        private System.Windows.Forms.Button btnKaldir;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvFaturaSatirlari;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chkMFisTarihi;
        private System.Windows.Forms.GroupBox grpMFisTarihi;
        private System.Windows.Forms.Label lblMFisTarihi;
        private System.Windows.Forms.TextBox txtToplamTutarTL;
        private System.Windows.Forms.TextBox txtToplamDovizTutar;
        private System.Windows.Forms.TextBox txtKdvTL;
        private System.Windows.Forms.TextBox txtKdvKur;
        private System.Windows.Forms.TextBox txtGenelToplamTL;
        private System.Windows.Forms.TextBox txtGenelToplamKur;
    }
}

