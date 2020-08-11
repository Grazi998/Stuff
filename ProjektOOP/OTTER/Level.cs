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
    public partial class Level : Form
    {
        
        public Level()
        {
            InitializeComponent();
        }
        ChooseLevel cl;
        private void btnLevel1_Click(object sender, EventArgs e)
        {
            cl = new ChooseLevel();
            cl.LoadLevel1();
            this.Close();
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            cl = new ChooseLevel();
            cl.LoadLevel2();
            this.Close();
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            cl = new ChooseLevel();
            cl.LoadLevel3();
            this.Close();
        }
    }
}
