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
    public partial class frmGraphics : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=ED-INTERN;Initial Catalog=Northwind;Integrated Security=True");
        string sqlQ = "";
        public frmGraphics()
        {
            InitializeComponent();
        }

        private void frmGraphics_Load(object sender, EventArgs e)
        {
            connect.Open();

            sqlQ = "SELECT Categories.CategoryName, COUNT(*) FROM Products INNER JOIN\tCategories ON Categories.CategoryID=Products.CategoryID GROUP BY CategoryName";
            SqlCommand cmd = new SqlCommand(sqlQ,connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Kategori"].Points.AddXY(dr[0], dr[1]);
            }
            connect.Close();
        }
    }
}
