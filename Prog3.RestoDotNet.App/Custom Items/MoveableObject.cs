using System.Drawing;
using System.Windows.Forms;

namespace Prog3.RestoDotNet.App
{
    public class MoveableObject : PictureBox
    {
        public int Id { get; set; }
        public virtual object BoundedEntity { get; set; }
        public Point CurrentPosition { get; set; }
    }
}
