using Pandora.NetStandard.Core.Interfaces;
using Prog3.RestoDotNet.Model.Entities;

namespace Prog3.RestoDotNet.Model.Dtos
{
    public class TableDto : IDto<Table>
    {
        public Table BaseEntity { get; set; }
    }
}
