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
using System.Data.SqlTypes;



namespace Sinema_Otomasyon
{
    public partial class frm4yonetmenlst : Form
    {
        public frm4yonetmenlst()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=Mustafaalg06;Initial Catalog=OTOMASYON;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm4yonetmenlst_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            string sorgu    = "SELECT * FROM TBLYONETMENLER ORDER BY ADSOYAD ASC";
            SqlCommand komut = new SqlCommand(sorgu,connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
              YonetmenListesi arac = new YonetmenListesi();
                arac.lblid.Text = oku["ID"].ToString();
                arac.lblAdSoyad.Text=oku["ADSOYAD"].ToString();
                arac.pbResimdetay.ImageLocation = oku ["GÖRSEL"].ToString();
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
            SqlCommand ara = new SqlCommand("Select * FROM TBLYONETMENLER WHERE ADSOYAD LIKE '%" + txtarama.Text + "%' ORDER BY ADSOYAD ASC", connection);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                YonetmenListesi arac = new YonetmenListesi();
                arac.lblid.Text = oku["ID"].ToString();
                arac.lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                arac.pbResimdetay.ImageLocation = oku["GÖRSEL"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            connection.Close();
        }
    }
}
