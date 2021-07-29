using System;
using System.Collections.Generic;
using LunchBuddies.LunchBuddies;
using LunchBuddies.Restaurants;

namespace LunchBuddies
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Lunch Buddies!");
      var checkitout = "";
      List<LunchBuddy> colleagues = new List<LunchBuddy>();
      var john = new LunchBuddy("John", "Maple");
      var juan = new LunchBuddy("Juan", "Davila");
      var chris = new LunchBuddy("Chris", "Meffley");
      var martin = new LunchBuddy("Martin", "Sisk");
      colleagues.Add(john);
      colleagues.Add(juan);
      colleagues.Add(chris);
      colleagues.Add(martin);

      checkitout = juan.Eat();
      juan.Eat("Pizza");
      juan.Eat(colleagues);
      juan.Eat("nachos", colleagues);
    }
  }
}
