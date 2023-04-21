using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunTakipEntity
{

    
    public partial class frmIstatistik : Form
    {
        NorthwindEntities db = new NorthwindEntities();
        public frmIstatistik()
        {
            InitializeComponent();
        }

        private void frmIstatistik_Load(object sender, EventArgs e)
        {
            DateTime today= DateTime.Today;

            lblMusteriSayisi.Text = db.tblMusteri.Count().ToString();
            lblKategoriSayisi.Text=db.Categories.Count().ToString();    
            lblUrunSayısı.Text=db.Products.Count().ToString();
            lblBeyazEsyaSayisi.Text=db.Categories.Count(x=>x.CategoryName=="Beverages").ToString();
            lblToplamStok.Text=db.Products.Sum(x=>x.UnitsInStock).ToString();

            lblBugunSatisAdeti.Text=db.tblSatis.Count(x=>x.Tarih==today).ToString();

            lblBugunKasaTutarı.Text=db.tblSatis.Where(x=>x.Tarih==today).Sum(x=>x.Toplam).ToString() + " ₺ ";

            lblToplamKasaTutarı.Text=db.tblSatis.Sum(x=>x.Toplam).ToString() + " ₺ ";

            lblEnYuksekFiyat.Text = (from x in db.Products orderby x.UnitPrice descending select x.ProductName).FirstOrDefault();

            lblEnDusukUrun.Text= (from x in db.Products orderby x.UnitPrice ascending select x.ProductName).FirstOrDefault();

            lblEnfazlaStok.Text = (from x in db.Products orderby x.UnitsInStock descending select x.ProductName).FirstOrDefault();

            lblEnAzStok.Text = (from x in db.Products orderby x.UnitsInStock ascending select x.ProductName).FirstOrDefault();


        }
    }
}
