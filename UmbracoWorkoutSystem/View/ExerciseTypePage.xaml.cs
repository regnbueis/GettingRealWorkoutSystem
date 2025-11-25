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
using UmbracoWorkoutSystem.View;

namespace UmbracoWorkoutSystem.View
{
    /// <summary>
    /// Interaction logic for ExerciseTypePage.xaml
    /// </summary>
    public partial class ExerciseTypePage : Page
    {
        public ExerciseTypePage()
        {
            InitializeComponent();
            
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {

            var mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.MainFrame.Navigate(new ExercisePage());

        }
    }
}
