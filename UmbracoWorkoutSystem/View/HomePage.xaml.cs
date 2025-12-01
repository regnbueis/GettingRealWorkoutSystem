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
using UmbracoWorkoutSystem.ViewModels;

namespace UmbracoWorkoutSystem.View
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        MainViewModel mvm = new MainViewModel();
        public HomePage()
        {
            InitializeComponent();

            mvm.StartUp();
            mvm.GetUpcomingEvent();

            DataContext = mvm;
        }
    }
}
