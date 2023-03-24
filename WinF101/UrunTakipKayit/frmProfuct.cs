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
    public partial class frmProfuct : Form
    {
        SqlConnection conn=new SqlConnection(@"Data Source=ED-INTERN;Initial Catalog=Northwind;Integrated Security=True");
        public frmProfuct()
        {
            InitializeComponent();
        }

      
        private void ShowData()
        {
            conn.Open();

            //Lsteleme
            string sqlQuery = "select ProductName, UnitPrice, UnitsInStock, CategoryID from Products";

            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgrwProduct.DataSource = dt;


            //ComboBox verileri
            sqlQuery = "Select* From Categories";

            SqlCommand cmd1 = new SqlCommand(sqlQuery, conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            cboxCategory.DisplayMember = "CategoryName";
            cboxCategory.ValueMember = "CategoryID";
            cboxCategory.DataSource = dt1;

        }

        private void frmProfuct_Load(object sender, EventArgs e)
        {
           
            ShowData(); 

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void dgrwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tBoxProduct.Text = dgrwProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            tBoxPrice.Text = dgrwProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            nudStok.Value = int.Parse( dgrwProduct.Rows[e.RowIndex].Cells[2].Value.ToString());
           // cboxCategory.ValueMember = dgrwProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
