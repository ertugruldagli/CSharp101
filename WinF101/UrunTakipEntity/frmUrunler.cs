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

            var urunler = from x in db.Products select new { x.ProductID, x.ProductName, x.UnitsInStock, x.UnitPrice, x.Categories.CategoryName };
            dgridUrunler.DataSource = urunler.ToList();
        }

        private void dgridUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tBoxId.Text = dgridUrunler.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
