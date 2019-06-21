using Pandora.NetStandard.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Prog3.RestoDotNet.Model.Entities
{
    [Table("Consumes", Schema = "Resto")]
    public class Consume : IEntity
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Obs { get; set; }

        public virtual IEnumerable<Meal> Meals { get; set; }
        public decimal TotalPrice { get { return Meals.Sum(m => m.Price); } }


        public int TableId { get; set; }
        public virtual Table Table { get; set; }

        public int WaiterId { get; set; }
        public virtual Waiter Waiter { get; set; }

    }
}
