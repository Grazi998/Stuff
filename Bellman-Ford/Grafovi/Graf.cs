using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Grafovi
{

    class CvorGrafa
    {
        public char Oznaka;
        public CvorGrafa(char oz)
        {
            this.Oznaka = oz;
        }
    }

    class Graf
    {
        // klasa se može definirati i unutar druge klase
        // mora li biti public?
        public class Brid
        {
            public CvorGrafa pocetak, kraj;
            public int tezina;
        };

        int brCvor, brBrid;
        public List<Brid> Bridovi;
        public List<CvorGrafa> Cvorovi;


        // Graf ima listu bridova i čvorova
        // nećemo raditi matricu jer ne moramo unaprijed znati broj čvorova

        public Graf()
        {
            Cvorovi = new List<CvorGrafa>();
            Bridovi = new List<Brid>();
            // inicijalizacija
        }

        public void DodajBrid(CvorGrafa poc, CvorGrafa kraj, int t)
        {
            Brid b = new Brid();
            Bridovi.Add(b);
            b.pocetak = poc;
            b.kraj = kraj;
            b.tezina = t;

            if (!Cvorovi.Contains(poc))
            {
                Cvorovi.Add(poc);
            }
            if (!Cvorovi.Contains(kraj))
            {
                Cvorovi.Add(kraj);
            }

            this.brBrid = Bridovi.Count;
            this.brCvor = Cvorovi.Count;
           //sprema bridove i čvorove
        }

        public void BellmanFord(int pocetni, RichTextBox rtb)
        {
            Graf g = this;

            int brCv = g.brCvor;
            int brBr = g.brBrid;

            Dictionary<char, int> dict = new Dictionary<char, int>();

            // 1. postavi sve udaljenosti na beskonačno, početni na 0
            foreach(CvorGrafa c in g.Cvorovi)
            {
                dict[c.Oznaka] = int.MaxValue;
            }
            CvorGrafa cg = this.Cvorovi[pocetni];
            dict[cg.Oznaka] = 0;

            // 2. računaj n-1 puta za svaki čvor, n je broj bridova
            
            for (int i = 0; i < g.Cvorovi.Count; i++)
            {
                
                for(int j = 0; j < brBr; j++)
                {
                    char u = g.Bridovi[j].pocetak.Oznaka;
                    char v = g.Bridovi[j].kraj.Oznaka;
                    int tezinaUV = g.Bridovi[j].tezina;
                    if (dict[u] != int.MaxValue && dict[v] > dict[u] + tezinaUV)
                    {
                        dict[v] = dict[u] + tezinaUV;
                    }
                }
            }

            for(int j = 0; j < brBr; j++)
            {
                char u = g.Bridovi[j].pocetak.Oznaka;
                char v = g.Bridovi[j].kraj.Oznaka;
                int tezinaUV = g.Bridovi[j].tezina;
                if (dict[u] != int.MaxValue && dict[v] > dict[u] + tezinaUV)
                {
                    MessageBox.Show("Graf ima negativne cikluse");
                }
            }
            foreach(char k in dict.Keys)
            {
                rtb.AppendText(k.ToString() + "\t" + dict[k] + "\n");
            }
            // https://www.geeksforgeeks.org/bellman-ford-algorithm-dp-23/
        }
    }
}
