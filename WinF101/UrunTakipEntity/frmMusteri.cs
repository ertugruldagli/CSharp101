﻿using System;
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
    public partial class frmMusteri : Form
    {
        NorthwindEntities dbNortwind = new NorthwindEntities();

        public frmMusteri()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dgridMusteri.DataSource=dbNortwind.tblMusteri.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tblMusteri tbl=new tblMusteri();

            tbl.Ad = tBoxAd.Text;
            tbl.Soyad=tBoxSoyad.Text;
            tbl.Bakiye=decimal.Parse(tBoxBakiye.Text);
            tbl.Sehir=tBoxSehir.Text;

            dbNortwind.tblMusteri.Add(tbl);
            dbNortwind.SaveChanges();

            MessageBox.Show("Yeni müşteri kaydı eklendi!");

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id= int.Parse(tBoxId.Text);
            var x = dbNortwind.tblMusteri.Find(id);
            dbNortwind.tblMusteri.Remove(x);
            dbNortwind.SaveChanges();
            MessageBox.Show("Seçilen Kayıt Silindi!");
        }
    }
}
