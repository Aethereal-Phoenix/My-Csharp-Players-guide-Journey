namespace The_Triangle_Farmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of the base of the triangle:");
            double triangleBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height of the triangle:");
            double triangleHeight = double.Parse(Console.ReadLine());

            double triangleArea = ((triangleBase * triangleHeight) / 2);

            Console.WriteLine($"Area: {triangleArea}");
        }
    }
}
