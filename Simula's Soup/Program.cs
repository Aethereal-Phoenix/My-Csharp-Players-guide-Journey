using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace Simula_s_Soup
{
    internal class Program
    {
        public enum Recipes
        {
            None,
            Soup,
            Stew,
            Gumbo
        }

        public enum Ingredients
        {
            None,
            Mushroom,
            Chicken,
            Carrots,
            Potatoes
        }

        public enum Seasonings
        {
            None,
            Spicy,
            Salty,
            Sweet
        }
        static void Main(string[] args)
        {
            while (true)
            {
                (Recipes recipe, Ingredients ingredients, Seasonings seasonings) dinner;
                Console.WriteLine("Welcome, please select what you would like for dinner.");
                dinner.recipe = RecipePicker();
                dinner.ingredients = IngredientPicker();
                dinner.seasonings = SeasoningPicker();

                Console.WriteLine($"{dinner.seasonings} {dinner.ingredients} {dinner.recipe}");
                Console.WriteLine("Is this what you want? Y/N");
                string userInput = Console.ReadLine();

                if (userInput.ToUpper() == "Y")
                {
                    Console.WriteLine("Then that is what we will have for dinner.");
                    return;
                }
                else if (userInput.ToUpper() == "N")
                {
                    Console.WriteLine("Very well we will try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("Please enter a valid input");
                    continue;
                }
            }
        }
        public static Recipes RecipePicker()
        {
            while (true)
            {
                Console.WriteLine("Please pick a recipe from the following");
                Console.WriteLine($"1 -- {Recipes.Soup}");
                Console.WriteLine($"2 -- {Recipes.Stew}");
                Console.WriteLine($"3 -- {Recipes.Gumbo}");
                int[] validChoice = new[] { 1, 2, 3 };
                int userChoice = int.Parse(Console.ReadLine());

                if (!validChoice.Contains(userChoice))
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    continue;
                }
                else if (userChoice == 1)
                {
                    return Recipes.Soup;
                }
                else if (userChoice == 2)
                {
                    return Recipes.Stew;
                }
                else if (userChoice == 3)
                {
                    return Recipes.Gumbo;
                }
            }
        }// End of RecipePicker

        public static Ingredients IngredientPicker()
        {
            while (true)
            {
                Console.WriteLine("Please pick an ingridient from the following");
                Console.WriteLine($"1 -- {Ingredients.Mushroom}");
                Console.WriteLine($"2 -- {Ingredients.Chicken}");
                Console.WriteLine($"3 -- {Ingredients.Carrots}");
                Console.WriteLine($"4 -- {Ingredients.Potatoes}");
                int[] validChoice = new[] { 1, 2, 3, 4 };
                int userChoice = int.Parse(Console.ReadLine());

                if (!validChoice.Contains(userChoice))
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    continue;
                }
                else if (userChoice == 1)
                {
                    return Ingredients.Mushroom;
                }
                else if (userChoice == 2)
                {
                    return Ingredients.Chicken;
                }
                else if (userChoice == 3)
                {
                    return Ingredients.Carrots;
                }
                else if (userChoice == 4)
                {
                    return Ingredients.Potatoes;
                }
            }
        }// End of IngredientPicker

        public static Seasonings SeasoningPicker()
        {
            while (true)
            {
                Console.WriteLine("Please pick a seasoning from the following");
                Console.WriteLine($"1 -- {Seasonings.Spicy}");
                Console.WriteLine($"2 -- {Seasonings.Salty}");
                Console.WriteLine($"3 -- {Seasonings.Sweet}");
                int[] validChoice = new[] { 1, 2, 3 };
                int userChoice = int.Parse(Console.ReadLine());

                if (!validChoice.Contains(userChoice))
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    continue;
                }
                else if (userChoice == 1)
                {
                    return Seasonings.Spicy;
                }
                else if (userChoice == 2)
                {
                    return Seasonings.Salty;
                }
                else if (userChoice == 3)
                {
                    return Seasonings.Sweet;
                }
            }
        }// End of RecipePicker
    }// Methods go above this line
}
