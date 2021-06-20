
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
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izađiIzProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.računToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviRačunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pogledajRačuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.štampajRačunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pogledajListuProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmeniListuKategorijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataRacuni = new System.Windows.Forms.DataGridView();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekatDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekatDataSet = new TVPProjekat2.projekatDataSet();
            this.btnNoviRacun = new System.Windows.Forms.Button();
            this.btnStornirajRacun = new System.Windows.Forms.Button();
            this.btnObrisiRacun = new System.Windows.Forms.Button();
            this.btnKloniraj = new System.Windows.Forms.Button();
            this.dataStornirani = new System.Windows.Forms.DataGridView();
            this.groupRacuni = new System.Windows.Forms.GroupBox();
            this.btnStampaj = new System.Windows.Forms.Button();
            this.groupStonrirani = new System.Windows.Forms.GroupBox();
            this.groupFiltrirano = new System.Windows.Forms.GroupBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dataFilter = new System.Windows.Forms.DataGridView();
            this.listaProizvođačaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRacuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekatDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStornirani)).BeginInit();
            this.groupRacuni.SuspendLayout();
            this.groupStonrirani.SuspendLayout();
            this.groupFiltrirano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(919, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(113, 17);
            this.toolStripStatusLabel1.Text = "statusLabelRadnikID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.računToolStripMenuItem,
            this.proizvodToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiStatistikuProdajeToolStripMenuItem,
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
            // štampajRačunToolStripMenuItem
            // 
            this.štampajRačunToolStripMenuItem.Name = "štampajRačunToolStripMenuItem";
            this.štampajRačunToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.štampajRačunToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.štampajRačunToolStripMenuItem.Text = "Štampaj račun";
            this.štampajRačunToolStripMenuItem.Click += new System.EventHandler(this.stampajRacun);
            // 
            // proizvodToolStripMenuItem
            // 
            this.proizvodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pogledajListuProizvodaToolStripMenuItem,
            this.izmeniListuKategorijaToolStripMenuItem,
            this.listaProizvođačaToolStripMenuItem});
            this.proizvodToolStripMenuItem.Name = "proizvodToolStripMenuItem";
            this.proizvodToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.proizvodToolStripMenuItem.Text = "Proizvod";
            // 
            // pogledajListuProizvodaToolStripMenuItem
            // 
            this.pogledajListuProizvodaToolStripMenuItem.Name = "pogledajListuProizvodaToolStripMenuItem";
            this.pogledajListuProizvodaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.pogledajListuProizvodaToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.pogledajListuProizvodaToolStripMenuItem.Text = "Lista proizvoda";
            this.pogledajListuProizvodaToolStripMenuItem.Click += new System.EventHandler(this.prikaziListuProizvoda);
            // 
            // izmeniListuKategorijaToolStripMenuItem
            // 
            this.izmeniListuKategorijaToolStripMenuItem.Name = "izmeniListuKategorijaToolStripMenuItem";
            this.izmeniListuKategorijaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.K)));
            this.izmeniListuKategorijaToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.izmeniListuKategorijaToolStripMenuItem.Text = "Lista kategorija";
            this.izmeniListuKategorijaToolStripMenuItem.Click += new System.EventHandler(this.prikaziListuKategorija);
            // 
            // dataRacuni
            // 
            this.dataRacuni.AllowUserToAddRows = false;
            this.dataRacuni.AllowUserToDeleteRows = false;
            this.dataRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRacuni.Location = new System.Drawing.Point(6, 50);
            this.dataRacuni.Name = "dataRacuni";
            this.dataRacuni.ReadOnly = true;
            this.dataRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRacuni.Size = new System.Drawing.Size(433, 411);
            this.dataRacuni.TabIndex = 2;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataMember = "Racun";
            this.racunBindingSource.DataSource = this.projekatDataSetBindingSource;
            // 
            // projekatDataSetBindingSource
            // 
            this.projekatDataSetBindingSource.DataSource = this.projekatDataSet;
            this.projekatDataSetBindingSource.Position = 0;
            // 
            // projekatDataSet
            // 
            this.projekatDataSet.DataSetName = "projekatDataSet";
            this.projekatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNoviRacun
            // 
            this.btnNoviRacun.Location = new System.Drawing.Point(6, 19);
            this.btnNoviRacun.Name = "btnNoviRacun";
            this.btnNoviRacun.Size = new System.Drawing.Size(433, 25);
            this.btnNoviRacun.TabIndex = 3;
            this.btnNoviRacun.Text = "Novi račun";
            this.btnNoviRacun.UseVisualStyleBackColor = true;
            this.btnNoviRacun.Click += new System.EventHandler(this.noviRacun);
            // 
            // btnStornirajRacun
            // 
            this.btnStornirajRacun.Location = new System.Drawing.Point(6, 467);
            this.btnStornirajRacun.Name = "btnStornirajRacun";
            this.btnStornirajRacun.Size = new System.Drawing.Size(168, 25);
            this.btnStornirajRacun.TabIndex = 4;
            this.btnStornirajRacun.Text = "Storniraj Selektovano";
            this.btnStornirajRacun.UseVisualStyleBackColor = true;
            this.btnStornirajRacun.Click += new System.EventHandler(this.stornirajSelektovano);
            // 
            // btnObrisiRacun
            // 
            this.btnObrisiRacun.Location = new System.Drawing.Point(238, 219);
            this.btnObrisiRacun.Name = "btnObrisiRacun";
            this.btnObrisiRacun.Size = new System.Drawing.Size(204, 23);
            this.btnObrisiRacun.TabIndex = 5;
            this.btnObrisiRacun.Text = "Obriši selektovano";
            this.btnObrisiRacun.UseVisualStyleBackColor = true;
            this.btnObrisiRacun.Click += new System.EventHandler(this.obrisiSelektovano);
            // 
            // btnKloniraj
            // 
            this.btnKloniraj.Location = new System.Drawing.Point(6, 219);
            this.btnKloniraj.Name = "btnKloniraj";
            this.btnKloniraj.Size = new System.Drawing.Size(222, 23);
            this.btnKloniraj.TabIndex = 6;
            this.btnKloniraj.Text = "Kloniraj račun";
            this.btnKloniraj.UseVisualStyleBackColor = true;
            this.btnKloniraj.Click += new System.EventHandler(this.izmeniRacun);
            // 
            // dataStornirani
            // 
            this.dataStornirani.AllowUserToAddRows = false;
            this.dataStornirani.AllowUserToDeleteRows = false;
            this.dataStornirani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStornirani.Location = new System.Drawing.Point(6, 19);
            this.dataStornirani.MultiSelect = false;
            this.dataStornirani.Name = "dataStornirani";
            this.dataStornirani.ReadOnly = true;
            this.dataStornirani.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataStornirani.Size = new System.Drawing.Size(435, 194);
            this.dataStornirani.TabIndex = 7;
            // 
            // groupRacuni
            // 
            this.groupRacuni.Controls.Add(this.btnStampaj);
            this.groupRacuni.Controls.Add(this.dataRacuni);
            this.groupRacuni.Controls.Add(this.btnNoviRacun);
            this.groupRacuni.Controls.Add(this.btnStornirajRacun);
            this.groupRacuni.Location = new System.Drawing.Point(12, 28);
            this.groupRacuni.Name = "groupRacuni";
            this.groupRacuni.Size = new System.Drawing.Size(445, 498);
            this.groupRacuni.TabIndex = 8;
            this.groupRacuni.TabStop = false;
            this.groupRacuni.Text = "Lista današnjih računa";
            // 
            // btnStampaj
            // 
            this.btnStampaj.Location = new System.Drawing.Point(250, 467);
            this.btnStampaj.Name = "btnStampaj";
            this.btnStampaj.Size = new System.Drawing.Size(189, 25);
            this.btnStampaj.TabIndex = 12;
            this.btnStampaj.Text = "Štampaj račun";
            this.btnStampaj.UseVisualStyleBackColor = true;
            this.btnStampaj.Click += new System.EventHandler(this.stampajRacun);
            // 
            // groupStonrirani
            // 
            this.groupStonrirani.Controls.Add(this.dataStornirani);
            this.groupStonrirani.Controls.Add(this.btnKloniraj);
            this.groupStonrirani.Controls.Add(this.btnObrisiRacun);
            this.groupStonrirani.Location = new System.Drawing.Point(463, 28);
            this.groupStonrirani.Name = "groupStonrirani";
            this.groupStonrirani.Size = new System.Drawing.Size(448, 248);
            this.groupStonrirani.TabIndex = 9;
            this.groupStonrirani.TabStop = false;
            this.groupStonrirani.Text = "Stornirani računi";
            // 
            // groupFiltrirano
            // 
            this.groupFiltrirano.Controls.Add(this.btnPretraga);
            this.groupFiltrirano.Controls.Add(this.dataFilter);
            this.groupFiltrirano.Location = new System.Drawing.Point(463, 282);
            this.groupFiltrirano.Name = "groupFiltrirano";
            this.groupFiltrirano.Size = new System.Drawing.Size(448, 244);
            this.groupFiltrirano.TabIndex = 10;
            this.groupFiltrirano.TabStop = false;
            this.groupFiltrirano.Text = "Filtrirano";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(7, 213);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(435, 25);
            this.btnPretraga.TabIndex = 11;
            this.btnPretraga.Text = "Pretraži današnje račune";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.pretraga);
            // 
            // dataFilter
            // 
            this.dataFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFilter.Location = new System.Drawing.Point(7, 18);
            this.dataFilter.Name = "dataFilter";
            this.dataFilter.Size = new System.Drawing.Size(434, 189);
            this.dataFilter.TabIndex = 0;
            // 
            // listaProizvođačaToolStripMenuItem
            // 
            this.listaProizvođačaToolStripMenuItem.Name = "listaProizvođačaToolStripMenuItem";
            this.listaProizvođačaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.listaProizvođačaToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.listaProizvođačaToolStripMenuItem.Text = "Lista proizvođača";
            this.listaProizvođačaToolStripMenuItem.Click += new System.EventHandler(this.prikaziListuProizvodjaca);
            // 
            // FormProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 551);
            this.Controls.Add(this.groupFiltrirano);
            this.Controls.Add(this.groupStonrirani);
            this.Controls.Add(this.groupRacuni);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(935, 590);
            this.MinimumSize = new System.Drawing.Size(935, 590);
            this.Name = "FormProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drugi projekat (markonrt8519)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.izlazIzProgramaForm);
            this.Load += new System.EventHandler(this.formLoadEvent);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRacuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekatDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStornirani)).EndInit();
            this.groupRacuni.ResumeLayout(false);
            this.groupStonrirani.ResumeLayout(false);
            this.groupFiltrirano.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izađiIzProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem računToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviRačunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pogledajRačuneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pogledajListuProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiStatistikuProdajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem izmeniListuKategorijaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataRacuni;
        private System.Windows.Forms.BindingSource projekatDataSetBindingSource;
        private projekatDataSet projekatDataSet;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private projekatDataSetTableAdapters.racunTableAdapter racunTableAdapter;
        private System.Windows.Forms.Button btnNoviRacun;
        private System.Windows.Forms.Button btnStornirajRacun;
        private System.Windows.Forms.Button btnObrisiRacun;
        private System.Windows.Forms.Button btnKloniraj;
        private System.Windows.Forms.DataGridView dataStornirani;
        private System.Windows.Forms.GroupBox groupRacuni;
        private System.Windows.Forms.GroupBox groupStonrirani;
        private System.Windows.Forms.GroupBox groupFiltrirano;
        private System.Windows.Forms.DataGridView dataFilter;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnStampaj;
        private System.Windows.Forms.ToolStripMenuItem štampajRačunToolStripMenuItem;
        private projekatDataSetTableAdapters.racun_proizvodTableAdapter racun_ProizvodTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem listaProizvođačaToolStripMenuItem;
    }
}

