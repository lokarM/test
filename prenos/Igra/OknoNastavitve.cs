﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igra
{
    public partial class OknoNastavitve : Form
    {
        public OknoNastavitve()
        {
            InitializeComponent();
        }

        private void spremeni_Click(object sender, EventArgs e)
        {
            GlOkno.premiki["levo"] = this.tB_levo.Text;
            this.Close();
        }
    }
}
