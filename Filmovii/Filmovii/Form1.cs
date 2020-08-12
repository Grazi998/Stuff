using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmovii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int x = r.Next(0, 5);

            string[] film = { "FAST & FURIOUS", "THIS MEANS WAR", "CAPTAIN AMERICA", "WALKING ON SUNSHINE", "FANTASTIC BEASTS", "THE NOTEBOOK" };

            txtPrikaz.Text = film[x];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPrikaz.Text = "";
        }
    }
}
