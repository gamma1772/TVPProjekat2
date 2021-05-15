using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVPProjekat2
{
    class Proizvod
    {
        private int id, kolicina;
        private string imeProizvoda;
        private Kategorija kategorija;
        private double cena;
        private string barKod;

        public int Id { get => id; set => id = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public string ImeProizvoda { get => imeProizvoda; set => imeProizvoda = value; }
        internal Kategorija Kategorija { get => kategorija; set => kategorija = value; }
        public double Cena { get => cena; set => cena = value; }
        public string BarKod { get => barKod; set => barKod = value; }

        public Proizvod(int id, string imeProizvoda, int kolicina, Kategorija kategorija, double cena, string barKod)
        {
            Id = id;
            ImeProizvoda = imeProizvoda;
            Kolicina = kolicina;
            Kategorija = kategorija;
            Cena = cena;
            BarKod = barKod;
        }
    }
}
