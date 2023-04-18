using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = new string[] {"Water has three molecules", "Blackboxes in airplanes are black", "Goldfish have three second memories", "An octopus has three hearts", "According to Scotish law it is illegal to be in charge of a cow while drunk", "The Great Wall of China is visible from space", "Quizzes are fun"};
      bool[] answers = new bool[] {true, false, false,true, true, false, true};
      bool[] responses = new bool[questions.Length];

      if (questions.Length != answers.Length){
        Console.WriteLine("Ahh! Questions and answers don't match! Panic!");
      }
      
      var askingIndex = 0;
      foreach(var question in questions){
        bool inputBool;
        bool isBool;
        Console.WriteLine(question);
        Console.WriteLine("True or false? ");
        string input = Console.ReadLine();
        isBool = Boolean.TryParse(input, out inputBool);
        while(!isBool){
          Console.WriteLine("Please respond 'true' or 'false'.");
          string reply = Console.ReadLine();
          isBool = Boolean.TryParse(reply, out inputBool);
        }
        responses[askingIndex] = inputBool;
        askingIndex++;
      }

      int scoringIndex = 0;
      int score = 0;
      foreach (var answer in answers){
        var userReply = responses[scoringIndex];
        Console.WriteLine($"{scoringIndex + 1}. Input: {userReply} | Answer: {answers[scoringIndex]}");
        if (userReply == answers[scoringIndex])
          score++;
        scoringIndex++;
      }

      Console.WriteLine($"You got {score} out of {answers.Length} right!");
    }
  }
}
