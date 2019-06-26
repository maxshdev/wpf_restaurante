
using Pandora.NetStandard.Core.Base;
using Prog3.RestoDotNet.Model.Entities;
using System;
using System.Data.Entity;

namespace Prog3.RestoDotNet.Data.Dals
{
    public class RestoDbContext : DbContext
    {
#if DEBUG
        public RestoDbContext() : base("name=DebugConnection") { }
#else
        public RestoDbContext() : base("name=ReleaseConnection") { }
#endif


        public virtual IDbSet<Table> Tables { get; set; }
        public virtual IDbSet<Chair> Chairs { get; set; }
        public virtual IDbSet<Meal> Meals { get; set; }
        public virtual IDbSet<Waiter> Waiters { get; set; }


    }
}