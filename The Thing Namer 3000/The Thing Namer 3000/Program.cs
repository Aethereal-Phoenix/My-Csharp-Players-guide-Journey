namespace The_Thing_Namer_3000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of thing are we talking about?");
            string a = Console.ReadLine(); // Variable should be called thing
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string b = Console.ReadLine(); // Variable should be called thingDescription
            string c = " of Doom"; /*I do not understand why this is a variable*/ // Added a space to make itwork better. 
            string d = "3000"; // Again this doesnt need to be a variable
            Console.WriteLine("The " + b + " " + a /*There was a " of " here but it is not needed because c already has it*/+ c + " " + d + "!");
        }
    }
}
