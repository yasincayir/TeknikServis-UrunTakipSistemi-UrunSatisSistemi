﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmFaturaKalemPopup : Form
    {
        public FrmFaturaKalemPopup()
        {
            InitializeComponent();
        }
        public int id;
        private void FrmFaturaKalemPopup_Load(object sender, EventArgs e)
        {
            //label1.Text = id.ToString();
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            gridControl1.DataSource = db.TblFaturaDetay.Where(x => x.FATURAID == id).ToList();
            gridControl2.DataSource = db.TblFaturaBilgi.Where(x => x.ID == id).ToList();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.Pdf";
            gridControl1.ExportToPdf(path);
            MessageBox.Show("PDF Olarak dönüştürüldü", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureEdit3_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.xls";
            gridControl1.ExportToXls(path);
            MessageBox.Show("EXEL Olarak dönüştürüldü", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
