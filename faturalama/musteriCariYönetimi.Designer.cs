namespace faturalama
{
    partial class musteriCariYönetimi
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
            this.dgvCari = new System.Windows.Forms.DataGridView();
            this.btnDuzenleEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.grpCari = new System.Windows.Forms.GroupBox();
            this.txtCariAdi = new System.Windows.Forms.TextBox();
            this.grpİletişimBilgileri = new System.Windows.Forms.GroupBox();
            this.rtxtAdres = new System.Windows.Forms.RichTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobilTel = new System.Windows.Forms.TextBox();
            this.txtSabitTel = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMobilTelefon = new System.Windows.Forms.Label();
            this.lblSabitTel = new System.Windows.Forms.Label();
            this.grpVergiBilgileri = new System.Windows.Forms.GroupBox();
            this.txtVergiNumarası = new System.Windows.Forms.TextBox();
            this.txtVergiOfisi = new System.Windows.Forms.TextBox();
            this.lblVergiNumarasi = new System.Windows.Forms.Label();
            this.lblVergiOfisi = new System.Windows.Forms.Label();
            this.lblCariAdi = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCari)).BeginInit();
            this.grpCari.SuspendLayout();
            this.grpİletişimBilgileri.SuspendLayout();
            this.grpVergiBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCari
            // 
            this.dgvCari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCari.Location = new System.Drawing.Point(38, 29);
            this.dgvCari.Name = "dgvCari";
            this.dgvCari.RowHeadersWidth = 51;
            this.dgvCari.RowTemplate.Height = 24;
            this.dgvCari.Size = new System.Drawing.Size(921, 150);
            this.dgvCari.TabIndex = 0;
            this.dgvCari.SelectionChanged += new System.EventHandler(this.dgvCari_SelectionChanged);
            // 
            // btnDuzenleEkle
            // 
            this.btnDuzenleEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuzenleEkle.Location = new System.Drawing.Point(723, 221);
            this.btnDuzenleEkle.Name = "btnDuzenleEkle";
            this.btnDuzenleEkle.Size = new System.Drawing.Size(131, 27);
            this.btnDuzenleEkle.TabIndex = 1;
            this.btnDuzenleEkle.Text = "Duzenle/Ekle";
            this.btnDuzenleEkle.UseVisualStyleBackColor = true;
            this.btnDuzenleEkle.Click += new System.EventHandler(this.btnDuzenleEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(869, 221);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 27);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // grpCari
            // 
            this.grpCari.Controls.Add(this.btnKaydet);
            this.grpCari.Controls.Add(this.txtCariAdi);
            this.grpCari.Controls.Add(this.grpİletişimBilgileri);
            this.grpCari.Controls.Add(this.grpVergiBilgileri);
            this.grpCari.Controls.Add(this.lblCariAdi);
            this.grpCari.Location = new System.Drawing.Point(38, 288);
            this.grpCari.Name = "grpCari";
            this.grpCari.Size = new System.Drawing.Size(927, 338);
            this.grpCari.TabIndex = 3;
            this.grpCari.TabStop = false;
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Location = new System.Drawing.Point(106, 20);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(185, 22);
            this.txtCariAdi.TabIndex = 3;
            // 
            // grpİletişimBilgileri
            // 
            this.grpİletişimBilgileri.Controls.Add(this.rtxtAdres);
            this.grpİletişimBilgileri.Controls.Add(this.txtEmail);
            this.grpİletişimBilgileri.Controls.Add(this.txtMobilTel);
            this.grpİletişimBilgileri.Controls.Add(this.txtSabitTel);
            this.grpİletişimBilgileri.Controls.Add(this.lblAdres);
            this.grpİletişimBilgileri.Controls.Add(this.lblEmail);
            this.grpİletişimBilgileri.Controls.Add(this.lblMobilTelefon);
            this.grpİletişimBilgileri.Controls.Add(this.lblSabitTel);
            this.grpİletişimBilgileri.Location = new System.Drawing.Point(350, 128);
            this.grpİletişimBilgileri.Name = "grpİletişimBilgileri";
            this.grpİletişimBilgileri.Size = new System.Drawing.Size(513, 167);
            this.grpİletişimBilgileri.TabIndex = 2;
            this.grpİletişimBilgileri.TabStop = false;
            this.grpİletişimBilgileri.Text = "İletişim Bilgileri";
            // 
            // rtxtAdres
            // 
            this.rtxtAdres.Location = new System.Drawing.Point(317, 35);
            this.rtxtAdres.Name = "rtxtAdres";
            this.rtxtAdres.Size = new System.Drawing.Size(179, 115);
            this.rtxtAdres.TabIndex = 7;
            this.rtxtAdres.Text = "";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(127, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // txtMobilTel
            // 
            this.txtMobilTel.Location = new System.Drawing.Point(127, 71);
            this.txtMobilTel.Name = "txtMobilTel";
            this.txtMobilTel.Size = new System.Drawing.Size(100, 22);
            this.txtMobilTel.TabIndex = 5;
            this.txtMobilTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobilTel_KeyPress);
            this.txtMobilTel.Leave += new System.EventHandler(this.txtMobilTel_Leave);
            // 
            // txtSabitTel
            // 
            this.txtSabitTel.Location = new System.Drawing.Point(127, 37);
            this.txtSabitTel.Name = "txtSabitTel";
            this.txtSabitTel.Size = new System.Drawing.Size(100, 22);
            this.txtSabitTel.TabIndex = 4;
            this.txtSabitTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSabitTel_KeyPress);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(255, 38);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(46, 16);
            this.lblAdres.TabIndex = 3;
            this.lblAdres.Text = "Adres:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 102);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblMobilTelefon
            // 
            this.lblMobilTelefon.AutoSize = true;
            this.lblMobilTelefon.Location = new System.Drawing.Point(16, 74);
            this.lblMobilTelefon.Name = "lblMobilTelefon";
            this.lblMobilTelefon.Size = new System.Drawing.Size(92, 16);
            this.lblMobilTelefon.TabIndex = 1;
            this.lblMobilTelefon.Text = "Mobil Telefon:";
            // 
            // lblSabitTel
            // 
            this.lblSabitTel.AutoSize = true;
            this.lblSabitTel.Location = new System.Drawing.Point(16, 38);
            this.lblSabitTel.Name = "lblSabitTel";
            this.lblSabitTel.Size = new System.Drawing.Size(90, 16);
            this.lblSabitTel.TabIndex = 0;
            this.lblSabitTel.Text = "Sabit Telefon:";
            // 
            // grpVergiBilgileri
            // 
            this.grpVergiBilgileri.Controls.Add(this.txtVergiNumarası);
            this.grpVergiBilgileri.Controls.Add(this.txtVergiOfisi);
            this.grpVergiBilgileri.Controls.Add(this.lblVergiNumarasi);
            this.grpVergiBilgileri.Controls.Add(this.lblVergiOfisi);
            this.grpVergiBilgileri.Location = new System.Drawing.Point(21, 103);
            this.grpVergiBilgileri.Name = "grpVergiBilgileri";
            this.grpVergiBilgileri.Size = new System.Drawing.Size(305, 192);
            this.grpVergiBilgileri.TabIndex = 1;
            this.grpVergiBilgileri.TabStop = false;
            this.grpVergiBilgileri.Text = "Vergi Bilgileri";
            // 
            // txtVergiNumarası
            // 
            this.txtVergiNumarası.Location = new System.Drawing.Point(124, 121);
            this.txtVergiNumarası.Name = "txtVergiNumarası";
            this.txtVergiNumarası.Size = new System.Drawing.Size(100, 22);
            this.txtVergiNumarası.TabIndex = 3;
            // 
            // txtVergiOfisi
            // 
            this.txtVergiOfisi.Location = new System.Drawing.Point(124, 63);
            this.txtVergiOfisi.Name = "txtVergiOfisi";
            this.txtVergiOfisi.Size = new System.Drawing.Size(100, 22);
            this.txtVergiOfisi.TabIndex = 2;
            // 
            // lblVergiNumarasi
            // 
            this.lblVergiNumarasi.AutoSize = true;
            this.lblVergiNumarasi.Location = new System.Drawing.Point(15, 121);
            this.lblVergiNumarasi.Name = "lblVergiNumarasi";
            this.lblVergiNumarasi.Size = new System.Drawing.Size(103, 16);
            this.lblVergiNumarasi.TabIndex = 1;
            this.lblVergiNumarasi.Text = "Vergi Numarası:";
            // 
            // lblVergiOfisi
            // 
            this.lblVergiOfisi.AutoSize = true;
            this.lblVergiOfisi.Location = new System.Drawing.Point(15, 69);
            this.lblVergiOfisi.Name = "lblVergiOfisi";
            this.lblVergiOfisi.Size = new System.Drawing.Size(71, 16);
            this.lblVergiOfisi.TabIndex = 0;
            this.lblVergiOfisi.Text = "Vergi Ofisi:";
            // 
            // lblCariAdi
            // 
            this.lblCariAdi.AutoSize = true;
            this.lblCariAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCariAdi.Location = new System.Drawing.Point(26, 22);
            this.lblCariAdi.Name = "lblCariAdi";
            this.lblCariAdi.Size = new System.Drawing.Size(74, 20);
            this.lblCariAdi.TabIndex = 0;
            this.lblCariAdi.Text = "Cari Adı:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(778, 301);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(128, 31);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // musteriCariYönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 659);
            this.Controls.Add(this.grpCari);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenleEkle);
            this.Controls.Add(this.dgvCari);
            this.Name = "musteriCariYönetimi";
            this.Text = "Müşteri Cari Yönetimi";
            this.Load += new System.EventHandler(this.musteriCariYönetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCari)).EndInit();
            this.grpCari.ResumeLayout(false);
            this.grpCari.PerformLayout();
            this.grpİletişimBilgileri.ResumeLayout(false);
            this.grpİletişimBilgileri.PerformLayout();
            this.grpVergiBilgileri.ResumeLayout(false);
            this.grpVergiBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCari;
        private System.Windows.Forms.Button btnDuzenleEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox grpCari;
        private System.Windows.Forms.GroupBox grpİletişimBilgileri;
        private System.Windows.Forms.GroupBox grpVergiBilgileri;
        private System.Windows.Forms.Label lblVergiNumarasi;
        private System.Windows.Forms.Label lblVergiOfisi;
        private System.Windows.Forms.Label lblCariAdi;
        private System.Windows.Forms.TextBox txtVergiNumarası;
        private System.Windows.Forms.TextBox txtVergiOfisi;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobilTelefon;
        private System.Windows.Forms.Label lblSabitTel;
        private System.Windows.Forms.RichTextBox rtxtAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobilTel;
        private System.Windows.Forms.TextBox txtSabitTel;
        private System.Windows.Forms.TextBox txtCariAdi;
        private System.Windows.Forms.Button btnKaydet;
    }
}