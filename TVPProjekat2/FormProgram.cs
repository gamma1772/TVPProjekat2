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
        projekatDataSetTableAdapters.kategorijaTableAdapter kategorijaDB;
        projekatDataSetTableAdapters.proizvodTableAdapter proizvodDB;
        projekatDataSetTableAdapters.racunTableAdapter racunDB;
        projekatDataSetTableAdapters.racun_proizvodTableAdapter racun_proizvodDB;

        public FormProgram(projekatDataSet pds, FormLogin formLogin)
        {
            InitializeComponent();
            this.pds = pds;
            this.frmLogin = formLogin;

            

            kategorijaDB = new projekatDataSetTableAdapters.kategorijaTableAdapter();
            proizvodDB = new projekatDataSetTableAdapters.proizvodTableAdapter();
            racunDB = new projekatDataSetTableAdapters.racunTableAdapter();
            racun_proizvodDB = new projekatDataSetTableAdapters.racun_proizvodTableAdapter();

            kategorijaDB.Fill(pds.kategorija);
            proizvodDB.Fill(pds.proizvod);
            racunDB.Fill(pds.racun);
            racun_proizvodDB.Fill(pds.racun_proizvod);

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
            string id = "";
            foreach (DataRow item in dataRacuni.SelectedRows)
            {
                id = item.ItemArray[0].ToString();
            }
            var linq = from racun in pds.racun where racun.ID.Equals(id) select racun;
            foreach (var item in linq)
            {
                item.storniran = true;
                item.AcceptChanges();
            }
            pds.AcceptChanges();
            racunDB.Update(pds.racun);
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
            var linq = from racun in pds.racun 
                       where racun.datum_izdavanja.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy") 
                       select racun;
            var storniraniLinq = from racun in pds.racun
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