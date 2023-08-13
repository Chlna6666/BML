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
using BML.Pages;
using System.Windows.Media.Animation;

namespace BML
{
    public partial class MainWindow : Window
    {
        private bool isSidebarExpanded = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToggleMenu_Click(object sender, RoutedEventArgs e)
        {
            if (isSidebarExpanded)
            {
                Storyboard collapseStoryboard = FindResource("CollapseSidebar") as Storyboard;
                collapseStoryboard?.Begin();
            }
            else
            {
                Storyboard expandStoryboard = FindResource("ExpandSidebar") as Storyboard;
                expandStoryboard?.Begin();
            }

            isSidebarExpanded = !isSidebarExpanded;
        }

        private void MenuItem_Checked(object sender, RoutedEventArgs e)
        {
            // Handle the menu item selection here
            // For example:
            if (sender is RadioButton radioButton && radioButton.Tag != null)
            {
                // Get the tag from the RadioButton (assuming it's the icon)
                PagesNavigation.Navigate(new System.Uri("Pages/home.xaml", UriKind.RelativeOrAbsolute));
            }
        }
    }
}
