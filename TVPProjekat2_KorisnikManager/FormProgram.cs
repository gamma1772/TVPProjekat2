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
using TVPProjekat2_KorisnikManager.projekatDataSetTableAdapters;

namespace TVPProjekat2_KorisnikManager
{
    public partial class FormProgram : Form
    {
        projekatDataSet dataSet;
        korisnikTableAdapter korisnikDB;

        private FormDodaj frmDodaj;
        private FormIzmeni frmIzmeni;

        public FormDodaj FrmDodaj { get => frmDodaj; set => frmDodaj = value; }
        public FormIzmeni FrmIzmeni { get => frmIzmeni; set => frmIzmeni = value; }

        public FormProgram()
        {
            InitializeComponent();
            dataSet = new projekatDataSet();
            korisnikDB = new korisnikTableAdapter();

            update();
        }

        internal void update()
        {
            korisnikDB.Update(dataSet);
            korisnikDB.Fill(dataSet.korisnik);

            var linq = from korisnik in dataSet.korisnik select korisnik;

            if (linq.Any())
            {
                dataKorisnici.DataSource = linq.CopyToDataTable();
            }
            else
            {
                dataKorisnici.DataSource = null;
            }
        }

        private void dodaj(object sender, EventArgs e)
        {
            if (FrmDodaj == null)
            {
                FrmDodaj = new FormDodaj(dataSet, korisnikDB, this);
                FrmDodaj.Show();
            }
            else
            {
                FrmDodaj.Focus();
            }
        }

        private void izmeni(object sender, EventArgs e)
        {
            if (FrmIzmeni == null)
            {
                FrmIzmeni = new FormIzmeni(dataSet, korisnikDB, dataKorisnici.SelectedRows[0], this);
                FrmIzmeni.Show();
            }
            else
            {
                FrmIzmeni.Focus();
            }
        }

        private void obrisi(object sender, EventArgs e)
        {
            korisnikDB.Connection.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE korisnik SET aktivan = NOT aktivan WHERE UUID = '" + dataKorisnici.SelectedRows[0].Cells[0].Value.ToString() + "'", korisnikDB.Connection);
            cmd.ExecuteNonQuery();
            korisnikDB.Connection.Close();
            update();
        }

        private void close(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            close(sender, e);
        }
    }
}
