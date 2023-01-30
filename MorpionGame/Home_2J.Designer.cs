namespace MorpionGame
{
    partial class Menu2joueur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu2joueur));
            this.valider = new System.Windows.Forms.Button();
            this.joueur1_en = new System.Windows.Forms.Label();
            this.nom1 = new System.Windows.Forms.TextBox();
            this.joueur2_en = new System.Windows.Forms.Label();
            this.nom2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.erreur = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(316, 330);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(166, 39);
            this.valider.TabIndex = 52;
            this.valider.TabStop = false;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
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
            this.joueur1_en.TabIndex = 53;
            this.joueur1_en.Text = "Joueur 1:";
            // 
            // nom1
            // 
            this.nom1.BackColor = System.Drawing.Color.White;
            this.nom1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom1.Location = new System.Drawing.Point(161, 270);
            this.nom1.Name = "nom1";
            this.nom1.Size = new System.Drawing.Size(140, 27);
            this.nom1.TabIndex = 55;
            // 
            // joueur2_en
            // 
            this.joueur2_en.AutoSize = true;
            this.joueur2_en.BackColor = System.Drawing.Color.Transparent;
            this.joueur2_en.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joueur2_en.ForeColor = System.Drawing.Color.DarkRed;
            this.joueur2_en.Location = new System.Drawing.Point(486, 272);
            this.joueur2_en.Name = "joueur2_en";
            this.joueur2_en.Size = new System.Drawing.Size(108, 26);
            this.joueur2_en.TabIndex = 56;
            this.joueur2_en.Text = "Joueur 2:";
            // 
            // nom2
            // 
            this.nom2.BackColor = System.Drawing.Color.White;
            this.nom2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom2.Location = new System.Drawing.Point(596, 270);
            this.nom2.Name = "nom2";
            this.nom2.Size = new System.Drawing.Size(140, 27);
            this.nom2.TabIndex = 57;
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
            this.label2.TabIndex = 63;
            this.label2.Text = "Bienvenue dans morpion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 16.8F);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(163, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 37);
            this.label3.TabIndex = 64;
            this.label3.Text = "Veuillez saisir les noms des joueurs";
            // 
            // erreur
            // 
            this.erreur.AutoSize = true;
            this.erreur.BackColor = System.Drawing.Color.Transparent;
            this.erreur.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreur.ForeColor = System.Drawing.Color.Red;
            this.erreur.Location = new System.Drawing.Point(193, 417);
            this.erreur.Name = "erreur";
            this.erreur.Size = new System.Drawing.Size(410, 37);
            this.erreur.TabIndex = 65;
            this.erreur.Text = "Veuillez entrer les deux noms";
            this.erreur.Visible = false;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(301, 474);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(194, 58);
            this.back.TabIndex = 66;
            this.back.TabStop = false;
            this.back.Text = "<----";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Menu2joueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MorpionGame.Properties.Resources.istockphoto_511661914_170667a;
            this.ClientSize = new System.Drawing.Size(797, 553);
            this.Controls.Add(this.back);
            this.Controls.Add(this.erreur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nom2);
            this.Controls.Add(this.joueur2_en);
            this.Controls.Add(this.nom1);
            this.Controls.Add(this.joueur1_en);
            this.Controls.Add(this.valider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu2joueur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu2joueur_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Label joueur1_en;
        private System.Windows.Forms.Label joueur2_en;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label erreur;
        public System.Windows.Forms.TextBox nom1;
        public System.Windows.Forms.TextBox nom2;
        private System.Windows.Forms.Button back;
    }
}