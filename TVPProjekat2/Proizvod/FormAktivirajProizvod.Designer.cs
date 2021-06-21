
namespace TVPProjekat2.Proizvod
{
    partial class FormAktivirajProizvod
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
            this.dataDeaktivni = new System.Windows.Forms.DataGridView();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnAktiviraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDeaktivni)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDeaktivni
            // 
            this.dataDeaktivni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDeaktivni.Location = new System.Drawing.Point(12, 13);
            this.dataDeaktivni.Name = "dataDeaktivni";
            this.dataDeaktivni.Size = new System.Drawing.Size(776, 395);
            this.dataDeaktivni.TabIndex = 0;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(713, 415);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 1;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.close);
            // 
            // btnAktiviraj
            // 
            this.btnAktiviraj.Location = new System.Drawing.Point(632, 415);
            this.btnAktiviraj.Name = "btnAktiviraj";
            this.btnAktiviraj.Size = new System.Drawing.Size(75, 23);
            this.btnAktiviraj.TabIndex = 2;
            this.btnAktiviraj.Text = "Aktiviraj";
            this.btnAktiviraj.UseVisualStyleBackColor = true;
            this.btnAktiviraj.Click += new System.EventHandler(this.aktivirajProizvod);
            // 
            // FormAktivirajProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAktiviraj);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.dataDeaktivni);
            this.Name = "FormAktivirajProizvod";
            this.Text = "Aktiviraj proizvod";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataDeaktivni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDeaktivni;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnAktiviraj;
    }
}