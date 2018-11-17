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

using static MinecraftDirectoryManagerWindowsDesktop.BackEnd;


namespace MinecraftDirectoryManagerWindowsDesktop
{
    /// <summary>
    /// Interaction logic for DirectoriesPage.xaml
    /// </summary>
    public partial class DirectoriesPage : Page, IChangesPage
    {
        public System.Collections.ObjectModel.ObservableCollection<MCDirectory> Directories;

        

        public DirectoriesPage()
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

            //var data = System.IO.File.OpenText(Constants.APPDATA + "Directories.txt");

            //// Create and populate the Directories list
            //Directories = new System.Collections.ObjectModel.ObservableCollection<MCDirectory>();
            //string line = data.ReadLine();
            //while (line != null)
            //{
            //    string[] values = line.Split(new char[] { ';' });
            //    Directories.Add(new MCDirectory(values[0], values[1]));

            //    line = data.ReadLine();
            //}
            //data.Close();

            Directories = LoadDirectories();


            DirectoriesListView.ItemsSource = Directories;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (NewNameTextBox.Text != "" && NewPathTextBox.Text != "")
            {
                if (System.IO.Directory.Exists(NewPathTextBox.Text) && (ValidateDirectory(NewPathTextBox.Text) || ValidateDirectory(NewPathTextBox.Text, false, true)))
                {
                    Directories.Add(new MCDirectory(NewNameTextBox.Text, NewPathTextBox.Text));

                    NewNameTextBox.Text = "";
                    NewPathTextBox.Text = "";
                }
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            int editIndex = DirectoriesListView.SelectedIndex;

            if (editIndex >= 0)
            {
                // Open new window for editiing
                DirectoryUpdateWindow updater = new DirectoryUpdateWindow(Directories[editIndex]);
                updater.Update += UpdateEntry;

                updater.Show();
            }
        }

        public bool UpdateEntry(DirectoryUpdateWindow sender)
        {
            for (int i = 0; i < Directories.Count; i++)
            {
                if (Directories[i].ID == sender.Directory.ID)
                {
                    Directories[i] = sender.Directory;

                    break;
                }
            }

            return true;
        }

        public void Save()
        {
            // Save all changes
            if (!System.IO.Directory.Exists(RootDirectory))
            {
                System.IO.Directory.CreateDirectory(RootDirectory);
            }
            if (!System.IO.File.Exists(DirectoriesFile))
            {
                var file = System.IO.File.Create(DirectoriesFile);
                file.Close();
            }

            string[] lines = new string[Directories.Count];
            for (int i = 0; i < Directories.Count; i++)
            {
                lines[i] = Directories[i].Name + ";" + Directories[i].Path;
            }

            System.IO.File.WriteAllLines(DirectoriesFile, lines);
        }

        

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            int removeAt = DirectoriesListView.SelectedIndex;

            if (removeAt >= 0)
            {
                Directories.RemoveAt(removeAt);
            }
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            //Save();
        }

        private void DirectoriesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DirectoriesListView.SelectedIndex != -1)
            {
                string path = Directories[DirectoriesListView.SelectedIndex].Path;
                ValidCheckBox.IsChecked = ValidateDirectory(path);

                ModdedCheckBox.IsChecked = ValidateDirectory(path, true) || ValidateDirectory(path, true, true);

                ServerCheckBox.IsChecked = ValidateDirectory(path, false, true);

                DetailsGrid.Visibility = Visibility.Visible;
            }
            else
            {
                DetailsGrid.Visibility = Visibility.Hidden;
            }
        }
    }
}
