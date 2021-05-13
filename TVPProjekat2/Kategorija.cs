using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVPProjekat2
{
    class Kategorija
    {
        private int idKategorije;
        private string imeKategorije;

        public int IdKategorije { get => idKategorije; set => idKategorije = value; }
        public string ImeKategorije { get => imeKategorije; set => imeKategorije = value; }

        public Kategorija(int idKategorije, string imeKategorije)
        {
            this.IdKategorije = idKategorije;
            this.ImeKategorije = imeKategorije;
        }

        public Kategorija(string imeKategorije)
        {
            ImeKategorije = imeKategorije;
        }

        public Kategorija()
        {
        }
    }
}
