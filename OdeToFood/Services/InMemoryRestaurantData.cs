using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{ ID=1,Name="Poco Loco"},
                new Restaurant{ ID=2,Name="Gino's"},
                new Restaurant{ ID=3,Name="Grande"}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r=>r.Name);
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.ID == id);
        }

        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.ID = _restaurants.Max(r => r.ID) + 1;
            _restaurants.Add(restaurant);

            return restaurant;
        }

        public Restaurant Update(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        List<Restaurant> _restaurants;
    }
}
