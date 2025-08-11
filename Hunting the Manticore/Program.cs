using System.ComponentModel.Design;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.Serialization.Formatters;

namespace Hunting_the_Manticore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int manticoreHealth = 10;
            int consolasHealth = 15;
            int manticoreDistance = ManticoreDistance();
            for (int turnNumber = 1; (manticoreHealth > 0 && consolasHealth > 0); turnNumber++)
            {
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine($"STATUS: Round: {turnNumber} City: {consolasHealth}/15 Manticore: {manticoreHealth}/10");
                int attackDamage = AttackDamage(turnNumber);
                int attackDistance = AttackDistance(manticoreDistance);

                if (attackDistance == manticoreDistance)
                {
                    manticoreHealth -= attackDamage;
                }
                else if (attackDistance != manticoreDistance)
                {
                    consolasHealth -= 1;
                }
            }
            
            if (manticoreHealth <= 0)
            {
                Console.WriteLine("You have successfuly killed the Manticore and saved Consolas");
                Console.Beep();
                Console.ReadKey(true);
            }
            else if (consolasHealth <= 0)
            {
                Console.WriteLine("The Manticore has destroyed Consolas, you will need to try again.");
                Console.Beep();
                Console.ReadKey(true);
            }
        }

        /// <summary>
        /// Writes colored text without going to the next line
        /// </summary>
        /// <param name="text"></param>
        /// <param name="color"></param>
        public static void WriteColored(string text, ConsoleColor color)
        {
            var previousColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = previousColor;
        }

        /// <summary>
        /// Determines what type of attack will be made based on the turn, rrturns the damage ammount and writes the attack text
        /// </summary>
        /// <param name="turnNumber"></param>
        /// <returns></returns>
        public static int AttackDamage(int turnNumber)
        {
            int attackDamage = 0;
            Console.Write("The cannon is expected to deal ");
            if (turnNumber % 5 == 0 && turnNumber % 3 == 0)
            {
                attackDamage = 10;
                WriteColored($"{attackDamage} Fire-Lightning", ConsoleColor.Blue);
            }
            else if (turnNumber % 5 == 0 && turnNumber % 3 != 0)
            {
                attackDamage = 3;
                WriteColored($"{attackDamage} Lightning", ConsoleColor.Magenta);
            }
            else if (turnNumber % 5 != 0 && turnNumber % 3 == 0)
            {
                attackDamage = 3;
                WriteColored($"{attackDamage} Fire", ConsoleColor.Red);
            }
            else if ( turnNumber % 5 != 0 && turnNumber % 3 != 0)
            {
                attackDamage = 1;
                WriteColored($"{attackDamage}", ConsoleColor.Green);
            }
            Console.Write(" Damage to the Manticore\n");
            return attackDamage;
        }

        public static int AttackDistance(int manticoreDistance)
        {
            while (true)
            {
                Console.Write("Enter desired cannon range: ");
                int attackDistance = int.Parse(Console.ReadLine());

                if (attackDistance < 0 || attackDistance > 100)
                {
                    Console.WriteLine($"{attackDistance} is invalid, please try again.");
                    continue;
                }
                Console.Write("That round ");
                if (attackDistance > manticoreDistance)
                {
                    WriteColored("OVERSHOT", ConsoleColor.DarkRed);
                }
                else if (attackDistance < manticoreDistance)
                {
                    WriteColored("UNDERSHOT", ConsoleColor.DarkGreen);
                }
                else if (attackDistance == manticoreDistance)
                {
                    WriteColored("HIT", ConsoleColor.Cyan);
                }
                
                Console.Write(" the Manticore\n");
                return attackDistance;
            }

        }
        
        /// <summary>
        /// Has the user determine the distance the Manticore will be from Consolas
        /// </summary>
        /// <param name="programerTurn"></param>
        /// <returns></returns>
        public static int ManticoreDistance()
        {
            int distanceToCity = -1;
            while (true)
            {
                Console.Write("Pilot please enter how far away you want to station the Manticore: ");
                distanceToCity = int.Parse(Console.ReadLine());
                Console.Clear();
                
                if (distanceToCity < 0 || distanceToCity > 100)
                {
                    Console.WriteLine("Your input is invalid please try again.");
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine($"Distance to city: {distanceToCity}\nIs this correct? Y/N");
                    char userResponse = char.Parse(Console.ReadLine());
                    Console.Clear();

                    if (userResponse == 'Y' || userResponse == 'y')
                    {
                        Console.WriteLine("Very well.");
                        Console.Clear();
                        return distanceToCity;
                    }
                    else if (userResponse == 'N' || userResponse == 'n')
                    {
                        Console.WriteLine("Very well. We will try again.");
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid response. Please try again.");
                        Console.Clear();
                        continue;
                    }
                }
            }
        }
    }// Methods go above this line
}