using Pandora.NetStandard.Core.Interfaces;
using Prog3.RestoDotNet.Model.Entities;
using Prog3.RestoDotNet.Model.Enums;

namespace Prog3.RestoDotNet.Model.Dtos
{
    public class TableDto : IDto<Table>
    {
        public TableDto(int id, string description, TableStateEnum state, TableShapeEnum shape, byte maxChairs)
        {
            Id = id;
            Description = description;
            State = state;
            Shape = shape;
            MaxChairs = maxChairs;
        }

        public Table BaseEntity { get; set; }

        public int Id { get; set; }
        public string Description { get; set; }
        public TableStateEnum State { get; set; }
        public TableShapeEnum Shape { get; set; }
        public byte MaxChairs { get; set; }

    }
}
