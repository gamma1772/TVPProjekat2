using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVPProjekat2
{
    class Korisnik
    {
        private string uuid;
        private DateTime datumRodjenja;
        private string ime, prezime, korisnickoIme, sifra, adresa, brojTelefona;
        public string UUID { get => uuid; set => uuid = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Sifra { get => sifra; set => sifra = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }

        public Korisnik(string UUID, DateTime datumRodjenja, string ime, string prezime, string korisnickoIme, string sifra, string adresa, string brojTelefona)
        {
            this.UUID = UUID;
            this.DatumRodjenja = datumRodjenja;
            this.Ime = ime;
            this.Prezime = prezime;
            this.KorisnickoIme = korisnickoIme;
            this.Sifra = sifra;
            this.Adresa = adresa;
            this.BrojTelefona = brojTelefona;
        }

        public Korisnik(DateTime datumRodjenja, string ime, string prezime, string korisnickoIme, string sifra, string adresa, string brojTelefona)
        {
            this.UUID = generateUUID();
            this.DatumRodjenja = datumRodjenja;
            this.Ime = ime;
            this.Prezime = prezime;
            this.KorisnickoIme = korisnickoIme;
            this.Sifra = sifra;
            this.Adresa = adresa;
            this.BrojTelefona = brojTelefona;
        }

        public Korisnik()
        {
            this.UUID = generateUUID();
            this.DatumRodjenja = new DateTime();
            this.Ime = "";
            this.Prezime = "";
            this.KorisnickoIme = "";
            this.Sifra = "";
            this.Adresa = "";
            this.BrojTelefona = "";
        }
        /// <summary>
        /// Generise jedinstveni identifikator za korisnika na osnovu danasnjeg datuma i nasumicnog broja izmedju 1000 i 9999.
        /// </summary>
        /// <returns>
        /// Tekstualni jedinstveni identifikator u formatu: ddMMyyyyHHmmXXXX<br></br>
        ///     - dd: dan<br></br>
        ///     - MM: mesec<br></br>
        ///     - yyyy: godina<br></br>
        ///     - HH: sat<br></br>
        ///     - mm: minut<br></br>
        ///     - XXXX: Nasumican broj od 1000 do 9999
        /// </returns>
        private string generateUUID()
        {
            return DateTime.Now.ToString("ddMMyyyyHHmm") + new Random().Next(1000, 9999).ToString();
        }
    }
}
