namespace faturalama
{
    partial class musteriFormu
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
            this.grpFiltre = new System.Windows.Forms.GroupBox();
            this.txtFiltre = new System.Windows.Forms.TextBox();
            this.cmbFiltrelenecekAlan = new System.Windows.Forms.ComboBox();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.lblFiltrelenecekAlan = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDetay = new System.Windows.Forms.Button();
            this.dgvMusteriFormu = new System.Windows.Forms.DataGridView();
            this.grpFiltre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriFormu)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiltre
            // 
            this.grpFiltre.Controls.Add(this.txtFiltre);
            this.grpFiltre.Controls.Add(this.cmbFiltrelenecekAlan);
            this.grpFiltre.Controls.Add(this.lblFiltre);
            this.grpFiltre.Controls.Add(this.lblFiltrelenecekAlan);
            this.grpFiltre.Location = new System.Drawing.Point(41, 34);
            this.grpFiltre.Name = "grpFiltre";
            this.grpFiltre.Size = new System.Drawing.Size(346, 140);
            this.grpFiltre.TabIndex = 0;
            this.grpFiltre.TabStop = false;
            // 
            // txtFiltre
            // 
            this.txtFiltre.Location = new System.Drawing.Point(142, 74);
            this.txtFiltre.Name = "txtFiltre";
            this.txtFiltre.Size = new System.Drawing.Size(167, 22);
            this.txtFiltre.TabIndex = 3;
            // 
            // cmbFiltrelenecekAlan
            // 
            this.cmbFiltrelenecekAlan.FormattingEnabled = true;
            this.cmbFiltrelenecekAlan.Location = new System.Drawing.Point(142, 24);
            this.cmbFiltrelenecekAlan.Name = "cmbFiltrelenecekAlan";
            this.cmbFiltrelenecekAlan.Size = new System.Drawing.Size(167, 24);
            this.cmbFiltrelenecekAlan.TabIndex = 2;
            // 
            // lblFiltre
            // 
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.Location = new System.Drawing.Point(22, 81);
            this.lblFiltre.Name = "lblFiltre";
            this.lblFiltre.Size = new System.Drawing.Size(39, 16);
            this.lblFiltre.TabIndex = 1;
            this.lblFiltre.Text = "Filtre:";
            // 
            // lblFiltrelenecekAlan
            // 
            this.lblFiltrelenecekAlan.AutoSize = true;
            this.lblFiltrelenecekAlan.Location = new System.Drawing.Point(19, 32);
            this.lblFiltrelenecekAlan.Name = "lblFiltrelenecekAlan";
            this.lblFiltrelenecekAlan.Size = new System.Drawing.Size(117, 16);
            this.lblFiltrelenecekAlan.TabIndex = 0;
            this.lblFiltrelenecekAlan.Text = "Filtrelenecek Alan:";
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(426, 184);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(103, 28);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(547, 184);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(103, 28);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(426, 387);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 28);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDetay
            // 
            this.btnDetay.Enabled = false;
            this.btnDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetay.Location = new System.Drawing.Point(547, 387);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(103, 28);
            this.btnDetay.TabIndex = 4;
            this.btnDetay.Text = "Detay";
            this.btnDetay.UseVisualStyleBackColor = true;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // dgvMusteriFormu
            // 
            this.dgvMusteriFormu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriFormu.Location = new System.Drawing.Point(27, 239);
            this.dgvMusteriFormu.Name = "dgvMusteriFormu";
            this.dgvMusteriFormu.RowHeadersWidth = 51;
            this.dgvMusteriFormu.RowTemplate.Height = 24;
            this.dgvMusteriFormu.Size = new System.Drawing.Size(633, 137);
            this.dgvMusteriFormu.TabIndex = 5;
            this.dgvMusteriFormu.SelectionChanged += new System.EventHandler(this.dgvMusteriFormu_SelectionChanged);
            // 
            // musteriFormu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMusteriFormu);
            this.Controls.Add(this.btnDetay);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.grpFiltre);
            this.Name = "musteriFormu";
            this.Text = "Müşteri Formu";
            this.Load += new System.EventHandler(this.musteriFormu_Load);
            this.grpFiltre.ResumeLayout(false);
            this.grpFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriFormu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltre;
        private System.Windows.Forms.Label lblFiltre;
        private System.Windows.Forms.Label lblFiltrelenecekAlan;
        private System.Windows.Forms.ComboBox cmbFiltrelenecekAlan;
        private System.Windows.Forms.TextBox txtFiltre;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDetay;
        private System.Windows.Forms.DataGridView dgvMusteriFormu;
    }
}