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
    /// Interaction logic for ModPacksPage.xaml
    /// </summary>
    public partial class ModPacksPage : Page
    {
        public readonly string FolderPath = System.IO.Path.Combine(Constants.APPDATA, "Mods", "ModPacks");
        public System.Collections.ObjectModel.ObservableCollection<MCModPack> ModPacks;
        public System.Collections.ObjectModel.ObservableCollection<MCModPack> DirectoryModPacks;
        public System.Collections.ObjectModel.ObservableCollection<MCDirectory> Directories;


        public static System.Collections.ObjectModel.ObservableCollection<MCModPack> LoadModPacks(string filepath)
        {
            System.Collections.ObjectModel.ObservableCollection<MCModPack> modpacks = new System.Collections.ObjectModel.ObservableCollection<MCModPack>();

            var data = System.IO.File.OpenText(filepath);

            // Populate the modpacks list
            string line = data.ReadLine();
            while (line != null)
            {
                string[] values = line.Split(new char[] { ';' });
                modpacks.Add(new MCModPack(values[0], values[1]));

                line = data.ReadLine();
            }
            data.Close();

            return modpacks;
        }

        public static void SaveModPacks(string filepath, System.Collections.ObjectModel.ObservableCollection<MCModPack> modpacks)
        {
            if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(filepath)))
            {
                System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(filepath));
            }
            if (!System.IO.File.Exists(filepath))
            {
                var file = System.IO.File.Create(filepath);
                file.Close();
            }

            string[] lines = new string[modpacks.Count];
            for (int i = 0; i < modpacks.Count; i++)
            {
                lines[i] = modpacks[i].Name + ";" + modpacks[i].Version;
            }

            System.IO.File.WriteAllLines(filepath, lines);
        }
        
        public static System.Collections.ObjectModel.ObservableCollection<UIListString> LoadModPackMods(string filepath)
        {
            System.Collections.ObjectModel.ObservableCollection<UIListString> mods = new System.Collections.ObjectModel.ObservableCollection<UIListString>();

            var data = System.IO.File.OpenText(filepath);

            // Populate the mods list
            string line = data.ReadLine();
            while (line != null)
            {
                mods.Add(new UIListString(line));

                line = data.ReadLine();
            }
            data.Close();

            return mods;
        }

        public static void SaveModPackMods(string filepath, System.Collections.ObjectModel.ObservableCollection<UIListString> mods)
        {
            if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(filepath)))
            {
                System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(filepath));
            }
            if (!System.IO.File.Exists(filepath))
            {
                var file = System.IO.File.Create(filepath);
                file.Close();
            }

            string[] lines = new string[mods.Count];
            for (int i = 0; i < mods.Count; i++)
            {
                lines[i] = mods[i].Text;
            }

            System.IO.File.WriteAllLines(filepath, lines);
        }




        public ModPacksPage()
        {
            InitializeComponent();

            this.DataContext = this;

            
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            ModPacks = ModPacksPage.LoadModPacks(System.IO.Path.Combine(FolderPath, "ModPacks.txt"));

            StoredModPacksListView.ItemsSource = ModPacks;


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

        }

        private void AddNewModPackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteStoredModPackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveDirectoryModPackButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
