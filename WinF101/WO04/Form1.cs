﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WO04
{
    public partial class frmAtm : Form
    {
        public frmAtm()
        {
            InitializeComponent();
        }

        #region Çıkış Butonu
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
