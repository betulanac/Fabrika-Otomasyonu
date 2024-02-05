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
    public partial class cikolata : Form
    {
        public cikolata()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5433; Database=Fabrika; user Id=postgres; password=cfuUm.0696; ");

        private void button5_Click(object sender, EventArgs e)
        {
            String sorgu = "UPDATE cikolatalar SET cikolataid=@cikolataid, cikolataadi=@cikolataadi, " +
                "cikolatastok=@cikolatastok,  birimfiyat=@birimfiyat WHERE cikolataid=@cikolataid  ";
            using (NpgsqlCommand komutgüncelle = new NpgsqlCommand(sorgu, baglanti))
            {
                baglanti.Open();

                komutgüncelle.Parameters.AddWithValue("@cikolataid", Convert.ToInt32(txtid.Text));
                komutgüncelle.Parameters.AddWithValue("@cikolataadi", txtadi.Text);
                komutgüncelle.Parameters.AddWithValue("@cikolatastok", int.Parse(nstok.Text));
                //komutgüncelle.Parameters.AddWithValue("@siparisadeti", int.Parse(txtsip.Text));
                komutgüncelle.Parameters.AddWithValue("@birimfiyat", decimal.Parse(txtfiyat.Text));

                komutgüncelle.ExecuteNonQuery();
            }
            MessageBox.Show(" Çikolata bilgileri güncellendi. ");
            baglanti.Close();
        }

        private void listbtn_Click(object sender, EventArgs e)
        {
            String sorgu = "select *from cikolatalar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            nstok.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //txtsip.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtfiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // SQL komutunu hazırla
                string sql = "INSERT INTO cikolatalar ( cikolataadi, cikolatastok,  birimfiyat) " +
                             "VALUES ( @cikolataadi, @cikolatastok,  @birimfiyat)";
                using (NpgsqlCommand komutEkle = new NpgsqlCommand(sql, baglanti))
                {
                    // Parametreleri ekle

                    komutEkle.Parameters.AddWithValue("@cikolataadi", txtadi.Text);
                    komutEkle.Parameters.AddWithValue("@cikolatastok", int.Parse(nstok.Text));
                    // komutEkle.Parameters.AddWithValue("@siparisadeti", int.Parse(txtsip.Text));
                    komutEkle.Parameters.AddWithValue("@birimfiyat", decimal.Parse(txtfiyat.Text));


                    // Komutu çalıştır
                    komutEkle.ExecuteNonQuery();
                }
                MessageBox.Show("Çikolata eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String sorgu = "DELETE FROM cikolatalar WHERE cikolataid=@cikolataid";
            using (NpgsqlCommand komutEkle = new NpgsqlCommand(sorgu, baglanti))
            {
                komutEkle.Parameters.AddWithValue("@cikolataid", Convert.ToInt32(txtid.Text));
                komutEkle.ExecuteNonQuery();
            }
            MessageBox.Show("Çikolata Silindi ");
            baglanti.Close();
        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcının girdiği arama terimini al
                string aramaTerimi = txtara.Text.Trim();

                // NpgsqlConnection açılır
                baglanti.Open();

                // Personel adına göre arama SQL sorgusu
                string sql = "SELECT * FROM cikolatalar WHERE cikolataadi ILIKE @aramaTerimi";
                // NpgsqlDataAdapter nesnesi sınıf düzeyinde tanımlanır
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, baglanti))
                {
                    // Parametreleri ekleyerek SQL sorgusunu güvenli hale getir
                    adapter.SelectCommand.Parameters.AddWithValue("@aramaTerimi", "%" + aramaTerimi + "%");

                    // DataSet oluştur
                    DataSet ds = new DataSet();

                    // SQL sorgusunu çalıştır ve sonuçları DataSet'e doldur
                    adapter.Fill(ds);

                    // DataGridView'e DataSet'teki tabloyu bağla
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // NpgsqlConnection kapatılır
                baglanti.Close();
            }
        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            müdürekran gcs = new müdürekran();
            gcs.Show();
            this.Hide();
        }

        private void anabtn_Click(object sender, EventArgs e)
        {
            AnaGiris anagcs = new AnaGiris();
            anagcs.Show();
            this.Hide();
        }

        private void cikolata_Load(object sender, EventArgs e)
        {

        }
    }
}
