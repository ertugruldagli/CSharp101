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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=ED-INTERN;Initial Catalog=Northwind;Integrated Security=True");
        string SQLQuery = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            connect.Open();
            SQLQuery = "SELECT * FROM TblAdmin WHERE Kullanici=@KName and Sifre = @Pass";

            SqlCommand cmd= new SqlCommand(SQLQuery, connect);

            cmd.Parameters.AddWithValue("@KName", tboxKname.Text);
            cmd.Parameters.AddWithValue("@Pass", tboxPass.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                frmDireciton fr = new frmDireciton();
                fr.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Hatalı kullanım..");
            }
               
            connect.Close();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
