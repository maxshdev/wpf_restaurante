namespace Prog3.RestoDotNet.Data.Migrations
{
    using Prog3.RestoDotNet.Model.Entities;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Prog3.RestoDotNet.Data.Dals.RestoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Prog3.RestoDotNet.Data.Dals.RestoDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            context.Waiters.AddOrUpdate(w => w.Id,
                new Waiter { Name = "Juan Perez Mesero" },
                new Waiter { Name = "Jhon Travolta Mesero" },
                new Waiter { Name = "Peteco Carabajal Mesero" }
                );


            base.Seed(context);
        }
    }
}
