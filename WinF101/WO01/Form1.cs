using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WO01
{
    public partial class frmTersString : Form
    {
        public frmTersString()
        {
            InitializeComponent();
        }


        #region Method
        public void TersYazma() //işlem yapılam yer
        {
            string ters = tBoxString.Text; //string texten alındı

            tBoxOutput.Clear();
            
            for (int i = ters.Length - 1; i >= 0; i--) //string uzunlupuna göre tersten döngüye girildi
            {
                
                tBoxOutput.Text += ters[i];    //ters alınan stringin herbir karakterini  output textine yazdırıldı
            }

        }
        #endregion

        #region Çıkış Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region İşlemler
        private void btnYazdir_Click(object sender, EventArgs e)
        {
        
            TersYazma(); //Method oluşturarak yapıldı.
            
        }
        #endregion



    }
}
