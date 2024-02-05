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
    public partial class müdürekran : Form
    {
        public müdürekran()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 prsnlgcis = new Form1();
            prsnlgcis.Show();
            this.Hide();
            geribtn.Visible = false;



            // Anagiriş formunu gizle
            this.Hide();
        }

        private void msteriilembtn_Click(object sender, EventArgs e)
        {
            musteribilggoruntule mstrerigecis = new musteribilggoruntule();
            mstrerigecis.Show();
            this.Hide();

        }

        private void cikolatabtn_Click(object sender, EventArgs e)
        {
            cikolata cikolatagecis = new cikolata();
            cikolatagecis.Show();
            this.Hide();
        }

        private void malzemebtn_Click(object sender, EventArgs e)
        {
            malzeme malzemegcs = new malzeme();
            malzemegcs.Show();
            this.Hide();
        }

        private void gelirbtn_Click(object sender, EventArgs e)
        {
            cikolatagelir gcs = new cikolatagelir();
            gcs.Show();
            this.Hide();
        }

        private void giderbtn_Click(object sender, EventArgs e)
        {
            gider gcs = new gider();
            gcs.Show();
            this.Hide();
        }

        private void anasayfabtn_Click(object sender, EventArgs e)
        {
            AnaGiris gcs = new AnaGiris();
            gcs.Show();
            this.Hide();
        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            yonetimgrs gcs = new yonetimgrs();
            gcs.Show();
            this.Hide();
        }

        private void müdürekran_Load(object sender, EventArgs e)
        {
            this.Owner = null;
        }

        private void sipbtn_Click(object sender, EventArgs e)
        {
            siparis gcs = new siparis();
            gcs.Show();
            this.Hide();
        }
    }
}


