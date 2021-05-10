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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            gridControl2.DataSource = (from x in db.TblUrun
                                       select new
                                       {
                                           x.AD,
                                           x.MARKA,
                                           x.STOK
                                       }).Where(x => x.STOK < 50).ToList();
            gridControl6.DataSource = (from i in db.TblCari
                                       select new
                                       {
                                           i.AD,
                                           i.SOYAD,
                                           i.İL
                                       }).ToList();
            gridControl5.DataSource = db.urunkategori().ToList();

            DateTime bugun = DateTime.Today;
            var deger = (from x in db.TblNotlarım.OrderBy(y => y.ID)
                         where (x.TARİH == bugun)
                         select new
                         {
                             x.BAŞLIK,
                             x.İÇERİK
                         });
            gridControl7.DataSource = deger.ToList();

            string konu1, ad1, konu2, ad2, konu3, ad3, konu4, ad4, konu5, ad5;

            konu1 = db.Tblİletisim.First(x => x.ID == 1).KONU;
            ad1 = db.Tblİletisim.First(x => x.ID == 1).ADSOYAD;
            labelControl1.Text = konu1 + " - " + ad1;

            konu2 = db.Tblİletisim.First(x => x.ID == 2).KONU;
            ad2 = db.Tblİletisim.First(x => x.ID == 2).ADSOYAD;
            labelControl2.Text = konu2 + " - " + ad2;

            konu3 = db.Tblİletisim.First(x => x.ID == 3).KONU;
            ad3 = db.Tblİletisim.First(x => x.ID == 3).ADSOYAD;
            labelControl3.Text = konu3 + " - " + ad3;

            konu4 = db.Tblİletisim.First(x => x.ID == 4).KONU;
            ad4 = db.Tblİletisim.First(x => x.ID == 4).ADSOYAD;
            labelControl4.Text = konu4 + " - " + ad4;

            konu5 = db.Tblİletisim.First(x => x.ID == 5).KONU;
            ad5 = db.Tblİletisim.First(x => x.ID == 5).ADSOYAD;
            labelControl5.Text = konu5 + " - " + ad5;



        }
    }
}
