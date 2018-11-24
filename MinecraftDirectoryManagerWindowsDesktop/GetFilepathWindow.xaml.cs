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

using Microsoft.Win32;

namespace MinecraftDirectoryManagerWindowsDesktop
{
    /// <summary>
    /// Interaction logic for DirectoryUpdateWindow.xaml
    /// </summary>
    public partial class GetFilepathWindow : Window
    {
        public string Path { get; private set; }
        public bool Folder { get; set; }
        public bool MultiSelect { get; private set; }
        public CommonDialog Diolouge { get; private set; }

        public event SubmitPathEventHandler Submit;

        public GetFilepathWindow(string initialPath = "", bool folder = false, bool multiSelect = false, CommonDialog customDiolouge = null)
        {
            InitializeComponent();

            Folder = folder;

            Path = initialPath;

            FilepathTextBox.Text = Path;

            MultiSelect = multiSelect;

            Diolouge = customDiolouge;

            if (folder)
            {
                ContextLabel.Content = "Path to Folder:";
            }

            if (Diolouge == null)
            {
                SelectItemButton.IsEnabled = false;
            }
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (FilepathTextBox.Text != "")
            {
                if ((Folder)? System.IO.Directory.Exists(FilepathTextBox.Text) : System.IO.File.Exists(FilepathTextBox.Text))
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

        private void SelectItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (Diolouge != null)
            {
                if (Diolouge.ShowDialog() == true)
                {
                    if (Diolouge.GetType() == typeof(OpenFileDialog))
                    {
                        if (MultiSelect)
                        {
                            string paths = "";
                            foreach (string path in ((OpenFileDialog)Diolouge).FileNames)
                            {
                                paths += path + ";";
                            }
                            FilepathTextBox.Text = paths.TrimEnd(';');
                        }
                        else
                        {
                            FilepathTextBox.Text = ((OpenFileDialog)Diolouge).FileName;
                        }
                    }
                }
            }
        }
    }



    public delegate bool SubmitPathEventHandler(string filepath);
}
