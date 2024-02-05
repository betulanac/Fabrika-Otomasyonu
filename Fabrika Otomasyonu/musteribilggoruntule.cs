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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fabrika_Otomasyonu
{
    public partial class musteribilggoruntule : Form
    {
        public musteribilggoruntule()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5433; Database=Fabrika; user Id=postgres; password=cfuUm.0696; ");

        private void listbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String sorgu = "select *from musteri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void musteribilggoruntule_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void musteribilggoruntule_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mxttlfn.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // SQL komutunu hazırla
                string sql = "INSERT INTO musteri (sirketadi, telefon, mail, adres) " +
                             "VALUES (@sirketadi, @telefon, @mail, @adres)";
                using (NpgsqlCommand komutEkle = new NpgsqlCommand(sql, baglanti))
                {
                    // Parametreleri ekle
                    komutEkle.Parameters.AddWithValue("@sirketadi", txtadi.Text);
                    komutEkle.Parameters.AddWithValue("@telefon", mxttlfn.Text);
                    komutEkle.Parameters.AddWithValue("@mail", txtmail.Text);
                    komutEkle.Parameters.AddWithValue("@adres", txtadres.Text);

                    // Komutu çalıştır
                    komutEkle.ExecuteNonQuery();
                }
                MessageBox.Show(" Yeni müşteri eklendi.");
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
            String sorgu = "DELETE FROM musteri WHERE sirketid=@sirketid";
            using (NpgsqlCommand komutEkle = new NpgsqlCommand(sorgu, baglanti))
            {
                komutEkle.Parameters.AddWithValue("@sirketid", Convert.ToInt32(txtid.Text));
                komutEkle.ExecuteNonQuery();
            }
            MessageBox.Show("Müşteri Silindi ");
            baglanti.Close();
        }

        private void gncbtn_Click(object sender, EventArgs e)
        {
            String sorgu = "UPDATE musteri SET sirketid=@sirketid, sirketadi=@sirketadi, " +
                "Telefon=@Telefon, Mail=@Mail, Adres=@Adres WHERE sirketid=@sirketid";
            using (NpgsqlCommand komutgüncelle = new NpgsqlCommand(sorgu, baglanti))
            {
                baglanti.Open();

                komutgüncelle.Parameters.AddWithValue("@sirketid", Convert.ToInt32(txtid.Text));
                komutgüncelle.Parameters.AddWithValue("@sirketadi", txtadi.Text);
                komutgüncelle.Parameters.AddWithValue("@telefon", mxttlfn.Text);
                komutgüncelle.Parameters.AddWithValue("@mail", txtmail.Text);
                komutgüncelle.Parameters.AddWithValue("@adres", txtadres.Text);

                komutgüncelle.ExecuteNonQuery();
            }
            MessageBox.Show("Müşteri bilgileri güncellendi. ");
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
                string sql = "SELECT * FROM musteri WHERE sirketadi ILIKE @aramaTerimi";
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

        private void anasayfabtn_Click(object sender, EventArgs e)
        {
            AnaGiris anagcs = new AnaGiris();
            anagcs.Show();
            this.Hide();
        }
    }

}

