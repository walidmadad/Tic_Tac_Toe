using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MorpionGame
{
    public partial class solo_facile : Form
    {
        public solo_facile()
        {
            InitializeComponent();
        }
        int score1 = 0;
        int score2 = 0;
        int scoreNull = 0;
        List<int> btn =new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public object Deleted { get; private set; }

        private void changer_Click(object sender, EventArgs e)
        {
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
                btn.Remove(1);
                btn1(this.button1.Text);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") {  }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            Random random = new Random();
                            int r1 = random.Next(1, btn.Count);
                            int robot = btn[r1];
                            btn.Remove(robot);
                            robo(robot);
                            this.tour_2.Visible = false;
                            this.tour_1.Visible = true;
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
                btn.Remove(2);
                btn2(this.button2.Text);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") {  }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            Random random = new Random();
                            int r1 = random.Next(1, btn.Count);
                            int robot = btn[r1];
                            btn.Remove(robot);
                            robo(robot);
                            this.tour_2.Visible = false;
                            this.tour_1.Visible = true;
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
                btn.Remove(3);
                btn3(this.button3.Text);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") {  }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            Random random = new Random();
                            int r1 = random.Next(1, btn.Count);
                            int robot = btn[r1];
                            btn.Remove(robot);
                            robo(robot);
                            this.tour_2.Visible = false;
                            this.tour_1.Visible = true;
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
                btn.Remove(4);
                btn4(this.button4.Text);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") {  }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            Random random = new Random();
                            int r1 = random.Next(1, btn.Count);
                            int robot = btn[r1];
                            btn.Remove(robot);
                            robo(robot);
                            this.tour_2.Visible = false;
                            this.tour_1.Visible = true;
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
                btn.Remove(5);
                btn5(this.button5.Text);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") {  }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            Random random = new Random();
                            int r1 = random.Next(1, btn.Count);
                            int robot = btn[r1];
                            btn.Remove(robot);
                            robo(robot);
                            this.tour_2.Visible = false;
                            this.tour_1.Visible = true;
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
                btn.Remove(6);
                btn6(this.button6.Text);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") {  }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            Random random = new Random();
                            int r1 = random.Next(1, btn.Count);
                            int robot = btn[r1];
                            btn.Remove(robot);
                            robo(robot);
                            this.tour_2.Visible = false;
                            this.tour_1.Visible = true;
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
                btn.Remove(7);
                btn7(this.button7.Text);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") {  }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            Random random = new Random();
                            int r1 = random.Next(1, btn.Count);
                            int robot = btn[r1];
                            btn.Remove(robot);
                            robo(robot);
                            this.tour_2.Visible = false;
                            this.tour_1.Visible = true;
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
                btn.Remove(8);
                btn8(this.button8.Text);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") {  }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            Random random = new Random();
                            int r1 = random.Next(1, btn.Count);
                            int robot = btn[r1];
                            btn.Remove(robot);
                            robo(robot);
                            this.tour_2.Visible = false;
                            this.tour_1.Visible = true;
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
                btn.Remove(9);
                btn9(this.button9.Text);
                if (!this.feli.Visible)
                {
                    if (this.tour_2.Visible)
                    {
                        if (this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "") {  }
                        if (btn.Count != 0)
                        {
                            Thread.Sleep(1000);
                            Random random = new Random();
                            int r1 = random.Next(1, btn.Count);
                            int robot = btn[r1];
                            btn.Remove(robot);
                            robo(robot);
                            this.tour_2.Visible = false;
                            this.tour_1.Visible = true;

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
                Random random = new Random();
                int r1 = random.Next(0, btn.Count);
                int robot = btn[r1];
                robo(robot);
                btn.Remove(robot);
                this.tour_2.Visible = false;
                this.tour_1.Visible = true;
            }
        
        }

        private void solo_facile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Dispose();
        }
    }
}
