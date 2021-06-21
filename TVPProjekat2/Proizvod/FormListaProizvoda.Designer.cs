
namespace TVPProjekat2
{
    partial class FormListaProizvoda
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
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dataProizvodi = new System.Windows.Forms.DataGridView();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnAktiv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(863, 411);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(169, 23);
            this.btnZatvori.TabIndex = 7;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.close);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(863, 133);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(169, 23);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.obrisiProizvod);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(863, 17);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(169, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.dodajProizvod);
            // 
            // dataProizvodi
            // 
            this.dataProizvodi.AllowUserToAddRows = false;
            this.dataProizvodi.AllowUserToDeleteRows = false;
            this.dataProizvodi.AllowUserToResizeRows = false;
            this.dataProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProizvodi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataProizvodi.Location = new System.Drawing.Point(11, 17);
            this.dataProizvodi.MultiSelect = false;
            this.dataProizvodi.Name = "dataProizvodi";
            this.dataProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProizvodi.Size = new System.Drawing.Size(846, 417);
            this.dataProizvodi.TabIndex = 4;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(863, 46);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(169, 23);
            this.btnIzmeni.TabIndex = 8;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.izmeniProizvod);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Location = new System.Drawing.Point(863, 75);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(169, 23);
            this.btnStatistika.TabIndex = 9;
            this.btnStatistika.Text = "Prikaži statistiku prodaje";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.prikaziStatistiku);
            // 
            // btnAktiv
            // 
            this.btnAktiv.Location = new System.Drawing.Point(863, 104);
            this.btnAktiv.Name = "btnAktiv";
            this.btnAktiv.Size = new System.Drawing.Size(169, 23);
            this.btnAktiv.TabIndex = 10;
            this.btnAktiv.Text = "Aktiviraj / Deaktiviraj";
            this.btnAktiv.UseVisualStyleBackColor = true;
            this.btnAktiv.Click += new System.EventHandler(this.promeniAktivniStatus);
            // 
            // FormListaProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 444);
            this.Controls.Add(this.btnAktiv);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataProizvodi);
            this.Name = "FormListaProizvoda";
            this.Text = "FormListaProizvoda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataProizvodi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dataProizvodi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Button btnAktiv;
    }
}