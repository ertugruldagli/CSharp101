using System;
using System.Collections;
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

        string sqlQuery = "";
        public frmProfuct()
        {
            InitializeComponent();
        }

      
        private void ShowData()
        {
            conn.Open();

            dgrwProduct.RowHeadersVisible = false; // baştaki boş kolonun gözükmesini kapatır.

            //Lsteleme
            sqlQuery = "SELECT Products.ProductID, Products.ProductName,  Products.UnitPrice,Products.UnitsInStock, CategoryName, Categories.CategoryID FROM Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID";

            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgrwProduct.DataSource = dt;

            dgrwProduct.Columns["CategoryID"].Visible=false;// kullanıcılara gözükmez..

            //ComboBox verileri
            sqlQuery = "Select* From Categories";

            SqlCommand cmd1 = new SqlCommand(sqlQuery, conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);  

            cboxCategory.DisplayMember = "CategoryName";
            cboxCategory.ValueMember = "CategoryID";
            cboxCategory.DataSource = dt1;

            conn.Close();

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
            tBoxProduct.Text = dgrwProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            tBoxPrice.Text = dgrwProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            nudStok.Value = int.Parse( dgrwProduct.Rows[e.RowIndex].Cells[3].Value.ToString());
            cboxCategory.SelectedValue = dgrwProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            sqlQuery = "UPDATE Products SET ProductName=@ProductName, UnitPrice=@UnitPrice, UnitsInStock=@UnitsInStock, CategoryID=@CategoryID WHERE ProductID=@ProductID";

            SqlCommand cmd= new SqlCommand(sqlQuery, conn);
            cmd.Parameters.AddWithValue("@ProductID", dgrwProduct.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@ProductName", tBoxProduct.Text);
            cmd.Parameters.AddWithValue("@UnitPrice", decimal.Parse(tBoxPrice.Text));
            cmd.Parameters.AddWithValue("@UnitsInStock", nudStok.Value);
            cmd.Parameters.AddWithValue("@CategoryID", cboxCategory.SelectedValue);
            

            cmd.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                

                MessageBox.Show("İşleminiz başarılı");
                
                conn.Close();
                ShowData();
            }
            catch (Exception hata)
            {
                

                MessageBox.Show(hata.ToString());
            }
          

          
        }
    }
}
