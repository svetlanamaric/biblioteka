namespace BibliotekaProjekat
{
    partial class IzdavanjeForma
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
            this.Rezervacija = new System.Windows.Forms.Label();
            this.buttonIzdavanje = new System.Windows.Forms.Button();
            this.textBoxRezervacija = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Rezervacija
            // 
            this.Rezervacija.AutoSize = true;
            this.Rezervacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rezervacija.Location = new System.Drawing.Point(79, 32);
            this.Rezervacija.Name = "Rezervacija";
            this.Rezervacija.Size = new System.Drawing.Size(290, 20);
            this.Rezervacija.TabIndex = 0;
            this.Rezervacija.Text = "Molimo Vas unesite broj članske kartice!\r\n";
            // 
            // buttonIzdavanje
            // 
            this.buttonIzdavanje.Location = new System.Drawing.Point(183, 139);
            this.buttonIzdavanje.Name = "buttonIzdavanje";
            this.buttonIzdavanje.Size = new System.Drawing.Size(75, 23);
            this.buttonIzdavanje.TabIndex = 2;
            this.buttonIzdavanje.Text = "Izdavanje";
            this.buttonIzdavanje.UseVisualStyleBackColor = true;
            this.buttonIzdavanje.Click += new System.EventHandler(this.buttonIzdavanje_Click_1);
            // 
            // textBoxRezervacija
            // 
            this.textBoxRezervacija.Location = new System.Drawing.Point(172, 82);
            this.textBoxRezervacija.Name = "textBoxRezervacija";
            this.textBoxRezervacija.Size = new System.Drawing.Size(100, 20);
            this.textBoxRezervacija.TabIndex = 3;
            // 
            // IzdavanjeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 186);
            this.Controls.Add(this.textBoxRezervacija);
            this.Controls.Add(this.buttonIzdavanje);
            this.Controls.Add(this.Rezervacija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IzdavanjeForma";
            this.Text = "Izdavanje knjiga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rezervacija;
        private System.Windows.Forms.Button buttonIzdavanje;
        private System.Windows.Forms.TextBox textBoxRezervacija;
    }
}