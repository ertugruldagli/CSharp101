using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using BussinesLayer;

namespace KatmanliMimariProjects
{
    public partial class frmDersler : Form
    {
        public frmDersler()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            EntityDers dersler=new EntityDers();

            dersler.DersAd=tBoxDersAd.Text;

            BLDers.DersEkleBL(dersler);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityDers> ders = BLDers.DersListesiBL();
            dgridDers.DataSource = ders;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            byte deger, deger2;
           //deger2= dgridDers.Row
            deger=byte.Parse(tBoxDersId.Text);
            EntityDers ed=new EntityDers();
            ed.DersID = byte.Parse(deger.ToString());
            BLDers.DersSilBL(ed.DersID);
        }
    }
}
