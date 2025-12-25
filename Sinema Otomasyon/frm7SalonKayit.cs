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
    public partial class frm7SalonKayit : Form
    {
        public frm7SalonKayit()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=Mustafaalg06;Initial Catalog=OTOMASYON;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnresimyukle_Click(object sender, EventArgs e)
        {
            if (txtsalonadi.Text != "" && cbkoltuksayisi.Text != "")

            {
                connection.Open();
                SqlCommand kaydet = new SqlCommand("insert into TBLSALON (SALONADI,KOLTUKSAYISI) values (@p1,@p2)", connection);
                kaydet.Parameters.AddWithValue("@p1", txtsalonadi.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@p2", cbkoltuksayisi.Text);
                kaydet.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Salon Kaydı Başarıyla Gerçekleşti");
                txtsalonadi.Text = "";
                cbkoltuksayisi.Text = "";
                txtsalonadi.Focus();
            }
            else
            {
                MessageBox.Show("Lütfen Salon Adı ve Koltuk Sayısını Giriniz");
            }
        }
        private void frm7SalonKayit_Load(object sender, EventArgs e)
        {
            panelsalon.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from TBLSALON ", connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                salonlistesi arac = new salonlistesi();
                arac.lblsalonadi.Text = oku["SALONADI"].ToString();
                arac.lblkoltuksayisi.Text = oku["KOLTUKSAYISI"].ToString();
                panelsalon.Controls.Add(arac);
            }



            connection.Close();



        }
        void kOlustur()
        {
            for (int i = 1; i <= 100; i++)
            {
                cbkoltuksayisi.Items.Add(i);

            }



        }
    }
}