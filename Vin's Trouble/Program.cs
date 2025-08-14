namespace Vin_s_Trouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Lets make and arrow");
                Arrow arrow = new Arrow();
                double arrowPrice = ArrowPrice(arrow);
                Console.WriteLine($"The total cost of that arrow is: {arrowPrice}");
                while (true)
                {
                    Console.WriteLine("Is this correct? Y/N");
                    string userInput = Console.ReadLine();

                    if (userInput.ToUpper() != "Y" && userInput.ToUpper() != "N")
                    {
                        Console.WriteLine("Invalid input please try again.");
                        continue;
                    }
                    else if (userInput.ToUpper() == "Y")
                    {
                        break;
                    }
                    else if (userInput.ToUpper() == "N")
                    {
                        return;
                    }
                }
                Console.WriteLine("How many would you like to order?");
                double totalArrows = int.Parse(Console.ReadLine());

                while (true)
                {
                    Console.WriteLine($"{totalArrows} Is this correct? Y/N");
                    string userInput = Console.ReadLine();

                    if (userInput.ToUpper() != "Y" && userInput.ToUpper() != "N")
                    {
                        Console.WriteLine("Invalid input please try again.");
                        continue;
                    }
                    else if (userInput.ToUpper() == "Y")
                    {
                        break;
                    }
                    else if (userInput.ToUpper() == "N")
                    {
                        return;
                    }
                }
                double totalCost = totalArrows * arrowPrice;
                Console.WriteLine($"Grand total: {totalCost}");
            }
        }
        public static double ArrowPrice(Arrow arrow)
        {
            double arrowheadCost = 0;
            double fletchingCost = 0;
            double lengthCost = 0;
            double totalCost = 0;

            if (arrow._arrowhead == Arrowhead.Steel)
            {
                arrowheadCost = 10.00;
            }
            else if (arrow._arrowhead == Arrowhead.Wood)
            {
                arrowheadCost = 3.00;
            }
            else if (arrow._arrowhead == Arrowhead.Obsidian)
            {
                arrowheadCost = 5.00;
            }

            if (arrow._fletching == Fletching.Plastic)
            {
                fletchingCost = 10.00;
            }
            else if (arrow._fletching == Fletching.Turkey)
            {
                fletchingCost = 5.00;
            }
            else if (arrow._fletching == Fletching.Goose)
            {
                fletchingCost = 3.00;
            }

            lengthCost = arrow._length_cm * .05;

            totalCost = arrowheadCost + fletchingCost + lengthCost;
            return totalCost;
        }
    }// Methods go above this line
}
