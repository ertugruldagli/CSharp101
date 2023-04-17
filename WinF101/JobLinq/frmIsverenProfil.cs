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

            SQLQuery = "INSERRT INTO tblSirketBilgileri ( UserId, Ad, Sektor, Adres, Sehir, CalisanSayisi, Aciklama From tblSirketBilgileri ) VALUES (@UserId, @Ad, @Sektor,@Adres, @Sehir, @CalisanSayisi, @Aciklama)";

            using (SqlCommand cmd =new SqlCommand (SQLQuery,conn))
            {
                cmd.Parameters.AddWithValue("@Ad ", tBoxSirketAD.Text);
                cmd.Parameters.AddWithValue("@Sektor ", cBoxSirketSektor);
                cmd.Parameters.AddWithValue("@Adres ", tBoxSirketAdres.Text);
                cmd.Parameters.AddWithValue("@Sehir ", cBoxSirketSehir);
                cmd.Parameters.AddWithValue("@CalisanSayisi ", tBoxCalisanSayisi.Text);
                cmd.Parameters.AddWithValue("@Aciklama ", liBoxProfilOnyazi.Text);

                using (SqlDataAdapter sda =new SqlDataAdapter(cmd))
                {


                }

            }



                conn.Close();
        }
    }
}
