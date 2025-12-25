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
    public partial class frm13biletdetay : Form
    {
        public frm13biletdetay()
        {
            InitializeComponent();
        }

         public string biletno = "";
        SqlConnection connection = new SqlConnection(@"Data Source=Mustafaalg06;Initial Catalog=OTOMASYON;Integrated Security=True");
        private void frm13biletdetay_Load(object sender, EventArgs e)
        {
            lblbiletno.Text = biletno;
            lblbiletno2.Text = biletno;
            barkodnoolustur();
            bilgigetir();   
        }
        void bilgigetir()
        {
            string sorgu = "select * from TBLBilet where BKOD=@kod";
            connection.Open();
            SqlCommand getir = new SqlCommand(sorgu , connection);
            getir.Parameters.AddWithValue("@kod", biletno);
            SqlDataReader oku = getir.ExecuteReader();
            if (oku.Read())
            {
                lblfilmadı.Text = oku["FİLM"].ToString();
                lblfilmadi2.Text = oku["FİLM"].ToString();
                lbltelno.Text = oku["TELNO"].ToString();
                lbladsoyad.Text = oku["ADSOYAD"].ToString();
                lblbilettürü.Text = oku["TURU"].ToString();
                lblsalonadı.Text = oku["SALON"].ToString();
                lblsalonadı2.Text = oku["SALON"].ToString();
                lbltarih.Text = oku["TARIH"].ToString();
                lbltarihsaat.Text = oku["TARIH"].ToString();
                lblfilmsaati.Text = oku["SAAT"].ToString();
                lblkoltuklar.Text = oku["KOLTUKNO"].ToString();
                lblkoltuk2.Text = oku["KOLTUKNO"].ToString();
                lblsaattt.Text = oku["SAAT"].ToString();
                lblucret.Text = oku["UCRET"].ToString() + " TL";
            }

            connection.Close();
        }
        void barkodnoolustur()
        {
            {
                Random rnd = new Random();
                string karakterler = "01234567899876543210ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZQWXXWQZÜUVYTŞSTÖONMLKJİIHĞGFEDÇCBA";
                string kod = "";
                for (int i = 0; i < 10; i++)
                {
                    kod += karakterler[rnd.Next(karakterler.Length)];
                }
                lblbarkod1.Text = kod;
                lblbarkod2.Text = kod;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblfilmadı_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblfilmsaati_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblbilettürü_Click(object sender, EventArgs e)
        {

        }

        private void lbltarih_Click(object sender, EventArgs e)
        {

        }

        private void lblfilmadi2_Click(object sender, EventArgs e)
        {

        }

        private void lbltelno_Click(object sender, EventArgs e)
        {

        }

        private void lbladsoyad_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbltarihsaat_Click(object sender, EventArgs e)
        {

        }
    }
}
