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
    public partial class FrmArizaliUrunDetayListesi : Form
    {
        public FrmArizaliUrunDetayListesi()
        {
            InitializeComponent();
        }

        private void FrmArizaliUrunDetayListesi_Load(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            gridControl1.DataSource = (from x in db.TblUrunTakip
                                      select new
                                      {
                                          x.TAKIPID,
                                          x.SERİNO,
                                          x.TARİH,
                                          x.ACIKLAMA
                                      }).ToList();
        }
    }
}
