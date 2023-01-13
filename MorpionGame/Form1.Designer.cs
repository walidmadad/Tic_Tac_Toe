namespace MorpionGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.changer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.feli = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Label();
            this.nom2 = new System.Windows.Forms.TextBox();
            this.nom1 = new System.Windows.Forms.TextBox();
            this.joueur2_en = new System.Windows.Forms.Label();
            this.joueur1_en = new System.Windows.Forms.Label();
            this.valider = new System.Windows.Forms.Button();
            this.tour2 = new System.Windows.Forms.Label();
            this.tour_1 = new System.Windows.Forms.Label();
            this.score_nul = new System.Windows.Forms.Label();
            this.score_2 = new System.Windows.Forms.Label();
            this.score_1 = new System.Windows.Forms.Label();
            this.rejouer = new System.Windows.Forms.Button();
            this.joueur_2 = new System.Windows.Forms.Label();
            this.joueur_1 = new System.Windows.Forms.Label();
            this.match_null = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changer
            // 
            this.changer.Location = new System.Drawing.Point(415, 491);
            this.changer.Name = "changer";
            this.changer.Size = new System.Drawing.Size(220, 40);
            this.changer.TabIndex = 63;
            this.changer.TabStop = false;
            this.changer.Text = "Changer des joueurs";
            this.changer.UseVisualStyleBackColor = true;
            this.changer.Visible = false;
            this.changer.Click += new System.EventHandler(this.changer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(146, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 55);
            this.label2.TabIndex = 62;
            this.label2.Text = "Bienvenue dans moripon";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 16.8F);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(161, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 37);
            this.label3.TabIndex = 61;
            this.label3.Text = "Veuillez saisir les noms du joueurs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(274, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 52);
            this.label4.TabIndex = 60;
            this.label4.Text = "Tic Tac Toe ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "VS";
            this.label1.Visible = false;
            // 
            // feli
            // 
            this.feli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feli.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.feli.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feli.Location = new System.Drawing.Point(161, 300);
            this.feli.Name = "feli";
            this.feli.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.feli.Size = new System.Drawing.Size(474, 39);
            this.feli.TabIndex = 58;
            this.feli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.feli.UseMnemonic = false;
            this.feli.Visible = false;
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.BackColor = System.Drawing.Color.Transparent;
            this.o.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.ForeColor = System.Drawing.Color.DarkRed;
            this.o.Location = new System.Drawing.Point(533, 68);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(39, 40);
            this.o.TabIndex = 57;
            this.o.Text = "O";
            this.o.Visible = false;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.BackColor = System.Drawing.Color.Transparent;
            this.x.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.ForeColor = System.Drawing.Color.Navy;
            this.x.Location = new System.Drawing.Point(237, 68);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(39, 40);
            this.x.TabIndex = 56;
            this.x.Text = "X";
            this.x.Visible = false;
            // 
            // nom2
            // 
            this.nom2.BackColor = System.Drawing.Color.White;
            this.nom2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom2.Location = new System.Drawing.Point(596, 268);
            this.nom2.Name = "nom2";
            this.nom2.Size = new System.Drawing.Size(140, 27);
            this.nom2.TabIndex = 55;
            // 
            // nom1
            // 
            this.nom1.BackColor = System.Drawing.Color.White;
            this.nom1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom1.Location = new System.Drawing.Point(161, 270);
            this.nom1.Name = "nom1";
            this.nom1.Size = new System.Drawing.Size(140, 27);
            this.nom1.TabIndex = 54;
            // 
            // joueur2_en
            // 
            this.joueur2_en.AutoSize = true;
            this.joueur2_en.BackColor = System.Drawing.Color.Transparent;
            this.joueur2_en.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joueur2_en.ForeColor = System.Drawing.Color.DarkRed;
            this.joueur2_en.Location = new System.Drawing.Point(486, 269);
            this.joueur2_en.Name = "joueur2_en";
            this.joueur2_en.Size = new System.Drawing.Size(108, 26);
            this.joueur2_en.TabIndex = 53;
            this.joueur2_en.Text = "Joueur 2:";
            // 
            // joueur1_en
            // 
            this.joueur1_en.AutoSize = true;
            this.joueur1_en.BackColor = System.Drawing.Color.Transparent;
            this.joueur1_en.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joueur1_en.ForeColor = System.Drawing.Color.Navy;
            this.joueur1_en.Location = new System.Drawing.Point(50, 272);
            this.joueur1_en.Name = "joueur1_en";
            this.joueur1_en.Size = new System.Drawing.Size(103, 26);
            this.joueur1_en.TabIndex = 52;
            this.joueur1_en.Text = "Joueur 1:";
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(316, 330);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(166, 39);
            this.valider.TabIndex = 51;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // tour2
            // 
            this.tour2.AutoSize = true;
            this.tour2.BackColor = System.Drawing.Color.Transparent;
            this.tour2.Location = new System.Drawing.Point(649, 58);
            this.tour2.Name = "tour2";
            this.tour2.Size = new System.Drawing.Size(38, 16);
            this.tour2.TabIndex = 50;
            this.tour2.Text = "Vous";
            this.tour2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tour2.Visible = false;
            // 
            // tour_1
            // 
            this.tour_1.AutoSize = true;
            this.tour_1.BackColor = System.Drawing.Color.Transparent;
            this.tour_1.Location = new System.Drawing.Point(113, 58);
            this.tour_1.Name = "tour_1";
            this.tour_1.Size = new System.Drawing.Size(38, 16);
            this.tour_1.TabIndex = 49;
            this.tour_1.Text = "Vous";
            this.tour_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tour_1.Visible = false;
            // 
            // score_nul
            // 
            this.score_nul.AutoSize = true;
            this.score_nul.BackColor = System.Drawing.Color.Transparent;
            this.score_nul.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_nul.Location = new System.Drawing.Point(459, 117);
            this.score_nul.Name = "score_nul";
            this.score_nul.Size = new System.Drawing.Size(23, 23);
            this.score_nul.TabIndex = 48;
            this.score_nul.Text = "0";
            this.score_nul.Visible = false;
            // 
            // score_2
            // 
            this.score_2.AutoSize = true;
            this.score_2.BackColor = System.Drawing.Color.Transparent;
            this.score_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_2.ForeColor = System.Drawing.Color.DarkRed;
            this.score_2.Location = new System.Drawing.Point(462, 72);
            this.score_2.Name = "score_2";
            this.score_2.Size = new System.Drawing.Size(27, 29);
            this.score_2.TabIndex = 47;
            this.score_2.Text = "0";
            this.score_2.Visible = false;
            // 
            // score_1
            // 
            this.score_1.AutoSize = true;
            this.score_1.BackColor = System.Drawing.Color.Transparent;
            this.score_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_1.ForeColor = System.Drawing.Color.Navy;
            this.score_1.Location = new System.Drawing.Point(315, 72);
            this.score_1.Name = "score_1";
            this.score_1.Size = new System.Drawing.Size(27, 29);
            this.score_1.TabIndex = 46;
            this.score_1.Text = "0";
            this.score_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.score_1.Visible = false;
            // 
            // rejouer
            // 
            this.rejouer.Location = new System.Drawing.Point(161, 491);
            this.rejouer.Name = "rejouer";
            this.rejouer.Size = new System.Drawing.Size(220, 40);
            this.rejouer.TabIndex = 45;
            this.rejouer.TabStop = false;
            this.rejouer.Text = "Rejouer";
            this.rejouer.UseVisualStyleBackColor = true;
            this.rejouer.Visible = false;
            this.rejouer.Click += new System.EventHandler(this.rejouer_Click);
            // 
            // joueur_2
            // 
            this.joueur_2.BackColor = System.Drawing.Color.Transparent;
            this.joueur_2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joueur_2.ForeColor = System.Drawing.Color.DarkRed;
            this.joueur_2.Location = new System.Drawing.Point(583, 74);
            this.joueur_2.Name = "joueur_2";
            this.joueur_2.Size = new System.Drawing.Size(181, 25);
            this.joueur_2.TabIndex = 44;
            this.joueur_2.Text = "Joueur 2";
            this.joueur_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.joueur_2.Visible = false;
            // 
            // joueur_1
            // 
            this.joueur_1.BackColor = System.Drawing.Color.Transparent;
            this.joueur_1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joueur_1.ForeColor = System.Drawing.Color.Navy;
            this.joueur_1.Location = new System.Drawing.Point(33, 74);
            this.joueur_1.Name = "joueur_1";
            this.joueur_1.Size = new System.Drawing.Size(207, 25);
            this.joueur_1.TabIndex = 43;
            this.joueur_1.Text = "Joueur 1";
            this.joueur_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.joueur_1.Visible = false;
            // 
            // match_null
            // 
            this.match_null.AutoSize = true;
            this.match_null.BackColor = System.Drawing.Color.Transparent;
            this.match_null.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.match_null.Location = new System.Drawing.Point(309, 113);
            this.match_null.Name = "match_null";
            this.match_null.Size = new System.Drawing.Size(142, 29);
            this.match_null.TabIndex = 42;
            this.match_null.Text = "Match nul :";
            this.match_null.Visible = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("MV Boli", 24.2F);
            this.button9.Location = new System.Drawing.Point(463, 375);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 100);
            this.button9.TabIndex = 41;
            this.button9.TabStop = false;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("MV Boli", 24.2F);
            this.button8.Location = new System.Drawing.Point(353, 375);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 100);
            this.button8.TabIndex = 40;
            this.button8.TabStop = false;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("MV Boli", 24.2F);
            this.button7.Location = new System.Drawing.Point(240, 375);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 100);
            this.button7.TabIndex = 39;
            this.button7.TabStop = false;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(463, 269);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 100);
            this.button6.TabIndex = 38;
            this.button6.TabStop = false;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(353, 269);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 37;
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(240, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 36;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("MV Boli", 24.2F);
            this.button3.Location = new System.Drawing.Point(463, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 35;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("MV Boli", 24.2F);
            this.button2.Location = new System.Drawing.Point(353, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 34;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("MV Boli", 24.2F);
            this.button1.Location = new System.Drawing.Point(240, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 33;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MorpionGame.Properties.Resources.istockphoto_511661914_170667a;
            this.ClientSize = new System.Drawing.Size(797, 553);
            this.Controls.Add(this.changer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.feli);
            this.Controls.Add(this.o);
            this.Controls.Add(this.x);
            this.Controls.Add(this.nom2);
            this.Controls.Add(this.nom1);
            this.Controls.Add(this.joueur2_en);
            this.Controls.Add(this.joueur1_en);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.tour2);
            this.Controls.Add(this.tour_1);
            this.Controls.Add(this.score_nul);
            this.Controls.Add(this.score_2);
            this.Controls.Add(this.score_1);
            this.Controls.Add(this.rejouer);
            this.Controls.Add(this.joueur_2);
            this.Controls.Add(this.joueur_1);
            this.Controls.Add(this.match_null);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label feli;
        private System.Windows.Forms.Label o;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.TextBox nom2;
        private System.Windows.Forms.TextBox nom1;
        private System.Windows.Forms.Label joueur2_en;
        private System.Windows.Forms.Label joueur1_en;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Label tour2;
        private System.Windows.Forms.Label tour_1;
        private System.Windows.Forms.Label score_nul;
        private System.Windows.Forms.Label score_2;
        private System.Windows.Forms.Label score_1;
        private System.Windows.Forms.Button rejouer;
        private System.Windows.Forms.Label joueur_2;
        private System.Windows.Forms.Label joueur_1;
        private System.Windows.Forms.Label match_null;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

