
namespace TVPProjekat2_KorisnikManager
{
    partial class FormProgram
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
            this.dataKorisnici = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dataKorisnici
            // 
            this.dataKorisnici.AllowUserToAddRows = false;
            this.dataKorisnici.AllowUserToDeleteRows = false;
            this.dataKorisnici.AllowUserToResizeRows = false;
            this.dataKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKorisnici.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataKorisnici.Location = new System.Drawing.Point(13, 12);
            this.dataKorisnici.MultiSelect = false;
            this.dataKorisnici.Name = "dataKorisnici";
            this.dataKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKorisnici.ShowEditingIcon = false;
            this.dataKorisnici.Size = new System.Drawing.Size(775, 397);
            this.dataKorisnici.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(13, 415);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(181, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj novog korisnika";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.dodaj);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(200, 415);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(135, 23);
            this.btnIzmeni.TabIndex = 2;
            this.btnIzmeni.Text = "Izmeni informacije";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.izmeni);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(341, 415);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(152, 23);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Aktiviraj / Deaktiviraj";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.obrisi);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(713, 415);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 4;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.close);
            // 
            // FormProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataKorisnici);
            this.Name = "FormProgram";
            this.Text = "Upravljanje korisnicima";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataKorisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataKorisnici;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzadji;
    }
}

