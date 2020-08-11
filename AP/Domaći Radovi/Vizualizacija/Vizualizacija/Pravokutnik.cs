using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vizualizacija
{
    public class Pravokutnik
    {
        public Rectangle rec;
        private Pen pen;
        private int postotakVisine;
        private PictureBox pbox;

        public int PostotakVisine
        {
            get
            {
                return postotakVisine;
            }

            set
            {
                if (value < 10)
                    postotakVisine = 10;
                else if (value > 100)
                    postotakVisine = 100;
                else
                    postotakVisine = value;
            }
        }

        public Pravokutnik(int x,int y, int w, int h, PictureBox pb)
        {
            pen = new Pen(Color.Black);
            pen.Width = 2;
            rec = new Rectangle(x, y, w, h);
            PostotakVisine = h;
            pbox = pb;
        }

        //public void Crtaj(Graphics g)
        //{
        //    g.DrawRectangle(pen, rec);
        //}

        public void Crtaj(Graphics g)
        {
            rec.Height = pbox.Height * this.PostotakVisine / 100;
            g.DrawRectangle(pen, rec);
        }
    }
}
