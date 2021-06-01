
namespace TVPProjekat2
{
    partial class FormPretraga
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
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rbDanas = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateOdredjeno = new System.Windows.Forms.DateTimePicker();
            this.dateDo = new System.Windows.Forms.DateTimePicker();
            this.rbDatum = new System.Windows.Forms.RadioButton();
            this.dateOd = new System.Windows.Forms.DateTimePicker();
            this.rbOpseg = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(78, 12);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(193, 20);
            this.txtKeyword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ključna reč";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(613, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pretraži";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rbDanas
            // 
            this.rbDanas.AutoSize = true;
            this.rbDanas.Checked = true;
            this.rbDanas.Location = new System.Drawing.Point(6, 19);
            this.rbDanas.Name = "rbDanas";
            this.rbDanas.Size = new System.Drawing.Size(84, 17);
            this.rbDanas.TabIndex = 7;
            this.rbDanas.TabStop = true;
            this.rbDanas.Text = "Samo danas";
            this.rbDanas.UseVisualStyleBackColor = true;
            this.rbDanas.CheckedChanged += new System.EventHandler(this.GlobalRBChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateOdredjeno);
            this.groupBox1.Controls.Add(this.dateDo);
            this.groupBox1.Controls.Add(this.rbDatum);
            this.groupBox1.Controls.Add(this.dateOd);
            this.groupBox1.Controls.Add(this.rbOpseg);
            this.groupBox1.Controls.Add(this.rbDanas);
            this.groupBox1.Location = new System.Drawing.Point(277, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datum";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(103, 19);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(72, 17);
            this.rbAll.TabIndex = 15;
            this.rbAll.Text = "Svi računi";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.GlobalRBChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Datum";
            // 
            // dateOdredjeno
            // 
            this.dateOdredjeno.CustomFormat = "dd/MM/yyyy";
            this.dateOdredjeno.Enabled = false;
            this.dateOdredjeno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOdredjeno.Location = new System.Drawing.Point(219, 97);
            this.dateOdredjeno.Name = "dateOdredjeno";
            this.dateOdredjeno.Size = new System.Drawing.Size(81, 20);
            this.dateOdredjeno.TabIndex = 12;
            // 
            // dateDo
            // 
            this.dateDo.CustomFormat = "dd/MM/yyyy";
            this.dateDo.Enabled = false;
            this.dateDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDo.Location = new System.Drawing.Point(263, 54);
            this.dateDo.Name = "dateDo";
            this.dateDo.Size = new System.Drawing.Size(76, 20);
            this.dateDo.TabIndex = 10;
            // 
            // rbDatum
            // 
            this.rbDatum.AutoSize = true;
            this.rbDatum.Location = new System.Drawing.Point(6, 100);
            this.rbDatum.Name = "rbDatum";
            this.rbDatum.Size = new System.Drawing.Size(99, 17);
            this.rbDatum.TabIndex = 9;
            this.rbDatum.Text = "Određen datum";
            this.rbDatum.UseVisualStyleBackColor = true;
            this.rbDatum.CheckedChanged += new System.EventHandler(this.GlobalRBChange);
            // 
            // dateOd
            // 
            this.dateOd.CustomFormat = "dd/MM/yyyy";
            this.dateOd.Enabled = false;
            this.dateOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOd.Location = new System.Drawing.Point(159, 54);
            this.dateOd.Name = "dateOd";
            this.dateOd.Size = new System.Drawing.Size(76, 20);
            this.dateOd.TabIndex = 11;
            // 
            // rbOpseg
            // 
            this.rbOpseg.AutoSize = true;
            this.rbOpseg.Location = new System.Drawing.Point(6, 55);
            this.rbOpseg.Name = "rbOpseg";
            this.rbOpseg.Size = new System.Drawing.Size(119, 17);
            this.rbOpseg.TabIndex = 8;
            this.rbOpseg.Text = "Svi računi u opsegu";
            this.rbOpseg.UseVisualStyleBackColor = true;
            this.rbOpseg.CheckedChanged += new System.EventHandler(this.GlobalRBChange);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kriterijum";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(60, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(193, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Korisnik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Proizvod";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // FormPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 200);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKeyword);
            this.Name = "FormPretraga";
            this.Text = "Pretraga računa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosedEvent);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbDanas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateOdredjeno;
        private System.Windows.Forms.DateTimePicker dateDo;
        private System.Windows.Forms.RadioButton rbDatum;
        private System.Windows.Forms.DateTimePicker dateOd;
        private System.Windows.Forms.RadioButton rbOpseg;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}