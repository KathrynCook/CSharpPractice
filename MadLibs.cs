using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a short MadLibs Game! Fill in the blanks with the indicated part of speech to make a unique story of your very own.
      Author: Kathryn Cook
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Ready? Let's go! Start creating your story!");

      // Give the Mad Lib a title:
      string title = "Once Upon a Time... Stuff Went Down";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();

      Console.Write("How about some adjectives? Pick an adjective: ");
      string adj1 = Console.ReadLine();
      Console.Write("And another adjective: ");
      string adj2 = Console.ReadLine();
      Console.Write("One more adjective: ");
      string adj3 = Console.ReadLine();

      Console.Write("Let's add a verb: ");
      string verb = Console.ReadLine();

      Console.Write("This story could use some nouns. Choose a noun: ");
      string noun1 = Console.ReadLine();
      Console.Write("One more noun, please: ");
      string noun2 = Console.ReadLine();

      Console.Write("Now for the fun bits! Pick an animal: ");
      string animal = Console.ReadLine();

      Console.Write("How about a food: ");
      string food = Console.ReadLine();

      Console.Write("Let's have a fruit too: ");
      string fruit = Console.ReadLine();

      Console.Write("And a superhero: ");
      string superhero = Console.ReadLine();

      Console.Write("Choose a country: ");
      string country = Console.ReadLine();

      Console.Write("What about a dessert: ");
      string dessert = Console.ReadLine();

      Console.Write("And last but not least! Pick a year: ");
      string year = Console.ReadLine();

      // The template for the story:

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
