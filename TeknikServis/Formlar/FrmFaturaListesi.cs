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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from k in db.TblFaturaBilgi
                           select new
                           {
                               k.ID,
                               k.SERİ,
                               k.SIRANO,
                               k.TARİH,
                               k.SAAT,
                               k.VERGİDAİRE,
                               CARİ=k.TblCari.AD +" "+ k.TblCari.SOYAD,
                               PERSONEL= k.TblPersonel.AD +" "+ k.TblPersonel.SOYAD
                           };
            gridControl1.DataSource = degerler.ToList();
            lookUpCari.Properties.DataSource = (from x in db.TblCari
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD=x.AD +" "+x.SOYAD
                                                 }).ToList();
            lookUpPersonel.Properties.DataSource = (from x in db.TblPersonel
                                                select new
                                                {
                                                    x.ID,
                                                    AD = x.AD + " " + x.SOYAD
                                                }).ToList();
        }

        private void simpleButtonListele_Click(object sender, EventArgs e)
        {
            var degerler = from k in db.TblFaturaBilgi
                           select new
                           {
                               k.ID,
                               k.SERİ,
                               k.SIRANO,
                               k.TARİH,
                               k.SAAT,
                               k.VERGİDAİRE,
                               CARİ = k.TblCari.AD + " " + k.TblCari.SOYAD,
                               PERSONEL = k.TblPersonel.AD + " " + k.TblPersonel.SOYAD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            TblFaturaBilgi t = new TblFaturaBilgi();
            t.SERİ = textseri.Text;
            t.SIRANO = textsırano.Text;
            t.TARİH = Convert.ToDateTime(texttarih.Text);
            t.SAAT = textsaat.Text;
            t.VERGİDAİRE = textvergidaire.Text;
            t.CARİ = int.Parse(lookUpCari.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpPersonel.EditValue.ToString());
            db.TblFaturaBilgi.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Sisteme Kaydedilmiştir.Kalem Girişi Yapabilirsiniz");
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopup fr = new FrmFaturaKalemPopup();
            fr.id =int.Parse( gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
