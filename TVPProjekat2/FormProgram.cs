using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPProjekat2
{
    public partial class FormProgram : Form
    {
        private Korisnik prijavljenKorisnik;
        private FormLogin frmLogin;
        projekatDataSet pds;
        projekatDataSetTableAdapters.KategorijaTableAdapter kategorijaDB;
        projekatDataSetTableAdapters.ProizvodTableAdapter proizvodDB;
        projekatDataSetTableAdapters.RacunTableAdapter racunDB;

        public FormProgram(projekatDataSet pds, FormLogin formLogin)
        {
            InitializeComponent();
            this.pds = pds;
            this.frmLogin = formLogin;

            kategorijaDB = new projekatDataSetTableAdapters.KategorijaTableAdapter();
            proizvodDB = new projekatDataSetTableAdapters.ProizvodTableAdapter();
            racunDB = new projekatDataSetTableAdapters.RacunTableAdapter();

            kategorijaDB.Fill(pds.Kategorija);
            proizvodDB.Fill(pds.Proizvod);
            racunDB.Fill(pds.Racun);

            azurirajTabele();
        }

        internal void recieveUser(Korisnik korisnik)
        {
            this.prijavljenKorisnik = korisnik;
        }

        private void izlazIzPrograma(object sender, EventArgs e)
        {
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
            FormStatistika frmStatistika = new FormStatistika();
            frmStatistika.Show();
        }

        private void noviRacun(object sender, EventArgs e)
        {

        }

        private void pogledajSveRacune(object sender, EventArgs e)
        {

        }

        private void stampajRacun(object sender, EventArgs e)
        {

        }

        private void prikaziListuProizvoda(object sender, EventArgs e)
        {

        }

        private void prikaziListuKategorija(object sender, EventArgs e)
        {

        }

        private void PrikaziUputstvo(object sender, EventArgs e)
        {

        }

        private void prikaziInformacijeOProjektu(object sender, EventArgs e)
        {

        }

        private void izmeniRacun(object sender, EventArgs e)
        {

        }

        private void stornirajSelektovano(object sender, EventArgs e)
        {
        }

        private void obrisiSelektovano(object sender, EventArgs e)
        {

        }

        private void pretraga(object sender, EventArgs e)
        {
            FormPretraga pretraga = new FormPretraga();
            pretraga.Show();
        }

        private void azurirajTabele()
        {
            var linq = from racun in pds.Racun 
                       where racun.datum_izdavanja.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy") 
                       select racun;
            if (linq.Any())
            {
                dataRacuni.DataSource = linq.CopyToDataTable();
                dataRacuni.Columns["korisnik"].Visible = false;
                dataRacuni.Columns["storniran"].Visible = false;
            }
        }

        private void izlazIzProgramaForm(object sender, FormClosedEventArgs e)
        {
            izlazIzPrograma(sender, e);
        }

        private void trebovanje(object sender, EventArgs e)
        {

        }
    }
}
