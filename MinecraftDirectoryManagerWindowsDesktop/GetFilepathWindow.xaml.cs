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
    public partial class GetFilepathWindow : Window
    {
        public string Path { get; private set; }
        public bool File { get; private set; }

        public event SubmitPathEventHandler Submit;

        public GetFilepathWindow(string initialPath = "", bool file = false)
        {
            InitializeComponent();

            File = file;

            Path = initialPath;

            FilepathTextBox.Text = Path;

            if (file)
            {
                ContextLabel.Content = "Path to Folder:";
            }
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (FilepathTextBox.Text != "")
            {
                if ((File)? System.IO.File.Exists(FilepathTextBox.Text) : System.IO.Directory.Exists(FilepathTextBox.Text))
                {
                    Path = FilepathTextBox.Text;

                    if (Submit != null)
                    {
                        if (this.Submit(Path) == true)
                        {
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("The path provided was invalid. Please try again.", "Invalid Path", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK, MessageBoxOptions.None);
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



    public delegate bool SubmitPathEventHandler(string filepath);
}
