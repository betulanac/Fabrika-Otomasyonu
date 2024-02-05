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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        // PostgreSQL veritabanı bağlantı bilgileri
        string connectionString = "Host=localhost;Port=5433;Database=Fabrika;User Id=postgres;Password=cfuUm.0696;";


        private void prsnlGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtkuladi.Text;
            string sifre = txtsifre.Text;
            string secilenDepartman = comboBox1.SelectedItem.ToString();

            // Kullanıcı adı ve şifreyi veritabanından kontrol et
            if (GirisKontrol(kullaniciadi, sifre, secilenDepartman))
            {
                // Departmana göre ilgili formu aç
                switch (secilenDepartman)
                {
                    case "Üretim":
                        cikolata cikolatagcs = new cikolata();
                        cikolatagcs.Show();
                        break;

                    case "Depo":
                        deposayfa depogcs = new deposayfa();
                        depogcs.Show();
                        break;

                    case "Satış ve Pazarlama":
                        satısvepazarlama satisForm = new satısvepazarlama();
                        satisForm.Show();
                        break;

                    case "İnsan Kaynakları ve Muhasebe":
                        ikvemuhasebe ikForm = new ikvemuhasebe();
                        ikForm.Show();
                        break;



                    default:
                        MessageBox.Show("Geçersiz departman seçimi.");
                        break;
                }

                // Giriş formunu gizle
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }

        private bool GirisKontrol(string kullaniciadi, string sifre, string departman)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Kullanıcı adı, şifre ve departman kontrolü için PostgreSQL sorgusu
                string sql = "SELECT COUNT(*) FROM \"kullanicilar\" WHERE \"kullaniciadi\" = @kullaniciAdi AND \"sifre\" = @sifre AND \"departman\" = @departman";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    // Parametreleri ekleyerek SQL sorgusunu güvenli hale getir
                    command.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                    command.Parameters.AddWithValue("@sifre", sifre);
                    command.Parameters.AddWithValue("@departman", departman);

                    // SQL sorgusunu çalıştır ve sonucu al
                    int rowCount = Convert.ToInt32(command.ExecuteScalar());

                    // Kullanıcı adı, şifre ve departman doğru ise rowCount değeri 1 olacak
                    return rowCount == 1;
                }
            }

        }

        private void geribtn_Click(object sender, EventArgs e)
        {

            AnaGiris AnaGirisgcs = new AnaGiris();
            AnaGirisgcs.Show();
            this.Hide();

        }

        private void anasayfabtn_Click(object sender, EventArgs e)
        {
            AnaGiris AnaGirisgcs = new AnaGiris();
            AnaGirisgcs.Show();
            this.Hide();

        }
    }
}

