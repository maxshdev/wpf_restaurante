using Pandora.NetStandard.Core.Interfaces;
using Prog3.RestoDotNet.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prog3.RestoDotNet.Model.Entities
{
    [Table("Tables", Schema = "Resto")]
    public class Table : IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Caption { get; set; }
        [Required]
        public Guid BoundedMapId { get; set; }
        public TableStateEnum State { get; set; }
        public TableShapeEnum Shape { get; set; }
        public byte MaxChairs { get; set; }
        public virtual IEnumerable<Chair> Chairs { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
