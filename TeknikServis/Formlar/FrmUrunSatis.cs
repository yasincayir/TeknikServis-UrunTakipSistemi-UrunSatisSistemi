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
    public partial class FrmUrunSatis : Form
    {
        public FrmUrunSatis()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            TblUrunHareket t = new TblUrunHareket();
            t.URUN =int.Parse(lookUpEdit1.EditValue.ToString());
            t.MUSTERİ = byte.Parse(lookUpEdit2.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpEdit3.EditValue.ToString());
            t.TARİH = DateTime.Parse(textTarih.Text);
            t.ADET = short.Parse(textAdet.Text);
            t.FİYAT = decimal.Parse(textSatisFiyat.Text);
            t.ÜRÜNSERİNO = textSerino.Text;
            db.TblUrunHareket.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Başarıyla Gerçekleşti");
        }

        private void FrmUrunSatis_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TblUrun
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();
            lookUpEdit2.Properties.DataSource = (from x in db.TblCari
                                                 select new
                                                 {
                                                     x.ID,
                                                    AD=x.AD +" "+ x.SOYAD
                                                 }).ToList();
            lookUpEdit3.Properties.DataSource = (from x in db.TblPersonel
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
