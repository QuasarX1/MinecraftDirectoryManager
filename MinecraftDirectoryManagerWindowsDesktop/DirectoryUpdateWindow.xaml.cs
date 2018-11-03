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

namespace MinecraftDirectoryManagerWindowsDesktop
{
    /// <summary>
    /// Interaction logic for DirectoryUpdateWindow.xaml
    /// </summary>
    public partial class DirectoryUpdateWindow : Window
    {
        public MCDirectory Directory { get; private set; }

        public event UpdateEventEventHandler Update;

        public DirectoryUpdateWindow(MCDirectory directory)
        {
            InitializeComponent();

            Directory = directory;

            NameTextBox.Text = Directory.Name;
            PathTextBox.Text = Directory.Path;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text != "" && PathTextBox.Text != "")
            {
                if (System.IO.Directory.Exists(PathTextBox.Text) && DirectoriesPage.ValidateDirectory(PathTextBox.Text) == true)
                {
                    Directory.Name = NameTextBox.Text;
                    Directory.Path = PathTextBox.Text;

                    if (Update != null)
                    {
                        if (this.Update(this) == true)
                        {
                            this.Close();
                        }
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }



    public delegate bool UpdateEventEventHandler(DirectoryUpdateWindow sender);
}
