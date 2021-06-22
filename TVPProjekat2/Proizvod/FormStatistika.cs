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
        private int brDana, odabranMesec;
        private string[] horizontal;
        private projekatDataSet dataSet;

        private float kolicina = 0;
        private float mesecnaKolicina = 0;
        private float[] godisnjiPresek;
        private float godisnjaKolicina = 0;
        FormProgram main;
        public FormStatistika(projekatDataSet dataSet, FormProgram main)
        {
            InitializeComponent();
            var linq = from p in dataSet.proizvod select p.ime;
            comboProizvodi.DataSource = linq.ToList();
            this.dataSet = dataSet;
            this.main = main;

            comboMesec.SelectedIndex = 0;
            update();
        }

        private void crtajOdabrano(object sender, EventArgs e)
        {
            this.groupPrikaz.Paint += crtaj;
            this.groupPrikaz.Invalidate();
            if (dataSet != null)
            {
                update();
            }
        }

        private void crtaj(object sender, PaintEventArgs e)
        {
            float pocetniUgao = 0;
            
            if (odabranMesec != 0)
            {
                if (mesecnaKolicina != 0 && kolicina != 0)
                {
                    e.Graphics.FillPie(Brushes.Red, new Rectangle(150, 35, 200, 200), pocetniUgao, 360);
                    e.Graphics.FillPie(Brushes.Blue, new Rectangle(150, 35, 200, 200), pocetniUgao, (mesecnaKolicina * 360) / kolicina);
                    e.Graphics.DrawPie(Pens.Black, new Rectangle(150, 35, 200, 200), pocetniUgao, 360);
                }
                else
                {
                    e.Graphics.DrawString("Nema podataka", DefaultFont, Brushes.Red, 150, 35);
                }
            }
            else
            {
                if (kolicina != 0)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        e.Graphics.FillPie(brush(), new Rectangle(150, 35, 200, 200), pocetniUgao, (godisnjiPresek[i] * 360) / kolicina);
                        pocetniUgao += (godisnjiPresek[i] * 360) / kolicina;
                    }
                    e.Graphics.DrawPie(Pens.Black, new Rectangle(150, 35, 200, 200), pocetniUgao, 360);
                }
                else
                {
                    e.Graphics.DrawString("Nema podataka", DefaultFont, Brushes.Red, 150, 35);
                }
            }
            
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

        private void checkChanged(object sender, EventArgs e)
        {
            update();
            if (rbStatistika.Checked)
            {
                //chartStatistika.Show();
                this.groupPrikaz.Invalidate();
            } else if (rbProcentualno.Checked)
            {
                //chartStatistika.Hide();
                crtajOdabrano(sender, e);
            }
        }

        private void formClosed(object sender, FormClosedEventArgs e)
        {
            close(sender, e);
        }

        private void close(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();

            main.FrmStatistika = null;
        }

        private void promeniMesec(object sender, EventArgs e)
        {
            odabranMesec = comboMesec.SelectedIndex;
            switch (comboMesec.SelectedIndex)
            {
                case 0:
                    brDana = 365;
                    horizontal = new string[] { "Jan", "Feb", "Mar", "Apr", "Maj", "Jun", "Jul", "Avg", "Sep", "Okt", "Nov", "Dec" };
                    break;

                case 1: case 3: case 5: case 7: case 8: case 10: case 12: //Jan Mar Maj Jul Avg Okt Dec: 31 dan
                    brDana = 31;
                    horizontal = new string[brDana];
                    for (int i = 0; i < brDana; i++)
                    {
                        horizontal[i] = (i + 1).ToString();
                    }
                    break;

                case 2: //Feb: 38 dana
                    brDana = 28;
                    horizontal = new string[brDana];
                    for (int i = 0; i < brDana; i++)
                    {
                        horizontal[i] = (i + 1).ToString();
                    }
                    break;

                case 4: case 6: case 9: case 11: //Apr Jun Sep Nov: 30 dana
                    brDana = 30;
                    horizontal = new string[brDana];
                    for (int i = 0; i < brDana; i++)
                    {
                        horizontal[i] = (i + 1).ToString();
                    }
                    break;

                default:
                    brDana = 1;
                    horizontal = new string[] { "Ukupna prodaja" };
                    break;
            }
            update();
            crtajOdabrano(sender, e);
        }

        private void update()
        {
            var linq = (from rp in dataSet.racun_proizvod where (from p in dataSet.proizvod where p.ime.ToLower().Equals(comboProizvodi.SelectedItem.ToString().ToLower()) select p.ID).Contains(rp.ProizvodID) select rp.Kolicina);
            kolicina = (float)linq.Sum();
            if (odabranMesec != 0)
            {
                var linqMesec = (from rp in dataSet.racun_proizvod where (from r in dataSet.racun where r.datum_izdavanja.Month == odabranMesec && r.datum_izdavanja.Year == DateTime.Now.Year select r.ID).Contains(rp.RacunID) && (from p in dataSet.proizvod where p.ime.ToLower().Equals(comboProizvodi.SelectedItem.ToString().ToLower()) select p.ID).Contains(rp.ProizvodID) select rp.Kolicina);
                mesecnaKolicina = (float)linqMesec.Sum();
            }
            else
            {
                godisnjiPresek = new float[12];
                for (int i = 0; i < 12; i++)
                {
                    var linqGodisnjiPresek = (from rp in dataSet.racun_proizvod where (from r in dataSet.racun where r.datum_izdavanja.Month == i + 1 && r.datum_izdavanja.Year == DateTime.Now.Year select r.ID).Contains(rp.RacunID) && (from p in dataSet.proizvod where p.ime.ToLower().Equals(comboProizvodi.SelectedItem.ToString().ToLower()) select p.ID).Contains(rp.ProizvodID) select rp.Kolicina);
                    godisnjiPresek[i] = (float) linqGodisnjiPresek.Sum();
                }
            }
            var linqGodisnji = (from rp in dataSet.racun_proizvod where (from r in dataSet.racun where r.datum_izdavanja.Year == DateTime.Now.Year select r.ID).Contains(rp.RacunID) && (from p in dataSet.proizvod where p.ime.ToLower().Equals(comboProizvodi.SelectedItem.ToString().ToLower()) select p.ID).Contains(rp.ProizvodID) select rp.Kolicina);
            godisnjaKolicina = (float) linqGodisnji.Sum();

            txtGodisnje.Text = godisnjaKolicina.ToString("0.00");
            txtUkupno.Text = kolicina.ToString("0.00");
        }
    }
}
