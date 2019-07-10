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

        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
