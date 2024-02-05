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


    public partial class siparis : Form
    {
        private string connectionString = "Host=localhost;Port=5433;Database=Fabrika;User Id=postgres;Password=cfuUm.0696;";
        public siparis()
        {
            InitializeComponent();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        // Sipariş bilgilerini al
                        string sirketAd = txtadi.Text;
                        string cikolataAd = txtcikoadi.Text;
                        int adet;
                        if (!int.TryParse(txtadet.Text, out adet))
                        {
                            MessageBox.Show("Adet alanına geçerli bir sayı girin.");
                            return;
                        }
                        DateTime siparisTarihi = dateTimePicker1.Value;
                        decimal tutar;
                        if (!decimal.TryParse(txttutar.Text, out tutar) || tutar <= 0)
                        {
                            MessageBox.Show("Geçerli bir tutar girin.");
                            return;
                        }

                        // Şirket ID'yi şirket adına göre sorgula
                        using (NpgsqlCommand command = new NpgsqlCommand("SELECT sirketid FROM musteri WHERE sirketadi=@sirketadi", connection))
                        {
                            command.Parameters.AddWithValue("@sirketadi", sirketAd);
                            object sirketId = command.ExecuteScalar();

                            if (sirketId != null)
                            {
                                // Çikolata birim fiyatını almak için cikolatalar tablosundan sorgu yap
                                string birimFiyatSorgu = "SELECT birimfiyat FROM cikolatalar WHERE cikolataadi = @cikolataadi";
                                using (NpgsqlCommand birimFiyatCommand = new NpgsqlCommand(birimFiyatSorgu, connection))
                                {
                                    birimFiyatCommand.Parameters.AddWithValue("@cikolataadi", cikolataAd);
                                    object birimFiyatObj = birimFiyatCommand.ExecuteScalar();

                                    if (birimFiyatObj != null)
                                    {
                                        decimal birimFiyat = Convert.ToDecimal(birimFiyatObj);

                                        // PostgreSQL INSERT sorgusu
                                        string insertQuery = "INSERT INTO siparis (sirketid,sirketadi ,cikolataadi, siparisadeti, siparistarihi, tutar) " +
                                                             "VALUES (@sirketid,@sirketadi, @cikolataadi, @siparisadeti, @siparistarihi, @tutar)";

                                        using (NpgsqlCommand insertCommand = new NpgsqlCommand(insertQuery, connection))
                                        {
                                            insertCommand.Parameters.AddWithValue("@sirketid", sirketId);
                                            insertCommand.Parameters.AddWithValue("@sirketadi", sirketAd);
                                            insertCommand.Parameters.AddWithValue("@cikolataadi", cikolataAd);
                                            insertCommand.Parameters.AddWithValue("@siparisadeti", adet);
                                            insertCommand.Parameters.AddWithValue("@siparistarihi", siparisTarihi);
                                            insertCommand.Parameters.AddWithValue("@tutar", tutar);

                                            insertCommand.ExecuteNonQuery();

                                            MessageBox.Show("Sipariş başarıyla eklendi!");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Belirtilen çikolata adı bulunamadı. Çikolata Adı: {cikolataAd}");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Şirket bulunamadı. Lütfen geçerli bir şirket adı girin.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            catch (Npgsql.PostgresException ex)
            {
                MessageBox.Show($"PostgreSQL Hatası:\nHata Kodu: {ex.SqlState}\nHata Mesajı: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message);
            }


        }
        private decimal GetCikolataFiyati(string cikolataAdi)
        {
            // Çikolata adına göre fiyatı veritabanından alabilirsiniz.
            // Bu örnekte sabit bir fiyat döndürüyorum.
            return 10.0m; // Sabit bir fiyat, gerçek veritabanı bağlantısı ve sorgusu ile değiştirilebilir.
        }

        private void listbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Siparişleri listeleme SQL sorgusu
                    string sql = "SELECT * FROM Siparis";

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, connection))
                    {
                        // DataSet oluştur
                        DataSet ds = new DataSet();

                        // SQL sorgusunu çalıştır ve sonuçları DataSet'e doldur
                        adapter.Fill(ds);

                        // DataGridView'e DataSet'teki tabloyu bağla
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Siparişleri listelerken bir hata oluştu: " + ex.Message);
            }
        }

        private void Hesaplabtn_Click(object sender, EventArgs e)
        {
            // Kullanıcının seçtiği çikolata adını al
            string cikolataAdi = txtcikoadi.Text;

            // Kullanıcının girdiği miktarı al
            int miktar;
            if (!int.TryParse(txtadet.Text, out miktar) || miktar <= 0)
            {
                MessageBox.Show("Geçerli bir miktar girin.");
                return;
            }

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Çikolata birim fiyatını almak için cikolatalar tablosundan sorgu yap
                    string birimFiyatSorgu = "SELECT birimfiyat FROM cikolatalar WHERE cikolataadi = @cikolataAdi";
                    using (NpgsqlCommand birimFiyatCommand = new NpgsqlCommand(birimFiyatSorgu, connection))
                    {
                        birimFiyatCommand.Parameters.AddWithValue("@cikolataAdi", cikolataAdi);
                        object result = birimFiyatCommand.ExecuteScalar();

                        if (result != null)
                        {
                            decimal birimFiyat = Convert.ToDecimal(result);
                            decimal toplamTutar = miktar * birimFiyat;

                            // Toplam tutarı göster
                            txttutar.Text = toplamTutar.ToString("0.00");
                        }
                        else
                        {
                            MessageBox.Show($"Belirtilen çikolata adı bulunamadı. Çikolata Adı: {cikolataAdi}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Toplam tutar hesaplanırken bir hata oluştu: " + ex.Message);
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtsipno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtcikoadi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtadet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txttutar.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği malzeme ID bilgisini al
            int sipno;
            if (!int.TryParse(txtsipno.Text, out sipno))
            {
                MessageBox.Show("Geçerli bir sipariş no girin.");
                return;
            }

            try
            {
                // PostgreSQL bağlantısını aç
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Malzeme silme SQL sorgusu
                    string sql = "DELETE FROM siparis WHERE siparisno = @siparisno";

                    // PostgreSQL komutunu oluştur
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        // Parametreyi ekleyerek SQL sorgusunu güvenli hale getir
                        command.Parameters.AddWithValue("@siparisno", sipno);

                        // SQL sorgusunu çalıştır
                        int affectedRows = command.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Sipariş başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen sipariş no bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş silinirken bir hata oluştu: " + ex.Message);
            }




        }

        private void gncbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Güncellenecek sipariş numarasını al
                    int siparisNo;
                    if (!int.TryParse(txtsipno.Text, out siparisNo) || siparisNo <= 0)
                    {
                        MessageBox.Show("Geçerli bir sipariş numarası girin.");
                        return;
                    }

                    // Sipariş bilgilerini al
                    string sirketAd = txtadi.Text;
                    string cikolataAd = txtcikoadi.Text;
                    int adet;
                    if (!int.TryParse(txtadet.Text, out adet))
                    {
                        MessageBox.Show("Adet alanına geçerli bir sayı girin.");
                        return;
                    }
                    DateTime siparisTarihi = dateTimePicker1.Value;
                    decimal tutar;
                    if (!decimal.TryParse(txttutar.Text, out tutar) || tutar <= 0)
                    {
                        MessageBox.Show("Geçerli bir tutar girin.");
                        return;
                    }

                    // Şirket ID'yi şirket adına göre sorgula
                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT sirketid FROM musteri WHERE sirketadi=@sirketadi", connection))
                    {
                        command.Parameters.AddWithValue("@sirketadi", sirketAd);
                        object sirketId = command.ExecuteScalar();

                        if (sirketId != null)
                        {
                            // Çikolata birim fiyatını almak için cikolatalar tablosundan sorgu yap
                            string birimFiyatSorgu = "SELECT birimfiyat FROM cikolatalar WHERE cikolataadi = @cikolataadi";
                            using (NpgsqlCommand birimFiyatCommand = new NpgsqlCommand(birimFiyatSorgu, connection))
                            {
                                birimFiyatCommand.Parameters.AddWithValue("@cikolataadi", cikolataAd);
                                object birimFiyatObj = birimFiyatCommand.ExecuteScalar();

                                if (birimFiyatObj != null)
                                {
                                    decimal birimFiyat = Convert.ToDecimal(birimFiyatObj);

                                    // PostgreSQL UPDATE sorgusu
                                    string updateQuery = "UPDATE siparis SET sirketid=@sirketid, sirketadi=@sirketadi, cikolataadi=@cikolataadi, siparisadeti=@siparisadeti, siparistarihi=@siparistarihi, tutar=@tutar WHERE siparisno=@siparisno";

                                    using (NpgsqlCommand updateCommand = new NpgsqlCommand(updateQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@siparisno", siparisNo);
                                        updateCommand.Parameters.AddWithValue("@sirketid", sirketId);
                                        updateCommand.Parameters.AddWithValue("@sirketadi", sirketAd);
                                        updateCommand.Parameters.AddWithValue("@cikolataadi", cikolataAd);
                                        updateCommand.Parameters.AddWithValue("@siparisadeti", adet);
                                        updateCommand.Parameters.AddWithValue("@siparistarihi", siparisTarihi);
                                        updateCommand.Parameters.AddWithValue("@tutar", tutar);

                                        updateCommand.ExecuteNonQuery();

                                        MessageBox.Show("Sipariş başarıyla güncellendi!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"Belirtilen çikolata adı bulunamadı. Çikolata Adı: {cikolataAd}");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Şirket bulunamadı. Lütfen geçerli bir şirket adı girin.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }



        }

        private void arabtn_Click(object sender, EventArgs e)
        {
            string aramaKelimesi = txtara.Text.Trim();

            if (string.IsNullOrEmpty(aramaKelimesi))
            {
                MessageBox.Show("Lütfen bir arama kelimesi girin.");
                return;
            }

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Şirket adına veya çikolata adına göre arama yap
                    string aramaSorgu = "SELECT * FROM siparis WHERE sirketadi ILIKE @aramaKelimesi OR cikolataadi ILIKE @aramaKelimesi";
                    using (NpgsqlCommand aramaCommand = new NpgsqlCommand(aramaSorgu, connection))
                    {
                        aramaCommand.Parameters.AddWithValue("@aramaKelimesi", "%" + aramaKelimesi + "%");

                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(aramaCommand))
                        {
                            // DataSet oluştur
                            DataSet ds = new DataSet();

                            // SQL sorgusunu çalıştır ve sonuçları DataSet'e doldur
                            adapter.Fill(ds);

                            // DataGridView'e DataSet'teki tabloyu bağla
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama yapılırken bir hata oluştu: " + ex.Message);
            }
        }

        private void geribtn_Click(object sender, EventArgs e)
        {
            müdürekran gcs = new müdürekran();
            gcs.Show();
            this.Hide();
        }

        private void siparis_Load(object sender, EventArgs e)
        {

        }

        private void anasayfabtn_Click(object sender, EventArgs e)
        {
            AnaGiris gcs = new AnaGiris();
            gcs.Show();
            this.Hide();
        }
    }
}


