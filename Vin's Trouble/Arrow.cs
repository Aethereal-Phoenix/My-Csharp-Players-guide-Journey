using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vin_s_Trouble
{
    enum Arrowhead
    {
        None,
        Steel,
        Wood,
        Obsidian
    }

    enum Fletching
    {
        None,
        Plastic,
        Turkey,
        Goose
    }
    internal class Arrow
    {
        // Properties
        private Arrowhead _arrowhead;
        private Fletching _fletching;
        private int _length_cm;

        // Getters
        public Arrowhead GetArrowhead() => _arrowhead;
        public Fletching GetFletching() => _fletching;
        public int GetLength() => _length_cm;

        // Methods
        public Arrowhead ArrowheadSelector()
        {
            while (true)
            {
                Console.WriteLine("What sort of arrowhead would you like?");
                foreach (Arrowhead arrowhead in Enum.GetValues(typeof(Arrowhead)))
                {
                    Console.WriteLine($"{arrowhead}");
                }
                Console.WriteLine("Please enter the name of the arrowhead you would like?");
                string userChoice = Console.ReadLine();

                foreach (Arrowhead arrowhead in Enum.GetValues(typeof(Arrowhead)))
                {
                    string arrowheadString = arrowhead.ToString();
                    if (userChoice.ToUpper() == arrowheadString.ToUpper())
                    {
                        return arrowhead;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

        }

        public Fletching FletchingSelector()
        {
            while (true)
            {
                Console.WriteLine("What sort of arrowhead would you like?");
                foreach (Fletching fletching in Enum.GetValues(typeof(Fletching)))
                {
                    Console.WriteLine($"{fletching}");
                }
                Console.WriteLine("Please enter the name of the arrowhead you would like?");
                string userChoice = Console.ReadLine();

                foreach (Fletching fletching in Enum.GetValues(typeof(Fletching)))
                {
                    string fletchingString = fletching.ToString();
                    if (userChoice.ToUpper() == fletchingString.ToUpper())
                    {
                        return fletching;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

        }

        public int LengthSelector()
        {
            while (true)
            {
                Console.WriteLine("Please enter the length of the arrow shaft in increments of 1 cm.\nThe arrow can be as short as 60 cm and as long as 100 cm");
                int length = int.Parse(Console.ReadLine());

                if (length < 60 || length > 100)
                {
                    Console.WriteLine("That length is not available please try again.");
                    continue;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine($"You have selected: {length}\nIs this correct? Y/N");
                        string userChoice = Console.ReadLine();

                        if (userChoice.ToUpper() != "Y" && userChoice.ToUpper() != "N")
                        {
                            Console.WriteLine("Please select either Y or N");
                        }
                        else if (userChoice.ToUpper() == "Y")
                        {
                            return length;
                        }
                        else if (userChoice.ToUpper() == "N")
                        {
                            Console.WriteLine("Very well. We will try again.");
                            break;
                        }
                    }
                }
            }
        }
        // Constructor
        public Arrow()
        {
            _arrowhead = ArrowheadSelector();
            _fletching = FletchingSelector();
            _length_cm = LengthSelector();
        }
    }// End of Arrow Class
}
