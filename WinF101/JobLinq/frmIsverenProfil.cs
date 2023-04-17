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
    public partial class frmIsverenProfil : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=ED-INTERN;Initial Catalog=DBJobLinq;Integrated Security=True");
        string SQLQuery = "";

        public frmIsverenProfil()
        {
            InitializeComponent();
        }

        private void AddData()
        {
            conn.Open();

            SQLQuery = "INSERT INTO tblSirketBilgisi ( UserId, Ad, Sektor, Adres, Sehir, CalisanSayisi, Aciklama ) VALUES (@UserId, @Ad, @Sektor,@Adres, @Sehir, @CalisanSayisi, @Aciklama)";

            using (SqlCommand cmd =new SqlCommand (SQLQuery,conn))
            {

                cmd.Parameters.AddWithValue("@UserId",tBoxSirketUserId.Text);
                cmd.Parameters.AddWithValue("@Ad ", tBoxSirketAD.Text);
                cmd.Parameters.AddWithValue("@Sektor ", tBoxSirketSektor.Text);
                cmd.Parameters.AddWithValue("@Adres ", tBoxSirketAdres.Text);
                cmd.Parameters.AddWithValue("@Sehir ", tBoxSirketSehir.Text);
                cmd.Parameters.AddWithValue("@CalisanSayisi ", tBoxCalisanSayisi.Text);
                cmd.Parameters.AddWithValue("@Aciklama ", tBoxSirketAciklama.Text);

                cmd.CommandType = CommandType.Text;

                using (SqlDataAdapter sda =new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("İşleminiz başarılı");

                      
                   
                }

            }



                
        }

        private void btnIsVerenProfilGuncelle_Click(object sender, EventArgs e)
        {
            AddData();
        }
    }
}
