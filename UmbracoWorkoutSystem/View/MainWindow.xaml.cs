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
using UmbracoWorkoutSystem.View;

namespace UmbracoWorkoutSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new HomePage());
        }

        private void btnØvelser_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ExerciseTypePage());
        }

        private void btnEvents_Click(object sender, RoutedEventArgs e)
        {

        }
      
        private void logoHome_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HomePage());

        }

    }
}
    
