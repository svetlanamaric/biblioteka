using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaProjekat
{
    public partial class IzdateKnjigeForm : Form 
    {
        string connString = Utility.GetConnectionString();
        int Id = 0;

        public IzdateKnjigeForm()
        {
            InitializeComponent();
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

        private void FillDataGrid()
        {
           SqlConnection conn = new SqlConnection(connString);
           string sql = "SELECT * FROM bibliotekaRezervisaneKnjige";

           DataSet ds = new DataSet();
           SqlDataAdapter da = new SqlDataAdapter(sql, conn);
           SqlCommandBuilder builder = new SqlCommandBuilder(da);
           da.Fill(ds);

            dataGridViewRezervacije.DataSource = ds.Tables[0];
        }
    }
}


