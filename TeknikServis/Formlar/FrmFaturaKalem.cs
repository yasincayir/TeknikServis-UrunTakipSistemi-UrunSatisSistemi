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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            TblFaturaDetay t = new TblFaturaDetay();
            t.ÜRÜN = textUrun.Text;
            t.ADET = short.Parse(textAdet.Text);
            t.FİYAT = decimal.Parse(textFiyat.Text);
            t.TUTAR = decimal.Parse(textTutar.Text);
            t.FATURAID = int.Parse(textFaturaID.Text);
            db.TblFaturaDetay.Add(t);
            db.SaveChanges();
            MessageBox.Show("Faturaya Ait Kalem Girişi Başarıyla Yapıldı");
        }

        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            var degerler = from k in db.TblFaturaDetay
                           select new
                           {
                               k.FATURADETAYID,
                               k.ÜRÜN,
                               k.ADET,
                               k.FİYAT,
                               k.TUTAR,
                               k.FATURAID,
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void simpleButtonListele_Click(object sender, EventArgs e)
        {
            var degerler = from k in db.TblFaturaDetay
                           select new
                           {
                               k.FATURADETAYID,
                               k.ÜRÜN,
                               k.ADET,
                               k.FİYAT,
                               k.TUTAR,
                               k.FATURAID,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
