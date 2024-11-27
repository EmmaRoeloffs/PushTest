using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PushTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBlue_Click(object sender, RoutedEventArgs e)
        {
            myGrid.Background = new SolidColorBrush(Colors.LightBlue);
        }

        private void ButtonRed_Click(object sender, RoutedEventArgs e)
        {
            myGrid.Background = new SolidColorBrush(Colors.Red);
        }

        private void ButtonGreen_Click(object sender, RoutedEventArgs e)
        {
            myGrid.Background = new SolidColorBrush(Colors.Green);
        }
    }
}