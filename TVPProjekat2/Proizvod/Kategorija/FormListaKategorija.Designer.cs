
namespace TVPProjekat2
{
    partial class FormListaKategorija
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
            this.dataKategorije = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataKategorije)).BeginInit();
            this.SuspendLayout();
            // 
            // dataKategorije
            // 
            this.dataKategorije.AllowUserToAddRows = false;
            this.dataKategorije.AllowUserToDeleteRows = false;
            this.dataKategorije.AllowUserToResizeRows = false;
            this.dataKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKategorije.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataKategorije.Location = new System.Drawing.Point(13, 13);
            this.dataKategorije.MultiSelect = false;
            this.dataKategorije.Name = "dataKategorije";
            this.dataKategorije.ReadOnly = true;
            this.dataKategorije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKategorije.ShowCellErrors = false;
            this.dataKategorije.ShowCellToolTips = false;
            this.dataKategorije.ShowEditingIcon = false;
            this.dataKategorije.ShowRowErrors = false;
            this.dataKategorije.Size = new System.Drawing.Size(253, 417);
            this.dataKategorije.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(272, 13);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(169, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.dodajKategoriju);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(272, 100);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(169, 23);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.obrisiKategoriju);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(272, 407);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(169, 23);
            this.btnZatvori.TabIndex = 3;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.close);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(272, 42);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(169, 23);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.izmeniKategoriju);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Aktiviraj / Deaktiviraj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormListaKategorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataKategorije);
            this.Name = "FormListaKategorija";
            this.Text = "FormListaKategorija";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormListaKategorija_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataKategorije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataKategorije;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button button1;
    }
}