using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaProjekat
{
    public partial class PocetnaForma : Form
    {
       
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void pictureBoxKnjige_Click(object sender, EventArgs e)
        {
            Form formKnjige = new FormaKnjige();
            formKnjige.Show();
        }

        private void pictureBoxClanovi_Click(object sender, EventArgs e)
        {
            Form formClanovi = new FormaClanovi();
            formClanovi.Show();
        }

        private void pictureBoxRezervisaneKnjige_Click(object sender, EventArgs e)
        {
            Form formIzdateKnjige = new IzdateKnjigeForm();
            formIzdateKnjige.Show();
        }
    }
}
