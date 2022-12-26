namespace WFA_DietApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBasla = new System.Windows.Forms.Button();
            this.lblBilgi2 = new System.Windows.Forms.Label();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.lblSaglikliBeslenmeIcinArac = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btnBasla);
            this.panel1.Controls.Add(this.lblBilgi2);
            this.panel1.Controls.Add(this.lblBilgi);
            this.panel1.Controls.Add(this.lblSaglikliBeslenmeIcinArac);
            this.panel1.Location = new System.Drawing.Point(2, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 429);
            this.panel1.TabIndex = 1;
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBasla.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBasla.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBasla.FlatAppearance.BorderSize = 0;
            this.btnBasla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasla.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 14F);
            this.btnBasla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBasla.Location = new System.Drawing.Point(72, 348);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(190, 32);
            this.btnBasla.TabIndex = 56;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // lblBilgi2
            // 
            this.lblBilgi2.AutoSize = true;
            this.lblBilgi2.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.lblBilgi2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblBilgi2.Location = new System.Drawing.Point(10, 242);
            this.lblBilgi2.Name = "lblBilgi2";
            this.lblBilgi2.Size = new System.Drawing.Size(303, 48);
            this.lblBilgi2.TabIndex = 3;
            this.lblBilgi2.Text = "Dünya genelinde 75 milyon kullanıcı \r\ntarafından güveniliyor.";
            this.lblBilgi2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 15F);
            this.lblBilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblBilgi.Location = new System.Drawing.Point(10, 120);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(302, 72);
            this.lblBilgi.TabIndex = 2;
            this.lblBilgi.Text = "Sağlıklı bir hamilelik süreci \r\niçin senin ve bebeğinin bu \r\nserüveninde sana yar" +
    "dımcı  olacağız.";
            this.lblBilgi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSaglikliBeslenmeIcinArac
            // 
            this.lblSaglikliBeslenmeIcinArac.AutoSize = true;
            this.lblSaglikliBeslenmeIcinArac.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 25F);
            this.lblSaglikliBeslenmeIcinArac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSaglikliBeslenmeIcinArac.Location = new System.Drawing.Point(41, 11);
            this.lblSaglikliBeslenmeIcinArac.Name = "lblSaglikliBeslenmeIcinArac";
            this.lblSaglikliBeslenmeIcinArac.Size = new System.Drawing.Size(259, 82);
            this.lblSaglikliBeslenmeIcinArac.TabIndex = 1;
            this.lblSaglikliBeslenmeIcinArac.Text = "Sağlıklı Beslenme\r\n İçin #1 Araç";
            this.lblSaglikliBeslenmeIcinArac.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 622);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblBilgi2;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Label lblSaglikliBeslenmeIcinArac;
    }
}

