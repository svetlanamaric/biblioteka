namespace BibliotekaProjekat
{
    partial class PocetnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaForma));
            this.pictureBoxClanovi = new System.Windows.Forms.PictureBox();
            this.pictureBoxKnjige = new System.Windows.Forms.PictureBox();
            this.pictureBoxRezervisaneKnjige = new System.Windows.Forms.PictureBox();
            this.lblKnjige = new System.Windows.Forms.Label();
            this.lblClanoviBiblioteke = new System.Windows.Forms.Label();
            this.lblRezervisaneKnjige = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClanovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKnjige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRezervisaneKnjige)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxClanovi
            // 
            this.pictureBoxClanovi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClanovi.Image")));
            this.pictureBoxClanovi.Location = new System.Drawing.Point(53, 43);
            this.pictureBoxClanovi.Name = "pictureBoxClanovi";
            this.pictureBoxClanovi.Size = new System.Drawing.Size(158, 127);
            this.pictureBoxClanovi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClanovi.TabIndex = 3;
            this.pictureBoxClanovi.TabStop = false;
            this.pictureBoxClanovi.Click += new System.EventHandler(this.pictureBoxClanovi_Click);
            // 
            // pictureBoxKnjige
            // 
            this.pictureBoxKnjige.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKnjige.Image")));
            this.pictureBoxKnjige.Location = new System.Drawing.Point(264, 44);
            this.pictureBoxKnjige.Name = "pictureBoxKnjige";
            this.pictureBoxKnjige.Size = new System.Drawing.Size(149, 128);
            this.pictureBoxKnjige.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKnjige.TabIndex = 4;
            this.pictureBoxKnjige.TabStop = false;
            this.pictureBoxKnjige.Click += new System.EventHandler(this.pictureBoxKnjige_Click);
            // 
            // pictureBoxRezervisaneKnjige
            // 
            this.pictureBoxRezervisaneKnjige.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRezervisaneKnjige.Image")));
            this.pictureBoxRezervisaneKnjige.Location = new System.Drawing.Point(476, 44);
            this.pictureBoxRezervisaneKnjige.Name = "pictureBoxRezervisaneKnjige";
            this.pictureBoxRezervisaneKnjige.Size = new System.Drawing.Size(167, 126);
            this.pictureBoxRezervisaneKnjige.TabIndex = 5;
            this.pictureBoxRezervisaneKnjige.TabStop = false;
            this.pictureBoxRezervisaneKnjige.Click += new System.EventHandler(this.pictureBoxRezervisaneKnjige_Click);
            // 
            // lblKnjige
            // 
            this.lblKnjige.AutoSize = true;
            this.lblKnjige.Location = new System.Drawing.Point(325, 192);
            this.lblKnjige.Name = "lblKnjige";
            this.lblKnjige.Size = new System.Drawing.Size(36, 13);
            this.lblKnjige.TabIndex = 6;
            this.lblKnjige.Text = "Knjige";
            // 
            // lblClanoviBiblioteke
            // 
            this.lblClanoviBiblioteke.AutoSize = true;
            this.lblClanoviBiblioteke.Location = new System.Drawing.Point(112, 192);
            this.lblClanoviBiblioteke.Name = "lblClanoviBiblioteke";
            this.lblClanoviBiblioteke.Size = new System.Drawing.Size(42, 13);
            this.lblClanoviBiblioteke.TabIndex = 7;
            this.lblClanoviBiblioteke.Text = "Članovi";
            // 
            // lblRezervisaneKnjige
            // 
            this.lblRezervisaneKnjige.AutoSize = true;
            this.lblRezervisaneKnjige.Location = new System.Drawing.Point(519, 192);
            this.lblRezervisaneKnjige.Name = "lblRezervisaneKnjige";
            this.lblRezervisaneKnjige.Size = new System.Drawing.Size(67, 13);
            this.lblRezervisaneKnjige.TabIndex = 8;
            this.lblRezervisaneKnjige.Text = "Izdate knjige";
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 239);
            this.Controls.Add(this.lblRezervisaneKnjige);
            this.Controls.Add(this.lblClanoviBiblioteke);
            this.Controls.Add(this.lblKnjige);
            this.Controls.Add(this.pictureBoxRezervisaneKnjige);
            this.Controls.Add(this.pictureBoxKnjige);
            this.Controls.Add(this.pictureBoxClanovi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PocetnaForma";
            this.Text = "Biblioteka";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClanovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKnjige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRezervisaneKnjige)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClanovi;
        private System.Windows.Forms.PictureBox pictureBoxKnjige;
        private System.Windows.Forms.PictureBox pictureBoxRezervisaneKnjige;
        private System.Windows.Forms.Label lblKnjige;
        private System.Windows.Forms.Label lblClanoviBiblioteke;
        private System.Windows.Forms.Label lblRezervisaneKnjige;
    }
}

