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
    public partial class cikolatagelir : Form
    {
        private string connectionString = "Host=localhost;Port=5433;Database=Fabrika;User Id=postgres;Password=cfuUm.0696;";
        public cikolatagelir()
        {
            InitializeComponent();
        }
        private void GetirVeGoster()
        {
            
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                
                using (NpgsqlCommand command = new NpgsqlCommand("guncelgelir", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                  
                    command.ExecuteNonQuery();
                }

               
                string selectQuery = "SELECT * FROM GelirFormu";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(selectQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    richTextBox1.Text = "GelirFormu Tablosu Verileri:\n";
                    foreach (DataRow row in dataTable.Rows)
                    {
                        richTextBox1.AppendText($"ID: {row["gelirformu_id"]}, Toplam Gelir: {row["toplamgelir"]}," +
                            $" Eklenen Tarih: {row["eklenentarih"]}\n");
                    }
                }
            }
        }

        private void cikolatagelir_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetirVeGoster();
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
