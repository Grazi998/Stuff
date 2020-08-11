using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTTER
{
    /// <summary>
    /// Game options
    /// </summary>
    static class GameOptions
    {
        
        public static int SpriteHeight = 50;
        public static int SpriteWidth = 50;
        public static int Speed = 10;

        public static int LeftEdge = 0;
        public static int RightEdge = ChooseLevel.Width - 10;
        public static int UpEdge = 0;
        public static int DownEdge = ChooseLevel.Height - 35;

        //public int RightEdge1 { get => rightEdge; set => rightEdge = value; }
        //public int DownEdge1 { get => downEdge; set => downEdge = value; }


        //public GameOptions(int x, int y)
        //{
        //    this.rightEdge = x;
        //    this.downEdge = y;
        //}
    }
}
