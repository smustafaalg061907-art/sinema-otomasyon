using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otomasyon
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
        public string kisiadisoyadi = "";
        private void frm2_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hoşgeldiniz Sayın " + kisiadisoyadi😊);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm3 frm = new frm3();
            frm.ShowDialog();
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm4yonetmenlst frm = new frm4yonetmenlst();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm5OyuncuKayıt frm = new frm5OyuncuKayıt();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm6OyuncuListesi frm = new frm6OyuncuListesi();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm7SalonKayit frm = new frm7SalonKayit();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm8filmkayit frm = new frm8filmkayit();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm9filmliste frm = new frm9filmliste();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frm11Biletolusturma frm = new frm11Biletolusturma();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frm12biletsorgu frm = new frm12biletsorgu();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmsalonatama frm   = new frmsalonatama();
            frm.ShowDialog();
        }
    }
}
