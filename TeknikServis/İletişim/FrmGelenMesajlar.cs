using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.İletişim
{
    public partial class FrmGelenMesajlar : Form
    {
        public FrmGelenMesajlar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmGelenMesajlar_Load(object sender, EventArgs e)
        {
            labelControl19.Text = db.Tblİletisim.Count().ToString();
            labelControl12.Text = db.Tblİletisim.Where(x => x.KONU == "Teşekkür").Count().ToString();
            labelControl1.Text = db.Tblİletisim.Where(x => x.KONU == "Rica").Count().ToString();
            labelControl5.Text = db.Tblİletisim.Where(x => x.KONU == "Şikayet").Count().ToString();

            gridControl1.DataSource = (from x in db.Tblİletisim
                                       select new
                                       {
                                           x.ID,
                                           x.ADSOYAD,
                                           x.KONU,
                                           x.MAİL,
                                           x.MESAJ
                                       }).ToList();
        }
    }
}
