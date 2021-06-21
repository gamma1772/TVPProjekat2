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
using TVPProjekat2.projekatDataSetTableAdapters;

namespace TVPProjekat2
{
    public partial class FormRacuni : Form
    {
        private projekatDataSet dataSet;
        private racunTableAdapter racunDB;
        private racun_proizvodTableAdapter racunProizvodDB;
        private proizvodTableAdapter proizvodDB;
        private FormProgram main;
        public FormRacuni(projekatDataSet dataSet, racunTableAdapter racunDB, racun_proizvodTableAdapter racunProizvodDB, proizvodTableAdapter proizvodDB, FormProgram main)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            this.racunDB = racunDB;
            this.racunProizvodDB = racunProizvodDB;
            this.proizvodDB = proizvodDB;
            this.main = main;
            var linq = from racun in dataSet.racun select racun;
            azurirajTabelu(linq);
        }

        private void advSearch(object sender, EventArgs e)
        {

        }

        private void storniraj(object sender, EventArgs e)
        {
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
                var linq = from racunProizvod in dataSet.racun_proizvod
                           where racunProizvod.RacunID.Equals(item.Cells[0].Value.ToString())
                           select racunProizvod;
                foreach (var item2 in linq)
                {
                    cmd2.CommandText = "UPDATE Proizvod SET kolicina = kolicina + " + item2.Kolicina + " WHERE ID = " + item2.ProizvodID;
                    cmd2.ExecuteNonQuery();
                }
            }

            racunDB.Update(dataSet);
            proizvodDB.Update(dataSet);
            dataRacuni.Update();
            dataRacuni.Refresh();
            racunDB.Connection.Close();
            proizvodDB.Connection.Close();
        }

        private void prikazi(object sender, EventArgs e)
        {

        }

        private void obrisi(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Brisanjem računa se gubi evidencija i statistika prodaje nekih proizvoda. Da li sigurno želite da obrišete račun?", "Brisanje računa", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (result == DialogResult.Yes)
            {
                racunDB.Connection.Open(); //Konekcija se otvara jer je potrebno koristiti OleDbCommand()
                proizvodDB.Connection.Open();
                racunProizvodDB.Connection.Open();

                OleDbCommand cmd = new OleDbCommand
                {
                    Connection = proizvodDB.Connection
                };

                OleDbCommand cmdRacun = new OleDbCommand
                {
                    Connection = racunDB.Connection
                };

                OleDbCommand cmdRacunProizvod = new OleDbCommand
                {
                    Connection = racunProizvodDB.Connection
                };
                foreach (DataGridViewRow item in dataRacuni.SelectedRows)
                {
                    var linq = from racunProizvod in dataSet.racun_proizvod
                               where racunProizvod.RacunID.Equals(item.Cells[0].Value.ToString())
                               select racunProizvod;
                    foreach (var item2 in linq)
                    {
                        if (!bool.Parse(item.Cells[4].Value.ToString()))
                        {
                            cmd.CommandText = "UPDATE Proizvod SET kolicina = kolicina + " + item2.Kolicina + " WHERE ID = " + item2.ProizvodID;
                            cmd.ExecuteNonQuery();
                        }

                        cmdRacunProizvod.CommandText = "DELETE FROM racun_proizvod WHERE RacunID = '" + item2.RacunID + "' AND ProizvodID = " + item2.ProizvodID;
                        cmdRacunProizvod.ExecuteNonQuery();
                    }

                    cmdRacun.CommandText = "DELETE FROM Racun WHERE ID = '" + item.Cells[0].Value.ToString() + "'";
                    cmdRacun.ExecuteNonQuery();
                }

                racunDB.Connection.Close();
                proizvodDB.Connection.Close();
                racunProizvodDB.Connection.Close();

                racunDB.Update(dataSet); racunDB.Fill(dataSet.racun);
                proizvodDB.Update(dataSet); proizvodDB.Fill(dataSet.proizvod);
                racunProizvodDB.Update(dataSet); racunProizvodDB.Fill(dataSet.racun_proizvod);

                var linqFinal = from racun in dataSet.racun select racun;
                azurirajTabelu(linqFinal);
            }
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
