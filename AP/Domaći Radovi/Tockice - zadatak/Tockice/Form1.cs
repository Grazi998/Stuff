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

namespace Tockice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double Udaljenost(Tocka a, Tocka b)
        {

            double x = Math.Pow(a.x - b.x, 2);
            double y = Math.Pow(a.y - b.y, 2);
            double udaljenost = Math.Sqrt(x + y);

            return udaljenost;
        }

        private void btnCrtaj_Click(object sender, EventArgs e)
        {
            Tocka min1=tocke[0];
            Tocka min2=tocke[1];
            double minUdaljenost=int.MaxValue;
            for(int i = 0; i < tocke.Count-1; i++)
            {
                for(int j = i + 1; j < tocke.Count; j++)
                {
                    if (Udaljenost(tocke[i], tocke[j])<minUdaljenost)
                    {
                        minUdaljenost = Udaljenost(tocke[i], tocke[j]);
                        min1 = tocke[i];
                        min2 = tocke[j];
                    }
                }
            }

            Linija l = new Linija(min1, min2, gr);
            l.Crtaj();
            lblIspis.Text = minUdaljenost.ToString();
        }

        List<Tocka> tocke = new List<Tocka>();
        Graphics gr;

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            tocke.Clear();
            gr = pbCrtanje.CreateGraphics();
            gr.Clear(Color.White);

            string imed = "koor.txt";
            using (StreamReader sr = File.OpenText(imed))
            {
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {
                    string[] toc = linija.Split(';');
                    Tocka T = new Tocka(int.Parse(toc[0]), int.Parse(toc[1]), gr);
                    tocke.Add(T);
                }
            }
            foreach(Tocka t in tocke)
            {
                t.Crtaj();
            }
        }

        private void Random_Click(object sender, EventArgs e)
        {
            tocke.Clear();
            
            gr = pbCrtanje.CreateGraphics();
            gr.Clear(Color.White);
            Random r = new Random();

            while(true)
            {
                
                int a = r.Next(0, 500);
                int b = r.Next(0, 500);
                Tocka x = new Tocka(a, b, gr);
                if (!tocke.Contains(x))
                {
                    tocke.Add(x);
                }
                if (tocke.Count == 10)
                {
                    break;
                }
            }
            foreach(Tocka t in tocke)
            {
                t.Crtaj();
            }
        }
    }
}
