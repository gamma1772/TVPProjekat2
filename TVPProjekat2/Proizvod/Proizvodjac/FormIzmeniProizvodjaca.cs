using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TVPProjekat2.projekatDataSetTableAdapters;

namespace TVPProjekat2.Proizvod.Proizvodjac
{
    public partial class FormIzmeniProizvodjaca : Form
    {
        private projekatDataSet dataSet;
        private proizvodjacTableAdapter proizvodjacDB;
        FormListaProizvodjaca formListaProizvodjaca;
        private DataGridViewSelectedRowCollection row;

        private Regex regex = new Regex("[A-Za-z0-9\\s]{2,255}");
        private Regex regexNoDigit = new Regex("[A-Za-z\\s]{2,255}");

        public FormIzmeniProizvodjaca(projekatDataSet dataSet, proizvodjacTableAdapter proizvodjacDB, DataGridViewSelectedRowCollection row, FormListaProizvodjaca formListaProizvodjaca)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.proizvodjacDB = proizvodjacDB;
            this.formListaProizvodjaca = formListaProizvodjaca;
            this.row = row;

            txtID.Text = row[0].Cells[0].Value.ToString();
            txtNaziv.Text = row[0].Cells[1].Value.ToString();
            txtDrzava.Text = row[0].Cells[2].Value.ToString();
        }

        private void izmeniProizvodjaca(object sender, EventArgs e)
        {
            if (regex.IsMatch(txtNaziv.Text) && regexNoDigit.IsMatch(txtDrzava.Text))
            {
                var linq = from proizvodjac in dataSet.proizvodjac where proizvodjac.naziv.ToLower().Equals(txtNaziv.Text.ToLower()) && proizvodjac.drzava.ToLower().Equals(txtDrzava.Text.ToLower()) select proizvodjac;
                if (row[0].Cells[1].ToString().ToLower().Equals(txtNaziv.Text.ToLower()) && row[0].Cells[2].ToString().ToLower().Equals(txtDrzava.Text.ToLower()))
                {
                    MessageBox.Show("Proizvođač nije izmenjen.", "Izmena proizvođača", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    otkazi(sender, e);
                }
                else if (linq.Any())
                {
                    MessageBox.Show("Proizvođač sa ovim nazivom i zemljom porekla već postoji.", "Izmena proizvođača", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    proizvodjacDB.Update(txtNaziv.Text, txtDrzava.Text, int.Parse(row[0].Cells[0].Value.ToString()), row[0].Cells[1].Value.ToString(), row[0].Cells[2].Value.ToString());
                    proizvodjacDB.Fill(dataSet.proizvodjac);

                    MessageBox.Show("Proizvođač uspešno izmenjen.", "Izmena proizvođača", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    formListaProizvodjaca.azurirajTabelu();
                    otkazi(sender, e);

                }
            }
            else
            {
                MessageBox.Show("Polja za naziv proizvođača i države ne smeju da budu kraći od 2 znaka i mogu da sadrže samo slova i brojeve (samo za naziv)", "Izmena proizvođača", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void otkazi(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            formListaProizvodjaca.FrmIzmeni = null;
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            otkazi(sender, e);
        }
    }
}
