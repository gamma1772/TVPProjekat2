﻿using System;
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
    public partial class FormNoviProizvod : Form
    {
        public FormNoviProizvod(projekatDataSet dataSet, proizvodTableAdapter proizvodDB, FormListaProizvoda main)
        {
            InitializeComponent();
        }
    }
}
