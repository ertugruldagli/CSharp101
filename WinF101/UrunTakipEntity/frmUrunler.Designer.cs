namespace UrunTakipEntity
{
    partial class frmUrunler
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
            this.dgridUrunler = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxStok = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.tBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridUrunler
            // 
            this.dgridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridUrunler.Location = new System.Drawing.Point(12, 12);
            this.dgridUrunler.Name = "dgridUrunler";
            this.dgridUrunler.Size = new System.Drawing.Size(591, 321);
            this.dgridUrunler.TabIndex = 1;
            this.dgridUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridUrunler_CellClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(628, 303);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(150, 23);
            this.btnGuncelle.TabIndex = 28;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(628, 274);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(150, 23);
            this.btnsil.TabIndex = 27;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(628, 245);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 23);
            this.btnKaydet.TabIndex = 26;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Category: ";
            // 
            // tBoxFiyat
            // 
            this.tBoxFiyat.Location = new System.Drawing.Point(678, 95);
            this.tBoxFiyat.Name = "tBoxFiyat";
            this.tBoxFiyat.Size = new System.Drawing.Size(100, 20);
            this.tBoxFiyat.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Satis Fiyati: ";
            // 
            // tBoxStok
            // 
            this.tBoxStok.Location = new System.Drawing.Point(678, 69);
            this.tBoxStok.Name = "tBoxStok";
            this.tBoxStok.Size = new System.Drawing.Size(100, 20);
            this.tBoxStok.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Stok:";
            // 
            // tBoxAd
            // 
            this.tBoxAd.Location = new System.Drawing.Point(678, 43);
            this.tBoxAd.Name = "tBoxAd";
            this.tBoxAd.Size = new System.Drawing.Size(100, 20);
            this.tBoxAd.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Urun Ad: ";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(628, 216);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(150, 23);
            this.btnListele.TabIndex = 17;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // tBoxId
            // 
            this.tBoxId.Location = new System.Drawing.Point(678, 17);
            this.tBoxId.Name = "tBoxId";
            this.tBoxId.Size = new System.Drawing.Size(100, 20);
            this.tBoxId.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID: ";
            // 
            // cBoxCategory
            // 
            this.cBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCategory.FormattingEnabled = true;
            this.cBoxCategory.Location = new System.Drawing.Point(678, 125);
            this.cBoxCategory.Name = "cBoxCategory";
            this.cBoxCategory.Size = new System.Drawing.Size(100, 21);
            this.cBoxCategory.TabIndex = 29;
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 356);
            this.Controls.Add(this.cBoxCategory);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBoxFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBoxStok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.tBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgridUrunler);
            this.Name = "frmUrunler";
            this.Text = "frmUrunler";
            this.Load += new System.EventHandler(this.frmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridUrunler;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxStok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox tBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxCategory;
    }
}