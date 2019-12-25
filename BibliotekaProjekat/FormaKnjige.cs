using System;
using System.Windows.Forms;

namespace BibliotekaProjekat
{
    public partial class FormaKnjige : Form
    {
        public FormaKnjige()
        {
            InitializeComponent();

            richTextBox.ReadOnly = true;
            richTextBox1.ReadOnly = true;
            richTextBox2.ReadOnly = true;
            richTextBox3.ReadOnly = true;
            richTextBox4.ReadOnly = true;
            richTextBox5.ReadOnly = true;
            richTextBox6.ReadOnly = true;
            richTextBox7.ReadOnly = true;
            richTextBox8.ReadOnly = true;   
            
        }

        private void pictureBoxVelikiMislilac_Click(object sender, EventArgs e)
        {
            Form rezervacijaForma = new IzdavanjeForma();
            rezervacijaForma.Show();

            KliknutaKnjiga.nazivKnjige = labelVelikiMislilacNaslov.Text;
            KliknutaKnjiga.autorKnjige = labelVelikiMislilacAutor.Text;
        }

        private void pictureBoxKaGranici_Click(object sender, EventArgs e)
        {
            Form rezervacijaForma = new IzdavanjeForma();
            rezervacijaForma.Show();

            KliknutaKnjiga.nazivKnjige = lblKaGraniciNaslov.Text;
            KliknutaKnjiga.autorKnjige = LblKaGraniciAutor.Text;
        }

        private void pictureBoxBezdno_Click(object sender, EventArgs e)
        {
            Form rezervacijaForma = new IzdavanjeForma();
            rezervacijaForma.Show();

            KliknutaKnjiga.nazivKnjige = lblBezdnoNaslov.Text;
            KliknutaKnjiga.autorKnjige = lblBezdnoAutor.Text;

        }

        private void pictureBoxKoferIzBerlina_Click(object sender, EventArgs e)
        {
            Form rezervacijaForma = new IzdavanjeForma();
            rezervacijaForma.Show();

            KliknutaKnjiga.nazivKnjige = labelKoferIzBerlinaNaslov.Text;
            KliknutaKnjiga.autorKnjige = labelKoferIzBerlinaAutor.Text;
        }

        private void pictureBoxPoredPuta_Click(object sender, EventArgs e)
        {
            Form rezervacijaForma = new IzdavanjeForma();
            rezervacijaForma.Show();

            KliknutaKnjiga.nazivKnjige = lblPoredPutaNaslov.Text;
            KliknutaKnjiga.autorKnjige = lblPoredPutaAutor.Text;
        }

        private void pictureBoxZeneIzZamka_Click(object sender, EventArgs e)
        {
            Form rezervacijaForma = new IzdavanjeForma();
            rezervacijaForma.Show();

            KliknutaKnjiga.nazivKnjige = lblZeneIzZamkaNaslov.Text;
            KliknutaKnjiga.autorKnjige = lblZeneIzZamkaAutor.Text;
        }

        private void pictureBoxIgreZmaja_Click(object sender, EventArgs e)
        {
            Form rezervacijaForma = new IzdavanjeForma();
            rezervacijaForma.Show();

            KliknutaKnjiga.nazivKnjige = labelNaslovIgreZmaja.Text;
            KliknutaKnjiga.autorKnjige = labelIgreZmajaAutor.Text;
        }

        private void pictureBoxDokVremeProtice_Click(object sender, EventArgs e)
        {
            Form rezervacijaForma = new IzdavanjeForma();
            rezervacijaForma.Show();

            KliknutaKnjiga.nazivKnjige = lblDokVremeProticeNaslov.Text;
            KliknutaKnjiga.autorKnjige = lblDokVremeProticeAutor.Text;
        }

        private void pictureBoxOlujniBedem_Click(object sender, EventArgs e)
        {
            Form rezervacijaForma = new IzdavanjeForma();
            rezervacijaForma.Show();

            KliknutaKnjiga.nazivKnjige = lblOlujniBedemNaslov.Text;
            KliknutaKnjiga.autorKnjige = lblOlujniBedemAutor.Text;
        }
    }
}
