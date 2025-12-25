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
    public partial class salonlistesi : UserControl
    {
        public salonlistesi()
        {
            InitializeComponent();
        }

        private void salonlistesi_Load(object sender, EventArgs e)
        {

        }

        private void gel(object sender, MouseEventArgs e)
        {
            lblsalonadi.ForeColor = Color.DarkRed;
            this.BackColor = Color.DarkGray;
        }

        private void ayril(object sender, EventArgs e)
        {
            lblsalonadi.ForeColor = Color.Black;
            this.BackColor = Color.LightGray;
        }
    }
}
