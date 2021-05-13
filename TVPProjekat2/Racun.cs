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
        private int key;
        private string iD;
        private DateTime dateTime;
        private List<Proizvod> proizvodi;
        private double cena;

        public string ID { get => ID; set => ID = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        internal List<Proizvod> Proizvodi { get => proizvodi; set => proizvodi = value; }
        public double Cena { get => cena; set => cena = value; }
        public String GenerateID { get => generateID(); }

        public Racun(string iD, DateTime dateTime, List<Proizvod> proizvodi, double cena)
        {
            this.ID = iD;
            this.DateTime = dateTime;
            this.Proizvodi = proizvodi;
            this.Cena = cena;
        }

        public Racun(DateTime dateTime, List<Proizvod> proizvodi, double cena)
        {
            this.ID = this.GenerateID;
            this.DateTime = dateTime;
            this.Proizvodi = proizvodi;
            this.Cena = cena;
        }

        public Racun()
        {
            this.ID = "";
            this.DateTime = new DateTime();
            this.Proizvodi = new List<Proizvod>();
            this.Cena = 0.0D;
        }

        private String generateID()
        {
            Random random = new Random(int.Parse(DateTime.Now.ToString("HHmmssffff")));
            return DateTime.Now.ToString("HHmmssff") + random.Next(1000, 7000).ToString();
        }
    }
}
