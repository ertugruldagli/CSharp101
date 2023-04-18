using Microsoft.Win32.SafeHandles;
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

namespace JobLinq
{
    public partial class frmIlanlarim : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=ED-INTERN;Initial Catalog=DBJobLinq;Integrated Security=True");
        string SQLQuery = "";

        public frmIlanlarim()
        {
            InitializeComponent();
        }


        private void Property()
        {
            dgridIlanlarim.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;

            dgridIlanlarim.RowHeadersVisible=false;

            dgridIlanlarim.Columns[0].Visible=false;
        }


       
        private void DataList()
        {
            conn.Open();
            
            
            SQLQuery = "SELECT* FROM tblilan";

            using (SqlCommand cmd = new SqlCommand(SQLQuery,conn))
            {
                using (SqlDataAdapter sda =new SqlDataAdapter(cmd))
                {
                    DataTable dataTable= new DataTable();   
                    sda.Fill(dataTable);

                    dgridIlanlarim.DataSource= dataTable;
                }
            }

             conn.Close();

        }

        private void frmIlanlarim_Load(object sender, EventArgs e)
        {
            DataList();
            Property();
        }
    }
}
