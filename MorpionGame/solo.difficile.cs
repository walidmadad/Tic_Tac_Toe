using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorpionGame
{
    public partial class solo_difficile : Form
    {
        public solo_difficile()
        {
            InitializeComponent();
        }
        int score1 = 0;
        int score2 = 0;
        int scoreNull = 0;
        List<int> btn = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public object Deleted { get; private set; }

        private void changer_Click(object sender, EventArgs e)
        {
            btn.Clear();
            btn.Add(1);
            btn.Add(2);
            btn.Add(3);
            btn.Add(4);
            btn.Add(5);
            btn.Add(6);
            btn.Add(7);
            btn.Add(8);
            btn.Add(9);

            Application.OpenForms[1].Show();
            this.Close();
        }
        public void robo(int robot)
        {
            switch (robot)
            {
                case 1:
                    this.button1.Text = "O";
                    this.button1.Enabled = false;
                    btn1(this.button1.Text);
                    break;
                case 2:
                    this.button2.Text = "O";
                    this.button2.Enabled = false;
                    btn2(this.button2.Text);
                    break;
                case 3:
                    this.button3.Text = "O";
                    this.button3.Enabled = false;
                    btn3(this.button3.Text);
                    break;
                case 4:
                    this.button4.Text = "O";
                    this.button4.Enabled = false;
                    btn4(this.button4.Text);
                    break;
                case 5:
                    this.button5.Text = "O";
                    this.button5.Enabled = false;
                    btn5(this.button5.Text);
                    break;
                case 6:
                    this.button6.Text = "O";
                    this.button6.Enabled = false;
                    btn6(this.button6.Text);
                    break;
                case 7:
                    this.button7.Text = "O";
                    this.button7.Enabled = false;
                    btn7(this.button7.Text);
                    break;
                case 8:
                    this.button8.Text = "O";
                    this.button8.Enabled = false;
                    btn8(this.button8.Text);
                    break;
                case 9:
                    this.button9.Text = "O";
                    this.button9.Enabled = false;
                    btn9(this.button9.Text);
                    break;
            }
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
            this.feli.Text = "Vous avez gagné";
            score1++;
            this.score_1.Text = Convert.ToString(score1);
            button_disable();

        }
        public void joueur2_V()
        {
            this.rejouer.Visible = true;
            this.feli.Visible = true;
            this.feli.Text = "Vous avez perdu";
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
               || (this.button1.Text == lettre && this.button4.Text == lettre && this.button7.Text == lettre)
               || (this.button1.Text == lettre && this.button5.Text == lettre && this.button9.Text == lettre))
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
            else if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "")
            {
                re();
            }
        }
        public void btn2(string lettre)
        {
            if ((this.button1.Text == lettre && this.button2.Text == lettre && this.button3.Text == lettre)
               || (this.button2.Text == lettre && this.button5.Text == lettre && this.button8.Text == lettre))
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
            else if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "")
            {
                re();
            }
        }
        public void btn3(string lettre)
        {
            if ((this.button1.Text == lettre && this.button2.Text == lettre && this.button3.Text == lettre)
                || (this.button3.Text == lettre && this.button6.Text == lettre && this.button9.Text == lettre)
                || (this.button3.Text == lettre && this.button5.Text == lettre && this.button7.Text == lettre))
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
            else if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "")
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
            else if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "")
            {
                re();
            }
        }
        public void btn5(string lettre)
        {
            if ((this.button1.Text == lettre && this.button5.Text == lettre && this.button9.Text == lettre)
                || (this.button2.Text == lettre && this.button5.Text == lettre && this.button8.Text == lettre)
                || (this.button3.Text == lettre && this.button5.Text == lettre && this.button7.Text == lettre)
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
            else if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "")
            {
                re();
            }
        }
        public void btn6(string lettre)
        {
            if ((this.button6.Text == lettre && this.button5.Text == lettre && this.button4.Text == lettre)
                || (this.button3.Text == lettre && this.button6.Text == lettre && this.button9.Text == lettre))
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
            else if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "")
            {
                re();
            }
        }
        public void btn7(string lettre)
        {
            if ((this.button1.Text == lettre && this.button4.Text == lettre && this.button7.Text == lettre)
                || (this.button7.Text == lettre && this.button8.Text == lettre && this.button9.Text == lettre)
                || (this.button7.Text == lettre && this.button5.Text == lettre && this.button3.Text == lettre))
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
            else if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "")
            {
                re();
            }
        }
        public void btn8(string lettre)
        {
            if ((this.button8.Text == lettre && this.button7.Text == lettre && this.button9.Text == lettre)
                || (this.button8.Text == lettre && this.button5.Text == lettre && this.button2.Text == lettre))
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
            else if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "")
            {
                re();
            }
        }
        public void btn9(string lettre)
        {
            if ((this.button9.Text == lettre && this.button8.Text == lettre && this.button7.Text == lettre)
                || (this.button9.Text == lettre && this.button5.Text == lettre && this.button1.Text == lettre)
                || (this.button9.Text == lettre && this.button6.Text == lettre && this.button3.Text == lettre))
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
            else if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "")
            {
                re();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible)
            {
                this.button1.Text = "X";
                this.tour_2.Visible = true;
                this.tour_1.Visible = false;
                this.button1.Enabled = false;
                btn1(this.button1.Text);
                btn.Remove(1);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") { }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            if (button1.Text == "X" && tour_2.Visible)
                            {
                                //col 2
                                if (button2.Text =="O" && button5.Text=="O" &&button8.Text==""&& this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text =="O"&& button8.Text=="O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text =="O"&& button8.Text=="O" && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 3
                                else if (button3.Text =="O" &&button6.Text=="O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text =="O" &&button9.Text=="O" && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == "O" && button9.Text=="O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 2
                                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == "O" && button5.Text == "O" && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // ligne 3
                                else if (button7.Text == "O" && button8.Text=="O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 3 5 7 
                                else if (button3.Text == "O" && button5.Text=="O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text =="O" && button7.Text== "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text =="O"&& button7.Text=="O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }                                                            
                                else if (button1.Text == button2.Text && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == button3.Text && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == button4.Text && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == button7.Text && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == button5.Text && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == button9.Text && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else
                                {
                                    if (button5.Text == "")
                                    {
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                        robo(5);
                                        btn.Remove(5);
                                    }
                                    else if (button5.Text == "O" && button3.Text=="")
                                    {
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                        robo(3);
                                        btn.Remove(3);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible)
            {
                this.button2.Text = "X";
                this.tour_2.Visible = true;
                this.tour_1.Visible = false;
                this.button2.Enabled = false;
                btn2(this.button2.Text);
                btn.Remove(2);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") { }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            if (button2.Text == "X" && tour_2.Visible)
                            {
                                //col 1
                                if (button1.Text == "O" && button2.Text== "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == "O" && button3.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 2
                                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == "O" && button8.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 3
                                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == "O" && button9.Text == "O" && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == "O" && button9.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 1
                                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button7.Text == "O" && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == "O" && button7.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 2
                                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == "O" && button5.Text == "O" && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // ligne 3
                                else if (button7.Text == "O" && button8.Text =="O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 1 5 9
                                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button9.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button9.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 3 5 7 
                                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == "O" && button7.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button7.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                           
                                else if (button2.Text == button3.Text && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == button1.Text && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == button5.Text && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == button8.Text && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else
                                {
                                    if (button5.Text == "")
                                    {
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                        robo(5);
                                        btn.Remove(5);
                                    }
                                    else if((button2.Text == "X" || button4.Text == "X" || button6.Text == "X" || button8.Text == "X" ) && button1.Text == "")
                                    {
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                        robo(1);
                                        btn.Remove(1);
                                    }
                                    else
                                    {
                                        Random random = new Random();
                                        int r1 = random.Next(0, btn.Count);
                                        int robot = btn[r1];
                                        robo(robot);
                                        btn.Remove(robot);
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible)
            {
                this.button3.Text = "X";
                this.tour_2.Visible = true;
                this.tour_1.Visible = false;
                this.button3.Enabled = false;
                btn3(this.button3.Text);
                btn.Remove(3);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") { }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            if (button3.Text == "X" && tour_2.Visible)
                            {
                                //col 1
                                if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == "O" && button3.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 2
                                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == "O" && button8.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button8.Text == "O" && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 3
                                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == "O" && button9.Text == "O" && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 1
                                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button7.Text == "O" && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == "O" && button7.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 2
                                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == "O" && button5.Text == "O" && button4.Text == "" && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // ligne 3
                                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 1 5 9
                                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button9.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button9.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 3 5 7 
                                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == "O" && button7.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }                                
                                else if (button3.Text == button1.Text && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == button2.Text && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == button6.Text && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == button9.Text && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == button5.Text && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == button7.Text && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else
                                {
                                    if (button5.Text == "")
                                    {
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                        robo(5);
                                        btn.Remove(5);
                                    }
                                    else
                                    {
                                        Random random = new Random();
                                        int r1 = random.Next(0, btn.Count);
                                        int robot = btn[r1];
                                        robo(robot);
                                        btn.Remove(robot);
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible)
            {
                this.button4.Text = "X";
                this.tour_2.Visible = true;
                this.tour_1.Visible = false;
                this.button4.Enabled = false;
                btn4(this.button4.Text);
                btn.Remove(4);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") { }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            if (button4.Text == "X" && tour_2.Visible)
                            {
                                //col 1
                                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == "O" && button3.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 2
                                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == "O" && button8.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button8.Text == "O" && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 3
                                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == "O" && button9.Text == "O" && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == "O" && button9.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 1
                                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == "O" && button7.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 2
                                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // ligne 3
                                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 1 5 9
                                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button9.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button9.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 3 5 7 
                                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == "O" && button7.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button7.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }                                                        
                                else if (button4.Text == button1.Text && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == button7.Text && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == button6.Text && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == button5.Text && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else
                                {
                                    if (button5.Text == "")
                                    {
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                        robo(5);
                                        btn.Remove(5);

                                    }
                                    else if ((button2.Text == "X" || button4.Text == "X" || button6.Text == "X" || button8.Text == "X") && button1.Text == "")
                                    {
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                        robo(1);
                                        btn.Remove(1);
                                    }
                                    else
                                    {
                                        Random random = new Random();
                                        int r1 = random.Next(0, btn.Count);
                                        int robot = btn[r1];
                                        robo(robot);
                                        btn.Remove(robot);
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible)
            {
                this.button5.Text = "X";
                this.tour_2.Visible = true;
                this.tour_1.Visible = false;
                this.button5.Enabled = false;
                btn5(this.button5.Text);
                btn.Remove(5);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") { }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            if (button5.Text == "X" && tour_2.Visible)
                            {
                                //col 1
                                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == "O" && button3.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1); 
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 2
                                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button8.Text == "O" && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 3
                                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == "O" && button9.Text == "O" && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == "O" && button9.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 1
                                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button7.Text == "O" && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == "O" && button7.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    btn.Remove(1);
                                    robo(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 2
                                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == "O" && button5.Text == "O" && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // ligne 3
                                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 1 5 9
                                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button9.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 3 5 7 
                                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button7.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }                               
                                else if (button5.Text == button1.Text && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == button9.Text && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == button2.Text && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == button8.Text && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == button3.Text && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == button7.Text && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == button6.Text && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == button4.Text && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else
                                {
                                    if (button5.Text == "")
                                    {
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                        robo(5);
                                        btn.Remove(5);
                                    }
                                    else if (button5.Text == "X")
                                    {
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                        robo(1);
                                        btn.Remove(1);
                                    }
                                    else
                                    {
                                        Random random = new Random();
                                        int r1 = random.Next(0, btn.Count);
                                        int robot = btn[r1];
                                        robo(robot);
                                        btn.Remove(robot);
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible)
            {
                this.button6.Text = "X";
                this.tour_2.Visible = true;
                this.tour_1.Visible = false;
                this.button6.Enabled = false;
                btn6(this.button6.Text);
                btn.Remove(6);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") { }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            if (button6.Text == "X" && tour_2.Visible)
                            {
                                //col 1
                                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == "O" && button3.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 2
                                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == "O" && button8.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button8.Text == "O" && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 3
                                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == "O" && button9.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 1
                                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button7.Text == "O" && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == "O" && button7.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 2
                                else if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // ligne 3
                                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 1 5 9
                                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button9.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button9.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 3 5 7 
                                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == "O" && button7.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button7.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }                                
                                else if (button6.Text == button3.Text && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == button9.Text && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == button4.Text && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == button5.Text && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else
                                {
                                    if (button5.Text == "")
                                    {
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                        robo(5);
                                        btn.Remove(5);
                                    }
                                    else if ((button2.Text == "X" || button4.Text == "X" || button6.Text == "X" || button8.Text == "X") &&button1.Text=="")
                                    {
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                        robo(1);
                                        btn.Remove(1);
                                    }
                                    else
                                    {
                                        Random random = new Random();
                                        int r1 = random.Next(0, btn.Count);
                                        int robot = btn[r1];
                                        robo(robot);
                                        btn.Remove(robot);
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible)
            {
                this.button7.Text = "X";
                this.tour_2.Visible = true;
                this.tour_1.Visible = false;
                this.button7.Enabled = false;               
                btn7(this.button7.Text);
                btn.Remove(7);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") { }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            if (button7.Text == "X" && tour_2.Visible)
                            {
                                //col 1
                                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == "O" && button3.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 2
                                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == "O" && button8.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button8.Text == "O" && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 3
                                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == "O" && button9.Text == "O" && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == "O" && button9.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 1
                                else if (button1.Text == "O" && button7.Text == "O" && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == "O" && button7.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 2
                                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == "O" && button5.Text == "O" && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // ligne 3
                                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 1 5 9
                                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button9.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button9.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 3 5 7 
                                else if (button3.Text == "O" && button7.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button7.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button7.Text == button1.Text && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button7.Text == button4.Text && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button7.Text == button8.Text && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button7.Text == button9.Text && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button7.Text == button5.Text && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button7.Text == button3.Text && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else
                                {
                                    if (button5.Text == "")
                                    {
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                        robo(5);
                                        btn.Remove(5);
                                    }
                                    else
                                    {
                                        Random random = new Random();
                                        int r1 = random.Next(0, btn.Count);
                                        int robot = btn[r1];
                                        robo(robot);
                                        btn.Remove(robot);
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible)
            {
                this.button8.Text = "X";
                this.tour_2.Visible = true;
                this.tour_1.Visible = false;
                this.button8.Enabled = false;
                btn8(this.button8.Text);
                btn.Remove(8);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") { }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            if (button8.Text == "X" && tour_2.Visible)
                            {
                                //col 1
                                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == "O" && button3.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 2
                                else if (button2.Text == "O" && button8.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button8.Text == "O" && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 3
                                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == "O" && button9.Text == "O" && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == "O" && button9.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 1
                                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button7.Text == "O" && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == "O" && button7.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 2
                                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == "O" && button5.Text == "O" && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // ligne 3
                                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 1 5 9
                                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button9.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button9.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 3 5 7 
                                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == "O" && button7.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button7.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }                                                                
                                else if (button8.Text == button9.Text && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button8.Text == button7.Text && button9.Text == "" && this.tour_2.Visible)
                                {
                                    robo(9);
                                    btn.Remove(9);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button8.Text == button2.Text && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button8.Text == button5.Text && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else
                                {
                                    if (button5.Text == "")
                                    {
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                        robo(5);
                                        btn.Remove(5);
                                    }
                                    else if ((button2.Text == "X" || button4.Text == "X" || button6.Text == "X" || button8.Text == "X") && button1.Text == "")
                                    {
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                        robo(1);
                                        btn.Remove(1);
                                    }
                                    else
                                    {
                                        Random random = new Random();
                                        int r1 = random.Next(0, btn.Count);
                                        int robot = btn[r1];
                                        robo(robot);
                                        btn.Remove(robot);
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (this.tour_1.Visible)
            {
                this.button9.Text = "X";
                this.tour_2.Visible = true;
                this.tour_1.Visible = false;
                this.button9.Enabled = false;
                btn9(this.button9.Text);
                btn.Remove(9);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") { }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            if (button9.Text == "X" && tour_2.Visible)
                            {
                                //col 1
                                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == "O" && button3.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 2
                                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button2.Text == "O" && button8.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button8.Text == "O" && button2.Text == "" && this.tour_2.Visible)
                                {
                                    robo(2);
                                    btn.Remove(2);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //col 3
                                else if (button3.Text == "O" && button9.Text == "O" && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == "O" && button9.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 1
                                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button1.Text == "O" && button7.Text == "O" && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == "O" && button7.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                //ligne 2
                                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button6.Text == "O" && button5.Text == "O" && button4.Text == "" && this.tour_2.Visible)
                                {
                                    robo(4);
                                    btn.Remove(4);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // ligne 3
                                else if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 1 5 9
                                else if (button1.Text == "O" && button9.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button9.Text == "O" && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                // diagonale 3 5 7 
                                else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button3.Text == "O" && button7.Text == "O" && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button5.Text == "O" && button7.Text == "O" && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button9.Text == button8.Text && button7.Text == "" && this.tour_2.Visible)
                                {
                                    robo(7);
                                    btn.Remove(7);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button9.Text == button7.Text && button8.Text == "" && this.tour_2.Visible)
                                {
                                    robo(8);
                                    btn.Remove(8);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button9.Text == button6.Text && button3.Text == "" && this.tour_2.Visible)
                                {
                                    robo(3);
                                    btn.Remove(3);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button9.Text == button3.Text && button6.Text == "" && this.tour_2.Visible)
                                {
                                    robo(6);
                                    btn.Remove(6);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button9.Text == button5.Text && button1.Text == "" && this.tour_2.Visible)
                                {
                                    robo(1);
                                    btn.Remove(1);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else if (button9.Text == button1.Text && button5.Text == "" && this.tour_2.Visible)
                                {
                                    robo(5);
                                    btn.Remove(5);
                                    this.tour_2.Visible = false;
                                    this.tour_1.Visible = true;
                                }
                                else
                                {
                                    if(button5.Text=="")
                                    {
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                        robo(5);
                                        btn.Remove(5);
                                    }
                                    else
                                    {
                                        Random random = new Random();
                                        int r1 = random.Next(0, btn.Count);
                                        int robot = btn[r1];
                                        robo(robot);
                                        btn.Remove(robot);
                                        this.tour_2.Visible = false;
                                        this.tour_1.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void rejouer_Click(object sender, EventArgs e)
        {
            this.feli.Visible = false;
            btn.Clear();
            button_text_null();
            button_actived();
                

            this.rejouer.Visible = false;
            btn.Add(1);
            btn.Add(2);
            btn.Add(3);
            btn.Add(4);
            btn.Add(5);
            btn.Add(6);
            btn.Add(7);
            btn.Add(8);
            btn.Add(9);
            if (tour_2.Visible == true)
            {
                Thread.Sleep(1000);
                robo(5);
                btn.Remove(5);
                tour_1.Visible= true;
                tour_2.Visible = false;
            }
           
        }

        private void solo_difficile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Dispose();
        }
    }
}
