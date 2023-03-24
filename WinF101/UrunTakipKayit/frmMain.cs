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

namespace UrunTakipKayit
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=ED-INTERN;Initial Catalog=TestDB;Integrated Security=True");

        private void btnListele_Click(object sender, EventArgs e)
        {
         
            

            SqlCommand query = new SqlCommand("Select* From datPersonel",connect);
            
            SqlDataAdapter adapter = new SqlDataAdapter(query); //köprü görevi görür.
            
            DataTable dataTable= new DataTable();  //verileri tablo halinde getirir.
           
            adapter.Fill(dataTable); //fill: doldurma anlamına gelir

            dtw01.DataSource = dataTable;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand query2 = new SqlCommand("Insert into datPersonel (Name) values (@p1)", connect);
            query2.Parameters.AddWithValue("@p1",tBoxKategori.Text);
            //query2.Parameters.AddWithValue("@p3", null);
            query2.ExecuteNonQuery();

            connect.Close();

            MessageBox.Show("Kaydedildi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand query3 = new SqlCommand("Delete From datPersonel Where PersID=@p1", connect);
            query3.Parameters.AddWithValue("@p1",tBoxID.Text);
            query3.ExecuteNonQuery();

            connect.Close();

            MessageBox.Show("Silme İşlemi Başarılı!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connect.Open();

            SqlCommand query4 = new SqlCommand("Update datPersonel SET Name=@p1 Where PersID=@p2", connect);
            query4.Parameters.AddWithValue("@p1", tBoxKategori.Text);
            query4.Parameters.AddWithValue("@p2", tBoxID.Text);
            query4.ExecuteNonQuery();

            connect.Close();

            MessageBox.Show("Güncelleme İşlemi Başarılı!");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("Select* From datPersonel where Name=@p1", connect);
            query.Parameters.AddWithValue("@p1",tBoxKategori.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(query); //köprü görevi görür.

            DataTable dataTable = new DataTable();  //verileri tablo halinde getirir.

            adapter.Fill(dataTable); //fill: doldurma anlamına gelir

            dtw01.DataSource = dataTable;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=ED-INTERN;Initial Catalog=Northwind;Integrated Security=True
//Data Source=ED-INTERN;Initial Catalog=TestDB;Integrated Security=True