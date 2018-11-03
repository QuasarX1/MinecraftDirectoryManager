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
        public MainWindow()
        {
            InitializeComponent();

            // Check data directory structure

            MainDisplayFrame.Content = new HomePage();
        }

        public void NavigateToPage(Type pageType)
        {
            // Save any changes
            if (MainDisplayFrame.Content is IChangesPage)
            {
                ((IChangesPage)MainDisplayFrame.Content).Save();
            }
            
            // Load the new page
            MainDisplayFrame.Content = Activator.CreateInstance(pageType);
        }



        private void HideMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenuContainer.Width = new GridLength(0.05, GridUnitType.Star);
            MainMenu.Visibility = Visibility.Collapsed;
            ShowMenuButton.Visibility = Visibility.Visible;
        }

        private void ShowMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenuContainer.Width = new GridLength(0.2, GridUnitType.Star);
            ShowMenuButton.Visibility = Visibility.Collapsed;
            MainMenu.Visibility = Visibility.Visible;
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MainDisplayFrame.Content is IChangesPage)
            {
                ((IChangesPage)MainDisplayFrame.Content).Save();
            }
        }
    }
}
