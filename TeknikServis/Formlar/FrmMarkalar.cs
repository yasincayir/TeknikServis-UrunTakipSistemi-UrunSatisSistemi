using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void gridControl1_Click(object sender, EventArgs e)
        {
            var degerler = db.TblUrun.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TblUrun.Count().ToString();
            labelControl3.Text=db.marksurunmarka().FirstOrDefault();
            labelControl3.Text = (from x in db.TblUrun select x.MARKA).Distinct().Count().ToString();
            labelControl7.Text = (from x in db.TblUrun orderby x.SATIŞFİYAT descending select x.MARKA).FirstOrDefault();

            //1.CHART
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-VREQ9PN\SQLEXPRESS;Initial Catalog=DbTeknikServis;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT MARKA,COUNT(*) FROM TblUrun GROUP BY MARKA",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString( dr[0]),int.Parse( dr[1].ToString()));
            }
            baglanti.Close();

            // 2.CHART
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT TblKategori.AD,COUNT(*) FROM TblUrun " +
                "INNER JOIN TblKategori ON TblKategori.ID=TblUrun.KATEGORİ GROUP BY TblKategori.AD", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            baglanti.Close();

        }
    }
}
