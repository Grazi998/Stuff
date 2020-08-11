using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Cvor
    {
        public int kljuc;
        public string vrijednost;
        

        public Cvor(int k, string vr)
        {
            kljuc = k;
            vrijednost = vr;
            
        }

        //public Cvor()
        //{
        //    kljuc = 0;
        //    vrijednost = "";
        //    prazan = true;
        //}
    }

    class RedPrioriteta
    {
        public int Kapacitet;
        public int count;
        public Cvor[] Elementi;
        public RedPrioriteta(int k)
        {
            Kapacitet = k;
            count = 0;
            Elementi = new Cvor[Kapacitet];

            for (int i = 0; i < Kapacitet; i++)
                Elementi[i] = null;
        }

        public void Umetni(int k, string v)
        {
            if (count < Kapacitet)
            {
                int prazni = count;
                Cvor n = new Cvor(k, v);
                //ako je prazan

                //ako je ključ roditelja praznog manji od novog
                //upisati novi na prazno mjesto

                while (true)
                {
                    if (prazni == 0)
                    {
                        Elementi[0] = n;
                        count++;
                        break;
                    }
                    else
                    {
                        int ir = (prazni - 1) / 2;
                        if (Elementi[ir].kljuc < n.kljuc)
                        {
                            Elementi[prazni] = n;
                            count++;
                            break;
                        }
                        else
                        {
                            Elementi[prazni] = Elementi[ir];
                            Elementi[ir] = null;
                            prazni = ir;
                        }
                    }
                }
            }
        }

        public Cvor BrisiMin()
        {
            if (count == 0)
                return null;
            //vrati vrh i stavi zadnji element na vrh
            //ispitaj pravilo gomile
            Cvor izbacen = Elementi[0];
            Elementi[0] = null;
            
            Cvor x = Elementi[count - 1]; //uzmi zadnjeg
            Elementi[count - 1] = null;
            count--;

            if (count == 0)
                return izbacen;

            int prazni = 0;

            while (true)
            {
                //nađi indekse djece od praznog
                int ld = 2 * prazni + 1;
                int dd = 2 * prazni + 2;
                //nađi manje dijete od praznog, ako ga ima
                int manje = -1;
                if (ld < count) //ako ima lijevo dijete
                    if (dd < count) //ako ima i desno dijete
                        manje = Elementi[ld].kljuc < Elementi[dd].kljuc ? ld : dd;
                    else //ako nema desno
                        manje = ld; //onda je traženo mjesto lijevo
                //ako nema ni jedno dijete, onda smjesti x na to prazno mjesto
                if (manje == -1)
                {
                    Elementi[prazni] = x;
                    break; //nema djece
                }
                //ako je ključ od x manji od manjeg djeteta, onda spremi u prazni i završi
                if (x.kljuc < Elementi[manje].kljuc)
                {
                    Elementi[prazni] = x;
                    break;
                }
                else
                {
                    //spremi manjeg u prazni i ponovi
                    Elementi[prazni] = Elementi[manje];
                    
                    Elementi[manje] = null; //manje dijete je sad prazno
                    prazni = manje;
                }
            }
            return izbacen;
        }
    }
}
