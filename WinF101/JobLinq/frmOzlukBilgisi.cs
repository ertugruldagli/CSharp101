using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobLinq
{
    public partial class frmOzlukBilgisi : Form
    {
        public frmOzlukBilgisi()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmIsArayanProfil pp=new frmIsArayanProfil();   
            pp.tBoxProfilEmail.Text=tboxOzlukEmail.Text;
            pp.ShowDialog();
            
        }
    }
}
