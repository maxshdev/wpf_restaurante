using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;

namespace wpf_restaurante
{
    /// <summary>
    /// Lógica de interacción para Table.xaml
    /// </summary>
    public partial class Table : UserControl
    {

        private Point mouseLocation;
        
        private TranslateTransform transPoint;

        private bool obj_moving = false;
        private Point point_origin;

        public Table()
        {
            InitializeComponent();
        }

        private void UserControl_MouseMove(object sender, MouseEventArgs e)
        {
            //Table uc = (Table)sender;
            mouseLocation = e.GetPosition(this);
            transPoint = new TranslateTransform(point_origin.X, point_origin.Y);

            if (e.LeftButton == MouseButtonState.Pressed)
            {
                transPoint.X = (mouseLocation.X - point_origin.X);
                transPoint.Y = (mouseLocation.Y - point_origin.Y);
                this.RenderTransform = transPoint;
            }

            
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //if (e.ChangedButton == MouseButton.Left)
            //{
            //    obj_moving = true;
            //    point_origin = e.GetPosition(this);
            //}
            //e.Handled = true;
            /*
            mouseLocation = e.GetPosition(this);
            point_origin = new Point(mouseLocation.X, mouseLocation.Y);
            transPoint = new TranslateTransform(point_origin.X, point_origin.Y);
            */
        }

        private void UserControl_MouseUp(object sender, MouseEventArgs e) => obj_moving = false;

        
    }
}
