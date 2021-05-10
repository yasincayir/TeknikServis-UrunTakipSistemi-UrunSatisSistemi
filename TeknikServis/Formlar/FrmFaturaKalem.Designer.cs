
namespace TeknikServis.Formlar
{
    partial class FrmFaturaKalem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaKalem));
            this.textFaturaID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textAdet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.textID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonListele = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.textUrun = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.textFaturaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textFaturaID
            // 
            this.textFaturaID.Location = new System.Drawing.Point(94, 184);
            this.textFaturaID.Name = "textFaturaID";
            this.textFaturaID.Size = new System.Drawing.Size(194, 20);
            this.textFaturaID.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(38, 187);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 13);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Fatura ID:";
            // 
            // textTutar
            // 
            this.textTutar.Location = new System.Drawing.Point(94, 158);
            this.textTutar.Name = "textTutar";
            this.textTutar.Size = new System.Drawing.Size(194, 20);
            this.textTutar.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(58, 161);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 13);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Tutar:";
            // 
            // textFiyat
            // 
            this.textFiyat.Location = new System.Drawing.Point(94, 132);
            this.textFiyat.Name = "textFiyat";
            this.textFiyat.Size = new System.Drawing.Size(194, 20);
            this.textFiyat.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(60, 135);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Fiyat:";
            // 
            // textAdet
            // 
            this.textAdet.Location = new System.Drawing.Point(94, 106);
            this.textAdet.Name = "textAdet";
            this.textAdet.Size = new System.Drawing.Size(194, 20);
            this.textAdet.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(61, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Adet:";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.MediumAquamarine;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(1, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(968, 535);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(94, 54);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(194, 20);
            this.textID.TabIndex = 20;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(41, 57);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Detay ID:";
            // 
            // simpleButtonListele
            // 
            this.simpleButtonListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonListele.ImageOptions.Image")));
            this.simpleButtonListele.Location = new System.Drawing.Point(94, 359);
            this.simpleButtonListele.Name = "simpleButtonListele";
            this.simpleButtonListele.Size = new System.Drawing.Size(184, 38);
            this.simpleButtonListele.TabIndex = 11;
            this.simpleButtonListele.Text = "LİSTELE";
            this.simpleButtonListele.Click += new System.EventHandler(this.simpleButtonListele_Click);
            // 
            // simpleButtonGüncelle
            // 
            this.simpleButtonGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGüncelle.ImageOptions.Image")));
            this.simpleButtonGüncelle.Location = new System.Drawing.Point(94, 315);
            this.simpleButtonGüncelle.Name = "simpleButtonGüncelle";
            this.simpleButtonGüncelle.Size = new System.Drawing.Size(184, 38);
            this.simpleButtonGüncelle.TabIndex = 10;
            this.simpleButtonGüncelle.Text = "GÜNCELLE";
            // 
            // simpleButtonSil
            // 
            this.simpleButtonSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSil.ImageOptions.Image")));
            this.simpleButtonSil.Location = new System.Drawing.Point(94, 271);
            this.simpleButtonSil.Name = "simpleButtonSil";
            this.simpleButtonSil.Size = new System.Drawing.Size(184, 38);
            this.simpleButtonSil.TabIndex = 9;
            this.simpleButtonSil.Text = "SİL";
            // 
            // simpleButtonKaydet
            // 
            this.simpleButtonKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonKaydet.ImageOptions.Image")));
            this.simpleButtonKaydet.Location = new System.Drawing.Point(94, 227);
            this.simpleButtonKaydet.Name = "simpleButtonKaydet";
            this.simpleButtonKaydet.Size = new System.Drawing.Size(184, 38);
            this.simpleButtonKaydet.TabIndex = 8;
            this.simpleButtonKaydet.Text = "KAYDET";
            this.simpleButtonKaydet.Click += new System.EventHandler(this.simpleButtonKaydet_Click);
            // 
            // textUrun
            // 
            this.textUrun.Location = new System.Drawing.Point(94, 80);
            this.textUrun.Name = "textUrun";
            this.textUrun.Size = new System.Drawing.Size(194, 20);
            this.textUrun.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(61, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Ürün:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textFaturaID);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.textTutar);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.textFiyat);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textAdet);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.simpleButtonListele);
            this.groupControl1.Controls.Add(this.simpleButtonGüncelle);
            this.groupControl1.Controls.Add(this.simpleButtonSil);
            this.groupControl1.Controls.Add(this.simpleButtonKaydet);
            this.groupControl1.Controls.Add(this.textUrun);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(975, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(395, 535);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "FATURA KALEM İŞLEMLERİ";
            // 
            // FrmFaturaKalem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmFaturaKalem";
            this.Text = "Fatura Kalem";
            this.Load += new System.EventHandler(this.FrmFaturaKalem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textFaturaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textFaturaID;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textTutar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textAdet;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.TextEdit textID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton simpleButtonListele;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGüncelle;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSil;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
        private DevExpress.XtraEditors.TextEdit textUrun;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}