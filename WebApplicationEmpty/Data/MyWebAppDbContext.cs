using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationEmpty.Models;

namespace WebApplicationEmpty.Data
{
    public class MyWebAppDbContext : DbContext
    {
        public MyWebAppDbContext(DbContextOptions options)
            : base (options)
        {
            
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
