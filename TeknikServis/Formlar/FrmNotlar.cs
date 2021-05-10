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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TblNotlarım.Where(x => x.OKUMA == false).ToList();
            gridControl2.DataSource = db.TblNotlarım.Where(y => y.OKUMA == true).ToList();
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            TblNotlarım t = new TblNotlarım();
            t.BAŞLIK = textBaslik.Text;
            t.İÇERİK = texticerik.Text;
            t.OKUMA = false;
            t.TARİH =DateTime.Parse( textEdit1.Text);
            db.TblNotlarım.Add(t);
            db.SaveChanges();
            MessageBox.Show("Notlar Başarıyla Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void simpleButtonListele_Click(object sender, EventArgs e)
        {

            gridControl1.DataSource = db.TblNotlarım.Where(x => x.OKUMA == false).ToList();
            gridControl2.DataSource = db.TblNotlarım.Where(y => y.OKUMA == true).ToList();
        }

        private void simpleButtonGüncelle_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                int id = int.Parse(textID.Text);
                var deger = db.TblNotlarım.Find(id);
                deger.OKUMA = true;

                db.SaveChanges();
                MessageBox.Show("Not Durumu Değiştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }
    }
}
