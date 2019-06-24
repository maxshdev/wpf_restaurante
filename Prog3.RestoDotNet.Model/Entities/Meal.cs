using Pandora.NetStandard.Core.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prog3.RestoDotNet.Model.Entities
{
    [Table("Meals", Schema = "Resto")]
    public class Meal : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
