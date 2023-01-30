namespace MorpionGame
{
    partial class Solo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solo));
            this.back = new System.Windows.Forms.Button();
            this.Difficile = new System.Windows.Forms.Button();
            this.Facile = new System.Windows.Forms.Button();
            this.Moyen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Impossible = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(301, 464);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(194, 58);
            this.back.TabIndex = 67;
            this.back.Text = "<----";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Difficile
            // 
            this.Difficile.BackColor = System.Drawing.Color.DarkOrange;
            this.Difficile.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difficile.Location = new System.Drawing.Point(283, 284);
            this.Difficile.Name = "Difficile";
            this.Difficile.Size = new System.Drawing.Size(232, 58);
            this.Difficile.TabIndex = 68;
            this.Difficile.TabStop = false;
            this.Difficile.Text = "Difficile";
            this.Difficile.UseVisualStyleBackColor = false;
            this.Difficile.Click += new System.EventHandler(this.Difficile_Click);
            // 
            // Facile
            // 
            this.Facile.BackColor = System.Drawing.Color.Green;
            this.Facile.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facile.Location = new System.Drawing.Point(283, 102);
            this.Facile.Name = "Facile";
            this.Facile.Size = new System.Drawing.Size(232, 58);
            this.Facile.TabIndex = 69;
            this.Facile.TabStop = false;
            this.Facile.Text = "Facile";
            this.Facile.UseVisualStyleBackColor = false;
            this.Facile.Click += new System.EventHandler(this.Facile_Click);
            // 
            // Moyen
            // 
            this.Moyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Moyen.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Moyen.Location = new System.Drawing.Point(283, 196);
            this.Moyen.Name = "Moyen";
            this.Moyen.Size = new System.Drawing.Size(232, 58);
            this.Moyen.TabIndex = 70;
            this.Moyen.TabStop = false;
            this.Moyen.Text = "Moyen";
            this.Moyen.UseVisualStyleBackColor = false;
            this.Moyen.Click += new System.EventHandler(this.Moyen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 44);
            this.label1.TabIndex = 71;
            this.label1.Text = "Choisissez La difficulté\r\n";
            // 
            // Impossible
            // 
            this.Impossible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Impossible.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Impossible.Location = new System.Drawing.Point(283, 376);
            this.Impossible.Name = "Impossible";
            this.Impossible.Size = new System.Drawing.Size(232, 58);
            this.Impossible.TabIndex = 72;
            this.Impossible.TabStop = false;
            this.Impossible.Text = "Impossible";
            this.Impossible.UseVisualStyleBackColor = false;
            this.Impossible.Click += new System.EventHandler(this.Impossible_Click);
            // 
            // Solo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MorpionGame.Properties.Resources.istockphoto_511661914_170667a;
            this.ClientSize = new System.Drawing.Size(797, 553);
            this.Controls.Add(this.Impossible);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Moyen);
            this.Controls.Add(this.Facile);
            this.Controls.Add(this.Difficile);
            this.Controls.Add(this.back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Solo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Solo_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button Difficile;
        private System.Windows.Forms.Button Facile;
        private System.Windows.Forms.Button Moyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Impossible;
    }
}