// Creates a Car class
// You can construct a Car using a price and color
// or just a price, in which case a Car is black
// or no parameters, in which case a Car is $10,000 and black
using System;
using static System.Console;
using System.Globalization;
class DebugNine3
{
   static void Main()
   {
      Car myCar = new Car(32000, "red");
      Car yourCar = new Car(14000);
      Car theirCar = new Car();
      WriteLine("My {0} car cost {1}", myCar.Color,
         myCar.Price.ToString("c2", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Your {0} car cost {1}",
         yourCar.Color, yourCar.Price.ToString("c2", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Their {0} car cost {1}",
         theirCar.Color, theirCar.Price.ToString("c2", CultureInfo.GetCultureInfo("en-US")));
  }
}
class Car
{
   private string color;
   private int price;

   // Constructors
   //  the this acts as a default values or it can accept an argument
   public Car() : this(10000, "black")
   {
   }
   public Car(int price) : this(price, "black")
   {
     
   }

   // the this in this scenario is basically just explicilty saying this version = that
   public Car(int price, string color)
   {
       this.Price = price;
       this.Color = color;
   }

   // Properties
   public string Color
   {
      get
      {
         return color;
      }
      set
      {
         color = value;
      }
   }
   public int Price
   {
      get
      {
         return price;
      }
      set
      {
         price = value;
      }
   }
}
