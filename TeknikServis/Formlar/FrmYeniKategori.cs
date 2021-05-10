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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if(textKategoriAd.Text!="" && textKategoriAd.Text.Length <= 30)
            {
                TblKategori t = new TblKategori();
                t.AD = textKategoriAd.Text;
                db.TblKategori.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Kaydedildi");
            }
            else
            {
                MessageBox.Show("Lütfen karakter sayısını 0-30 arasında girin","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
