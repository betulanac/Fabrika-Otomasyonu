using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Fabrika_Otomasyonu
{
    public partial class gider : Form
    {
        private string connectionString = "Host=localhost;Port=5433;Database=Fabrika;User Id=postgres;Password=cfuUm.0696;";

        public gider()
        {
            InitializeComponent();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {


            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    if (cmbtip.SelectedItem != null)
                    {
                        string gidertipi = cmbtip.SelectedItem.ToString();

                        string insertQuery = "INSERT INTO gider (gidertipi, aciklama, tarih, tutar) " +
                                             "VALUES (@p_gidertipi, @p_aciklama, @p_tarih, @p_tutar)";

                        using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@p_gidertipi", gidertipi);
                            command.Parameters.AddWithValue("@p_aciklama", txtaciklama.Text);
                            command.Parameters.AddWithValue("@p_tarih", dateTimePicker1.Value);

                            // Tutar alanı boş olabilir, boşsa 0 olarak kabul et
                            decimal tutar;
                            if (decimal.TryParse(txttutar.Text, out tutar))
                            {
                                command.Parameters.AddWithValue("@p_tutar", tutar);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@p_tutar", 0);
                            }

                            command.ExecuteNonQuery();

                            MessageBox.Show("Gider başarıyla eklendi!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir gidertipi seçin.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

        }

        private void listbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM gider", connection))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        // Seçili satırın giderno değerini al
                        int selectedGiderNo = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["giderno"].Value);

                        // PostgreSQL DELETE sorgusu
                        string deleteQuery = "DELETE FROM gider WHERE giderno = @p_giderno";

                        using (NpgsqlCommand command = new NpgsqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@p_giderno", selectedGiderNo);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Gider başarıyla silindi!");
                        }

                        // DataGridView'i güncelle
                        // Listele();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen silmek istediğiniz bir gider seçin.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtgiderno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cmbtip.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtaciklama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txttutar.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void gncbtn_Click(object sender, EventArgs e)
        {

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE gider SET gidertipi = @gidertipi, aciklama = @aciklama, tarih = @tarih, tutar = @tutar WHERE giderno = @giderno";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@gidertipi", cmbtip.Text);
                        command.Parameters.AddWithValue("@aciklama", txtaciklama.Text);
                        command.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);

                        // NpgsqlDbType.Numeric ekleyerek hatayı çözebilirsiniz.
                        command.Parameters.Add(new NpgsqlParameter("@tutar", NpgsqlDbType.Numeric));
                        command.Parameters["@tutar"].Value = Convert.ToDecimal(txttutar.Text);

                        // txtgiderno.Text'i kullanmalısınız
                        command.Parameters.AddWithValue("@giderno", int.Parse(txtgiderno.Text));


                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Veri güncellendi");
                            // DataGridView'i güncel verilerle yeniden doldurabilirsiniz.
                        }
                        else
                        {
                            MessageBox.Show("Veri güncellenemedi");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
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


