using Pandora.NetStandard.Core.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prog3.RestoDotNet.Model.Entities
{
    [Table("Waiters", Schema = "Resto")]
    public class Waiter : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
