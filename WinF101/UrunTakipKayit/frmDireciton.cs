using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunTakipKayit
{
    public partial class frmDireciton : Form
    {
        public frmDireciton()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=ED-INTERN;Initial Catalog=Northwind;Integrated Security=True");

        private void panel1_Click(object sender, EventArgs e)
        {
            frmProfuct frmProfuct = new frmProfuct();   
            frmProfuct.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();    
            frmMain.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            frmIstatistik fr=new frmIstatistik();
            fr.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            frmGraphics frmGraphics = new frmGraphics();
            frmGraphics.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin(); 
            frmAdmin.Show();
            frmAdmin.Hide();
        }
    }
}
