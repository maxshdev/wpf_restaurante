using Pandora.NetStandard.Core.Interfaces;
using Prog3.RestoDotNet.Model.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prog3.RestoDotNet.Model.Entities
{
    [Table("Tables", Schema = "Resto")]
    public class Table : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Description { get; set; }
        public TableStateEnum State { get; set; }
        public TableShapeEnum Shape { get; set; }
        public byte MaxChairs { get; set; }
        public virtual IEnumerable<Chair> Chairs { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
