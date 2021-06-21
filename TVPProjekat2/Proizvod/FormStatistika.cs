using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPProjekat2
{
    public partial class FormStatistika : Form
    {
        private projekatDataSet dataSet;
        FormProgram main;
        public FormStatistika(projekatDataSet dataSet, FormProgram main)
        {
            InitializeComponent();
            var linq = from p in dataSet.proizvod select p.ime;
            comboProizvodi.DataSource = linq.ToList();
            this.dataSet = dataSet;
            this.main = main;
        }

        private void crtajOdabrano(object sender, EventArgs e)
        {
            this.groupPrikaz.Paint += crtaj;
            this.groupPrikaz.Invalidate();
        }

        private void crtaj(object sender, PaintEventArgs e)
        {
            float pocetniUgao = 0;
            float kolicina = 0;
        }
        private Pen pen()
        {
            PropertyInfo[] nizCetkicaInfo = typeof(Pens).GetProperties();
            Pen[] nizCetkica = new Pen[nizCetkicaInfo.Length];
            for (int i = 0; i < nizCetkicaInfo.Length; i++)
            {
                nizCetkica[i] = (Pen)nizCetkicaInfo[i].GetValue(null, null);
            }
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return nizCetkica[rnd.Next(1, nizCetkica.Length)];
        }

        private Brush brush()
        {
            PropertyInfo[] nizCetkicaInfo = typeof(Brushes).GetProperties();
            Brush[] nizCetkica = new Brush[nizCetkicaInfo.Length];
            for (int i = 0; i < nizCetkicaInfo.Length; i++)
            {
                nizCetkica[i] = (Brush)nizCetkicaInfo[i].GetValue(null, null);
            }
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return nizCetkica[rnd.Next(1, nizCetkica.Length)];
        }
    }
}
