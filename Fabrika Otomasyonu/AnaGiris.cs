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
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris giris1 = new giris();
            giris1.Show();
            this.Hide();
        }

        private void yntmbtn_Click(object sender, EventArgs e)
        {
            yonetimgrs giris1 = new yonetimgrs();
            giris1.Show();
            this.Hide();
        }
    }
}

