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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int score1 = 0;
        int score2 = 0;
        int scoreNull = 0;
        public void button_actived()
        {
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.button9.Enabled = true;
        }
        public void button_disable()
        {
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
            this.button7.Enabled = false;
            this.button8.Enabled = false;
            this.button9.Enabled = false;
        }
        public void button_text_null()
        {
            this.button1.Text = null;
            this.button2.Text = null;
            this.button3.Text = null;
            this.button4.Text = null;
            this.button5.Text = null;
            this.button6.Text = null;
            this.button7.Text = null;
            this.button8.Text = null;
            this.button9.Text = null;
        }
        public void joueur1_V()
        {
            this.rejouer.Visible = true;
            this.feli.Visible = true;
            this.feli.Text = "Félicitation " + this.nom1.Text;
            score1++;
            this.score_1.Text = Convert.ToString(score1);
            score1 = Convert.ToInt32(score1);
            button_disable();
        }
        public void joueur2_V()
        {
            this.rejouer.Visible = true;
            this.feli.Visible = true;
            this.feli.Text = "Félicitation " + this.nom2.Text;
            score2++;
            this.score_2.Text = Convert.ToString(score2);
            score2 = Convert.ToInt32(score2);
            button_disable();
        }
        public void M()
        {
            this.feli.Text = "Match nul";
            this.feli.Visible = true;
            this.rejouer.Visible = true;
            scoreNull++;
            this.score_nul.Text = Convert.ToString(scoreNull);
        }
        private void valider_Click(object sender, EventArgs e)
        {
            this.tour_1.Visible = true;
            this.joueur_1.Visible = true;
            this.joueur_2.Visible = true;
            this.score_1.Visible = true;
            Convert.ToInt32(this.score_1.Text);
            Convert.ToInt32(this.score_2.Text);
            this.score_2.Visible = true;
            this.match_null.Visible = true;
            this.score_nul.Visible = true;
            this.joueur1_en.Visible = false;
            this.joueur2_en.Visible = false;
            this.nom1.Visible = false;
            this.nom2.Visible = false;
            this.valider.Visible = false;
            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            this.button5.Visible = true;
            this.button6.Visible = true;
            this.button7.Visible = true;
            this.button8.Visible = true;
            this.button9.Visible = true;
            this.rejouer.Visible = false;
            button_actived();
            this.label1.Visible = true;
            this.label2.Visible = false;
            this.label4.Visible = true;
            this.label3.Visible = false;
            this.joueur_1.Text = this.nom1.Text;
            this.joueur_2.Text = this.nom2.Text;
            this.x.Visible = true;
            this.o.Visible = true;
            this.changer.Visible = true;
            this.score_2.Visible = true;
            this.joueur_1.Visible = true;
            this.joueur_2.Visible = true;
            score2 = 0;
            score1 = 0;
            scoreNull = 0;
            this.score_1.Text = "0";
            this.score_2.Text = "0";
            this.score_nul.Text = "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible == true)
            {
                this.button1.Text = "X";
                this.tour2.Visible = true;
                this.tour_1.Visible = false;
                this.button1.Enabled = false;
                this.button1.ForeColor = Color.Navy;
            }
            else if (this.tour2.Visible == true)
            {
                this.button1.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button1.Enabled = false;
                this.button1.ForeColor = Color.DarkRed;
            }
            if (this.button1.Text == "X" && this.button2.Text == "X" && this.button3.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button4.Text == "X" && this.button5.Text == "X" && this.button6.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button1.Text == "X" && this.button5.Text == "X" && this.button9.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button1.Text == "O" && this.button2.Text == "O" && this.button3.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button4.Text == "O" && this.button5.Text == "O" && this.button6.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button1.Text == "O" && this.button5.Text == "O" && this.button9.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                this.feli.Text = "Match nul";
                this.feli.Visible = true;
                this.rejouer.Visible = true;
                scoreNull++;
                this.score_nul.Text = Convert.ToString(scoreNull);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (this.tour_1.Visible == true)
            {
                this.button2.Text = "X";
                this.tour2.Visible = true;
                this.tour_1.Visible = false;
                this.button2.Enabled = false;
                this.button1.ForeColor = Color.Navy;

            }
            else if (this.tour2.Visible == true)
            {
                this.button2.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button2.Enabled = false;
                this.button1.ForeColor = Color.DarkRed;

            }
            if (this.button1.Text == "X" && this.button2.Text == "X" && this.button3.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button2.Text == "X" && this.button5.Text == "X" && this.button8.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button1.Text == "O" && this.button2.Text == "O" && this.button3.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button2.Text == "O" && this.button5.Text == "O" && this.button8.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                this.feli.Text = "Match nul";
                this.feli.Visible = true;
                this.rejouer.Visible = true;
                scoreNull++;
                this.score_nul.Text = Convert.ToString(scoreNull);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible == true)
            {
                this.button3.Text = "X";
                this.tour2.Visible = true;
                this.tour_1.Visible = false;
                this.button3.Enabled = false;
                this.button1.ForeColor = Color.Navy;

            }
            else if (this.tour2.Visible == true)
            {
                this.button3.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button3.Enabled = false;
                this.button1.ForeColor = Color.DarkRed;
            }
            if (this.button1.Text == "X" && this.button2.Text == "X" && this.button3.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button3.Text == "X" && this.button6.Text == "X" && this.button9.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button3.Text == "X" && this.button5.Text == "X" && this.button7.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button1.Text == "O" && this.button2.Text == "O" && this.button3.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button3.Text == "O" && this.button6.Text == "O" && this.button9.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button3.Text == "O" && this.button5.Text == "O" && this.button7.Text == "O")
            {
                joueur2_V();

            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                this.feli.Text = "Match nul";
                this.feli.Visible = true;
                this.rejouer.Visible = true;
                scoreNull++;
                this.score_nul.Text = Convert.ToString(scoreNull);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible == true)
            {
                this.button4.Text = "X";
                this.tour2.Visible = true;
                this.tour_1.Visible = false;
                this.button4.Enabled = false;
                this.button1.ForeColor = Color.Navy;
            }
            else if (this.tour2.Visible == true)
            {
                this.button4.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button4.Enabled = false;
                this.button1.ForeColor = Color.DarkRed;
            }
            if (this.button1.Text == "X" && this.button4.Text == "X" && this.button7.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button4.Text == "X" && this.button5.Text == "X" && this.button6.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button1.Text == "O" && this.button4.Text == "O" && this.button7.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button4.Text == "O" && this.button5.Text == "O" && this.button6.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                this.feli.Text = "Match nul";
                this.feli.Visible = true;
                this.rejouer.Visible = true;
                scoreNull++;
                this.score_nul.Text = Convert.ToString(scoreNull);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible == true)
            {
                this.button5.Text = "X";
                this.tour2.Visible = true;
                this.tour_1.Visible = false;
                this.button5.Enabled = false;
                this.button1.ForeColor = Color.Navy;
            }
            else if (this.tour2.Visible == true)
            {
                this.button5.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button5.Enabled = false;
                this.button1.ForeColor = Color.DarkRed;
            }
            if (this.button1.Text == "X" && this.button5.Text == "X" && this.button9.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button2.Text == "X" && this.button5.Text == "X" && this.button8.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button3.Text == "X" && this.button5.Text == "X" && this.button7.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button4.Text == "X" && this.button5.Text == "X" && this.button6.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button1.Text == "O" && this.button5.Text == "O" && this.button9.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button2.Text == "O" && this.button5.Text == "O" && this.button8.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button3.Text == "O" && this.button5.Text == "O" && this.button7.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button4.Text == "O" && this.button5.Text == "O" && this.button6.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                this.feli.Text = "Match nul";
                this.feli.Visible = true;
                this.rejouer.Visible = true;
                scoreNull++;
                this.score_nul.Text = Convert.ToString(scoreNull);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible == true)
            {
                this.button6.Text = "X";
                this.tour2.Visible = true;
                this.tour_1.Visible = false;
                this.button6.Enabled = false;
                this.button1.ForeColor = Color.Navy;
            }
            else if (this.tour2.Visible == true)
            {
                this.button6.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button6.Enabled = false;
                this.button1.ForeColor = Color.DarkRed;
            }
            if (this.button6.Text == "X" && this.button5.Text == "X" && this.button4.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button3.Text == "X" && this.button6.Text == "X" && this.button9.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button6.Text == "O" && this.button5.Text == "O" && this.button4.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button3.Text == "O" && this.button6.Text == "O" && this.button9.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                this.feli.Text = "Match nul";
                this.feli.Visible = true;
                this.rejouer.Visible = true;
                scoreNull++;
                this.score_nul.Text = Convert.ToString(scoreNull);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible == true)
            {
                this.button7.Text = "X";
                this.tour2.Visible = true;
                this.tour_1.Visible = false;
                this.button7.Enabled = false;
                this.button1.ForeColor = Color.Navy;
            }
            else if (this.tour2.Visible == true)
            {
                this.button7.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button7.Enabled = false;
                this.button1.ForeColor = Color.DarkRed;
            }
            if (this.button1.Text == "X" && this.button4.Text == "X" && this.button7.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button7.Text == "X" && this.button8.Text == "X" && this.button9.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button7.Text == "X" && this.button5.Text == "X" && this.button3.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button1.Text == "O" && this.button4.Text == "O" && this.button7.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button7.Text == "O" && this.button8.Text == "O" && this.button9.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button7.Text == "O" && this.button5.Text == "O" && this.button3.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                this.feli.Text = "Match nul";
                this.feli.Visible = true;
                this.rejouer.Visible = true;
                scoreNull++;
                this.score_nul.Text = Convert.ToString(scoreNull);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible == true)
            {
                this.button8.Text = "X";
                this.tour2.Visible = true;
                this.tour_1.Visible = false;
                this.button8.Enabled = false;
                this.button1.ForeColor = Color.Navy;
            }
            else if (this.tour2.Visible == true)
            {
                this.button8.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button8.Enabled = false;
                this.button1.ForeColor = Color.DarkRed;
            }
            if (this.button8.Text == "X" && this.button7.Text == "X" && this.button9.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button8.Text == "X" && this.button5.Text == "X" && this.button2.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button8.Text == "O" && this.button7.Text == "O" && this.button9.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button8.Text == "O" && this.button5.Text == "O" && this.button2.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                this.feli.Text = "Match nul";
                this.feli.Visible = true;
                this.rejouer.Visible = true;
                scoreNull++;
                this.score_nul.Text = Convert.ToString(scoreNull);
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible == true)
            {
                this.button9.Text = "X";
                this.tour2.Visible = true;
                this.tour_1.Visible = false;
                this.button9.Enabled = false;
                this.button1.ForeColor = Color.Navy;
            }
            else if (this.tour2.Visible == true)
            {
                this.button9.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button9.Enabled = false;
                this.button1.ForeColor = Color.DarkRed;
            }
            if (this.button9.Text == "X" && this.button8.Text == "X" && this.button7.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button9.Text == "X" && this.button5.Text == "X" && this.button1.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button9.Text == "X" && this.button6.Text == "X" && this.button3.Text == "X")
            {
                joueur1_V();
            }
            else if (this.button9.Text == "O" && this.button8.Text == "O" && this.button7.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button9.Text == "O" && this.button5.Text == "O" && this.button1.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button9.Text == "O" && this.button6.Text == "O" && this.button3.Text == "O")
            {
                joueur2_V();
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                this.feli.Text = "Match nul";
                this.feli.Visible = true;
                this.rejouer.Visible = true;
                scoreNull++;
                this.score_nul.Text = Convert.ToString(scoreNull);
            }
        }
        private void rejouer_Click(object sender, EventArgs e)
        {
            button_text_null();
            button_actived();
            this.feli.Visible = false;
            this.rejouer.Visible = false;
        }
        private void changer_Click(object sender, EventArgs e)
        {
            this.score_2.Visible = false;
            this.match_null.Visible = false;
            this.score_nul.Visible = false;
            this.joueur1_en.Visible = true;
            this.joueur2_en.Visible = true;
            this.nom1.Visible = true;
            this.nom2.Visible = true;
            this.score_1.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            this.button5.Visible = false;
            this.button6.Visible = false;
            this.button7.Visible = false;
            this.button8.Visible = false;
            this.button9.Visible = false;
            button_disable();
            this.label1.Visible = false;
            this.label2.Visible = true;
            this.label4.Visible = false;
            this.label3.Visible = true;
            this.x.Visible = false;
            this.o.Visible = false;
            this.changer.Visible = false;
            this.valider.Visible = true;
            this.tour_1.Visible = false;
            this.tour2.Visible = false;
            this.feli.Visible = false;
            this.rejouer.Visible = false;
            button_text_null();
            this.joueur_1.Visible = false;
            this.joueur_2.Visible = false;
            this.nom1.Text = null;
            this.nom2.Text = null;
        }
    }
}
