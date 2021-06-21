using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVPProjekat2.Kategorija;
using TVPProjekat2.Proizvod.Proizvodjac;
using TVPProjekat2.projekatDataSetTableAdapters;

namespace TVPProjekat2.Proizvod
{
    public partial class FormNoviProizvod : Form
    {
        private projekatDataSet dataSet;
        private proizvodTableAdapter proizvodDB;
        private kategorijaTableAdapter kategorijaDB;
        private proizvodjacTableAdapter proizvodjacDB;
        private FormListaProizvoda frmListaProizvoda;
        private FormNoviRacun frmNoviRacun;

        private Regex regex = new Regex("[A-Za-z0-9\\s]{2,255}");
        private Regex regexBarKod = new Regex("[0-9]{2,13}");
        private Regex regexCena = new Regex("[0-9]+[.]{1}[0-9]{0,2}");
        private Regex regexDigit = new Regex("[0-9]+");

        private FormNovaKategorija frmNovaKategorija;
        private FormNoviProizvodjac formNoviProizvodjac;

        public FormNovaKategorija FrmNovaKategorija { get => frmNovaKategorija; set => frmNovaKategorija = value; }
        public FormNoviProizvodjac FrmNoviProizvodjac { get => formNoviProizvodjac; set => formNoviProizvodjac = value; }

        public FormNoviProizvod(projekatDataSet dataSet, proizvodTableAdapter proizvodDB, kategorijaTableAdapter kategorijaDB, proizvodjacTableAdapter proizvodjacDB, FormListaProizvoda main)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.proizvodDB = proizvodDB;
            this.kategorijaDB = kategorijaDB;
            this.proizvodjacDB = proizvodjacDB;
            this.frmListaProizvoda = main;
            this.frmNoviRacun = null;

            popuniListe();
        }

        public FormNoviProizvod(projekatDataSet dataSet, proizvodTableAdapter proizvodDB, kategorijaTableAdapter kategorijaDB, proizvodjacTableAdapter proizvodjacDB, FormNoviRacun main)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.proizvodDB = proizvodDB;
            this.kategorijaDB = kategorijaDB;
            this.proizvodjacDB = proizvodjacDB;
            this.frmListaProizvoda = null;
            this.frmNoviRacun = main;

            popuniListe();
        }

        private void dodajProizvod(object sender, EventArgs e)
        {
            if (regex.IsMatch(txtNaziv.Text) && (regexDigit.IsMatch(txtKolicina.Text) || regexCena.IsMatch(txtKolicina.Text)) && (regexCena.IsMatch(txtCena.Text) || regexDigit.IsMatch(txtCena.Text)) && regexBarKod.IsMatch(txtBarKod.Text))
            {
                if (comboProizvodjac.SelectedIndex != -1 && ComboKategorija.SelectedIndex != -1)
                {
                    proizvodDB.Insert(txtNaziv.Text, comboProizvodjac.SelectedIndex + 1, double.Parse(txtKolicina.Text), ComboKategorija.SelectedIndex + 1, double.Parse(txtCena.Text), txtBarKod.Text, checkAktivno.Checked);
                    proizvodDB.Update(dataSet);
                    proizvodDB.Fill(dataSet.proizvod);

                    if (frmListaProizvoda == null)
                    {
                        frmNoviRacun.osveziListu();
                    }
                    else
                    {
                        frmListaProizvoda.azurirajTabelu();
                    }

                    close(sender, e);
                }
                else
                {
                    MessageBox.Show("Potrebno je da odaberete proizvođača i kategoriju.", "Novi proizvod", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tekstualna polja za naziv, količinu, cenu ili barKod su pogrešno popunjeni.\nNaziv: Slova i brojevi\nKoličina i cena: celi brojevi ili sa decimalnim zarezom i dve nule\nBar kod: 13 cifara", "Novi proizvod", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

            if (frmListaProizvoda == null)
            {
                frmNoviRacun.FrmNoviProizvod = null;
            }
            else
            {
                frmListaProizvoda.FrmNovi = null;
            }
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            close(sender, e);
        }

        internal void popuniListe()
        {
            var linqProizvodjac = from proizvodjac in dataSet.proizvodjac where proizvodjac.aktivno == true select proizvodjac.naziv;
            var linqKategorija = from kategorija in dataSet.kategorija where kategorija.aktivno == true select kategorija.ime;

            if (linqProizvodjac.Any())
            {
                comboProizvodjac.DataSource = linqProizvodjac.ToList();
            }
            if (linqKategorija.Any())
            {
                ComboKategorija.DataSource = linqKategorija.ToList();
            }
        }

        private void noviProizvodjac(object sender, EventArgs e)
        {
            if (FrmNoviProizvodjac == null)
            {
                FrmNoviProizvodjac = new FormNoviProizvodjac(dataSet, proizvodjacDB, this);
                FrmNoviProizvodjac.Show();
            }
            else
            {
                FrmNoviProizvodjac.Focus();
            }
        }

        private void novaKategorija(object sender, EventArgs e)
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
    }
}
