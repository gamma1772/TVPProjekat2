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

namespace TVPProjekat2.Proizvod
{
    public partial class FormAktivirajProizvod : Form
    {
        private projekatDataSet dataSet;
        private proizvodTableAdapter proizvodDB;
        private FormNoviRacun main;
        public FormAktivirajProizvod(projekatDataSet dataSet, proizvodTableAdapter proizvodDB, FormNoviRacun main)
        {
            InitializeComponent();

            this.dataSet = dataSet;
            this.proizvodDB = proizvodDB;
            this.main = main;

            azurirajTabelu();
        }
        private void azurirajTabelu()
        {
            var linq = from proizvod in dataSet.proizvod where proizvod.aktivno == false select proizvod;

            if (linq.Any())
            {
                dataDeaktivni.DataSource = linq.CopyToDataTable();
            }

            dataDeaktivni.Update();
            dataDeaktivni.Refresh();
        }

        private void aktivirajProizvod(object sender, EventArgs e)
        {
            proizvodDB.Update(dataDeaktivni.SelectedRows[0].Cells[1].Value.ToString(), int.Parse(dataDeaktivni.SelectedRows[0].Cells[2].Value.ToString()), double.Parse(dataDeaktivni.SelectedRows[0].Cells[3].Value.ToString()), int.Parse(dataDeaktivni.SelectedRows[0].Cells[4].Value.ToString()), double.Parse(dataDeaktivni.SelectedRows[0].Cells[5].Value.ToString()), dataDeaktivni.SelectedRows[0].Cells[6].Value.ToString(), true, 
                int.Parse(dataDeaktivni.SelectedRows[0].Cells[0].Value.ToString()), dataDeaktivni.SelectedRows[0].Cells[1].Value.ToString(), int.Parse(dataDeaktivni.SelectedRows[0].Cells[2].Value.ToString()), double.Parse(dataDeaktivni.SelectedRows[0].Cells[3].Value.ToString()), int.Parse(dataDeaktivni.SelectedRows[0].Cells[4].Value.ToString()), double.Parse(dataDeaktivni.SelectedRows[0].Cells[5].Value.ToString()), dataDeaktivni.SelectedRows[0].Cells[6].Value.ToString(), bool.Parse(dataDeaktivni.SelectedRows[0].Cells[7].Value.ToString()));
            proizvodDB.Update(dataSet);
            proizvodDB.Fill(dataSet.proizvod);

            azurirajTabelu();
            main.osveziListu();
        }

        private void close(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            main.FrmAktiviraj = null;
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            close(sender, e);
        }
    }

    
}
