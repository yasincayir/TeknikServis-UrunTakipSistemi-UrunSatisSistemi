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
    public partial class FrmFaturaKalemleri : Form
    {
        public FrmFaturaKalemleri()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnAra_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textFaturaId.Text);
            var degerler = (from k in db.TblFaturaDetay
                           select new
                           {
                               k.FATURADETAYID,
                               k.ÜRÜN,
                               k.ADET,
                               k.FİYAT,
                               k.TUTAR,
                               k.FATURAID,
                           }).Where(k=>k.FATURAID==id);
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
