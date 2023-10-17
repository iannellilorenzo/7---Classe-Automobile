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
using _7___Classe_Automobile;

namespace _7___Classe_Automobile
{
    public partial class Form1 : Form
    {
        Automobile auto;

        public Form1()
        {
            InitializeComponent();
            auto = new Automobile();

            AccensBot.BackColor = Color.Red;
            Display.Items.Add("Monitoraggio:\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AccensBot_Click(object sender, EventArgs e)
        {
            string message = auto.Accesa();

            if (auto.Accensione)
            {
                AccensBot.BackColor = Color.Green;
                Display.Items.Add(message);
            }
            else
            {
                AccensBot.BackColor = Color.Red;
                Display.Items.Add(message);
            }
        }

        private void AccelBut_Click(object sender, EventArgs e)
        {
            string message = auto.Accelerazione();
            Display.Items.Add(message);
        }

        private void FrenoBut_Click(object sender, EventArgs e)
        {
            string message = auto.Freno();
            Display.Items.Add(message);
        }

        private void MarciaSuBut_Click(object sender, EventArgs e)
        {
            string message = auto.MarceSu();
            Display.Items.Add(message);
        }
    }
}
