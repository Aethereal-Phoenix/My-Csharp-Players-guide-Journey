using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow_Factory
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
        // Fields
        private Arrowhead _arrowhead;
        private Fletching _fletching;
        private int _lengthCM;

        // Properties
        public Arrowhead Arrowhead { get => _arrowhead; set => _arrowhead = value; }
        public Fletching Fletching { get => _fletching; set => _fletching = value; }
        public int LengthCM { get => _lengthCM; set => _lengthCM = value; }

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
        public static double ArrowPrice(Arrow arrow)
        {
            double arrowheadCost = 0;
            double fletchingCost = 0;
            double lengthCost = 0;
            double totalCost = 0;

            if (arrow.Arrowhead == Arrowhead.Steel)
            {
                arrowheadCost = 10.00;
            }
            else if (arrow.Arrowhead == Arrowhead.Wood)
            {
                arrowheadCost = 3.00;
            }
            else if (arrow.Arrowhead == Arrowhead.Obsidian)
            {
                arrowheadCost = 5.00;
            }

            if (arrow.Fletching == Fletching.Plastic)
            {
                fletchingCost = 10.00;
            }
            else if (arrow.Fletching == Fletching.Turkey)
            {
                fletchingCost = 5.00;
            }
            else if (arrow.Fletching == Fletching.Goose)
            {
                fletchingCost = 3.00;
            }

            lengthCost = arrow.LengthCM * .05;

            totalCost = arrowheadCost + fletchingCost + lengthCost;
            return totalCost;
        }

        public static Arrow EliteArrow()
        {
            Arrow eliteArrow = new Arrow();
            eliteArrow.Arrowhead = Arrowhead.Steel;
            eliteArrow.Fletching = Fletching.Plastic;
            eliteArrow.LengthCM = 95;
            return eliteArrow;
        }

        public static Arrow BegginerArrow()
        {
            Arrow begginerArrow = new Arrow();
            begginerArrow.Arrowhead = Arrowhead.Wood;
            begginerArrow.Fletching = Fletching.Goose;
            begginerArrow.LengthCM = 75;
            return begginerArrow;
        }

        public static Arrow MarksmanArrow()
        {
            Arrow marksmanArrow = new Arrow();
            marksmanArrow.Arrowhead = Arrowhead.Steel;
            marksmanArrow.Fletching = Fletching.Goose;
            BegginerArrow().LengthCM = 65;
            return marksmanArrow;
        }
        // Constructor
        public Arrow()
        {
            _arrowhead = ArrowheadSelector();
            _fletching = FletchingSelector();
            _lengthCM = LengthSelector();
        }
    }// End of Arrow Class
}
