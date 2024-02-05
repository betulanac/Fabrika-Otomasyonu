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
    public partial class malzeme : Form
    {
        public malzeme()
        {
            InitializeComponent();


        }
        string connectionString = "Host=localhost;Port=5433;Database=Fabrika;User Id=postgres;Password=cfuUm.0696;";

        private void malzeme_Load(object sender, EventArgs e)
        {

        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            
            string malzemeAdi = txtadi.Text;
            int stokMiktari;
            decimal birimFiyat;
            string marka = txtmarka.Text;

            if (!int.TryParse(txtstok.Text, out stokMiktari))
            {
                MessageBox.Show("Geçerli bir stok miktarı girin.");
                return;
            }
            if (!decimal.TryParse(txtfiyat.Text, out birimFiyat))
            {
                MessageBox.Show("Geçerli bir birim fiyat girin.");
                return;
            }
            try
            { 
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO malzeme (malzemeadi, stok, birimfiyat, marka) VALUES (@malzemeAdi," +
                        " @stokMiktari, @birimFiyat, @marka) RETURNING malzemeid";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@malzemeAdi", malzemeAdi);
                        command.Parameters.AddWithValue("@stokMiktari", stokMiktari);
                        command.Parameters.AddWithValue("@birimFiyat", birimFiyat);
                        command.Parameters.AddWithValue("@marka", marka);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Malzeme başarıyla eklendi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Malzeme eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void listbtn_Click(object sender, EventArgs e)
        {
            String sorgu = "select *from malzeme";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, connectionString);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void silbtn_Click(object sender, EventArgs e)
        {

            // Kullanıcının girdiği malzeme ID bilgisini al
            int malzemeId;
            if (!int.TryParse(txtid.Text, out malzemeId))
            {
                MessageBox.Show("Geçerli bir malzeme ID girin.");
                return;
            }

            try
            {
                // PostgreSQL bağlantısını aç
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Malzeme silme SQL sorgusu
                    string sql = "DELETE FROM malzeme WHERE malzemeid = @malzemeId";

                    // PostgreSQL komutunu oluştur
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        // Parametreyi ekleyerek SQL sorgusunu güvenli hale getir
                        command.Parameters.AddWithValue("@malzemeId", malzemeId);

                        // SQL sorgusunu çalıştır
                        int affectedRows = command.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Malzeme başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen malzeme ID bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Malzeme silinirken bir hata oluştu: " + ex.Message);
            }




        }

        private void gnclbtn_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği malzeme ID bilgisini al
            int malzemeId;
            if (!int.TryParse(txtid.Text, out malzemeId))
            {
                MessageBox.Show("Geçerli bir malzeme ID girin.");
                return;
            }

            // Kullanıcının girdiği yeni malzeme bilgilerini al
            string yeniMalzemeAdi = txtadi.Text;
            int yeniStokMiktari;
            decimal yeniBirimFiyat;
            string yeniMarka = txtmarka.Text;

            if (!int.TryParse(txtstok.Text, out yeniStokMiktari))
            {
                MessageBox.Show("Geçerli bir stok miktarı girin.");
                return;
            }

            if (!decimal.TryParse(txtfiyat.Text, out yeniBirimFiyat))
            {
                MessageBox.Show("Geçerli bir birim fiyat girin.");
                return;
            }

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string sql = "UPDATE malzeme SET malzemeadi = @yeniMalzemeAdi, stok = @yeniStokMiktari, birimfiyat = @yeniBirimFiyat, " +
                        "marka = @yeniMarka WHERE malzemeid = @malzemeId";

                    // PostgreSQL komutunu oluştur
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
        
                        command.Parameters.AddWithValue("@yeniMalzemeAdi", yeniMalzemeAdi);
                        command.Parameters.AddWithValue("@yeniStokMiktari", yeniStokMiktari);
                        command.Parameters.AddWithValue("@yeniBirimFiyat", yeniBirimFiyat);
                        command.Parameters.AddWithValue("@yeniMarka", yeniMarka);
                        command.Parameters.AddWithValue("@malzemeId", malzemeId);

                        // SQL sorgusunu çalıştır
                        int affectedRows = command.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Malzeme başarıyla güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen malzeme ID bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Malzeme güncellenirken bir hata oluştu: " + ex.Message);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtstok.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtfiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtmarka.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void arabtn_Click(object sender, EventArgs e)
        {


            // Kullanıcının girdiği arama terimini al
            string aramaTerimi = txtarama.Text.Trim();

            // PostgreSQL bağlantısını aç
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Malzeme adına göre arama SQL sorgusu
                string sql = "SELECT * FROM malzeme WHERE malzemeadi ILIKE @aramaTerimi";
                //ILIKE büyük-küçük harf duyarlılığı olmasın diye kullanılır

                // NpgsqlDataAdapter ve DataSet kullanarak SQL sorgusunu çalıştır ve sonuçları al
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, connection))
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
        }

        private void stkbtn_Click(object sender, EventArgs e)
        {

            // Kullanıcının girdiği malzeme adını ve güncellenecek miktarı al
            string malzemeAdi = txtadi.Text.Trim();
            int miktar;

            if (!int.TryParse(txtstok.Text, out miktar))
            {
                MessageBox.Show("Geçerli bir miktar girin.");
                return;
            }

            // Stok güncelleme metodunu çağır
            stokGuncelle(malzemeAdi, miktar);
        }
        private void stokGuncelle(string malzemeAdi, int miktar)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "UPDATE malzeme SET stok = stok + @miktar WHERE malzemeadi = @malzemeAdi";

                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@malzemeAdi", malzemeAdi);
                        command.Parameters.AddWithValue("@miktar", miktar);

                        int affectedRows = command.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Stok başarıyla güncellendi.");
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen malzeme adı bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stok güncellenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            müdürekran gcs = new müdürekran();
            gcs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaGiris gcs = new AnaGiris();
            gcs.Show();
            this.Hide();
        }

        private void txtstok_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





