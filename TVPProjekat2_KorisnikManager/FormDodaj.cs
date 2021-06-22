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
    public partial class FormDodaj : Form
    {
        private projekatDataSet dataSet;
        private korisnikTableAdapter korisnikDB;
        private FormProgram frm;

        Regex regex = new Regex("[A-Za-z]+");
        Regex brTelefona = new Regex("[0-9]{9,10}");
        Regex adresa = new Regex("[A-Za-z0-9\\s]+");
        Regex sifra = new Regex("[A-Za-z0-9._!]{6,}");
        Regex korIme = new Regex("[A-Za-z0-9_!]{6,}");
        public FormDodaj(projekatDataSet dataSet, korisnikTableAdapter korisnikDB, FormProgram frm)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.korisnikDB = korisnikDB;
            this.frm = frm;

            this.uUIDTextBox.Text = generateUUID();
        }

        private string generateUUID()
        {
            return DateTime.Now.ToString("ddMMyyyyHHmm") + new Random().Next(1000, 9999).ToString();
        }

        private void create(object sender, EventArgs e)
        {
            if (regex.IsMatch(imeTextBox.Text) && regex.IsMatch(prezimeTextBox.Text) &&
                korIme.IsMatch(korisnicko_imeTextBox.Text) && sifra.IsMatch(sifraTextBox.Text) &&
                adresa.IsMatch(adresaTextBox.Text) && brTelefona.IsMatch(broj_telefonaTextBox.Text) &&
                datum_rodjenjaDateTimePicker.Value.Year < DateTime.Now.Year - 17)
            {
                korisnikDB.Insert(uUIDTextBox.Text, imeTextBox.Text, prezimeTextBox.Text, korisnicko_imeTextBox.Text, sifraTextBox.Text, datum_rodjenjaDateTimePicker.Value, adresaTextBox.Text, broj_telefonaTextBox.Text, true);
                frm.update();
                close(sender, e);
            }
            else
            {
                MessageBox.Show("Forma nije pravilno popunjena. Proverite formu.", "Novi korisnik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

            frm.FrmDodaj = null;
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            close(sender, e);
        }
    }
}
