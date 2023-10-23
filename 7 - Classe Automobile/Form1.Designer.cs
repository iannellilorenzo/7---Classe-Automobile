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
            this.AccensioneLabel = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.ListView();
            this.AccelBut = new System.Windows.Forms.Button();
            this.AcceleratoreLabel = new System.Windows.Forms.Label();
            this.FrenoLabel = new System.Windows.Forms.Label();
            this.FrenoBut = new System.Windows.Forms.Button();
            this.MarciaSuLabel = new System.Windows.Forms.Label();
            this.MarciaSuBut = new System.Windows.Forms.Button();
            this.MarciaGiuLabel = new System.Windows.Forms.Label();
            this.MarciaGiuBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PuliziaMonitor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccensBot
            // 
            this.AccensBot.Location = new System.Drawing.Point(621, 49);
            this.AccensBot.Margin = new System.Windows.Forms.Padding(0);
            this.AccensBot.Name = "AccensBot";
            this.AccensBot.Size = new System.Drawing.Size(183, 54);
            this.AccensBot.TabIndex = 0;
            this.AccensBot.UseVisualStyleBackColor = true;
            this.AccensBot.Click += new System.EventHandler(this.AccensBot_Click);
            // 
            // AccensioneLabel
            // 
            this.AccensioneLabel.AutoSize = true;
            this.AccensioneLabel.Location = new System.Drawing.Point(675, 29);
            this.AccensioneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccensioneLabel.Name = "AccensioneLabel";
            this.AccensioneLabel.Size = new System.Drawing.Size(78, 16);
            this.AccensioneLabel.TabIndex = 1;
            this.AccensioneLabel.Text = "Accensione";
            // 
            // Display
            // 
            this.Display.HideSelection = false;
            this.Display.Location = new System.Drawing.Point(13, 381);
            this.Display.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(1439, 351);
            this.Display.TabIndex = 2;
            this.Display.UseCompatibleStateImageBehavior = false;
            this.Display.View = System.Windows.Forms.View.List;
            // 
            // AccelBut
            // 
            this.AccelBut.Location = new System.Drawing.Point(549, 136);
            this.AccelBut.Margin = new System.Windows.Forms.Padding(0);
            this.AccelBut.Name = "AccelBut";
            this.AccelBut.Size = new System.Drawing.Size(144, 46);
            this.AccelBut.TabIndex = 3;
            this.AccelBut.UseVisualStyleBackColor = true;
            this.AccelBut.Click += new System.EventHandler(this.AccelBut_Click);
            // 
            // AcceleratoreLabel
            // 
            this.AcceleratoreLabel.AutoSize = true;
            this.AcceleratoreLabel.Location = new System.Drawing.Point(585, 120);
            this.AcceleratoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AcceleratoreLabel.Name = "AcceleratoreLabel";
            this.AcceleratoreLabel.Size = new System.Drawing.Size(84, 16);
            this.AcceleratoreLabel.TabIndex = 4;
            this.AcceleratoreLabel.Text = "Acceleratore";
            // 
            // FrenoLabel
            // 
            this.FrenoLabel.AutoSize = true;
            this.FrenoLabel.Location = new System.Drawing.Point(789, 120);
            this.FrenoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FrenoLabel.Name = "FrenoLabel";
            this.FrenoLabel.Size = new System.Drawing.Size(42, 16);
            this.FrenoLabel.TabIndex = 6;
            this.FrenoLabel.Text = "Freno";
            // 
            // FrenoBut
            // 
            this.FrenoBut.Location = new System.Drawing.Point(733, 136);
            this.FrenoBut.Margin = new System.Windows.Forms.Padding(0);
            this.FrenoBut.Name = "FrenoBut";
            this.FrenoBut.Size = new System.Drawing.Size(144, 46);
            this.FrenoBut.TabIndex = 5;
            this.FrenoBut.UseVisualStyleBackColor = true;
            this.FrenoBut.Click += new System.EventHandler(this.FrenoBut_Click);
            // 
            // MarciaSuLabel
            // 
            this.MarciaSuLabel.AutoSize = true;
            this.MarciaSuLabel.Location = new System.Drawing.Point(565, 216);
            this.MarciaSuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MarciaSuLabel.Name = "MarciaSuLabel";
            this.MarciaSuLabel.Size = new System.Drawing.Size(116, 16);
            this.MarciaSuLabel.TabIndex = 8;
            this.MarciaSuLabel.Text = "Scala marcia in su";
            // 
            // MarciaSuBut
            // 
            this.MarciaSuBut.Location = new System.Drawing.Point(549, 230);
            this.MarciaSuBut.Margin = new System.Windows.Forms.Padding(0);
            this.MarciaSuBut.Name = "MarciaSuBut";
            this.MarciaSuBut.Size = new System.Drawing.Size(144, 46);
            this.MarciaSuBut.TabIndex = 7;
            this.MarciaSuBut.UseVisualStyleBackColor = true;
            this.MarciaSuBut.Click += new System.EventHandler(this.MarciaSuBut_Click);
            // 
            // MarciaGiuLabel
            // 
            this.MarciaGiuLabel.AutoSize = true;
            this.MarciaGiuLabel.Location = new System.Drawing.Point(748, 216);
            this.MarciaGiuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MarciaGiuLabel.Name = "MarciaGiuLabel";
            this.MarciaGiuLabel.Size = new System.Drawing.Size(120, 16);
            this.MarciaGiuLabel.TabIndex = 10;
            this.MarciaGiuLabel.Text = "Scala marcia in giù";
            // 
            // MarciaGiuBut
            // 
            this.MarciaGiuBut.Location = new System.Drawing.Point(733, 230);
            this.MarciaGiuBut.Margin = new System.Windows.Forms.Padding(0);
            this.MarciaGiuBut.Name = "MarciaGiuBut";
            this.MarciaGiuBut.Size = new System.Drawing.Size(144, 46);
            this.MarciaGiuBut.TabIndex = 9;
            this.MarciaGiuBut.UseVisualStyleBackColor = true;
            this.MarciaGiuBut.Click += new System.EventHandler(this.MarciaGiuBut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 315);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pulizia monitoraggio";
            // 
            // PuliziaMonitor
            // 
            this.PuliziaMonitor.Location = new System.Drawing.Point(640, 331);
            this.PuliziaMonitor.Margin = new System.Windows.Forms.Padding(0);
            this.PuliziaMonitor.Name = "PuliziaMonitor";
            this.PuliziaMonitor.Size = new System.Drawing.Size(144, 46);
            this.PuliziaMonitor.TabIndex = 11;
            this.PuliziaMonitor.UseVisualStyleBackColor = true;
            this.PuliziaMonitor.Click += new System.EventHandler(this.PuliziaMonitor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 743);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PuliziaMonitor);
            this.Controls.Add(this.MarciaGiuLabel);
            this.Controls.Add(this.MarciaGiuBut);
            this.Controls.Add(this.MarciaSuLabel);
            this.Controls.Add(this.MarciaSuBut);
            this.Controls.Add(this.FrenoLabel);
            this.Controls.Add(this.FrenoBut);
            this.Controls.Add(this.AcceleratoreLabel);
            this.Controls.Add(this.AccelBut);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.AccensioneLabel);
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
        private System.Windows.Forms.Label AccensioneLabel;
        private System.Windows.Forms.ListView Display;
        private System.Windows.Forms.Button AccelBut;
        private System.Windows.Forms.Label AcceleratoreLabel;
        private System.Windows.Forms.Label FrenoLabel;
        private System.Windows.Forms.Button FrenoBut;
        private System.Windows.Forms.Label MarciaSuLabel;
        private System.Windows.Forms.Button MarciaSuBut;
        private System.Windows.Forms.Label MarciaGiuLabel;
        private System.Windows.Forms.Button MarciaGiuBut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PuliziaMonitor;
    }
}

