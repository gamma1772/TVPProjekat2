
namespace TVPProjekat2
{
    partial class FormNoviRacun
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
            this.txtIDRacuna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProdavac = new System.Windows.Forms.TextBox();
            this.listRacun = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.listProizvodi = new System.Windows.Forms.ListView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rbNaziv = new System.Windows.Forms.RadioButton();
            this.rbProizvodjac = new System.Windows.Forms.RadioButton();
            this.rbKategorija = new System.Windows.Forms.RadioButton();
            this.rbBarKod = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBarKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNaziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProizvodjac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKategorija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKolicina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIzbaci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIDRacuna
            // 
            this.txtIDRacuna.Enabled = false;
            this.txtIDRacuna.Location = new System.Drawing.Point(74, 6);
            this.txtIDRacuna.Name = "txtIDRacuna";
            this.txtIDRacuna.ReadOnly = true;
            this.txtIDRacuna.Size = new System.Drawing.Size(187, 20);
            this.txtIDRacuna.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Računa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prodavac";
            // 
            // txtProdavac
            // 
            this.txtProdavac.Enabled = false;
            this.txtProdavac.Location = new System.Drawing.Point(74, 32);
            this.txtProdavac.Name = "txtProdavac";
            this.txtProdavac.ReadOnly = true;
            this.txtProdavac.Size = new System.Drawing.Size(187, 20);
            this.txtProdavac.TabIndex = 2;
            // 
            // listRacun
            // 
            this.listRacun.FullRowSelect = true;
            this.listRacun.HideSelection = false;
            this.listRacun.Location = new System.Drawing.Point(74, 245);
            this.listRacun.Name = "listRacun";
            this.listRacun.Size = new System.Drawing.Size(711, 203);
            this.listRacun.TabIndex = 5;
            this.listRacun.UseCompatibleStateImageBehavior = false;
            this.listRacun.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Račun";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 454);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(106, 33);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Napravi račun";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(679, 454);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 33);
            this.button5.TabIndex = 13;
            this.button5.Text = "Odustani";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(124, 454);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 33);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Očisti";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(328, 32);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(457, 20);
            this.txtPretraga.TabIndex = 15;
            this.txtPretraga.TextChanged += new System.EventHandler(this.autoPretraga);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Količina";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(74, 216);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(193, 20);
            this.txtKolicina.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(307, 457);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 26);
            this.label10.TabIndex = 28;
            this.label10.Text = "Ukupno";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(400, 455);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(187, 32);
            this.textBox9.TabIndex = 27;
            // 
            // listProizvodi
            // 
            this.listProizvodi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colBarKod,
            this.colNaziv,
            this.colProizvodjac,
            this.colKategorija,
            this.colKolicina,
            this.colCena});
            this.listProizvodi.FullRowSelect = true;
            this.listProizvodi.HideSelection = false;
            this.listProizvodi.Location = new System.Drawing.Point(74, 58);
            this.listProizvodi.Name = "listProizvodi";
            this.listProizvodi.Size = new System.Drawing.Size(711, 146);
            this.listProizvodi.TabIndex = 29;
            this.listProizvodi.UseCompatibleStateImageBehavior = false;
            this.listProizvodi.View = System.Windows.Forms.View.Details;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(270, 210);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(283, 30);
            this.btnDodaj.TabIndex = 31;
            this.btnDodaj.Text = "Dodaj na račun";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Proizvodi";
            // 
            // rbNaziv
            // 
            this.rbNaziv.AutoSize = true;
            this.rbNaziv.Location = new System.Drawing.Point(328, 12);
            this.rbNaziv.Name = "rbNaziv";
            this.rbNaziv.Size = new System.Drawing.Size(52, 17);
            this.rbNaziv.TabIndex = 33;
            this.rbNaziv.Text = "Naziv";
            this.rbNaziv.UseVisualStyleBackColor = true;
            // 
            // rbProizvodjac
            // 
            this.rbProizvodjac.AutoSize = true;
            this.rbProizvodjac.Location = new System.Drawing.Point(386, 12);
            this.rbProizvodjac.Name = "rbProizvodjac";
            this.rbProizvodjac.Size = new System.Drawing.Size(79, 17);
            this.rbProizvodjac.TabIndex = 34;
            this.rbProizvodjac.Text = "Proizvođač";
            this.rbProizvodjac.UseVisualStyleBackColor = true;
            // 
            // rbKategorija
            // 
            this.rbKategorija.AutoSize = true;
            this.rbKategorija.Location = new System.Drawing.Point(471, 12);
            this.rbKategorija.Name = "rbKategorija";
            this.rbKategorija.Size = new System.Drawing.Size(72, 17);
            this.rbKategorija.TabIndex = 36;
            this.rbKategorija.Text = "Kategorija";
            this.rbKategorija.UseVisualStyleBackColor = true;
            // 
            // rbBarKod
            // 
            this.rbBarKod.AutoSize = true;
            this.rbBarKod.Checked = true;
            this.rbBarKod.Location = new System.Drawing.Point(723, 12);
            this.rbBarKod.Name = "rbBarKod";
            this.rbBarKod.Size = new System.Drawing.Size(62, 17);
            this.rbBarKod.TabIndex = 37;
            this.rbBarKod.TabStop = true;
            this.rbBarKod.Text = "Bar kod";
            this.rbBarKod.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Pretraga";
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 40;
            // 
            // colBarKod
            // 
            this.colBarKod.Text = "Bar Kod";
            this.colBarKod.Width = 120;
            // 
            // colNaziv
            // 
            this.colNaziv.Text = "Naziv";
            this.colNaziv.Width = 120;
            // 
            // colProizvodjac
            // 
            this.colProizvodjac.Text = "Proizvođač";
            this.colProizvodjac.Width = 120;
            // 
            // colKategorija
            // 
            this.colKategorija.Text = "Kategorija";
            this.colKategorija.Width = 120;
            // 
            // colKolicina
            // 
            this.colKolicina.Text = "Količina";
            this.colKolicina.Width = 85;
            // 
            // colCena
            // 
            this.colCena.Text = "Cena";
            this.colCena.Width = 85;
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Location = new System.Drawing.Point(559, 210);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(226, 30);
            this.btnIzbaci.TabIndex = 39;
            this.btnIzbaci.Text = "Izbaci sa računa";
            this.btnIzbaci.UseVisualStyleBackColor = true;
            // 
            // FormNoviRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 495);
            this.Controls.Add(this.btnIzbaci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbBarKod);
            this.Controls.Add(this.rbKategorija);
            this.Controls.Add(this.rbProizvodjac);
            this.Controls.Add(this.rbNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.listProizvodi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listRacun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProdavac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDRacuna);
            this.Name = "FormNoviRacun";
            this.Text = "Novi račun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDRacuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProdavac;
        private System.Windows.Forms.ListView listRacun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ListView listProizvodi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbNaziv;
        private System.Windows.Forms.RadioButton rbProizvodjac;
        private System.Windows.Forms.RadioButton rbKategorija;
        private System.Windows.Forms.RadioButton rbBarKod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colBarKod;
        private System.Windows.Forms.ColumnHeader colNaziv;
        private System.Windows.Forms.ColumnHeader colProizvodjac;
        private System.Windows.Forms.ColumnHeader colKategorija;
        private System.Windows.Forms.ColumnHeader colKolicina;
        private System.Windows.Forms.ColumnHeader colCena;
        private System.Windows.Forms.Button btnIzbaci;
    }
}