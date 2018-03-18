﻿using System.Collections.Generic;
using WebApplicationEmpty.Models;

namespace WebApplicationEmpty.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant restaurant);
        Restaurant Update(Restaurant restaurant);
    }
}