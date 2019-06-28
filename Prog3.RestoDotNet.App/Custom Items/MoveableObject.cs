using Prog3.RestoDotNet.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3.RestoDotNet.App.Custom_Items
{
    public class MoveableObject : PictureBox
    {
        public int Id { get; set; }
        public virtual object BindedEntity { get; set; }
        public Point CurrentPosition { get; set; }        
    }
}
