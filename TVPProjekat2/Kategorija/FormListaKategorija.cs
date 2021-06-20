using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVPProjekat2.Kategorija;
using TVPProjekat2.projekatDataSetTableAdapters;

namespace TVPProjekat2
{
    public partial class FormListaKategorija : Form
    {
        private projekatDataSet dataSet;
        private kategorijaTableAdapter kategorijaDB;
        private proizvodTableAdapter proizvodDB;
        private FormProgram main;

        private FormNovaKategorija frmNovaKategorija;
        private FormIzmeniKategoriju frmIzmeniKategoriju;

        public FormNovaKategorija FrmNovaKategorija { get => frmNovaKategorija; set => frmNovaKategorija = value; }
        public FormIzmeniKategoriju FrmIzmeniKategoriju { get => frmIzmeniKategoriju; set => frmIzmeniKategoriju = value; }

        public FormListaKategorija(projekatDataSet dataSet, kategorijaTableAdapter kategorijaDB, proizvodTableAdapter proizvodDB, FormProgram main)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.kategorijaDB = kategorijaDB;
            this.proizvodDB = proizvodDB;

            this.main = main;

            //dataKategorije.DataSource = kategorijaDB;
            azurirajTabelu();
        }

        private void dodajKategoriju(object sender, EventArgs e)
        {
            if (FrmNovaKategorija == null)
            {
                FrmNovaKategorija = new FormNovaKategorija(dataSet, kategorijaDB, this);
                FrmNovaKategorija.Show();
            }
            else
            {
                FrmNovaKategorija.Focus();
            }
        }

        private void izmeniKategoriju(object sender, EventArgs e)
        {
            if (FrmIzmeniKategoriju == null)
            {
                FrmIzmeniKategoriju = new FormIzmeniKategoriju(dataSet, kategorijaDB, dataKategorije.SelectedRows, this);
                FrmIzmeniKategoriju.Show();
            }
            else
            {
                FrmIzmeniKategoriju.Focus();
            }
        }

        private void obrisiKategoriju(object sender, EventArgs e)
        {
            var linq = from proizvod in dataSet.proizvod where proizvod.kategorija == int.Parse(dataKategorije.SelectedRows[0].Cells[0].Value.ToString()) select proizvod;

            if (!linq.Any())
            {
                DialogResult result = MessageBox.Show("Da li želite da obrišete odabranu kategoriju?", "Lista kategorija", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    kategorijaDB.Delete(int.Parse(dataKategorije.SelectedRows[0].Cells[0].Value.ToString()), dataKategorije.SelectedRows[0].Cells[1].Value.ToString());

                    kategorijaDB.Update(dataSet);
                    kategorijaDB.Fill(dataSet.kategorija);

                    azurirajTabelu();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Kategorija je dodeljena proizvodu. Potrebno je da obrišete proizvod ili da mu promenite kategoriju.", "Lista kategorija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void azurirajTabelu()
        {
            var linq = from kategorija in dataSet.kategorija select kategorija;

            if (linq.Any())
            {
                dataKategorije.DataSource = linq.CopyToDataTable();
            }

            dataKategorije.Update();
            dataKategorije.Refresh();
        }

        private void close(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            main.FrmKategorije = null;
        }

        private void FormListaKategorija_FormClosed(object sender, FormClosedEventArgs e)
        {
            close(sender, e);
        }
    }
}
