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

namespace TVPProjekat2.Kategorija
{
    public partial class FormNovaKategorija : Form
    {
        private projekatDataSet dataSet;
        private kategorijaTableAdapter kategorijaDB;
        private FormListaKategorija frmKategorije;

        private Regex regex = new Regex("[A-Za-z0-9\\s]{2,255}");
        public FormNovaKategorija( projekatDataSet dataSet, kategorijaTableAdapter kategorijaDB, FormListaKategorija frmKategorije)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.kategorijaDB = kategorijaDB;
            this.frmKategorije = frmKategorije;
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
                    frmKategorije.azurirajTabelu();
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
            frmKategorije.FrmNovaKategorija = null;
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            otkazi(sender, e);
        }
    }
}
