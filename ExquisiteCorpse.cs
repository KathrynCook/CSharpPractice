using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Exquisite Corpse! \nLet's make a monster ^ vvv ^ \nWould you like to (1) create your own or (2) create a random monster? Please select 1 or 2: ");
      string userChoice = Console.ReadLine();

      if (userChoice == "1"){
        BuildACreature();
      }
      else if (userChoice == "2") {
        RandomMode();
      }
      else {
        Console.WriteLine("Hmm. That's not one of the numbers I know! Sorry! Try again next time.");
      }

      static void BuildACreature(){
        Console.WriteLine("For each of the following choices, please select monster, bug or ghost!");
        Console.WriteLine("What head should we use? (Monster, bug or ghost)");
        int headNum = TranslateToNumber(Console.ReadLine());

        Console.WriteLine("What body should we use? (Monster, bug or ghost)");
        int bodyNum = TranslateToNumber(Console.ReadLine());

        Console.WriteLine("What feet should we use? (Monster, bug or ghost)");
        int feetNum = TranslateToNumber(Console.ReadLine());

        SwitchCase(headNum, bodyNum, feetNum);
      }

      static void RandomMode(){
        Random randomNumber = new Random();

        int head = randomNumber.Next(1,4);
        int body = randomNumber.Next(1,4);
        int feet = randomNumber.Next(1,4);

        SwitchCase(head, body, feet);
      }

      static void SwitchCase(int head, int body, int feet){
        switch (head) {
          case 1:
            GhostHead();
            break;
          case 2:
            BugHead();
            break;
          case 3:
            MonsterHead();
            break;
        }

        switch (body){
          case 1:
            GhostBody();
            break;
          case 2:
            BugBody();
            break;
          case 3:
            MonsterBody();
            break;
        }

        switch (feet) {
          case 1:
            GhostFeet();
            break;
          case 2:
            BugFeet();
            break;
          case 3:
            MonsterFeet();
            break;
        }
      }

      static int TranslateToNumber(string creature){
        switch(creature){
          case "ghost":
            return 1;
          case "bug":
            return 2;
          case "monster":
            return 3;
          default:
            return 1;
        }
      }

    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
