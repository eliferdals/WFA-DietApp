namespace WFA_DietApp
{
    partial class AddMealDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMealDetail));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblSecilenBesin = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblKategoridekiUrunler = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblLutfenYedikleriniziGiriniz = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txSecilenUrunMiktari = new System.Windows.Forms.TextBox();
            this.lstViewEklenenUrunler = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSecilenUrun = new System.Windows.Forms.Label();
            this.lstViewUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(639, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 71;
            this.label1.Text = "Eklenen Ürünler";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F);
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEkle.Location = new System.Drawing.Point(834, 78);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(125, 33);
            this.btnEkle.TabIndex = 70;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblSecilenBesin
            // 
            this.lblSecilenBesin.AutoSize = true;
            this.lblSecilenBesin.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.lblSecilenBesin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSecilenBesin.Location = new System.Drawing.Point(846, 9);
            this.lblSecilenBesin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecilenBesin.Name = "lblSecilenBesin";
            this.lblSecilenBesin.Size = new System.Drawing.Size(113, 24);
            this.lblSecilenBesin.TabIndex = 67;
            this.lblSecilenBesin.Text = "Seçilen Besin";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.lblMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMiktar.Location = new System.Drawing.Point(639, 10);
            this.lblMiktar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(62, 24);
            this.lblMiktar.TabIndex = 63;
            this.lblMiktar.Text = "Miktar";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F);
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSil.Location = new System.Drawing.Point(643, 547);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(155, 49);
            this.btnSil.TabIndex = 62;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblKategoridekiUrunler
            // 
            this.lblKategoridekiUrunler.AutoSize = true;
            this.lblKategoridekiUrunler.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.lblKategoridekiUrunler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblKategoridekiUrunler.Location = new System.Drawing.Point(12, 104);
            this.lblKategoridekiUrunler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategoridekiUrunler.Name = "lblKategoridekiUrunler";
            this.lblKategoridekiUrunler.Size = new System.Drawing.Size(420, 24);
            this.lblKategoridekiUrunler.TabIndex = 60;
            this.lblKategoridekiUrunler.Text = "Besin Değerleri 100 gr / 100 mililitre / 1 adet içindir";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(15, 36);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(254, 28);
            this.cmbKategori.TabIndex = 59;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.lblKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblKategori.Location = new System.Drawing.Point(11, 5);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(77, 24);
            this.lblKategori.TabIndex = 57;
            this.lblKategori.Text = "Kategori";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F);
            this.btnKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKaydet.Location = new System.Drawing.Point(806, 547);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(153, 49);
            this.btnKaydet.TabIndex = 56;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblLutfenYedikleriniziGiriniz
            // 
            this.lblLutfenYedikleriniziGiriniz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLutfenYedikleriniziGiriniz.AutoSize = true;
            this.lblLutfenYedikleriniziGiriniz.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 20F);
            this.lblLutfenYedikleriniziGiriniz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblLutfenYedikleriniziGiriniz.Location = new System.Drawing.Point(12, 29);
            this.lblLutfenYedikleriniziGiriniz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLutfenYedikleriniziGiriniz.Name = "lblLutfenYedikleriniziGiriniz";
            this.lblLutfenYedikleriniziGiriniz.Size = new System.Drawing.Size(299, 32);
            this.lblLutfenYedikleriniziGiriniz.TabIndex = 55;
            this.lblLutfenYedikleriniziGiriniz.Text = "Lütfen Yediklerinizi Giriniz";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.txSecilenUrunMiktari);
            this.panel1.Controls.Add(this.lstViewEklenenUrunler);
            this.panel1.Controls.Add(this.lblSecilenUrun);
            this.panel1.Controls.Add(this.lstViewUrunler);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.lblSecilenBesin);
            this.panel1.Controls.Add(this.lblMiktar);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblKategoridekiUrunler);
            this.panel1.Controls.Add(this.cmbKategori);
            this.panel1.Controls.Add(this.lblKategori);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Location = new System.Drawing.Point(2, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 610);
            this.panel1.TabIndex = 1;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblQuantity.Location = new System.Drawing.Point(695, 16);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(0, 20);
            this.lblQuantity.TabIndex = 76;
            // 
            // txSecilenUrunMiktari
            // 
            this.txSecilenUrunMiktari.Location = new System.Drawing.Point(643, 41);
            this.txSecilenUrunMiktari.Name = "txSecilenUrunMiktari";
            this.txSecilenUrunMiktari.Size = new System.Drawing.Size(134, 26);
            this.txSecilenUrunMiktari.TabIndex = 75;
            // 
            // lstViewEklenenUrunler
            // 
            this.lstViewEklenenUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lstViewEklenenUrunler.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 10F);
            this.lstViewEklenenUrunler.FullRowSelect = true;
            this.lstViewEklenenUrunler.GridLines = true;
            this.lstViewEklenenUrunler.HideSelection = false;
            this.lstViewEklenenUrunler.Location = new System.Drawing.Point(643, 136);
            this.lstViewEklenenUrunler.Name = "lstViewEklenenUrunler";
            this.lstViewEklenenUrunler.Size = new System.Drawing.Size(316, 403);
            this.lstViewEklenenUrunler.TabIndex = 74;
            this.lstViewEklenenUrunler.UseCompatibleStateImageBehavior = false;
            this.lstViewEklenenUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Besin Adı";
            this.columnHeader9.Width = 181;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Miktar";
            this.columnHeader10.Width = 180;
            // 
            // lblSecilenUrun
            // 
            this.lblSecilenUrun.BackColor = System.Drawing.Color.White;
            this.lblSecilenUrun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecilenUrun.Location = new System.Drawing.Point(785, 39);
            this.lblSecilenUrun.Name = "lblSecilenUrun";
            this.lblSecilenUrun.Size = new System.Drawing.Size(174, 28);
            this.lblSecilenUrun.TabIndex = 73;
            // 
            // lstViewUrunler
            // 
            this.lstViewUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstViewUrunler.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 10F);
            this.lstViewUrunler.FullRowSelect = true;
            this.lstViewUrunler.GridLines = true;
            this.lstViewUrunler.HideSelection = false;
            this.lstViewUrunler.Location = new System.Drawing.Point(15, 136);
            this.lstViewUrunler.Name = "lstViewUrunler";
            this.lstViewUrunler.Size = new System.Drawing.Size(606, 460);
            this.lstViewUrunler.TabIndex = 72;
            this.lstViewUrunler.UseCompatibleStateImageBehavior = false;
            this.lstViewUrunler.View = System.Windows.Forms.View.Details;
            this.lstViewUrunler.DoubleClick += new System.EventHandler(this.lstViewUrunler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 31;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Besin Adı";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kalori";
            this.columnHeader3.Width = 63;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Protein";
            this.columnHeader4.Width = 78;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kalsiyum";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Karbonhidrat";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Folik Asid";
            this.columnHeader7.Width = 139;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 24);
            this.label2.TabIndex = 60;
            this.label2.Text = "Seçilen Kategoriye göre ürünler listelendi Lütfen seçim yapınız";
            // 
            // AddMealDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 771);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLutfenYedikleriniziGiriniz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddMealDetail";
            this.Text = "Öğün Ekleme";
            this.Load += new System.EventHandler(this.AddMealDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblSecilenBesin;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblKategoridekiUrunler;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblLutfenYedikleriniziGiriniz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstViewUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstViewEklenenUrunler;
        private System.Windows.Forms.Label lblSecilenUrun;
        private System.Windows.Forms.TextBox txSecilenUrunMiktari;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label lblQuantity;
    }
}