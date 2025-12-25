using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sinema_Otomasyon
{
    public partial class frm11Biletolusturma : Form
    {
        public frm11Biletolusturma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=Mustafaalg06;Initial Catalog=OTOMASYON;Integrated Security=True");
        private void frm11Biletolusturma_Load(object sender, EventArgs e)
        {
            filmAdiGetir();
            biletnoolusturma();
        }
        void biletnoolusturma()
        {
            Random rnd = new Random();
            string karakterler = "01234567899876543210ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZQWXXWQZÜUVYTŞSTÖONMLKJİIHĞGFEDÇCBA";
            string kod = "";
            for (int i = 0; i < 10; i++)
            {
                kod += karakterler[rnd.Next(karakterler.Length)];
            }
            txtbiletnö.Text = kod;
        }

        void filmAdiGetir()
        {
            string sorgu = "SELECT * FROM TBLFilmler ";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbfilmadi.Items.Add(oku["ADI"].ToString());
            }
            connection.Close();
        }

        private void cbfilmadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DISTINCT ile aynı tarihi birden fazla kez eklememek için

            cbtarih.Items.Clear();
            string sorgu = "SELECT DISTINCT TARIH FROM TBLKontrol WHERE FİLMADI=@filmadı";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@filmadı", cbfilmadi.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbtarih.Items.Add(oku["TARIH"].ToString());
            }
            connection.Close();
        }
        void biletnosorgu()
        {
            string sorgu = "SELECT * FROM TBLBilet WHERE BKOD=@biletnö";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@biletnö", txtbiletnö.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            if (!oku.Read())
            {
                kaydetme();
            }
            else
            {
                biletnoolusturma();
                connection.Close();
                biletnosorgu();
            }

            connection.Close();
        }

        void kaydetme()
        {
            string sorgu = "INSERT INTO TBLBilet (BKOD,ADSOYAD,TELNO,KOLTUKNO,FİLM,TARIH,SAAT,SALON,UCRET,TURU) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
            connection.Close();
            connection.Open();
            SqlCommand kayıt = new SqlCommand(sorgu, connection);
            kayıt.Parameters.AddWithValue("@p1", txtbiletnö.Text.ToString());
            kayıt.Parameters.AddWithValue("@p2", txtadsoyad.Text.ToUpper().ToString());
            kayıt.Parameters.AddWithValue("@p3", txttelno.Text.ToString());
            kayıt.Parameters.AddWithValue("@p4", txtkoltukno.Text.ToString());
            kayıt.Parameters.AddWithValue("@p5", cbfilmadi.Text.ToString());
            kayıt.Parameters.AddWithValue("@p6", cbtarih.Text.ToString());
            kayıt.Parameters.AddWithValue("@p7", lblseanssec.Text.ToString());
            kayıt.Parameters.AddWithValue("@p8", cbsalonadı.Text.ToString());
         //   kayıt.Parameters.AddWithValue("@p9", txtbiletücret.Text.ToString());
            kayıt.Parameters.AddWithValue("@p10", cbbilettürü.Text.ToString());
            kayıt.ExecuteNonQuery();
            connection.Close();

            string sorgu2 = "UPDATE TBLKontrol SET KOLTUKLAR=@numara WHERE FİLMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat AND SALONADİ=@salonadi";
            connection.Open();
            SqlCommand guncelle = new SqlCommand(sorgu2, connection);
            guncelle.Parameters.AddWithValue("@numara", lblgelenkoltuk.Text.ToString() + "," + txtkoltukno.Text.ToString());
            guncelle.Parameters.AddWithValue("@filmadi", cbfilmadi.Text.ToString());
            guncelle.Parameters.AddWithValue("@tarih", cbtarih.Text.ToString());
            guncelle.Parameters.AddWithValue("@saat", lblseanssec.Text.ToString());
            guncelle.Parameters.AddWithValue("@salonadi", cbsalonadı.Text.ToString());
            guncelle.ExecuteNonQuery();
            connection.Close();


            MessageBox.Show("BİLET ONAYLANDI😊");
            salondurumu();
        }


        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtadsoyad.Text != "" && txtbiletnö.Text != "" && txtkoltukno.Text != "" && txttelno.Text != "" && cbbilettürü.Text != "" && cbfilmadi.Text != "" && cbsalonadı.Text != "" && cbtarih.Text != "")
            {
                //MessageBox.Show("İşlem Başarılı");
                biletnosorgu();
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }

        }

        void secilenler()
        {
            txtkoltukno.Text = "";
            foreach (string item in lbdolankoltuk.Items)
            {
                txtkoltukno.Text += "," + item;
            }
            if (txtkoltukno.Text.Length > 1)
            {
                txtkoltukno.Text = txtkoltukno.Text.Substring(1);
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

            if (btn.ForeColor == Color.White)//dolu koltuk
            {
                MessageBox.Show("Bu Koltuk Doludur!");
            }
            else
            {
                if (btn.ForeColor == Color.Yellow)
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.koltuk2);
                    btn.ForeColor = Color.Black;
                    lbdolankoltuk.Items.Add(btn.Text);
                    secilenler();
                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.koltuk);
                    btn.ForeColor = Color.Yellow;
                    lbdolankoltuk.Items.Remove(btn.Text);
                    secilenler();
                }
            }

            {

            }



        }

        private void cbtarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelsaat.Controls.Clear();

            string sorgu = "SELECT DISTINCT SAAT FROM TBLKontrol WHERE FİLMADI=@filmadı AND TARIH=@tarih";

            using (SqlConnection conn = new SqlConnection(connection.ConnectionString))
            using (SqlCommand komut = new SqlCommand(sorgu, conn))
            {
                komut.Parameters.AddWithValue("@filmadı", cbfilmadi.Text);
                komut.Parameters.AddWithValue("@tarih", cbtarih.Text);

                conn.Open();
                using (SqlDataReader oku = komut.ExecuteReader())
                {
                    int y = 10; // RadioButton'ların dikey konumu
                    while (oku.Read())
                    {
                        string saat = oku["SAAT"].ToString();
                        RadioButton rb = new RadioButton
                        {
                            Text = saat,
                            ForeColor = Color.Red,
                            Location = new Point(10, y)
                        };
                        rb.CheckedChanged += saatler;
                        panelsaat.Controls.Add(rb);

                        y += 25; // Sonraki RadioButton biraz aşağıya kayar
                    }
                }
            }




        }

        private void saatler(object sender, EventArgs e)
        {

            foreach (RadioButton item in panelsaat.Controls)
            {
                if (item.Checked)
                {
                    lblseanssec.Text = item.Text;
                    cbsalonadı.Items.Clear();

                    string sorgu = "SELECT DISTINCT SALONADİ FROM TBLKontrol WHERE FİLMADI=@filmadı AND  TARIH=@tarih AND SAAT=@saat";
                    connection.Open();
                    SqlCommand komut = new SqlCommand(sorgu, connection);
                    komut.Parameters.AddWithValue("@filmadı", cbfilmadi.Text);
                    komut.Parameters.AddWithValue("@tarih", cbtarih.Text);
                    komut.Parameters.AddWithValue("@saat", lblseanssec.Text);
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        cbsalonadı.Items.Add(oku["SALONADİ"].ToString());


                    }
                    connection.Close();
                }
            }
        }



        private void cbsalonadı_SelectedIndexChanged(object sender, EventArgs e)
        {

            salondurumu();
        }

        void salondurumu()
        {
            string sorgu = "SELECT * FROM TBLSALON  WHERE SALONADI=@salonadı";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@salonadı", cbsalonadı.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblkoltuksayısı.Text = oku["KOLTUKSAYISI"].ToString();



            }
            connection.Close();
            koltukgetir();

            DOLDUR();
        }

        void DOLDUR()

        {
            {
                koltukpaneli.Controls.Clear();
                int sayi = Convert.ToInt16(lblkoltuksayısı.Text);
                for (int i = 1; i <= sayi; i++)
                {
                    System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                    btn.Text = i.ToString();
                    btn.Name = i.ToString();
                    btn.Width = 40;
                    btn.Height = 40;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13);

                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Purple;
                    btn.Click += Btn_Click;

                    if (lbgelenkoltuk.Items.Contains(btn.Text))
                    {
                        btn.Image = (System.Drawing.Image)(Properties.Resources.koltuk3);
                        btn.ForeColor = Color.White;
                        //btn.BackColor = Color.DarkRed;//seçili olan koltuklar
                    }
                    else
                    {
                        btn.Image = (System.Drawing.Image)(Properties.Resources.koltuk);
                        btn.ForeColor = Color.Yellow;
                        //btn.BackColor = Color.LightSkyBlue;//boş koltuklar
                    }


                    koltukpaneli.Controls.Add(btn);
                }
            }
        }








        void koltukgetir()
        {
            lblgelenkoltuk.Text = "";
            string sorgu = "SELECT * FROM TBLKontrol WHERE FİLMADI=@filmadı AND TARIH=@tarih AND SAAT=@saat AND SALONADİ=@salonadı";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@filmadı", cbfilmadi.Text);
            komut.Parameters.AddWithValue("@tarih", cbtarih.Text);
            komut.Parameters.AddWithValue("@saat", lblseanssec.Text);
            komut.Parameters.AddWithValue("@salonadı", cbsalonadı.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblgelenkoltuk.Text += " ," + oku["KOLTUKLAR"].ToString();
                if (lblgelenkoltuk.Text.Length > 2)
                {
                    lblgelenkoltuk.Text = lblgelenkoltuk.Text.Substring(2);
                }



            }
            connection.Close();
            koltukayırma();
        }
        void koltukayırma()
        {
            lbgelenkoltuk.Items.Clear();
            string no = "";
            string[] sec;
            no = lblgelenkoltuk.Text.ToString();
            sec = no.Split(',');
            foreach (string bulunan in sec)
            {
                lbgelenkoltuk.Items.Add(bulunan);
            }
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtadsoyad.Text = "";
            txtbiletnö.Text = "";
            //txtbiletücret.Text = "";
            txtkoltukno.Text = "";
            txttelno.Text = "";
            cbsalonadı.Text = "";
            cbsalonadı.Items.Clear();
            cbbilettürü.Text = "";
            cbbilettürü.Items.Clear();
            cbbilettürü.Items.Add("YETİSKİN");
            cbbilettürü.Items.Add("ÖGRENCİ");
            cbtarih.Text = "";
            cbtarih.Items.Clear();
            biletnoolusturma();
            panelsaat.Controls.Clear();
            lbdolankoltuk.Items.Clear();
            lbgelenkoltuk.Text = "";
            lblkoltuksayısı.Text = "";
            lblseanssec.Text = "";
            koltukpaneli.Controls.Clear();
            cbfilmadi.Items.Clear();
            filmAdiGetir();
            txtadsoyad.Focus();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void txtbiletücret_TextChanged(object sender, EventArgs e)

        { }
  
       


        

        private void cbbilettürü_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbücret_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }



}


