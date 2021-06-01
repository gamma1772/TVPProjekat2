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
    public partial class FormPretraga : Form
    {
        public delegate void nullifyForm(Form form);

        private DataGridView dataGrid;
        private projekatDataSet projekatData;
        private FormProgram mainProgram;

        private List<RadioButton> rbs;
        public FormPretraga(DataGridView dataGrid, projekatDataSet projekatData, FormProgram main)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
            this.projekatData = projekatData;
            this.mainProgram = main;
            rbs = new List<RadioButton>();

            rbs.Add(rbAll);
            rbs.Add(rbDanas);
            rbs.Add(rbDatum);
            rbs.Add(rbOpseg);
        }

        public void GlobalRBChange(object sender, EventArgs e)
        {
            foreach (RadioButton button in rbs)
            {
                if (button.Checked)
                {
                    if (button.Name.Contains("Datum"))
                    {
                        this.dateOdredjeno.Enabled = true;
                    }
                    else
                    {
                        this.dateOdredjeno.Enabled = false;
                    }
                    if (button.Name.Contains("Opseg"))
                    {
                        this.dateOd.Enabled = true;
                        this.dateDo.Enabled = true;
                    }
                    else
                    {
                        this.dateOd.Enabled = false;
                        this.dateDo.Enabled = false;
                    }
                }
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
