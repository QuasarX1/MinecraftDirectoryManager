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
    /// Interaction logic for ModsPage.xaml
    /// </summary>
    public partial class ModsPage : Page, IChangesPage
    {
        public void Save()
        {
            if (CurrentPackFilepath != null)
            {
                SaveModPackMods(CurrentPackFilepath, ModPackMods);
            }
        }

        public System.Collections.ObjectModel.ObservableCollection<UIListString> Mods;
        public System.Collections.ObjectModel.ObservableCollection<UIListString> ModPackMods;
        public System.Collections.ObjectModel.ObservableCollection<MCModPack> ModPacks;
        private string CurrentPackFilepath;

        public ModsPage()
        {
            InitializeComponent();

            this.DataContext = this;


            if (!Directory.Exists(ModsFolder))
            {
                Directory.CreateDirectory(ModsFolder);
            }

            Mods = new System.Collections.ObjectModel.ObservableCollection<UIListString>();

            foreach (string save in Directory.GetFiles(ModsFolder))
            {
                Mods.Add(new UIListString(System.IO.Path.GetFileName(save)));
            }

            StoredModsListView.ItemsSource = Mods;


            if (!System.IO.File.Exists(ModPacksFile))
            {
                var file = System.IO.File.Create(ModPacksFile);
                file.Close();
            }

            ModPacks = LoadModPacks();

            ModPacksListView.ItemsSource = ModPacks;
        }
        


        private void ModPacksListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Save the current modpack
            Save();

            if (ModPacksListView.SelectedIndex != -1)
            {
                CurrentPackFilepath = System.IO.Path.Combine(ModPacksFolder, ModPacks[ModPacksListView.SelectedIndex].Name + ".txt");
                ModPackMods = LoadModPackMods(CurrentPackFilepath);

                ModPackModsListView.Visibility = Visibility.Visible;
            }
            else
            {
                CurrentPackFilepath = null;
                ModPackModsListView.Visibility = Visibility.Hidden;
            }

            ModPackModsListView.ItemsSource = ModPackMods;
        }

        public bool AddMod(string path)
        {
            try
            {
                File.Copy(path, System.IO.Path.Combine(ModsFolder, System.IO.Path.GetFileName(path)));

                Mods.Add(new UIListString(System.IO.Path.GetFileName(path)));

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void AddNewModButton_Click(object sender, RoutedEventArgs e)
        {
            GetFilepathWindow dioulouge = new GetFilepathWindow();
            dioulouge.Submit += AddMod;

            dioulouge.Show();
        }

        private void AddToModPackButton_Click(object sender, RoutedEventArgs e)
        {
            // Copy to list
            if (StoredModsListView.SelectedIndex != -1 && ModPacksListView.SelectedIndex != -1)
            {
                if (!ModPackMods.Contains(Mods[StoredModsListView.SelectedIndex], new ModCompairer()))
                {
                    ModPackMods.Add(Mods[StoredModsListView.SelectedIndex]);
                }
            }
        }

        private void DeleteStoredModButton_Click(object sender, RoutedEventArgs e)
        {
            if (StoredModsListView.SelectedIndex != -1)
            {
                //TODO: Check if used in mod pack
                File.Delete(System.IO.Path.Combine(ModsFolder, Mods[StoredModsListView.SelectedIndex].Text));
                
                Mods.RemoveAt(StoredModsListView.SelectedIndex);
            }
        }

        private void RemoveFromModPackButton_Click(object sender, RoutedEventArgs e)
        {
            if (ModPackModsListView.SelectedIndex != -1)
            {
                ModPackMods.RemoveAt(ModPackModsListView.SelectedIndex);
            }
        }
    }



    public class ModCompairer : EqualityComparer<UIListString>
    {
        public override bool Equals(UIListString x, UIListString y)
        {
            return (x.Text == y.Text) ? true : false;
        }

        public override int GetHashCode(UIListString obj)
        {
            return obj.GetHashCode();
        }
    }
}
