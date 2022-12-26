namespace WFA_DietApp
{
    partial class UpdateMealDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMealDetail));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblGuncellenecekUrun = new System.Windows.Forms.Label();
            this.lstViewUrunler = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtGüncenllenecekUrunMiktari = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.lblSecilenBesin = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKategoridekiUrunler = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblLutfenYedikleriniziGiriniz = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Karbonhidrat";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kalsiyum";
            this.columnHeader5.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Protein";
            this.columnHeader4.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kalori";
            this.columnHeader3.Width = 63;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Besin Adı";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 31;
            // 
            // lblGuncellenecekUrun
            // 
            this.lblGuncellenecekUrun.BackColor = System.Drawing.Color.White;
            this.lblGuncellenecekUrun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGuncellenecekUrun.Location = new System.Drawing.Point(785, 136);
            this.lblGuncellenecekUrun.Name = "lblGuncellenecekUrun";
            this.lblGuncellenecekUrun.Size = new System.Drawing.Size(174, 28);
            this.lblGuncellenecekUrun.TabIndex = 73;
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
            // columnHeader7
            // 
            this.columnHeader7.Text = "Folik Asid";
            this.columnHeader7.Width = 139;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblQuantity.Location = new System.Drawing.Point(695, 113);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(0, 20);
            this.lblQuantity.TabIndex = 76;
            // 
            // txtGüncenllenecekUrunMiktari
            // 
            this.txtGüncenllenecekUrunMiktari.Location = new System.Drawing.Point(643, 136);
            this.txtGüncenllenecekUrunMiktari.Name = "txtGüncenllenecekUrunMiktari";
            this.txtGüncenllenecekUrunMiktari.Size = new System.Drawing.Size(134, 26);
            this.txtGüncenllenecekUrunMiktari.TabIndex = 75;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.txtGüncenllenecekUrunMiktari);
            this.panel1.Controls.Add(this.lblGuncellenecekUrun);
            this.panel1.Controls.Add(this.lstViewUrunler);
            this.panel1.Controls.Add(this.btnGüncelle);
            this.panel1.Controls.Add(this.lblSecilenBesin);
            this.panel1.Controls.Add(this.lblMiktar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblKategoridekiUrunler);
            this.panel1.Controls.Add(this.cmbKategori);
            this.panel1.Controls.Add(this.lblKategori);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 610);
            this.panel1.TabIndex = 56;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGüncelle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGüncelle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGüncelle.FlatAppearance.BorderSize = 0;
            this.btnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGüncelle.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F);
            this.btnGüncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGüncelle.Location = new System.Drawing.Point(834, 175);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(125, 33);
            this.btnGüncelle.TabIndex = 70;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // lblSecilenBesin
            // 
            this.lblSecilenBesin.AutoSize = true;
            this.lblSecilenBesin.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.lblSecilenBesin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSecilenBesin.Location = new System.Drawing.Point(781, 109);
            this.lblSecilenBesin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecilenBesin.Name = "lblSecilenBesin";
            this.lblSecilenBesin.Size = new System.Drawing.Size(171, 24);
            this.lblSecilenBesin.TabIndex = 67;
            this.lblSecilenBesin.Text = "Güncellenecek Besin";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.lblMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblMiktar.Location = new System.Drawing.Point(639, 109);
            this.lblMiktar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(62, 24);
            this.lblMiktar.TabIndex = 63;
            this.lblMiktar.Text = "Miktar";
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
            this.cmbKategori.Location = new System.Drawing.Point(15, 28);
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
            // lblLutfenYedikleriniziGiriniz
            // 
            this.lblLutfenYedikleriniziGiriniz.AutoSize = true;
            this.lblLutfenYedikleriniziGiriniz.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 20F);
            this.lblLutfenYedikleriniziGiriniz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblLutfenYedikleriniziGiriniz.Location = new System.Drawing.Point(748, 9);
            this.lblLutfenYedikleriniziGiriniz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLutfenYedikleriniziGiriniz.Name = "lblLutfenYedikleriniziGiriniz";
            this.lblLutfenYedikleriniziGiriniz.Size = new System.Drawing.Size(235, 32);
            this.lblLutfenYedikleriniziGiriniz.TabIndex = 57;
            this.lblLutfenYedikleriniziGiriniz.Text = "Güncellenecek Besin";
            // 
            // UpdateMealDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLutfenYedikleriniziGiriniz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateMealDetail";
            this.Text = "Öğün Güncelleme Ekranı";
            this.Load += new System.EventHandler(this.UpdateMealDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lblGuncellenecekUrun;
        private System.Windows.Forms.ListView lstViewUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtGüncenllenecekUrunMiktari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label lblSecilenBesin;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKategoridekiUrunler;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblLutfenYedikleriniziGiriniz;
    }
}