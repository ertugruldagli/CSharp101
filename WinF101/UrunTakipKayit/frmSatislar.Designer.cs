namespace UrunTakipKayit
{
    partial class frmSatislar
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
            this.rbtnSehir = new System.Windows.Forms.RadioButton();
            this.rbtnSoyad = new System.Windows.Forms.RadioButton();
            this.rbtnAd = new System.Windows.Forms.RadioButton();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxAdet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxSatisID = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgridMusteri = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxToplam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBoxDate = new System.Windows.Forms.TextBox();
            this.cBoxUrunId = new System.Windows.Forms.ComboBox();
            this.cBoxMusteriID = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.rbtnSehir);
            this.groupBox1.Controls.Add(this.rbtnSoyad);
            this.groupBox1.Controls.Add(this.rbtnAd);
            this.groupBox1.Controls.Add(this.tboxSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 70);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // rbtnSehir
            // 
            this.rbtnSehir.AutoSize = true;
            this.rbtnSehir.Location = new System.Drawing.Point(357, 29);
            this.rbtnSehir.Name = "rbtnSehir";
            this.rbtnSehir.Size = new System.Drawing.Size(49, 17);
            this.rbtnSehir.TabIndex = 17;
            this.rbtnSehir.TabStop = true;
            this.rbtnSehir.Text = "Sehir";
            this.rbtnSehir.UseVisualStyleBackColor = true;
            // 
            // rbtnSoyad
            // 
            this.rbtnSoyad.AutoSize = true;
            this.rbtnSoyad.Location = new System.Drawing.Point(296, 28);
            this.rbtnSoyad.Name = "rbtnSoyad";
            this.rbtnSoyad.Size = new System.Drawing.Size(55, 17);
            this.rbtnSoyad.TabIndex = 16;
            this.rbtnSoyad.TabStop = true;
            this.rbtnSoyad.Text = "Soyad";
            this.rbtnSoyad.UseVisualStyleBackColor = true;
            // 
            // rbtnAd
            // 
            this.rbtnAd.AutoSize = true;
            this.rbtnAd.Location = new System.Drawing.Point(253, 28);
            this.rbtnAd.Name = "rbtnAd";
            this.rbtnAd.Size = new System.Drawing.Size(37, 17);
            this.rbtnAd.TabIndex = 15;
            this.rbtnAd.TabStop = true;
            this.rbtnAd.Text = "ad";
            this.rbtnAd.UseVisualStyleBackColor = true;
            // 
            // tboxSearch
            // 
            this.tboxSearch.Location = new System.Drawing.Point(102, 25);
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.Size = new System.Drawing.Size(122, 20);
            this.tboxSearch.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Aranacak Kelime:";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(439, 19);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(130, 36);
            this.btnAra.TabIndex = 12;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.cBoxMusteriID);
            this.groupBox2.Controls.Add(this.cBoxUrunId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tBoxDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tBoxToplam);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tboxFiyat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tboxAdet);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tboxSatisID);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnOk);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(644, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 430);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fiyat: ";
            // 
            // tboxFiyat
            // 
            this.tboxFiyat.Location = new System.Drawing.Point(107, 200);
            this.tboxFiyat.Name = "tboxFiyat";
            this.tboxFiyat.Size = new System.Drawing.Size(122, 20);
            this.tboxFiyat.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Adet: ";
            // 
            // tboxAdet
            // 
            this.tboxAdet.Location = new System.Drawing.Point(107, 155);
            this.tboxAdet.Name = "tboxAdet";
            this.tboxAdet.Size = new System.Drawing.Size(122, 20);
            this.tboxAdet.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Musteri: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Urun: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "SatisId";
            // 
            // tboxSatisID
            // 
            this.tboxSatisID.Location = new System.Drawing.Point(107, 19);
            this.tboxSatisID.Name = "tboxSatisID";
            this.tboxSatisID.Size = new System.Drawing.Size(122, 20);
            this.tboxSatisID.TabIndex = 19;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(6, 343);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(115, 36);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(131, 385);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(115, 36);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(131, 343);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(115, 36);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Kaydet";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 385);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 36);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dgridMusteri
            // 
            this.dgridMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridMusteri.Location = new System.Drawing.Point(30, 91);
            this.dgridMusteri.Name = "dgridMusteri";
            this.dgridMusteri.Size = new System.Drawing.Size(576, 341);
            this.dgridMusteri.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Toplam: ";
            // 
            // tBoxToplam
            // 
            this.tBoxToplam.Location = new System.Drawing.Point(107, 240);
            this.tBoxToplam.Name = "tBoxToplam";
            this.tBoxToplam.Size = new System.Drawing.Size(122, 20);
            this.tBoxToplam.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Date: ";
            // 
            // tBoxDate
            // 
            this.tBoxDate.Location = new System.Drawing.Point(107, 275);
            this.tBoxDate.Name = "tBoxDate";
            this.tBoxDate.Size = new System.Drawing.Size(122, 20);
            this.tBoxDate.TabIndex = 31;
            // 
            // cBoxUrunId
            // 
            this.cBoxUrunId.FormattingEnabled = true;
            this.cBoxUrunId.Location = new System.Drawing.Point(108, 70);
            this.cBoxUrunId.Name = "cBoxUrunId";
            this.cBoxUrunId.Size = new System.Drawing.Size(121, 21);
            this.cBoxUrunId.TabIndex = 32;
            // 
            // cBoxMusteriID
            // 
            this.cBoxMusteriID.FormattingEnabled = true;
            this.cBoxMusteriID.Location = new System.Drawing.Point(109, 112);
            this.cBoxMusteriID.Name = "cBoxMusteriID";
            this.cBoxMusteriID.Size = new System.Drawing.Size(121, 21);
            this.cBoxMusteriID.TabIndex = 33;
            // 
            // frmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(920, 437);
            this.Controls.Add(this.dgridMusteri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSatislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSatislar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridMusteri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSehir;
        private System.Windows.Forms.RadioButton rbtnSoyad;
        private System.Windows.Forms.RadioButton rbtnAd;
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxSatisID;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBoxDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxToplam;
        private System.Windows.Forms.DataGridView dgridMusteri;
        private System.Windows.Forms.ComboBox cBoxMusteriID;
        private System.Windows.Forms.ComboBox cBoxUrunId;
    }
}