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
    public partial class FormIzmeniKategoriju : Form
    {
        private projekatDataSet dataSet;
        private kategorijaTableAdapter kategorijaDB;
        private FormListaKategorija frmKategorije;
        private DataGridViewSelectedRowCollection row;

        private Regex regex = new Regex("[A-Za-z0-9\\s]{2,255}");
        public FormIzmeniKategoriju(projekatDataSet dataSet, kategorijaTableAdapter kategorijaDB, DataGridViewSelectedRowCollection row, FormListaKategorija frmKategorije)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.kategorijaDB = kategorijaDB;
            this.frmKategorije = frmKategorije;
            this.row = row;

            txtID.Text = row[0].Cells[0].Value.ToString();
            txtNaziv.Text = row[0].Cells[1].Value.ToString();
        }

        private void izmeniKategoriju(object sender, EventArgs e)
        {
            if (regex.IsMatch(txtNaziv.Text))
            {
                var linq = from kategorija in dataSet.kategorija where kategorija.ime.ToLower().Equals(txtNaziv.Text.ToLower()) select kategorija;
                if (row[0].Cells[1].ToString().ToLower().Equals(txtNaziv.Text.ToLower()))
                {
                    MessageBox.Show("Kategorija nije izmenjena.", "Izmena kategorije", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    otkazi(sender, e);
                }
                else if (linq.Any())
                {
                    MessageBox.Show("Kategorija sa ovim imenom već postoji.", "Izmena kategorije", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    kategorijaDB.Update(txtNaziv.Text, int.Parse(row[0].Cells[0].Value.ToString()), row[0].Cells[1].Value.ToString());
                    kategorijaDB.Fill(dataSet.kategorija);

                    MessageBox.Show("Kategorija uspešno izmenjena.", "Izmena kategorije", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    frmKategorije.azurirajTabelu();
                    otkazi(sender, e);
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
            frmKategorije.FrmIzmeniKategoriju = null;
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            otkazi(sender, e);
        }
    }
}
