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
using static MinecraftDirectoryManagerWindowsDesktop.BackEnd;

namespace MinecraftDirectoryManagerWindowsDesktop
{
    /// <summary>
    /// Interaction logic for SavesPage.xaml
    /// </summary>
    public partial class SavesPage : Page
    {
        public System.Collections.ObjectModel.ObservableCollection<UIListString> Saves;
        public System.Collections.ObjectModel.ObservableCollection<UIListString> DirectorySaves;
        public System.Collections.ObjectModel.ObservableCollection<MCDirectory> Directories;

        public SavesPage()
        {
            InitializeComponent();

            this.DataContext = this;

            
            if (!Directory.Exists(SavesFolder))
            {
                Directory.CreateDirectory(SavesFolder);
            }

            Saves = new System.Collections.ObjectModel.ObservableCollection<UIListString>();

            foreach (string save in Directory.GetDirectories(SavesFolder))
            {
                Saves.Add(new UIListString(System.IO.Path.GetFileName(save)));
            }

            StoredSavesListView.ItemsSource = Saves;

            Directories = LoadDirectories();
            
            DirectoriesListView.ItemsSource = Directories;
        }

        private void DirectoriesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DirectorySaves = new System.Collections.ObjectModel.ObservableCollection<UIListString>();

            if (ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path) == true)
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

        

        public bool AddSave(string path)
        {
            try
            {
                CopyFilesRecursively(path, System.IO.Path.Combine(SavesFolder, System.IO.Path.GetFileName(path)));

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
            GetFilepathWindow dioulouge = new GetFilepathWindow("", true);
            dioulouge.Submit += AddSave;

            dioulouge.Show();
        }

        private void MoveToDirectoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (StoredSavesListView.SelectedIndex != -1 && DirectoriesListView.SelectedIndex != -1 && ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path))
            {
                if (!Directory.Exists(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "saves", Saves[StoredSavesListView.SelectedIndex].Text)))
                {
                    Directory.Move(System.IO.Path.Combine(SavesFolder, Saves[StoredSavesListView.SelectedIndex].Text), System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "saves", Saves[StoredSavesListView.SelectedIndex].Text));
                    DirectorySaves.Add(Saves[StoredSavesListView.SelectedIndex]);
                    Saves.RemoveAt(StoredSavesListView.SelectedIndex);
                }
            }
        }

        private void CopyToDirectoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (StoredSavesListView.SelectedIndex != -1 && DirectoriesListView.SelectedIndex != -1 && ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path))
            {
                if (!Directory.Exists(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "saves", Saves[StoredSavesListView.SelectedIndex].Text)))
                {
                    CopyFilesRecursively(System.IO.Path.Combine(SavesFolder, Saves[StoredSavesListView.SelectedIndex].Text), System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "saves", Saves[StoredSavesListView.SelectedIndex].Text));
                    DirectorySaves.Add(Saves[StoredSavesListView.SelectedIndex]);
                }
            }
        }

        private void DeleteStoredSaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (StoredSavesListView.SelectedIndex != -1)
            {
                Directory.Delete(System.IO.Path.Combine(SavesFolder, Saves[StoredSavesListView.SelectedIndex].Text), true);
                Saves.RemoveAt(StoredSavesListView.SelectedIndex);
            }
        }

        private void MoveToSavesButton_Click(object sender, RoutedEventArgs e)
        {
            if (DirectorySavesListView.SelectedIndex != -1 && DirectoriesListView.SelectedIndex != -1 && ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path))
            {
                if (!Directory.Exists(System.IO.Path.Combine(SavesFolder, DirectorySaves[DirectorySavesListView.SelectedIndex].Text)))
                {
                    Directory.Move(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "saves", DirectorySaves[DirectorySavesListView.SelectedIndex].Text), System.IO.Path.Combine(SavesFolder, DirectorySaves[DirectorySavesListView.SelectedIndex].Text));
                    Saves.Add(DirectorySaves[DirectorySavesListView.SelectedIndex]);
                    DirectorySaves.RemoveAt(DirectorySavesListView.SelectedIndex);
                }
            }
        }

        private void CopyToSavesButton_Click(object sender, RoutedEventArgs e)
        {
            if (DirectorySavesListView.SelectedIndex != -1 && DirectoriesListView.SelectedIndex != -1 && ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path))
            {
                if (!Directory.Exists(System.IO.Path.Combine(SavesFolder, DirectorySaves[DirectorySavesListView.SelectedIndex].Text)))
                {
                    CopyFilesRecursively(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "saves", DirectorySaves[DirectorySavesListView.SelectedIndex].Text), System.IO.Path.Combine(SavesFolder, DirectorySaves[DirectorySavesListView.SelectedIndex].Text));
                    Saves.Add(DirectorySaves[DirectorySavesListView.SelectedIndex]);
                }
            }
        }

        private void DeleteDirectorySaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (DirectorySavesListView.SelectedIndex != -1 && DirectoriesListView.SelectedIndex != -1 && ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path))
            {
                Directory.Delete(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "saves", DirectorySaves[DirectorySavesListView.SelectedIndex].Text), true);
                DirectorySaves.RemoveAt(DirectorySavesListView.SelectedIndex);
            }
        }
    }
}
