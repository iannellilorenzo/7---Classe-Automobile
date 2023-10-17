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
            this.SuspendLayout();
            // 
            // AccensBot
            // 
            this.AccensBot.Location = new System.Drawing.Point(53, 109);
            this.AccensBot.Margin = new System.Windows.Forms.Padding(0);
            this.AccensBot.Name = "AccensBot";
            this.AccensBot.Size = new System.Drawing.Size(137, 44);
            this.AccensBot.TabIndex = 0;
            this.AccensBot.UseVisualStyleBackColor = true;
            this.AccensBot.Click += new System.EventHandler(this.AccensBot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accensione";
            // 
            // Jarvis
            // 
            this.Jarvis.HideSelection = false;
            this.Jarvis.Location = new System.Drawing.Point(1003, 13);
            this.Jarvis.Name = "Jarvis";
            this.Jarvis.Size = new System.Drawing.Size(494, 814);
            this.Jarvis.TabIndex = 2;
            this.Jarvis.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 839);
            this.Controls.Add(this.Jarvis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccensBot);
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
    }
}

