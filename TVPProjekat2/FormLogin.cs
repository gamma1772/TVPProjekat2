using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPProjekat2
{
    public partial class FormLogin : Form
    {
        private delegate void sendUser(Korisnik korisnik);

        projekatDataSet pds;
        projekatDataSetTableAdapters.KorisnikTableAdapter pdaKorisnik;

        public FormLogin()
        {
            InitializeComponent();
            pds = new projekatDataSet();
            pdaKorisnik = new projekatDataSetTableAdapters.KorisnikTableAdapter();
            pdaKorisnik.Fill(pds.Korisnik);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(proveraForme()) {
                login();
            }
            else
            {
                MessageBox.Show(@"Polja ne smeju da sadrze specijalne znakove: @, #, &, *, =, +, |, \, / ili prazan znak", "Neispravan unos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void login()
        {
            Korisnik k = new Korisnik();
            string username = txtUsername.Text;
            string password = txtPasswd.Text;
            var korisnikLinq = from korisnik in pds.Korisnik where korisnik.korisnicko_ime.Equals(username) && korisnik.sifra.Equals(password) select korisnik;
            if (korisnikLinq.Any())
            {
                k.UUID = korisnikLinq.ElementAt(0).UUID;
                k.DatumRodjenja = korisnikLinq.ElementAt(0).datum_rodjenja;
                k.Ime = korisnikLinq.ElementAt(0).ime;
                k.Prezime = korisnikLinq.ElementAt(0).prezime;
                k.KorisnickoIme = korisnikLinq.ElementAt(0).korisnicko_ime;
                k.Sifra = korisnikLinq.ElementAt(0).sifra;
                k.Adresa = korisnikLinq.ElementAt(0).adresa;
                k.BrojTelefona = korisnikLinq.ElementAt(0).broj_telefona;

                FormProgram frm = new FormProgram(pds);
                sendUser del = new sendUser(frm.recieveUser);

                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Niste uneli pravilno korisnicko ime ili lozinku!", "Netacni podaci", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool proveraForme()
        {
            char[] kolekcija = { '@', '#', '%', '&', '*', '=', '+', '|', '/', '\\', ' '};
            foreach (char c in kolekcija)
            {
                if (txtUsername.Text.Contains(c) || txtPasswd.Text.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
