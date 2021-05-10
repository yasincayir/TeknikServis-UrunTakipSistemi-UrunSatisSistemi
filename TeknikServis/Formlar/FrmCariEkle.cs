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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        int secilen;
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TblCari t = new TblCari();
                t.AD = textad.Text;
                t.SOYAD = textsoyad.Text;
                t.İL = lookUpEdit1.Text;
                t.BANKA = textBanka.Text;
                t.MAİL = textMail.Text;
                t.TELEFON = textTelefon.Text;
                t.VERGİDAİRESİ = textVergiDaire.Text;
                t.VERGİNO = textVergiNo.Text;
                t.İLÇE = lookUpEdit2.Text;
                db.TblCari.Add(t);
                db.SaveChanges();
                MessageBox.Show("Cari Başarıyla Eklendi");
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!");
            }
            
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCariEkle_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TblIller
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir
                                                 }).ToList();


        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

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
    }
}
