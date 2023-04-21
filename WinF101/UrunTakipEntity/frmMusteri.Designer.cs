namespace UrunTakipEntity
{
    partial class frmMusteri
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
            this.dgridMusteri = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxId = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.tBoxAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxSehir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxBakiye = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgridMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridMusteri
            // 
            this.dgridMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridMusteri.Location = new System.Drawing.Point(12, 27);
            this.dgridMusteri.Name = "dgridMusteri";
            this.dgridMusteri.Size = new System.Drawing.Size(541, 321);
            this.dgridMusteri.TabIndex = 0;
            this.dgridMusteri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridMusteri_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID: ";
            // 
            // tBoxId
            // 
            this.tBoxId.Location = new System.Drawing.Point(628, 39);
            this.tBoxId.Name = "tBoxId";
            this.tBoxId.Size = new System.Drawing.Size(100, 20);
            this.tBoxId.TabIndex = 2;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(578, 189);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(150, 23);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // tBoxAd
            // 
            this.tBoxAd.Location = new System.Drawing.Point(628, 65);
            this.tBoxAd.Name = "tBoxAd";
            this.tBoxAd.Size = new System.Drawing.Size(100, 20);
            this.tBoxAd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad: ";
            // 
            // tBoxSoyad
            // 
            this.tBoxSoyad.Location = new System.Drawing.Point(628, 91);
            this.tBoxSoyad.Name = "tBoxSoyad";
            this.tBoxSoyad.Size = new System.Drawing.Size(100, 20);
            this.tBoxSoyad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyad: ";
            // 
            // tBoxSehir
            // 
            this.tBoxSehir.Location = new System.Drawing.Point(628, 117);
            this.tBoxSehir.Name = "tBoxSehir";
            this.tBoxSehir.Size = new System.Drawing.Size(100, 20);
            this.tBoxSehir.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sehir: ";
            // 
            // tBoxBakiye
            // 
            this.tBoxBakiye.Location = new System.Drawing.Point(628, 143);
            this.tBoxBakiye.Name = "tBoxBakiye";
            this.tBoxBakiye.Size = new System.Drawing.Size(100, 20);
            this.tBoxBakiye.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bakiye: ";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(578, 218);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 23);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(578, 247);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(150, 23);
            this.btnsil.TabIndex = 13;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(578, 276);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(150, 23);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 369);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tBoxBakiye);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBoxSehir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBoxSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.tBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgridMusteri);
            this.Name = "frmMusteri";
            this.Text = "frmMusteri";
            this.Load += new System.EventHandler(this.frmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridMusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridMusteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxId;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox tBoxAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxSehir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxBakiye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

