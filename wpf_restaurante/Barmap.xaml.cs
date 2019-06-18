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
using System.Windows.Shapes;

namespace wpf_restaurante
{
    /// <summary>
    /// Lógica de interacción para Barmap.xaml
    /// </summary>
    public partial class Barmap : Window
    {
        public Barmap()
        {
            InitializeComponent();
        }

        private void Add_Table(object sender, RoutedEventArgs e)
        {
            Table tbl = new Table();
            tbl.Height = 100;
            tbl.Width = 100;

            canvasBarMain.Children.Add(tbl);
        }
    }
}
