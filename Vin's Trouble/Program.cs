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
                double arrowPrice = Arrow.ArrowPrice(arrow);
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
    }// Methods go above this line
}
