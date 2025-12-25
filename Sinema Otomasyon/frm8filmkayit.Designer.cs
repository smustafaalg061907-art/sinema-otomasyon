namespace Sinema_Otomasyon
{
    partial class frm8filmkayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm8filmkayit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttür = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttarıh = new System.Windows.Forms.TextBox();
            this.cbdublaj = new System.Windows.Forms.ComboBox();
            this.cbtür = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cbpuan = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtyonetmen = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtoyuncular = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnresimyukle = new System.Windows.Forms.Button();
            this.pbresim = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblKarakter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdetay = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).BeginInit();
            this.groupBox7.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(928, 91);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Wide Latin", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(824, 0);
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
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "FİLM KAYIT🕊️";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Font = new System.Drawing.Font("Algerian", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(20, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(462, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FİLM ADI 🕊️";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtad
            // 
            this.txtad.BackColor = System.Drawing.Color.White;
            this.txtad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtad.Location = new System.Drawing.Point(10, 36);
            this.txtad.Multiline = true;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(449, 37);
            this.txtad.TabIndex = 0;
            this.txtad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.txttür);
            this.groupBox2.Font = new System.Drawing.Font("Algerian", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(20, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 82);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FİLM TÜRÜ 🕊️";
            // 
            // txttür
            // 
            this.txttür.Location = new System.Drawing.Point(10, 39);
            this.txttür.Name = "txttür";
            this.txttür.Size = new System.Drawing.Size(449, 40);
            this.txttür.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.txttarıh);
            this.groupBox3.Controls.Add(this.cbdublaj);
            this.groupBox3.Controls.Add(this.cbtür);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.cbpuan);
            this.groupBox3.Font = new System.Drawing.Font("Algerian", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox3.Location = new System.Drawing.Point(17, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 191);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ÖZELLİKLER 🕊️";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txttarıh
            // 
            this.txttarıh.Location = new System.Drawing.Point(167, 91);
            this.txttarıh.Multiline = true;
            this.txttarıh.Name = "txttarıh";
            this.txttarıh.Size = new System.Drawing.Size(249, 36);
            this.txttarıh.TabIndex = 14;
            this.txttarıh.TextChanged += new System.EventHandler(this.txttarıh_TextChanged);
            // 
            // cbdublaj
            // 
            this.cbdublaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbdublaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdublaj.Font = new System.Drawing.Font("Algerian", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdublaj.FormattingEnabled = true;
            this.cbdublaj.Location = new System.Drawing.Point(266, 39);
            this.cbdublaj.Name = "cbdublaj";
            this.cbdublaj.Size = new System.Drawing.Size(190, 33);
            this.cbdublaj.TabIndex = 13;
            // 
            // cbtür
            // 
            this.cbtür.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtür.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtür.Font = new System.Drawing.Font("Algerian", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtür.FormattingEnabled = true;
            this.cbtür.Items.AddRange(new object[] {
            ""});
            this.cbtür.Location = new System.Drawing.Point(13, 39);
            this.cbtür.Name = "cbtür";
            this.cbtür.Size = new System.Drawing.Size(190, 33);
            this.cbtür.TabIndex = 12;
            this.cbtür.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "YAYIN TARİHİ";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Silver;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Algerian", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(6, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 30);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "IMDb PUANI :";
            // 
            // cbpuan
            // 
            this.cbpuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpuan.Font = new System.Drawing.Font("Algerian", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbpuan.FormattingEnabled = true;
            this.cbpuan.Items.AddRange(new object[] {
            "1",
            "1.1",
            "1.2",
            "1.3",
            "1.4",
            "1.5",
            "1.6",
            "1.7",
            "1.8",
            "1.9",
            "2",
            "2.1",
            "2.2",
            "2.3",
            "2.4",
            "2.5",
            "2.6",
            "2.7",
            "2.8",
            "2.9",
            "3",
            "3.1",
            "3.2",
            "3.3",
            "3.4",
            "3.5",
            "3.6",
            "3.7",
            "3.8",
            "3.9",
            "4",
            "4.1",
            "4.2",
            "4.3",
            "4.4",
            "4.5",
            "4.6",
            "4.7",
            "4.8",
            "4.9",
            "5",
            "5.1",
            "5.2",
            "5.3",
            "5.4",
            "5.5",
            "5.6",
            "5.7",
            "5.8",
            "5.9",
            "6",
            "6.1",
            "6.2",
            "6.3",
            "6.4",
            "6.5",
            "6.6",
            "6.7",
            "6.8",
            "6.9",
            "7",
            "7.1",
            "7.2",
            "7.3",
            "7.4",
            "7.5",
            "7.6",
            "7.7",
            "7.8",
            "7.9",
            "8",
            "8.1",
            "8.2",
            "8.3",
            "8.4",
            "8.5",
            "8.6",
            "8.7",
            "8.8",
            "8.9",
            "9",
            "9.1",
            "9.2",
            "9.3",
            "9.4",
            "9.5",
            "9.6",
            "9.7",
            "9.8",
            "9.9",
            "10"});
            this.cbpuan.Location = new System.Drawing.Point(192, 152);
            this.cbpuan.MaxLength = 10;
            this.cbpuan.Name = "cbpuan";
            this.cbpuan.Size = new System.Drawing.Size(110, 33);
            this.cbpuan.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Silver;
            this.groupBox4.Controls.Add(this.txtyonetmen);
            this.groupBox4.Font = new System.Drawing.Font("Algerian", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox4.Location = new System.Drawing.Point(488, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 114);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "YÖNETMEN 🕊️";
            // 
            // txtyonetmen
            // 
            this.txtyonetmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtyonetmen.Location = new System.Drawing.Point(3, 36);
            this.txtyonetmen.Multiline = true;
            this.txtyonetmen.Name = "txtyonetmen";
            this.txtyonetmen.Size = new System.Drawing.Size(422, 75);
            this.txtyonetmen.TabIndex = 0;
            this.txtyonetmen.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Silver;
            this.groupBox5.Controls.Add(this.txtoyuncular);
            this.groupBox5.Font = new System.Drawing.Font("Algerian", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox5.Location = new System.Drawing.Point(488, 217);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(428, 241);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "OYUNCULAR 🕊️";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // txtoyuncular
            // 
            this.txtoyuncular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtoyuncular.Location = new System.Drawing.Point(3, 36);
            this.txtoyuncular.Multiline = true;
            this.txtoyuncular.Name = "txtoyuncular";
            this.txtoyuncular.Size = new System.Drawing.Size(422, 202);
            this.txtoyuncular.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Silver;
            this.groupBox6.Controls.Add(this.btnresimyukle);
            this.groupBox6.Controls.Add(this.pbresim);
            this.groupBox6.Font = new System.Drawing.Font("Algerian", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox6.Location = new System.Drawing.Point(17, 465);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(465, 288);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "FİLM AFİŞ 🕊️";
            // 
            // btnresimyukle
            // 
            this.btnresimyukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnresimyukle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnresimyukle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnresimyukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresimyukle.Font = new System.Drawing.Font("Wide Latin", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresimyukle.ForeColor = System.Drawing.Color.White;
            this.btnresimyukle.Location = new System.Drawing.Point(3, 238);
            this.btnresimyukle.Name = "btnresimyukle";
            this.btnresimyukle.Size = new System.Drawing.Size(459, 47);
            this.btnresimyukle.TabIndex = 19;
            this.btnresimyukle.Text = "YÜKLE";
            this.btnresimyukle.UseVisualStyleBackColor = false;
            this.btnresimyukle.Click += new System.EventHandler(this.btnresimyukle_Click);
            // 
            // pbresim
            // 
            this.pbresim.BackColor = System.Drawing.Color.White;
            this.pbresim.Image = ((System.Drawing.Image)(resources.GetObject("pbresim.Image")));
            this.pbresim.Location = new System.Drawing.Point(61, 36);
            this.pbresim.Name = "pbresim";
            this.pbresim.Size = new System.Drawing.Size(321, 196);
            this.pbresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbresim.TabIndex = 18;
            this.pbresim.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Silver;
            this.groupBox7.Controls.Add(this.lblKarakter);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.txtdetay);
            this.groupBox7.Font = new System.Drawing.Font("Algerian", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox7.Location = new System.Drawing.Point(488, 468);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(428, 285);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "FİLM DETAY 🕊️";
            // 
            // lblKarakter
            // 
            this.lblKarakter.AutoSize = true;
            this.lblKarakter.Location = new System.Drawing.Point(337, 254);
            this.lblKarakter.Name = "lblKarakter";
            this.lblKarakter.Size = new System.Drawing.Size(60, 28);
            this.lblKarakter.TabIndex = 3;
            this.lblKarakter.Text = "300";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "MAX 300  KARAKTER";
            // 
            // txtdetay
            // 
            this.txtdetay.BackColor = System.Drawing.Color.White;
            this.txtdetay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtdetay.Font = new System.Drawing.Font("Arial Narrow", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdetay.Location = new System.Drawing.Point(3, 36);
            this.txtdetay.MaxLength = 300;
            this.txtdetay.Multiline = true;
            this.txtdetay.Name = "txtdetay";
            this.txtdetay.Size = new System.Drawing.Size(422, 246);
            this.txtdetay.TabIndex = 1;
            this.txtdetay.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Black;
            this.btnkaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkaydet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Font = new System.Drawing.Font("Wide Latin", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.ForeColor = System.Drawing.Color.White;
            this.btnkaydet.Location = new System.Drawing.Point(0, 759);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(928, 54);
            this.btnkaydet.TabIndex = 18;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // frm8filmkayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 813);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm8filmkayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm8filmkayit";
            this.Load += new System.EventHandler(this.frm8filmkayit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.ComboBox cbpuan;
        private System.Windows.Forms.TextBox txtdetay;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnresimyukle;
        private System.Windows.Forms.PictureBox pbresim;
        private System.Windows.Forms.Label lblKarakter;
        private System.Windows.Forms.TextBox txttür;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbdublaj;
        private System.Windows.Forms.ComboBox cbtür;
        private System.Windows.Forms.TextBox txtyonetmen;
        private System.Windows.Forms.TextBox txtoyuncular;
        public System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txttarıh;
    }
}