﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projee3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmDepartmanlar frm = new Formlar.FrmDepartmanlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersoneller frm2 = new Formlar.FrmPersoneller();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void BtnPersonelistatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersonelistatistik frm3 = new Formlar.FrmPersonelistatistik();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void BtnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevListesi frm4 = new Formlar.FrmGorevListesi();
            frm4.MdiParent = this;
            frm4.Show();
        }
    }
}