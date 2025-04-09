
namespace sqlbaglanti
{
    partial class formKasiyer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKasiyerParola = new System.Windows.Forms.TextBox();
            this.label_KasiyerParola = new System.Windows.Forms.Label();
            this.txtKasiyerAd = new System.Windows.Forms.TextBox();
            this.txtKasiyerNo = new System.Windows.Forms.TextBox();
            this.label_KasiyerId = new System.Windows.Forms.Label();
            this.label_KasiyerAd = new System.Windows.Forms.Label();
            this.lstKasiyer = new System.Windows.Forms.ListBox();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Güncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKasiyerParola);
            this.groupBox1.Controls.Add(this.label_KasiyerParola);
            this.groupBox1.Controls.Add(this.txtKasiyerAd);
            this.groupBox1.Controls.Add(this.txtKasiyerNo);
            this.groupBox1.Controls.Add(this.label_KasiyerId);
            this.groupBox1.Controls.Add(this.label_KasiyerAd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtKasiyerParola
            // 
            this.txtKasiyerParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtKasiyerParola.Location = new System.Drawing.Point(224, 153);
            this.txtKasiyerParola.Name = "txtKasiyerParola";
            this.txtKasiyerParola.Size = new System.Drawing.Size(261, 38);
            this.txtKasiyerParola.TabIndex = 16;
            // 
            // label_KasiyerParola
            // 
            this.label_KasiyerParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_KasiyerParola.Location = new System.Drawing.Point(6, 160);
            this.label_KasiyerParola.Name = "label_KasiyerParola";
            this.label_KasiyerParola.Size = new System.Drawing.Size(212, 31);
            this.label_KasiyerParola.TabIndex = 15;
            this.label_KasiyerParola.Text = "Kasiyer Parola : ";
            this.label_KasiyerParola.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtKasiyerAd
            // 
            this.txtKasiyerAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtKasiyerAd.Location = new System.Drawing.Point(224, 97);
            this.txtKasiyerAd.Name = "txtKasiyerAd";
            this.txtKasiyerAd.Size = new System.Drawing.Size(261, 38);
            this.txtKasiyerAd.TabIndex = 14;
            // 
            // txtKasiyerNo
            // 
            this.txtKasiyerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtKasiyerNo.Location = new System.Drawing.Point(224, 36);
            this.txtKasiyerNo.Name = "txtKasiyerNo";
            this.txtKasiyerNo.Size = new System.Drawing.Size(261, 38);
            this.txtKasiyerNo.TabIndex = 13;
            // 
            // label_KasiyerId
            // 
            this.label_KasiyerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_KasiyerId.Location = new System.Drawing.Point(22, 39);
            this.label_KasiyerId.Name = "label_KasiyerId";
            this.label_KasiyerId.Size = new System.Drawing.Size(196, 38);
            this.label_KasiyerId.TabIndex = 11;
            this.label_KasiyerId.Text = "Kasiyer No : ";
            this.label_KasiyerId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_KasiyerAd
            // 
            this.label_KasiyerAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_KasiyerAd.Location = new System.Drawing.Point(6, 104);
            this.label_KasiyerAd.Name = "label_KasiyerAd";
            this.label_KasiyerAd.Size = new System.Drawing.Size(206, 31);
            this.label_KasiyerAd.TabIndex = 11;
            this.label_KasiyerAd.Text = "Kasiyer Ad :";
            this.label_KasiyerAd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lstKasiyer
            // 
            this.lstKasiyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lstKasiyer.FormattingEnabled = true;
            this.lstKasiyer.ItemHeight = 31;
            this.lstKasiyer.Location = new System.Drawing.Point(10, 264);
            this.lstKasiyer.Name = "lstKasiyer";
            this.lstKasiyer.Size = new System.Drawing.Size(475, 190);
            this.lstKasiyer.TabIndex = 1;
            this.lstKasiyer.DoubleClick += new System.EventHandler(this.lstKasiyer_DoubleClick);
            // 
            // button_Ekle
            // 
            this.button_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_Ekle.Location = new System.Drawing.Point(316, 219);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(147, 39);
            this.button_Ekle.TabIndex = 20;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.UseVisualStyleBackColor = true;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_Sil.Location = new System.Drawing.Point(163, 219);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(147, 39);
            this.button_Sil.TabIndex = 19;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = true;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_Güncelle
            // 
            this.button_Güncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_Güncelle.Location = new System.Drawing.Point(10, 219);
            this.button_Güncelle.Name = "button_Güncelle";
            this.button_Güncelle.Size = new System.Drawing.Size(147, 39);
            this.button_Güncelle.TabIndex = 18;
            this.button_Güncelle.Text = "Güncelle";
            this.button_Güncelle.UseVisualStyleBackColor = true;
            this.button_Güncelle.Click += new System.EventHandler(this.button_Güncelle_Click);
            // 
            // formKasiyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 455);
            this.Controls.Add(this.button_Ekle);
            this.Controls.Add(this.button_Sil);
            this.Controls.Add(this.button_Güncelle);
            this.Controls.Add(this.lstKasiyer);
            this.Controls.Add(this.groupBox1);
            this.Name = "formKasiyer";
            this.Text = "Kasiyer";
            this.Load += new System.EventHandler(this.formKasiyer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKasiyerParola;
        private System.Windows.Forms.Label label_KasiyerParola;
        private System.Windows.Forms.TextBox txtKasiyerAd;
        private System.Windows.Forms.TextBox txtKasiyerNo;
        private System.Windows.Forms.Label label_KasiyerId;
        private System.Windows.Forms.Label label_KasiyerAd;
        private System.Windows.Forms.ListBox lstKasiyer;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Güncelle;
    }
}