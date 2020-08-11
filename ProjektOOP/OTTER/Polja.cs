using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTTER
{
    class Polja : Sprite
    {
        public Polja(int xkor, int ykor, string s = "sprites\\RedSquare.png") :
            base(s, xkor, ykor)
        {
            base.Heigth = 100;
            base.Width = 100;
        }


    }

    class Kugla : Sprite
    {
        public Kugla(string s, int xkor, int ykor) :
            base(s, xkor, ykor)
        {
            this.Width = 100;
            this.Heigth = 100;
        }

        private bool pokrenuta=true;

        public override int X
        {
            get
            {
                return base.X;
            }
            set
            {
                if (value + base.Width > GameOptions.RightEdge)
                {
                    this.Pokrenuta = false;
                    base.X = GameOptions.RightEdge - this.Width;
                    
                }
                else if (value < 0)
                {
                    this.Pokrenuta = false;
                    base.X = 0;
                }
                else
                {
                    
                    base.X = value;
                }
            }
        }

        public override int Y
        {
            get
            {
                return base.Y;
            }
            set
            {
                if (value + base.Heigth >= GameOptions.DownEdge)
                {
                    this.pokrenuta = false;
                    base.Y = GameOptions.DownEdge - this.Heigth;
                }
                else if (value <= 0)
                {
                    this.pokrenuta = false;
                    base.Y = 0;
                }
                else
                {
                    base.Y = value;
                }
            }
        }

        public bool Pokrenuta { get => pokrenuta; set => pokrenuta = value; }
    }
}
