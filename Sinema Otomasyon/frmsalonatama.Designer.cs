namespace Sinema_Otomasyon
{
    partial class frmsalonatama
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbfilmadi = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblkoltuksayısı = new System.Windows.Forms.Label();
            this.cbsalonadı = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ngun = new System.Windows.Forms.NumericUpDown();
            this.nay = new System.Windows.Forms.NumericUpDown();
            this.nyıl = new System.Windows.Forms.NumericUpDown();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.panelsaat = new System.Windows.Forms.Panel();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.seanssaat = new System.Windows.Forms.GroupBox();
            this.cbdolusaat = new System.Windows.Forms.ComboBox();
            this.lblsec = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyıl)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.seanssaat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 91);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Wide Latin", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(662, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 91);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 25.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "SALON ATAMA 🕊️";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Silver;
            this.groupBox4.Controls.Add(this.cbfilmadi);
            this.groupBox4.Font = new System.Drawing.Font("Algerian", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox4.Location = new System.Drawing.Point(34, 109);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox4.Size = new System.Drawing.Size(348, 72);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FİLM ADI";
            // 
            // cbfilmadi
            // 
            this.cbfilmadi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbfilmadi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilmadi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbfilmadi.FormattingEnabled = true;
            this.cbfilmadi.Location = new System.Drawing.Point(10, 36);
            this.cbfilmadi.Name = "cbfilmadi";
            this.cbfilmadi.Size = new System.Drawing.Size(335, 33);
            this.cbfilmadi.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Silver;
            this.groupBox6.Controls.Add(this.lblkoltuksayısı);
            this.groupBox6.Controls.Add(this.cbsalonadı);
            this.groupBox6.Font = new System.Drawing.Font("Algerian", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox6.Location = new System.Drawing.Point(34, 206);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox6.Size = new System.Drawing.Size(348, 86);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SALON ADI ";
            // 
            // lblkoltuksayısı
            // 
            this.lblkoltuksayısı.AutoSize = true;
            this.lblkoltuksayısı.Location = new System.Drawing.Point(153, 0);
            this.lblkoltuksayısı.Name = "lblkoltuksayısı";
            this.lblkoltuksayısı.Size = new System.Drawing.Size(141, 25);
            this.lblkoltuksayısı.TabIndex = 24;
            this.lblkoltuksayısı.Text = "lblkoltuk";
            // 
            // cbsalonadı
            // 
            this.cbsalonadı.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbsalonadı.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsalonadı.FormattingEnabled = true;
            this.cbsalonadı.Location = new System.Drawing.Point(10, 50);
            this.cbsalonadı.Name = "cbsalonadı";
            this.cbsalonadı.Size = new System.Drawing.Size(335, 33);
            this.cbsalonadı.TabIndex = 19;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Silver;
            this.groupBox5.Controls.Add(this.ngun);
            this.groupBox5.Controls.Add(this.nay);
            this.groupBox5.Controls.Add(this.nyıl);
            this.groupBox5.Font = new System.Drawing.Font("Algerian", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox5.Location = new System.Drawing.Point(34, 307);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox5.Size = new System.Drawing.Size(351, 69);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TARIH ";
            // 
            // ngun
            // 
            this.ngun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ngun.Location = new System.Drawing.Point(13, 27);
            this.ngun.Name = "ngun";
            this.ngun.Size = new System.Drawing.Size(80, 32);
            this.ngun.TabIndex = 0;
            this.ngun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nay
            // 
            this.nay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nay.Location = new System.Drawing.Point(120, 27);
            this.nay.Name = "nay";
            this.nay.Size = new System.Drawing.Size(80, 32);
            this.nay.TabIndex = 25;
            this.nay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nyıl
            // 
            this.nyıl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nyıl.Location = new System.Drawing.Point(223, 27);
            this.nyıl.Name = "nyıl";
            this.nyıl.Size = new System.Drawing.Size(104, 32);
            this.nyıl.TabIndex = 26;
            this.nyıl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.Silver;
            this.groupBox10.Controls.Add(this.panelsaat);
            this.groupBox10.Font = new System.Drawing.Font("Algerian", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox10.Location = new System.Drawing.Point(414, 109);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox10.Size = new System.Drawing.Size(333, 400);
            this.groupBox10.TabIndex = 24;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "SAAT";
            // 
            // panelsaat
            // 
            this.panelsaat.AutoScroll = true;
            this.panelsaat.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.panelsaat.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.panelsaat.AutoSize = true;
            this.panelsaat.BackColor = System.Drawing.Color.White;
            this.panelsaat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelsaat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelsaat.Location = new System.Drawing.Point(10, 32);
            this.panelsaat.Name = "panelsaat";
            this.panelsaat.Size = new System.Drawing.Size(320, 365);
            this.panelsaat.TabIndex = 0;
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Black;
            this.btnkaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkaydet.FlatAppearance.BorderSize = 0;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Font = new System.Drawing.Font("Wide Latin", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.ForeColor = System.Drawing.Color.White;
            this.btnkaydet.Location = new System.Drawing.Point(41, 392);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(341, 54);
            this.btnkaydet.TabIndex = 25;
            this.btnkaydet.Text = "TAMAMLA";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.Color.Black;
            this.btntemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntemizle.FlatAppearance.BorderSize = 0;
            this.btntemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntemizle.Font = new System.Drawing.Font("Wide Latin", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntemizle.ForeColor = System.Drawing.Color.White;
            this.btntemizle.Location = new System.Drawing.Point(41, 452);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(341, 54);
            this.btntemizle.TabIndex = 36;
            this.btntemizle.Text = "TEMİZLE";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // seanssaat
            // 
            this.seanssaat.BackColor = System.Drawing.Color.Silver;
            this.seanssaat.Controls.Add(this.cbdolusaat);
            this.seanssaat.Font = new System.Drawing.Font("Algerian", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seanssaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.seanssaat.Location = new System.Drawing.Point(47, 521);
            this.seanssaat.Name = "seanssaat";
            this.seanssaat.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.seanssaat.Size = new System.Drawing.Size(348, 86);
            this.seanssaat.TabIndex = 37;
            this.seanssaat.TabStop = false;
            this.seanssaat.Text = "SAATLER";
            this.seanssaat.Visible = false;
            // 
            // cbdolusaat
            // 
            this.cbdolusaat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbdolusaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdolusaat.FormattingEnabled = true;
            this.cbdolusaat.Location = new System.Drawing.Point(10, 50);
            this.cbdolusaat.Name = "cbdolusaat";
            this.cbdolusaat.Size = new System.Drawing.Size(335, 33);
            this.cbdolusaat.TabIndex = 19;
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsec.Location = new System.Drawing.Point(409, 521);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(72, 26);
            this.lblsec.TabIndex = 38;
            this.lblsec.Text = "label2";
            this.lblsec.Visible = false;
            // 
            // frmsalonatama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 511);
            this.Controls.Add(this.lblsec);
            this.Controls.Add(this.seanssaat);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmsalonatama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmsalonatama";
            this.Load += new System.EventHandler(this.frmsalonatama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ngun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyıl)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.seanssaat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbfilmadi;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblkoltuksayısı;
        private System.Windows.Forms.ComboBox cbsalonadı;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Panel panelsaat;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.NumericUpDown ngun;
        private System.Windows.Forms.NumericUpDown nay;
        private System.Windows.Forms.NumericUpDown nyıl;
        private System.Windows.Forms.GroupBox seanssaat;
        private System.Windows.Forms.ComboBox cbdolusaat;
        private System.Windows.Forms.Label lblsec;
    }
}