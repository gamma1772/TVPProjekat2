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
        private projekatDataSet projekatData;
        private FormProgram mainProgram;

        public FormPretraga(DataGridView dataGrid, projekatDataSet projekatData, FormProgram main)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
            this.projekatData = projekatData;
            this.mainProgram = main;
        }

        public void GlobalRBChange(object sender, EventArgs e)
        {
            if (rbAll.Checked)
            {

            } else if (rbDanas.Checked)
            {

            }

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
            this.Dispose();
            this.Close();
            mainProgram.FrmPretraga = null;
        }
    }
}
