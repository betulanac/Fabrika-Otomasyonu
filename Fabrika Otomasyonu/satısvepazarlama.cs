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
    public partial class satısvepazarlama : Form
    {
        public satısvepazarlama()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void anasayfabtn_Click(object sender, EventArgs e)
        {
            AnaGiris anagcs = new AnaGiris();
            anagcs.Show();
            this.Hide();
        }

        private void satısvepazarlama_Load(object sender, EventArgs e)
        {
            geribtn.Visible = false;
        }

        private void btnmalzgcs_Click(object sender, EventArgs e)
        {
            musteribilggoruntule mustgcs = new musteribilggoruntule();
            mustgcs.Show();
            //this.Hide();
        }

        private void btnsipgcs_Click(object sender, EventArgs e)
        {
            siparis sipgcs = new siparis();
            sipgcs.Show();
            //this.Hide();
        }

        private void geribtn_Click(object sender, EventArgs e)
        {

        }
    }
}
