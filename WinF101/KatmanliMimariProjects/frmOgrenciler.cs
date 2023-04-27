using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using EntityLayer;
using BussinesLayer;

namespace KatmanliMimariProjects
{
    public partial class frmOgrenciler : Form
    {
        public frmOgrenciler()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            EntityOgrenci ogrenciler = new EntityOgrenci();

            ogrenciler.Ad = tBoxOgrAd.Text;
            ogrenciler.Soyad=tboxOgrSoyad.Text;
            ogrenciler.Numara = tboxOgrNo.Text;
            ogrenciler.Bolum=tboxOgrBolum.Text;

            BLOgrenci.OgrenciEkleBL(ogrenciler);

            MessageBox.Show("Kaydedildi!");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //List<EntityOgrenci> Ogrenciler = BLOgrenci.OgrenciListesiBL();
            //dgridOgrenci.DataSource = Ogrenciler;
            dgridOgrenci.DataSource = BLOgrenci.OgrenciListesiBL();
        }
    }
}
