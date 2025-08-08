namespace Discounted_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select your choice from the available options to see the price");
            Console.WriteLine("1 -- Rope");
            Console.WriteLine("2 -- Torches");
            Console.WriteLine("3 -- Climging Equipment");
            Console.WriteLine("4 -- Clean Water");
            Console.WriteLine("5 -- Machete");
            Console.WriteLine("6 -- Canoe");
            Console.WriteLine("7 -- Food Supplies");
            Console.Write("Please enter your choice: ");
            int userChoice = int.Parse(Console.ReadLine());
            Console.Write("Please enter your name:");
            string userName = Console.ReadLine();

            if ( "Phoenix" == userName )
            {
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Rope cost 5 gold");
                        break;
                    case 2:
                        Console.WriteLine("Torches cost 8 gold");
                        break;
                    case 3:
                        Console.WriteLine("Climbing Equipment cost 12 gold");
                        break;
                    case 4:
                        Console.WriteLine("Clean water cost 1 gold");
                        break;
                    case 5:
                        Console.WriteLine("Machete cost 10 gold");
                        break;
                    case 6:
                        Console.WriteLine("Canoe cost 100 gold");
                        break;
                    case 7:
                        Console.WriteLine("Food Supplies cost 1 gold");
                        break;
                    default:
                        Console.WriteLine("That is not a valid option. Please try again.");
                        break;
                }
            }
            else
            {
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Rope cost 10 gold");
                        break;
                    case 2:
                        Console.WriteLine("Torches cost 16 gold");
                        break;
                    case 3:
                        Console.WriteLine("Climbing Equipment cost 24 gold");
                        break;
                    case 4:
                        Console.WriteLine("Clean water cost 2 gold");
                        break;
                    case 5:
                        Console.WriteLine("Machete cost 20 gold");
                        break;
                    case 6:
                        Console.WriteLine("Canoe cost 200 gold");
                        break;
                    case 7:
                        Console.WriteLine("Food Supplies cost 2 gold");
                        break;
                    default:
                        Console.WriteLine("That is not a valid option. Please try again.");
                        break;
                }
            }
        }
    }
}
