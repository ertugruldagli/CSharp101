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
    public partial class frmYeniIlan : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ED-INTERN;Initial Catalog=DBJobLinq;Integrated Security=True");
        string SQLQuery = "";
        public frmYeniIlan()
        {
            InitializeComponent();
        }

        private void AddData()
        {
            conn.Open();

            SQLQuery = "INSERT INTO tblilan ( Sirket, Departman, Tecrube, EgitimSeviyesi, YabanciDil, CalismaSekli, Pozisyon, Sehir, IlanDetay ) VALUES ( @Sirket, @Departman, @Tecrube ,@EgitimSeviyesi, @YabanciDil, @CalismaSekli, @Pozisyon, @Sehir, @IlanDetay)";

            using (SqlCommand cmd = new SqlCommand(SQLQuery, conn))
            {

                cmd.Parameters.AddWithValue("@Sirket", tboxYeniİlanSirket.Text);
                cmd.Parameters.AddWithValue("@Departman ", tBoxYeniIlanDEpartman.Text);
                cmd.Parameters.AddWithValue("@Tecrube ", tBoxYeniIlanTecrube.Text);
                cmd.Parameters.AddWithValue("@EgitimSeviyesi ", tBoxYeniIlanESeviyesi.Text);
                cmd.Parameters.AddWithValue("@YabanciDil ", tBoxYeniIlanDil.Text);
                cmd.Parameters.AddWithValue("@CalismaSekli ", tBoxYeniIlanCSekli.Text);
                cmd.Parameters.AddWithValue("@Pozisyon ", tBoxYeniIlanPozisyon.Text);
                cmd.Parameters.AddWithValue("@Sehir ", tBoxYeniIlanSehir.Text);
                cmd.Parameters.AddWithValue("@IlanDetay ", tBoxAciklama.Text);

                cmd.CommandType = CommandType.Text;

                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);

                    cmd.ExecuteNonQuery();
                    //cBoxSirketSehir.DisplayMember = "Sehir";
                    //cBoxSirketSehir.ValueMember = "Sehir";
                    //cBoxSirketSehir.DataSource = dataTable;

                    MessageBox.Show("İşleminiz başarılı");

                }

            }

            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddData();
            frmIlanlarim ilanlar=new frmIlanlarim();    
            ilanlar.ShowDialog();
        }

        private void label10_DoubleClick(object sender, EventArgs e)
        {
            frmIlanlarim ilan=new frmIlanlarim();
            ilan.ShowDialog();
        }
    }
}
