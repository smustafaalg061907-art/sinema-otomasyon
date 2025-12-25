using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Sinema_Otomasyon
{
    public partial class frmsalonatama : Form
    {
        public frmsalonatama()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=Mustafaalg06;Initial Catalog=OTOMASYON;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmsalonatama_Load(object sender, EventArgs e)
        {
            bugününtarih();
            filmAdiGetir();
            salonGetir();

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

        void salonGetir()
        {
            string sorgu = "SELECT * FROM TBLSALON ";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbsalonadı.Items.Add(oku["SALONADI"].ToString());
            }
            connection.Close();

        }


        void bugününtarih()
        {
            nyıl.Minimum = 1900;
            nyıl.Maximum = 2030;
            nay.Minimum = 1;
            nay.Maximum = 12;
            ngun.Minimum = 1;
            ngun.Maximum = 31;
            var today = DateTime.Today;
            ngun.Value = DateTime.Today.Day;
            nay.Value = DateTime.Today.Month;
            nyıl.Value = DateTime.Today.Year;

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {



            if (btnkaydet.Text == "TAMAMLA")
            {
                string sorgu = "SELECT * FROM TBLKontrol WHERE TARIH=@tarih and SALONADİ=@salonadi";
                string tarih = ngun.Value + "." + nay.Value + "." + nyıl.Value;
                connection.Open();
                SqlCommand komut = new SqlCommand(sorgu, connection);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@salonadi", cbsalonadı.Text.ToUpper());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cbdolusaat.Items.Add(oku["SAAT"].ToString());
                }
                connection.Close();
                //saatsalonkontrol();
                saatkontrol();

                btnkaydet.Text = "KAYDET";
                btnkaydet.BackColor = Color.Yellow;
            }
            else
            {
                kaydet();
                temizle();
                btnkaydet.Text = "TAMAMLA";
                btnkaydet.BackColor = Color.Blue;
            }

        }
        void kaydet()
        {
            string sorgu = "INSERT INTO TBLKontrol (FİLMADI,SALONADİ,TARIH,SAAT) VALUES (@filmadi,@salonadi,@tarih,@saat)";
            connection.Open();
            SqlCommand ekle = new SqlCommand(sorgu, connection); 
            ekle.Parameters.AddWithValue("@filmadi", cbfilmadi.Text.ToUpper());
            ekle.Parameters.AddWithValue("@salonadi", cbsalonadı.Text.ToUpper());
            ekle.Parameters.AddWithValue("@tarih", ngun.Value + "." + nay.Value + "." + nyıl.Value);
            ekle.Parameters.AddWithValue("@saat", lblsec.Text);
            ekle.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Salon Atama İşlemi Başarıyla Gerçekleşti.");
        }


        void saatsalonkontrol()//deneme
        {
            panelsaat.Controls.Clear();
            for (int i = 10; i <= 23; i++)
            {
                for (int j = 0; j <= 30; j += 30)
                {
                    RadioButton rnd = new RadioButton();
                    rnd.ForeColor = Color.White;
                    rnd.FlatStyle = FlatStyle.Flat;
                    rnd.Width = 80;
                    rnd.CheckedChanged += new EventHandler(saatler);
                    if (j == 0)
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString() + "0";
                    }
                    else
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString();
                    }
                    if (cbdolusaat.Items.Contains(rnd.Text))
                    {
                        rnd.Visible = false;
                    }
                    panelsaat.Controls.Add(rnd);
                }
            }




        }
        private void saatler(object sender, EventArgs e)
        {
            foreach (RadioButton item in panelsaat.Controls)
                if (item.Checked)
                {
                    lblsec.Text = item.Text.ToString();
                }             
            {

            }
        }
        private void btntemizle_Click(object sender, EventArgs e)
        {
        

        }
        void temizle()
        {
            cbfilmadi.Items.Clear();
            cbsalonadı.Items.Clear();
            cbdolusaat.Items.Clear();
            lblsec.Text = "";
            bugününtarih();
            filmAdiGetir();
            salonGetir();
            panelsaat.Controls.Clear();
            btnkaydet.Text = "TAMAMLA";


        }
        void saatkontrol()
        {
            panelsaat.Controls.Clear();
            int y = 10; // dikey konum başlangıcı

            for (int i = 11; i <= 23; i++) // saat
            {
                for (int j = 0; j <= 30; j += 30) // dakika 
                {
                    RadioButton rnd = new RadioButton();
                    rnd.ForeColor = Color.Purple;
                    rnd.FlatStyle = FlatStyle.Flat;
                    rnd.Text = i.ToString("00") + ":" + j.ToString("00");
                    rnd.Location = new Point(10, y); // konum ayarla

                    rnd.Width = 80;
                     y += 25; // her eklemede biraz aşağı kaydır
                    rnd.CheckedChanged += new EventHandler(saatler);
                   
                    if (cbdolusaat.Items.Contains(rnd.Text))
                    {
                        rnd.Visible = false;
                    } 
                    else
                    
                    panelsaat.Controls.Add(rnd);
                }
            }


        }
            }





        }
    

