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
           
            SQLQuery = "SELECT UserId FROM tblDatUser WHERE  Email=@Email and Parola=@Parola";

            using (SqlCommand cmd = new SqlCommand(SQLQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Email ", tBoxEmail.Text);
                cmd.Parameters.AddWithValue("@Parola ", tBoxPassword.Text);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    string id = dt.Rows[0][0].ToString();

                
                    
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