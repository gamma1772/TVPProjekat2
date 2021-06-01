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
        private DataGridView dataGrid;
        projekatDataSet projekatData;

        private List<RadioButton> rbs;
        public FormPretraga(DataGridView dataGrid, projekatDataSet projekatData)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
            this.projekatData = projekatData;

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
    }
}
