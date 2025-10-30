namespace faturalama
{
    partial class musteriEklemeFormu
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
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.lblMusteriKodu = new System.Windows.Forms.Label();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.txtMusteriKodu = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusteriAdi.Location = new System.Drawing.Point(41, 57);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(99, 20);
            this.lblMusteriAdi.TabIndex = 0;
            this.lblMusteriAdi.Text = "Müşteri Adı:";
            // 
            // lblMusteriKodu
            // 
            this.lblMusteriKodu.AutoSize = true;
            this.lblMusteriKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusteriKodu.Location = new System.Drawing.Point(41, 111);
            this.lblMusteriKodu.Name = "lblMusteriKodu";
            this.lblMusteriKodu.Size = new System.Drawing.Size(113, 20);
            this.lblMusteriKodu.TabIndex = 1;
            this.lblMusteriKodu.Text = "Müşteri Kodu:";
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMusteriAdi.Location = new System.Drawing.Point(178, 54);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(150, 27);
            this.txtMusteriAdi.TabIndex = 2;
            // 
            // txtMusteriKodu
            // 
            this.txtMusteriKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMusteriKodu.Location = new System.Drawing.Point(178, 104);
            this.txtMusteriKodu.Name = "txtMusteriKodu";
            this.txtMusteriKodu.Size = new System.Drawing.Size(150, 27);
            this.txtMusteriKodu.TabIndex = 3;
            this.txtMusteriKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriKodu_KeyPress);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(316, 163);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 30);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // musteriEklemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 225);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMusteriKodu);
            this.Controls.Add(this.txtMusteriAdi);
            this.Controls.Add(this.lblMusteriKodu);
            this.Controls.Add(this.lblMusteriAdi);
            this.Name = "musteriEklemeFormu";
            this.Text = "Müşteri Ekleme Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.Label lblMusteriKodu;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.TextBox txtMusteriKodu;
        private System.Windows.Forms.Button btnKaydet;
    }
}