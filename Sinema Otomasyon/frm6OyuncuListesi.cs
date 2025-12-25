using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Sinema_Otomasyon
{
    public partial class frm6OyuncuListesi : Form
    {
        public frm6OyuncuListesi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=Mustafaalg06;Initial Catalog=OTOMASYON;Integrated Security=True");
        private void frm6OyuncuListesi_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            string sorgu = "SELECT* FROM TBLOYUNCULAR ORDER BY ADSOYAD ASC";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Oyunculst arac = new Oyunculst();
                arac.lblid.Text = oku["ID"].ToString();
                arac.lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                arac.pbresimdetay.ImageLocation = oku["RESIM"].ToString();
                ListePaneli.Controls.Add(arac);
            }



            connection.Close();
        }

        private void ListePaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();

            connection.Open();
            SqlCommand ara = new SqlCommand("Select * FROM TBLOYUNCULAR WHERE ADSOYAD LIKE '%" + txtarama.Text + "%' ORDER BY ADSOYAD ASC", connection);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                Oyunculst arac = new Oyunculst();
                arac.lblid.Text = oku["ID"].ToString();
                arac.lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                arac.pbresimdetay.ImageLocation = oku["RESIM"].ToString();
                ListePaneli.Controls.Add(arac);
            }

            connection.Close();
        }
    }
}
