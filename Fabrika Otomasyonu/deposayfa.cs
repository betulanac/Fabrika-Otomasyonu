using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrika_Otomasyonu
{
    public partial class deposayfa : Form
    {
        public deposayfa()
        {
            InitializeComponent();
        }

        private void btnmalzgcs_Click(object sender, EventArgs e)
        {
            malzeme malzemesgcs = new malzeme();
            malzemesgcs.Show();
            //this.Hide();

        }

        private void btncikogcs_Click(object sender, EventArgs e)
        {
            cikolata cikolatagcs = new cikolata();
            cikolatagcs.Show();
            //this.Hide();
        }

        private void geribtn_Click(object sender, EventArgs e)
        {

        }

        private void anasayfabtn_Click(object sender, EventArgs e)
        {
            AnaGiris anagirisgcs = new AnaGiris();
            anagirisgcs.Show();
            this.Hide();
        }

        private void deposayfa_Load(object sender, EventArgs e)
        {
            geribtn.Visible = false;
        }
    }
}
