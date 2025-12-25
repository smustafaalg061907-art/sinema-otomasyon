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
    public partial class YonetmenListesi : UserControl
    {
        public YonetmenListesi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=Mustafaalg06;Initial Catalog=OTOMASYON;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

            connection.Open();
            string sorgu = "SELECT * FROM TBLYONETMENLER WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lblCinsiyet.Text = oku["CİNSİYET"].ToString();
            }
            connection.Close();
            if (lblCinsiyet.Text == "0");
            //{
            //    pbCinsiyet.ImageLocation = @"C:\\Users\\smust\\OneDrive\\Desktop\\Yeni klasör\\d.png";

            //}
            //else
            //{
            //    pbCinsiyet.ImageLocation = @"C:\\Users\\smust\\OneDrive\\Desktop\\Yeni klasör\\i.png";
            //}

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void YonetmenListesi_Load(object sender, EventArgs e)
        {

        }

        private void lblCinsiyet_Click(object sender, EventArgs e)
        {
           
        }

        private void btnresimyukle_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sorgu = "SELECT * FROM TBLYONETMENLER WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader oku = komut.ExecuteReader();
           
            if (oku.Read())
               
            {
                MessageBox.Show(oku["CİNSİYET"].ToString());
            }
            if (oku.Read()) ;
                 connection.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand SİL= new SqlCommand("DELETE FROM TBLYONETMENLER WHERE ID=@p1", connection);
            SİL.Parameters.AddWithValue("@p1", lblid.Text);
            SİL.ExecuteNonQuery();
            connection.Close();
            this.Hide();
           MessageBox.Show(lblAdSoyad.Text+" Kişisine Ait Kayıt Başarılı Şekilde Silinmiştir");
        }
    }
}
