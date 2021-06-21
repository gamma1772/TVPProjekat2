using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVPProjekat2.Proizvod.Proizvodjac;

namespace TVPProjekat2
{
    public partial class FormProgram : Form
    {
        

        private FormListaKategorija frmKategorije;
        private FormListaProizvoda frmProizvodi;
        private FormNoviRacun frmNoviRacun;
        private FormRacuni frmRacuni;
        private FormStatistika frmStatistika;
        private FormListaProizvodjaca frmProizvodjaci;

        internal Korisnik prijavljenKorisnik;
        private FormLogin frmLogin;
        projekatDataSet pds;
        projekatDataSetTableAdapters.kategorijaTableAdapter kategorijaDB;
        projekatDataSetTableAdapters.proizvodTableAdapter proizvodDB;
        projekatDataSetTableAdapters.proizvodjacTableAdapter proizvodjacDB;
        projekatDataSetTableAdapters.racunTableAdapter racunDB;
        projekatDataSetTableAdapters.racun_proizvodTableAdapter racun_proizvodDB;

        //private Thread DBThread;
        //private Task DBUpdateTask;
        //private Task DBTask;

        public FormListaKategorija FrmKategorije { get => frmKategorije; set => frmKategorije = value; }
        public FormListaProizvoda FrmProizvodi { get => frmProizvodi; set => frmProizvodi = value; }
        public FormNoviRacun FrmNoviRacun { get => frmNoviRacun; set => frmNoviRacun = value; }
        public FormRacuni FrmRacuni { get => frmRacuni; set => frmRacuni = value; }
        public FormStatistika FrmStatistika { get => frmStatistika; set => frmStatistika = value; }
        public FormListaProizvodjaca FrmProizvodjaci { get => frmProizvodjaci; set => frmProizvodjaci = value; }

        public FormProgram(projekatDataSet pds, FormLogin formLogin)
        {
            InitializeComponent();
            this.pds = pds;
            this.frmLogin = formLogin;

            startAdapters();
            azurirajTabele();
        }

        private void startAdapters()
        {
            kategorijaDB = new projekatDataSetTableAdapters.kategorijaTableAdapter();
            proizvodDB = new projekatDataSetTableAdapters.proizvodTableAdapter();
            proizvodjacDB = new projekatDataSetTableAdapters.proizvodjacTableAdapter();
            racunDB = new projekatDataSetTableAdapters.racunTableAdapter();
            racun_proizvodDB = new projekatDataSetTableAdapters.racun_proizvodTableAdapter();
        }

        internal void recieveUser(Korisnik korisnik)
        {
            this.prijavljenKorisnik = korisnik;
        }

        private void izlazIzPrograma(object sender, EventArgs e)
        {
            azurirajDB();
            this.Dispose();
            this.Close();
            Application.Exit();
        }

        private void odjava(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            this.frmLogin.Show();
        }

        private void statistikaProdaje(object sender, EventArgs e)
        {
            if (FrmStatistika == null)
            {
                FrmStatistika = new FormStatistika();
                FrmStatistika.Show();
            }
            else
            {
                FrmStatistika.Focus();
            }
        }

        private void noviRacun(object sender, EventArgs e)
        {
            FrmNoviRacun = new FormNoviRacun(pds, proizvodDB, kategorijaDB, racunDB, racun_proizvodDB, proizvodjacDB, this);
            FrmNoviRacun.Show();
        }

        private void pogledajSveRacune(object sender, EventArgs e)
        {
            if (FrmRacuni == null)
            {
                FrmRacuni = new FormRacuni(pds, racunDB, racun_proizvodDB, proizvodDB, this);
                FrmRacuni.Show();
            }
            else
            {
                FrmRacuni.Focus();
            }
            
        }

        private void prikaziListuProizvoda(object sender, EventArgs e)
        {
            if (FrmProizvodi == null)
            {
                FrmProizvodi = new FormListaProizvoda(pds, proizvodDB, proizvodjacDB, kategorijaDB, this);
                FrmProizvodi.Show();
            }
            else
            {
                FrmProizvodi.Focus();
            }
            
        }

        private void prikaziListuKategorija(object sender, EventArgs e)
        {
            if (FrmKategorije == null)
            {
                FrmKategorije = new FormListaKategorija(pds, kategorijaDB, proizvodDB, this);
                FrmKategorije.Show();
            }
            else
            {
                FrmKategorije.Focus();
            }
        }

        private void izmeniRacun(object sender, EventArgs e)
        {
            azurirajTabele();
        }

        /// <summary>
        /// Stornira racune koji su selektovani u DataGridView za racune (dataRacun) klikom na dugme.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Dogadjaj</param>
        private void stornirajSelektovano(object sender, EventArgs e)
        {
            //DataTable table = (DataTable)(dataRacuni.DataSource);

            racunDB.Connection.Open(); //Konekcija se otvara jer je potrebno koristiti OleDbCommand()
            proizvodDB.Connection.Open();
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = racunDB.Connection
            };

            OleDbCommand cmd2 = new OleDbCommand
            {
                Connection = proizvodDB.Connection
            };
            foreach (DataGridViewRow item in dataRacuni.SelectedRows)
            {
                cmd.CommandText = "UPDATE Racun SET storniran = TRUE WHERE ID = '" + item.Cells[0].Value + "'";
                cmd.ExecuteNonQuery();
                var linq = from racunProizvod in pds.racun_proizvod
                           where racunProizvod.RacunID.Equals(item.Cells[0].Value.ToString()) 
                           select racunProizvod;
                foreach (var item2 in linq)
                {
                    cmd2.CommandText = "UPDATE Proizvod SET kolicina = kolicina + " + item2.Kolicina + " WHERE ID = " + item2.ProizvodID;
                    cmd2.ExecuteNonQuery();
                }
            }
            
            racunDB.Update(pds);
            proizvodDB.Update(pds);
            azurirajTabele();
            racunDB.Connection.Close();
            proizvodDB.Connection.Close();
        }

        private void obrisiSelektovano(object sender, EventArgs e)
        {
            if (dataStornirani.SelectedRows.Count > 0)
            {
                var linq = from racun in pds.racun where racun.ID == dataStornirani.SelectedRows[0].Cells[0].Value.ToString() select racun;
                if (linq.Any())
                {
                    racunDB.Delete(linq.ElementAt(0).ID, linq.ElementAt(0).korisnik, linq.ElementAt(0).datum_izdavanja, linq.ElementAt(0).cena, linq.ElementAt(0).storniran);
                    racunDB.Update(pds);
                }
                azurirajTabele();
            }
            
        }

        /// <summary>
        /// Funkcija azurira tabele. Koristi linq query za proveravanje tabela, ako neki linq ne vrati ni jednu vrednost, ta tabela se prazni
        /// tako sto se DataSource postavi na null.
        /// </summary>
        internal void azurirajTabele()
        {
            kategorijaDB.Fill(pds.kategorija);
            proizvodDB.Fill(pds.proizvod);
            proizvodjacDB.Fill(pds.proizvodjac);
            racunDB.Fill(pds.racun);
            racun_proizvodDB.Fill(pds.racun_proizvod);
            
            var linq = from racun in pds.racun 
                       where racun.datum_izdavanja.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy") && !racun.storniran
                       select racun;
            var storniraniLinq = from racun in pds.racun
                                 where racun.datum_izdavanja.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy") && racun.storniran
                                 select racun;
            if (linq.Any())
            {
                dataRacuni.DataSource = linq.CopyToDataTable();
                dataRacuni.Columns["storniran"].Visible = false;
                dataRacuni.Update();
                dataRacuni.Refresh();
            }
            else
            {
                dataRacuni.DataSource = null; // 'Prazni' DataGridView
            }
            if (storniraniLinq.Any())
            {
                dataStornirani.DataSource = storniraniLinq.CopyToDataTable();
                dataStornirani.Columns["storniran"].Visible = false;
                dataStornirani.Update();
                dataStornirani.Refresh();
            }
            else
            {
                dataStornirani.DataSource = null;
            }
        }

        private void azurirajDB()
        {
            kategorijaDB.Update(pds);
            proizvodDB.Update(pds);
            proizvodjacDB.Update(pds);
            racunDB.Update(pds);
            racun_proizvodDB.Update(pds);
        }

        private void izlazIzProgramaForm(object sender, FormClosedEventArgs e)
        {
            izlazIzPrograma(sender, e);
            
        }

        private void formLoadEvent(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = prijavljenKorisnik.UUID;
        }
        //private void CreateOrFocus(Form form, object type)
        //{
        //    if (form == null)
        //    {
        //        form = (Form) type;
        //        form.Show();
        //    }
        //    else
        //    {
        //        form.Focus();
        //    }
        //}

        private void prikaziListuProizvodjaca(object sender, EventArgs e)
        {
            if (FrmProizvodjaci == null)
            {
                FrmProizvodjaci = new FormListaProizvodjaca(pds, proizvodjacDB, proizvodDB, this);
                FrmProizvodjaci.Show();
            }
            else
            {
                FrmProizvodjaci.Focus();
            }
        }
    }
}