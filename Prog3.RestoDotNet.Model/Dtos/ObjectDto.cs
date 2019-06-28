using Pandora.NetStandard.Core.Interfaces;
using Prog3.RestoDotNet.Model.Entities;
using Prog3.RestoDotNet.Model.Enums;
using System;

namespace Prog3.RestoDotNet.Model.Dtos
{
    public class ObjectDto : IDto<ObjectOther>
    {
        public ObjectDto(string caption, Guid mapTrackId, TableShapeEnum shape, byte maxChairs)
        {
            Caption = caption;
            BoundedMapId = mapTrackId;
            Shape = shape;
            MaxChairs = maxChairs;
        }

        public ObjectOther BaseEntity { get; set; }

        public int Id { get; set; }
        public string Caption { get; set; }
        public Guid BoundedMapId { get; set; }
        public TableShapeEnum Shape { get; set; }
        public byte MaxChairs { get; set; }
    }
}
