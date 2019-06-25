using Pandora.NetStandard.Core.Interfaces;
using Prog3.RestoDotNet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prog3.RestoDotNet.Model.Dtos
{
    public class WaiterDto : IDto<Waiter>
    {
        public Waiter BaseEntity { get; set; }
    }
}
