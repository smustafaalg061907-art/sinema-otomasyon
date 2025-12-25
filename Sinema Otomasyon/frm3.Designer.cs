namespace Sinema_Otomasyon
{
    partial class frm3
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
            System.Windows.Forms.RadioButton rberkek;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbkadin = new System.Windows.Forms.RadioButton();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnresimyukle = new System.Windows.Forms.Button();
            this.pbresim = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ngun = new System.Windows.Forms.NumericUpDown();
            this.nay = new System.Windows.Forms.NumericUpDown();
            this.nyil = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            rberkek = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyil)).BeginInit();
            this.SuspendLayout();
            // 
            // rberkek
            // 
            rberkek.AutoSize = true;
            rberkek.Location = new System.Drawing.Point(8, 342);
            rberkek.Name = "rberkek";
            rberkek.Size = new System.Drawing.Size(110, 29);
            rberkek.TabIndex = 13;
            rberkek.Text = "ERKEK";
            rberkek.UseVisualStyleBackColor = true;
            rberkek.CheckedChanged += new System.EventHandler(this.rberkek_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 91);
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
            this.button1.Location = new System.Drawing.Point(745, 0);
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "YÖNETMEN KAYIT🕊️";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(rberkek);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rbkadin);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(34, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 392);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "🕊️";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "DOĞUM TARİHİ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(324, 322);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(19, 146);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(250, 37);
            this.txtsoyad.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 335);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "SOYAD";
            // 
            // rbkadin
            // 
            this.rbkadin.AutoSize = true;
            this.rbkadin.BackColor = System.Drawing.Color.Silver;
            this.rbkadin.Location = new System.Drawing.Point(199, 342);
            this.rbkadin.Name = "rbkadin";
            this.rbkadin.Size = new System.Drawing.Size(103, 29);
            this.rbkadin.TabIndex = 14;
            this.rbkadin.TabStop = true;
            this.rbkadin.Text = "KADIN";
            this.rbkadin.UseVisualStyleBackColor = false;
            this.rbkadin.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtad
            // 
            this.txtad.BackColor = System.Drawing.SystemColors.Window;
            this.txtad.Location = new System.Drawing.Point(19, 61);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(250, 37);
            this.txtad.TabIndex = 5;
            this.txtad.TextChanged += new System.EventHandler(this.txtad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.btnresimyukle);
            this.groupBox2.Controls.Add(this.pbresim);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(460, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 329);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "🕊️";
            // 
            // btnresimyukle
            // 
            this.btnresimyukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnresimyukle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnresimyukle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnresimyukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresimyukle.Font = new System.Drawing.Font("Wide Latin", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresimyukle.ForeColor = System.Drawing.Color.White;
            this.btnresimyukle.Location = new System.Drawing.Point(3, 272);
            this.btnresimyukle.Name = "btnresimyukle";
            this.btnresimyukle.Size = new System.Drawing.Size(358, 54);
            this.btnresimyukle.TabIndex = 2;
            this.btnresimyukle.Text = "YÜKLE";
            this.btnresimyukle.UseVisualStyleBackColor = false;
            this.btnresimyukle.Click += new System.EventHandler(this.btnresimyukle_Click);
            // 
            // pbresim
            // 
            this.pbresim.Image = ((System.Drawing.Image)(resources.GetObject("pbresim.Image")));
            this.pbresim.Location = new System.Drawing.Point(69, 61);
            this.pbresim.Name = "pbresim";
            this.pbresim.Size = new System.Drawing.Size(230, 200);
            this.pbresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbresim.TabIndex = 1;
            this.pbresim.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "GÖRSEL";
            // 
            // ngun
            // 
            this.ngun.Location = new System.Drawing.Point(53, 352);
            this.ngun.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.ngun.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ngun.Name = "ngun";
            this.ngun.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ngun.Size = new System.Drawing.Size(74, 37);
            this.ngun.TabIndex = 8;
            this.ngun.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nay
            // 
            this.nay.Location = new System.Drawing.Point(173, 352);
            this.nay.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nay.Name = "nay";
            this.nay.Size = new System.Drawing.Size(74, 37);
            this.nay.TabIndex = 9;
            this.nay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nyil
            // 
            this.nyil.Location = new System.Drawing.Point(283, 352);
            this.nyil.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.nyil.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nyil.Name = "nyil";
            this.nyil.Size = new System.Drawing.Size(124, 37);
            this.nyil.TabIndex = 10;
            this.nyil.Tag = "";
            this.nyil.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.nyil.ValueChanged += new System.EventHandler(this.nyıl_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "CİNSİYET";
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Black;
            this.btnkaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkaydet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Font = new System.Drawing.Font("Wide Latin", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.ForeColor = System.Drawing.Color.White;
            this.btnkaydet.Location = new System.Drawing.Point(0, 529);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(849, 54);
            this.btnkaydet.TabIndex = 17;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 583);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nyil);
            this.Controls.Add(this.nay);
            this.Controls.Add(this.ngun);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Algerian", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm3";
            this.Load += new System.EventHandler(this.frm3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown ngun;
        private System.Windows.Forms.NumericUpDown nay;
        private System.Windows.Forms.NumericUpDown nyil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbkadin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbresim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnresimyukle;
        private System.Windows.Forms.Button btnkaydet;
    }
}