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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            TersYazma();
        }

        public void TersYazma()
        {
             string ters=tBoxString.Text;

            for (int i=ters.Length-1;i>=0;i--)
            {
                tBoxOutput.Text += ters[i];    
            }


        }
    }
}
