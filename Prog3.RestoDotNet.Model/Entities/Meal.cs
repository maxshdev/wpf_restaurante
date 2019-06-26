using Pandora.NetStandard.Core.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prog3.RestoDotNet.Model.Entities
{
    [Table("Meals", Schema = "Resto")]
    public class Meal : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
    }
}
