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
    public partial class frmIstatistik : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=ED-INTERN;Initial Catalog=Northwind;Integrated Security=True");
        public frmIstatistik()
        {
            InitializeComponent();
        }

        private void frmIstatistik_Load(object sender, EventArgs e)
        {

            connect.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT Count(*) FROM Categories",connect);
            SqlDataReader dr=cmd1.ExecuteReader();
            dr.Read();
            lblToplam.Text = dr[0].ToString();
            //while(dr.Read())
            // {
            //     lblToplam.Text = dr[0].ToString();
            // }
            connect.Close();
        }
    }
}
