using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM
{
    class Trazilica
    {
        //konstruktor
        public Trazilica(string s, string p)
        {
            this.str = s;
            this.patt = p;
        }
        //polja
        public string str;
        public string patt;
        //metode
        public List<int> Pronadi()
        {
            List<int>  rijesenje = new List<int>();
            if (str.Length < patt.Length)
            {
                MessageBox.Show("Uzorak ne postoji!");
                //return;
            }
            else
            {
                int duzo=patt.Length-1;
                for(int i = duzo; i < str.Length; i++)
                {
                                   
                    if (patt[duzo] == str[i])
                    {
                        int td=duzo;
                        int ts = i;
                        while (patt[td] == str[ts])
                        {
                            if (td == 0)
                            {
                                rijesenje.Add(ts);
                                break;
                            }
                            td -= 1;
                            ts -= 1;
                        }
                    }
                    
                }
            }
            return rijesenje;
        }
        public List<int> Trazi(string tekst, string uzorak)
        {
            List<int> pozicije = new List<int>();
            

            return pozicije;
        }
    }
}
