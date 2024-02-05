using Npgsql;
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
    public partial class yonetimgrs : Form
    {
        public yonetimgrs()
        {
            InitializeComponent();

        }
        // PostgreSQL veritabanı bağlantı bilgileri
        string connectionString = "Host=localhost;Port=5433;Database=Fabrika;User Id=postgres;Password=cfuUm.0696;";

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtkuladi.Text;
            string sifre = txtsifre.Text;

            if (GirisKontrol(kullaniciadi, sifre))
            {
                müdürekran müdürekrangcs = new müdürekran();
                müdürekrangcs.Show();
                this.Hide();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }
        private bool GirisKontrol(string kullaniciAdi, string sifre)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT COUNT(*) FROM yonetici WHERE kullaniciadi = @kullaniciAdi AND sifre = @sifre";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        command.Parameters.AddWithValue("@sifre", sifre);

                        int kullaniciSayisi = Convert.ToInt32(command.ExecuteScalar());

                        return kullaniciSayisi > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş kontrolü sırasında bir hata oluştu: " + ex.Message);
                return false;
            }
        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            AnaGiris AnaGirisgcs = new AnaGiris();
            AnaGirisgcs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaGiris AnaGirisgcs = new AnaGiris();
            AnaGirisgcs.Show();
            this.Hide();
        }
    }
}
