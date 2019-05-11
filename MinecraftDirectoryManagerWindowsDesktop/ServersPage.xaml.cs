using System;
using System.Collections.Generic;
using System.Diagnostics;
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

using MDM_Server_Tools;

using static MinecraftDirectoryManagerWindowsDesktop.BackEnd;

namespace MinecraftDirectoryManagerWindowsDesktop
{
    /// <summary>
    /// Interaction logic for ServersPage.xaml
    /// </summary>
    public partial class ServersPage : Page
    {
        public System.Collections.ObjectModel.ObservableCollection<MCDirectory> Servers;

        public ServersPage()
        {
            InitializeComponent();

            this.DataContext = this;


            if (!System.IO.Directory.Exists(RootDirectory))
            {
                System.IO.Directory.CreateDirectory(RootDirectory);
            }
            if (!System.IO.File.Exists(DirectoriesFile))
            {
                var file = System.IO.File.Create(DirectoriesFile);
                file.Close();
            }

            Servers = new System.Collections.ObjectModel.ObservableCollection<MCDirectory>(from directory in LoadDirectories() where ValidateDirectory(directory.Path, modded: false, server: true) || ValidateDirectory(directory.Path, modded: false, server: true) select directory);

            ServersListView.ItemsSource = Servers;
        }

        private Process CreateServerProcess(string path, string root)
        {
            Process serverConsole = new Process();
            serverConsole.StartInfo.FileName = path;
            serverConsole.StartInfo.WorkingDirectory = System.IO.Path.Combine(root, "win-x64");

            return serverConsole;
        }

        private void ServersListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ServersListView.SelectedIndex != -1)
            {
                StartServerButton.IsEnabled = true;
                StartExternalServerButton.IsEnabled = true;

                //TODO: display infomation about the server
            }
            else
            {
                StartServerButton.IsEnabled = false;
                StartExternalServerButton.IsEnabled = false;
            }
        }

        private void StartServerButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO: open new child window and pass process to it
            string serverRoot = Servers[ServersListView.SelectedIndex].Path;
            ServerConsoleWindow serverWindow = new ServerConsoleWindow(serverRoot, Servers[ServersListView.SelectedIndex].Name);
            serverWindow.Show();
        }

        private void StartExternalServerButton_Click(object sender, RoutedEventArgs e)
        {
            string serverRoot = Servers[ServersListView.SelectedIndex].Path;
            string exePath = System.IO.Path.Combine(serverRoot, "win-x64", "MCServerAutomator.exe");
            if (System.IO.File.Exists(exePath))
            {
                Process serverConsole = CreateServerProcess(exePath, serverRoot);

                serverConsole.StartInfo.UseShellExecute = true;

                serverConsole.Start();
            }
            else
            {
                
            }
        }
    }
}
