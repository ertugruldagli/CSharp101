using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wo02
{
    public partial class frmTwoCBoxes : Form
    {
        public void DegerAtama()  // comboBox içerisine  manuel girmek yerine method oluşturularak otomatik olarak girildi.
        {
            for (int i = 0; i <= 20; i++)
            {
                cBoxConrol.Items.Add(i);
            }
        }

        public frmTwoCBoxes()
        {
            
            InitializeComponent();

            DegerAtama();// method form içerisinden çağırıldı.
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            cBoxListele.Items.Clear(); //butona bastıktan sonra temizlendi.

            int t = Convert.ToInt32(cBoxConrol.Text);
            

            for (int i = t+1; i <= t+10; i++)  //seçilen sayının bir fazlasından alarak seçilen değerin 10 fazlasına kadar getirdi.
            {
               
                cBoxListele.Items.Add(i); // seçilen değerleri yeni cboxa yazdırdı.
            }


        }
            

     
    }
}
