using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            RedPrioriteta r = new RedPrioriteta(10);
            //int[] kk = new int[] { 2, 5, 10, 3, 4, 6, 7, 1, 9, 8 };
            int[] kk = new int[] { 12,15,5,3,7,2,18,11,4,10 };

            Random g = new Random();
            for (int i = 0; i < kk.Length; i++)
                //r.Umetni(g.Next(1, 100), "xy");
                r.Umetni(kk[i], "xy");

            for (int i = 0; i < r.count; i++)
                Console.Write(r.Elementi[i].kljuc + " ");
            
            Console.WriteLine();

            while (r.count != 0)
            {
                Console.Write(r.BrisiMin().kljuc + " ");
            }
            Console.ReadKey();
        }
    }
}
