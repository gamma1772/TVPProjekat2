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

        public int Id { get => id; set => id = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public string ImeProizvoda { get => imeProizvoda; set => imeProizvoda = value; }
        internal Kategorija Kategorija { get => kategorija; set => kategorija = value; }

        public Proizvod(int id, string imeProizvoda, int kolicina, Kategorija kategorija)
        {
            Id = id;
            ImeProizvoda = imeProizvoda;
            Kolicina = kolicina;
            Kategorija = kategorija;
        }

        public Proizvod(string imeProizvoda, int kolicina, Kategorija kategorija)
        {
            this.imeProizvoda = imeProizvoda;
            this.kolicina = kolicina;
            this.kategorija = kategorija;
        }

        public Proizvod()
        {
        }
    }
}
