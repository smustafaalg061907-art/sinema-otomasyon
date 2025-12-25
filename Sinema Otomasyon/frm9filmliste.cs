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
    public partial class frm9filmliste : Form
    {
        public frm9filmliste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=Mustafaalg06;Initial Catalog=OTOMASYON;Integrated Security=True");
        private void frm9filmliste_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            string sorgu = "SELECT * FROM TBLFilmler ADI  ";
            connection.Open();
            SqlCommand komut = new SqlCommand( sorgu , connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                filmlistesi arac = new filmlistesi();
                arac.lblfilmadi.Text = oku["ADI"].ToString();
                arac.pbresim.ImageLocation = oku["AFİS"].ToString();
                arac.label1.Text = oku["ID"].ToString();
                ListePaneli.Controls.Add(arac);

            }


            connection.Close();
        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLFilmler WHERE ADI LIKE '%" + txtarama.Text + "%'",connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                filmlistesi arac = new filmlistesi();
                arac.lblfilmadi.Text = oku["ADI"].ToString();
                arac.pbresim.ImageLocation = oku["AFİS"].ToString();
                arac.label1.Text = oku["ID"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            connection.Close();
        }

        private void ListePaneli_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
