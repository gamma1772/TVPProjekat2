using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using TVPProjekat2.projekatDataSetTableAdapters;

namespace TVPProjekat2
{
    public partial class FormNoviRacun : Form
    {
        projekatDataSet dataSet;
        racunTableAdapter racunDB;
        racun_proizvodTableAdapter racunProizvodDB;
        proizvodTableAdapter proizvodDB;
        kategorijaTableAdapter kategorijaDB;

        private string ID;
        private double iznosRacuna = 0.00D;
        public FormNoviRacun(projekatDataSet dataSet, proizvodTableAdapter proizvodDB, kategorijaTableAdapter kategorijaDB, racunTableAdapter racunDB, racun_proizvodTableAdapter racunProizvodDB, FormProgram frmProgram)
        {
            InitializeComponent();
            ID = generateID();
            this.txtIDRacuna.Text = ID;
            this.txtProdavac.Text = frmProgram.prijavljenKorisnik.UUID;
            this.dataSet = dataSet;
            this.racunDB = racunDB;
            this.racunProizvodDB = racunProizvodDB;
            this.proizvodDB = proizvodDB;
            this.kategorijaDB = kategorijaDB;

            this.txtIznos.Text = iznosRacuna.ToString("0.00");
            osveziListu();
        }

        private void osveziListu()
        {
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
                    var linqProizvodjac = from proizvod in dataSet.proizvod where (from proizvodjac in dataSet.proizvodjac where proizvod.proizvodjac == proizvodjac.ID select proizvodjac.naziv).ElementAt(0).Contains(txtPretraga.Text) select proizvod;
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
                    var linqProizvodjac = from proizvodjac in dataSet.proizvodjac where proizvodjac.ID == item.proizvodjac select proizvodjac;

                    string kategorijaString = linqKategorija.ElementAt(0).ime;
                    string proizvodjacString = linqProizvodjac.ElementAt(0).naziv;
                    string[] vals = { item.ID.ToString(), item.bar_kod.ToString(), item.ime.ToString(), proizvodjacString, kategorijaString, item.kolicina.ToString(), item.cena.ToString("0.00") };
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

        //Na dodavanje u listRacun potrebno je umanjiti kolicinu proizvoda za vrednost iz txtKolicina.
        //Ako proizvod nije na stanju, izbaciti gresku.
        private void dodajProizvod(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listProizvodi.SelectedItems)
            {
                ListViewItem clone = (ListViewItem)item.Clone();
                if (int.Parse(item.SubItems[5].Text) > 0 && !txtKolicina.Text.Equals(""))
                {
                    
                    clone.SubItems[5].Text = txtKolicina.Text;
                    listRacun.Items.Add(clone);

                    var linq = from kategorija in dataSet.kategorija where item.SubItems[4].Text == kategorija.ime select kategorija.ID;
                    var linq2 = from proizvodjac in dataSet.proizvodjac where item.SubItems[3].Text == proizvodjac.naziv select proizvodjac.ID;

                    proizvodDB.Update(item.SubItems[2].Text, linq2.ElementAt(0), (short?)(short.Parse(item.SubItems[5].Text) - short.Parse(txtKolicina.Text)), linq.ElementAt(0), double.Parse(item.SubItems[6].Text), item.SubItems[1].Text,
                        int.Parse(item.SubItems[0].Text), item.SubItems[2].Text, linq2.ElementAt(0), short.Parse(item.SubItems[5].Text), linq.ElementAt(0), double.Parse(item.SubItems[6].Text), item.SubItems[1].Text);
                    proizvodDB.Update(dataSet);
                    proizvodDB.Fill(dataSet.proizvod);
                    iznosRacuna += double.Parse(item.SubItems[6].Text) * int.Parse(txtKolicina.Text);
                    osveziListu();
                    txtKolicina.Clear();
                }
                else
                {
                    if (!txtKolicina.Text.Equals(""))
                    {
                        MessageBox.Show("Proizvod više nije na stanju.", "Račun", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        MessageBox.Show("Niste uneli količinu.", "Račun", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            txtIznos.Text = iznosRacuna.ToString("0.00");
        }

        private void izbaciproizvod(object sender, EventArgs e)
        {
            if (listRacun.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listRacun.SelectedItems)
                {
                    var linq = from kategorija in dataSet.kategorija where item.SubItems[4].Text == kategorija.ime select kategorija.ID;
                    var linq2 = from proizvodjac in dataSet.proizvodjac where item.SubItems[3].Text == proizvodjac.naziv select proizvodjac.ID;
                    var linq3 = from proizvod in dataSet.proizvod where int.Parse(item.SubItems[0].Text) == proizvod.ID select proizvod.kolicina;

                    proizvodDB.Update(item.SubItems[2].Text, linq2.ElementAt(0), (short?)(short.Parse(item.SubItems[5].Text) + short.Parse(linq3.ElementAt(0).ToString())), linq.ElementAt(0), double.Parse(item.SubItems[6].Text), item.SubItems[1].Text,
                        int.Parse(item.SubItems[0].Text), item.SubItems[2].Text, linq2.ElementAt(0), short.Parse(linq3.ElementAt(0).ToString()), linq.ElementAt(0), double.Parse(item.SubItems[6].Text), item.SubItems[1].Text);
                    proizvodDB.Update(dataSet);
                    proizvodDB.Fill(dataSet.proizvod);

                    iznosRacuna -= double.Parse(item.SubItems[6].Text) * int.Parse(item.SubItems[5].Text);

                    listRacun.Items.Remove(item);

                    osveziListu();
                }
                txtIznos.Text = iznosRacuna.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Niste odabrali stavku sa liste 'Račun'.", "Račun", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
