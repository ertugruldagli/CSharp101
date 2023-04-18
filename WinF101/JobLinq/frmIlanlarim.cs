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

        private void dgridIlanlarim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tBoxIlanSirketId.Text = dgridIlanlarim.Rows[e.RowIndex].Cells[1].Value.ToString();
            tBoxIlanDepartman.Text = dgridIlanlarim.Rows[e.RowIndex].Cells[2].Value.ToString();
            tBoxIlanTecrube.Text = dgridIlanlarim.Rows[e.RowIndex].Cells[3].Value.ToString();
            tBoxIlanEgitim.Text = dgridIlanlarim.Rows[e.RowIndex].Cells[4].Value.ToString();
            tBoxIlanYabanciDil.Text = dgridIlanlarim.Rows[e.RowIndex].Cells[5].Value.ToString();
            tBoxIlanCalisma.Text = dgridIlanlarim.Rows[e.RowIndex].Cells[6].Value.ToString();
            tBoxIlanPozisyon.Text = dgridIlanlarim.Rows[e.RowIndex].Cells[7].Value.ToString();
            cBoxIlanSehir.SelectedValue = dgridIlanlarim.Rows[e.RowIndex].Cells[8].Value.ToString();
            tBoxIlanDetay.Text = dgridIlanlarim.Rows[e.RowIndex].Cells[9].Value.ToString();
        }





        private void frmIlanlarim_Load(object sender, EventArgs e)
        {
            DataList();
            Property();
        }

        
    }
}
