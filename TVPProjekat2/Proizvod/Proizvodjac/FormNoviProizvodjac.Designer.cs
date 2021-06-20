
namespace TVPProjekat2.Proizvod.Proizvodjac
{
    partial class FormNoviProizvodjac
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label drzavaLabel;
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            nazivLabel = new System.Windows.Forms.Label();
            drzavaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(12, 9);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(96, 13);
            nazivLabel.TabIndex = 10;
            nazivLabel.Text = "Naziv proizvođača";
            // 
            // drzavaLabel
            // 
            drzavaLabel.AutoSize = true;
            drzavaLabel.Location = new System.Drawing.Point(12, 35);
            drzavaLabel.Name = "drzavaLabel";
            drzavaLabel.Size = new System.Drawing.Size(41, 13);
            drzavaLabel.TabIndex = 12;
            drzavaLabel.Text = "Država";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(195, 61);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 14;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.otkazi);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(114, 6);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(156, 20);
            this.txtNaziv.TabIndex = 11;
            // 
            // txtDrzava
            // 
            this.txtDrzava.Location = new System.Drawing.Point(114, 32);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(156, 20);
            this.txtDrzava.TabIndex = 13;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(15, 61);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.dodajProizvodjaca);
            // 
            // FormNoviProizvodjac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 93);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(drzavaLabel);
            this.Controls.Add(this.txtDrzava);
            this.Controls.Add(this.btnDodaj);
            this.Name = "FormNoviProizvodjac";
            this.Text = "Novi proizvođač";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.Button btnDodaj;
    }
}