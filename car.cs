using System;
using System.Collections.Generic;

public class car
{
  public string MakeModel;
  public int Price;
  public int Miles;
}
public class Program
{
  public static void Main()
  {
  car Porshe = new car();
   Porshe.MakeModel = "Porshe";
   Porshe.Price = 50000;
   Porshe.Miles = 75000;

  car ford = new car();
   ford.MakeModel = "2011 Ford F450";
   ford.Price = 55995;
   ford.Miles = 14241;

  car lexus = new car();
   lexus.MakeModel = "2013 Lexus RX 350";
   lexus.Price = 44700;
   lexus.Miles = 20000;

  car mercedes = new car();
   mercedes.MakeModel = "Mercedes Benz CLS550";
   mercedes.Price = 39900;
   mercedes.Miles = 37979;

   List<car> Cars = new List<car>() {Porshe, ford, lexus, mercedes};

   foreach (car automobile in Cars)
   {
   Console.WriteLine(automobile.MakeModel);
   Console.WriteLine(automobile.Miles);
   }
   Console.WriteLine("Enter Max Price");
   string MaxPrice = Console.ReadLine();
   int maxPrice = int.Parse(MaxPrice);
   List<car> CarsMatchingSeacrh = new List<car>();
   foreach (car automobile in Cars)
   {
     if (automobile.Price < maxPrice)
     {
       CarsMatchingSeacrh.Add(automobile);
     }
   }
   foreach (car automobile in CarsMatchingSeacrh )
   {
     Console.WriteLine(automobile.MakeModel);
   }
  }
}
