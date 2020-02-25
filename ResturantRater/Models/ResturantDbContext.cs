using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ResturantRater.Models
{
    public class ResturantDbContext : DbContext
    {
        public ResturantDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<Resturant> Resturants { get; set; }
    }
}