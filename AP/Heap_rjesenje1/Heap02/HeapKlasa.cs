using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heap02
{
    class HeapKlasa
    {
        public void Bubble(int[] niz)
        {
            int n = niz.Length;
            bool zamjena = true;

            while (zamjena)
            {
                zamjena = false;
                for (int i = 0; i < n - 1; i++)
                    if (niz[i] > niz[i + 1])
                    {
                        int t = niz[i];
                        niz[i] = niz[i + 1];
                        niz[i + 1] = t;
                        zamjena = true;
                    }
                n--;
            }
        }

        public void NapraviHeap(int[] niz)
        {
            int brElemenata = niz.Length;
            for (int p = (brElemenata - 1) / 2; p >= 0; p--)
                MaxHeapify(niz, brElemenata, p);

        }


        public void Heap_Sort(int[] niz)
        {
            int brElemenata=niz.Length;

            for (int i = niz.Length - 1; i > 0; i--)
            {
                //Swap
                int temp = niz[i];
                niz[i] = niz[0];
                niz[0] = temp;

                brElemenata--;
                MaxHeapify(niz, brElemenata, 0);
            }

        }

        private void MaxHeapify(int[] niz, int brojElemenata, int index)
        {
            int lijevo = (index + 1) * 2 - 1;
            int desno = (index + 1) * 2;
            int najveci = 0;

            if (lijevo < brojElemenata && niz[lijevo] > niz[index])
                najveci = lijevo;
            else
                najveci = index;

            if (desno < brojElemenata && niz[desno] > niz[najveci])
                najveci = desno;

            if (najveci != index)
            {
                int temp = niz[index];
                niz[index] = niz[najveci];
                niz[najveci] = temp;

                MaxHeapify(niz, brojElemenata, najveci);
            }
        }
    }
}
