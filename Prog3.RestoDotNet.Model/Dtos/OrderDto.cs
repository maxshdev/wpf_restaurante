using Pandora.NetStandard.Core.Interfaces;
using Prog3.RestoDotNet.Model.Entities;
using System;
using System.Collections.Generic;

namespace Prog3.RestoDotNet.Model.Dtos
{
    public class OrderDto : IDto<Order>
    {
        public Order BaseEntity { get; set; }

        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Obs { get; set; }

        public virtual IEnumerable<Meal> Meals { get; set; }
        public decimal TotalPrice { get; set; }


        public virtual TableDto Table { get; set; }
        public virtual WaiterDto Waiter { get; set; }
    }

}
