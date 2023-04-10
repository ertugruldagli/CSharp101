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
   
    public partial class frmUrunGetir : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=ED-INTERN;Initial Catalog=Northwind;Integrated Security=True");

        string sqlQuery = "";

        public frmUrunGetir()
        {
            InitializeComponent();
        }


        private void ShowData()
        {
            conn.Open();
            sqlQuery = "exec UrunGetir2 "+ tBoxGetir.Text;

            using (SqlCommand cmd=new SqlCommand(sqlQuery,conn))
            {
                using (SqlDataAdapter dAdapter=new SqlDataAdapter(cmd))
                {
                    DataTable dataTabla= new DataTable();   
                    dAdapter.Fill(dataTabla);

                    dgrwUrunGetir.DataSource= dataTabla;
                }
            }

            


                conn.Close();

        }

        private void btnUrunGetir_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
