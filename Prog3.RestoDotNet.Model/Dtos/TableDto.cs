using Pandora.NetStandard.Core.Interfaces;
using Prog3.RestoDotNet.Model.Entities;
using Prog3.RestoDotNet.Model.Enums;
using System;

namespace Prog3.RestoDotNet.Model.Dtos
{
    public class TableDto : IDto<Table>
    {
        public TableDto()
        {

        }
        public TableDto(string caption, int moveableTableId, Guid mapTrackId, TableStateEnum state, TableShapeEnum shape, byte maxChairs)
        {
            Caption = caption;
            MoveableTableId = moveableTableId;
            BoundedMapId = mapTrackId;
            State = state;
            Shape = shape;
            MaxChairs = maxChairs;
        }

        public Table BaseEntity { get; set; }

        public int Id { get; set; }
        public string Caption { get; set; }
        public int MoveableTableId { get; set; }
        public Guid BoundedMapId { get; set; }
        public TableStateEnum State { get; set; }
        public TableShapeEnum Shape { get; set; }
        public byte MaxChairs { get; set; }

    }
}
