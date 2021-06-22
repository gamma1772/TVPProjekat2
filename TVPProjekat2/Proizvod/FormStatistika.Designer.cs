
namespace TVPProjekat2
{
    partial class FormStatistika
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
            this.comboProizvodi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPrikaz = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbProcentualno = new System.Windows.Forms.RadioButton();
            this.rbStatistika = new System.Windows.Forms.RadioButton();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.txtGodisnje = new System.Windows.Forms.TextBox();
            this.txtDanas = new System.Windows.Forms.TextBox();
            this.txtMesec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.comboMesec = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboProizvodi
            // 
            this.comboProizvodi.FormattingEnabled = true;
            this.comboProizvodi.Location = new System.Drawing.Point(12, 32);
            this.comboProizvodi.Name = "comboProizvodi";
            this.comboProizvodi.Size = new System.Drawing.Size(530, 21);
            this.comboProizvodi.TabIndex = 0;
            this.comboProizvodi.SelectedIndexChanged += new System.EventHandler(this.crtajOdabrano);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proizvod";
            // 
            // groupPrikaz
            // 
            this.groupPrikaz.BackColor = System.Drawing.SystemColors.Control;
            this.groupPrikaz.Location = new System.Drawing.Point(12, 59);
            this.groupPrikaz.Name = "groupPrikaz";
            this.groupPrikaz.Size = new System.Drawing.Size(530, 243);
            this.groupPrikaz.TabIndex = 3;
            this.groupPrikaz.TabStop = false;
            this.groupPrikaz.Text = "Grafički prikaz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbProcentualno);
            this.groupBox2.Controls.Add(this.rbStatistika);
            this.groupBox2.Controls.Add(this.txtUkupno);
            this.groupBox2.Controls.Add(this.txtGodisnje);
            this.groupBox2.Controls.Add(this.txtDanas);
            this.groupBox2.Controls.Add(this.txtMesec);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(548, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 243);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tekstualni izveštaj";
            // 
            // rbProcentualno
            // 
            this.rbProcentualno.AutoSize = true;
            this.rbProcentualno.Location = new System.Drawing.Point(7, 211);
            this.rbProcentualno.Name = "rbProcentualno";
            this.rbProcentualno.Size = new System.Drawing.Size(115, 17);
            this.rbProcentualno.TabIndex = 9;
            this.rbProcentualno.Text = "Procentualni prikaz";
            this.rbProcentualno.UseVisualStyleBackColor = true;
            this.rbProcentualno.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // rbStatistika
            // 
            this.rbStatistika.AutoSize = true;
            this.rbStatistika.Checked = true;
            this.rbStatistika.Location = new System.Drawing.Point(7, 188);
            this.rbStatistika.Name = "rbStatistika";
            this.rbStatistika.Size = new System.Drawing.Size(101, 17);
            this.rbStatistika.TabIndex = 8;
            this.rbStatistika.TabStop = true;
            this.rbStatistika.Text = "Statistički prikaz";
            this.rbStatistika.UseVisualStyleBackColor = true;
            this.rbStatistika.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(6, 150);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.ReadOnly = true;
            this.txtUkupno.Size = new System.Drawing.Size(157, 20);
            this.txtUkupno.TabIndex = 7;
            // 
            // txtGodisnje
            // 
            this.txtGodisnje.Location = new System.Drawing.Point(6, 111);
            this.txtGodisnje.Name = "txtGodisnje";
            this.txtGodisnje.ReadOnly = true;
            this.txtGodisnje.Size = new System.Drawing.Size(157, 20);
            this.txtGodisnje.TabIndex = 6;
            // 
            // txtDanas
            // 
            this.txtDanas.Location = new System.Drawing.Point(6, 72);
            this.txtDanas.Name = "txtDanas";
            this.txtDanas.ReadOnly = true;
            this.txtDanas.Size = new System.Drawing.Size(157, 20);
            this.txtDanas.TabIndex = 5;
            // 
            // txtMesec
            // 
            this.txtMesec.Location = new System.Drawing.Point(6, 33);
            this.txtMesec.Name = "txtMesec";
            this.txtMesec.ReadOnly = true;
            this.txtMesec.Size = new System.Drawing.Size(157, 20);
            this.txtMesec.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Godišnja prodaja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prodato danas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ukupno prodato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prodato za mesec:";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(12, 308);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(102, 34);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Eksportuj";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(615, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "U redu";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.close);
            // 
            // comboMesec
            // 
            this.comboMesec.FormattingEnabled = true;
            this.comboMesec.Items.AddRange(new object[] {
            "Godisnji prikaz...",
            "Januar",
            "Februar",
            "Mart",
            "April",
            "Maj",
            "Jun",
            "Jul",
            "Avgust",
            "Septembar",
            "Oktobar",
            "Novembar",
            "Decembar"});
            this.comboMesec.Location = new System.Drawing.Point(548, 32);
            this.comboMesec.Name = "comboMesec";
            this.comboMesec.Size = new System.Drawing.Size(169, 21);
            this.comboMesec.TabIndex = 7;
            this.comboMesec.SelectedIndexChanged += new System.EventHandler(this.promeniMesec);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mesec";
            // 
            // FormStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 354);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboMesec);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupPrikaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboProizvodi);
            this.Name = "FormStatistika";
            this.Text = "Statistika prodaje";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboProizvodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupPrikaz;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.TextBox txtGodisnje;
        private System.Windows.Forms.TextBox txtDanas;
        private System.Windows.Forms.TextBox txtMesec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMesec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbProcentualno;
        private System.Windows.Forms.RadioButton rbStatistika;
    }
}