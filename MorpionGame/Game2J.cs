using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MorpionGame
{
    public partial class Game2joueurs : Form
    { 
        public Game2joueurs()
        {
            InitializeComponent();
        }
        int score1 = 0;
        int score2 = 0;
        int scoreNull = 0;
        private void Game_Load(object sender, EventArgs e)
        {
            this.joueur_1.Text = Menu2joueur.name1;
            this.joueur_2.Text = Menu2joueur.name2;
        }
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
            this.feli.Text = "Félicitation " + Menu2joueur.name1;
            score1++;
            this.score_1.Text = Convert.ToString(score1);
            button_disable();
        }
        public void joueur2_V()
        {
            this.rejouer.Visible = true;
            this.feli.Visible = true;
            this.feli.Text = "Félicitation " + Menu2joueur.name2;
            score2++;
            this.score_2.Text = Convert.ToString(score2);
            button_disable();
        }
        public void re()
        {
            this.feli.Text = "Match nul";
            this.feli.Visible = true;
            this.rejouer.Visible = true;
            scoreNull++;
            this.score_nul.Text = Convert.ToString(scoreNull);
        }
        public void btn1(string lettre)
        {
            if ((this.button1.Text == lettre && this.button2.Text == lettre && this.button3.Text == lettre)
               ||(this.button1.Text == lettre && this.button4.Text == lettre && this.button7.Text == lettre)
               ||(this.button1.Text == lettre && this.button5.Text == lettre && this.button9.Text == lettre))
            {
                if (lettre == "X")
                {
                    joueur1_V();
                }
                else
                {
                    joueur2_V();
                }
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false )
            {
                re();           
            }
        } 
        public void btn2(string lettre)
        {
            if ((this.button1.Text == lettre && this.button2.Text == lettre && this.button3.Text == lettre)
               ||(this.button2.Text == lettre && this.button5.Text == lettre && this.button8.Text == lettre))
            {
                if (lettre == "X")
                {
                    joueur1_V();
                }
                else
                {
                    joueur2_V();
                }
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                re();
            }
        }
        public void btn3(string lettre)
        {
            if ((this.button1.Text == lettre && this.button2.Text == lettre && this.button3.Text == lettre)
                ||(this.button3.Text == lettre && this.button6.Text == lettre && this.button9.Text == lettre)
                ||(this.button3.Text == lettre && this.button5.Text == lettre && this.button7.Text == lettre))
            {
                if (lettre == "X")
                {
                    joueur1_V();
                }
                else
                {
                    joueur2_V();
                }
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                re();
            }
        }
        public void btn4(string lettre)
        {
            if ((this.button1.Text == lettre && this.button4.Text == lettre && this.button7.Text == lettre)
               || (this.button4.Text == lettre && this.button5.Text == lettre && this.button6.Text == lettre))
            {
                if (lettre == "X")
                {
                    joueur1_V();
                }
                else
                {
                    joueur2_V();
                }            
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                re();
            }
        }
        public void btn5(string lettre)
        {
            if ((this.button1.Text == lettre && this.button5.Text == lettre && this.button9.Text == lettre)
                ||(this.button2.Text == lettre && this.button5.Text == lettre && this.button8.Text == lettre)
                ||(this.button3.Text == lettre && this.button5.Text == lettre && this.button7.Text == lettre)
                ||(this.button4.Text == lettre && this.button5.Text == lettre && this.button6.Text == lettre))
            {
                if (lettre == "X")
                {
                    joueur1_V();
                }
                else
                {
                    joueur2_V();
                }
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                re();
            }
        }
        public void btn6(string lettre)
        {
            if ((this.button6.Text == lettre && this.button5.Text == lettre && this.button4.Text == lettre)
                ||(this.button3.Text == lettre && this.button6.Text == lettre && this.button9.Text == lettre))
            {
                if (lettre == "X")
                {
                    joueur1_V();
                }
                else
                {
                    joueur2_V();
                }
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                re();
            }
        }
        public void btn7(string lettre)
        {
            if((this.button1.Text == lettre && this.button4.Text == lettre && this.button7.Text == lettre)
                ||(this.button7.Text == lettre && this.button8.Text == lettre && this.button9.Text == lettre)
                ||(this.button7.Text == lettre && this.button5.Text == lettre && this.button3.Text == lettre))
            {
                if (lettre == "X")
                {
                    joueur1_V();
                }
                else
                {
                    joueur2_V();
                }
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                re();
            }
        }
        public void btn8(string lettre)
        {
            if ((this.button8.Text == lettre && this.button7.Text == lettre && this.button9.Text == lettre)
                ||(this.button8.Text == lettre && this.button5.Text == lettre && this.button2.Text == lettre))
            {
                if (lettre == "X")
                {
                    joueur1_V();
                }
                else
                {
                    joueur2_V();
                }
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                re();
            }
        }
        public void btn9(string lettre)
        {
            if ((this.button9.Text == lettre && this.button8.Text == lettre && this.button7.Text == lettre)
                ||(this.button9.Text == lettre && this.button5.Text == lettre && this.button1.Text == lettre)
                ||(this.button9.Text == lettre && this.button6.Text == lettre && this.button3.Text == lettre))
            {
                if (lettre == "X")
                {
                    joueur1_V();
                }
                else
                {
                    joueur2_V();
                }
            }
            else if (this.button1.Enabled == false && this.button2.Enabled == false && this.button3.Enabled == false && this.button4.Enabled == false && this.button5.Enabled == false && this.button6.Enabled == false && this.button7.Enabled == false && this.button8.Enabled == false && this.button9.Enabled == false)
            {
                re();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible)
            {
                this.button1.Text = "X";
                this.tour2.Visible = true;
                this.tour_1.Visible = false;
                this.button1.Enabled = false;
                btn1(this.button1.Text);
            }
            else if (this.tour2.Visible)
            {
                this.button1.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button1.Enabled = false;
                btn1(this.button1.Text);
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
                btn2(this.button2.Text);
            }
            else if (this.tour2.Visible == true)
            {
                this.button2.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button2.Enabled = false;
                btn2(this.button2.Text);
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
                btn3(this.button3.Text);
            }
            else if (this.tour2.Visible == true)
            {
                this.button3.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button3.Enabled = false;
                btn3(this.button3.Text);
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
                btn4(this.button4.Text);
            }
            else if (this.tour2.Visible == true)
            {
                this.button4.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button4.Enabled = false;
                btn4(this.button4.Text);
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
                btn5(this.button5.Text);
            }
            else if (this.tour2.Visible == true)
            {
                this.button5.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button5.Enabled = false;
                btn5(this.button5.Text);
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
                btn6(this.button6.Text);
            }
            else if (this.tour2.Visible == true)
            {
                this.button6.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button6.Enabled = false;
                btn6(this.button6.Text);
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
                btn7(this.button7.Text);
            }
            else if (this.tour2.Visible == true)
            {
                this.button7.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button7.Enabled = false;
                btn7(this.button7.Text);
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
                btn8(this.button8.Text);
            }
            else if (this.tour2.Visible == true)
            {
                this.button8.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button8.Enabled = false;
                btn8(this.button8.Text);
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
                btn9(this.button9.Text);
            }
            else if (this.tour2.Visible == true)
            {
                this.button9.Text = "O";
                this.tour2.Visible = false;
                this.tour_1.Visible = true;
                this.button9.Enabled = false;
                btn9(this.button9.Text);
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
            Application.OpenForms[1].Show();
            this.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}