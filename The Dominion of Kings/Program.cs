namespace The_Dominion_of_Kings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Provinces do you rule over?");
            int provinces = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Duchies do you rule over?");
            int duchies = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Estates do you rule over?");
            int estates = int.Parse(Console.ReadLine());

            int totalPoints = 0;

            totalPoints += (provinces * 6);
            totalPoints += (duchies * 3);
            totalPoints += (estates * 1);

            Console.WriteLine($"Total Points: {totalPoints}");
        }
    }
}
