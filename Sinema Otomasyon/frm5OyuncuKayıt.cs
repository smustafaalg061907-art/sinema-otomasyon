using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Sinema_Otomasyon
{
    public partial class frm5OyuncuKayıt : Form
    {
        public frm5OyuncuKayıt()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=Mustafaalg06;Initial Catalog=OTOMASYON;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string resimYolu = "";
        private void btnresimyukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Resim Seçiniz";
            ofd.Filter = "JPG Dosyaları|*.jpg|PNG Dosyaları|*.png|Tüm Dosyalar|*.*";
            ofd.FilterIndex = 3;


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbresim.Image = new Bitmap(ofd.FileName);
                resimYolu = ofd.FileName.ToString();
            }
        }
        public string cinsiyet = "0";
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "0";
        }

        private void rbkadin_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "1";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ngun_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nyil_ValueChanged(object sender, EventArgs e)
        {
            string tarih = ngun.Value.ToString() + "-" + nay.Value.ToString() + "-" + nyil.Value.ToString();

            DateTime dt = Convert.ToDateTime(tarih);
            DateTime bugun = DateTime.Now;
            int yas = bugun.Year - dt.Year;

            if (yas < 0)
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
             
        }
        string btnkaydet_Click;
        private void btnkaydet_Click_1(object sender, EventArgs e)
        {
            if (txtad.Text != "" && txtsoyad.Text != "" && resimYolu != "")

            {
                String AdSoyad = txtad.Text.ToString().ToUpper() + " " + txtsoyad.Text.ToString().ToUpper();
                //MessageBox.Show(AdSoyad);

                connection.Open();
                SqlCommand kayit = new SqlCommand("insert into TBLOYUNCULAR (ADSOYAD,CINSIYET,RESIM) values (@p1,@p2,@p3)", connection);

                kayit.Parameters.AddWithValue("@p1", AdSoyad);
                kayit.Parameters.AddWithValue("@p2", cinsiyet);
                kayit.Parameters.AddWithValue("@p3", resimYolu);
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
            txtad.Focus();

        }
    }
    }

    


