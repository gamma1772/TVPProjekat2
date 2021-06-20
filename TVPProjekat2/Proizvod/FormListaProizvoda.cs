using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVPProjekat2.Proizvod;
using TVPProjekat2.projekatDataSetTableAdapters;

namespace TVPProjekat2
{
    public partial class FormListaProizvoda : Form
    {
        private projekatDataSet dataSet;
        private proizvodTableAdapter proizvodDB;
        private proizvodjacTableAdapter proizvodjacDB;
        private kategorijaTableAdapter kategorijaDB;
        private FormProgram main;

        private FormNoviProizvod frmNovi;
        private FormIzmeniProizvod frmIzmeni;
        private FormStatistika frmStatistika;

        public FormNoviProizvod FrmNovi { get => frmNovi; set => frmNovi = value; }
        public FormIzmeniProizvod FrmIzmeni { get => frmIzmeni; set => frmIzmeni = value; }
        public FormStatistika FrmStatistika { get => frmStatistika; set => frmStatistika = value; }

        public FormListaProizvoda(projekatDataSet dataSet, proizvodTableAdapter proizvodDB, proizvodjacTableAdapter proizvodjacDB, kategorijaTableAdapter kategorijaDB, FormProgram main)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.proizvodDB = proizvodDB;
            this.proizvodjacDB = proizvodjacDB;
            this.kategorijaDB = kategorijaDB;
            this.main = main;

            azurirajTabelu();
        }

        internal void azurirajTabelu()
        {
            var linq = from proizvod in dataSet.proizvod select proizvod;

            if (linq.Any())
            {
                dataProizvodi.DataSource = linq.CopyToDataTable();

            }

            dataProizvodi.Update();
            dataProizvodi.Refresh();
        }

        private void dodajProizvod(object sender, EventArgs e)
        {
            if (FrmNovi == null)
            {
                FrmNovi = new FormNoviProizvod(dataSet, proizvodDB, this);
                FrmNovi.Show();
            }
            else
            {
                FrmNovi.Focus();
            }
        }

        private void izmeniProizvod(object sender, EventArgs e)
        {
            if (FrmIzmeni == null)
            {
                FrmIzmeni = new FormIzmeniProizvod(dataSet, proizvodDB, this);
                FrmIzmeni.Show();
            }
            else
            {
                FrmIzmeni.Focus();
            }
        }

        private void obrisiProizvod(object sender, EventArgs e)
        {

        }

        private void prikaziStatistiku(object sender, EventArgs e)
        {

        }

        private void close(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

            this.main.FrmProizvodi = null;
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            close(sender, e);
        }

        private void promeniAktivniStatus(object sender, EventArgs e)
        {
            proizvodDB.Update(dataProizvodi.SelectedRows[0].Cells[1].Value.ToString(), int.Parse(dataProizvodi.SelectedRows[0].Cells[2].Value.ToString()), double.Parse(dataProizvodi.SelectedRows[0].Cells[3].Value.ToString()), int.Parse(dataProizvodi.SelectedRows[0].Cells[4].Value.ToString()), double.Parse(dataProizvodi.SelectedRows[0].Cells[5].Value.ToString()), dataProizvodi.SelectedRows[0].Cells[6].Value.ToString(), !bool.Parse(dataProizvodi.SelectedRows[0].Cells[7].Value.ToString()),
                int.Parse(dataProizvodi.SelectedRows[0].Cells[0].Value.ToString()), dataProizvodi.SelectedRows[0].Cells[1].Value.ToString(), int.Parse(dataProizvodi.SelectedRows[0].Cells[2].Value.ToString()), double.Parse(dataProizvodi.SelectedRows[0].Cells[3].Value.ToString()), int.Parse(dataProizvodi.SelectedRows[0].Cells[4].Value.ToString()), double.Parse(dataProizvodi.SelectedRows[0].Cells[5].Value.ToString()), dataProizvodi.SelectedRows[0].Cells[6].Value.ToString(), bool.Parse(dataProizvodi.SelectedRows[0].Cells[7].Value.ToString()));
        }
    }
}
