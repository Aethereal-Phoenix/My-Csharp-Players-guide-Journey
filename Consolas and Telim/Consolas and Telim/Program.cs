using System.Net.Security;

namespace Consolas_and_Telim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bread for the city is complete.");
            Console.WriteLine("Please enter the name of the recipient:");
            string recipientName = Console.ReadLine();
            Console.WriteLine($"Recipient: {recipientName}");
        }
    }
}
