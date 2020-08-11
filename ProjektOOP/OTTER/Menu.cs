using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OTTER
{
    public partial class Menu : Form
    {
        
        public List<int> LevelNiz = new List<int>();

        public Menu()
        {
            InitializeComponent();
        }

        private void btnChooseLevel_Click(object sender, EventArgs e)
        {
            Level biraj = new Level();
            biraj.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
