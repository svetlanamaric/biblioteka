
using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BibliotekaProjekat
{

    public partial class FormaClanovi : Form
    {
        string connString = Utility.GetConnectionString();
        int Id = 0;

        public FormaClanovi()
        {
            InitializeComponent();
            textBoxBrojClanskeKarte.Enabled = false;
        }

        private void buttonDodajClana_Click(object sender, EventArgs e)
        {
            if (textBoxImeClana.Text.Trim().Length == 0 || textBoxPrezimeClana.Text.Trim().Length == 0 ||
               textBoxAdresaClana.Text.Trim().Length == 0 || textBoxBrojTelefona.Text.Trim().Length == 0)
            {
                MessageBox.Show("Molimo Vas popunite sva polja.");
            }
            else
            {

                SqlConnection conn = new SqlConnection(connString);

                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    if (buttonDodajClana.Text == "Dodaj člana")
                    {
                        SqlCommand sqlCmd = new SqlCommand("[dbo].[bibliotekaClanoviDodavanjeIzmena]", conn);
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        sqlCmd.Parameters.AddWithValue("@Mode", "Add");
                        sqlCmd.Parameters.AddWithValue("@BrojClanskeKarte", 0);
                        sqlCmd.Parameters.AddWithValue("@Ime", textBoxImeClana.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Prezime", textBoxPrezimeClana.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Adresa", textBoxAdresaClana.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@BrojTelefona", textBoxBrojTelefona.Text.Trim());

                        sqlCmd.ExecuteNonQuery();

                        MessageBox.Show("Član je uspešno dodat.");

                        Reset();
                        FillDataGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error message");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void buttonIzmeniClana_Click(object sender, EventArgs e)
        {
            if (textBoxImeClana.Text.Trim().Length == 0 || textBoxPrezimeClana.Text.Trim().Length == 0 ||
               textBoxAdresaClana.Text.Trim().Length == 0 || textBoxBrojTelefona.Text.Trim().Length == 0)
            {
                MessageBox.Show("Molimo Vas popunite sva polja.");
            }
            else
            {
                SqlConnection conn = new SqlConnection(connString);
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    if (buttonIzmeniClana.Text == "Izmeni")
                    {
                        SqlCommand sqlCmd = new SqlCommand("[dbo].[bibliotekaClanoviDodavanjeIzmena]", conn);
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        sqlCmd.Parameters.AddWithValue("@Mode", "Edit");
                        sqlCmd.Parameters.AddWithValue("@BrojClanskeKarte", Id);
                        sqlCmd.Parameters.AddWithValue("@Ime", textBoxImeClana.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Prezime", textBoxPrezimeClana.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Adresa", textBoxAdresaClana.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@BrojTelefona", textBoxBrojTelefona.Text.Trim());

                        sqlCmd.ExecuteNonQuery();

                        MessageBox.Show("Podaci su promenjeni.");

                        Reset();
                        FillDataGrid();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error message");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void FillDataGrid()
        {
            SqlConnection conn = new SqlConnection(connString);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlDataAdapter adapter = new SqlDataAdapter("[dbo].[bibliotekaClanoviPrikazPretraga]", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@PodaciClana", textBoxPretraga.Text.Trim());

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridViewClanovi.DataSource = dt;
            dataGridViewClanovi.Columns[0].Visible = false;

            conn.Close();
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error message");
            }
        }

        private void Reset()
        {
            textBoxBrojClanskeKarte.Text = textBoxImeClana.Text = textBoxPrezimeClana.Text = textBoxAdresaClana.Text = textBoxBrojTelefona.Text = string.Empty;
            buttonDodajClana.Text = "Dodaj člana";
            Id = 0;
            buttonObrisiClana.Enabled = false;
        }

        private void buttonUkloniPodatkeClana_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void buttonObrisiClana_Click(object sender, EventArgs e)
        {
            if (textBoxImeClana.Text.Trim().Length == 0 || textBoxPrezimeClana.Text.Trim().Length == 0 ||
               textBoxAdresaClana.Text.Trim().Length == 0 || textBoxBrojTelefona.Text.Trim().Length == 0)
            {
                MessageBox.Show("Molimo Vas popunite sva polja.");
            }
            else
            {
                SqlConnection conn = new SqlConnection(connString);

                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    SqlCommand sqlCmd = new SqlCommand("[dbo].[bibliotekaClanoviBrisanje]", conn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.AddWithValue("@Id", Id);
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Uspešno ste obrisali");

                    Reset();
                    FillDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error message");
                }
            }
        }

        private void buttonPretragaClana_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error message");
            }
        }

        private void dataGridViewClanovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewClanovi.CurrentRow.Index != -1)
            {
                Id = Convert.ToInt32(dataGridViewClanovi.CurrentRow.Cells[0].Value.ToString());
                textBoxImeClana.Text = dataGridViewClanovi.CurrentRow.Cells[1].Value.ToString();
                textBoxPrezimeClana.Text = dataGridViewClanovi.CurrentRow.Cells[2].Value.ToString();
                textBoxAdresaClana.Text = dataGridViewClanovi.CurrentRow.Cells[3].Value.ToString();
                textBoxBrojTelefona.Text = dataGridViewClanovi.CurrentRow.Cells[4].Value.ToString();

                buttonObrisiClana.Enabled = true;
            }
        }
    }
}