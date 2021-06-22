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
using TVPProjekat2_KorisnikManager.projekatDataSetTableAdapters;

namespace TVPProjekat2_KorisnikManager
{
    public partial class FormIzmeni : Form
    {
        private projekatDataSet dataSet;
        private korisnikTableAdapter korisnikDB;
        private FormProgram frm;
        private DataGridViewRow row;

        Regex regex = new Regex("[A-Za-z]+");
        Regex brTelefona = new Regex("[0-9]{9,10}");
        Regex adresa = new Regex("[A-Za-z0-9\\s]+");
        Regex sifra = new Regex("[A-Za-z0-9._!]{6,}");
        Regex korIme = new Regex("[A-Za-z0-9_!]{6,}");
        public FormIzmeni(projekatDataSet dataSet, korisnikTableAdapter korisnikDB, DataGridViewRow row, FormProgram frm)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.korisnikDB = korisnikDB;
            this.frm = frm;
            this.row = row;

            uUIDTextBox.Text = row.Cells[0].Value.ToString();
            imeTextBox.Text = row.Cells[1].Value.ToString();
            prezimeTextBox.Text = row.Cells[2].Value.ToString();
            korisnicko_imeTextBox.Text = row.Cells[3].Value.ToString();
            sifraTextBox.Text = row.Cells[4].Value.ToString();
            datum_rodjenjaDateTimePicker.Value = DateTime.Parse(row.Cells[5].Value.ToString());
            adresaTextBox.Text = row.Cells[6].Value.ToString();
            broj_telefonaTextBox.Text = row.Cells[7].Value.ToString();
        }

        private void close(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

            frm.FrmIzmeni = null;
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            close(sender, e);
        }

        private void save(object sender, EventArgs e)
        {
            if (regex.IsMatch(imeTextBox.Text) && regex.IsMatch(prezimeTextBox.Text) &&
                korIme.IsMatch(korisnicko_imeTextBox.Text) && sifra.IsMatch(sifraTextBox.Text) &&
                adresa.IsMatch(adresaTextBox.Text) && brTelefona.IsMatch(broj_telefonaTextBox.Text) &&
                datum_rodjenjaDateTimePicker.Value.Year < DateTime.Now.Year - 17)
            {
                korisnikDB.Update(imeTextBox.Text, prezimeTextBox.Text, korisnicko_imeTextBox.Text, sifraTextBox.Text, datum_rodjenjaDateTimePicker.Value, adresaTextBox.Text, broj_telefonaTextBox.Text, true, uUIDTextBox.Text, row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), DateTime.Parse(row.Cells[5].Value.ToString()), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), bool.Parse(row.Cells[8].Value.ToString()));
                frm.update();
                close(sender, e);
            }
            else
            {
                MessageBox.Show("Forma nije pravilno popunjena. Proverite formu.", "Izmeni korisnika", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
