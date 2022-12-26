namespace WFA_DietApp
{
    partial class NutritionistProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NutritionistProfile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUygulamadanCik = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstViewKullanicila = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewKullaniciDetayBilgileri = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblKullanicilar = new System.Windows.Forms.Label();
            this.lblKullanıcıDetayBilgileri = new System.Windows.Forms.Label();
            this.btnTumKullanıcılarıListele = new System.Windows.Forms.Button();
            this.lblDiyetisyenProfili = new System.Windows.Forms.Label();
            this.btnBesinEkle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btnUygulamadanCik);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.lstViewKullanicila);
            this.panel1.Controls.Add(this.lstViewKullaniciDetayBilgileri);
            this.panel1.Controls.Add(this.lblKullanicilar);
            this.panel1.Controls.Add(this.lblKullanıcıDetayBilgileri);
            this.panel1.Controls.Add(this.btnTumKullanıcılarıListele);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 550);
            this.panel1.TabIndex = 1;
            // 
            // btnUygulamadanCik
            // 
            this.btnUygulamadanCik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUygulamadanCik.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUygulamadanCik.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUygulamadanCik.FlatAppearance.BorderSize = 0;
            this.btnUygulamadanCik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUygulamadanCik.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F);
            this.btnUygulamadanCik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUygulamadanCik.Location = new System.Drawing.Point(701, 502);
            this.btnUygulamadanCik.Name = "btnUygulamadanCik";
            this.btnUygulamadanCik.Size = new System.Drawing.Size(143, 32);
            this.btnUygulamadanCik.TabIndex = 59;
            this.btnUygulamadanCik.Text = "Uygulamadan Çık";
            this.btnUygulamadanCik.UseVisualStyleBackColor = false;
            this.btnUygulamadanCik.Click += new System.EventHandler(this.btnUygulamadanCik_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSil.Location = new System.Drawing.Point(850, 502);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(129, 32);
            this.btnSil.TabIndex = 58;
            this.btnSil.Text = "Tahtayı Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstViewKullanicila
            // 
            this.lstViewKullanicila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader9});
            this.lstViewKullanicila.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 10F);
            this.lstViewKullanicila.FullRowSelect = true;
            this.lstViewKullanicila.GridLines = true;
            this.lstViewKullanicila.HideSelection = false;
            this.lstViewKullanicila.Location = new System.Drawing.Point(15, 39);
            this.lstViewKullanicila.Name = "lstViewKullanicila";
            this.lstViewKullanicila.Size = new System.Drawing.Size(202, 457);
            this.lstViewKullanicila.TabIndex = 57;
            this.lstViewKullanicila.UseCompatibleStateImageBehavior = false;
            this.lstViewKullanicila.View = System.Windows.Forms.View.Details;
            this.lstViewKullanicila.DoubleClick += new System.EventHandler(this.lstViewKullanicila_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 36;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Soyisim";
            this.columnHeader9.Width = 90;
            // 
            // lstViewKullaniciDetayBilgileri
            // 
            this.lstViewKullaniciDetayBilgileri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10});
            this.lstViewKullaniciDetayBilgileri.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 10F);
            this.lstViewKullaniciDetayBilgileri.FullRowSelect = true;
            this.lstViewKullaniciDetayBilgileri.GridLines = true;
            this.lstViewKullaniciDetayBilgileri.HideSelection = false;
            this.lstViewKullaniciDetayBilgileri.Location = new System.Drawing.Point(223, 39);
            this.lstViewKullaniciDetayBilgileri.Name = "lstViewKullaniciDetayBilgileri";
            this.lstViewKullaniciDetayBilgileri.Size = new System.Drawing.Size(756, 457);
            this.lstViewKullaniciDetayBilgileri.TabIndex = 56;
            this.lstViewKullaniciDetayBilgileri.UseCompatibleStateImageBehavior = false;
            this.lstViewKullaniciDetayBilgileri.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 38;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İsim";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Soyisim";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail";
            this.columnHeader6.Width = 156;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Diyet Tipi";
            this.columnHeader7.Width = 82;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Sigara Kullanım Durumu";
            this.columnHeader8.Width = 160;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Trimester Dönemi";
            this.columnHeader10.Width = 134;
            // 
            // lblKullanicilar
            // 
            this.lblKullanicilar.AutoSize = true;
            this.lblKullanicilar.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.lblKullanicilar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblKullanicilar.Location = new System.Drawing.Point(13, 12);
            this.lblKullanicilar.Name = "lblKullanicilar";
            this.lblKullanicilar.Size = new System.Drawing.Size(100, 24);
            this.lblKullanicilar.TabIndex = 51;
            this.lblKullanicilar.Text = "Kullanıcılar";
            // 
            // lblKullanıcıDetayBilgileri
            // 
            this.lblKullanıcıDetayBilgileri.AutoSize = true;
            this.lblKullanıcıDetayBilgileri.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.lblKullanıcıDetayBilgileri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblKullanıcıDetayBilgileri.Location = new System.Drawing.Point(779, 12);
            this.lblKullanıcıDetayBilgileri.Name = "lblKullanıcıDetayBilgileri";
            this.lblKullanıcıDetayBilgileri.Size = new System.Drawing.Size(200, 24);
            this.lblKullanıcıDetayBilgileri.TabIndex = 54;
            this.lblKullanıcıDetayBilgileri.Text = "Kullanıcı Detay Bilgileri ";
            // 
            // btnTumKullanıcılarıListele
            // 
            this.btnTumKullanıcılarıListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTumKullanıcılarıListele.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTumKullanıcılarıListele.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTumKullanıcılarıListele.FlatAppearance.BorderSize = 0;
            this.btnTumKullanıcılarıListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumKullanıcılarıListele.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F);
            this.btnTumKullanıcılarıListele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTumKullanıcılarıListele.Location = new System.Drawing.Point(17, 502);
            this.btnTumKullanıcılarıListele.Name = "btnTumKullanıcılarıListele";
            this.btnTumKullanıcılarıListele.Size = new System.Drawing.Size(200, 32);
            this.btnTumKullanıcılarıListele.TabIndex = 52;
            this.btnTumKullanıcılarıListele.Text = "Kullanıcıları Listele";
            this.btnTumKullanıcılarıListele.UseVisualStyleBackColor = false;
            this.btnTumKullanıcılarıListele.Click += new System.EventHandler(this.btnTumKullanıcılarıListele_Click);
            // 
            // lblDiyetisyenProfili
            // 
            this.lblDiyetisyenProfili.AutoSize = true;
            this.lblDiyetisyenProfili.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 20F);
            this.lblDiyetisyenProfili.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDiyetisyenProfili.Location = new System.Drawing.Point(12, 18);
            this.lblDiyetisyenProfili.Name = "lblDiyetisyenProfili";
            this.lblDiyetisyenProfili.Size = new System.Drawing.Size(198, 32);
            this.lblDiyetisyenProfili.TabIndex = 50;
            this.lblDiyetisyenProfili.Text = "Diyetisyen Profili";
            // 
            // btnBesinEkle
            // 
            this.btnBesinEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBesinEkle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBesinEkle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBesinEkle.FlatAppearance.BorderSize = 0;
            this.btnBesinEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBesinEkle.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBesinEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBesinEkle.Location = new System.Drawing.Point(876, 12);
            this.btnBesinEkle.Name = "btnBesinEkle";
            this.btnBesinEkle.Size = new System.Drawing.Size(133, 32);
            this.btnBesinEkle.TabIndex = 60;
            this.btnBesinEkle.Text = "Besin Ekle";
            this.btnBesinEkle.UseVisualStyleBackColor = false;
            this.btnBesinEkle.Click += new System.EventHandler(this.btnBesinEkle_Click);
            // 
            // NutritionistProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 711);
            this.Controls.Add(this.btnBesinEkle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDiyetisyenProfili);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NutritionistProfile";
            this.Text = "Diyetisyen Profili";
            this.Load += new System.EventHandler(this.NutritionistProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstViewKullaniciDetayBilgileri;
        private System.Windows.Forms.Label lblDiyetisyenProfili;
        private System.Windows.Forms.Label lblKullanicilar;
        private System.Windows.Forms.Label lblKullanıcıDetayBilgileri;
        private System.Windows.Forms.Button btnTumKullanıcılarıListele;
        private System.Windows.Forms.ListView lstViewKullanicila;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnBesinEkle;
        private System.Windows.Forms.Button btnUygulamadanCik;
    }
}