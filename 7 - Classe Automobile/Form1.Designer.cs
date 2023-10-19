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
            this.Display = new System.Windows.Forms.ListView();
            this.AccelBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FrenoBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MarciaSuBut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MarciaGiuBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PuliziaMonitor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccensBot
            // 
            this.AccensBot.Location = new System.Drawing.Point(286, 41);
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
            this.label1.Location = new System.Drawing.Point(326, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accensione";
            // 
            // Display
            // 
            this.Display.HideSelection = false;
            this.Display.Location = new System.Drawing.Point(710, 11);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(380, 584);
            this.Display.TabIndex = 2;
            this.Display.UseCompatibleStateImageBehavior = false;
            this.Display.View = System.Windows.Forms.View.List;
            // 
            // AccelBut
            // 
            this.AccelBut.Location = new System.Drawing.Point(232, 111);
            this.AccelBut.Margin = new System.Windows.Forms.Padding(0);
            this.AccelBut.Name = "AccelBut";
            this.AccelBut.Size = new System.Drawing.Size(108, 37);
            this.AccelBut.TabIndex = 3;
            this.AccelBut.UseVisualStyleBackColor = true;
            this.AccelBut.Click += new System.EventHandler(this.AccelBut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Acceleratore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Freno";
            // 
            // FrenoBut
            // 
            this.FrenoBut.Location = new System.Drawing.Point(370, 111);
            this.FrenoBut.Margin = new System.Windows.Forms.Padding(0);
            this.FrenoBut.Name = "FrenoBut";
            this.FrenoBut.Size = new System.Drawing.Size(108, 37);
            this.FrenoBut.TabIndex = 5;
            this.FrenoBut.UseVisualStyleBackColor = true;
            this.FrenoBut.Click += new System.EventHandler(this.FrenoBut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Scala marcia in su";
            // 
            // MarciaSuBut
            // 
            this.MarciaSuBut.Location = new System.Drawing.Point(232, 188);
            this.MarciaSuBut.Margin = new System.Windows.Forms.Padding(0);
            this.MarciaSuBut.Name = "MarciaSuBut";
            this.MarciaSuBut.Size = new System.Drawing.Size(108, 37);
            this.MarciaSuBut.TabIndex = 7;
            this.MarciaSuBut.UseVisualStyleBackColor = true;
            this.MarciaSuBut.Click += new System.EventHandler(this.MarciaSuBut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Scala marcia in giù";
            // 
            // MarciaGiuBut
            // 
            this.MarciaGiuBut.Location = new System.Drawing.Point(370, 188);
            this.MarciaGiuBut.Margin = new System.Windows.Forms.Padding(0);
            this.MarciaGiuBut.Name = "MarciaGiuBut";
            this.MarciaGiuBut.Size = new System.Drawing.Size(108, 37);
            this.MarciaGiuBut.TabIndex = 9;
            this.MarciaGiuBut.UseVisualStyleBackColor = true;
            this.MarciaGiuBut.Click += new System.EventHandler(this.MarciaGiuBut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pulizia monitoraggio";
            // 
            // PuliziaMonitor
            // 
            this.PuliziaMonitor.Location = new System.Drawing.Point(301, 275);
            this.PuliziaMonitor.Margin = new System.Windows.Forms.Padding(0);
            this.PuliziaMonitor.Name = "PuliziaMonitor";
            this.PuliziaMonitor.Size = new System.Drawing.Size(108, 37);
            this.PuliziaMonitor.TabIndex = 11;
            this.PuliziaMonitor.UseVisualStyleBackColor = true;
            this.PuliziaMonitor.Click += new System.EventHandler(this.PuliziaMonitor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 604);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PuliziaMonitor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MarciaGiuBut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MarciaSuBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FrenoBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccelBut);
            this.Controls.Add(this.Display);
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
        private System.Windows.Forms.ListView Display;
        private System.Windows.Forms.Button AccelBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FrenoBut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button MarciaSuBut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button MarciaGiuBut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PuliziaMonitor;
    }
}

