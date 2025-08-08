namespace Watchtower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Watchtower";

            Console.Write("Please enter the x axis value for the enemies position: ");
            int xValue = int.Parse(Console.ReadLine());
            Console.Write("Please enter the y axis value fo the enemies position: ");
            int yValue = int.Parse(Console.ReadLine());

            if (0 > xValue)
            {
                if (0 < yValue)
                {
                    Console.WriteLine("The enemy approaches from the NW");
                }
                else if (0 == yValue)
                {
                    Console.WriteLine("The enemy approaches from the W");
                }
                else if (0 > yValue)
                {
                    Console.WriteLine("The enemy approaches from the SW");
                }
            }
            else if ( 0 == xValue)
            {
                if (0 < yValue)
                {
                    Console.WriteLine("The enemy approaches from the North");
                }
                else if (0 == yValue)
                {
                    Console.WriteLine("The enemy is already within our walls");
                }
                else if (0 > yValue)
                {
                    Console.WriteLine("The enemy approaches from the S");
                }
            }
            else if ( 0 < xValue)
            {
                if (0 < yValue)
                {
                    Console.WriteLine("The enemy approaches from the NE");
                }
                else if (0 == yValue)
                {
                    Console.WriteLine("The enemy approaches from the E");
                }
                else if (0 > yValue)
                {
                    Console.WriteLine("The enemy approaches from the SE");
                }
            }
        }
    }
}
