using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog3.RestoDotNet.App.XmlObjects
{
    public class XmlTable
    {
        public int Id { get; set; }
        public Guid TackId { get; set; }
        public int Bottom { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public String imageFile { get; set; }
    }
}
