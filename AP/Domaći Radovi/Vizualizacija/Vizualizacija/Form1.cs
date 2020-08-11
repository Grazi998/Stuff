using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vizualizacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            if (pravokutnici.Count > 0)           
                label1.Text = "pb " + pbCrtanje.Height + " " + pravokutnici[0].rec.Height;
            grafika = pbCrtanje.CreateGraphics();
            grafika.Clear(Color.White);
            for (int i = 0; i < pravokutnici.Count; i++)
            {
                pravokutnici[i].Crtaj(grafika);
            }


        }

        Graphics grafika;
        List<Pravokutnik> pravokutnici = new List<Pravokutnik>();

        private void btnCrtajTestni_Click(object sender, EventArgs e)
        {
            Random g = new Random();
            int x = g.Next(0, pbCrtanje.Width - 10);
            int h = g.Next(10, 100);
            Pravokutnik p = new Pravokutnik(x, 0, 10, h, pbCrtanje);
            pravokutnici.Add(p);

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            this.Refresh();
        }
        
        private void btnSort_Click(object sender, EventArgs e)
        {
            
            MergeSort ms = new MergeSort();
            List<Pravokutnik> replika = pravokutnici;            
            pravokutnici = ms.Sort(replika);
            int x = 0;
            foreach(Pravokutnik p in pravokutnici)
            {
                p.rec.X = x;
                x += 30;
            }
            


        }

        private void btnBSort_Click(object sender, EventArgs e)
        {
            BubbleSort bs = new BubbleSort();
            List<Pravokutnik> replika = pravokutnici;
            pravokutnici = bs.BubbleS(replika);
            int x = 0;
            foreach (Pravokutnik p in pravokutnici)
            {
                p.rec.X = x;
                x += 30;
            }
        }
    }
}
