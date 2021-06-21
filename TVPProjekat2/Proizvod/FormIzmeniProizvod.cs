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
    public partial class FormIzmeniProizvod : Form
    {
        private projekatDataSet dataSet;
        private proizvodTableAdapter proizvodDB;
        private kategorijaTableAdapter kategorijaDB;
        private proizvodjacTableAdapter proizvodjacDB;
        private FormListaProizvoda frmListaProizvoda;
        private FormNoviRacun frmNoviRacun;

        private Regex regex = new Regex("[A-Za-z0-9\\s]{2,255}");
        private Regex regexBarKod = new Regex("[0-9]{2,13}");
        private Regex regexCena = new Regex("[0-9]+[,.]{1}[0-9]{0,2}");
        private Regex regexDigit = new Regex("[0-9]+");

        DataGridViewSelectedRowCollection row;
        ListView.SelectedListViewItemCollection item;

        private FormNovaKategorija frmNovaKategorija;
        private FormNoviProizvodjac formNoviProizvodjac;

        public FormNovaKategorija FrmNovaKategorija { get => frmNovaKategorija; set => frmNovaKategorija = value; }
        public FormNoviProizvodjac FrmNoviProizvodjac { get => formNoviProizvodjac; set => formNoviProizvodjac = value; }

        public FormIzmeniProizvod(projekatDataSet dataSet, proizvodTableAdapter proizvodDB, kategorijaTableAdapter kategorijaDB, proizvodjacTableAdapter proizvodjacDB, DataGridViewSelectedRowCollection row, FormListaProizvoda main)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.proizvodDB = proizvodDB;
            this.kategorijaDB = kategorijaDB;
            this.proizvodjacDB = proizvodjacDB;
            this.frmListaProizvoda = main;
            this.frmNoviRacun = null;
            this.row = row;
            popuniListe();

            txtID.Text = int.Parse(row[0].Cells[0].Value.ToString()).ToString();
            txtNaziv.Text = row[0].Cells[1].Value.ToString();
            comboProizvodjac.SelectedIndex = int.Parse(row[0].Cells[2].Value.ToString()) - 1;
            txtKolicina.Text = double.Parse(row[0].Cells[3].Value.ToString()).ToString("0.00");
            ComboKategorija.SelectedIndex = int.Parse(row[0].Cells[4].Value.ToString()) - 1;
            txtCena.Text = double.Parse(row[0].Cells[5].Value.ToString()).ToString("0.00");
            txtBarKod.Text = row[0].Cells[6].Value.ToString();
            checkAktivno.Checked = bool.Parse(row[0].Cells[7].Value.ToString());
        }

        public FormIzmeniProizvod(projekatDataSet dataSet, proizvodTableAdapter proizvodDB, kategorijaTableAdapter kategorijaDB, proizvodjacTableAdapter proizvodjacDB, ListView.SelectedListViewItemCollection item, FormNoviRacun main)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.proizvodDB = proizvodDB;
            this.kategorijaDB = kategorijaDB;
            this.proizvodjacDB = proizvodjacDB;
            this.frmListaProizvoda = null;
            this.frmNoviRacun = main;
            this.item = item;

            popuniListe();

            txtID.Text = int.Parse(item[0].SubItems[0].Text).ToString();
            txtNaziv.Text = item[0].SubItems[2].Text;

            var linqProizvodjac = from proizvodjac in dataSet.proizvodjac where proizvodjac.naziv.ToLower().Equals(item[0].SubItems[3].Text.ToLower()) select proizvodjac.ID;
            comboProizvodjac.SelectedIndex = linqProizvodjac.ElementAt(0) - 1;

            txtKolicina.Text = double.Parse(item[0].SubItems[5].Text).ToString("0.00");
            txtKolicina.Text.Replace('.', ',');

            var linqKategorija = from kategorija in dataSet.kategorija where kategorija.ime.ToLower().Equals(item[0].SubItems[4].Text.ToLower()) select kategorija.ID;
            ComboKategorija.SelectedIndex = linqKategorija.ElementAt(0) - 1;

            txtCena.Text = double.Parse(item[0].SubItems[6].Text).ToString("0.00");
            txtBarKod.Text = item[0].SubItems[1].Text;
            checkAktivno.Checked = true;
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

        private void izmeniProizvod(object sender, EventArgs e)
        {
            if (regex.IsMatch(txtNaziv.Text) && (regexDigit.IsMatch(txtKolicina.Text) || regexCena.IsMatch(txtKolicina.Text)) && (regexCena.IsMatch(txtCena.Text) || regexDigit.IsMatch(txtCena.Text)) && regexBarKod.IsMatch(txtBarKod.Text))
            {
                if (comboProizvodjac.SelectedIndex != -1 && ComboKategorija.SelectedIndex != -1)
                {
                    //proizvodDB.Insert(txtNaziv.Text, comboProizvodjac.SelectedIndex + 1, double.Parse(txtKolicina.Text), ComboKategorija.SelectedIndex + 1, double.Parse(txtCena.Text), txtBarKod.Text, checkAktivno.Checked);


                    if (frmListaProizvoda == null)
                    {
                        var linqProizvodjac = from proizvodjac in dataSet.proizvodjac where proizvodjac.naziv.ToLower().Equals(item[0].SubItems[3].Text.ToLower()) select proizvodjac.ID;
                        var linqKategorija = from kategorija in dataSet.kategorija where kategorija.ime.ToLower().Equals(item[0].SubItems[4].Text.ToLower()) select kategorija.ID;


                        proizvodDB.Update(txtNaziv.Text, comboProizvodjac.SelectedIndex + 1, double.Parse(txtKolicina.Text.Replace('.', ',')), ComboKategorija.SelectedIndex + 1, double.Parse(txtCena.Text.Replace('.', ',')), txtBarKod.Text, checkAktivno.Checked,
                        int.Parse(txtID.Text), item[0].SubItems[2].Text, linqProizvodjac.ElementAt(0), double.Parse(item[0].SubItems[5].Text), linqKategorija.ElementAt(0), double.Parse(item[0].SubItems[6].Text), item[0].SubItems[1].Text, true);
                        proizvodDB.Update(dataSet);
                        proizvodDB.Fill(dataSet.proizvod);
                        frmNoviRacun.osveziListu();

                        close(sender, e);
                    }
                    else
                    {
                        proizvodDB.Update(txtNaziv.Text, comboProizvodjac.SelectedIndex + 1, double.Parse(txtKolicina.Text.Replace('.', ',')), ComboKategorija.SelectedIndex + 1, double.Parse(txtCena.Text.Replace('.', ',')), txtBarKod.Text, checkAktivno.Checked,
                        int.Parse(txtID.Text), row[0].Cells[1].Value.ToString(), int.Parse(row[0].Cells[2].Value.ToString()), double.Parse(row[0].Cells[3].Value.ToString()), int.Parse(row[0].Cells[4].Value.ToString()), double.Parse(row[0].Cells[5].Value.ToString()), row[0].Cells[6].Value.ToString(), bool.Parse(row[0].Cells[7].Value.ToString()));
                        proizvodDB.Update(dataSet);
                        proizvodDB.Fill(dataSet.proizvod);
                        frmListaProizvoda.azurirajTabelu();

                        close(sender, e);
                    }
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
                frmNoviRacun.FrmIzmeniProizvod = null;
            }
            else
            {
                frmListaProizvoda.FrmIzmeni = null;
            }
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            close(sender, e);
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
