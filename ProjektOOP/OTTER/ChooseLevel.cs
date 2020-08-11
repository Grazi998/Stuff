using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OTTER
{
    class ChooseLevel
    {
        static public List<int> LevelNiz=new List<int>();
        static public int Width;
        static public int Height;

        //Učitaj levele
        public void LoadLevel1()
        {
            int[] niz = { 16, 17, 20, 25, 34, 33, 39, 41, 55, 57, 59, 75, 79 };
            Width = 910;
            Height = 935;
            LevelNiz.AddRange(niz);
            
            

            MessageBox.Show("Učitan Level 1 !");
        }

        public void LoadLevel2()
        {
            int[] niz = { 9, 10, 11, 12, 13, 14, 17, 18, 22, 24, 35, 36, 38, 39, 40, 50, 51, 52, 54, 62, 65, 66, 67, 68, 69, 70 };
            Width = 810;
            Height = 1135;
            LevelNiz.AddRange(niz);
            MessageBox.Show("Učitan Level 2 !");
        }

        public void LoadLevel3()
        {
            MessageBox.Show("Učitan Level 3 !");
        }
    }
}
