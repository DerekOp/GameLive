using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FireFlyFireworks.Models;
using Microsoft.EntityFrameworkCore;



namespace FireFlyFireworks.Data
{

    public class FireFlyFireworksContext : DbContext
    {
        public FireFlyFireworksContext(DbContextOptions<FireFlyFireworksContext> options)
                : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }

        //public DbSet<FireFlyFireworks.Models.Order> Order { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<Color> Color { get; set; }
        public DbSet<Chem> Chem { get; set; }

    }
}


