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
    public partial class frm10filmdetay : Form
    {
        public frm10filmdetay()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=Mustafaalg06;Initial Catalog=OTOMASYON;Integrated Security=True");
        public string idno = "";
        private void frm10filmdetay_Load(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM TBLFilmler WHERE ID=@p1";
            connection.Open();
            SqlCommand komut = new SqlCommand(sorgu,connection);
            komut.Parameters.AddWithValue("@p1", idno);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                pbresim.ImageLocation = oku["AFİS"].ToString();
                lblfilmadi.Text = oku["ADI"].ToString();
                lblyonetmen.Text = oku["YONETMEN"].ToString();
                lbloyuncular.Text = oku["OYUNCULAR"].ToString();
                lblfilmturu.Text = oku["TURU"].ToString();
                lblcbtür.Text = oku["OZELLIKLER"].ToString();
                //lblcbdublaj.Text = oku["OZELLIKLER"].ToString(); // dublaj,altyazı kişisel tercih
                lbldetay.Text = oku["DETAY"].ToString();
                lbltarıh.Text = oku["TARIH"].ToString();
                lblpuan.Text = oku["PUAN"].ToString();
            }



            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblpuan_Click(object sender, EventArgs e)
        {

        }

        private void lblcbdublaj_Click(object sender, EventArgs e)
        {

        }
    }
}
