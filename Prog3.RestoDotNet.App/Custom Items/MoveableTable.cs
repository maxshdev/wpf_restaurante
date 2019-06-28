using Prog3.RestoDotNet.App.Custom_Items;
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
        public new TableDto BindedEntity { get; set; }
        public override string ToString()
        {
            return $"{ BindedEntity?.Caption} { BindedEntity?.Shape}";
        }
    }
}
