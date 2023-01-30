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
    public partial class Menu2joueur : Form
    {
        public Menu2joueur()
        {
            InitializeComponent();
        }
        public static string name1 = "";
        public static string name2 = "";
        private void valider_Click(object sender, EventArgs e)
        {

            Game2joueurs jeu = new Game2joueurs();
            
            if (this.nom1.Text == "" && this.nom2.Text == "")
            {
                this.erreur.Visible = true;
            }
            else if (this.nom1.Text!="" && this.nom2.Text!= "")
            {
                name1 = this.nom1.Text;
                name2 = this.nom2.Text;
                jeu.Show();
                this.Hide();                                
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }
    }
}
