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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TblDepartman
                           select new
                           {
                               u.ID,
                               u.AD
                                
                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl19.Text = db.TblDepartman.Count().ToString();
            labelControl12.Text= db.TblPersonel.Count().ToString();
        }

        private void simpleButtonKaydet_Click(object sender, EventArgs e)
        {
            TblDepartman t = new TblDepartman();
            if(textad.Text.Length<=50 && textad.Text!="" && richTextBox1.Text.Length >= 1)
            {
                t.AD = textad.Text;
                t.AÇIKLAMA = richTextBox1.Text;
                db.TblDepartman.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Kaydedildi");
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı! Alanları Tekrar Kontrol Edin","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void simpleButtonSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var deger = db.TblDepartman.Find(id);
            db.TblDepartman.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void simpleButtonGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var deger = db.TblDepartman.Find(id);
            deger.AD = textad.Text;
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButtonListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TblDepartman
                           select new
                           {
                               u.ID,
                               u.AD
                               
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
           // richTextBox1.Text = gridView1.GetFocusedRowCellValue("AÇIKLAMA").ToString();
        }
    }
}
