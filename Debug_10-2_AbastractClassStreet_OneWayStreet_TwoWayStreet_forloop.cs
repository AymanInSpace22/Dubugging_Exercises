// Street is an abstract class
// OneWayStreet and TwoWayStreet derive from Street
// On a OneWayStreet, it is illegal to make a U turn
// On a TwoWayStreet, a U Turn reverses the travelling direction

// Main program creates two Street child objects - one OneWay and one TwoWay
// and demonstrates what happens when you make a U Turn
// on a OneWayStreet and a TwoWayStreet

using static System.Console;
class DebugTen02
{
   static void Main()
   {
      OneWayStreet oak = new OneWayStreet("Oak Avenue", "east");
      TwoWayStreet elm = new TwoWayStreet("Elm Street", "south");
      WriteLine("On " + oak.Name + " " + oak.MakeUTurn());
      WriteLine("On " + oak.Name + " " + oak.MakeUTurn());
      WriteLine("On " + elm.Name + " " + elm.MakeUTurn());
      WriteLine("On " + elm.Name + " " + elm.MakeUTurn());
   }
}
abstract class Street
{
   // protected is best so that way the derived classes can still use it since it doesnt have a property
   protected string name;
   protected string direction;

   // the abstract class can have a constructor that accepts arguments
   // and you can set them eqaul to values in the abstract class
   public Street(string name, string travelDirection)
   {
      this.name = name;
      this.direction = travelDirection;
   }

   // this is a Read-Only property for the name field
   // becuase it only has a get
   public string Name
   {
      get
      {
         return name;
      }
   }

   // here is your abstract method
   // remember it can have no method statements and no parameters
   // it basically sets up the method to be overriden in the derived classes
   public abstract string MakeUTurn();
}


// inheriting from the abstract street class
class OneWayStreet : Street
{

   // if you are inheriting from an abstract class you must implement the same constructor
   // as the abstract class even if it is not adding anything new
   // as you see here 
   public OneWayStreet(string name, string direction) : base(name, direction)
   {
   }

   // here we are overridng our mandatory MakeUTurn method
   // becuase we inherit from abstract class street
   // we must implement the abstract method that was set up
   public override string MakeUTurn()
   {
      string temp = "U Turn is illegal! Was going and still going " + direction;
      return temp;
   }
}




class TwoWayStreet : Street
{
   
   public TwoWayStreet(string name, string direction) : base(name, direction)
   {
   }


   // we are still doing the same thing here but we add in this for loop and logic to do something
   public override string MakeUTurn()
   {
      string wasGoing = direction;
      string[] directions = {"north", "south", "east", "west"};
      string[] oppDirections = {"south", "north", "west", "east"};
      for(int x = 0; x < directions.Length; ++x)
      {
         if(direction.Equals(directions[x]))
         {
            direction = oppDirections[x];
            x = directions.Length;
         }
      }

      string temp = "U Turn successful. Was going " + wasGoing + 
         ". Now going " + direction;
      return temp;      
   }
}
