using System.Runtime.InteropServices;

namespace The_Four_Sisters_and_the_Duckbear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of eggs that were collected today:");
            int eggsCollected = int.Parse(Console.ReadLine());

            int eggsForDuckbear = eggsCollected % 4;
            int eggsForEachSister = (eggsCollected - eggsForDuckbear) / 4;

            Console.WriteLine($"Each sister will get: {eggsForEachSister}");
            Console.WriteLine($"The Duckbear will get: {eggsForDuckbear}");
        }
    }
}
