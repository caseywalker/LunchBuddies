using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies.Restaurants
{
  class Restaurant
  {
    public string RestaurantName { get; set; }
    private List<string> RestaurantNames { get; set; } = new List<string>();

    public Restaurant()
    {
      RestaurantNames.Add("Cheddars");
      RestaurantNames.Add("Taco Bell");
      RestaurantNames.Add("Burger Republic");
      Random rnd = new Random();
      int randomRestaurant = rnd.Next(0, RestaurantNames.Count);
      RestaurantName = RestaurantNames[randomRestaurant];
    }

  }
}
