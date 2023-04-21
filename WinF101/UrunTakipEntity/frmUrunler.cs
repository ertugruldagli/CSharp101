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
    public partial class frmUrunler : Form
    {
        NorthwindEntities db=new NorthwindEntities();
        public frmUrunler()
        {
            InitializeComponent();
        }


        private void Property()
        {
            dgridUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgridUrunler.RowHeadersVisible = false;
        }


       
        private void btnListele_Click(object sender, EventArgs e)
        {
            Property();

            // dgridUrunler.DataSource=db.Products.ToList  ();

            var urunler = from x in db.Products select new 
            {
                x.ProductID, x.ProductName, x.UnitsInStock, x.UnitPrice, x.Categories.CategoryName
            };

            dgridUrunler.DataSource = urunler.ToList();
        }

        private void dgridUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tBoxId.Text = dgridUrunler.Rows[e.RowIndex].Cells[0].Value.ToString();
            tBoxAd.Text = dgridUrunler.Rows[e.RowIndex].Cells[1].Value.ToString();
            tBoxStok.Text = dgridUrunler.Rows[e.RowIndex].Cells[2].Value.ToString();
            tBoxFiyat.Text = dgridUrunler.Rows[e.RowIndex].Cells[3].Value.ToString();
            cBoxCategory.SelectedValue = dgridUrunler.Rows[e.RowIndex].Cells[4].ToString();
        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            cBoxCategory.DataSource = db.Categories.ToList();

            cBoxCategory.ValueMember = "CategoryID";
            cBoxCategory.DisplayMember = "CategoryName";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Products p =new Products();

            p.ProductName=tBoxAd.Text;
            p.UnitsInStock=short.Parse(tBoxStok.Text);
            p.UnitPrice=decimal.Parse(tBoxFiyat.Text);
            p.CategoryID = (int)cBoxCategory.SelectedValue;

            db.Products.Add(p);
            db.SaveChanges();

            MessageBox.Show("Yeni Ürün Kaydı yapıldı!");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (tBoxId.Text=="")
            {
                MessageBox.Show("Tıklama İşlemi Yapmadınız!");
            }
            else
            {
                int id = int.Parse(tBoxId.Text);
                var k = db.Products.Find(id);

                db.Products.Remove(k);
                db.SaveChanges();

                MessageBox.Show("Seçilen Kayıt Silindi!");
            }

           

        }
    }
}
