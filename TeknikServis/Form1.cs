using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       Formlar.FrmUrunListesi fr3;
        private void BtnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null || fr3.IsDisposed)
            {
                fr3 = new Formlar.FrmUrunListesi();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
        Formlar.FrmYeniUrun fr27;
        private void BtnYeniÜrün_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr27 == null || fr27.IsDisposed)
            {
                fr27 = new Formlar.FrmYeniUrun();
                //fr.MdiParent = this;
                fr27.Show();
            }
                
        }
        Formlar.FrmKategori fr2;
        private void BtnKategoriListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null || fr2.IsDisposed)
            {
                fr2=new Formlar.FrmKategori();
                fr2.MdiParent = this;
                fr2.Show();
            }
                
        }

        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniKategori fr = new Formlar.FrmYeniKategori();
            fr.Show();
        }
        Formlar.FrmIstatistik fr4;
        private void BtnIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null || fr4.IsDisposed)
            {
                fr4 = new Formlar.FrmIstatistik();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }
        Formlar.FrmMarkalar fr5;
        private void BtnMarkaİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)
            {
                fr5= new Formlar.FrmMarkalar();
                fr5.MdiParent = this;
                fr5.Show();
            }
                
        }
        Formlar.FrmCariListesi fr26;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr26 == null || fr26.IsDisposed)
            {
                fr26 = new Formlar.FrmCariListesi();
                fr26.MdiParent = this;
                fr26.Show();
            }
               
        }
        Formlar.FrmCariİller fr25;
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr25 == null || fr25.IsDisposed)
            {

                fr25 = new Formlar.FrmCariİller();
                fr25.MdiParent = this;
                fr25.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Formlar.FrmCariEkle fr = new Formlar.FrmCariEkle();
            fr.Show();
        }
        Formlar.FrmDepartman fr24;
        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr24 == null || fr24.IsDisposed)
            {

                fr24 = new Formlar.FrmDepartman();
                fr24.MdiParent = this;
                fr24.Show();
            }
        }
        Formlar.FrmYeniDepartman fr23;
        private void BtnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr23 == null || fr23.IsDisposed)
            {
                fr23 = new Formlar.FrmYeniDepartman();
                fr23.MdiParent = this;
                fr23.Show();
            }
               
        }
        Formlar.FrmPersonel fr22;
        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr22 == null || fr22.IsDisposed)
            {
                fr22 = new Formlar.FrmPersonel();
                fr22.MdiParent = this;
                fr22.Show();
            }
               
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
        Formlar.FrmKurlar fr21;
        private void BtnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr21 == null || fr21.IsDisposed)
            {
                fr21 = new Formlar.FrmKurlar();
                fr21.MdiParent = this;
                fr21.Show();
            }
                
        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }
        Formlar.FrmYoutube fr20;
        private void BtnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr20 == null || fr6.IsDisposed)
            {
                fr20 = new Formlar.FrmYoutube();
                fr20.MdiParent = this;
                fr20.Show();
            }
        }
        Formlar.FrmNotlar fr19;
        private void BtnNotListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr19 == null || fr19.IsDisposed)
            {
                fr19 = new Formlar.FrmNotlar();
                fr19.MdiParent = this;
                fr19.Show();
            }
        }
        Formlar.FrmArizaListesi fr6;
        private void BtnArizaliÜrünListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null || fr6.IsDisposed)
            {
                fr6 =new Formlar.FrmArizaListesi();
                fr6.MdiParent = this;
                fr6.Show();
            }
                
        }
        Formlar.FrmUrunSatis fr18;
        private void BtnÜrünSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr18 == null || fr18.IsDisposed)
            {
                fr18 = new Formlar.FrmUrunSatis();
                //fr.MdiParent = this;
                fr18.Show();
            }
               
        }
        Formlar.FrmSatislar fr17;
        private void BtnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr17 == null || fr17.IsDisposed)
            {

                fr17 = new Formlar.FrmSatislar();
                fr17.MdiParent = this;
                fr17.Show();
            }
        }
        Formlar.FrmArizaliUrunKaydi fr16;
        private void BtnYeniArizaliUrunKaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr16 == null || fr16.IsDisposed)
            {
                fr16 = new Formlar.FrmArizaliUrunKaydi();
                //fr.MdiParent = this;
                fr16.Show();
            }
                
        }
        Formlar.FrmArizaDetaylar fr15;
        private void BtnArizaliUrunAciklama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr15 == null || fr15.IsDisposed)
            {
                fr15 = new Formlar.FrmArizaDetaylar();
                //fr.MdiParent = this;
                fr15.Show();
            }
                
        }
        Formlar.FrmArizaliUrunDetayListesi fr7;
        private void BtnArizaliDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null || fr7.IsDisposed)
            {
                fr7 = new Formlar.FrmArizaliUrunDetayListesi();
                fr7.MdiParent = this;
                fr7.Show();
            }
                
        }
        Formlar.FrmQrKod fr8;
        private void BtnQrKodOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null || fr8.IsDisposed)
            {
                fr8 = new Formlar.FrmQrKod();
                //fr.MdiParent = this;
                fr8.Show();
            }
                
        }
        Formlar.FrmFaturaListesi fr9;
        private void BtnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null || fr9.IsDisposed)
            {
                fr9 = new Formlar.FrmFaturaListesi();
                fr9.MdiParent = this;
                fr9.Show();
            }
                
        }
        Formlar.FrmFaturaKalem fr10;
        private void BtnFaturaKalem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null || fr10.IsDisposed)
            {
                fr10 = new Formlar.FrmFaturaKalem();
                fr10.MdiParent = this;
                fr10.Show();
            }
                
        }
        Formlar.FrmFaturaKalemleri fr11;
        private void BtnFaturaKalemListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null || fr11.IsDisposed)
            {
                fr11 = new Formlar.FrmFaturaKalemleri();
                fr11.MdiParent = this;
                fr11.Show();
            }
               
        }
        Formlar.FrmGauge fr12;
        private void BtnHakkımızda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null || fr12.IsDisposed)
            {
                fr12 = new Formlar.FrmGauge();
                fr12.MdiParent = this;
                fr12.Show();
            }
                
        }
        Formlar.FrmHarita fr13;
        private void BtnHaritalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null || fr.IsDisposed)
            {
                fr13 = new Formlar.FrmHarita();
                fr13.MdiParent = this;
                fr13.Show();
            }

        }
        Formlar.FrmRapor fr14;
        private void BtnRaporSihirbazı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14 == null || fr14.IsDisposed)
            {
                fr14 = new Formlar.FrmRapor();
                //fr.MdiParent = this;
                fr14.Show();
            }
               
        }
        Formlar.FrmAnasayfa fr;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (fr == null || fr.IsDisposed) 
            {
                fr = new Formlar.FrmAnasayfa();
                fr.MdiParent = this;
                fr.Show();
            }

        }


        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAnasayfa();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        İletişim.FrmRehber frm;
        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                fr = new Formlar.FrmAnasayfa();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        İletişim.FrmGelenMesajlar frm2;
        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new İletişim.FrmGelenMesajlar();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            İletişim.FrmMail fr = new İletişim.FrmMail();
            fr.Show();
        }
    }
}
