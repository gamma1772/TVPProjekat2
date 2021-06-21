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
using TVPProjekat2.Proizvod;
using TVPProjekat2.projekatDataSetTableAdapters;

namespace TVPProjekat2.Kategorija
{
    public partial class FormNovaKategorija : Form
    {
        private projekatDataSet dataSet;
        private kategorijaTableAdapter kategorijaDB;

        private FormListaKategorija frmKategorije;
        private FormIzmeniProizvod frmIzmeniProizvod;
        private FormNoviProizvod frmNoviProizvod;

        private Regex regex = new Regex("[A-Za-z0-9\\s]{2,255}");
        public FormNovaKategorija( projekatDataSet dataSet, kategorijaTableAdapter kategorijaDB, FormListaKategorija frmKategorije)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.kategorijaDB = kategorijaDB;
            this.frmKategorije = frmKategorije;
        }

        public FormNovaKategorija(projekatDataSet dataSet, kategorijaTableAdapter kategorijaDB, FormIzmeniProizvod form)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.kategorijaDB = kategorijaDB;
            this.frmIzmeniProizvod = form;
        }

        public FormNovaKategorija(projekatDataSet dataSet, kategorijaTableAdapter kategorijaDB, FormNoviProizvod form)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.kategorijaDB = kategorijaDB;
            this.frmNoviProizvod = form;
        }

        private void dodajKategoriju(object sender, EventArgs e)
        {
            if (regex.IsMatch(txtNaziv.Text))
            {
                var linq = from kategorija in dataSet.kategorija where kategorija.ime.ToLower().Equals(txtNaziv.Text.ToLower()) select kategorija;
                if (!linq.Any())
                {
                    kategorijaDB.Insert(txtNaziv.Text, true);
                    kategorijaDB.Update(dataSet);
                    kategorijaDB.Fill(dataSet.kategorija);

                    MessageBox.Show("Uspešno dodata nova kategorija.", "Nova kategorija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (frmKategorije != null)
                    {
                        frmKategorije.azurirajTabelu();
                    }
                    if (frmNoviProizvod != null)
                    {
                        frmNoviProizvod.popuniListe();
                    }
                    if (frmIzmeniProizvod != null)
                    {
                        frmIzmeniProizvod.popuniListe();
                    }
                    otkazi(sender, e);
                }
                else
                {
                    MessageBox.Show("Ova kategorija već postoji.", "Nova kategorija", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Polje za naziv kategorije ne sme da bude kraće od 2 znaka i može da sadrži samo slova i brojeve.", "Nova kategorija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void otkazi(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            if (frmKategorije != null)
            {
                frmKategorije.FrmNovaKategorija = null;
            }
            if (frmNoviProizvod != null)
            {
                frmNoviProizvod.FrmNovaKategorija = null;
            }
            if (frmIzmeniProizvod != null)
            {
                frmIzmeniProizvod.FrmNovaKategorija = null;
            }
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            otkazi(sender, e);
        }
    }
}
