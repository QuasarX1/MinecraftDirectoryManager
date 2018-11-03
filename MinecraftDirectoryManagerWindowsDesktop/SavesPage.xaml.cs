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
    /// Interaction logic for SavesPage.xaml
    /// </summary>
    public partial class SavesPage : Page, IChangesPage
    {
        public void Save()
        {

        }

        public System.Collections.ObjectModel.ObservableCollection<UIListString> Saves;
        public System.Collections.ObjectModel.ObservableCollection<UIListString> DirectorySaves;
        public System.Collections.ObjectModel.ObservableCollection<MCDirectory> Directories;
        public readonly string  FolderPath = Constants.APPDATA + "Versions";

        public SavesPage()
        {
            InitializeComponent();

            this.DataContext = this;

            
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            Saves = new System.Collections.ObjectModel.ObservableCollection<UIListString>();

            foreach (string save in Directory.GetDirectories(FolderPath))
            {
                Saves.Add(new UIListString(System.IO.Path.GetFileName(save)));
            }

            StoredSavesListView.ItemsSource = Saves;


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
            DirectorySaves = new System.Collections.ObjectModel.ObservableCollection<UIListString>();

            if (DirectoriesPage.ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path) == true)
            {
                foreach (string save in Directory.GetDirectories(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "saves")))
                {
                    DirectorySaves.Add(new UIListString(System.IO.Path.GetFileName(save)));
                }

                DirectorySavesListView.Visibility = Visibility.Visible;
            }
            else
            {
                DirectorySavesListView.Visibility = Visibility.Hidden;
            }

            DirectorySavesListView.ItemsSource = DirectorySaves;
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

        public bool AddSave(string path)
        {
            try
            {
                CopyFilesRecursively(path, System.IO.Path.Combine(FolderPath, System.IO.Path.GetFileName(path)));

                Saves.Add(new UIListString(System.IO.Path.GetFileName(path)));

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void AddNewSaveButton_Click(object sender, RoutedEventArgs e)
        {
            GetFilepathWindow dioulouge = new GetFilepathWindow();
            dioulouge.Submit += AddSave;

            dioulouge.Show();
        }

        private void MoveToDirectoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (StoredSavesListView.SelectedIndex != -1 && DirectoriesListView.SelectedIndex != -1 && DirectoriesPage.ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path))
            {
                if (!Directory.Exists(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "saves", Saves[StoredSavesListView.SelectedIndex].Text)))
                {
                    Directory.Move(System.IO.Path.Combine(FolderPath, Saves[StoredSavesListView.SelectedIndex].Text), System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "saves", Saves[StoredSavesListView.SelectedIndex].Text));
                    DirectorySaves.Add(Saves[StoredSavesListView.SelectedIndex]);
                    Saves.RemoveAt(StoredSavesListView.SelectedIndex);
                }
            }
        }

        private void CopyToDirectoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (StoredSavesListView.SelectedIndex != -1 && DirectoriesListView.SelectedIndex != -1 && DirectoriesPage.ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path))
            {
                if (!Directory.Exists(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "saves", Saves[StoredSavesListView.SelectedIndex].Text)))
                {
                    CopyFilesRecursively(System.IO.Path.Combine(FolderPath, Saves[StoredSavesListView.SelectedIndex].Text), System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "saves", Saves[StoredSavesListView.SelectedIndex].Text));
                    DirectorySaves.Add(Saves[StoredSavesListView.SelectedIndex]);
                }
            }
        }

        private void DeleteStoredSaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (StoredSavesListView.SelectedIndex != -1)
            {
                Directory.Delete(System.IO.Path.Combine(FolderPath, Saves[StoredSavesListView.SelectedIndex].Text), true);
                Saves.RemoveAt(StoredSavesListView.SelectedIndex);
            }
        }

        private void MoveToSavesButton_Click(object sender, RoutedEventArgs e)
        {
            if (DirectorySavesListView.SelectedIndex != -1 && DirectoriesListView.SelectedIndex != -1 && DirectoriesPage.ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path))
            {
                if (!Directory.Exists(System.IO.Path.Combine(FolderPath, DirectorySaves[DirectorySavesListView.SelectedIndex].Text)))
                {
                    Directory.Move(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "saves", DirectorySaves[DirectorySavesListView.SelectedIndex].Text), System.IO.Path.Combine(FolderPath, DirectorySaves[DirectorySavesListView.SelectedIndex].Text));
                    Saves.Add(DirectorySaves[DirectorySavesListView.SelectedIndex]);
                    DirectorySaves.RemoveAt(DirectorySavesListView.SelectedIndex);
                }
            }
        }

        private void CopyToSavesButton_Click(object sender, RoutedEventArgs e)
        {
            if (DirectorySavesListView.SelectedIndex != -1 && DirectoriesListView.SelectedIndex != -1 && DirectoriesPage.ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path))
            {
                if (!Directory.Exists(System.IO.Path.Combine(FolderPath, DirectorySaves[DirectorySavesListView.SelectedIndex].Text)))
                {
                    CopyFilesRecursively(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "saves", DirectorySaves[DirectorySavesListView.SelectedIndex].Text), System.IO.Path.Combine(FolderPath, DirectorySaves[DirectorySavesListView.SelectedIndex].Text));
                    Saves.Add(DirectorySaves[DirectorySavesListView.SelectedIndex]);
                }
            }
        }

        private void DeleteDirectorySaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (DirectorySavesListView.SelectedIndex != -1 && DirectoriesListView.SelectedIndex != -1 && DirectoriesPage.ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path))
            {
                Directory.Delete(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "saves", DirectorySaves[DirectorySavesListView.SelectedIndex].Text), true);
                DirectorySaves.RemoveAt(DirectorySavesListView.SelectedIndex);
            }
        }
    }
}
