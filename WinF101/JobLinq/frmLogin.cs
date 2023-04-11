using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace JobLinq
{
    public partial class frmLogin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ED-INTERN;Initial Catalog=DBJobLinq;Integrated Security=True");
        string SQLQuery = "";
        public frmLogin()
        {
            InitializeComponent();
        }


        private void Login()
        {
            conn.Open();
            int HesapTipi;
            SQLQuery = "SELECT  Email, Parola, HesapTipi FROM tblDatUser WHERE  Email=@Email and Parola=@Parola";
            using (SqlCommand cmd = new SqlCommand(SQLQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Email ", tBoxEmail.Text);
                cmd.Parameters.AddWithValue("@Parola ", tBoxPassword.Text);
                

                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.Read())
                    {
                        //if("HesapTipi".Equals(1))
                        //{
                        //    frmOzlukBilgisi ob = new frmOzlukBilgisi();
                        //    ob.ShowDialog();
                        //}
                        //else
                        //{
                        //    frmIsverenProfil pp=new frmIsverenProfil();
                        //    pp.ShowDialog();
                        //}
                        frmOzlukBilgisi ob = new frmOzlukBilgisi();
                        ob.tboxOzlukEmail.Text = tBoxEmail.Text;
                        ob.ShowDialog();

                        
                    }
                    else
                    {
                        MessageBox.Show("Hatalı kullanım..");
                    }
                }
                conn.Close();
            }
        }

            private void btnGirisYap_Click(object sender, EventArgs e)
            {
                Login();
            }
    }
    
}