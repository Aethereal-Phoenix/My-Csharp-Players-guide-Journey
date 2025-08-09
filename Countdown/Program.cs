namespace Countdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to countdown from");
            int userInput = int.Parse(Console.ReadLine());
            Countdown(userInput);
            
            void Countdown(int currentNumber)
            {
                if (currentNumber == 0)
                {
                    return;
                }
                Console.WriteLine(currentNumber);
                Countdown(currentNumber - 1);
            }
        }
    }// Methods go above this line
}
