using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("What amount should we convert to coins? ");
      string input = Console.ReadLine();
      double amount = -321;
      while (amount == -321) {
        try {
          amount = Convert.ToDouble(input);
          amount = Math.Floor(amount);
          break;
        } catch (FormatException e) {
          Console.WriteLine("Hey... that doesn't look like a number! Trying picking a number for the amount. ");
          break;
        }
      }

      Console.WriteLine("What currency should we use? (Cents or Mubbles?) ");
      string currency = Console.ReadLine().ToLower();

      int goldValue = 0;
      int silverValue = 0;
      int bronzeValue = 0;

      switch (currency){
        case "cents":
          goldValue = 10;
          silverValue = 5;
          bronzeValue = 1;
          break;
        case "mubbles":
          goldValue = 7;
          silverValue = 3;
          bronzeValue = 1;
          break;
        default:
          Console.WriteLine("Huh... I don't recognize that one. Maybe try again?");
          System.Environment.Exit(0);
          break;
        }

      Console.WriteLine($"{amount} {currency} is equal to...");
      
      double goldCoins = amount / goldValue;
      goldCoins = Math.Floor(goldCoins);
      double remainingPostGold = amount % goldValue;
      double silverCoins = Math.Floor(remainingPostGold / silverValue);
      double bronzeCoins = remainingPostGold % silverValue;

      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {bronzeCoins}");
    }
  }
}
