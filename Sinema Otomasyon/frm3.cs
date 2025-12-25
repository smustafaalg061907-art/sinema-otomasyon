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
using System.Drawing.Text;

namespace Sinema_Otomasyon
{
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-UB6A5S3\\SQLEXPRESS;Initial Catalog=SinemaOtomasyon;Integrated Security=True");
        SqlConnection connection = new SqlConnection(@"Data Source=Mustafaalg06;Initial Catalog=OTOMASYON;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "1";
        }
        public string cins = "1";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm3_Load(object sender, EventArgs e)
        {

        }
        public string resimYolu = "";
        private void btnresimyukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Title = "Resim Seçiniz";
            dosya.Filter = "JPG Dosyalar (*.jpg)|*.jpg|PNG Dosyalar (*.png)|*.png|Tüm Dosyalar (*.*)|*.*";
            dosya.FilterIndex = 3;
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                pbresim.ImageLocation = dosya.FileName;

                resimYolu = dosya.FileName.ToString();




            }
        }

        private void rberkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "0";
        }
        public string cinsiyet = "0";

        private void btnkaydet_Click(object sender, EventArgs e)
        {
           
            if (txtad.Text != "" && txtsoyad.Text != "" && resimYolu != "")

            {
                String AdSoyad = txtad.Text.ToString().ToUpper() + " " + txtsoyad.Text.ToString().ToUpper();
                //MessageBox.Show(AdSoyad);

                connection.Open();
                SqlCommand kayit = new SqlCommand("insert into TBLYONETMENLER (ADSOYAD,CİNSİYET,YAS,GÖRSEL ) VALUES (@p1,@p2,@p3,@p4)", connection);

                kayit.Parameters.AddWithValue("@p1", AdSoyad);
                kayit.Parameters.AddWithValue("@p2", cinsiyet);
                kayit.Parameters.AddWithValue("@p3", bYas);
                kayit.Parameters.AddWithValue("@p4", resimYolu);
                kayit.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kayıt İşlemi Başarılı");
                aracTemizleme();
            }
            else
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz");
                return;
            }
        }
        void aracTemizleme()
        {
            txtad.Text = "";
            txtsoyad.Text = "";
            ngun.Value = 1;
            nay.Value = 1;
            nyil.Value = 2025;
            rbkadin.Checked = false;
            bYas = "00";
            txtad.Focus();

        }




        private void ToUpper()
        {
            throw new NotImplementedException();
        }

        public string bYas="0";

        private void nyıl_ValueChanged(object sender, EventArgs e)
        {
            string tarih = ngun.Value.ToString() + "-" + nay.Value.ToString() + "-" + nyil.Value.ToString();
           
            DateTime dt = Convert.ToDateTime(tarih);
            DateTime bugun = DateTime.Now;
            int yas = bugun.Year - dt.Year;
           
            if  (yas < 0)
            {
                MessageBox.Show("Hatalı Giriş");
            }
            else if (yas < 18)
            {
                //MessageBox.Show("18 Yas Altı Giriş Yasak");
            }
            else
            {
                //MessageBox.Show("Hoşgeldiniz"); 
               // MessageBox.Show(yas.ToString());
            }
            bYas = yas.ToString();
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
