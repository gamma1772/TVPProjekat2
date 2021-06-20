
namespace TVPProjekat2.Proizvod
{
    partial class FormNoviProizvod
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
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label proizvodjacLabel;
            System.Windows.Forms.Label kolicinaLabel;
            System.Windows.Forms.Label kategorijaLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label bar_kodLabel;
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtBarKod = new System.Windows.Forms.TextBox();
            this.checkAktivno = new System.Windows.Forms.CheckBox();
            this.comboProizvodjac = new System.Windows.Forms.ComboBox();
            this.ComboKategorija = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            imeLabel = new System.Windows.Forms.Label();
            proizvodjacLabel = new System.Windows.Forms.Label();
            kolicinaLabel = new System.Windows.Forms.Label();
            kategorijaLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            bar_kodLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(12, 9);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(34, 13);
            imeLabel.TabIndex = 3;
            imeLabel.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(15, 25);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(222, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // proizvodjacLabel
            // 
            proizvodjacLabel.AutoSize = true;
            proizvodjacLabel.Location = new System.Drawing.Point(12, 48);
            proizvodjacLabel.Name = "proizvodjacLabel";
            proizvodjacLabel.Size = new System.Drawing.Size(61, 13);
            proizvodjacLabel.TabIndex = 5;
            proizvodjacLabel.Text = "Proizvođač";
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Location = new System.Drawing.Point(12, 89);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(44, 13);
            kolicinaLabel.TabIndex = 7;
            kolicinaLabel.Text = "Količina";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(15, 105);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(101, 20);
            this.txtKolicina.TabIndex = 8;
            // 
            // kategorijaLabel
            // 
            kategorijaLabel.AutoSize = true;
            kategorijaLabel.Location = new System.Drawing.Point(12, 128);
            kategorijaLabel.Name = "kategorijaLabel";
            kategorijaLabel.Size = new System.Drawing.Size(54, 13);
            kategorijaLabel.TabIndex = 9;
            kategorijaLabel.Text = "Kategorija";
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(119, 89);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(32, 13);
            cenaLabel.TabIndex = 11;
            cenaLabel.Text = "Cena";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(122, 105);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(115, 20);
            this.txtCena.TabIndex = 12;
            // 
            // bar_kodLabel
            // 
            bar_kodLabel.AutoSize = true;
            bar_kodLabel.Location = new System.Drawing.Point(12, 168);
            bar_kodLabel.Name = "bar_kodLabel";
            bar_kodLabel.Size = new System.Drawing.Size(44, 13);
            bar_kodLabel.TabIndex = 13;
            bar_kodLabel.Text = "Bar kod";
            // 
            // txtBarKod
            // 
            this.txtBarKod.Location = new System.Drawing.Point(15, 184);
            this.txtBarKod.Name = "txtBarKod";
            this.txtBarKod.Size = new System.Drawing.Size(222, 20);
            this.txtBarKod.TabIndex = 14;
            // 
            // checkAktivno
            // 
            this.checkAktivno.Checked = true;
            this.checkAktivno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAktivno.Location = new System.Drawing.Point(175, 210);
            this.checkAktivno.Name = "checkAktivno";
            this.checkAktivno.Size = new System.Drawing.Size(62, 24);
            this.checkAktivno.TabIndex = 16;
            this.checkAktivno.Text = "Aktivno";
            this.checkAktivno.UseVisualStyleBackColor = true;
            // 
            // comboProizvodjac
            // 
            this.comboProizvodjac.FormattingEnabled = true;
            this.comboProizvodjac.Location = new System.Drawing.Point(15, 65);
            this.comboProizvodjac.Name = "comboProizvodjac";
            this.comboProizvodjac.Size = new System.Drawing.Size(222, 21);
            this.comboProizvodjac.TabIndex = 17;
            // 
            // ComboKategorija
            // 
            this.ComboKategorija.FormattingEnabled = true;
            this.ComboKategorija.Location = new System.Drawing.Point(15, 144);
            this.ComboKategorija.Name = "ComboKategorija";
            this.ComboKategorija.Size = new System.Drawing.Size(222, 21);
            this.ComboKategorija.TabIndex = 18;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(15, 240);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 19;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(162, 240);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 20;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // FormNoviProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 273);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.ComboKategorija);
            this.Controls.Add(this.comboProizvodjac);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(proizvodjacLabel);
            this.Controls.Add(kolicinaLabel);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(kategorijaLabel);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(bar_kodLabel);
            this.Controls.Add(this.txtBarKod);
            this.Controls.Add(this.checkAktivno);
            this.Name = "FormNoviProizvod";
            this.Text = "Novi proizvod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtBarKod;
        private System.Windows.Forms.CheckBox checkAktivno;
        private System.Windows.Forms.ComboBox comboProizvodjac;
        private System.Windows.Forms.ComboBox ComboKategorija;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOtkazi;
    }
}