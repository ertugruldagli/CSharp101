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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.tBoxAdet = new System.Windows.Forms.TextBox();
            this.tBoxMusteriAd = new System.Windows.Forms.TextBox();
            this.cBoxUrunId = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxToplam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxSatisID = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgridSatis = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridSatis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.mtBoxDate);
            this.groupBox2.Controls.Add(this.tBoxAdet);
            this.groupBox2.Controls.Add(this.tBoxMusteriAd);
            this.groupBox2.Controls.Add(this.cBoxUrunId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tBoxToplam);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tboxFiyat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tboxSatisID);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnOk);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(594, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 430);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // mtBoxDate
            // 
            this.mtBoxDate.Location = new System.Drawing.Point(107, 279);
            this.mtBoxDate.Mask = "00/00/0000";
            this.mtBoxDate.Name = "mtBoxDate";
            this.mtBoxDate.Size = new System.Drawing.Size(124, 20);
            this.mtBoxDate.TabIndex = 35;
            this.mtBoxDate.ValidatingType = typeof(System.DateTime);
            // 
            // tBoxAdet
            // 
            this.tBoxAdet.Location = new System.Drawing.Point(109, 155);
            this.tBoxAdet.Name = "tBoxAdet";
            this.tBoxAdet.Size = new System.Drawing.Size(122, 20);
            this.tBoxAdet.TabIndex = 34;
            // 
            // tBoxMusteriAd
            // 
            this.tBoxMusteriAd.Location = new System.Drawing.Point(109, 108);
            this.tBoxMusteriAd.Name = "tBoxMusteriAd";
            this.tBoxMusteriAd.Size = new System.Drawing.Size(122, 20);
            this.tBoxMusteriAd.TabIndex = 33;
            // 
            // cBoxUrunId
            // 
            this.cBoxUrunId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxUrunId.FormattingEnabled = true;
            this.cBoxUrunId.Location = new System.Drawing.Point(108, 70);
            this.cBoxUrunId.Name = "cBoxUrunId";
            this.cBoxUrunId.Size = new System.Drawing.Size(121, 21);
            this.cBoxUrunId.TabIndex = 32;
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
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
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
            // dgridSatis
            // 
            this.dgridSatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridSatis.Location = new System.Drawing.Point(12, 2);
            this.dgridSatis.Name = "dgridSatis";
            this.dgridSatis.Size = new System.Drawing.Size(576, 430);
            this.dgridSatis.TabIndex = 30;
            // 
            // frmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(857, 437);
            this.Controls.Add(this.dgridSatis);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmSatislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSatislar";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridSatis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxSatisID;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxToplam;
        private System.Windows.Forms.DataGridView dgridSatis;
        private System.Windows.Forms.ComboBox cBoxUrunId;
        private System.Windows.Forms.MaskedTextBox mtBoxDate;
        private System.Windows.Forms.TextBox tBoxAdet;
        public System.Windows.Forms.TextBox tBoxMusteriAd;
    }
}