namespace The_laws_of_Freach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentSmallest = int.MaxValue; //Start higher than anything in the array.
            
            foreach (int index in array)
            {
                if(index < currentSmallest)currentSmallest = index;
            }
            
            Console.WriteLine(currentSmallest);
        }
    }
}
