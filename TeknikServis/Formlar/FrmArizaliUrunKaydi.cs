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
    public partial class FrmArizaliUrunKaydi : Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            TblUrunKabul t = new TblUrunKabul();
            t.CARİ = int.Parse(lookUpkategori.EditValue.ToString());
            t.GELİŞTARİHİ = DateTime.Parse(textTarih.Text);
            t.URUNDURUMDETAY = "Ürün Kaydoldu";
            t.PERSONEL = short.Parse(lookUpkategori.EditValue.ToString());
            t.ÜRÜNSERİNO = textSerino.Text;
            db.TblUrunKabul.Add(t);
            db.SaveChanges();
            MessageBox.Show("Arızalı Ürün Kaydı Oluşturuldu");
        }

        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            //Müşteri
            lookUpkategori.Properties.DataSource = (from x in db.TblCari
                                                    select new
                                                    {
                                                        x.ID,
                                                        İSİM=x.AD +" "+x.SOYAD
                                                    }).ToList();

            //Personel
            lookUpEdit2.Properties.DataSource = (from x in db.TblPersonel
                                                    select new
                                                    {
                                                        x.ID,
                                                        İSİM = x.AD + " " + x.SOYAD
                                                    }).ToList();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textTarih_Click(object sender, EventArgs e)
        {
            textTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
