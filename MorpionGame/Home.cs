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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu2joueur joueurs_2 = new Menu2joueur();
            joueurs_2.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Vs_Machine_Click(object sender, EventArgs e)
        {
            Solo vsMachine = new Solo();
            vsMachine.Show();
            this.Hide();
        }
    }
}
