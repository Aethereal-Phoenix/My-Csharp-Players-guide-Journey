using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Point
{
    internal class Point
    {
        private int X {  get; set; } 
        private int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

    }
}
