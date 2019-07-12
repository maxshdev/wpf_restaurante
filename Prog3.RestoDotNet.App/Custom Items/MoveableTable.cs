using Prog3.RestoDotNet.Model.Dtos;
using Prog3.RestoDotNet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3.RestoDotNet.App
{
    public class MoveableTable : MoveableObject
    {
        public new TableDto BoundedEntity { get; set; }
        public override string ToString()
        {
            return $"{ BoundedEntity?.Caption} { BoundedEntity?.Shape}";
        }
    }
}
