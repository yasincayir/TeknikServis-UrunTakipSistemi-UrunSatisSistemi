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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TblUrun.Count().ToString();
            labelControl3.Text = db.TblKategori.Count().ToString();
            labelControl5.Text = db.TblUrun.Sum(x => x.STOK).ToString();
            labelControl7.Text = "10";
            labelControl19.Text = (from x in db.TblUrun 
                                   orderby x.STOK descending 
                                   select x.AD).FirstOrDefault();
            labelControl17.Text= (from x in db.TblUrun
                                  orderby x.STOK ascending
                                  select x.AD).FirstOrDefault();
            labelControl13.Text = (from x in db.TblUrun
                                   orderby x.SATIŞFİYAT descending
                                   select x.AD).FirstOrDefault();
            labelControl11.Text= (from x in db.TblUrun
                                  orderby x.SATIŞFİYAT ascending
                                  select x.AD).FirstOrDefault();
            labelControl25.Text = db.TblUrun.Count(x=>x.KATEGORİ==4).ToString();
            labelControl23.Text= db.TblUrun.Count(x => x.KATEGORİ == 1).ToString();
            labelControl21.Text = db.TblUrun.Count(x => x.KATEGORİ == 3).ToString();
            labelControl39.Text = (from x in db.TblUrun select x.MARKA).Distinct().Count().ToString();
            labelControl35.Text = db.TblUrunKabul.Count().ToString();
            labelControl15.Text = db.makskategoriurun().FirstOrDefault();
        }
    }
}
