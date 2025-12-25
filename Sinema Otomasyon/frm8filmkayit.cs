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
    public partial class frm8filmkayit : Form
    {
        public frm8filmkayit()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=Mustafaalg06;Initial Catalog=OTOMASYON;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        string resimYolu = "";
        private void btnresimyukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Title = "Resim Seçiniz";
            dosya.Filter = "JPG Dosyaları (*.jpg)|*.jpg|PNG Dosyaları (*.png)|*.png|Tüm Dosyalar (*.*)|*.*";
            dosya.FilterIndex = 3;


            if (dosya.ShowDialog() == DialogResult.OK)
            {
                resimYolu = dosya.FileName;
                pbresim.ImageLocation = resimYolu;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int karakterSayisi = txtdetay.Text.Length;
            int geri = 300 - karakterSayisi;
            lblKarakter.Text = geri.ToString();
            if (geri > 20)
            {
                lblKarakter.ForeColor = Color.Purple;
            }
            if (geri <= 20)
            {
                lblKarakter.ForeColor = Color.DarkOrange;
            }
            if (geri <= 10)
            {
                lblKarakter.ForeColor = Color.Red;
            }
            //if (textBox2.ForeColor != Color.Gray);
            //MessageBox.Show("En fazla 300 karakter girebilirsiniz");

        }

        private void lbloyuncuara_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtür.SelectedItem.ToString() == "Yabancı")
            {
                // ComboBox2'yi doldur
                cbdublaj.Items.Clear();
                cbdublaj.Items.Add("Türkçe Altyazı");
                cbdublaj.Items.Add("türkçe dublaj");
                cbdublaj.Items.Add("DUBLAJ&ALTYAZI");
                cbdublaj.Visible = true; // Görünsün
            }
            else if (cbtür.SelectedItem.ToString() == "Yerli")
            {
                // ComboBox2'yi temizle ve gizle
                cbdublaj.Items.Clear();
                cbdublaj.Visible = false;
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            if (cbtür.ForeColor == Color.Gray)
            {
                cbtür.ForeColor = Color.Black;
                cbtür.Items.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (txttür != null)

                if(txttür.ForeColor != Color.Gray)
                {

                }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into TBLFilmler (ADI,TURU,OZELLIKLER,YONETMEN,OYUNCULAR,DETAY,PUAN,AFİS,TARIH) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu,connection);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txttür.Text);
            komut.Parameters.AddWithValue("@p3", cbtür.Text);
            komut.Parameters.AddWithValue("@p4", txtyonetmen.Text);
            komut.Parameters.AddWithValue("@p5", txtoyuncular.Text); 
            komut.Parameters.AddWithValue("@p6", txtdetay.Text);
            komut.Parameters.AddWithValue("@p7", cbpuan.Text);
            komut.Parameters.AddWithValue("@p8", resimYolu);
            komut.Parameters.AddWithValue("@p9", DateTime.Parse(txttarıh.Text));
            komut.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Film Kaydı Yapıldı");
            txtad.Clear();
            txttür.Clear();
            txtyonetmen.Clear();
            txtoyuncular.Clear();
            txtdetay.Clear();
            cbtür.Text = "Seçiniz";
            cbpuan.Text = "Seçiniz";
            txttarıh.Text = "";
            pbresim.ImageLocation = "";
            resimYolu = "";
            cbtür.ForeColor = Color.Gray;
            cbpuan.ForeColor = Color.Gray;
            cbtür.Items.Clear();
            cbpuan.Items.Clear();
            cbdublaj.Items.Clear();
            cbpuan.Items.Clear();
            // Eğer tarih kutusu boşsa bugünün tarihini al, doluysa kutudakini çevir
            DateTime tarihDegeri;
            if (string.IsNullOrWhiteSpace(txttarıh.Text))
            {
                tarihDegeri = DateTime.Now; // Veya varsayılan başka bir tarih
            }
            else
            {
                tarihDegeri = Convert.ToDateTime(txttarıh.Text);
            }

            komut.Parameters.AddWithValue("@p9", tarihDegeri);

        }

        private void txttarıh_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm8filmkayit_Load(object sender, EventArgs e)
        {
            cbtür.Items.Add("Yerli");
            cbtür.Items.Add("Yabancı");

        }
    }
}




