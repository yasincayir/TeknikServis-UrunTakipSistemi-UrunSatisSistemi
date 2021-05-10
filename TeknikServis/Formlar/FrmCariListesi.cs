using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeknikServis.Formlar
{
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int secilen;

        void liste()
        {
            var degerler = from x in db.TblCari
                           select new
                           {
                               x.ID,
                               x.AD,
                               x.SOYAD,
                               x.İL,
                               x.İLÇE,
                               x.MAİL,
                               x.TELEFON

                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {

            liste();
            labelControl19.Text = db.TblCari.Count().ToString();

            lookUpEdit1.Properties.DataSource = (from x in db.TblIller
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir
                                                 }).ToList();
            labelControl14.Text = db.TblCari.Select(x => x.İL).Distinct().Count().ToString();
            labelControl16.Text = db.TblCari.Select(x => x.İLÇE).Distinct().Count().ToString();

            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VREQ9PN\SQLEXPRESS;Initial Catalog=DbTeknikServis;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT TOP 1 İL FROM TblCari GROUP BY İL ORDER BY COUNT(*) DESC", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelControl12.Text = dr[0].ToString();
            }
            baglanti.Close();

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            secilen = byte.Parse(lookUpEdit1.EditValue.ToString());
            lookUpEdit2.Properties.DataSource = (from y in db.TblIlceler
                                                 select new
                                                 {
                                                     y.id,
                                                     y.ilce,
                                                     y.sehir
                                                 }).Where(z => z.sehir == secilen).ToList();
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            if (textAd.Text!="" & textSoyad.Text!="" & textAd.Text.Length <=20)
            {
                TblCari t = new TblCari();
                t.AD = textAd.Text;
                t.SOYAD = textSoyad.Text;
                t.İL = lookUpEdit1.Text;
                t.İLÇE = lookUpEdit2.Text;
                db.TblCari.Add(t);
                db.SaveChanges();
                MessageBox.Show("Cari Sisteme Eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                liste();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yeniden Deneyin!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
