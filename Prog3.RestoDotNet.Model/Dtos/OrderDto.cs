using Pandora.NetStandard.Core.Interfaces;
using Prog3.RestoDotNet.Model.Entities;
using System;
using System.Collections.Generic;

namespace Prog3.RestoDotNet.Model.Dtos
{
    public class OrderDto : IDto<Order>
    {
        public OrderDto()
        {
            Meals = new List<MealDto>();
        }

        public Order BaseEntity { get; set; }

        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Obs { get; set; }

        public virtual List<MealDto> Meals { get; set; }
        public decimal TotalPrice { get; set; }


        public virtual TableDto Table { get; set; }
        public virtual WaiterDto Waiter { get; set; }
    }

}
