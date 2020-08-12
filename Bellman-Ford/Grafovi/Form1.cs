using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Grafovi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDatoteka_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Datoteka s popisom čvorova i udaljenosti";
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            Graf g = new Graf();

            string dat = dlg.FileName;
            using (StreamReader sr = File.OpenText(dat))
            {
                string linija = sr.ReadLine();
                while (linija != null)
                {
                    string[] s = linija.Split(';');

                    //spremi u graf
                    
                    CvorGrafa poc = new CvorGrafa(char.Parse(s[0]));
                    CvorGrafa kraj = new CvorGrafa(char.Parse(s[1]));
                    int tezina = int.Parse(s[2]);
                    g.DodajBrid(poc, kraj, tezina);
                    //sljedeća
                    linija = sr.ReadLine();
                }
            }

            //računanje i ispis udaljenosti
            g.BellmanFord(0, rtbIspis);
        }
    }
}
