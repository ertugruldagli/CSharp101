namespace WO01
{
    partial class frmTersString
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
            this.button1 = new System.Windows.Forms.Button();
            this.tBoxString = new System.Windows.Forms.TextBox();
            this.tBoxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(235, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBoxString
            // 
            this.tBoxString.Location = new System.Drawing.Point(99, 38);
            this.tBoxString.Name = "tBoxString";
            this.tBoxString.Size = new System.Drawing.Size(182, 20);
            this.tBoxString.TabIndex = 1;
            // 
            // tBoxOutput
            // 
            this.tBoxOutput.Location = new System.Drawing.Point(53, 177);
            this.tBoxOutput.Name = "tBoxOutput";
            this.tBoxOutput.Size = new System.Drawing.Size(182, 20);
            this.tBoxOutput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "String giriniz: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(95, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "OUTPUT";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(146, 75);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(89, 23);
            this.btnYazdir.TabIndex = 5;
            this.btnYazdir.Text = "Yazdir";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // frmTersString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(292, 299);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxOutput);
            this.Controls.Add(this.tBoxString);
            this.Controls.Add(this.button1);
            this.Name = "frmTersString";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TersString";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tBoxString;
        private System.Windows.Forms.TextBox tBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYazdir;
    }
}

