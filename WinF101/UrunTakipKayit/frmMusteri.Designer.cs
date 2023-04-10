namespace UrunTakipKayit
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
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.dgridMusteri = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSehir = new System.Windows.Forms.RadioButton();
            this.rbtnSoyad = new System.Windows.Forms.RadioButton();
            this.rbtnAd = new System.Windows.Forms.RadioButton();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxMusteriID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxSehir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxBakiye = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgridMusteri)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(439, 19);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(130, 36);
            this.btnAra.TabIndex = 12;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(107, 375);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(115, 36);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(107, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 36);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(107, 291);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(115, 36);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Kaydet";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(107, 249);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(115, 36);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dgridMusteri
            // 
            this.dgridMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridMusteri.Location = new System.Drawing.Point(21, 110);
            this.dgridMusteri.Name = "dgridMusteri";
            this.dgridMusteri.Size = new System.Drawing.Size(576, 332);
            this.dgridMusteri.TabIndex = 7;
            this.dgridMusteri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridMusteri_CellClick);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 70);
            this.groupBox1.TabIndex = 13;
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
            // tboxMusteriID
            // 
            this.tboxMusteriID.Location = new System.Drawing.Point(107, 19);
            this.tboxMusteriID.Name = "tboxMusteriID";
            this.tboxMusteriID.Size = new System.Drawing.Size(122, 20);
            this.tboxMusteriID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "MusteriID: ";
            // 
            // tboxAd
            // 
            this.tboxAd.Location = new System.Drawing.Point(107, 70);
            this.tboxAd.Name = "tboxAd";
            this.tboxAd.Size = new System.Drawing.Size(122, 20);
            this.tboxAd.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ad:";
            // 
            // tboxSoyad
            // 
            this.tboxSoyad.Location = new System.Drawing.Point(107, 115);
            this.tboxSoyad.Name = "tboxSoyad";
            this.tboxSoyad.Size = new System.Drawing.Size(122, 20);
            this.tboxSoyad.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Soyad: ";
            // 
            // tboxSehir
            // 
            this.tboxSehir.Location = new System.Drawing.Point(107, 155);
            this.tboxSehir.Name = "tboxSehir";
            this.tboxSehir.Size = new System.Drawing.Size(122, 20);
            this.tboxSehir.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sehir: ";
            // 
            // tboxBakiye
            // 
            this.tboxBakiye.Location = new System.Drawing.Point(107, 200);
            this.tboxBakiye.Name = "tboxBakiye";
            this.tboxBakiye.Size = new System.Drawing.Size(122, 20);
            this.tboxBakiye.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Bakiye: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tboxBakiye);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tboxSehir);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tboxSoyad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tboxAd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tboxMusteriID);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnOk);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(621, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 430);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Musteri İsmini Götür";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(880, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgridMusteri);
            this.Name = "frmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMusteri";
            ((System.ComponentModel.ISupportInitialize)(this.dgridMusteri)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dgridMusteri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSehir;
        private System.Windows.Forms.RadioButton rbtnSoyad;
        private System.Windows.Forms.RadioButton rbtnAd;
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxMusteriID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxSehir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxBakiye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox tboxAd;
        private System.Windows.Forms.Button button1;
    }
}