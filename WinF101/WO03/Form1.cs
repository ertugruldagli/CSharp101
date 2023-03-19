using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WO03
{
    public partial class frmOtotpark : Form
    {
        public frmOtotpark()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int fiyat=0;
            string select=cBoxType.Text;
            string saat=tBoxSaat.Text;

            switch (select)
            {
                case "Otomobil":
                    fiyat+= fiyat+10;
                    lblMessage.Text= $"Odenecek tutar: {fiyat.ToString()}";
                    break;

                case "Minibus":
                    fiyat += 15;
                    lblMessage.Text = $"Odenecek tutar: {fiyat.ToString()}";
                    break;

                case "Ticari":
                    fiyat += 20;
                    lblMessage.Text = $"Odenecek tutar: {fiyat.ToString()}";
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
