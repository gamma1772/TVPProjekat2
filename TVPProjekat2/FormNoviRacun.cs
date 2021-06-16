using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVPProjekat2.projekatDataSetTableAdapters;

namespace TVPProjekat2
{
    public partial class FormNoviRacun : Form
    {
        projekatDataSet dataSet;
        private string ID;
        public FormNoviRacun(projekatDataSet dataSet, proizvodTableAdapter proizvodDB, kategorijaTableAdapter kategorijaDB, racunTableAdapter racunDB, racun_proizvodTableAdapter racunProizvodDB, FormProgram frmProgram)
        {
            InitializeComponent();
            ID = generateID();
            this.txtIDRacuna.Text = ID;
            this.txtProdavac.Text = frmProgram.prijavljenKorisnik.UUID;
            this.dataSet = dataSet;
            var linq = from proizvod in dataSet.proizvod select proizvod;
            populateListProizvod(linq);
        }

        private void autoPretraga(object sender, EventArgs e)
        {
            if (txtPretraga.Text != null || txtPretraga.Text != "")
            {
                if (rbBarKod.Checked)
                {
                    var linqBarKod = from proizvod in dataSet.proizvod where proizvod.bar_kod.Contains(txtPretraga.Text) select proizvod;
                    populateListProizvod(linqBarKod);
                } else if (rbKategorija.Checked)
                {
                    //Podupit ovog LINQ upita ne mora da se proverava, jer svaki proizvod 100% uvek ima kategoriju.
                    var linqKategorija = from proizvod in dataSet.proizvod where (from kategorija in dataSet.kategorija where proizvod.kategorija == kategorija.ID select kategorija.ime).ElementAt(0).Contains(txtPretraga.Text) select proizvod;
                    populateListProizvod(linqKategorija);
                }
                else if(rbProizvodjac.Checked)
                {
                    var linqProizvodjac = from proizvod in dataSet.proizvod where proizvod.proizvodjac.Contains(txtPretraga.Text) select proizvod;
                    populateListProizvod(linqProizvodjac);
                } else if (rbNaziv.Checked)
                {
                    var linqNaziv = from proizvod in dataSet.proizvod where proizvod.ime.Contains(txtPretraga.Text) select proizvod;
                    populateListProizvod(linqNaziv);
                }
            }
        }

        private void populateListProizvod(EnumerableRowCollection<projekatDataSet.proizvodRow> linq)
        {
            listProizvodi.Items.Clear();
            if (linq.Any())
            {
                foreach (var item in linq)
                {
                    var linqKategorija = from kategorija in dataSet.kategorija where kategorija.ID == item.kategorija select kategorija;
                    string kategorijaString = linqKategorija.ElementAt(0).ime;
                    string[] vals = { item.ID.ToString(), item.bar_kod.ToString(), item.ime.ToString(), item.proizvodjac.ToString(), kategorijaString, item.kolicina.ToString(), item.cena.ToString("0.00") };
                    ListViewItem proizvod = new ListViewItem(vals);
                    listProizvodi.Items.Add(proizvod);
                }
            }
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
            return DateTime.Now.ToString("ddMMyyyy") + random.Next(1000, 7000).ToString();
        }
    }
}
