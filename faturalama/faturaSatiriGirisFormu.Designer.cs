namespace faturalama
{
    partial class faturaSatiriGirisFormu
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
            this.grpFaturaSatiri = new System.Windows.Forms.GroupBox();
            this.txtTutarTL = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.cmbKdvOrani = new System.Windows.Forms.ComboBox();
            this.txtİrsaliye = new System.Windows.Forms.TextBox();
            this.txtDövizTutar = new System.Windows.Forms.TextBox();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.txtDövizKuru = new System.Windows.Forms.TextBox();
            this.cmbDövizTürü = new System.Windows.Forms.ComboBox();
            this.chkDövizliFatura = new System.Windows.Forms.CheckBox();
            this.txtAçıklama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.grpFaturaSatiri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFaturaSatiri
            // 
            this.grpFaturaSatiri.Controls.Add(this.txtTutarTL);
            this.grpFaturaSatiri.Controls.Add(this.lblTutar);
            this.grpFaturaSatiri.Controls.Add(this.cmbKdvOrani);
            this.grpFaturaSatiri.Controls.Add(this.txtİrsaliye);
            this.grpFaturaSatiri.Controls.Add(this.txtDövizTutar);
            this.grpFaturaSatiri.Controls.Add(this.nmrAdet);
            this.grpFaturaSatiri.Controls.Add(this.txtDövizKuru);
            this.grpFaturaSatiri.Controls.Add(this.cmbDövizTürü);
            this.grpFaturaSatiri.Controls.Add(this.chkDövizliFatura);
            this.grpFaturaSatiri.Controls.Add(this.txtAçıklama);
            this.grpFaturaSatiri.Controls.Add(this.label8);
            this.grpFaturaSatiri.Controls.Add(this.label7);
            this.grpFaturaSatiri.Controls.Add(this.label6);
            this.grpFaturaSatiri.Controls.Add(this.label5);
            this.grpFaturaSatiri.Controls.Add(this.label4);
            this.grpFaturaSatiri.Controls.Add(this.label3);
            this.grpFaturaSatiri.Controls.Add(this.label2);
            this.grpFaturaSatiri.Controls.Add(this.label1);
            this.grpFaturaSatiri.Location = new System.Drawing.Point(34, 36);
            this.grpFaturaSatiri.Name = "grpFaturaSatiri";
            this.grpFaturaSatiri.Size = new System.Drawing.Size(803, 397);
            this.grpFaturaSatiri.TabIndex = 0;
            this.grpFaturaSatiri.TabStop = false;
            this.grpFaturaSatiri.Text = "Fatura Satırı";
            // 
            // txtTutarTL
            // 
            this.txtTutarTL.Location = new System.Drawing.Point(139, 235);
            this.txtTutarTL.Name = "txtTutarTL";
            this.txtTutarTL.Size = new System.Drawing.Size(119, 22);
            this.txtTutarTL.TabIndex = 18;
            this.txtTutarTL.TextChanged += new System.EventHandler(this.txtTutarTL_TextChanged);
            this.txtTutarTL.Validating += new System.ComponentModel.CancelEventHandler(this.txtTutarTL_Validating);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(36, 235);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(41, 16);
            this.lblTutar.TabIndex = 17;
            this.lblTutar.Text = "Tutar:";
            // 
            // cmbKdvOrani
            // 
            this.cmbKdvOrani.FormattingEnabled = true;
            this.cmbKdvOrani.Items.AddRange(new object[] {
            "0",
            "8",
            "10",
            "20"});
            this.cmbKdvOrani.Location = new System.Drawing.Point(138, 272);
            this.cmbKdvOrani.Name = "cmbKdvOrani";
            this.cmbKdvOrani.Size = new System.Drawing.Size(121, 24);
            this.cmbKdvOrani.TabIndex = 16;
            // 
            // txtİrsaliye
            // 
            this.txtİrsaliye.Location = new System.Drawing.Point(139, 355);
            this.txtİrsaliye.Name = "txtİrsaliye";
            this.txtİrsaliye.Size = new System.Drawing.Size(100, 22);
            this.txtİrsaliye.TabIndex = 15;
            this.txtİrsaliye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtİrsaliye_KeyPress);
            // 
            // txtDövizTutar
            // 
            this.txtDövizTutar.Enabled = false;
            this.txtDövizTutar.Location = new System.Drawing.Point(138, 200);
            this.txtDövizTutar.Name = "txtDövizTutar";
            this.txtDövizTutar.Size = new System.Drawing.Size(120, 22);
            this.txtDövizTutar.TabIndex = 13;
            this.txtDövizTutar.Text = "0.00";
            this.txtDövizTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDövizTutar.TextChanged += new System.EventHandler(this.txtDövizTutar_TextChanged);
            this.txtDövizTutar.Validating += new System.ComponentModel.CancelEventHandler(this.txtDövizTutar_Validating);
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(138, 168);
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(120, 22);
            this.nmrAdet.TabIndex = 12;
            this.nmrAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.ValueChanged += new System.EventHandler(this.nmrAdet_ValueChanged);
            // 
            // txtDövizKuru
            // 
            this.txtDövizKuru.Enabled = false;
            this.txtDövizKuru.Location = new System.Drawing.Point(138, 132);
            this.txtDövizKuru.Name = "txtDövizKuru";
            this.txtDövizKuru.Size = new System.Drawing.Size(100, 22);
            this.txtDövizKuru.TabIndex = 11;
            this.txtDövizKuru.Text = "0";
            this.txtDövizKuru.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDövizKuru.TextChanged += new System.EventHandler(this.txtDövizKuru_TextChanged);
            this.txtDövizKuru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDövizKuru_KeyPress);
            this.txtDövizKuru.Leave += new System.EventHandler(this.txtDövizKuru_Leave);
            this.txtDövizKuru.Validating += new System.ComponentModel.CancelEventHandler(this.txtDövizKuru_Validating);
            // 
            // cmbDövizTürü
            // 
            this.cmbDövizTürü.Enabled = false;
            this.cmbDövizTürü.FormattingEnabled = true;
            this.cmbDövizTürü.Location = new System.Drawing.Point(138, 96);
            this.cmbDövizTürü.Name = "cmbDövizTürü";
            this.cmbDövizTürü.Size = new System.Drawing.Size(121, 24);
            this.cmbDövizTürü.TabIndex = 10;
            // 
            // chkDövizliFatura
            // 
            this.chkDövizliFatura.AutoSize = true;
            this.chkDövizliFatura.Location = new System.Drawing.Point(139, 65);
            this.chkDövizliFatura.Name = "chkDövizliFatura";
            this.chkDövizliFatura.Size = new System.Drawing.Size(65, 20);
            this.chkDövizliFatura.TabIndex = 9;
            this.chkDövizliFatura.Text = "EVET";
            this.chkDövizliFatura.UseVisualStyleBackColor = true;
            this.chkDövizliFatura.CheckedChanged += new System.EventHandler(this.chkDövizliFatura_CheckedChanged);
            // 
            // txtAçıklama
            // 
            this.txtAçıklama.Location = new System.Drawing.Point(139, 37);
            this.txtAçıklama.Name = "txtAçıklama";
            this.txtAçıklama.Size = new System.Drawing.Size(411, 22);
            this.txtAçıklama.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "İrsaliye:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kdv Oranı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dövizli Tutar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Döviz Kuru";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Döviz Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dövizli Fatura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Açıklama:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(677, 449);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(102, 34);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(792, 449);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(102, 34);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // faturaSatiriGirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 491);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpFaturaSatiri);
            this.Name = "faturaSatiriGirisFormu";
            this.Text = "Fatura Satir iGiris Formu";
            this.Load += new System.EventHandler(this.faturaSatiriGirisFormu_Load);
            this.grpFaturaSatiri.ResumeLayout(false);
            this.grpFaturaSatiri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFaturaSatiri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtİrsaliye;
        private System.Windows.Forms.TextBox txtDövizTutar;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.TextBox txtDövizKuru;
        private System.Windows.Forms.ComboBox cmbDövizTürü;
        private System.Windows.Forms.CheckBox chkDövizliFatura;
        private System.Windows.Forms.TextBox txtAçıklama;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.ComboBox cmbKdvOrani;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtTutarTL;
    }
}