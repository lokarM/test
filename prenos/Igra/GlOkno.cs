using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Igra
{
    
    public partial class GlOkno : Form
    {
         public static Dictionary<string, string> premiki = new Dictionary<string, string>();

        public GlOkno()
        {
            InitializeComponent();
            premiki.Add("levo", "LEVO"); // začetna nastavitev
        }

        private void GlOkno_Load(object sender, EventArgs e)
        {
            kajLevo.Text = GlOkno.premiki["levo"];
        }

        private void spremeniNastavitve_Click(object sender, EventArgs e)
        {
            OknoNastavitve Okno_nastavi = new OknoNastavitve();
            Okno_nastavi.Show();

        }

        private void prikaziNastavitve_Click(object sender, EventArgs e)
        {
            kajLevo.Text = GlOkno.premiki["levo"];
        }
    }
}
