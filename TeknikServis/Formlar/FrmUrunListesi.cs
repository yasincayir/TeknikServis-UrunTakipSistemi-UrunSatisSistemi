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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        void method1()
        {
            var degerler = from u in db.TblUrun
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               KATEGORI = u.TblKategori.AD,
                               u.ALIŞFİYAT,
                               u.SATIŞFİYAT,
                               u.STOK
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            //var degerler = db.TblUrun.ToList();
            method1();
            lookUpkategori.Properties.DataSource = (from x in db.TblKategori
                                                    select new
                                                    {
                                                        x.ID,
                                                        x.AD
                                                    }).ToList();
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            TblUrun t = new TblUrun();
            t.AD = texturunadi.Text;
            t.MARKA = textmarka.Text;
            t.ALIŞFİYAT = decimal.Parse(textalisfiyat.Text);
            t.SATIŞFİYAT = decimal.Parse(textsatisfiyat.Text);
            t.KATEGORİ = byte.Parse(lookUpkategori.EditValue.ToString());
            t.DURUM = false;
            t.STOK = short.Parse(textstok.Text);
            db.TblUrun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürünler başarıyla kaydedildi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButtonListele_Click(object sender, EventArgs e)
        {
            method1();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                textID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                texturunadi.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                textmarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
                textalisfiyat.Text = gridView1.GetFocusedRowCellValue("ALIŞFİYAT").ToString();
                textsatisfiyat.Text = gridView1.GetFocusedRowCellValue("SATIŞFİYAT").ToString();
                textstok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
                //lookUpkategori.Text = gridView1.GetFocusedRowCellValue("KATEGORİ").ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!");
            }

        }

    private void simpleButtonSil_Click(object sender, EventArgs e)
    {
        int id = int.Parse(textID.Text);
        var deger = db.TblUrun.Find(id);
        db.TblUrun.Remove(deger);
        db.SaveChanges();
        MessageBox.Show("Ürün Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
    }

    private void simpleButtonGüncelle_Click(object sender, EventArgs e)
    {
        int id = int.Parse(textID.Text);
        var deger = db.TblUrun.Find(id);
        deger.AD = texturunadi.Text;
        deger.MARKA = textmarka.Text;
        deger.ALIŞFİYAT = decimal.Parse(textalisfiyat.Text);
        deger.SATIŞFİYAT = decimal.Parse(textsatisfiyat.Text);
        deger.KATEGORİ = byte.Parse(lookUpkategori.EditValue.ToString());
        deger.STOK = short.Parse(textstok.Text);
        db.SaveChanges();
        MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }

    private void BtnTemizle_Click(object sender, EventArgs e)
    {
        textalisfiyat.Text = "";
        textID.Text = "";
        textmarka.Text = "";
        textsatisfiyat.Text = "";
        textstok.Text = "";
        texturunadi.Text = "";
    }
}
}
