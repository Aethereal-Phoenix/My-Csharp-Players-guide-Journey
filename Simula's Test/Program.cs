using System.Globalization;

namespace Simula_s_Test
{
    internal class Program
    {
        enum LockState
        {
            Open,
            Closed,
            Locked
        }
        static void Main(string[] args)
        {
            LockState lockState = LockState.Locked;
            while (true)
            {
                Console.WriteLine($"The chest is currently {lockState}. What would you like to do?");
                string userInput = Console.ReadLine();

                if ( userInput == null )
                {
                    Console.WriteLine("That is an impossible action. Please try again.");
                    continue;
                }
                if (userInput.ToUpper() == "LOCK")
                {
                    if (lockState != LockState.Closed)
                    {
                        Console.WriteLine($"You can't lock the chest while it is {lockState}");
                    }
                    else if (lockState == LockState.Closed)
                    {
                        lockState = LockState.Locked;
                    }
                }
                else if (userInput.ToUpper() == "UNLOCK")
                {
                    if (lockState != LockState.Locked)
                    {
                        Console.WriteLine($"You can't unlock the chest while it is {lockState}");
                    }
                    else if (lockState == LockState.Locked)
                    {
                        lockState = LockState.Closed;
                    }
                }
                else if (userInput.ToUpper() == "CLOSE")
                {
                    if (lockState != LockState.Open)
                    {
                        Console.WriteLine($"You can't close the chest while it is {lockState}");
                    }
                    else if (lockState == LockState.Open)
                    {
                        lockState = LockState.Closed;
                    }
                }
                else if ( userInput.ToUpper() == "OPEN")
                {
                    if (lockState != LockState.Closed)
                    {
                        Console.WriteLine($"You can't open the chest while it is {lockState}");
                    }
                    else if (lockState == LockState.Closed)
                    {
                        lockState = LockState.Open;
                    }
                }
            }
        }
    }
}
