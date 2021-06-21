
namespace TVPProjekat2.Racun
{
    partial class FormPrikazRacuna
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtProdavac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listProizvodi = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBarkod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNaziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProizvodjac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKategorija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKolicina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnStampaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(88, 6);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(150, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtProdavac
            // 
            this.txtProdavac.Location = new System.Drawing.Point(88, 32);
            this.txtProdavac.Name = "txtProdavac";
            this.txtProdavac.ReadOnly = true;
            this.txtProdavac.Size = new System.Drawing.Size(150, 20);
            this.txtProdavac.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prodavac ID:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(373, 6);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(150, 20);
            this.txtDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum i vreme izdavanja:";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(373, 32);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.Size = new System.Drawing.Size(150, 20);
            this.txtCena.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ukupna cena:";
            // 
            // listProizvodi
            // 
            this.listProizvodi.CausesValidation = false;
            this.listProizvodi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colBarkod,
            this.colNaziv,
            this.colProizvodjac,
            this.colKategorija,
            this.colKolicina,
            this.colCena});
            this.listProizvodi.FullRowSelect = true;
            this.listProizvodi.GridLines = true;
            this.listProizvodi.HideSelection = false;
            this.listProizvodi.Location = new System.Drawing.Point(12, 58);
            this.listProizvodi.MultiSelect = false;
            this.listProizvodi.Name = "listProizvodi";
            this.listProizvodi.Size = new System.Drawing.Size(511, 375);
            this.listProizvodi.TabIndex = 8;
            this.listProizvodi.UseCompatibleStateImageBehavior = false;
            this.listProizvodi.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 48;
            // 
            // colBarkod
            // 
            this.colBarkod.Text = "Bar kod";
            this.colBarkod.Width = 90;
            // 
            // colNaziv
            // 
            this.colNaziv.Text = "Naziv";
            this.colNaziv.Width = 87;
            // 
            // colProizvodjac
            // 
            this.colProizvodjac.Text = "Proizvođač";
            this.colProizvodjac.Width = 74;
            // 
            // colKategorija
            // 
            this.colKategorija.Text = "Kategorija";
            this.colKategorija.Width = 87;
            // 
            // colKolicina
            // 
            this.colKolicina.Text = "Količina";
            // 
            // colCena
            // 
            this.colCena.Text = "Cena";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(448, 439);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 9;
            this.btnIzlaz.Text = "U redu";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.close);
            // 
            // btnStampaj
            // 
            this.btnStampaj.Location = new System.Drawing.Point(367, 439);
            this.btnStampaj.Name = "btnStampaj";
            this.btnStampaj.Size = new System.Drawing.Size(75, 23);
            this.btnStampaj.TabIndex = 10;
            this.btnStampaj.Text = "Štampaj";
            this.btnStampaj.UseVisualStyleBackColor = true;
            // 
            // FormPrikazRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 472);
            this.Controls.Add(this.btnStampaj);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.listProizvodi);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProdavac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "FormPrikazRacuna";
            this.Text = "FormPrikazRacuna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtProdavac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listProizvodi;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colBarkod;
        private System.Windows.Forms.ColumnHeader colNaziv;
        private System.Windows.Forms.ColumnHeader colProizvodjac;
        private System.Windows.Forms.ColumnHeader colKategorija;
        private System.Windows.Forms.ColumnHeader colKolicina;
        private System.Windows.Forms.ColumnHeader colCena;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnStampaj;
    }
}