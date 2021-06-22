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

namespace TVPProjekat2.Racun
{
    public partial class FormPrikazRacuna : Form
    {
        string racunID;
        projekatDataSet dataSet;
        FormRacuni main;
        FormProgram program;
        public FormPrikazRacuna(string racunID, projekatDataSet dataSet, FormRacuni main)
        {
            InitializeComponent();
            this.racunID = racunID;
            this.dataSet = dataSet;
            this.main = main;

            popuniFormu();
        }

        public FormPrikazRacuna(string racunID, projekatDataSet dataSet, FormProgram program)
        {
            InitializeComponent();
            this.racunID = racunID;
            this.dataSet = dataSet;
            this.program = program;

            popuniFormu();
        }

        private void popuniFormu()
        {
            listProizvodi.Items.Clear();

            var linq = from racun in dataSet.racun where racun.ID.Equals(racunID) select racun;
            var linqKorisnik = from korisnik in dataSet.korisnik where korisnik.UUID.Equals(linq.ElementAt(0).korisnik) select korisnik.UUID;
            txtID.Text = racunID;
            txtProdavac.Text = linqKorisnik.ElementAt(0);
            txtCena.Text = linq.ElementAt(0).cena.ToString("0.00");
            txtDate.Text = linq.ElementAt(0).datum_izdavanja.ToString("dd/MM/yyyy HH:mm:ss");

            var linqRP = from rp in dataSet.racun_proizvod where rp.RacunID.Equals(txtID.Text) select rp.ProizvodID;
            foreach (var item0 in linqRP)
            {
                var linqProizvod = from proizvod in dataSet.proizvod where item0.Equals(proizvod.ID) select proizvod;
                foreach (var item in linqProizvod)
                {
                    var linqKategorija = from kategorija in dataSet.kategorija where kategorija.ID == item.kategorija select kategorija.ime;
                    var linqProizvodjac = from proizvodjac in dataSet.proizvodjac where proizvodjac.ID == item.proizvodjac select proizvodjac.naziv;

                    var linq4 = from racun_proizvod in dataSet.racun_proizvod where racun_proizvod.RacunID.Equals(txtID.Text) && item.ID.Equals(racun_proizvod.ProizvodID) select racun_proizvod.Kolicina;

                    string[] vals = { item.ID.ToString(), item.bar_kod.ToString(), item.ime.ToString(), linqProizvodjac.ElementAt(0), linqKategorija.ElementAt(0), linq4.ElementAt(0).ToString("0.00"), item.cena.ToString("0.00") };
                    ListViewItem proizvod = new ListViewItem(vals);
                    listProizvodi.Items.Add(proizvod);
                }
            }
        }

        private void close(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

            if (main != null)
            {
                main.FrmPrikaz = null;
            }
            else
            {
                program.FrmPrikaziRacun = null;
            }
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            close(sender, e);
        }
    }
}
