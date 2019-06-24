using Pandora.NetStandard.Core.Interfaces;
using Prog3.RestoDotNet.Model.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prog3.RestoDotNet.Model.Entities
{
    [Table("Tables", Schema = "Resto")]
    public class Table : IEntity
    {
        public int Id { get; set; }
        public TableStateEnum State { get; set; }
        public TableShapeEnum Shape { get; set; }
        public byte MaxChairs { get; set; }
        public virtual IEnumerable<Chair> Chairs { get; set; }
        public virtual IEnumerable<Consume> Consumes { get; set; }
    }
}
