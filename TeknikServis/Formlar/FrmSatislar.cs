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
    public partial class FrmSatislar : Form
    {
        public FrmSatislar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmSatislar_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TblUrunHareket
                           select new
                           {
                               x.HAREKETID,
                               x.TblUrun.AD,
                               MUSTERİ = x.TblCari.AD +" "+ x.TblCari.SOYAD,
                               PERSONEL = x.TblPersonel.AD +" "+ x.TblPersonel.SOYAD,
                               x.TARİH,
                               x.ADET,
                               x.FİYAT,
                               x.ÜRÜNSERİNO
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
