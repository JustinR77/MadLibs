internal class Program
{
    private static void Main(string[] args)
    {
        // This program is to have fun with mad libs and practice coding.
        // Author: Justin Rivera

        // Let the user know the program is starting
        Console.WriteLine("Mad Libs is starting...");

        // Give the mad lib a title
        string title = "Fun with Mad Libs";

        // Define user input and variables
        Console.WriteLine("Enter a name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Provide 3 adjectives.");
        Console.WriteLine("Adjective #1: ");
        string adjectiveOne = Console.ReadLine();
        Console.WriteLine("Adjective #2: ");
        string adjectiveTwo = Console.ReadLine();
        Console.WriteLine("Adjective #3: ");
        string adjectiveThree = Console.ReadLine();
        Console.WriteLine("Provide a verb.");
        Console.WriteLine("Verb: ");
        string userVerb = Console.ReadLine();
        Console.WriteLine("Provice 2 nouns.");
        Console.WriteLine("Noun #1: ");
        string nounOne = Console.ReadLine();
        Console.WriteLine("Noun #2: ");
        string nounTwo = Console.ReadLine();
        Console.WriteLine("Provide the following: ");
        Console.WriteLine("An animal: ");
        string animal = Console.ReadLine();
        Console.WriteLine("A food: ");
        string food = Console.ReadLine();
        Console.WriteLine("A fruit: ");
        string fruit = Console.ReadLine();
        Console.WriteLine("A superhero: ");
        string superhero = Console.ReadLine();
        Console.WriteLine("A country: ");
        string country = Console.ReadLine();
        Console.WriteLine("A dessert: ");
        string dessert = Console.ReadLine();
        Console.WriteLine("A year: ");
        string year = Console.ReadLine();

        string story = $"This morning {name} woke up feeling {adjectiveOne}. It is going to be a {adjectiveTwo} day! Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {userVerb} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjectiveThree}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";
    }
}