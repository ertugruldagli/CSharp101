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
        double fiyat;
        double yFiyat;
        int saat;


        public frmOtotpark()
        {
            InitializeComponent();
        }


        #region Methodlar
        public void OtoHesapla()
        {
            
                fiyat = 10;
                saat = Convert.ToInt32(tBoxSaat.Text);
                yFiyat = (fiyat + (fiyat * 0.20)) * (saat);

                if (saat == 0)
                {
                    yFiyat = fiyat;
                }

        }
        public void BusHesapla()
        {

                fiyat = 15;
                saat = Convert.ToInt32(tBoxSaat.Text);
                yFiyat = (fiyat + (fiyat * 0.25)) * (saat);

                if (saat == 0)
                {
                    yFiyat = fiyat;
                }
        }
        public void VanHesapla()
        {

           
                fiyat = 20;
                saat = Convert.ToInt32(tBoxSaat.Text);
                yFiyat = (fiyat + (fiyat * 0.30)) * (saat);

                if (saat == 0)
                {
                    yFiyat = fiyat;
                }

        }
        #endregion


        #region İslemler
        private void btnHesapla_Click(object sender, EventArgs e)
        {

            string select = cBoxType.Text;
          

            switch (select)
            {
                case "Otomobil":
                    OtoHesapla();
                    lblMessage.Text = $"Odenecek tutar: {yFiyat.ToString()} ₺";
                    break;

                case "Minibus":
                    BusHesapla();
                    lblMessage.Text = $"Odenecek tutar: {yFiyat.ToString()} ₺";
                    break;

                case "Ticari":
                    VanHesapla();
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

    }
}
