namespace Sinema_Otomasyon
{
    partial class filmlistesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filmlistesi));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblfilmadi = new System.Windows.Forms.Label();
            this.btnfilm = new System.Windows.Forms.Button();
            this.pbresim = new System.Windows.Forms.PictureBox();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Silver;
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.lblfilmadi);
            this.groupBox6.Controls.Add(this.btnfilm);
            this.groupBox6.Controls.Add(this.pbresim);
            this.groupBox6.Font = new System.Drawing.Font("Algerian", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(313, 257);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = " 🕊️";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblfilmadi
            // 
            this.lblfilmadi.AutoSize = true;
            this.lblfilmadi.Font = new System.Drawing.Font("Algerian", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilmadi.Location = new System.Drawing.Point(56, 5);
            this.lblfilmadi.Name = "lblfilmadi";
            this.lblfilmadi.Size = new System.Drawing.Size(100, 25);
            this.lblfilmadi.TabIndex = 20;
            this.lblfilmadi.Text = "label1";
            // 
            // btnfilm
            // 
            this.btnfilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnfilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfilm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnfilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfilm.Font = new System.Drawing.Font("Wide Latin", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilm.ForeColor = System.Drawing.Color.White;
            this.btnfilm.Location = new System.Drawing.Point(3, 207);
            this.btnfilm.Name = "btnfilm";
            this.btnfilm.Size = new System.Drawing.Size(307, 47);
            this.btnfilm.TabIndex = 19;
            this.btnfilm.Text = "DETAY";
            this.btnfilm.UseVisualStyleBackColor = false;
            this.btnfilm.Click += new System.EventHandler(this.btnfilm_Click);
            // 
            // pbresim
            // 
            this.pbresim.BackColor = System.Drawing.Color.White;
            this.pbresim.Image = ((System.Drawing.Image)(resources.GetObject("pbresim.Image")));
            this.pbresim.Location = new System.Drawing.Point(0, 36);
            this.pbresim.Name = "pbresim";
            this.pbresim.Size = new System.Drawing.Size(310, 191);
            this.pbresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbresim.TabIndex = 18;
            this.pbresim.TabStop = false;
            // 
            // filmlistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Name = "filmlistesi";
            this.Size = new System.Drawing.Size(316, 260);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnfilm;
        public System.Windows.Forms.Label lblfilmadi;
        public System.Windows.Forms.PictureBox pbresim;
        public System.Windows.Forms.Label label1;
    }
}
