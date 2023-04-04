using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunTakipKayit
{
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tblMusteriTableAdapter tbM = new DataSet1TableAdapters.tblMusteriTableAdapter();
            dgridMusteri.DataSource = tbM.MusteriListesi();
        }
    }
}
