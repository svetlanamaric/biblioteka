namespace BibliotekaProjekat
{
    partial class FormaClanovi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.textBoxBrojTelefona = new System.Windows.Forms.TextBox();
            this.buttonUkloniPodatkeClana = new System.Windows.Forms.Button();
            this.buttonObrisiClana = new System.Windows.Forms.Button();
            this.buttonIzmeniClana = new System.Windows.Forms.Button();
            this.buttonDodajClana = new System.Windows.Forms.Button();
            this.textBoxAdresaClana = new System.Windows.Forms.TextBox();
            this.textBoxPrezimeClana = new System.Windows.Forms.TextBox();
            this.textBoxImeClana = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblPrezimeClana = new System.Windows.Forms.Label();
            this.lblImeClana = new System.Windows.Forms.Label();
            this.buttonPretragaClana = new System.Windows.Forms.Button();
            this.dataGridViewClanovi = new System.Windows.Forms.DataGridView();
            this.textBoxPretraga = new System.Windows.Forms.TextBox();
            this.labelBrojClanskeKarte = new System.Windows.Forms.Label();
            this.textBoxBrojClanskeKarte = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBrojClanskeKarte);
            this.groupBox1.Controls.Add(this.labelBrojClanskeKarte);
            this.groupBox1.Controls.Add(this.buttonPrikazi);
            this.groupBox1.Controls.Add(this.lblBrojTelefona);
            this.groupBox1.Controls.Add(this.textBoxBrojTelefona);
            this.groupBox1.Controls.Add(this.buttonUkloniPodatkeClana);
            this.groupBox1.Controls.Add(this.buttonObrisiClana);
            this.groupBox1.Controls.Add(this.buttonIzmeniClana);
            this.groupBox1.Controls.Add(this.buttonDodajClana);
            this.groupBox1.Controls.Add(this.textBoxAdresaClana);
            this.groupBox1.Controls.Add(this.textBoxPrezimeClana);
            this.groupBox1.Controls.Add(this.textBoxImeClana);
            this.groupBox1.Controls.Add(this.lblAdresa);
            this.groupBox1.Controls.Add(this.lblPrezimeClana);
            this.groupBox1.Controls.Add(this.lblImeClana);
            this.groupBox1.Location = new System.Drawing.Point(715, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 421);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Članovi biblioteke";
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.Location = new System.Drawing.Point(125, 320);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(75, 23);
            this.buttonPrikazi.TabIndex = 15;
            this.buttonPrikazi.Text = "Prikaži";
            this.buttonPrikazi.UseVisualStyleBackColor = true;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(17, 228);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(66, 13);
            this.lblBrojTelefona.TabIndex = 14;
            this.lblBrojTelefona.Text = "Broj telefona";
            // 
            // textBoxBrojTelefona
            // 
            this.textBoxBrojTelefona.Location = new System.Drawing.Point(126, 221);
            this.textBoxBrojTelefona.Name = "textBoxBrojTelefona";
            this.textBoxBrojTelefona.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrojTelefona.TabIndex = 13;
            // 
            // buttonUkloniPodatkeClana
            // 
            this.buttonUkloniPodatkeClana.Location = new System.Drawing.Point(43, 371);
            this.buttonUkloniPodatkeClana.Name = "buttonUkloniPodatkeClana";
            this.buttonUkloniPodatkeClana.Size = new System.Drawing.Size(157, 33);
            this.buttonUkloniPodatkeClana.TabIndex = 11;
            this.buttonUkloniPodatkeClana.Text = "Ukloni podatke";
            this.buttonUkloniPodatkeClana.UseVisualStyleBackColor = true;
            this.buttonUkloniPodatkeClana.Click += new System.EventHandler(this.buttonUkloniPodatkeClana_Click);
            // 
            // buttonObrisiClana
            // 
            this.buttonObrisiClana.Location = new System.Drawing.Point(24, 320);
            this.buttonObrisiClana.Name = "buttonObrisiClana";
            this.buttonObrisiClana.Size = new System.Drawing.Size(75, 23);
            this.buttonObrisiClana.TabIndex = 10;
            this.buttonObrisiClana.Text = "Obriši";
            this.buttonObrisiClana.UseVisualStyleBackColor = true;
            this.buttonObrisiClana.Click += new System.EventHandler(this.buttonObrisiClana_Click);
            // 
            // buttonIzmeniClana
            // 
            this.buttonIzmeniClana.Location = new System.Drawing.Point(128, 262);
            this.buttonIzmeniClana.Name = "buttonIzmeniClana";
            this.buttonIzmeniClana.Size = new System.Drawing.Size(75, 23);
            this.buttonIzmeniClana.TabIndex = 9;
            this.buttonIzmeniClana.Text = "Izmeni";
            this.buttonIzmeniClana.UseVisualStyleBackColor = true;
            this.buttonIzmeniClana.Click += new System.EventHandler(this.buttonIzmeniClana_Click);
            // 
            // buttonDodajClana
            // 
            this.buttonDodajClana.Location = new System.Drawing.Point(24, 262);
            this.buttonDodajClana.Name = "buttonDodajClana";
            this.buttonDodajClana.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajClana.TabIndex = 8;
            this.buttonDodajClana.Text = "Dodaj člana";
            this.buttonDodajClana.UseVisualStyleBackColor = true;
            this.buttonDodajClana.Click += new System.EventHandler(this.buttonDodajClana_Click);
            // 
            // textBoxAdresaClana
            // 
            this.textBoxAdresaClana.Location = new System.Drawing.Point(126, 177);
            this.textBoxAdresaClana.Name = "textBoxAdresaClana";
            this.textBoxAdresaClana.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdresaClana.TabIndex = 7;
            // 
            // textBoxPrezimeClana
            // 
            this.textBoxPrezimeClana.Location = new System.Drawing.Point(126, 128);
            this.textBoxPrezimeClana.Name = "textBoxPrezimeClana";
            this.textBoxPrezimeClana.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrezimeClana.TabIndex = 6;
            // 
            // textBoxImeClana
            // 
            this.textBoxImeClana.Location = new System.Drawing.Point(126, 89);
            this.textBoxImeClana.Name = "textBoxImeClana";
            this.textBoxImeClana.Size = new System.Drawing.Size(100, 20);
            this.textBoxImeClana.TabIndex = 5;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(17, 184);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(40, 13);
            this.lblAdresa.TabIndex = 3;
            this.lblAdresa.Text = "Adresa";
            // 
            // lblPrezimeClana
            // 
            this.lblPrezimeClana.AutoSize = true;
            this.lblPrezimeClana.Location = new System.Drawing.Point(17, 135);
            this.lblPrezimeClana.Name = "lblPrezimeClana";
            this.lblPrezimeClana.Size = new System.Drawing.Size(47, 13);
            this.lblPrezimeClana.TabIndex = 2;
            this.lblPrezimeClana.Text = "Prezime ";
            // 
            // lblImeClana
            // 
            this.lblImeClana.AutoSize = true;
            this.lblImeClana.Location = new System.Drawing.Point(17, 96);
            this.lblImeClana.Name = "lblImeClana";
            this.lblImeClana.Size = new System.Drawing.Size(27, 13);
            this.lblImeClana.TabIndex = 1;
            this.lblImeClana.Text = "Ime ";
            // 
            // buttonPretragaClana
            // 
            this.buttonPretragaClana.Location = new System.Drawing.Point(367, 14);
            this.buttonPretragaClana.Name = "buttonPretragaClana";
            this.buttonPretragaClana.Size = new System.Drawing.Size(73, 23);
            this.buttonPretragaClana.TabIndex = 12;
            this.buttonPretragaClana.Text = "Pretraga";
            this.buttonPretragaClana.UseVisualStyleBackColor = true;
            this.buttonPretragaClana.Click += new System.EventHandler(this.buttonPretragaClana_Click);
            // 
            // dataGridViewClanovi
            // 
            this.dataGridViewClanovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewClanovi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClanovi.Location = new System.Drawing.Point(12, 63);
            this.dataGridViewClanovi.Name = "dataGridViewClanovi";
            this.dataGridViewClanovi.Size = new System.Drawing.Size(657, 421);
            this.dataGridViewClanovi.TabIndex = 3;
            this.dataGridViewClanovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClanovi_CellContentClick);
            // 
            // textBoxPretraga
            // 
            this.textBoxPretraga.Location = new System.Drawing.Point(29, 17);
            this.textBoxPretraga.Name = "textBoxPretraga";
            this.textBoxPretraga.Size = new System.Drawing.Size(297, 20);
            this.textBoxPretraga.TabIndex = 5;
            // 
            // labelBrojClanskeKarte
            // 
            this.labelBrojClanskeKarte.AutoSize = true;
            this.labelBrojClanskeKarte.Location = new System.Drawing.Point(17, 54);
            this.labelBrojClanskeKarte.Name = "labelBrojClanskeKarte";
            this.labelBrojClanskeKarte.Size = new System.Drawing.Size(92, 13);
            this.labelBrojClanskeKarte.TabIndex = 16;
            this.labelBrojClanskeKarte.Text = "Broj članske karte";
            // 
            // textBoxBrojClanskeKarte
            // 
            this.textBoxBrojClanskeKarte.Location = new System.Drawing.Point(128, 47);
            this.textBoxBrojClanskeKarte.Name = "textBoxBrojClanskeKarte";
            this.textBoxBrojClanskeKarte.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrojClanskeKarte.TabIndex = 17;
            // 
            // FormaClanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 490);
            this.Controls.Add(this.textBoxPretraga);
            this.Controls.Add(this.buttonPretragaClana);
            this.Controls.Add(this.dataGridViewClanovi);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormaClanovi";
            this.Text = "Članovi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClanovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.TextBox textBoxBrojTelefona;
        private System.Windows.Forms.Button buttonPretragaClana;
        private System.Windows.Forms.Button buttonUkloniPodatkeClana;
        private System.Windows.Forms.Button buttonObrisiClana;
        private System.Windows.Forms.Button buttonIzmeniClana;
        private System.Windows.Forms.Button buttonDodajClana;
        private System.Windows.Forms.TextBox textBoxAdresaClana;
        private System.Windows.Forms.TextBox textBoxPrezimeClana;
        private System.Windows.Forms.TextBox textBoxImeClana;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblPrezimeClana;
        private System.Windows.Forms.Label lblImeClana;
        private System.Windows.Forms.DataGridView dataGridViewClanovi;
        private System.Windows.Forms.TextBox textBoxPretraga;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.TextBox textBoxBrojClanskeKarte;
        private System.Windows.Forms.Label labelBrojClanskeKarte;
    }
}