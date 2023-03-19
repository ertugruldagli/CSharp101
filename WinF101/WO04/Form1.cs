using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WO04
{
    public partial class frmAtm : Form
    {
        int bakiye;
        public frmAtm()
        {
            InitializeComponent();
        }

  

        #region Çıkış Butonu
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Methodlar
        public void ParaCekme()
        {

        }
        public void ParaYatirma()
        {

        }
        public void BakiyeSorgulama()
        {


        }

        #endregion

        #region İşlemler
        private void btnOkay_Click(object sender, EventArgs e)
        {
            bakiye = Convert.ToInt32(tBoxBakiye.Text);

            string konrol = (cBoxIslem.Text);

            switch (konrol)
            {
                case "Para Çekme":
                    ParaCekme();
                    break;
                case "Para Yatırma":
                   ParaYatirma();
                    break;
                case "Bakiye Sorgulama":
                    BakiyeSorgulama();
                    break;
              
            }
        }
        #endregion

    }
}
