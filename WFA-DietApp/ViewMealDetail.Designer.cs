namespace WFA_DietApp
{
    partial class ViewMealDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMealDetail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstViewOgunAdi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvtViewOgunIcerigi = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOgunIcerigi = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnOgunIcerigiGoruntule = new System.Windows.Forms.Button();
            this.btnOgunSil = new System.Windows.Forms.Button();
            this.lblOgunAdi = new System.Windows.Forms.Label();
            this.lblOgunDetaylariGoruntulemeEkrani = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lstViewOgunAdi);
            this.panel1.Controls.Add(this.lsvtViewOgunIcerigi);
            this.panel1.Controls.Add(this.lblOgunIcerigi);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnOgunIcerigiGoruntule);
            this.panel1.Controls.Add(this.btnOgunSil);
            this.panel1.Controls.Add(this.lblOgunAdi);
            this.panel1.Location = new System.Drawing.Point(-1, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 473);
            this.panel1.TabIndex = 1;
            // 
            // lstViewOgunAdi
            // 
            this.lstViewOgunAdi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstViewOgunAdi.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 10F);
            this.lstViewOgunAdi.FullRowSelect = true;
            this.lstViewOgunAdi.GridLines = true;
            this.lstViewOgunAdi.HideSelection = false;
            this.lstViewOgunAdi.Location = new System.Drawing.Point(13, 37);
            this.lstViewOgunAdi.Name = "lstViewOgunAdi";
            this.lstViewOgunAdi.Size = new System.Drawing.Size(257, 175);
            this.lstViewOgunAdi.TabIndex = 52;
            this.lstViewOgunAdi.UseCompatibleStateImageBehavior = false;
            this.lstViewOgunAdi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 33;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Öğün Adı";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarih";
            this.columnHeader3.Width = 107;
            // 
            // lsvtViewOgunIcerigi
            // 
            this.lsvtViewOgunIcerigi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lsvtViewOgunIcerigi.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 10F);
            this.lsvtViewOgunIcerigi.FullRowSelect = true;
            this.lsvtViewOgunIcerigi.GridLines = true;
            this.lsvtViewOgunIcerigi.HideSelection = false;
            this.lsvtViewOgunIcerigi.Location = new System.Drawing.Point(276, 37);
            this.lsvtViewOgunIcerigi.Name = "lsvtViewOgunIcerigi";
            this.lsvtViewOgunIcerigi.Size = new System.Drawing.Size(322, 386);
            this.lsvtViewOgunIcerigi.TabIndex = 51;
            this.lsvtViewOgunIcerigi.UseCompatibleStateImageBehavior = false;
            this.lsvtViewOgunIcerigi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Besin";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Miktar";
            this.columnHeader6.Width = 124;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kalori";
            this.columnHeader7.Width = 126;
            // 
            // lblOgunIcerigi
            // 
            this.lblOgunIcerigi.AutoSize = true;
            this.lblOgunIcerigi.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.lblOgunIcerigi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblOgunIcerigi.Location = new System.Drawing.Point(272, 7);
            this.lblOgunIcerigi.Name = "lblOgunIcerigi";
            this.lblOgunIcerigi.Size = new System.Drawing.Size(120, 24);
            this.lblOgunIcerigi.TabIndex = 47;
            this.lblOgunIcerigi.Text = "Öğün İçeriği : ";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F);
            this.btnGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGuncelle.Location = new System.Drawing.Point(490, 429);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(108, 32);
            this.btnGuncelle.TabIndex = 46;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
            this.btnSil.Location = new System.Drawing.Point(376, 429);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(108, 32);
            this.btnSil.TabIndex = 45;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnOgunIcerigiGoruntule
            // 
            this.btnOgunIcerigiGoruntule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOgunIcerigiGoruntule.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOgunIcerigiGoruntule.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOgunIcerigiGoruntule.FlatAppearance.BorderSize = 0;
            this.btnOgunIcerigiGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgunIcerigiGoruntule.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F);
            this.btnOgunIcerigiGoruntule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOgunIcerigiGoruntule.Location = new System.Drawing.Point(115, 228);
            this.btnOgunIcerigiGoruntule.Name = "btnOgunIcerigiGoruntule";
            this.btnOgunIcerigiGoruntule.Size = new System.Drawing.Size(155, 32);
            this.btnOgunIcerigiGoruntule.TabIndex = 44;
            this.btnOgunIcerigiGoruntule.Text = "Öğün İçeriğini Gör";
            this.btnOgunIcerigiGoruntule.UseVisualStyleBackColor = false;
            this.btnOgunIcerigiGoruntule.Click += new System.EventHandler(this.btnOgunIcerigiGoruntule_Click);
            // 
            // btnOgunSil
            // 
            this.btnOgunSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOgunSil.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOgunSil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOgunSil.FlatAppearance.BorderSize = 0;
            this.btnOgunSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgunSil.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F);
            this.btnOgunSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOgunSil.Location = new System.Drawing.Point(13, 228);
            this.btnOgunSil.Name = "btnOgunSil";
            this.btnOgunSil.Size = new System.Drawing.Size(93, 32);
            this.btnOgunSil.TabIndex = 44;
            this.btnOgunSil.Text = "Öğün Sil";
            this.btnOgunSil.UseVisualStyleBackColor = false;
            this.btnOgunSil.Click += new System.EventHandler(this.btnOgunSil_Click);
            // 
            // lblOgunAdi
            // 
            this.lblOgunAdi.AutoSize = true;
            this.lblOgunAdi.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.lblOgunAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblOgunAdi.Location = new System.Drawing.Point(9, 7);
            this.lblOgunAdi.Name = "lblOgunAdi";
            this.lblOgunAdi.Size = new System.Drawing.Size(92, 24);
            this.lblOgunAdi.TabIndex = 43;
            this.lblOgunAdi.Text = "Öğün Adı :";
            // 
            // lblOgunDetaylariGoruntulemeEkrani
            // 
            this.lblOgunDetaylariGoruntulemeEkrani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOgunDetaylariGoruntulemeEkrani.AutoSize = true;
            this.lblOgunDetaylariGoruntulemeEkrani.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 20F);
            this.lblOgunDetaylariGoruntulemeEkrani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblOgunDetaylariGoruntulemeEkrani.Location = new System.Drawing.Point(10, 47);
            this.lblOgunDetaylariGoruntulemeEkrani.Name = "lblOgunDetaylariGoruntulemeEkrani";
            this.lblOgunDetaylariGoruntulemeEkrani.Size = new System.Drawing.Size(180, 32);
            this.lblOgunDetaylariGoruntulemeEkrani.TabIndex = 42;
            this.lblOgunDetaylariGoruntulemeEkrani.Text = "Öğün Detayları ";
            // 
            // ViewMealDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 669);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOgunDetaylariGoruntulemeEkrani);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewMealDetail";
            this.Text = "Öğün Detayları Görüntüleme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewMealDetail_FormClosed);
            this.Load += new System.EventHandler(this.ViewMealDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOgunIcerigi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnOgunSil;
        private System.Windows.Forms.Label lblOgunAdi;
        private System.Windows.Forms.Label lblOgunDetaylariGoruntulemeEkrani;
        private System.Windows.Forms.ListView lstViewOgunAdi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnOgunIcerigiGoruntule;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lsvtViewOgunIcerigi;
    }
}