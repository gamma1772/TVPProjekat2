
namespace TVPProjekat2.Proizvod.Proizvodjac
{
    partial class FormIzmeniProizvodjaca
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label drzavaLabel;
            System.Windows.Forms.Label label1;
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.projekatDataSet = new TVPProjekat2.projekatDataSet();
            this.proizvodjacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodjacTableAdapter = new TVPProjekat2.projekatDataSetTableAdapters.proizvodjacTableAdapter();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            nazivLabel = new System.Windows.Forms.Label();
            drzavaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projekatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodjacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(12, 86);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeni.TabIndex = 0;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.izmeniProizvodjaca);
            // 
            // projekatDataSet
            // 
            this.projekatDataSet.DataSetName = "projekatDataSet";
            this.projekatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proizvodjacBindingSource
            // 
            this.proizvodjacBindingSource.DataMember = "proizvodjac";
            this.proizvodjacBindingSource.DataSource = this.projekatDataSet;
            // 
            // proizvodjacTableAdapter
            // 
            this.proizvodjacTableAdapter.ClearBeforeFill = true;
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(9, 34);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(96, 13);
            nazivLabel.TabIndex = 4;
            nazivLabel.Text = "Naziv proizvođača";
            // 
            // txtNaziv
            // 
            this.txtNaziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodjacBindingSource, "naziv", true));
            this.txtNaziv.Location = new System.Drawing.Point(111, 31);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(156, 20);
            this.txtNaziv.TabIndex = 5;
            // 
            // drzavaLabel
            // 
            drzavaLabel.AutoSize = true;
            drzavaLabel.Location = new System.Drawing.Point(9, 60);
            drzavaLabel.Name = "drzavaLabel";
            drzavaLabel.Size = new System.Drawing.Size(41, 13);
            drzavaLabel.TabIndex = 6;
            drzavaLabel.Text = "Država";
            // 
            // txtDrzava
            // 
            this.txtDrzava.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodjacBindingSource, "drzava", true));
            this.txtDrzava.Location = new System.Drawing.Point(111, 57);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(156, 20);
            this.txtDrzava.TabIndex = 7;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(192, 86);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 8;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.otkazi);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(18, 13);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodjacBindingSource, "naziv", true));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(111, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(156, 20);
            this.txtID.TabIndex = 10;
            // 
            // FormIzmeniProizvodjaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 115);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(drzavaLabel);
            this.Controls.Add(this.txtDrzava);
            this.Controls.Add(this.btnIzmeni);
            this.Name = "FormIzmeniProizvodjaca";
            this.Text = "Izmeni proizvođača";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            ((System.ComponentModel.ISupportInitialize)(this.projekatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodjacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzmeni;
        private projekatDataSet projekatDataSet;
        private System.Windows.Forms.BindingSource proizvodjacBindingSource;
        private projekatDataSetTableAdapters.proizvodjacTableAdapter proizvodjacTableAdapter;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.TextBox txtID;
    }
}