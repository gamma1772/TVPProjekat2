
namespace TVPProjekat2_KorisnikManager
{
    partial class FormDodaj
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
            System.Windows.Forms.Label uUIDLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label korisnicko_imeLabel;
            System.Windows.Forms.Label sifraLabel;
            System.Windows.Forms.Label datum_rodjenjaLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label broj_telefonaLabel;
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.uUIDTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.korisnicko_imeTextBox = new System.Windows.Forms.TextBox();
            this.sifraTextBox = new System.Windows.Forms.TextBox();
            this.datum_rodjenjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.broj_telefonaTextBox = new System.Windows.Forms.TextBox();
            uUIDLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            korisnicko_imeLabel = new System.Windows.Forms.Label();
            sifraLabel = new System.Windows.Forms.Label();
            datum_rodjenjaLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            broj_telefonaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(140, 292);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 36;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.close);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(14, 292);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 35;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.create);
            // 
            // uUIDLabel
            // 
            uUIDLabel.AutoSize = true;
            uUIDLabel.Location = new System.Drawing.Point(12, 9);
            uUIDLabel.Name = "uUIDLabel";
            uUIDLabel.Size = new System.Drawing.Size(37, 13);
            uUIDLabel.TabIndex = 19;
            uUIDLabel.Text = "UUID:";
            // 
            // uUIDTextBox
            // 
            this.uUIDTextBox.Enabled = false;
            this.uUIDTextBox.Location = new System.Drawing.Point(15, 25);
            this.uUIDTextBox.Name = "uUIDTextBox";
            this.uUIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.uUIDTextBox.TabIndex = 20;
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(12, 48);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(24, 13);
            imeLabel.TabIndex = 21;
            imeLabel.Text = "Ime";
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(15, 64);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(100, 20);
            this.imeTextBox.TabIndex = 22;
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(118, 48);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(44, 13);
            prezimeLabel.TabIndex = 23;
            prezimeLabel.Text = "Prezime";
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(121, 64);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(94, 20);
            this.prezimeTextBox.TabIndex = 24;
            // 
            // korisnicko_imeLabel
            // 
            korisnicko_imeLabel.AutoSize = true;
            korisnicko_imeLabel.Location = new System.Drawing.Point(12, 87);
            korisnicko_imeLabel.Name = "korisnicko_imeLabel";
            korisnicko_imeLabel.Size = new System.Drawing.Size(75, 13);
            korisnicko_imeLabel.TabIndex = 25;
            korisnicko_imeLabel.Text = "Korisničko ime";
            // 
            // korisnicko_imeTextBox
            // 
            this.korisnicko_imeTextBox.Location = new System.Drawing.Point(15, 142);
            this.korisnicko_imeTextBox.Name = "korisnicko_imeTextBox";
            this.korisnicko_imeTextBox.Size = new System.Drawing.Size(200, 20);
            this.korisnicko_imeTextBox.TabIndex = 26;
            // 
            // sifraLabel
            // 
            sifraLabel.AutoSize = true;
            sifraLabel.Location = new System.Drawing.Point(12, 126);
            sifraLabel.Name = "sifraLabel";
            sifraLabel.Size = new System.Drawing.Size(28, 13);
            sifraLabel.TabIndex = 27;
            sifraLabel.Text = "Šifra";
            // 
            // sifraTextBox
            // 
            this.sifraTextBox.Location = new System.Drawing.Point(15, 103);
            this.sifraTextBox.Name = "sifraTextBox";
            this.sifraTextBox.Size = new System.Drawing.Size(200, 20);
            this.sifraTextBox.TabIndex = 28;
            // 
            // datum_rodjenjaLabel
            // 
            datum_rodjenjaLabel.AutoSize = true;
            datum_rodjenjaLabel.Location = new System.Drawing.Point(12, 204);
            datum_rodjenjaLabel.Name = "datum_rodjenjaLabel";
            datum_rodjenjaLabel.Size = new System.Drawing.Size(75, 13);
            datum_rodjenjaLabel.TabIndex = 29;
            datum_rodjenjaLabel.Text = "Datun rođenja";
            // 
            // datum_rodjenjaDateTimePicker
            // 
            this.datum_rodjenjaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.datum_rodjenjaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datum_rodjenjaDateTimePicker.Location = new System.Drawing.Point(15, 220);
            this.datum_rodjenjaDateTimePicker.Name = "datum_rodjenjaDateTimePicker";
            this.datum_rodjenjaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datum_rodjenjaDateTimePicker.TabIndex = 30;
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(12, 165);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(40, 13);
            adresaLabel.TabIndex = 31;
            adresaLabel.Text = "Adresa";
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.Location = new System.Drawing.Point(15, 181);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(200, 20);
            this.adresaTextBox.TabIndex = 32;
            // 
            // broj_telefonaLabel
            // 
            broj_telefonaLabel.AutoSize = true;
            broj_telefonaLabel.Location = new System.Drawing.Point(12, 243);
            broj_telefonaLabel.Name = "broj_telefonaLabel";
            broj_telefonaLabel.Size = new System.Drawing.Size(66, 13);
            broj_telefonaLabel.TabIndex = 33;
            broj_telefonaLabel.Text = "Broj telefona";
            // 
            // broj_telefonaTextBox
            // 
            this.broj_telefonaTextBox.Location = new System.Drawing.Point(15, 259);
            this.broj_telefonaTextBox.Name = "broj_telefonaTextBox";
            this.broj_telefonaTextBox.Size = new System.Drawing.Size(200, 20);
            this.broj_telefonaTextBox.TabIndex = 34;
            // 
            // FormDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 328);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(uUIDLabel);
            this.Controls.Add(this.uUIDTextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(korisnicko_imeLabel);
            this.Controls.Add(this.korisnicko_imeTextBox);
            this.Controls.Add(sifraLabel);
            this.Controls.Add(this.sifraTextBox);
            this.Controls.Add(datum_rodjenjaLabel);
            this.Controls.Add(this.datum_rodjenjaDateTimePicker);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(broj_telefonaLabel);
            this.Controls.Add(this.broj_telefonaTextBox);
            this.Name = "FormDodaj";
            this.Text = "FormDodaj";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox uUIDTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox korisnicko_imeTextBox;
        private System.Windows.Forms.TextBox sifraTextBox;
        private System.Windows.Forms.DateTimePicker datum_rodjenjaDateTimePicker;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox broj_telefonaTextBox;
    }
}