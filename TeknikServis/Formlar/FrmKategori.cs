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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            var degerler = from k in db.TblKategori
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            if(textad.Text!="" && textad.Text.Length <=30)
            {
                TblKategori t = new TblKategori();
                t.AD = textad.Text;
                db.TblKategori.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Kaydedildi");
            }
            else
            {
                MessageBox.Show("Kategori Adı boş geçilemez ve Kategori Uzunluğu 30 karakterden uzun olamaz!");
            }
            
        }

        private void simpleButtonListele_Click(object sender, EventArgs e)
        {
            var degerler = from k in db.TblKategori
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButtonSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var deger = db.TblKategori.Find(id);
            db.TblKategori.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void simpleButtonGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var deger = db.TblKategori.Find(id);
            deger.AD = textad.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            textad.Text = "";
            textID.Text = "";
        }

    }
}
