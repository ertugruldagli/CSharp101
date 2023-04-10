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
        DataSet1TableAdapters.tblMusteriTableAdapter tbM = new DataSet1TableAdapters.tblMusteriTableAdapter();
        public frmMusteri()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            
            dgridMusteri.DataSource = tbM.MusteriListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            tbM.MusteriSil(int.Parse(tboxMusteriID.Text));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbM.MusteriGuncelle(tboxAd.Text,tboxSoyad.Text,tboxSehir.Text, decimal.Parse(tboxBakiye.Text), int.Parse( tboxMusteriID.Text));
        }

        private void dgridMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tboxMusteriID.Text = dgridMusteri.Rows[e.RowIndex].Cells[0].Value.ToString();
            tboxAd.Text = dgridMusteri.Rows[e.RowIndex].Cells[1].Value.ToString();
            tboxSoyad.Text = dgridMusteri.Rows[e.RowIndex].Cells[2].Value.ToString();
            tboxSehir.Text = dgridMusteri.Rows[e.RowIndex].Cells[3].Value.ToString();
            tboxBakiye.Text =dgridMusteri.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            dgridMusteri.DataSource= tbM.MusteriEkle(tboxAd.Text,tboxSoyad.Text,tboxSehir.Text, decimal.Parse(tboxBakiye.Text));

            dgridMusteri.DataSource = tbM.MusteriListesi();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (rbtnAd.Checked==true)
            {
                dgridMusteri.DataSource= tbM.AdaGoreGetir(tboxSearch.Text);
            }
             if (rbtnSoyad.Checked==true)
            {
                dgridMusteri.DataSource = tbM.SoyadaGoreGetir(tboxSearch.Text);
            }
            if (rbtnSehir.Checked == true)
            {
                dgridMusteri.DataSource = tbM.SehireGoreGetir(tboxSearch.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSatislar frmSatislar = new frmSatislar();
            frmSatislar.tBoxMusteriAd.Text=tboxAd.Text;
            frmSatislar.ShowDialog();
        }
    }
}
