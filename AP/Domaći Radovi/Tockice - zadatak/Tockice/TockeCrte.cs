using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tockice
{
    class Linija
    {
        private Point pocetak, kraj;
        private Graphics g;
        private Pen myPen;

        public Linija(Tocka A, Tocka B, Graphics grafika)
        {
            pocetak = new Point(A.x, A.y);
            kraj = new Point(B.x, B.y);
            g = grafika;

            myPen = new Pen(Color.Black);
            myPen.Width = 2;
        }

        public void Crtaj()
        {
            g.DrawLine(myPen, pocetak, kraj);
        }
    }
    public class Tocka
    {
        public int x, y;

        private int velicina;
        private Pen myPen;
        private Graphics g;

        public void Crtaj()
        {
            myPen.Color = Color.Black;
            g.DrawEllipse(myPen, this.x, this.y, this.velicina, this.velicina);
        }

        public void CrtajCrveno()
        {
            myPen.Color = Color.Red;
            g.DrawEllipse(myPen, this.x, this.y, this.velicina, this.velicina);
        }

        public Tocka(int xk, int yk, Graphics grafika)
        {
            this.x = xk;
            this.y = yk;

            this.velicina = 5;
            myPen = new Pen(Color.Black);
            myPen.Width = velicina;

            g = grafika;
        }
    }

}
