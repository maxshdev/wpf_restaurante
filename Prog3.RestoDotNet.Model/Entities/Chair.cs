using Pandora.NetStandard.Core.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prog3.RestoDotNet.Model.Entities
{
    [Table("Chairs", Schema = "Resto")]
    public class Chair : IEntity
    {
        [Key]
        public int Id { get; set; }
        public bool IsAvailable { get; set; }
        public int TableId { get; set; }

        [ForeignKey("TableId")]
        public virtual Table Table { get; set; }
    }
}
