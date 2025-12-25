namespace Sinema_Otomasyon
{
    partial class Oyunculst
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oyunculst));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbresimdetay = new System.Windows.Forms.PictureBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblcinsiyet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pbcinsiyet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbresimdetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcinsiyet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 138);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbresimdetay
            // 
            this.pbresimdetay.Image = ((System.Drawing.Image)(resources.GetObject("pbresimdetay.Image")));
            this.pbresimdetay.Location = new System.Drawing.Point(13, 0);
            this.pbresimdetay.Name = "pbresimdetay";
            this.pbresimdetay.Size = new System.Drawing.Size(172, 135);
            this.pbresimdetay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbresimdetay.TabIndex = 1;
            this.pbresimdetay.TabStop = false;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(359, 28);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(44, 16);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "label1";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(340, 63);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(44, 16);
            this.lblid.TabIndex = 3;
            this.lblid.Text = "label2";
            // 
            // lblcinsiyet
            // 
            this.lblcinsiyet.AutoSize = true;
            this.lblcinsiyet.Location = new System.Drawing.Point(284, 89);
            this.lblcinsiyet.Name = "lblcinsiyet";
            this.lblcinsiyet.Size = new System.Drawing.Size(44, 16);
            this.lblcinsiyet.TabIndex = 4;
            this.lblcinsiyet.Text = "label3";
            this.lblcinsiyet.Click += new System.EventHandler(this.lblcinsiyet_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Algerian", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(579, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Algerian", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(579, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 95);
            this.button2.TabIndex = 6;
            this.button2.Text = "DETAY";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbcinsiyet
            // 
            this.pbcinsiyet.Location = new System.Drawing.Point(191, 7);
            this.pbcinsiyet.Name = "pbcinsiyet";
            this.pbcinsiyet.Size = new System.Drawing.Size(72, 41);
            this.pbcinsiyet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbcinsiyet.TabIndex = 7;
            this.pbcinsiyet.TabStop = false;
            this.pbcinsiyet.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Oyunculst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbcinsiyet);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblcinsiyet);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.pbresimdetay);
            this.Controls.Add(this.panel1);
            this.Name = "Oyunculst";
            this.Size = new System.Drawing.Size(701, 138);
            this.Load += new System.EventHandler(this.Oyunculst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbresimdetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcinsiyet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcinsiyet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pbcinsiyet;
        public System.Windows.Forms.Label lblAdSoyad;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.PictureBox pbresimdetay;
    }
}
