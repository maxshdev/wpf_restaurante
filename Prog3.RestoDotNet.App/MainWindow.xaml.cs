using System.Windows;

namespace wpf_restaurante
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void OnClickBTN(object sender, RoutedEventArgs e)
        {
            Barmap bar = new Barmap();
            bar.Show();
        }

        private void AddMesaClick(object sender, RoutedEventArgs e) {
            Table tbl = new Table();

            mapa.Children.Add(tbl);
        }
    }
}
