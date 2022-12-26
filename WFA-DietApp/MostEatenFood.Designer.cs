namespace WFA_DietApp
{
    partial class MostEatenFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostEatenFood));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstbxEnCokYenenYemek = new System.Windows.Forms.ListBox();
            this.lblEnCokYenenYemekEkrani = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lstbxEnCokYenenYemek);
            this.panel1.Location = new System.Drawing.Point(-1, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 368);
            this.panel1.TabIndex = 66;
            // 
            // lstbxEnCokYenenYemek
            // 
            this.lstbxEnCokYenenYemek.FormattingEnabled = true;
            this.lstbxEnCokYenenYemek.ItemHeight = 20;
            this.lstbxEnCokYenenYemek.Location = new System.Drawing.Point(16, 33);
            this.lstbxEnCokYenenYemek.Name = "lstbxEnCokYenenYemek";
            this.lstbxEnCokYenenYemek.Size = new System.Drawing.Size(378, 244);
            this.lstbxEnCokYenenYemek.TabIndex = 62;
            // 
            // lblEnCokYenenYemekEkrani
            // 
            this.lblEnCokYenenYemekEkrani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEnCokYenenYemekEkrani.AutoSize = true;
            this.lblEnCokYenenYemekEkrani.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 20F);
            this.lblEnCokYenenYemekEkrani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEnCokYenenYemekEkrani.Location = new System.Drawing.Point(7, 23);
            this.lblEnCokYenenYemekEkrani.Name = "lblEnCokYenenYemekEkrani";
            this.lblEnCokYenenYemekEkrani.Size = new System.Drawing.Size(243, 32);
            this.lblEnCokYenenYemekEkrani.TabIndex = 55;
            this.lblEnCokYenenYemekEkrani.Text = "En Çok Yenen Yemek ";
            // 
            // MostEatenFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(408, 515);
            this.Controls.Add(this.lblEnCokYenenYemekEkrani);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MostEatenFood";
            this.Text = "En çok Yenen Yemek Raporu";
            this.Load += new System.EventHandler(this.MostEatenFood_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEnCokYenenYemekEkrani;
        private System.Windows.Forms.ListBox lstbxEnCokYenenYemek;
    }
}