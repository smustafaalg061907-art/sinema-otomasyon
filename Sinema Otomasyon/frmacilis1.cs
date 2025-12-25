using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//sql bağlantısı için kütüphaneyi ekle.
using System.Data.SqlClient;


namespace Sinema_Otomasyon
{
    public partial class frmacilis1 : Form
    {
        public frmacilis1()
        {
            InitializeComponent();
        }
        //CONNECTİONSTRING 
        SqlConnection connection = new SqlConnection(@"Data Source=Mustafaalg06;Initial Catalog=OTOMASYON;Integrated Security=True");
        private object txtyonetici;

        //SqlConnection connection = new SqlConnection("Data Source=;Initial Catalog=;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
          Application ExitApplication;
        }

        private void btngiris_Click(object sender, EventArgs e)
        {



            //giris işlemi 
   
            connection.Open();
            SqlCommand sorgula = new SqlCommand("Select * From TableOTO WHERE Yönetici=@parameters1 AND Sifre=@parameters2", connection);
            SqlParameter sqlParameter = sorgula.Parameters.AddWithValue("@parameters1", txtkullaniciadi.Text);
            sorgula.Parameters.AddWithValue("@parameters2", txtsifre.Text);
            SqlDataReader reader = sorgula.ExecuteReader();
            if (reader.Read())
            {
                //eğer giriş başarılı ise ana forma geçiş yap
                MessageBox.Show("Giriş Başarılı😊." +
                    "HOSGELDINIZ");
                frm2 frm = new frm2();
                frm.kisiadisoyadi = reader["ADSOYAD"].ToString();
                frm.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.Lütfen Tekrar Deneyiniz😓.");
            }


            connection.Close();
            txtkullaniciadi.Text = "";
            txtsifre.Text = "";
            txtkullaniciadi.Focus();

            //connection.Open();
            //if (connection.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("Bağlantı Başarılı");

            //}
            //    connection.Close();
        }
    }
}
