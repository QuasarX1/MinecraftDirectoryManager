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
    /// Interaction logic for DirectoriesPage.xaml
    /// </summary>
    public partial class DirectoriesPage : Page, IChangesPage
    {
        public System.Collections.ObjectModel.ObservableCollection<MCDirectory> Directories;
        public string testString = "Hello World";

        public static System.Collections.ObjectModel.ObservableCollection<MCDirectory> LoadDirectories(string filepath)
        {
            System.Collections.ObjectModel.ObservableCollection<MCDirectory> directories = new System.Collections.ObjectModel.ObservableCollection<MCDirectory>();

            var data = System.IO.File.OpenText(filepath);

            // Create and populate the Directories list
            string line = data.ReadLine();
            while (line != null)
            {
                string[] values = line.Split(new char[] { ';' });
                directories.Add(new MCDirectory(values[0], values[1]));

                line = data.ReadLine();
            }
            data.Close();

            return directories;
        }
        
        public DirectoriesPage()
        {
            InitializeComponent();

            this.DataContext = this;


            if (!System.IO.Directory.Exists(Constants.APPDATA))
            {
                System.IO.Directory.CreateDirectory(Constants.APPDATA);
            }
            if (!System.IO.File.Exists(Constants.APPDATA + "Directories.txt"))
            {
                var file = System.IO.File.Create(Constants.APPDATA + "Directories.txt");
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

            Directories = LoadDirectories(Constants.APPDATA + "Directories.txt");


            DirectoriesListView.ItemsSource = Directories;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (NewNameTextBox.Text != "" && NewPathTextBox.Text != "")
            {
                if (System.IO.Directory.Exists(NewPathTextBox.Text) && ValidateDirectory(NewPathTextBox.Text) == true)
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
            if (!System.IO.Directory.Exists(Constants.APPDATA))
            {
                System.IO.Directory.CreateDirectory(Constants.APPDATA);
            }
            if (!System.IO.File.Exists(Constants.APPDATA + "Directories.txt"))
            {
                var file = System.IO.File.Create(Constants.APPDATA + "Directories.txt");
                file.Close();
            }

            string[] lines = new string[Directories.Count];
            for (int i = 0; i < Directories.Count; i++)
            {
                lines[i] = Directories[i].Name + ";" + Directories[i].Path;
            }

            System.IO.File.WriteAllLines(Constants.APPDATA + "Directories.txt", lines);
        }

        /// <summary>
        /// Checks that a directory is a valid minecraft directory.
        /// </summary>
        /// <returns></returns>
        public static bool ValidateDirectory(string directoryPath, bool modded = false)
        {
            int missingItems = 0;
            foreach (string item in new string[] { "saves", "versions", (modded == true)? "mods" : "" })
            {
                if (System.IO.Directory.GetDirectories(directoryPath).Contains(System.IO.Path.Combine(directoryPath, item)) || item == "")
                {
                    continue;
                }
                else
                {
                    missingItems++;
                }
            }

            return (missingItems == 0) ? true : false;
           
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
    }
}
