namespace WFA_DietApp
{
    partial class FoodVarietyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodVarietyReport));
            this.lblYemekCesidiRaporEkrani = new System.Windows.Forms.Label();
            this.btnKullaniciProfilineDon = new System.Windows.Forms.Button();
            this.btnEnCokYenenYemekler = new System.Windows.Forms.Button();
            this.cmbBxYemekAdi = new System.Windows.Forms.ComboBox();
            this.lblYemekAdi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstViewYemekCesidi = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYemekCesidiRaporEkrani
            // 
            this.lblYemekCesidiRaporEkrani.AutoSize = true;
            this.lblYemekCesidiRaporEkrani.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 20F);
            this.lblYemekCesidiRaporEkrani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblYemekCesidiRaporEkrani.Location = new System.Drawing.Point(12, 15);
            this.lblYemekCesidiRaporEkrani.Name = "lblYemekCesidiRaporEkrani";
            this.lblYemekCesidiRaporEkrani.Size = new System.Drawing.Size(240, 32);
            this.lblYemekCesidiRaporEkrani.TabIndex = 55;
            this.lblYemekCesidiRaporEkrani.Text = "Yemek Çeşidi Raporu";
            // 
            // btnKullaniciProfilineDon
            // 
            this.btnKullaniciProfilineDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKullaniciProfilineDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnKullaniciProfilineDon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKullaniciProfilineDon.FlatAppearance.BorderSize = 0;
            this.btnKullaniciProfilineDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciProfilineDon.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F);
            this.btnKullaniciProfilineDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKullaniciProfilineDon.Location = new System.Drawing.Point(185, 285);
            this.btnKullaniciProfilineDon.Name = "btnKullaniciProfilineDon";
            this.btnKullaniciProfilineDon.Size = new System.Drawing.Size(208, 32);
            this.btnKullaniciProfilineDon.TabIndex = 63;
            this.btnKullaniciProfilineDon.Text = "Kullanıcı Profiline Dön";
            this.btnKullaniciProfilineDon.UseVisualStyleBackColor = false;
            this.btnKullaniciProfilineDon.Click += new System.EventHandler(this.btnKullaniciProfilineDon_Click);
            // 
            // btnEnCokYenenYemekler
            // 
            this.btnEnCokYenenYemekler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEnCokYenenYemekler.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEnCokYenenYemekler.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEnCokYenenYemekler.FlatAppearance.BorderSize = 0;
            this.btnEnCokYenenYemekler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnCokYenenYemekler.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 12F);
            this.btnEnCokYenenYemekler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEnCokYenenYemekler.Location = new System.Drawing.Point(185, 238);
            this.btnEnCokYenenYemekler.Name = "btnEnCokYenenYemekler";
            this.btnEnCokYenenYemekler.Size = new System.Drawing.Size(208, 32);
            this.btnEnCokYenenYemekler.TabIndex = 61;
            this.btnEnCokYenenYemekler.Text = "En Çok Yenen Yemekler";
            this.btnEnCokYenenYemekler.UseVisualStyleBackColor = false;
            this.btnEnCokYenenYemekler.Click += new System.EventHandler(this.btnEnCokYenenYemekler_Click);
            // 
            // cmbBxYemekAdi
            // 
            this.cmbBxYemekAdi.FormattingEnabled = true;
            this.cmbBxYemekAdi.Location = new System.Drawing.Point(134, 26);
            this.cmbBxYemekAdi.Name = "cmbBxYemekAdi";
            this.cmbBxYemekAdi.Size = new System.Drawing.Size(253, 28);
            this.cmbBxYemekAdi.TabIndex = 59;
            this.cmbBxYemekAdi.SelectedIndexChanged += new System.EventHandler(this.cmbBxYemekAdi_SelectedIndexChanged);
            // 
            // lblYemekAdi
            // 
            this.lblYemekAdi.AutoSize = true;
            this.lblYemekAdi.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.lblYemekAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblYemekAdi.Location = new System.Drawing.Point(23, 26);
            this.lblYemekAdi.Name = "lblYemekAdi";
            this.lblYemekAdi.Size = new System.Drawing.Size(103, 24);
            this.lblYemekAdi.TabIndex = 58;
            this.lblYemekAdi.Text = "Yemek Adi :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lstViewYemekCesidi);
            this.panel1.Controls.Add(this.btnKullaniciProfilineDon);
            this.panel1.Controls.Add(this.btnEnCokYenenYemekler);
            this.panel1.Controls.Add(this.cmbBxYemekAdi);
            this.panel1.Controls.Add(this.lblYemekAdi);
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 398);
            this.panel1.TabIndex = 65;
            // 
            // lstViewYemekCesidi
            // 
            this.lstViewYemekCesidi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstViewYemekCesidi.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 10F);
            this.lstViewYemekCesidi.GridLines = true;
            this.lstViewYemekCesidi.HideSelection = false;
            this.lstViewYemekCesidi.Location = new System.Drawing.Point(12, 74);
            this.lstViewYemekCesidi.Name = "lstViewYemekCesidi";
            this.lstViewYemekCesidi.Size = new System.Drawing.Size(375, 142);
            this.lstViewYemekCesidi.TabIndex = 65;
            this.lstViewYemekCesidi.UseCompatibleStateImageBehavior = false;
            this.lstViewYemekCesidi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yemek Adı";
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Öğün Adı";
            this.columnHeader4.Width = 113;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Miktar";
            this.columnHeader5.Width = 114;
            // 
            // FoodVarietyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(415, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblYemekCesidiRaporEkrani);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FoodVarietyReport";
            this.Text = "Yemek Çeşidi Raporu";
            this.Load += new System.EventHandler(this.FoodVarietyReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYemekCesidiRaporEkrani;
        private System.Windows.Forms.Button btnKullaniciProfilineDon;
        private System.Windows.Forms.Button btnEnCokYenenYemekler;
        private System.Windows.Forms.ComboBox cmbBxYemekAdi;
        private System.Windows.Forms.Label lblYemekAdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstViewYemekCesidi;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}