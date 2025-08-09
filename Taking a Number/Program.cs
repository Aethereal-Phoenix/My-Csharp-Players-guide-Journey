namespace Taking_a_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
        }
        int AskForNumberInRange(string text,  int min, int max)
        {
            while (true)
            {
                Console.WriteLine(text);
                int userInput = int.Parse(Console.ReadLine());

                if (min > userInput || max < userInput)
                {
                    Console.WriteLine($"{userInput} is out of the approved parameters. Please try again.");
                }
                else
                {
                    return userInput;
                }
            }
        }
    }// Methods go above this line
}
