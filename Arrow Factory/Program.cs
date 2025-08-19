using System.ComponentModel.Design;

namespace Arrow_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arrow arrow = new Arrow();
            bool premade = true;
            while (premade)
            {
                Console.WriteLine("I offer a few premade arrows, or we can make a custom arrow.");
                Console.WriteLine("1 -- Begginer Arrow\n" +
                                  "2 -- Marksman Arrow\n" +
                                  "3 -- Elite Arrow" +
                                  "4 -- Custom Arrow");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput > 4 || userInput < 1)
                {
                    Console.WriteLine("Invalid Input. Please try again.");
                    continue;
                }
                else if (userInput == 1)
                {
                    arrow = Arrow.BegginerArrow();
                    break;
                }
                else if (userInput == 2)
                {
                    arrow = Arrow.MarksmanArrow();
                    break;
                }
                else if (userInput == 3)
                {
                    arrow = Arrow.EliteArrow();
                    break;
                }
            }
            bool customize = true;
            while (customize)
            {
                Console.WriteLine("Lets make and arrow");
                double arrowPrice = Arrow.ArrowPrice(arrow);
                break;
            }
            
            CheckOut(arrow);
        }
        public static void CheckOut(Arrow arrow)
        {
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
    }// Methods go above this line
}
