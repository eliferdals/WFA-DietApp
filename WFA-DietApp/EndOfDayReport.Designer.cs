namespace WFA_DietApp
{
    partial class EndOfDayReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndOfDayReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKalori = new System.Windows.Forms.Label();
            this.lblOgundeAlinanToplamKalori = new System.Windows.Forms.Label();
            this.cmbOgunAdi = new System.Windows.Forms.ComboBox();
            this.lblOgunAdı = new System.Windows.Forms.Label();
            this.lblBugünAlınanToplamKalori = new System.Windows.Forms.Label();
            this.lblGunSonuRaporEkranı = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lblKalori);
            this.panel1.Controls.Add(this.lblOgundeAlinanToplamKalori);
            this.panel1.Controls.Add(this.cmbOgunAdi);
            this.panel1.Controls.Add(this.lblOgunAdı);
            this.panel1.Controls.Add(this.lblBugünAlınanToplamKalori);
            this.panel1.Location = new System.Drawing.Point(1, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 154);
            this.panel1.TabIndex = 1;
            // 
            // lblKalori
            // 
            this.lblKalori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKalori.Location = new System.Drawing.Point(264, 106);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(89, 25);
            this.lblKalori.TabIndex = 45;
            // 
            // lblOgundeAlinanToplamKalori
            // 
            this.lblOgundeAlinanToplamKalori.AutoSize = true;
            this.lblOgundeAlinanToplamKalori.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.lblOgundeAlinanToplamKalori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblOgundeAlinanToplamKalori.Location = new System.Drawing.Point(14, 107);
            this.lblOgundeAlinanToplamKalori.Name = "lblOgundeAlinanToplamKalori";
            this.lblOgundeAlinanToplamKalori.Size = new System.Drawing.Size(255, 24);
            this.lblOgundeAlinanToplamKalori.TabIndex = 44;
            this.lblOgundeAlinanToplamKalori.Text = "Öğünde Alınan Toplam Kalori : ";
            // 
            // cmbOgunAdi
            // 
            this.cmbOgunAdi.FormattingEnabled = true;
            this.cmbOgunAdi.Location = new System.Drawing.Point(118, 53);
            this.cmbOgunAdi.Name = "cmbOgunAdi";
            this.cmbOgunAdi.Size = new System.Drawing.Size(235, 28);
            this.cmbOgunAdi.TabIndex = 43;
            this.cmbOgunAdi.SelectedIndexChanged += new System.EventHandler(this.cmbOgunAdi_SelectedIndexChanged);
            // 
            // lblOgunAdı
            // 
            this.lblOgunAdı.AutoSize = true;
            this.lblOgunAdı.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.lblOgunAdı.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblOgunAdı.Location = new System.Drawing.Point(14, 56);
            this.lblOgunAdı.Name = "lblOgunAdı";
            this.lblOgunAdı.Size = new System.Drawing.Size(97, 24);
            this.lblOgunAdı.TabIndex = 42;
            this.lblOgunAdı.Text = "Öğün Adı : ";
            // 
            // lblBugünAlınanToplamKalori
            // 
            this.lblBugünAlınanToplamKalori.AutoSize = true;
            this.lblBugünAlınanToplamKalori.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.lblBugünAlınanToplamKalori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblBugünAlınanToplamKalori.Location = new System.Drawing.Point(14, 15);
            this.lblBugünAlınanToplamKalori.Name = "lblBugünAlınanToplamKalori";
            this.lblBugünAlınanToplamKalori.Size = new System.Drawing.Size(241, 24);
            this.lblBugünAlınanToplamKalori.TabIndex = 40;
            this.lblBugünAlınanToplamKalori.Text = "Bugün Alınan Toplam Kalori :";
            // 
            // lblGunSonuRaporEkranı
            // 
            this.lblGunSonuRaporEkranı.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGunSonuRaporEkranı.AutoSize = true;
            this.lblGunSonuRaporEkranı.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 20F);
            this.lblGunSonuRaporEkranı.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGunSonuRaporEkranı.Location = new System.Drawing.Point(12, 19);
            this.lblGunSonuRaporEkranı.Name = "lblGunSonuRaporEkranı";
            this.lblGunSonuRaporEkranı.Size = new System.Drawing.Size(196, 32);
            this.lblGunSonuRaporEkranı.TabIndex = 39;
            this.lblGunSonuRaporEkranı.Text = "Gün Sonu Raporu";
            // 
            // EndOfDayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 291);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGunSonuRaporEkranı);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EndOfDayReport";
            this.Text = "Gün Sonu Raporu";
            this.Load += new System.EventHandler(this.EndOfDayReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblKalori;
        private System.Windows.Forms.Label lblOgundeAlinanToplamKalori;
        private System.Windows.Forms.ComboBox cmbOgunAdi;
        private System.Windows.Forms.Label lblOgunAdı;
        private System.Windows.Forms.Label lblBugünAlınanToplamKalori;
        private System.Windows.Forms.Label lblGunSonuRaporEkranı;
    }
}