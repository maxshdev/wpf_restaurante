using Pandora.NetStandard.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Prog3.RestoDotNet.Model.Entities
{
    [Table("Orders", Schema = "Resto")]
    public class Order : IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Obs { get; set; }

        public virtual IEnumerable<Meal> Meals { get; set; }
        public decimal TotalPrice { get { return Meals.Sum(m => m.Price); } }


        public int TableId { get; set; }
        [ForeignKey("TableId")]
        public virtual Table Table { get; set; }

        public int WaiterId { get; set; }
        [ForeignKey("WaiterId")]
        public virtual Waiter Waiter { get; set; }

    }
}
