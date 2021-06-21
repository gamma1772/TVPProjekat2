
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(78, 12);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(546, 20);
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
            this.button1.Location = new System.Drawing.Point(15, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pretraži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.pokreniPretragu);
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
            this.groupBox1.Location = new System.Drawing.Point(15, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datum";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(6, 46);
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
            this.label6.Location = new System.Drawing.Point(306, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 46);
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
            this.dateOdredjeno.Location = new System.Drawing.Point(522, 42);
            this.dateOdredjeno.Name = "dateOdredjeno";
            this.dateOdredjeno.Size = new System.Drawing.Size(81, 20);
            this.dateOdredjeno.TabIndex = 12;
            // 
            // dateDo
            // 
            this.dateDo.CustomFormat = "dd/MM/yyyy";
            this.dateDo.Enabled = false;
            this.dateDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDo.Location = new System.Drawing.Point(328, 42);
            this.dateDo.Name = "dateDo";
            this.dateDo.Size = new System.Drawing.Size(76, 20);
            this.dateDo.TabIndex = 10;
            // 
            // rbDatum
            // 
            this.rbDatum.AutoSize = true;
            this.rbDatum.Location = new System.Drawing.Point(504, 19);
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
            this.dateOd.Location = new System.Drawing.Point(224, 42);
            this.dateOd.Name = "dateOd";
            this.dateOd.Size = new System.Drawing.Size(76, 20);
            this.dateOd.TabIndex = 11;
            // 
            // rbOpseg
            // 
            this.rbOpseg.AutoSize = true;
            this.rbOpseg.Location = new System.Drawing.Point(244, 19);
            this.rbOpseg.Name = "rbOpseg";
            this.rbOpseg.Size = new System.Drawing.Size(119, 17);
            this.rbOpseg.TabIndex = 8;
            this.rbOpseg.Text = "Svi računi u opsegu";
            this.rbOpseg.UseVisualStyleBackColor = true;
            this.rbOpseg.CheckedChanged += new System.EventHandler(this.GlobalRBChange);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Odustani";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.close);
            // 
            // FormPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 156);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKeyword);
            this.Name = "FormPretraga";
            this.Text = "Pretraga računa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosedEvent);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button button2;
    }
}