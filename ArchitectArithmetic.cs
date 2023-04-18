using System;

namespace ArchitectArithmetic
{ 
  class Program
  {
    public static void Main(string[] args)
    {
      static double RectangleArea(double length, double width)
      {
        return length * width;
      }

      static double CircleArea(double radius) 
      {
        return Math.PI * Math.Pow(radius, 2);
      }

      static double TriangleArea(double bottom, double height) 
      {
        return 0.5 * bottom * height;
      }

      //Console.WriteLine(RectangleArea(4, 5));
      //Console.WriteLine(CircleArea(4));
      //Console.WriteLine(TriangleArea(10, 9));

      double Teotihuacan = RectangleArea(1500, 2500) + (0.5*CircleArea(375)) + TriangleArea(500, 750);

      double TeotihuacanCost = Math.Round(Teotihuacan * 180, 2);

      Console.WriteLine($"It would cost {TeotihuacanCost} pesos if we built our own Teotihuacan today!");

      double TajArea = RectangleArea(90.5, 90.5) - (2 * RectangleArea(24, 24));
      double TajCost = Math.Round(TajArea * 180, 2);
      Console.WriteLine($"It would cost {TajCost} pesos to build our own Taj Mahal today!");

      double MeccaArea = RectangleArea(180, 106) + RectangleArea(284, 264) - TriangleArea(264, 84);
      double MeccaCost = Math.Round(MeccaArea * 180, 2);
      Console.WriteLine($"It would cost us {MeccaCost} pesos to build out own Mecca today!");
    }
  }
}
