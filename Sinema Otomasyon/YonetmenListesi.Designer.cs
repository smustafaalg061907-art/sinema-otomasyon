namespace Sinema_Otomasyon
{
    partial class YonetmenListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YonetmenListesi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.pbResimdetay = new System.Windows.Forms.PictureBox();
            this.btnresimyukle = new System.Windows.Forms.Button();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbResimdetay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 138);
            this.panel1.TabIndex = 0;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Algerian", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAdSoyad.Location = new System.Drawing.Point(290, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(100, 25);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "label1";
            this.lblAdSoyad.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Algerian", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblid.Location = new System.Drawing.Point(290, 53);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(100, 25);
            this.lblid.TabIndex = 2;
            this.lblid.Text = "label1";
            this.lblid.Visible = false;
            // 
            // pbResimdetay
            // 
            this.pbResimdetay.Image = ((System.Drawing.Image)(resources.GetObject("pbResimdetay.Image")));
            this.pbResimdetay.Location = new System.Drawing.Point(16, 0);
            this.pbResimdetay.Name = "pbResimdetay";
            this.pbResimdetay.Size = new System.Drawing.Size(159, 136);
            this.pbResimdetay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResimdetay.TabIndex = 3;
            this.pbResimdetay.TabStop = false;
            this.pbResimdetay.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnresimyukle
            // 
            this.btnresimyukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnresimyukle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnresimyukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresimyukle.Font = new System.Drawing.Font("Wide Latin", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresimyukle.ForeColor = System.Drawing.Color.White;
            this.btnresimyukle.Location = new System.Drawing.Point(681, 47);
            this.btnresimyukle.Name = "btnresimyukle";
            this.btnresimyukle.Size = new System.Drawing.Size(131, 91);
            this.btnresimyukle.TabIndex = 4;
            this.btnresimyukle.Text = "DETAY";
            this.btnresimyukle.UseVisualStyleBackColor = false;
            this.btnresimyukle.Click += new System.EventHandler(this.btnresimyukle_Click);
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Algerian", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCinsiyet.Location = new System.Drawing.Point(478, 40);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(26, 25);
            this.lblCinsiyet.TabIndex = 6;
            this.lblCinsiyet.Text = "1";
            this.lblCinsiyet.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Algerian", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(681, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YonetmenListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.btnresimyukle);
            this.Controls.Add(this.pbResimdetay);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.panel1);
            this.Name = "YonetmenListesi";
            this.Size = new System.Drawing.Size(815, 138);
            this.Load += new System.EventHandler(this.YonetmenListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResimdetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblAdSoyad;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.PictureBox pbResimdetay;
        private System.Windows.Forms.Button btnresimyukle;
        public System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Button button1;
    }
}
