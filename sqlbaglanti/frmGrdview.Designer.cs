
namespace sqlbaglanti
{
    partial class frmGrdview
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
            this.grdVeri = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeTarihBitiş = new System.Windows.Forms.DateTimePicker();
            this.labelBitTarih = new System.Windows.Forms.Label();
            this.button_Getir = new System.Windows.Forms.Button();
            this.comboBoxFaturaTip = new System.Windows.Forms.ComboBox();
            this.dateTimeTarih = new System.Windows.Forms.DateTimePicker();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Güncelle = new System.Windows.Forms.Button();
            this.label_FaturaTip = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label_Tutar = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label_Fiyat = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label_Miktar = new System.Windows.Forms.Label();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.label_UrunAd = new System.Windows.Forms.Label();
            this.labelBaşTarih = new System.Windows.Forms.Label();
            this.txtKasiyerAd = new System.Windows.Forms.TextBox();
            this.label_KasiyerAd = new System.Windows.Forms.Label();
            this.button_Excel = new System.Windows.Forms.Button();
            this.button_Excel_Oku = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grdVeri)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdVeri
            // 
            this.grdVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVeri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdVeri.Location = new System.Drawing.Point(0, 261);
            this.grdVeri.Name = "grdVeri";
            this.grdVeri.RowHeadersWidth = 51;
            this.grdVeri.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Transparent;
            this.grdVeri.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.grdVeri.RowTemplate.Height = 24;
            this.grdVeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVeri.Size = new System.Drawing.Size(1369, 206);
            this.grdVeri.TabIndex = 0;
            this.grdVeri.DoubleClick += new System.EventHandler(this.grdVeri_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Excel_Oku);
            this.groupBox1.Controls.Add(this.button_Excel);
            this.groupBox1.Controls.Add(this.dateTimeTarihBitiş);
            this.groupBox1.Controls.Add(this.labelBitTarih);
            this.groupBox1.Controls.Add(this.button_Getir);
            this.groupBox1.Controls.Add(this.comboBoxFaturaTip);
            this.groupBox1.Controls.Add(this.dateTimeTarih);
            this.groupBox1.Controls.Add(this.button_Ekle);
            this.groupBox1.Controls.Add(this.button_Sil);
            this.groupBox1.Controls.Add(this.button_Güncelle);
            this.groupBox1.Controls.Add(this.label_FaturaTip);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.label_Tutar);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.label_Fiyat);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.label_Miktar);
            this.groupBox1.Controls.Add(this.txtUrunAd);
            this.groupBox1.Controls.Add(this.label_UrunAd);
            this.groupBox1.Controls.Add(this.labelBaşTarih);
            this.groupBox1.Controls.Add(this.txtKasiyerAd);
            this.groupBox1.Controls.Add(this.label_KasiyerAd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1369, 467);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dateTimeTarihBitiş
            // 
            this.dateTimeTarihBitiş.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateTimeTarihBitiş.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTarihBitiş.Location = new System.Drawing.Point(174, 143);
            this.dateTimeTarihBitiş.Name = "dateTimeTarihBitiş";
            this.dateTimeTarihBitiş.Size = new System.Drawing.Size(205, 38);
            this.dateTimeTarihBitiş.TabIndex = 36;
            // 
            // labelBitTarih
            // 
            this.labelBitTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelBitTarih.Location = new System.Drawing.Point(6, 143);
            this.labelBitTarih.Name = "labelBitTarih";
            this.labelBitTarih.Size = new System.Drawing.Size(162, 31);
            this.labelBitTarih.TabIndex = 35;
            this.labelBitTarih.Text = "Bitiş Tarih :";
            this.labelBitTarih.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button_Getir
            // 
            this.button_Getir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_Getir.Location = new System.Drawing.Point(726, 95);
            this.button_Getir.Name = "button_Getir";
            this.button_Getir.Size = new System.Drawing.Size(147, 39);
            this.button_Getir.TabIndex = 34;
            this.button_Getir.Text = "Getir";
            this.button_Getir.UseVisualStyleBackColor = true;
            this.button_Getir.Click += new System.EventHandler(this.button_Getir_Click);
            // 
            // comboBoxFaturaTip
            // 
            this.comboBoxFaturaTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxFaturaTip.FormattingEnabled = true;
            this.comboBoxFaturaTip.Items.AddRange(new object[] {
            "ALIŞ FATURASI",
            "SATIŞ FATURASI"});
            this.comboBoxFaturaTip.Location = new System.Drawing.Point(892, 28);
            this.comboBoxFaturaTip.Name = "comboBoxFaturaTip";
            this.comboBoxFaturaTip.Size = new System.Drawing.Size(205, 33);
            this.comboBoxFaturaTip.TabIndex = 33;
            // 
            // dateTimeTarih
            // 
            this.dateTimeTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateTimeTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTarih.Location = new System.Drawing.Point(174, 86);
            this.dateTimeTarih.Name = "dateTimeTarih";
            this.dateTimeTarih.Size = new System.Drawing.Size(205, 38);
            this.dateTimeTarih.TabIndex = 32;
            // 
            // button_Ekle
            // 
            this.button_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_Ekle.Location = new System.Drawing.Point(879, 155);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(147, 39);
            this.button_Ekle.TabIndex = 31;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.UseVisualStyleBackColor = true;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_Sil.Location = new System.Drawing.Point(1032, 155);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(147, 39);
            this.button_Sil.TabIndex = 30;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = true;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_Güncelle
            // 
            this.button_Güncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_Güncelle.Location = new System.Drawing.Point(726, 155);
            this.button_Güncelle.Name = "button_Güncelle";
            this.button_Güncelle.Size = new System.Drawing.Size(147, 39);
            this.button_Güncelle.TabIndex = 29;
            this.button_Güncelle.Text = "Güncelle";
            this.button_Güncelle.UseVisualStyleBackColor = true;
            this.button_Güncelle.Click += new System.EventHandler(this.button_Güncelle_Click);
            // 
            // label_FaturaTip
            // 
            this.label_FaturaTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_FaturaTip.Location = new System.Drawing.Point(717, 31);
            this.label_FaturaTip.Name = "label_FaturaTip";
            this.label_FaturaTip.Size = new System.Drawing.Size(156, 31);
            this.label_FaturaTip.TabIndex = 27;
            this.label_FaturaTip.Text = "Fatura Tip :";
            this.label_FaturaTip.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtTutar.Location = new System.Drawing.Point(529, 152);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(182, 38);
            this.txtTutar.TabIndex = 26;
            // 
            // label_Tutar
            // 
            this.label_Tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_Tutar.Location = new System.Drawing.Point(397, 152);
            this.label_Tutar.Name = "label_Tutar";
            this.label_Tutar.Size = new System.Drawing.Size(109, 31);
            this.label_Tutar.TabIndex = 25;
            this.label_Tutar.Text = "Tutar :";
            this.label_Tutar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtFiyat.Location = new System.Drawing.Point(529, 89);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(182, 38);
            this.txtFiyat.TabIndex = 24;
            // 
            // label_Fiyat
            // 
            this.label_Fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_Fiyat.Location = new System.Drawing.Point(402, 92);
            this.label_Fiyat.Name = "label_Fiyat";
            this.label_Fiyat.Size = new System.Drawing.Size(104, 31);
            this.label_Fiyat.TabIndex = 23;
            this.label_Fiyat.Text = "Fiyat :";
            this.label_Fiyat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtMiktar.Location = new System.Drawing.Point(529, 31);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(182, 38);
            this.txtMiktar.TabIndex = 22;
            // 
            // label_Miktar
            // 
            this.label_Miktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_Miktar.Location = new System.Drawing.Point(408, 31);
            this.label_Miktar.Name = "label_Miktar";
            this.label_Miktar.Size = new System.Drawing.Size(98, 31);
            this.label_Miktar.TabIndex = 21;
            this.label_Miktar.Text = "Miktar :";
            this.label_Miktar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtUrunAd.Location = new System.Drawing.Point(174, 194);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(205, 38);
            this.txtUrunAd.TabIndex = 20;
            // 
            // label_UrunAd
            // 
            this.label_UrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_UrunAd.Location = new System.Drawing.Point(6, 197);
            this.label_UrunAd.Name = "label_UrunAd";
            this.label_UrunAd.Size = new System.Drawing.Size(162, 31);
            this.label_UrunAd.TabIndex = 19;
            this.label_UrunAd.Text = "Ürün Ad :";
            this.label_UrunAd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelBaşTarih
            // 
            this.labelBaşTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelBaşTarih.Location = new System.Drawing.Point(6, 93);
            this.labelBaşTarih.Name = "labelBaşTarih";
            this.labelBaşTarih.Size = new System.Drawing.Size(162, 31);
            this.labelBaşTarih.TabIndex = 17;
            this.labelBaşTarih.Text = "Başlangıç Tarih :";
            this.labelBaşTarih.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtKasiyerAd
            // 
            this.txtKasiyerAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtKasiyerAd.Location = new System.Drawing.Point(174, 31);
            this.txtKasiyerAd.Name = "txtKasiyerAd";
            this.txtKasiyerAd.Size = new System.Drawing.Size(205, 38);
            this.txtKasiyerAd.TabIndex = 16;
            // 
            // label_KasiyerAd
            // 
            this.label_KasiyerAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_KasiyerAd.Location = new System.Drawing.Point(6, 31);
            this.label_KasiyerAd.Name = "label_KasiyerAd";
            this.label_KasiyerAd.Size = new System.Drawing.Size(162, 31);
            this.label_KasiyerAd.TabIndex = 15;
            this.label_KasiyerAd.Text = "Kasiyer Ad :";
            this.label_KasiyerAd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button_Excel
            // 
            this.button_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_Excel.Location = new System.Drawing.Point(879, 95);
            this.button_Excel.Name = "button_Excel";
            this.button_Excel.Size = new System.Drawing.Size(147, 39);
            this.button_Excel.TabIndex = 37;
            this.button_Excel.Text = "Excel";
            this.button_Excel.UseVisualStyleBackColor = true;
            this.button_Excel.Click += new System.EventHandler(this.button_Excel_Click);
            // 
            // button_Excel_Oku
            // 
            this.button_Excel_Oku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_Excel_Oku.Location = new System.Drawing.Point(1032, 95);
            this.button_Excel_Oku.Name = "button_Excel_Oku";
            this.button_Excel_Oku.Size = new System.Drawing.Size(147, 39);
            this.button_Excel_Oku.TabIndex = 38;
            this.button_Excel_Oku.Text = "Excel Oku";
            this.button_Excel_Oku.UseVisualStyleBackColor = true;
            this.button_Excel_Oku.Click += new System.EventHandler(this.button_Excel_Oku_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmGrdview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 467);
            this.Controls.Add(this.grdVeri);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGrdview";
            this.Text = "frmGrdview";
            this.Load += new System.EventHandler(this.frmGrdview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdVeri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdVeri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_KasiyerAd;
        private System.Windows.Forms.Label label_FaturaTip;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label_Tutar;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label_Fiyat;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label_Miktar;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Label label_UrunAd;
        private System.Windows.Forms.Label labelBaşTarih;
        private System.Windows.Forms.TextBox txtKasiyerAd;
        private System.Windows.Forms.Button button_Güncelle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.DateTimePicker dateTimeTarih;
        private System.Windows.Forms.ComboBox comboBoxFaturaTip;
        private System.Windows.Forms.Button button_Getir;
        private System.Windows.Forms.Label labelBitTarih;
        private System.Windows.Forms.DateTimePicker dateTimeTarihBitiş;
        private System.Windows.Forms.Button button_Excel;
        private System.Windows.Forms.Button button_Excel_Oku;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}