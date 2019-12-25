using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaProjekat
{
    public partial class IzdavanjeForma : Form
    {
        SqlDataAdapter da;
        string connString = Utility.GetConnectionString();

        public IzdavanjeForma()
        {
            InitializeComponent();
        }
    
        private void buttonIzdavanje_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                int brojClkarte = Convert.ToInt32(textBoxRezervacija.Text);

                SqlCommand provera = new SqlCommand("SELECT COUNT(*) FROM bibliotekaClanovi WHERE (BrojClanskeKarte = @BrojClanskeKarte)", conn);
                provera.Parameters.AddWithValue("@BrojClanskeKarte", textBoxRezervacija.Text);
                int UserExist = (int)provera.ExecuteScalar();

                if (UserExist > 0)
                {
                    MessageBox.Show("Knjiga je izdata.");

                    SqlCommand sqlComm = new SqlCommand();
                    sqlComm = conn.CreateCommand();
                    sqlComm.CommandText = @"INSERT INTO bibliotekaRezervisaneKnjige (BrojClanskeKarte, NazivKnjige, Autor) VALUES (@brojClkarte, @nazivKnjige, @autorKnjige)";
                    sqlComm.Parameters.Add("@brojClkarte", SqlDbType.Int);
                    sqlComm.Parameters["@brojClkarte"].Value = brojClkarte;
                    sqlComm.Parameters.Add("@nazivKnjige", SqlDbType.VarChar);
                    sqlComm.Parameters["@nazivKnjige"].Value = KliknutaKnjiga.nazivKnjige;
                    sqlComm.Parameters.Add("@autorKnjige", SqlDbType.VarChar);
                    sqlComm.Parameters["@autorKnjige"].Value = KliknutaKnjiga.autorKnjige;

                    sqlComm.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Broj članske karte nije ispravan.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Regular Error message");
            }
            finally
            {
                conn.Close();
            }

            this.Close();
        }
    }
}

