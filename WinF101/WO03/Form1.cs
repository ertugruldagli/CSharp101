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
      
        double yFiyat=0;
        int saat=0;


        const double oFiyat = 10;
        const double mFiyat = 15;
        const double tFiyat = 20;



        public frmOtotpark()
        {
            InitializeComponent();

            //cBoxType.SelectedIndex = 0;
        }


        #region İslemler
        private void btnHesapla_Click(object sender, EventArgs e)
        {

            string select = cBoxType.Text;
            saat=Convert.ToInt32(tBoxSaat.Text);

            switch (select)
            {
                case "Otomobil":
                    if (saat == 1)
                    {
                        yFiyat = oFiyat;
                    }
                    else
                    {
                        yFiyat = saat * (oFiyat * 1.2);
                    }
                   
                    lblMessage.Text = $"Odenecek tutar: {yFiyat.ToString()} ₺";
                    break;

                case "Minibus":
                    if (saat == 1)
                    {
                        yFiyat = mFiyat;
                    }
                    else
                    {
                        yFiyat = saat * (mFiyat * 1.25);
                    }
                    
                    lblMessage.Text = $"Odenecek tutar: {yFiyat.ToString()} ₺";
                    break;

                case "Ticari":
                    if (saat==1)
                    {
                        yFiyat = tFiyat;
                    }
                    else
                    {
                        yFiyat = saat * (tFiyat * 1.3);
                    }
                    
                    lblMessage.Text = $"Odenecek tutar: {yFiyat.ToString()} ₺";
                    break;
            }

        }
        #endregion


        #region Exit Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void frmOtotpark_Load(object sender, EventArgs e)
        {
            cBoxType.SelectedIndex= 0;
        }
    }
}
