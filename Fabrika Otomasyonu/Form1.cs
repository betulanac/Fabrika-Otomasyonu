using Npgsql;
using System.Data;
using System.Data.Common;
using System;

namespace Fabrika_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5433; Database=Fabrika; user Id=postgres; password=cfuUm.0696; ");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sorgu = "select *from personel";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void eklebtn_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();

                // SQL komutunu hazýrla
                string sql = "INSERT INTO Personel (Adi, Soyadi, TCKimlik, Cinsiyet, Telefon, Mail, Adres, Pozisyon, Maas) " +
                             "VALUES (@Adi, @Soyadi, @TCKimlik, @Cinsiyet, @Telefon, @Mail, @Adres, @Pozisyon, @Maas)";
                using (NpgsqlCommand komutEkle = new NpgsqlCommand(sql, baglanti))
                {
                    // Parametreleri ekle
                    komutEkle.Parameters.AddWithValue("@Adi", txtadi.Text);
                    komutEkle.Parameters.AddWithValue("@Soyadi", txtsyadi.Text);
                    komutEkle.Parameters.AddWithValue("@TCKimlik", mtxtc.Text);
                    komutEkle.Parameters.AddWithValue("@Cinsiyet", cboxcins.Text);
                    komutEkle.Parameters.AddWithValue("@Telefon", mtxtlfn.Text);
                    komutEkle.Parameters.AddWithValue("@Mail", txtmail.Text);
                    komutEkle.Parameters.AddWithValue("@Adres", txtadres.Text);
                    komutEkle.Parameters.AddWithValue("@Pozisyon", txtpoz.Text);
                    komutEkle.Parameters.AddWithValue("@Maas", int.Parse(txtmaas.Text));

                    // Komutu çalýþtýr
                    komutEkle.ExecuteNonQuery();
                }
                MessageBox.Show("Personel baþarýyla eklendi.");
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
            String sorgu = "DELETE FROM personel WHERE personelid=@personelid";
            using (NpgsqlCommand komutsil = new NpgsqlCommand(sorgu, baglanti))
            {
                komutsil.Parameters.AddWithValue("@personelid", Convert.ToInt32(txtid.Text));
                komutsil.ExecuteNonQuery();
            }
            MessageBox.Show("Personel Silindi ");
            baglanti.Close();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mtxtc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cboxcins.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mtxtlfn.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtmail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtpoz.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtmaas.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

        }

        private void gnclbtn_Click(object sender, EventArgs e)
        {
            String sorgu = "UPDATE personel SET adi=@adi, soyadi=@soyadi, TCKimlik=@TCKimlik, Cinsiyet=@Cinsiyet," +
                "Telefon=@Telefon, Mail=@Mail, Adres=@Adres, Pozisyon=@Pozisyon, Maas=@Maas WHERE personelid=@personelid";
            using (NpgsqlCommand komutEkle = new NpgsqlCommand(sorgu, baglanti))
            {
                baglanti.Open();

                komutEkle.Parameters.AddWithValue("@personelid", Convert.ToInt32(txtid.Text));
                komutEkle.Parameters.AddWithValue("@Adi", txtadi.Text);
                komutEkle.Parameters.AddWithValue("@Soyadi", txtsyadi.Text);
                komutEkle.Parameters.AddWithValue("@TCKimlik", mtxtc.Text);
                komutEkle.Parameters.AddWithValue("@Cinsiyet", cboxcins.Text);
                komutEkle.Parameters.AddWithValue("@Telefon", mtxtlfn.Text);
                komutEkle.Parameters.AddWithValue("@Mail", txtmail.Text);
                komutEkle.Parameters.AddWithValue("@Adres", txtadres.Text);
                komutEkle.Parameters.AddWithValue("@Pozisyon", txtpoz.Text);
                komutEkle.Parameters.AddWithValue("@Maas", int.Parse(txtmaas.Text));

                komutEkle.ExecuteNonQuery();
            }
            MessageBox.Show("Personel bilgileri güncellendi. ");
            baglanti.Close();
        }

        private void geribtn_Click(object sender, EventArgs e)
        {

            müdürekran gcs = new müdürekran();
            gcs.Show();
            this.Hide();



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void arabtn_Click(object sender, EventArgs e)
        {

            try
            {
                // Kullanýcýnýn girdiði arama terimini al
                string aramaTerimi = txtara.Text.Trim();

                // NpgsqlConnection açýlýr
                baglanti.Open();

                // Personel adýna göre arama SQL sorgusu
                string sql = "SELECT * FROM personel WHERE adi ILIKE @aramaTerimi";
                // NpgsqlDataAdapter nesnesi sýnýf düzeyinde tanýmlanýr
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, baglanti))
                {
                    // Parametreleri ekleyerek SQL sorgusunu güvenli hale getir
                    adapter.SelectCommand.Parameters.AddWithValue("@aramaTerimi", "%" + aramaTerimi + "%");

                    // DataSet oluþtur
                    DataSet ds = new DataSet();

                    // SQL sorgusunu çalýþtýr ve sonuçlarý DataSet'e doldur
                    adapter.Fill(ds);

                    // DataGridView'e DataSet'teki tabloyu baðla
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // NpgsqlConnection kapatýlýr
                baglanti.Close();
            }
        }

        private void anasayfabtn_Click(object sender, EventArgs e)
        {
            AnaGiris anagcs = new AnaGiris();
            anagcs.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            müdürekran form3 = new müdürekran();
            form3.ShowDialog();

            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

