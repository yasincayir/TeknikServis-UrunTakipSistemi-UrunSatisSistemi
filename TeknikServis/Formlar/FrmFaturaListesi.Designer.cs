
namespace TeknikServis.Formlar
{
    partial class FrmFaturaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaListesi));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.textseri = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonSil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonListele = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.textID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpPersonel = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpCari = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textvergidaire = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textsaat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.texttarih = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textsırano = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textseri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textvergidaire.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textsaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texttarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textsırano.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textseri
            // 
            this.textseri.Location = new System.Drawing.Point(94, 49);
            this.textseri.Name = "textseri";
            this.textseri.Properties.Mask.EditMask = "A";
            this.textseri.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.textseri.Size = new System.Drawing.Size(194, 20);
            this.textseri.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(50, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Seri No:";
            // 
            // simpleButtonSil
            // 
            this.simpleButtonSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSil.ImageOptions.Image")));
            this.simpleButtonSil.Location = new System.Drawing.Point(94, 321);
            this.simpleButtonSil.Name = "simpleButtonSil";
            this.simpleButtonSil.Size = new System.Drawing.Size(184, 38);
            this.simpleButtonSil.TabIndex = 9;
            this.simpleButtonSil.Text = "SİL";
            // 
            // simpleButtonKaydet
            // 
            this.simpleButtonKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonKaydet.ImageOptions.Image")));
            this.simpleButtonKaydet.Location = new System.Drawing.Point(94, 277);
            this.simpleButtonKaydet.Name = "simpleButtonKaydet";
            this.simpleButtonKaydet.Size = new System.Drawing.Size(184, 38);
            this.simpleButtonKaydet.TabIndex = 8;
            this.simpleButtonKaydet.Text = "KAYDET";
            this.simpleButtonKaydet.Click += new System.EventHandler(this.simpleButtonKaydet_Click);
            // 
            // simpleButtonListele
            // 
            this.simpleButtonListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonListele.ImageOptions.Image")));
            this.simpleButtonListele.Location = new System.Drawing.Point(94, 409);
            this.simpleButtonListele.Name = "simpleButtonListele";
            this.simpleButtonListele.Size = new System.Drawing.Size(184, 38);
            this.simpleButtonListele.TabIndex = 11;
            this.simpleButtonListele.Text = "LİSTELE";
            this.simpleButtonListele.Click += new System.EventHandler(this.simpleButtonListele_Click);
            // 
            // simpleButtonGüncelle
            // 
            this.simpleButtonGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonGüncelle.ImageOptions.Image")));
            this.simpleButtonGüncelle.Location = new System.Drawing.Point(94, 365);
            this.simpleButtonGüncelle.Name = "simpleButtonGüncelle";
            this.simpleButtonGüncelle.Size = new System.Drawing.Size(184, 38);
            this.simpleButtonGüncelle.TabIndex = 10;
            this.simpleButtonGüncelle.Text = "GÜNCELLE";
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(94, 23);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(194, 20);
            this.textID.TabIndex = 20;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(9, 26);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(79, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "DEPARTMAN ID:";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.MediumAquamarine;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
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
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpPersonel);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.lookUpCari);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.textvergidaire);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.textsaat);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.texttarih);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textsırano);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.simpleButtonListele);
            this.groupControl1.Controls.Add(this.simpleButtonGüncelle);
            this.groupControl1.Controls.Add(this.simpleButtonSil);
            this.groupControl1.Controls.Add(this.simpleButtonKaydet);
            this.groupControl1.Controls.Add(this.textseri);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(975, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(395, 535);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "FATURA İŞLEMLERİ";
            // 
            // lookUpPersonel
            // 
            this.lookUpPersonel.Location = new System.Drawing.Point(94, 206);
            this.lookUpPersonel.Name = "lookUpPersonel";
            this.lookUpPersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPersonel.Properties.DisplayMember = "AD";
            this.lookUpPersonel.Properties.ValueMember = "ID";
            this.lookUpPersonel.Size = new System.Drawing.Size(194, 20);
            this.lookUpPersonel.TabIndex = 7;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(43, 209);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(45, 13);
            this.labelControl10.TabIndex = 34;
            this.labelControl10.Text = "Personel:";
            // 
            // lookUpCari
            // 
            this.lookUpCari.Location = new System.Drawing.Point(94, 179);
            this.lookUpCari.Name = "lookUpCari";
            this.lookUpCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCari.Properties.DisplayMember = "AD";
            this.lookUpCari.Properties.ValueMember = "ID";
            this.lookUpCari.Size = new System.Drawing.Size(194, 20);
            this.lookUpCari.TabIndex = 6;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(65, 182);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(23, 13);
            this.labelControl9.TabIndex = 32;
            this.labelControl9.Text = "Cari:";
            // 
            // textvergidaire
            // 
            this.textvergidaire.Location = new System.Drawing.Point(94, 153);
            this.textvergidaire.Name = "textvergidaire";
            this.textvergidaire.Size = new System.Drawing.Size(194, 20);
            this.textvergidaire.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(25, 156);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 13);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Vergi Dairesi:";
            // 
            // textsaat
            // 
            this.textsaat.Location = new System.Drawing.Point(94, 127);
            this.textsaat.Name = "textsaat";
            this.textsaat.Size = new System.Drawing.Size(194, 20);
            this.textsaat.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(62, 130);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(26, 13);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Saat:";
            // 
            // texttarih
            // 
            this.texttarih.Location = new System.Drawing.Point(94, 101);
            this.texttarih.Name = "texttarih";
            this.texttarih.Properties.Mask.EditMask = "99/99/00";
            this.texttarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.texttarih.Size = new System.Drawing.Size(194, 20);
            this.texttarih.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(60, 104);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Tarih:";
            // 
            // textsırano
            // 
            this.textsırano.Location = new System.Drawing.Point(94, 75);
            this.textsırano.Name = "textsırano";
            this.textsırano.Properties.Mask.EditMask = "AAAAAA";
            this.textsırano.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.textsırano.Size = new System.Drawing.Size(194, 20);
            this.textsırano.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(50, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Sıra No:";
            // 
            // FrmFaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmFaturaListesi";
            this.Text = "Fatura Listesi";
            this.Load += new System.EventHandler(this.FrmFaturaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textseri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textvergidaire.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textsaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texttarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textsırano.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textseri;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSil;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKaydet;
        private DevExpress.XtraEditors.SimpleButton simpleButtonListele;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGüncelle;
        private DevExpress.XtraEditors.TextEdit textID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textvergidaire;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textsaat;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit texttarih;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textsırano;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lookUpPersonel;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LookUpEdit lookUpCari;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}