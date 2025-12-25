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


namespace Sinema_Otomasyon
{
    public partial class Oyunculst : UserControl
    {
        public Oyunculst()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=Mustafaalg06;Initial Catalog=OTOMASYON;Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand SİL = new SqlCommand("DELETE FROM TBLOYUNCULAR WHERE ID=@p1", connection);
            SİL.Parameters.AddWithValue("@p1", lblid.Text);
            SİL.ExecuteNonQuery();
            connection.Close();
            this.Hide();
            MessageBox.Show(lblAdSoyad.Text + " Kişisine Ait Kayıt Başarılı Şekilde Silinmiştir");




            //connection.Open();
            //SqlCommand SİL = new SqlCommand("DELETE FROM TBLOYUNCULAR WHERE ID=@p1", connection);
            //SİL.Parameters.AddWithValue("@p1", lblid.Text);
            //SİL.ExecuteNonQuery();
            //connection.Close();
            //this.Hide();
            //MessageBox.Show(lblAdSoyad.Text + " Kişisine Ait Kayıt Başarılı Şekilde Silinmiştir");
        }

        private void Oyunculst_Load(object sender, EventArgs e)
        {

        }

        private void lblcinsiyet_Click(object sender, EventArgs e)
        {
            //connection.Open();
            //string sorgu = "SELECT * FROM TBLOYUNCULAR WHERE ID=@p1";
            //SqlCommand komut = new SqlCommand(sorgu, connection);
            //komut.Parameters.AddWithValue("@p1", lblid.Text);
            //SqlDataReader oku = komut.ExecuteReader();
            //if (oku.Read())
            //{
            //    lblcinsiyet.Text = oku["CİNSİYET"].ToString();
            //}
            //connection.Close();
            //if (lblcinsiyet.Text == "0") ;
            ////{
            ////    pbcinsiyet.ImageLocation = @"C:\\Users\\smust\\OneDrive\\Desktop\\Yeni klasör\\d.png";

            ////}
            ////    else
            ////{
            ////    pbcinsiyet.ImageLocation = @"C:\\Users\\smust\\OneDrive\\Desktop\\Yeni klasör\\i.png";
            ////}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sorgu = "SELECT * FROM TBLOYUNCULAR WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lblcinsiyet.Text = oku["CİNSİYET"].ToString();
            }
            connection.Close();
            if (lblcinsiyet.Text == "0") ;
        //    {
        //        pbcinsiyet.ImageLocation = @"C:\\Users\\smust\\OneDrive\\Desktop\\Yeni klasör\\d.png";

        //    }


        //        else
        //    {
        //        pbcinsiyet.ImageLocation = @"C:\\Users\\smust\\OneDrive\\Desktop\\Yeni klasör\\i.png";
        //    }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            connection.Open();
            string sorgu = "SELECT * FROM TBLOYUNCULAR WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@p1", lblid.Text);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())

            {
                MessageBox.Show(oku["CINSIYET"].ToString());
            }
            if (oku.Read()) ;
            connection.Close();
        }

     

        //{
        //    connection.Open();
        //    string sorgu = "SELECT * FROM TBLOYUNCULAR WHERE ID=@p1";
        //    SqlCommand komut = new SqlCommand(sorgu, connection);
        //    komut.Parameters.AddWithValue("@p1", lblid.Text);
        //    SqlDataReader oku = komut.ExecuteReader();
        //    if (oku.Read())
        //    {
        //        MessageBox.Show(oku["CİNSİYET"].ToString());
        //    }
        //    if (oku.Read())

        //        connection.Close();
        //}
    }
}
