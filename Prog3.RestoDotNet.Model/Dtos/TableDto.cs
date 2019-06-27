using Pandora.NetStandard.Core.Interfaces;
using Prog3.RestoDotNet.Model.Entities;
using Prog3.RestoDotNet.Model.Enums;
using System;

namespace Prog3.RestoDotNet.Model.Dtos
{
    public class TableDto : IDto<Table>
    {
        public TableDto(string caption, Guid mapTrackId, TableStateEnum state, TableShapeEnum shape, byte maxChairs)
        {
            Caption = caption;
            BoundedMapId = mapTrackId;
            State = state;
            Shape = shape;
            MaxChairs = maxChairs;
        }

        public Table BaseEntity { get; set; }

        public int Id { get; set; }
        public string Caption { get; set; }
        public Guid BoundedMapId { get; set; }
        public TableStateEnum State { get; set; }
        public TableShapeEnum Shape { get; set; }
        public byte MaxChairs { get; set; }

    }
}
