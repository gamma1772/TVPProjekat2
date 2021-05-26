
namespace TVPProjekat2
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiStatistikuProdajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaYaPovratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izađiIzProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviRačunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pogledajRačuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pogledajListuProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniListuKategorijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uputstvoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProjektuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projekatDataSet = new TVPProjekat2.projekatDataSet();
            this.projekatDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.racunTableAdapter = new TVPProjekat2.projekatDataSetTableAdapters.RacunTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumizdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNoviRacun = new System.Windows.Forms.Button();
            this.btnStornirajRacun = new System.Windows.Forms.Button();
            this.btnObrisiRacun = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupRacuni = new System.Windows.Forms.GroupBox();
            this.groupStonrirani = new System.Windows.Forms.GroupBox();
            this.groupFiltrirano = new System.Windows.Forms.GroupBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnStampaj = new System.Windows.Forms.Button();
            this.štampajRačunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekatDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupRacuni.SuspendLayout();
            this.groupStonrirani.SuspendLayout();
            this.groupFiltrirano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1034, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(110, 17);
            this.toolStripStatusLabel1.Text = "statusLabelRacunID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.računToolStripMenuItem,
            this.proizvodToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiStatistikuProdajeToolStripMenuItem,
            this.formaYaPovratToolStripMenuItem,
            this.odjaviSeToolStripMenuItem,
            this.izađiIzProgramaToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // prikažiStatistikuProdajeToolStripMenuItem
            // 
            this.prikažiStatistikuProdajeToolStripMenuItem.Name = "prikažiStatistikuProdajeToolStripMenuItem";
            this.prikažiStatistikuProdajeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.prikažiStatistikuProdajeToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.prikažiStatistikuProdajeToolStripMenuItem.Text = "Prikaži statistiku prodaje";
            this.prikažiStatistikuProdajeToolStripMenuItem.Click += new System.EventHandler(this.statistikaProdaje);
            // 
            // formaYaPovratToolStripMenuItem
            // 
            this.formaYaPovratToolStripMenuItem.Name = "formaYaPovratToolStripMenuItem";
            this.formaYaPovratToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.formaYaPovratToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.formaYaPovratToolStripMenuItem.Text = "Forma za povrat";
            this.formaYaPovratToolStripMenuItem.Click += new System.EventHandler(this.povrat);
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjava);
            // 
            // izađiIzProgramaToolStripMenuItem
            // 
            this.izađiIzProgramaToolStripMenuItem.Name = "izađiIzProgramaToolStripMenuItem";
            this.izađiIzProgramaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.izađiIzProgramaToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.izađiIzProgramaToolStripMenuItem.Text = "Izađi iz programa";
            this.izađiIzProgramaToolStripMenuItem.Click += new System.EventHandler(this.izlazIzPrograma);
            // 
            // računToolStripMenuItem
            // 
            this.računToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNoviRačunToolStripMenuItem,
            this.pogledajRačuneToolStripMenuItem,
            this.štampajRačunToolStripMenuItem});
            this.računToolStripMenuItem.Name = "računToolStripMenuItem";
            this.računToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.računToolStripMenuItem.Text = "Račun";
            // 
            // dodajNoviRačunToolStripMenuItem
            // 
            this.dodajNoviRačunToolStripMenuItem.Name = "dodajNoviRačunToolStripMenuItem";
            this.dodajNoviRačunToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.dodajNoviRačunToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.dodajNoviRačunToolStripMenuItem.Text = "Novi račun";
            this.dodajNoviRačunToolStripMenuItem.Click += new System.EventHandler(this.noviRacun);
            // 
            // pogledajRačuneToolStripMenuItem
            // 
            this.pogledajRačuneToolStripMenuItem.Name = "pogledajRačuneToolStripMenuItem";
            this.pogledajRačuneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.pogledajRačuneToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.pogledajRačuneToolStripMenuItem.Text = "Pogledaj račune";
            this.pogledajRačuneToolStripMenuItem.Click += new System.EventHandler(this.pogledajSveRacune);
            // 
            // proizvodToolStripMenuItem
            // 
            this.proizvodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pogledajListuProizvodaToolStripMenuItem,
            this.izmeniListuKategorijaToolStripMenuItem});
            this.proizvodToolStripMenuItem.Name = "proizvodToolStripMenuItem";
            this.proizvodToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.proizvodToolStripMenuItem.Text = "Proizvod";
            // 
            // pogledajListuProizvodaToolStripMenuItem
            // 
            this.pogledajListuProizvodaToolStripMenuItem.Name = "pogledajListuProizvodaToolStripMenuItem";
            this.pogledajListuProizvodaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pogledajListuProizvodaToolStripMenuItem.Text = "Lista proizvoda";
            this.pogledajListuProizvodaToolStripMenuItem.Click += new System.EventHandler(this.prikaziListuProizvoda);
            // 
            // izmeniListuKategorijaToolStripMenuItem
            // 
            this.izmeniListuKategorijaToolStripMenuItem.Name = "izmeniListuKategorijaToolStripMenuItem";
            this.izmeniListuKategorijaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izmeniListuKategorijaToolStripMenuItem.Text = "Lista kategorija";
            this.izmeniListuKategorijaToolStripMenuItem.Click += new System.EventHandler(this.prikaziListuKategorija);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uputstvoToolStripMenuItem,
            this.oProjektuToolStripMenuItem});
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // uputstvoToolStripMenuItem
            // 
            this.uputstvoToolStripMenuItem.Name = "uputstvoToolStripMenuItem";
            this.uputstvoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.uputstvoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uputstvoToolStripMenuItem.Text = "Uputstvo";
            this.uputstvoToolStripMenuItem.Click += new System.EventHandler(this.PrikaziUputstvo);
            // 
            // oProjektuToolStripMenuItem
            // 
            this.oProjektuToolStripMenuItem.Name = "oProjektuToolStripMenuItem";
            this.oProjektuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.oProjektuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oProjektuToolStripMenuItem.Text = "O Projektu";
            this.oProjektuToolStripMenuItem.Click += new System.EventHandler(this.prikaziInformacijeOProjektu);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.datumizdavanjaDataGridViewTextBoxColumn,
            this.proizvodiDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.racunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(433, 473);
            this.dataGridView1.TabIndex = 2;
            // 
            // projekatDataSet
            // 
            this.projekatDataSet.DataSetName = "projekatDataSet";
            this.projekatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projekatDataSetBindingSource
            // 
            this.projekatDataSetBindingSource.DataSource = this.projekatDataSet;
            this.projekatDataSetBindingSource.Position = 0;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "Racun";
            this.racunBindingSource.DataSource = this.projekatDataSetBindingSource;
            // 
            // racunTableAdapter
            // 
            this.racunTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumizdavanjaDataGridViewTextBoxColumn
            // 
            this.datumizdavanjaDataGridViewTextBoxColumn.DataPropertyName = "datum_izdavanja";
            this.datumizdavanjaDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumizdavanjaDataGridViewTextBoxColumn.Name = "datumizdavanjaDataGridViewTextBoxColumn";
            this.datumizdavanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proizvodiDataGridViewTextBoxColumn
            // 
            this.proizvodiDataGridViewTextBoxColumn.DataPropertyName = "proizvodi";
            this.proizvodiDataGridViewTextBoxColumn.HeaderText = "Proizvodi";
            this.proizvodiDataGridViewTextBoxColumn.Name = "proizvodiDataGridViewTextBoxColumn";
            this.proizvodiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnNoviRacun
            // 
            this.btnNoviRacun.Location = new System.Drawing.Point(866, 28);
            this.btnNoviRacun.Name = "btnNoviRacun";
            this.btnNoviRacun.Size = new System.Drawing.Size(156, 41);
            this.btnNoviRacun.TabIndex = 3;
            this.btnNoviRacun.Text = "Novi račun";
            this.btnNoviRacun.UseVisualStyleBackColor = true;
            this.btnNoviRacun.Click += new System.EventHandler(this.noviRacun);
            // 
            // btnStornirajRacun
            // 
            this.btnStornirajRacun.Location = new System.Drawing.Point(866, 282);
            this.btnStornirajRacun.Name = "btnStornirajRacun";
            this.btnStornirajRacun.Size = new System.Drawing.Size(156, 41);
            this.btnStornirajRacun.TabIndex = 4;
            this.btnStornirajRacun.Text = "Storniraj Selektovano";
            this.btnStornirajRacun.UseVisualStyleBackColor = true;
            this.btnStornirajRacun.Click += new System.EventHandler(this.stornirajSelektovano);
            // 
            // btnObrisiRacun
            // 
            this.btnObrisiRacun.Location = new System.Drawing.Point(866, 329);
            this.btnObrisiRacun.Name = "btnObrisiRacun";
            this.btnObrisiRacun.Size = new System.Drawing.Size(156, 41);
            this.btnObrisiRacun.TabIndex = 5;
            this.btnObrisiRacun.Text = "Obriši selektovano";
            this.btnObrisiRacun.UseVisualStyleBackColor = true;
            this.btnObrisiRacun.Click += new System.EventHandler(this.obrisiSelektovano);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(865, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Izmeni račun";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.izmeniRacun);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(384, 223);
            this.dataGridView2.TabIndex = 7;
            // 
            // groupRacuni
            // 
            this.groupRacuni.Controls.Add(this.dataGridView1);
            this.groupRacuni.Location = new System.Drawing.Point(12, 28);
            this.groupRacuni.Name = "groupRacuni";
            this.groupRacuni.Size = new System.Drawing.Size(445, 498);
            this.groupRacuni.TabIndex = 8;
            this.groupRacuni.TabStop = false;
            this.groupRacuni.Text = "Lista današnjih računa";
            // 
            // groupStonrirani
            // 
            this.groupStonrirani.Controls.Add(this.dataGridView2);
            this.groupStonrirani.Location = new System.Drawing.Point(463, 28);
            this.groupStonrirani.Name = "groupStonrirani";
            this.groupStonrirani.Size = new System.Drawing.Size(396, 248);
            this.groupStonrirani.TabIndex = 9;
            this.groupStonrirani.TabStop = false;
            this.groupStonrirani.Text = "Stornirani računi";
            // 
            // groupFiltrirano
            // 
            this.groupFiltrirano.Controls.Add(this.dataGridView3);
            this.groupFiltrirano.Location = new System.Drawing.Point(463, 282);
            this.groupFiltrirano.Name = "groupFiltrirano";
            this.groupFiltrirano.Size = new System.Drawing.Size(396, 244);
            this.groupFiltrirano.TabIndex = 10;
            this.groupFiltrirano.TabStop = false;
            this.groupFiltrirano.Text = "Filtrirano";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(866, 475);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(156, 45);
            this.btnPretraga.TabIndex = 11;
            this.btnPretraga.Text = "Pretraži današnje račune";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.pretraga);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(7, 20);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(383, 218);
            this.dataGridView3.TabIndex = 0;
            // 
            // btnStampaj
            // 
            this.btnStampaj.Location = new System.Drawing.Point(865, 122);
            this.btnStampaj.Name = "btnStampaj";
            this.btnStampaj.Size = new System.Drawing.Size(156, 41);
            this.btnStampaj.TabIndex = 12;
            this.btnStampaj.Text = "Štampaj račun";
            this.btnStampaj.UseVisualStyleBackColor = true;
            this.btnStampaj.Click += new System.EventHandler(this.stampajRacun);
            // 
            // štampajRačunToolStripMenuItem
            // 
            this.štampajRačunToolStripMenuItem.Name = "štampajRačunToolStripMenuItem";
            this.štampajRačunToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.štampajRačunToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.štampajRačunToolStripMenuItem.Text = "Štampaj račun";
            this.štampajRačunToolStripMenuItem.Click += new System.EventHandler(this.stampajRacun);
            // 
            // FormProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 551);
            this.Controls.Add(this.btnStampaj);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.groupFiltrirano);
            this.Controls.Add(this.groupStonrirani);
            this.Controls.Add(this.groupRacuni);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnObrisiRacun);
            this.Controls.Add(this.btnStornirajRacun);
            this.Controls.Add(this.btnNoviRacun);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1050, 590);
            this.MinimumSize = new System.Drawing.Size(1050, 590);
            this.Name = "FormProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drugi projekat (markonrt8519)";
            this.Load += new System.EventHandler(this.FormProgram_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekatDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupRacuni.ResumeLayout(false);
            this.groupStonrirani.ResumeLayout(false);
            this.groupFiltrirano.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izađiIzProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaYaPovratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviRačunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pogledajRačuneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pogledajListuProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uputstvoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProjektuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiStatistikuProdajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem izmeniListuKategorijaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource projekatDataSetBindingSource;
        private projekatDataSet projekatDataSet;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private projekatDataSetTableAdapters.RacunTableAdapter racunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumizdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNoviRacun;
        private System.Windows.Forms.Button btnStornirajRacun;
        private System.Windows.Forms.Button btnObrisiRacun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupRacuni;
        private System.Windows.Forms.GroupBox groupStonrirani;
        private System.Windows.Forms.GroupBox groupFiltrirano;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnStampaj;
        private System.Windows.Forms.ToolStripMenuItem štampajRačunToolStripMenuItem;
    }
}

