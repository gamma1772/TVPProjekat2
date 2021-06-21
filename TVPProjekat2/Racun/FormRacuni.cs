using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVPProjekat2.projekatDataSetTableAdapters;

namespace TVPProjekat2
{
    public partial class FormRacuni : Form
    {
        private projekatDataSet dataSet;
        private racunTableAdapter racunDB;
        private racun_proizvodTableAdapter racunProizvodDB;
        private FormProgram main;
        public FormRacuni(projekatDataSet dataSet, racunTableAdapter racunDB, racun_proizvodTableAdapter racunProizvodDB, FormProgram main)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.racunDB = racunDB;
            this.racunProizvodDB = racunProizvodDB;
            this.main = main;
            var linq = from racun in dataSet.racun select racun;
            azurirajTabelu(linq);
        }

        private void advSearch(object sender, EventArgs e)
        {

        }

        private void storniraj(object sender, EventArgs e)
        {

        }

        private void prikazi(object sender, EventArgs e)
        {

        }

        private void obrisi(object sender, EventArgs e)
        {

        }

        private void close(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

            main.FrmRacuni = null;
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            close(sender, e);
        }

        private void brzaPretraga(object sender, EventArgs e)
        {
            if (txtPretraga.Text != null)
            {
                var linq = from racun in dataSet.racun where racun.ID.Contains(txtPretraga.Text) select racun;
                azurirajTabelu(linq);
            }
        }

        internal void azurirajTabelu(EnumerableRowCollection<projekatDataSet.racunRow> linq)
        {
            dataRacuni.DataSource = null;
            if (linq.Any())
            {
                dataRacuni.DataSource = linq.CopyToDataTable();
            }

            dataRacuni.Update();
            dataRacuni.Refresh();
        }
    }
}
