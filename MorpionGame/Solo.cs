using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorpionGame
{
    public partial class Solo : Form
    {
        public Solo()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
        private void Facile_Click(object sender, EventArgs e)
        {
            solo_facile soloFacile = new solo_facile();
            soloFacile.Show();
            this.Hide();
        }
        private void Moyen_Click(object sender, EventArgs e)
        {
            solo_moyen solo_Moyen= new solo_moyen();
            solo_Moyen.Show();
            this.Hide();
        }
        private void Difficile_Click(object sender, EventArgs e)
        {
            solo_difficile soloDifficile= new solo_difficile();
            soloDifficile.Show();
            this.Hide();
        }

        private void Impossible_Click(object sender, EventArgs e)
        {
            Impossiblecs soloImpo=new Impossiblecs();
            soloImpo.Show();
            this.Hide();
        }
    }
}
