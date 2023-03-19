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
        public frmTwoCBoxes()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(cBoxConrol.Text);
            

            for (int i = t; i < ; i++)
            {
               
                cBoxListele.Items.Add(i);
            }
            






        }
    }
}
