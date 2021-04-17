// Handles a Format Exception if user does not enter a number
using System;
using static System.Console;
using System.Globalization;
class DebugEleven01
{
   static void Main()
   {
      // always make sure to set the variable equal to 0;
      double salary = 0;
      string salVal;
      // typically you will want to set the boolean value to false. 
      bool isValidSalary = false;
      // that way you can put not(!) and then the boolean name
      while(!isValidSalary)
      {
      // realisitically you dont even need a try parse here. but this is how you would do it
      // however this could all be done with just an if statement plus an else
         try
         {
            Write("Enter an employee's salary ");
            salVal = ReadLine();
            if(double.TryParse(salVal, out salary))
              isValidSalary = true;
            else    
              throw new FormatException();  
            
         }
         catch(FormatException)
         {
            WriteLine("You must enter a number for the salary.");
         }
      }
      WriteLine("The salary {0} is valid", salary.ToString("C2", CultureInfo.GetCultureInfo("en-US")));
   }
}
