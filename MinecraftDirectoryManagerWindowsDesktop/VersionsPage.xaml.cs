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

using System.IO;

namespace MinecraftDirectoryManagerWindowsDesktop
{
    /// <summary>
    /// Interaction logic for VersionsPage.xaml
    /// </summary>
    public partial class VersionsPage : Page
    {
        public System.Collections.ObjectModel.ObservableCollection<UIListString> Versions;
        public System.Collections.ObjectModel.ObservableCollection<UIListString> DirectoryVersions;
        public System.Collections.ObjectModel.ObservableCollection<MCDirectory> Directories;
        public readonly string FolderPath = Constants.APPDATA + "Versions";

        public VersionsPage()
        {
            InitializeComponent();

            this.DataContext = this;


            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            Versions = new System.Collections.ObjectModel.ObservableCollection<UIListString>();

            foreach (string version in Directory.GetDirectories(FolderPath))
            {
                Versions.Add(new UIListString(System.IO.Path.GetFileName(version)));
            }

            StoredVersionsListView.ItemsSource = Versions;


            if (!System.IO.File.Exists(Constants.APPDATA + "Directories.txt"))
            {
                var file = System.IO.File.Create(Constants.APPDATA + "Directories.txt");
                file.Close();
            }

            Directories = DirectoriesPage.LoadDirectories(Constants.APPDATA + "Directories.txt");

            DirectoriesListView.ItemsSource = Directories;
        }

        private void DirectoriesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DirectoryVersions = new System.Collections.ObjectModel.ObservableCollection<UIListString>();

            if (DirectoriesPage.ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path) == true)
            {
                foreach (string version in Directory.GetDirectories(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "versions")))
                {
                    DirectoryVersions.Add(new UIListString(System.IO.Path.GetFileName(version)));
                }

                DirectoryVersionsListView.Visibility = Visibility.Visible;
            }
            else
            {
                DirectoryVersionsListView.Visibility = Visibility.Hidden;
            }

            DirectoryVersionsListView.ItemsSource = DirectoryVersions;
        }

        public static void CopyFilesRecursively(string source, string target, bool initialCall = true)
        {
            DirectoryInfo sourceInfo = new DirectoryInfo(source);
            DirectoryInfo targetInfo = new DirectoryInfo(target);

            if (initialCall)
            {
                System.IO.Directory.CreateDirectory(targetInfo.FullName);
            }

            foreach (DirectoryInfo dir in sourceInfo.GetDirectories())
                CopyFilesRecursively(dir, targetInfo.CreateSubdirectory(dir.Name), false);
            foreach (FileInfo file in sourceInfo.GetFiles())
                file.CopyTo(System.IO.Path.Combine(targetInfo.FullName, file.Name));
        }

        public static void CopyFilesRecursively(DirectoryInfo source, DirectoryInfo target, bool initialCall = true)
        {
            if (initialCall)
            {
                System.IO.Directory.CreateDirectory(target.Name);
            }

            foreach (DirectoryInfo dir in source.GetDirectories())
                CopyFilesRecursively(dir, target.CreateSubdirectory(dir.Name), false);
            foreach (FileInfo file in source.GetFiles())
                file.CopyTo(System.IO.Path.Combine(target.FullName, file.Name));
        }

        public bool AddVersion(string path)
        {
            try
            {
                CopyFilesRecursively(path, System.IO.Path.Combine(FolderPath, System.IO.Path.GetFileName(path)));

                Versions.Add(new UIListString(System.IO.Path.GetFileName(path)));

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void AddNewVersionButton_Click(object sender, RoutedEventArgs e)
        {
            GetFilepathWindow dioulouge = new GetFilepathWindow("", true);
            dioulouge.Submit += AddVersion;

            dioulouge.Show();
        }

        private void MoveToDirectoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (StoredVersionsListView.SelectedIndex != -1 && DirectoriesListView.SelectedIndex != -1 && DirectoriesPage.ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path))
            {
                if (!Directory.Exists(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "versions", Versions[StoredVersionsListView.SelectedIndex].Text)))
                {
                    Directory.Move(System.IO.Path.Combine(FolderPath, Versions[StoredVersionsListView.SelectedIndex].Text), System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "versions", Versions[StoredVersionsListView.SelectedIndex].Text));
                    DirectoryVersions.Add(Versions[StoredVersionsListView.SelectedIndex]);
                    Versions.RemoveAt(StoredVersionsListView.SelectedIndex);
                }
            }
        }

        private void CopyToDirectoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (StoredVersionsListView.SelectedIndex != -1 && DirectoriesListView.SelectedIndex != -1 && DirectoriesPage.ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path))
            {
                if (!Directory.Exists(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "versions", Versions[StoredVersionsListView.SelectedIndex].Text)))
                {
                    CopyFilesRecursively(System.IO.Path.Combine(FolderPath, Versions[StoredVersionsListView.SelectedIndex].Text), System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "versions", Versions[StoredVersionsListView.SelectedIndex].Text));
                    DirectoryVersions.Add(Versions[StoredVersionsListView.SelectedIndex]);
                }
            }
        }

        private void DeleteStoredVersionButton_Click(object sender, RoutedEventArgs e)
        {
            if (StoredVersionsListView.SelectedIndex != -1)
            {
                Directory.Delete(System.IO.Path.Combine(FolderPath, Versions[StoredVersionsListView.SelectedIndex].Text), true);
                Versions.RemoveAt(StoredVersionsListView.SelectedIndex);
            }
        }

        private void MoveToVersionsButton_Click(object sender, RoutedEventArgs e)
        {
            if (DirectoryVersionsListView.SelectedIndex != -1 && DirectoriesListView.SelectedIndex != -1 && DirectoriesPage.ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path))
            {
                if (!Directory.Exists(System.IO.Path.Combine(FolderPath, DirectoryVersions[DirectoryVersionsListView.SelectedIndex].Text)))
                {
                    Directory.Move(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "versions", DirectoryVersions[DirectoryVersionsListView.SelectedIndex].Text), System.IO.Path.Combine(FolderPath, DirectoryVersions[DirectoryVersionsListView.SelectedIndex].Text));
                    Versions.Add(DirectoryVersions[DirectoryVersionsListView.SelectedIndex]);
                    DirectoryVersions.RemoveAt(DirectoryVersionsListView.SelectedIndex);
                }
            }
        }

        private void CopyToVersionsButton_Click(object sender, RoutedEventArgs e)
        {
            if (DirectoryVersionsListView.SelectedIndex != -1 && DirectoriesListView.SelectedIndex != -1 && DirectoriesPage.ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path))
            {
                if (!Directory.Exists(System.IO.Path.Combine(FolderPath, DirectoryVersions[DirectoryVersionsListView.SelectedIndex].Text)))
                {
                    CopyFilesRecursively(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "versions", DirectoryVersions[DirectoryVersionsListView.SelectedIndex].Text), System.IO.Path.Combine(FolderPath, DirectoryVersions[DirectoryVersionsListView.SelectedIndex].Text));
                    Versions.Add(DirectoryVersions[DirectoryVersionsListView.SelectedIndex]);
                }
            }
        }

        private void DeleteDirectoryVersionButton_Click(object sender, RoutedEventArgs e)
        {
            if (DirectoryVersionsListView.SelectedIndex != -1 && DirectoriesListView.SelectedIndex != -1 && DirectoriesPage.ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path))
            {
                Directory.Delete(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "versions", DirectoryVersions[DirectoryVersionsListView.SelectedIndex].Text), true);
                DirectoryVersions.RemoveAt(DirectoryVersionsListView.SelectedIndex);
            }
        }
    }
}
