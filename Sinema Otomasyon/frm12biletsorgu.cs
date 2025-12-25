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
    public partial class frm12biletsorgu : Form
    {
        public frm12biletsorgu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm12biletsorgu_Load(object sender, EventArgs e)
        {

        }

        private void btnsorgula_Click(object sender, EventArgs e)
        {
            frm13biletdetay frm = new frm13biletdetay();
            frm.biletno = txtbiletno.Text.ToString();
            txtbiletno.Text = "";
            frm.ShowDialog();
        }
    }
}
