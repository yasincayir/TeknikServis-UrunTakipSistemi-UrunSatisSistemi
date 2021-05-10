
namespace TeknikServis.Formlar
{
    partial class FrmUrunListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunListesi));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.textID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonListele = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpkategori = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textstok = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textsatisfiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textalisfiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textmarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.texturunadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpkategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textstok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textsatisfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textalisfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textmarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texturunadi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(1, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1009, 550);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.MediumAquamarine;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnTemizle);
            this.groupControl1.Controls.Add(this.textID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.simpleButtonListele);
            this.groupControl1.Controls.Add(this.simpleButtonGüncelle);
            this.groupControl1.Controls.Add(this.simpleButtonSil);
            this.groupControl1.Controls.Add(this.simpleButtonKaydet);
            this.groupControl1.Controls.Add(this.lookUpkategori);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.textstok);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.textsatisfiyat);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textalisfiyat);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textmarka);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.texturunadi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1016, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(354, 550);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Ürün İşlemleri";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTemizle.ImageOptions.Image")));
            this.BtnTemizle.Location = new System.Drawing.Point(101, 463);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(149, 38);
            this.BtnTemizle.TabIndex = 21;
            this.BtnTemizle.Text = "TEMİZLE";
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(91, 39);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(159, 20);
            this.textID.TabIndex = 20;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(32, 42);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "ÜRÜN ID:";
            // 
            // simpleButtonListele
            // 
            this.simpleButtonListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonListele.ImageOptions.Image")));
            this.simpleButtonListele.Location = new System.Drawing.Point(101, 410);
            this.simpleButtonListele.Name = "simpleButtonListele";
            this.simpleButtonListele.Size = new System.Drawing.Size(149, 38);
            this.simpleButtonListele.TabIndex = 18;
            this.simpleButtonListele.Text = "LİSTELE";
            this.simpleButtonListele.Click += new System.EventHandler(this.simpleButtonListele_Click);
            // 
            // simpleButtonGüncelle
            // 
            this.simpleButtonGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGüncelle.ImageOptions.Image")));
            this.simpleButtonGüncelle.Location = new System.Drawing.Point(101, 357);
            this.simpleButtonGüncelle.Name = "simpleButtonGüncelle";
            this.simpleButtonGüncelle.Size = new System.Drawing.Size(149, 38);
            this.simpleButtonGüncelle.TabIndex = 17;
            this.simpleButtonGüncelle.Text = "GÜNCELLE";
            this.simpleButtonGüncelle.Click += new System.EventHandler(this.simpleButtonGüncelle_Click);
            // 
            // simpleButtonSil
            // 
            this.simpleButtonSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSil.ImageOptions.Image")));
            this.simpleButtonSil.Location = new System.Drawing.Point(101, 302);
            this.simpleButtonSil.Name = "simpleButtonSil";
            this.simpleButtonSil.Size = new System.Drawing.Size(149, 38);
            this.simpleButtonSil.TabIndex = 16;
            this.simpleButtonSil.Text = "SİL";
            this.simpleButtonSil.Click += new System.EventHandler(this.simpleButtonSil_Click);
            // 
            // simpleButtonKaydet
            // 
            this.simpleButtonKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonKaydet.ImageOptions.Image")));
            this.simpleButtonKaydet.Location = new System.Drawing.Point(101, 245);
            this.simpleButtonKaydet.Name = "simpleButtonKaydet";
            this.simpleButtonKaydet.Size = new System.Drawing.Size(149, 38);
            this.simpleButtonKaydet.TabIndex = 15;
            this.simpleButtonKaydet.Text = "KAYDET";
            this.simpleButtonKaydet.Click += new System.EventHandler(this.simpleButtonKaydet_Click);
            // 
            // lookUpkategori
            // 
            this.lookUpkategori.Location = new System.Drawing.Point(91, 195);
            this.lookUpkategori.Name = "lookUpkategori";
            this.lookUpkategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpkategori.Properties.DisplayMember = "AD";
            this.lookUpkategori.Properties.ValueMember = "ID";
            this.lookUpkategori.Size = new System.Drawing.Size(159, 20);
            this.lookUpkategori.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(34, 198);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "KATEGORİ:";
            // 
            // textstok
            // 
            this.textstok.Location = new System.Drawing.Point(91, 169);
            this.textstok.Name = "textstok";
            this.textstok.Size = new System.Drawing.Size(159, 20);
            this.textstok.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(55, 172);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "STOK:";
            // 
            // textsatisfiyat
            // 
            this.textsatisfiyat.Location = new System.Drawing.Point(91, 143);
            this.textsatisfiyat.Name = "textsatisfiyat";
            this.textsatisfiyat.Size = new System.Drawing.Size(159, 20);
            this.textsatisfiyat.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(20, 146);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "SATIŞ FİYAT:";
            // 
            // textalisfiyat
            // 
            this.textalisfiyat.Location = new System.Drawing.Point(91, 117);
            this.textalisfiyat.Name = "textalisfiyat";
            this.textalisfiyat.Size = new System.Drawing.Size(159, 20);
            this.textalisfiyat.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "ALIŞ FİYAT:";
            // 
            // textmarka
            // 
            this.textmarka.Location = new System.Drawing.Point(91, 91);
            this.textmarka.Name = "textmarka";
            this.textmarka.Size = new System.Drawing.Size(159, 20);
            this.textmarka.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "MARKA:";
            // 
            // texturunadi
            // 
            this.texturunadi.Location = new System.Drawing.Point(91, 65);
            this.texturunadi.Name = "texturunadi";
            this.texturunadi.Size = new System.Drawing.Size(159, 20);
            this.texturunadi.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "ÜRÜN ADI:";
            // 
            // FrmUrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmUrunListesi";
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.FrmUrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpkategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textstok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textsatisfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textalisfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textmarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texturunadi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGüncelle;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSil;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
        private DevExpress.XtraEditors.LookUpEdit lookUpkategori;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textstok;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textsatisfiyat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textalisfiyat;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textmarka;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit texturunadi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonListele;
        private DevExpress.XtraEditors.TextEdit textID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton BtnTemizle;
    }
}