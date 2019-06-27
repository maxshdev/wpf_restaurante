using Pandora.NetStandard.Core.Interfaces;
using Prog3.RestoDotNet.Model.Entities;

namespace Prog3.RestoDotNet.Model.Dtos
{
    public class OrderDto : IDto<Order>
    {
        public Order BaseEntity { get; set; }
    }

}
