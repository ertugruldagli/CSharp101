namespace KatmanliMimariProjects
{
    partial class Form1
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tBoxDersAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxDersId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.dgridUrunler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgridUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(611, 169);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(150, 23);
            this.btnGuncelle.TabIndex = 41;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(611, 140);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(150, 23);
            this.btnsil.TabIndex = 40;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(611, 111);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(150, 23);
            this.btnKaydet.TabIndex = 39;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // tBoxDersAd
            // 
            this.tBoxDersAd.Location = new System.Drawing.Point(661, 38);
            this.tBoxDersAd.Name = "tBoxDersAd";
            this.tBoxDersAd.Size = new System.Drawing.Size(100, 20);
            this.tBoxDersAd.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ders Ad: ";
            // 
            // tBoxDersId
            // 
            this.tBoxDersId.Location = new System.Drawing.Point(661, 12);
            this.tBoxDersId.Name = "tBoxDersId";
            this.tBoxDersId.Size = new System.Drawing.Size(100, 20);
            this.tBoxDersId.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "DersID: ";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(611, 82);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(150, 23);
            this.btnListele.TabIndex = 31;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            // 
            // dgridUrunler
            // 
            this.dgridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridUrunler.Location = new System.Drawing.Point(12, 12);
            this.dgridUrunler.Name = "dgridUrunler";
            this.dgridUrunler.Size = new System.Drawing.Size(591, 187);
            this.dgridUrunler.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 225);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tBoxDersAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxDersId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgridUrunler);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgridUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox tBoxDersAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxDersId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dgridUrunler;
    }
}

