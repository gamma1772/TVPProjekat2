using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVPProjekat2
{
    class Racun
    {
        private string iD;
        private Korisnik kreatorRacuna;
        private DateTime dateTime;
        private List<Proizvod> proizvodi;
        private double cena;

        public string ID { get => iD; set => iD = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        internal List<Proizvod> Proizvodi { get => proizvodi; set => proizvodi = value; }
        public double Cena { get => cena; set => cena = value; }
        public String GenerateID { get => generateID(); }
        internal Korisnik KreatorRacuna { get => kreatorRacuna; set => kreatorRacuna = value; }

        public Racun(string iD, DateTime dateTime, Korisnik kreatorRacuna, List<Proizvod> proizvodi, double cena)
        {
            this.ID = iD;
            this.DateTime = dateTime;
            this.Proizvodi = proizvodi;
            this.Cena = cena;
            this.KreatorRacuna = kreatorRacuna;
        }

        public Racun(DateTime dateTime, Korisnik kreatorRacuna, List<Proizvod> proizvodi, double cena)
        {
            this.ID = this.GenerateID;
            this.DateTime = dateTime;
            this.Proizvodi = proizvodi;
            this.Cena = cena;
            this.KreatorRacuna = kreatorRacuna;
        }

        public Racun()
        {
            this.ID = this.generateID();
            this.DateTime = new DateTime();
            this.Proizvodi = new List<Proizvod>();
            this.Cena = 0.0D;
            this.KreatorRacuna = new Korisnik();
        }
        /// <summary>
        /// Generise jedinstveni identifikator za racun na osnovu danasnjeg datuma i nasumicnog broja izmedju 1000 i 7000.<br></br>
        /// Generator nasumicnog broja koristi seed koji se sastoji od trenutnog sata, minuta, sekunde i 10000-og dela sekunde
        /// </summary>
        /// <returns>
        /// Tekstualni jedinstveni identifikator u formatu: HHmmssffXXXX<br></br>
        ///     - HH: sat<br></br>
        ///     - mm: minut<br></br>
        ///     - ss: sekund<br></br>
        ///     - ff: stoti deo sekunde<br></br>
        ///     - XXXX: Nasumican broj od 1000 do 7000
        /// </returns>
        private string generateID()
        {
            Random random = new Random(int.Parse(DateTime.Now.ToString("HHmmssffff")));
            return DateTime.Now.ToString("HHmmssff") + random.Next(1000, 7000).ToString();
        }
    }
}
