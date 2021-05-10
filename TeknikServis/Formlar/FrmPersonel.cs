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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            var degerler = from k in db.TblPersonel
                           select new
                           {
                               k.ID,
                               k.AD,
                               k.SOYAD,
 
                           };
            gridControl1.DataSource = degerler.ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.TblDepartman
                                                select new
                                                {
                                                    x.ID,
                                                    x.AD
                                                }).ToList();
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            TblPersonel t = new TblPersonel();
            if (t.AD!="" & t.SOYAD!="")
            {
                t.AD = textAd.Text;
                t.SOYAD = textSoyad.Text;
                t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.TblPersonel.Add(t);
                db.SaveChanges();
                MessageBox.Show("Personel Sisteme Eklendi","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                liste();
            }
            else
            {
                MessageBox.Show("HATA Bilgileri Tekrar Kontrol Edin!", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        void liste()
        {
            var degerler = from k in db.TblPersonel
                           select new
                           {
                               k.ID,
                               k.AD,
                               k.SOYAD,

                           };
        gridControl1.DataSource = degerler.ToList();
        }
        private void simpleButtonListele_Click(object sender, EventArgs e)
        {
            liste();
        }
    }
}
