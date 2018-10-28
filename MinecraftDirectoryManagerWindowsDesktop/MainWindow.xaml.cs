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

namespace MinecraftDirectoryManagerWindowsDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object homePage = null;

        public MainWindow()
        {
            InitializeComponent();

            MainDisplayFrame.Content = new HomePage();
        }

        public void NavigateToPage(Type pageType)
        {
            MainDisplayFrame.Content = Activator.CreateInstance(pageType);
        }



        private void HomeMenuButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage(typeof(HomePage));
        }

        private void DirectoriesMenuButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage(typeof(DirectoriesPage));
        }

        private void SavesMenuButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage(typeof(SavesPage));
        }

        private void VersionsMenuButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage(typeof(VersionsPage));
        }

        private void ModsMenuButton_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage(typeof(ModsPage));
        }
    }
}
