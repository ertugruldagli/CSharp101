namespace UrunTakipKayit
{
    partial class frmUrunGetir
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
            this.dgrwUrunGetir = new System.Windows.Forms.DataGridView();
            this.tBoxGetir = new System.Windows.Forms.TextBox();
            this.btnUrunGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwUrunGetir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrwUrunGetir
            // 
            this.dgrwUrunGetir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrwUrunGetir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrwUrunGetir.Location = new System.Drawing.Point(12, 12);
            this.dgrwUrunGetir.Name = "dgrwUrunGetir";
            this.dgrwUrunGetir.Size = new System.Drawing.Size(599, 426);
            this.dgrwUrunGetir.TabIndex = 4;
            // 
            // tBoxGetir
            // 
            this.tBoxGetir.Location = new System.Drawing.Point(708, 46);
            this.tBoxGetir.Name = "tBoxGetir";
            this.tBoxGetir.Size = new System.Drawing.Size(100, 20);
            this.tBoxGetir.TabIndex = 5;
            // 
            // btnUrunGetir
            // 
            this.btnUrunGetir.Location = new System.Drawing.Point(721, 101);
            this.btnUrunGetir.Name = "btnUrunGetir";
            this.btnUrunGetir.Size = new System.Drawing.Size(75, 23);
            this.btnUrunGetir.TabIndex = 6;
            this.btnUrunGetir.Text = "Getir";
            this.btnUrunGetir.UseVisualStyleBackColor = true;
            this.btnUrunGetir.Click += new System.EventHandler(this.btnUrunGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(626, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "UrunName:";
            // 
            // frmUrunGetir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUrunGetir);
            this.Controls.Add(this.tBoxGetir);
            this.Controls.Add(this.dgrwUrunGetir);
            this.Name = "frmUrunGetir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUrunGetir";
            ((System.ComponentModel.ISupportInitialize)(this.dgrwUrunGetir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrwUrunGetir;
        private System.Windows.Forms.TextBox tBoxGetir;
        private System.Windows.Forms.Button btnUrunGetir;
        private System.Windows.Forms.Label label1;
    }
}