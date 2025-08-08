namespace The_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int captainsNumber;
            while (true)
            {
                Console.WriteLine("Alright Captain, please enter a number between 1 and 100");
                captainsNumber = int.Parse(Console.ReadLine());
                if (1 > captainsNumber || 100 < captainsNumber)
                {
                    Console.WriteLine("That is an invalid choice, please try again.");
                    Console.ReadKey(true);
                    Console.Clear();
                    continue;
                }
                Console.Clear();
                break;
            }

            while (true)
            {
                Console.Write("Enter your guess: ");
                int huntersNumber = int.Parse(Console.ReadLine());

                if (!(captainsNumber == huntersNumber))
                {
                    if (captainsNumber > huntersNumber)
                    {
                        Console.WriteLine($"{huntersNumber} is less that the number you are trying to guess");
                    }
                    else if (captainsNumber < huntersNumber)
                    {
                        Console.WriteLine($"{huntersNumber} is more than the number you are trying to guess");
                    }
                    Console.WriteLine("Please try again");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("You guessed correctly. Congratulations!!!");
                    break;
                }
            }
        }
    }
}
