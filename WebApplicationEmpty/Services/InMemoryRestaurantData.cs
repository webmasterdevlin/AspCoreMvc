using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationEmpty.Models;

namespace WebApplicationEmpty.Services
{
//    public class InMemoryRestaurantData : IRestaurantData
//    {
//        private List<Restaurant> _restaurants;
//
//        public InMemoryRestaurantData()
//        {
//            _restaurants = new List<Restaurant>()
//            {
//                new Restaurant {Id = 1, Name = "dev's pizza"},
//                new Restaurant { Id = 2, Name = "ruby's corner"},
//                new Restaurant { Id = 3, Name = "Myrna's kitchenet"},
//            };
//        }
//
//        public IEnumerable<Restaurant> GetAll()
//        {
//            return _restaurants.OrderBy(r => r.Name);
//        }
//
//        public Restaurant Get(int id)
//        {
//            return _restaurants.FirstOrDefault(r => r.Id == id);
//        }
//
//        public Restaurant Add(Restaurant restaurant)
//        {
//            restaurant.Id = _restaurants.Max(r => r.Id) + 1;
//            _restaurants.Add(restaurant);
//            return restaurant;
//        }
//
//        public Restaurant Update(Restaurant restaurant)
//        {
//            
//        }
//    }
}
