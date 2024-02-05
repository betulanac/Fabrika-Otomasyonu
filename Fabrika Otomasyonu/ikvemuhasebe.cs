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
    public partial class ikvemuhasebe : Form
    {
        public ikvemuhasebe()
        {
            InitializeComponent();
        }

        private void btnpersgcs_Click(object sender, EventArgs e)
        {
            Form1 persgcs = new Form1();
            persgcs.Show();

        }

        private void btngidergcs_Click(object sender, EventArgs e)
        {
            gider gidergcs = new gider();
            gidergcs.Show();

        }

        private void btngelirgcs_Click(object sender, EventArgs e)
        {
            cikolatagelir gelirgcs = new cikolatagelir();
            gelirgcs.Show();

        }

        private void geribtn_Click(object sender, EventArgs e)
        {

        }

        private void ikvemuhasebe_Load(object sender, EventArgs e)
        {
            //geribtn.Visible = false;
            this.Owner = null;
        }

        private void anasayfabtn_Click(object sender, EventArgs e)
        {
            AnaGiris anagcs = new AnaGiris();
            anagcs.Show();
            this.Hide();
        }
    }
}
