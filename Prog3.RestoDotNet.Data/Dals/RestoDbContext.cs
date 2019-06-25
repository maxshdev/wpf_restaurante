
using Pandora.NetStandard.Core.Base;
using Prog3.RestoDotNet.Model.Entities;
using System;
using System.Data.Entity;

namespace Prog3.RestoDotNet.Data.Dals
{
    public class RestoDbContext : DbContext
    {
        public RestoDbContext()
        {

        }


        public DbSet<Table> Tables { get; set; }
        public DbSet<Chair> Chairs { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Waiter> Waiters { get; set; }


    }
}