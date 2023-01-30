namespace MorpionGame
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Joueurs2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vs_Machine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Joueurs2
            // 
            this.Joueurs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joueurs2.Location = new System.Drawing.Point(122, 305);
            this.Joueurs2.Name = "Joueurs2";
            this.Joueurs2.Size = new System.Drawing.Size(178, 44);
            this.Joueurs2.TabIndex = 0;
            this.Joueurs2.TabStop = false;
            this.Joueurs2.Text = "2 Joueurs";
            this.Joueurs2.UseVisualStyleBackColor = true;
            this.Joueurs2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(148, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 55);
            this.label2.TabIndex = 64;
            this.label2.Text = "Bienvenue dans morpion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vs_Machine
            // 
            this.vs_Machine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vs_Machine.Location = new System.Drawing.Point(505, 305);
            this.vs_Machine.Name = "vs_Machine";
            this.vs_Machine.Size = new System.Drawing.Size(178, 44);
            this.vs_Machine.TabIndex = 65;
            this.vs_Machine.TabStop = false;
            this.vs_Machine.Text = "Vs Machine";
            this.vs_Machine.UseVisualStyleBackColor = true;
            this.vs_Machine.Click += new System.EventHandler(this.Vs_Machine_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MorpionGame.Properties.Resources.istockphoto_511661914_170667a;
            this.ClientSize = new System.Drawing.Size(797, 553);
            this.Controls.Add(this.vs_Machine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Joueurs2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Joueurs2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button vs_Machine;
    }
}