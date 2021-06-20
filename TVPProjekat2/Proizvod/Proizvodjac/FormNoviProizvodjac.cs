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
using TVPProjekat2.projekatDataSetTableAdapters;

namespace TVPProjekat2.Proizvod.Proizvodjac
{
    public partial class FormNoviProizvodjac : Form
    {
        private projekatDataSet dataSet;
        private proizvodjacTableAdapter proizvodjacDB;
        private FormListaProizvodjaca frmProizvodjaci;

        private Regex regex = new Regex("[A-Za-z0-9\\s]{2,255}");
        private Regex regexNoDigit = new Regex("[A-Za-z\\s]{2,255}");
        public FormNoviProizvodjac(projekatDataSet dataSet, proizvodjacTableAdapter proizvodjacDB, FormListaProizvodjaca frmProizvodjaci)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.proizvodjacDB = proizvodjacDB;
            this.frmProizvodjaci = frmProizvodjaci;
        }

        private void dodajProizvodjaca(object sender, EventArgs e)
        {
            if (regex.IsMatch(txtNaziv.Text) && regexNoDigit.IsMatch(txtDrzava.Text))
            {
                var linq = from proizvodjac in dataSet.proizvodjac where proizvodjac.naziv.ToLower().Equals(txtNaziv.Text.ToLower()) && proizvodjac.drzava.ToLower().Equals(txtDrzava.Text.ToLower()) select proizvodjac;
                if (!linq.Any())
                {
                    proizvodjacDB.Insert(txtNaziv.Text, txtDrzava.Text);
                    proizvodjacDB.Update(dataSet);
                    proizvodjacDB.Fill(dataSet.proizvodjac);

                    MessageBox.Show("Uspešno dodat novi proizvođač.", "Novi proizvođač", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmProizvodjaci.azurirajTabelu();
                    otkazi(sender, e);
                }
                else
                {
                    MessageBox.Show("Ovaj proizvođač već postoji.", "Novi proizvođač", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Polje za naziv proizvođača i državu ne sme da bude kraće od 2 znaka i može da sadrži samo slova i brojeve (samo za naziv).", "Novi proizvođač", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void otkazi(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            frmProizvodjaci.FrmNovi = null;
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            otkazi(sender, e);
        }
    }
}
