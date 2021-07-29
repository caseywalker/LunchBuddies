using LunchBuddies.Restaurants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies.LunchBuddies
{
  class LunchBuddy
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Restaurant Diner { get; set; }

    public LunchBuddy(string firstname, string lastname)
    {
      FirstName = firstname;
      LastName = lastname;
      Diner = new Restaurant();
    }

    public string Eat()
    {
      Console.WriteLine($"{FirstName} {LastName} is eating at {Diner.RestaurantName}");
      return Diner.RestaurantName;
    }

    public void Eat(string food)
    {
      Console.WriteLine($"{FirstName} {LastName} ate {food} at the office.");
    }

    public void Eat(List<LunchBuddy> companions)
    {
      var returnString = $"{FirstName} {LastName} is eating at {Diner.RestaurantName} with ";

      for (var i = 0; i < companions.Count; i++)
      {
        if (i < companions.Count -1)
        {
          returnString += $"{companions[i].FirstName}, ";
        }
        else
        {
          returnString += $"and {companions[i].FirstName}.";
        }
      }
      Console.WriteLine(returnString);
    }

    public void Eat(string food, List<LunchBuddy> companions)
    {
      var returnString = $"{FirstName} {LastName} ordered the {food} at {Diner.RestaurantName} with ";

      for (var i = 0; i < companions.Count; i++)
      {
        if (i < companions.Count - 1)
        {
          returnString += $"{companions[i].FirstName}, ";
        }
        else
        {
          returnString += $"and {companions[i].FirstName}.";
        }
      }
      Console.WriteLine(returnString);
    }
  }
}
