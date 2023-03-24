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

namespace AdoNetEx
{
    public partial class frmDataGridDetail : Form
    {
        public string islem;
        #region Sql Bağlantisi
        const string ConnectionUrl = @"Data Source=ED-INTERN;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection connection = new SqlConnection(ConnectionUrl);
        #endregion

        public frmDataGridDetail()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string SqlQuery = "";


            switch (islem)
            {
                case"U":
                    SqlQuery = "Update Customers SET ";
                    SqlQuery += "CompanyName=@CompanyName,";
                    SqlQuery += "ContactName=@ContactName,";
                    SqlQuery += "Country=@Country ";
                    SqlQuery += "where CustomerID=@CustomerID";

                    break;

                    
            }



            using (connection)
            {
                using (SqlCommand cmd =new SqlCommand(SqlQuery,connection))
                {
                    cmd.Parameters.AddWithValue("CustomerID", tboxCustomerID);
                    cmd.Parameters.AddWithValue("CompanyName", tboxCompanyName);
                    cmd.Parameters.AddWithValue("ContactName", tboxContactName);
                    cmd.Parameters.AddWithValue("Country", tboxCountry);

                    cmd.CommandType= CommandType.Text;

                    cmd.ExecuteNonQuery();


                }
            }
        }

        
    }
}
