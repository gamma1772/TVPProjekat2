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

namespace TVPProjekat2.Proizvod.Proizvodjac
{
    public partial class FormListaProizvodjaca : Form
    {
        private projekatDataSet dataSet;
        private proizvodjacTableAdapter proizvodjacDB;
        private proizvodTableAdapter proizvodDB;
        private FormProgram main;

        private FormNoviProizvodjac frmNovi;
        private FormIzmeniProizvodjaca frmIzmeni;
        public FormListaProizvodjaca(projekatDataSet dataSet, proizvodjacTableAdapter proizvodjacDB, proizvodTableAdapter proizvodDB, FormProgram main)
        {
            InitializeComponent();

            this.dataSet = dataSet;
            this.proizvodjacDB = proizvodjacDB;
            this.proizvodDB = proizvodDB;

            this.main = main;

            azurirajTabelu();
        }

        public FormNoviProizvodjac FrmNovi { get => frmNovi; set => frmNovi = value; }
        public FormIzmeniProizvodjaca FrmIzmeni { get => frmIzmeni; set => frmIzmeni = value; }

        private void dodajProizvodjaca(object sender, EventArgs e)
        {
            if (FrmNovi == null)
            {
                FrmNovi = new FormNoviProizvodjac(dataSet, proizvodjacDB, this);
                FrmNovi.Show();
            }
            else
            {
                FrmNovi.Focus();
            }
        }

        private void izmeniProizvodjaca(object sender, EventArgs e)
        {
            if (FrmIzmeni == null)
            {
                FrmIzmeni = new FormIzmeniProizvodjaca(dataSet, proizvodjacDB, dataProizvodjaci.SelectedRows, this);
                FrmIzmeni.Show();
            }
            else
            {
                FrmIzmeni.Focus();
            }
        }

        private void obrisiProizvodjaca(object sender, EventArgs e)
        {
            var linq = from proizvod in dataSet.proizvod where proizvod.proizvodjac == int.Parse(dataProizvodjaci.SelectedRows[0].Cells[0].Value.ToString()) select proizvod;

            if (!linq.Any())
            {
                DialogResult result = MessageBox.Show("Da li želite da obrišete odabranog proizvođača?", "Lista proizvođača", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    proizvodjacDB.Delete(int.Parse(dataProizvodjaci.SelectedRows[0].Cells[0].Value.ToString()), dataProizvodjaci.SelectedRows[0].Cells[1].Value.ToString(), dataProizvodjaci.SelectedRows[0].Cells[2].Value.ToString(), bool.Parse(dataProizvodjaci.SelectedRows[0].Cells[3].Value.ToString()));

                    proizvodjacDB.Update(dataSet);
                    proizvodjacDB.Fill(dataSet.proizvodjac);

                    azurirajTabelu();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Proizvođač je dodeljen proizvodu. Potrebno je da obrišete proizvod ili da mu promenite proizvođača.", "Lista proizvođača", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void azurirajTabelu()
        {
            var linq = from proizvodjac in dataSet.proizvodjac select proizvodjac;

            if (linq.Any())
            {
                dataProizvodjaci.DataSource = linq.CopyToDataTable();
            }

            dataProizvodjaci.Update();
            dataProizvodjaci.Refresh();
        }

        private void close(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            main.FrmKategorije = null;
        }

        private void FormListaProizvodjaca_FormClosed(object sender, FormClosedEventArgs e)
        {
            close(sender, e);
        }
    }
}
