namespace _7___Classe_Automobile
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.AccensBot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Jarvis = new System.Windows.Forms.ListView();
            this.AccelBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FrenoBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccensBot
            // 
            this.AccensBot.Location = new System.Drawing.Point(382, 50);
            this.AccensBot.Margin = new System.Windows.Forms.Padding(0);
            this.AccensBot.Name = "AccensBot";
            this.AccensBot.Size = new System.Drawing.Size(183, 54);
            this.AccensBot.TabIndex = 0;
            this.AccensBot.UseVisualStyleBackColor = true;
            this.AccensBot.Click += new System.EventHandler(this.AccensBot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accensione";
            // 
            // Jarvis
            // 
            this.Jarvis.HideSelection = false;
            this.Jarvis.Location = new System.Drawing.Point(946, 13);
            this.Jarvis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Jarvis.Name = "Jarvis";
            this.Jarvis.Size = new System.Drawing.Size(506, 718);
            this.Jarvis.TabIndex = 2;
            this.Jarvis.UseCompatibleStateImageBehavior = false;
            this.Jarvis.View = System.Windows.Forms.View.List;
            // 
            // AccelBut
            // 
            this.AccelBut.Location = new System.Drawing.Point(310, 137);
            this.AccelBut.Margin = new System.Windows.Forms.Padding(0);
            this.AccelBut.Name = "AccelBut";
            this.AccelBut.Size = new System.Drawing.Size(144, 45);
            this.AccelBut.TabIndex = 3;
            this.AccelBut.UseVisualStyleBackColor = true;
            this.AccelBut.Click += new System.EventHandler(this.AccelBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Acceleratore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Freno";
            // 
            // FrenoBut
            // 
            this.FrenoBut.Location = new System.Drawing.Point(493, 137);
            this.FrenoBut.Margin = new System.Windows.Forms.Padding(0);
            this.FrenoBut.Name = "FrenoBut";
            this.FrenoBut.Size = new System.Drawing.Size(144, 45);
            this.FrenoBut.TabIndex = 5;
            this.FrenoBut.UseVisualStyleBackColor = true;
            this.FrenoBut.Click += new System.EventHandler(this.FrenoBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 744);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FrenoBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccelBut);
            this.Controls.Add(this.Jarvis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccensBot);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AccensBot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Jarvis;
        private System.Windows.Forms.Button AccelBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FrenoBut;
    }
}

