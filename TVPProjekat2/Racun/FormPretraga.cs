using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPProjekat2
{
    public partial class FormPretraga : Form
    {
        private DataGridView dataGrid;
        private projekatDataSet dataSet;
        private FormRacuni mainProgram;

        public FormPretraga(DataGridView dataGrid, projekatDataSet dataSet, FormRacuni main)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
            this.dataSet = dataSet;
            this.mainProgram = main;
        }

        public void GlobalRBChange(object sender, EventArgs e)
        {

            if (rbOpseg.Checked)
            {
                dateOd.Enabled = true;
                dateDo.Enabled = true;
            } else
            {
                dateOd.Enabled = true;
                dateDo.Enabled = true;
            }

            if (rbDatum.Checked)
            {
                dateOdredjeno.Enabled = true;
            }
            else
            {
                dateOdredjeno.Enabled = false;
            }
        }

        private void FormClosedEvent(object sender, FormClosedEventArgs e)
        {
            close(sender, e);
        }

        private void pokreniPretragu(object sender, EventArgs e)
        {
            if (txtKeyword.Text != null)
            {
                if (rbAll.Checked)
                {
                    var linq = from racun in dataSet.racun where racun.ID.Contains(txtKeyword.Text) || racun.korisnik.Contains(txtKeyword.Text) ||
                                                                      (from p in dataSet.proizvod where (from rp in dataSet.racun_proizvod where racun.ID.Equals(rp.RacunID) select rp.ProizvodID).Contains(p.ID) select p.ime).Contains(txtKeyword.Text) ||
                                                                      (from m in dataSet.proizvodjac where (from p in dataSet.proizvod where (from rp in dataSet.racun_proizvod where racun.ID.Equals(rp.RacunID) select rp.ProizvodID).Contains(p.ID) select p.proizvodjac).Contains(m.ID) select m.naziv).Contains(txtKeyword.Text)
                               select racun;
                    mainProgram.azurirajTabelu(linq);
                }
                else if (rbDanas.Checked)
                {
                    var linqDanas = from racun in dataSet.racun where (racun.datum_izdavanja.Year.Equals(DateTime.Now.Year) && racun.datum_izdavanja.Month.Equals(DateTime.Now.Month) && racun.datum_izdavanja.Day.Equals(DateTime.Now.Day)) && (racun.ID.Contains(txtKeyword.Text) || racun.korisnik.Contains(txtKeyword.Text) ||
                                                                      (from p in dataSet.proizvod where (from rp in dataSet.racun_proizvod where racun.ID.Equals(rp.RacunID) select rp.ProizvodID).Contains(p.ID) select p.ime).Contains(txtKeyword.Text) ||
                                                                      (from m in dataSet.proizvodjac where (from p in dataSet.proizvod where (from rp in dataSet.racun_proizvod where racun.ID.Equals(rp.RacunID) select rp.ProizvodID).Contains(p.ID) select p.proizvodjac).Contains(m.ID) select m.naziv).Contains(txtKeyword.Text))

                                    select racun;
                    mainProgram.azurirajTabelu(linqDanas);
                }
                else if (rbDatum.Checked)
                {
                    var linqDatum = from racun in dataSet.racun where (racun.datum_izdavanja.Year.Equals(dateOdredjeno.Value.Year) && racun.datum_izdavanja.Month.Equals(dateOdredjeno.Value.Month) && racun.datum_izdavanja.Day.Equals(dateOdredjeno.Value.Day)) && (racun.ID.Contains(txtKeyword.Text) || racun.korisnik.Contains(txtKeyword.Text) ||
                                                                      (from p in dataSet.proizvod where (from rp in dataSet.racun_proizvod where racun.ID.Equals(rp.RacunID) select rp.ProizvodID).Contains(p.ID) select p.ime).Contains(txtKeyword.Text) ||
                                                                      (from m in dataSet.proizvodjac where (from p in dataSet.proizvod where (from rp in dataSet.racun_proizvod where racun.ID.Equals(rp.RacunID) select rp.ProizvodID).Contains(p.ID) select p.proizvodjac).Contains(m.ID) select m.naziv).Contains(txtKeyword.Text))
                                    select racun;
                    mainProgram.azurirajTabelu(linqDatum);
                }
                else if (rbOpseg.Checked)
                {
                    var linqOpseg = from racun 
                                    in dataSet.racun 
                                                                where ((racun.datum_izdavanja.Year >= dateOd.Value.Year && racun.datum_izdavanja.Year <= dateDo.Value.Year)) && 
                                                                      ((racun.datum_izdavanja.Month >= dateOd.Value.Month && racun.datum_izdavanja.Month <= dateDo.Value.Month)) && 
                                                                      ((racun.datum_izdavanja.Day >= dateOd.Value.Day && racun.datum_izdavanja.Day <= dateDo.Value.Day)) && 
                                                                      (racun.ID.Contains(txtKeyword.Text) || racun.korisnik.Contains(txtKeyword.Text) ||
                                                                      (from p in dataSet.proizvod where (from rp in dataSet.racun_proizvod where racun.ID.Equals(rp.RacunID) select rp.ProizvodID).Contains(p.ID) select p.ime).Contains(txtKeyword.Text)) ||
                                                                      (from m in dataSet.proizvodjac where (from p in dataSet.proizvod where (from rp in dataSet.racun_proizvod where racun.ID.Equals(rp.RacunID) select rp.ProizvodID).Contains(p.ID) select p.proizvodjac).Contains(m.ID) select m.naziv).Contains(txtKeyword.Text)
                                    select racun;
                    mainProgram.azurirajTabelu(linqOpseg);
                }
            }
            close(sender, e);
        }
        private void close(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

            mainProgram.FrmPretraga = null;
        }
    }
}
