namespace The_Replicator_of_D_To
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[5];
            Console.WriteLine("Please enter a series of 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            int[] secondArray = new int[5];

            for (int i = 0;i < 5; i++)
            {
                secondArray[i] = firstArray[i];
            }
            Console.WriteLine("First Array");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(firstArray[i]);
            }

            Console.WriteLine("Second Array");
            for (int i = 0;i < 5; i++)
            {
                Console.WriteLine(secondArray[i]);
            }
            Console.ReadKey(true);
        }
    }
}
