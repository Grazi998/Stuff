using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OTTER
{
    class Person : Sprite
    {
        private int _bodovi;
        private int _life;
        private string _stop="lijevo";
        
        public Person(string kostim, int xcor, int ycor, int bodovi = 0, int life = 3) :
            base(kostim, xcor, ycor)
        {
            _bodovi = bodovi;
            _life = life;
            
            
        }

        public int Bodovi
        {
            get { return _bodovi; }
            set
            {
                if (value < 0)
                {
                    _bodovi = 0;
                }
                else
                {
                    _bodovi = value;
                }
            }
        }
        public int Life
        {
            get { return _life; }
            set
            {
                if (value < 0)
                {
                    _life = 0;
                }
                else
                {
                    _life = value;
                }
            }
        }        
        public string Stop { get => _stop; set => _stop = value; }

        public override int X
        {
            get
            {
                return base.X;
            }
            set
            {
                if (value < 0)
                {
                    base.X = 0;
                    Stop = "lijevo";
                }
                else if (value > GameOptions.RightEdge - GameOptions.SpriteWidth)
                {
                    base.X = GameOptions.RightEdge - GameOptions.SpriteWidth;
                    Stop = "desno";
                }
                else
                {
                    //Stop = "";
                    base.X = value;
                }
            }
        }

        public bool TouchingSprite(Thing t)
        {
            if (base.TouchingSprite(t))
            {
                t.Active = false;                
                this.Bodovi += t.BodoviVrijednost;
                return true;
            }
            else
            {
                return false;
            }
        }


    }
    public abstract class Thing : Sprite
    {
        private bool active;
        private int bodoviVrijednost;
        private int speed=GameOptions.Speed;

        public bool Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;
            }
        }
        public int BodoviVrijednost
        {
            get
            {
                return bodoviVrijednost;
            }
            set
            {
                bodoviVrijednost = value;
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public Thing(string Kostim, int xkor, int ykor) :
            base(Kostim, xkor, ykor)
        {
            this.active = true;
            this.bodoviVrijednost = 0;
            this.speed = 10;
        }

        public override int Y
        {
            get
            {
                return base.Y;
            }
            set
            {
                if (value >= GameOptions.DownEdge - this.Heigth)
                {
                    active = false;
                    this.Show = false;
                }
                else
                {
                    base.Y = value;
                }
            }            
        }

        public void MoveSteps()
        {
            this.Y += speed;            
        }



    }
    class Petarda : Thing
    {
        public Petarda(string Kostim, int xkor, int ykor) :
            base(Kostim, xkor, ykor)
        {
            this.Show = false;
            this.BodoviVrijednost = -200;
        }
        public delegate void TimeHandler();
        public event TimeHandler _cekaj;
        public void PetardaFall()
        {
            this.Active = true;
            while (Active)
            {
                this.SetDirection(180);
                this.MoveSteps(this.Speed);
                _cekaj.Invoke();
                if (this.Y >= GameOptions.DownEdge - this.Heigth)
                {
                    this.Active = false;
                    break;
                }
            }
        }


    }
    class Poklon : Thing
    {
        public Poklon(string Kostim, int xkor, int ykor) :
            base(Kostim, xkor, ykor)
        {
            this.Show = false;
            this.BodoviVrijednost = 50;
        }

        
        public delegate void LostLife();
        public event LostLife _lostLife;

        public delegate void TimeHandler();
        public event TimeHandler _cekaj;
        

        public override int Y
        {
            get
            {
                return base.Y;
            }
            set
            {
                if (value >= GameOptions.DownEdge - this.Heigth)
                {
                    base.Y = 0;
                    Active = false;
                    this.Show = false;                    
                    _lostLife.Invoke();

                }
                else
                {
                    base.Y = value;
                }
            }
        }

        
        
    }
}
