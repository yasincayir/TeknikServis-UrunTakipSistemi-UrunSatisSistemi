using System;
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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblUrun t = new TblUrun();
            t.AD = textÜrünAd.Text;
            t.MARKA = textMarka.Text;
            t.ALIŞFİYAT =decimal.Parse( textAlısFiyat.Text);
            t.SATIŞFİYAT = decimal.Parse(textSatısFiyat.Text);
            t.STOK =short.Parse( textStok.Text);
            t.KATEGORİ = byte.Parse(lookUpkategori.EditValue.ToString());
            db.TblUrun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürünler Başarıyla kaydedildi");
        }

        private void textÜrünAd_Click(object sender, EventArgs e)
        {
            textÜrünAd.Text = "";
            textÜrünAd.Focus();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            
            lookUpkategori.Properties.DataSource = (from x in db.TblKategori
                                                    select new
                                                    {
                                                        x.ID,
                                                        x.AD
                                                    }).ToList();
        }

        private void textMarka_Click(object sender, EventArgs e)
        {
            textMarka.Text = "";
        }

        private void textAlısFiyat_Click(object sender, EventArgs e)
        {
            textAlısFiyat.Text = "";
        }

        private void textSatısFiyat_Click(object sender, EventArgs e)
        {
            textSatısFiyat.Text = "";
        }

        private void textStok_Click(object sender, EventArgs e)
        {
            textStok.Text = "";
        }
    }
}
