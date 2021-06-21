
namespace TVPProjekat2.Proizvod
{
    partial class FormIzmeniProizvod
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
            System.Windows.Forms.Label label1;
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.ComboKategorija = new System.Windows.Forms.ComboBox();
            this.comboProizvodjac = new System.Windows.Forms.ComboBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtBarKod = new System.Windows.Forms.TextBox();
            this.checkAktivno = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnNoviProizvodjac = new System.Windows.Forms.Button();
            this.btnNovaKategorija = new System.Windows.Forms.Button();
            imeLabel = new System.Windows.Forms.Label();
            proizvodjacLabel = new System.Windows.Forms.Label();
            kolicinaLabel = new System.Windows.Forms.Label();
            kategorijaLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            bar_kodLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(12, 48);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(34, 13);
            imeLabel.TabIndex = 21;
            imeLabel.Text = "Naziv";
            // 
            // proizvodjacLabel
            // 
            proizvodjacLabel.AutoSize = true;
            proizvodjacLabel.Location = new System.Drawing.Point(12, 87);
            proizvodjacLabel.Name = "proizvodjacLabel";
            proizvodjacLabel.Size = new System.Drawing.Size(61, 13);
            proizvodjacLabel.TabIndex = 23;
            proizvodjacLabel.Text = "Proizvođač";
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Location = new System.Drawing.Point(12, 128);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(44, 13);
            kolicinaLabel.TabIndex = 24;
            kolicinaLabel.Text = "Količina";
            // 
            // kategorijaLabel
            // 
            kategorijaLabel.AutoSize = true;
            kategorijaLabel.Location = new System.Drawing.Point(12, 167);
            kategorijaLabel.Name = "kategorijaLabel";
            kategorijaLabel.Size = new System.Drawing.Size(54, 13);
            kategorijaLabel.TabIndex = 26;
            kategorijaLabel.Text = "Kategorija";
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Location = new System.Drawing.Point(119, 128);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(32, 13);
            cenaLabel.TabIndex = 27;
            cenaLabel.Text = "Cena";
            // 
            // bar_kodLabel
            // 
            bar_kodLabel.AutoSize = true;
            bar_kodLabel.Location = new System.Drawing.Point(12, 207);
            bar_kodLabel.Name = "bar_kodLabel";
            bar_kodLabel.Size = new System.Drawing.Size(44, 13);
            bar_kodLabel.TabIndex = 29;
            bar_kodLabel.Text = "Bar kod";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(18, 13);
            label1.TabIndex = 36;
            label1.Text = "ID";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(162, 279);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 35;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.close);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(15, 279);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 34;
            this.btnDodaj.Text = "Izmeni";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.izmeniProizvod);
            // 
            // ComboKategorija
            // 
            this.ComboKategorija.FormattingEnabled = true;
            this.ComboKategorija.Location = new System.Drawing.Point(15, 183);
            this.ComboKategorija.Name = "ComboKategorija";
            this.ComboKategorija.Size = new System.Drawing.Size(136, 21);
            this.ComboKategorija.TabIndex = 33;
            // 
            // comboProizvodjac
            // 
            this.comboProizvodjac.FormattingEnabled = true;
            this.comboProizvodjac.Location = new System.Drawing.Point(15, 104);
            this.comboProizvodjac.Name = "comboProizvodjac";
            this.comboProizvodjac.Size = new System.Drawing.Size(136, 21);
            this.comboProizvodjac.TabIndex = 32;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(15, 64);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(222, 20);
            this.txtNaziv.TabIndex = 22;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(15, 144);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(101, 20);
            this.txtKolicina.TabIndex = 25;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(122, 144);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(115, 20);
            this.txtCena.TabIndex = 28;
            // 
            // txtBarKod
            // 
            this.txtBarKod.Location = new System.Drawing.Point(15, 223);
            this.txtBarKod.Name = "txtBarKod";
            this.txtBarKod.Size = new System.Drawing.Size(222, 20);
            this.txtBarKod.TabIndex = 30;
            // 
            // checkAktivno
            // 
            this.checkAktivno.Checked = true;
            this.checkAktivno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAktivno.Location = new System.Drawing.Point(175, 249);
            this.checkAktivno.Name = "checkAktivno";
            this.checkAktivno.Size = new System.Drawing.Size(62, 24);
            this.checkAktivno.TabIndex = 31;
            this.checkAktivno.Text = "Aktivno";
            this.checkAktivno.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(15, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(222, 20);
            this.txtID.TabIndex = 37;
            // 
            // btnNoviProizvodjac
            // 
            this.btnNoviProizvodjac.Location = new System.Drawing.Point(157, 95);
            this.btnNoviProizvodjac.Name = "btnNoviProizvodjac";
            this.btnNoviProizvodjac.Size = new System.Drawing.Size(80, 36);
            this.btnNoviProizvodjac.TabIndex = 38;
            this.btnNoviProizvodjac.Text = "Novi proizvođač";
            this.btnNoviProizvodjac.UseVisualStyleBackColor = true;
            this.btnNoviProizvodjac.Click += new System.EventHandler(this.noviProizvodjac);
            // 
            // btnNovaKategorija
            // 
            this.btnNovaKategorija.Location = new System.Drawing.Point(157, 174);
            this.btnNovaKategorija.Name = "btnNovaKategorija";
            this.btnNovaKategorija.Size = new System.Drawing.Size(80, 36);
            this.btnNovaKategorija.TabIndex = 39;
            this.btnNovaKategorija.Text = "Nova kategorija...";
            this.btnNovaKategorija.UseVisualStyleBackColor = true;
            this.btnNovaKategorija.Click += new System.EventHandler(this.novaKategorija);
            // 
            // FormIzmeniProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 315);
            this.Controls.Add(this.btnNovaKategorija);
            this.Controls.Add(this.btnNoviProizvodjac);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtID);
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
            this.Name = "FormIzmeniProizvod";
            this.Text = "Izmeni proizvod";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox ComboKategorija;
        private System.Windows.Forms.ComboBox comboProizvodjac;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtBarKod;
        private System.Windows.Forms.CheckBox checkAktivno;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnNoviProizvodjac;
        private System.Windows.Forms.Button btnNovaKategorija;
    }
}