using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizualizacija
{
    class BubbleSort
    {
        public List<Pravokutnik> BubbleS(List<Pravokutnik> lista)
        {
            Pravokutnik temp;

            for (int i = 0; i < lista.Count-1; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[i].PostotakVisine > lista[j].PostotakVisine)
                    {
                        temp = lista[i];

                        lista[i] = lista[j];

                        lista[j] = temp;
                    }
                }
            }
            return lista;
        }
        
    }
}
