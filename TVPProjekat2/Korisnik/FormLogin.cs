using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPProjekat2
{
    public partial class FormLogin : Form
    {
        private delegate void sendUser(Korisnik korisnik);

        projekatDataSet pds;
        projekatDataSetTableAdapters.korisnikTableAdapter pdaKorisnik;

        public FormLogin()
        {
            InitializeComponent();
            pds = new projekatDataSet();
            pdaKorisnik = new projekatDataSetTableAdapters.korisnikTableAdapter();
            pdaKorisnik.Fill(pds.korisnik);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(proveraForme()) {
                login();
            }
            else
            {
                MessageBox.Show(@"Polja ne smeju da sadrze specijalne znakove osim ! . _ -", "Neispravan unos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        ///<summary>
        ///Pokrece proces prijavljivanja, vrsi proveru podataka tako sto poziva linq upit iz baze
        ///i uporedjuje podatke unete u formu sa podacima iz baze. Ako su podaci tacni, prijavljuje 
        ///korisnika i prosledjuje ga na glavni program, u suprotnom izbacuje gresku da podaci nisu tacni.
        ///</summary>
        private void login()
        {
            Korisnik k = new Korisnik();
            string username = txtUsername.Text;
            string password = txtPasswd.Text;
            var korisnikLinq = from korisnik in pds.korisnik where korisnik.korisnicko_ime.Equals(username) && korisnik.sifra.Equals(password) select korisnik;
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

                FormProgram frm = new FormProgram(pds, this);
                sendUser del = new sendUser(frm.recieveUser);
                del(k);

                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Niste uneli pravilno korisnicko ime ili lozinku!", "Netacni podaci", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        ///<summary>
        ///Proverava da li forma sadrzi nepravilne karaktere;
        ///</summary>
        ///<returns>
        ///True ako se tekstualna polja poklapaju sa regularnim izrazom.
        ///</returns>
        private bool proveraForme()
        {
            //char[] kolekcija = { '@', '#', '%', '&', '*', '=', '+', '|', '/', '\\', ' '};
            Regex regex = new Regex("[A-Za-z0-9!._-]+");
            if (!regex.IsMatch(txtUsername.Text) || !regex.IsMatch(txtPasswd.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
