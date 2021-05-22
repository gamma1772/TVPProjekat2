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
        projekatDataSet pds;
        public FormProgram(projekatDataSet pds)
        {
            InitializeComponent();
            this.pds = pds;
        }

        internal void recieveUser(Korisnik korisnik)
        {
            this.prijavljenKorisnik = korisnik;
        }
    }
}
