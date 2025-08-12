namespace Collect_Input_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                bool exit = CollectInput<bool>("Would you like to exit the program?", "Yes", "No");

                if (exit == true)
                {
                    Console.WriteLine("Goodbye");
                    return;
                }
                else
                {
                    continue;
                }
            }
        }
        public static T CollectInput<T>(string userMessage, string trueString = null, string falseString = null) // Displays a string that was input and collects and returns an int
        {
            while (true)
            {
                Console.WriteLine(userMessage);
                string input = Console.ReadLine();

                try
                {
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Input cannot be empty. Please enter a valid response.");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    if (typeof(T) == typeof(string))
                    {
                        return (T)(object)input;
                    }

                    if (typeof(T) == typeof(char))
                    {
                        if (input.Length != 1)
                        {
                            Console.WriteLine("Input must be a single character. Please enter a valid response.");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        return (T)(object)char.Parse(input);
                    }

                    if (typeof(T) == typeof(int))
                    {
                        if (!int.TryParse(input, out int result))
                        {
                            Console.WriteLine("Input must be a valid integer. Please enter a valid response.");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        return (T)(object)result;
                    }

                    if (typeof(T) == typeof(double))
                    {
                        if (!double.TryParse(input, out double result))
                        {
                            Console.WriteLine("Input must be a valid number with a decimal. Please enter a valid response.");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        return (T)(object)result;
                    }

                    if (typeof(T) == typeof(bool))
                    {
                        bool response;
                        if ((trueString != null) && (falseString != null))
                        {
                            if (input == trueString)
                            {
                                response = true;
                                return (T)(object)response;
                            }
                            else if (input == falseString)
                            {
                                response = false;
                                return (T)(object)response;
                            }
                            else
                            {
                                Console.WriteLine($"Input must be {trueString}/{falseString}. Please enter a valid response.");
                                Console.ReadLine();
                                Console.Clear();
                                continue;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "Please enter a valid response.");
                    continue;
                }
            }
        }// end of CollectInput<T>
    }// Methods go above this line
}
