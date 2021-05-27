using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TVPProjekat2
{
    public partial class FormProgram : Form
    {
        private FormListaKategorija frmKategorije;
        private FormListaProizvoda frmProizvodi;
        private FormNoviRacun frmNoviRacun;
        private FormOProjektu frmOProjektu;
        private FormPretraga frmPretraga;
        private FormRacuni frmRacuni;
        private FormStampanjeRacuna frmStampanjeRacuna;
        private FormStatistika frmStatistika;
        private FormTrebovanje frmTrebovanje;
        private FormUputstvo frmUputstvo;

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
            frmStatistika = new FormStatistika();
            frmStatistika.Show();
        }

        private void noviRacun(object sender, EventArgs e)
        {
            frmNoviRacun = new FormNoviRacun();
            frmNoviRacun.Show();
        }

        private void pogledajSveRacune(object sender, EventArgs e)
        {
            frmRacuni = new FormRacuni();
            frmRacuni.Show();
        }

        private void stampajRacun(object sender, EventArgs e)
        {
            frmStampanjeRacuna = new FormStampanjeRacuna();
            frmStampanjeRacuna.Show();
        }

        private void prikaziListuProizvoda(object sender, EventArgs e)
        {
            frmProizvodi = new FormListaProizvoda();
            frmProizvodi.Show();
        }

        private void prikaziListuKategorija(object sender, EventArgs e)
        {
            frmKategorije = new FormListaKategorija();
            frmKategorije.Show();
        }

        private void PrikaziUputstvo(object sender, EventArgs e)
        {
            FormUputstvo frmUputstvo = new FormUputstvo();
            frmUputstvo.Show();
        }

        private void prikaziInformacijeOProjektu(object sender, EventArgs e)
        {
            FormOProjektu oProjektu = new FormOProjektu();
            oProjektu.Show();
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
            var storniraniLinq = from racun in pds.Racun
                                 where racun.datum_izdavanja.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy") && racun.storniran
                                 select racun;
            if (linq.Any())
            {
                dataRacuni.DataSource = linq.CopyToDataTable();
                dataRacuni.Columns["korisnik"].Visible = false;
                dataRacuni.Columns["storniran"].Visible = false;
            }
            if (storniraniLinq.Any())
            {
                dataStornirani.DataSource = storniraniLinq.CopyToDataTable();
            }
        }

        private void izlazIzProgramaForm(object sender, FormClosedEventArgs e)
        {
            izlazIzPrograma(sender, e);
        }

        private void trebovanje(object sender, EventArgs e)
        {
            frmTrebovanje = new FormTrebovanje();
            frmTrebovanje.Show();
        }

        private void formLoadEvent(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = prijavljenKorisnik.UUID;
        }
    }
}