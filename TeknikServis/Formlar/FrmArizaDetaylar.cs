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
    public partial class FrmArizaDetaylar : Form
    {
        public FrmArizaDetaylar()
        {
            InitializeComponent();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            TblUrunTakip t = new TblUrunTakip();
            t.ACIKLAMA = richTextBox1.Text;
            t.SERİNO = textSeriNo.Text;
            t.TARİH = DateTime.Parse( textTarih.Text);
            db.TblUrunTakip.Add(t);
            

            //2.GÜNCELLEME
            TblUrunKabul tb = new TblUrunKabul();
            int urunid = int.Parse(id.ToString());
            var deger = db.TblUrunKabul.Find(urunid);
            deger.URUNDURUMDETAY = comboBox1.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Arıza Detayları Güncellendi");
        }

        private void textMarka_Click(object sender, EventArgs e)
        {
            textSeriNo.Text = "";
        }

        private void textTarih_Click(object sender, EventArgs e)
        {
            textTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string id,serino;
        private void FrmArizaDetaylar_Load(object sender, EventArgs e)
        {
            textSeriNo.Text = serino;
        }
    }
}
