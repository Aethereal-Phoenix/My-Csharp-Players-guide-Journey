namespace The_Defense_of_Consolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Defense of Consolas";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("Please enter the target blocks horizontal value: ");
            int horizontalTargetBlock = int.Parse(Console.ReadLine());
            Console.Write("Please enter the target blocks verticle value: ");
            int verticalTargetBlock = int.Parse(Console.ReadLine());


            int northernDefenderHorizontal = horizontalTargetBlock;
            int northernDefenderVertical = verticalTargetBlock + 1;
            string northernDefender = $"{northernDefenderHorizontal}, {northernDefenderVertical}";


            int easternDefenderHorizontal = horizontalTargetBlock + 1;
            int easternDefenderVertical = verticalTargetBlock;
            string easternDefender = $"{easternDefenderHorizontal}, {easternDefenderVertical}";


            int southernDefenderHorizontal = horizontalTargetBlock;
            int southernDefenderVertical = verticalTargetBlock - 1;
            string southernDefender = $"{southernDefenderHorizontal}, {southernDefenderVertical}";


            int westernDefenderHorizontal = horizontalTargetBlock - 1;
            int westernDefenderVertical = verticalTargetBlock;
            string westernDefender = $"{westernDefenderHorizontal}, {westernDefenderVertical}";

            Console.WriteLine($"Defender positions");
            Console.WriteLine($"North: {northernDefender}");
            Console.WriteLine($"East: {easternDefender}");
            Console.WriteLine($"South: {southernDefender}");
            Console.WriteLine($"West: {westernDefender}");
            Console.Beep(1000, 500);
            Console.WriteLine("Press anykey to deploy the defenders...");
            Console.ReadKey(true);
        }
    }
}
