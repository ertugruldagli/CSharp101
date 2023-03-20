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

        const double oOdeme = 0.20;
        const double mOdeme = 0.25;
        const double tOdeme = 0.30;

        //const double oFiyat = 10;
        //const double mFiyat = 15;
        //const double tFiyat = 20;



        public frmOtotpark()
        {
            InitializeComponent();

            //cBoxType.SelectedIndex = 0;
        }

        public void Vehicle(string oto, string bus, string van)
        {
            //oto = oFiyat.ToString();

            fiyat = 10;
            saat = Convert.ToInt32(tBoxSaat.Text);
            yFiyat = (fiyat + (fiyat * oOdeme)) * (saat);

            if (saat == 0)
            {
                yFiyat = fiyat;
            }
        }



        #region Methodlar
        public void OtoHesapla()
        {
            
             

        }
        public void BusHesapla()
        {

                fiyat = 15;
                saat = Convert.ToInt32(tBoxSaat.Text);
                yFiyat = (fiyat + (fiyat * oOdeme)) * (saat);

                if (saat == 0)
                {
                    yFiyat = fiyat;
                }
        }
        public void VanHesapla()
        {

           
                fiyat = 20;
                saat = Convert.ToInt32(tBoxSaat.Text);
                yFiyat = (fiyat + (fiyat * tOdeme)) * (saat);

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

        private void frmOtotpark_Load(object sender, EventArgs e)
        {
            cBoxType.SelectedIndex= 0;
        }
    }
}
