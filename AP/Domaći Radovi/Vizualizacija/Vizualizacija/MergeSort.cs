using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vizualizacija
{
    class MergeSort
    {
        public List<Pravokutnik> Sort(List<Pravokutnik> lista)
        {            
            List<Pravokutnik> lijevo = new List<Pravokutnik>();
            List<Pravokutnik> desno = new List<Pravokutnik>();
            List<Pravokutnik> rezultat = new List<Pravokutnik>();
            
            int sredina = lista.Count / 2;

            if (lista.Count <= 1)
            {
                return lista;
            }
            
            foreach (Pravokutnik p in lista)
            {
                if (lista.IndexOf(p) < sredina)
                {
                    lijevo.Add(p);
                }
                else
                {
                    desno.Add(p);
                }
            }

            lijevo = Sort(lijevo);
            desno = Sort(desno);

            rezultat = Merge(lijevo, desno);
            
            return rezultat;
        }


        public static List<Pravokutnik> Merge(List<Pravokutnik> lijevo, List<Pravokutnik> desno)
        {
            int duzina = lijevo.Count + desno.Count;

            List<Pravokutnik> rezultat = new List<Pravokutnik>();

            int ilijevo = 0; int idesno = 0; int irezultat = 0;

            while (ilijevo < lijevo.Count || idesno < desno.Count)
            {
                if (ilijevo < lijevo.Count && idesno < desno.Count)
                {
                    if (lijevo[ilijevo].PostotakVisine <= desno[idesno].PostotakVisine)
                    {
                        rezultat.Add(lijevo[ilijevo]);
                        ilijevo++;
                        irezultat++;
                    }
                    else
                    {
                        rezultat.Add(desno[idesno]);
                        idesno++;
                        irezultat++;
                    }
                }
                else if (ilijevo < lijevo.Count)
                {
                    rezultat.Add(lijevo[ilijevo]);
                    ilijevo++;
                    irezultat++;
                }
                else if (idesno < desno.Count)
                {
                    rezultat.Add(desno[idesno]);
                    idesno++;
                    irezultat++;
                }
            }


            return rezultat;
        }
    }
}
