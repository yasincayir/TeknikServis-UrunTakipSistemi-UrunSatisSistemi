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
    public partial class FrmYeniDepartman : Form
    {
        public FrmYeniDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblDepartman t = new TblDepartman();
            if (textad.Text.Length <= 50 && textad.Text != "")
            {
                t.AD = textad.Text;
                db.TblDepartman.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Kaydedildi");
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı! Alanları Tekrar Kontrol Edin", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
