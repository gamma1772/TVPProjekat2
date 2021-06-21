
namespace TVPProjekat2
{
    partial class FormRacuni
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
            this.btnObrisiRacun = new System.Windows.Forms.Button();
            this.dataRacuni = new System.Windows.Forms.DataGridView();
            this.btnPrikaziRacun = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.btnStorniraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(547, 426);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(169, 23);
            this.btnZatvori.TabIndex = 7;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.close);
            // 
            // btnObrisiRacun
            // 
            this.btnObrisiRacun.Location = new System.Drawing.Point(547, 121);
            this.btnObrisiRacun.Name = "btnObrisiRacun";
            this.btnObrisiRacun.Size = new System.Drawing.Size(169, 23);
            this.btnObrisiRacun.TabIndex = 6;
            this.btnObrisiRacun.Text = "Obriši";
            this.btnObrisiRacun.UseVisualStyleBackColor = true;
            this.btnObrisiRacun.Click += new System.EventHandler(this.obrisi);
            // 
            // dataRacuni
            // 
            this.dataRacuni.AllowUserToAddRows = false;
            this.dataRacuni.AllowUserToDeleteRows = false;
            this.dataRacuni.AllowUserToResizeRows = false;
            this.dataRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRacuni.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataRacuni.Location = new System.Drawing.Point(12, 61);
            this.dataRacuni.Name = "dataRacuni";
            this.dataRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRacuni.Size = new System.Drawing.Size(529, 388);
            this.dataRacuni.TabIndex = 4;
            // 
            // btnPrikaziRacun
            // 
            this.btnPrikaziRacun.Location = new System.Drawing.Point(547, 92);
            this.btnPrikaziRacun.Name = "btnPrikaziRacun";
            this.btnPrikaziRacun.Size = new System.Drawing.Size(169, 23);
            this.btnPrikaziRacun.TabIndex = 9;
            this.btnPrikaziRacun.Text = "Prikaži račun";
            this.btnPrikaziRacun.UseVisualStyleBackColor = true;
            this.btnPrikaziRacun.Click += new System.EventHandler(this.prikazi);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 34);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(529, 20);
            this.txtPretraga.TabIndex = 10;
            this.txtPretraga.TextChanged += new System.EventHandler(this.brzaPretraga);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Brza pretraga (Broj računa)";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(547, 34);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(169, 23);
            this.btnPretraga.TabIndex = 12;
            this.btnPretraga.Text = "Napredna pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.advSearch);
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.Location = new System.Drawing.Point(547, 63);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(169, 23);
            this.btnStorniraj.TabIndex = 13;
            this.btnStorniraj.Text = "Storniraj";
            this.btnStorniraj.UseVisualStyleBackColor = true;
            this.btnStorniraj.Click += new System.EventHandler(this.storniraj);
            // 
            // FormRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 460);
            this.Controls.Add(this.btnStorniraj);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikaziRacun);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnObrisiRacun);
            this.Controls.Add(this.dataRacuni);
            this.Name = "FormRacuni";
            this.Text = "Računi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataRacuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnObrisiRacun;
        private System.Windows.Forms.DataGridView dataRacuni;
        private System.Windows.Forms.Button btnPrikaziRacun;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnStorniraj;
    }
}