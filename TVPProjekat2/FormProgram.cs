using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public FormProgram(projekatDataSet pds, FormLogin formLogin)
        {
            InitializeComponent();
            this.pds = pds;
            this.frmLogin = formLogin;
        }

        internal void recieveUser(Korisnik korisnik)
        {
            this.prijavljenKorisnik = korisnik;
        }

        private void FormProgram_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projekatDataSet.Racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this.projekatDataSet.Racun);

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

        private void povrat(object sender, EventArgs e)
        {

        }

        private void statistikaProdaje(object sender, EventArgs e)
        {

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

        }
    }
}
