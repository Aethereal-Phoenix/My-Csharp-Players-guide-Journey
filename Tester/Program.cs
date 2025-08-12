namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter an int i.e 123");
                try
                {
                    int userInt = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("You entered an invalid format. Please try again.");
                    Console.WriteLine(ex);
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("This is for all exceptions, not just a specific type.");
                    Console.WriteLine(ex);
                    continue;
                }
                Console.WriteLine("You have entered a valid input");
                break;
            }
            Console.WriteLine("You have exited the while loop.");
        }
    }
}
