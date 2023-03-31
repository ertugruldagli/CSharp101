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
    public partial class frmDataGrid : Form
    {
        #region Sql Bağlantisi
        const string ConnectionUrl = @"Data Source=ED-INTERN;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection connection = new SqlConnection(ConnectionUrl);
        #endregion


        public frmDataGrid()
        {
            InitializeComponent();
         
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        #region Data Grid Ozellikleri
        private void DataGridProperteis()
        {
            dgwCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwCustomers.ReadOnly = true; //sadece okuma işlemi yapar.. tablo üzerinde klavyeden giriş işlemi yapmaz
            dgwCustomers.RowHeadersVisible = false;   // baştaki kolonu gizler

        }
        #endregion

        #region Listeleme işlemi
        private void MainForm()
        {


        //   clsConneciton.openConnection();
            
            connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT CustomerID, CompanyName, ContactName, Country FROM Customers", connection))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dSet = new DataSet())
                        {
                            da.Fill(dSet);
                            dgwCustomers.DataSource = dSet.Tables[0];

                        }

                    }
                }
            connection.Close();
        }
        #endregion

        #region from load
        private void frmDataGrid_Load(object sender, EventArgs e)
        {
            MainForm();
            DataGridProperteis();
        }



        #endregion

     
        private void ShowData(string prmMode)
        {
            frmDataGridDetail detail = new frmDataGridDetail();
            detail.islem = prmMode;

        }




        private void dgwCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           ShowData("U");
            MainForm();
        }
    }
}
