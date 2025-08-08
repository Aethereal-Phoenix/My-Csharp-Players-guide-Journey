namespace The_Magic_Cannon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (!(0 == i % 3) && !(0 == i % 5))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine($"{i} -- Normal");
                }
                else if (0 == i % 3 && 0 == i % 5)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i} -- Fire & Lightning");

                }
                else if (0 == i % 3)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i} -- Fire");
                }
                else if (0 == i % 5)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{i} -- Lightning");
                }
            }
        }
    }
}
