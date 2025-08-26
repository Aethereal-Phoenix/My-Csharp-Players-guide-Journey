using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Color
{
    internal class Color
    {
        private int _red;
        private int _green;
        private int _blue;

        public int Red() => _red;
        public int Green() => _green;
        public int Blue() => _blue;

        // Constructor
        public Color()
        {
            Console.WriteLine("Red(0-255):");
            int redVal = int.Parse(Console.ReadLine());
            Console.WriteLine("Blue(0-255):");
            int blueVal = int.Parse(Console.ReadLine());
            Console.WriteLine("Green(0-255):");
        }

    }

}
