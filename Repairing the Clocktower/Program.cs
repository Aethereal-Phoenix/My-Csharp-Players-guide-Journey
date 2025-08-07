namespace Repairing_the_Clocktower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int clockInput = int.Parse(Console.ReadLine());

            if (clockInput % 2 == 0)
            {
                Console.WriteLine("Tick");
            }
            else
            {
                Console.WriteLine("Tock");
            }
        }
    }
}
