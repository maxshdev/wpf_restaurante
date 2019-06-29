using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.Model.Dtos
{
    public class MealDto
    {
        public MealDto(int id, string description, decimal price)
        {
            Id = id;
            Description = description;
            Price = price;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public virtual OrderDto Order { get; set; }

        public override string ToString()
        {
            return $"{Description} {Price.ToString("C")}";
        }
    }
}
