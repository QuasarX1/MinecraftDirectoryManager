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
    /// Interaction logic for ModPacksPage.xaml
    /// </summary>
    public partial class ModPacksPage : Page, IChangesPage
    {
        public System.Collections.ObjectModel.ObservableCollection<MCModPack> ModPacks;
        public System.Collections.ObjectModel.ObservableCollection<PackInDirectory> DirectoryModPacks;
        public System.Collections.ObjectModel.ObservableCollection<MCDirectory> Directories;
        public MCDirectory CurrentDirectory =  null;



        public void Save()
        {
            SaveModPacks(ModPacks);

            if (CurrentDirectory != null)
            {
                SavePacksInDirectories(CurrentDirectory.Name, DirectoryModPacks);
            }
        }

        public ModPacksPage()
        {
            InitializeComponent();

            this.DataContext = this;

            ModPacks = LoadModPacks();

            StoredModPacksListView.ItemsSource = ModPacks;

            Directories = LoadDirectories();
            
            DirectoriesListView.ItemsSource = Directories;
        }

        private void DirectoriesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Save();

            if (ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path, true) || ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path, true, true))
            {
                DirectoryModPacks = LoadPacksInDirectories(Directories[DirectoriesListView.SelectedIndex].Name);

                DirectoryModPacksListView.Visibility = Visibility.Visible;



                CurrentDirectory = Directories[DirectoriesListView.SelectedIndex];
            }
            else
            {
                DirectoryModPacks = new System.Collections.ObjectModel.ObservableCollection<PackInDirectory>();

                DirectoryModPacksListView.Visibility = Visibility.Hidden;


                CurrentDirectory = null;
            }

            DirectoryModPacksListView.ItemsSource = DirectoryModPacks;
        }

        public bool CreateModPack(NewModPackWindow sender)
        {
            if (!ModPacks.Contains(sender.ModPack, new ModPackCompairer()) && (from character in sender.ModPack.Name where System.IO.Path.GetInvalidFileNameChars().Contains(character) select character).Count() == 0)
            {
                File.Create(System.IO.Path.Combine(ModPacksFolder, sender.ModPack.Name + ".txt")).Close();

                ModPacks.Add(sender.ModPack);

                return true;
            }
            else
            {
                return false;
            }
        }

        private void NewModPackButton_Click(object sender, RoutedEventArgs e)
        {
            NewModPackWindow dioulouge = new NewModPackWindow();
            dioulouge.Create += CreateModPack;

            dioulouge.Show();
        }

        private void DeleteStoredModPackButton_Click(object sender, RoutedEventArgs e)
        {
            if (StoredModPacksListView.SelectedIndex != -1)
            {
                if (!LoadPacksInDirectories().Contains(new PackInDirectory(ModPacks[StoredModPacksListView.SelectedIndex], null), new PackAccrossDirectoryCompairer()))
                {
                    if (File.Exists(System.IO.Path.Combine(ModPacksFolder, ModPacks[StoredModPacksListView.SelectedIndex].Name + ".txt")))
                    {
                        File.Delete(System.IO.Path.Combine(ModPacksFolder, ModPacks[StoredModPacksListView.SelectedIndex].Name + ".txt"));
                    }

                    ModPacks.RemoveAt(StoredModPacksListView.SelectedIndex);
                }
            }
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            if (StoredModPacksListView.SelectedIndex != -1 && DirectoriesListView.SelectedIndex != -1 && (ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path, true) || ValidateDirectory(Directories[DirectoriesListView.SelectedIndex].Path, true, true)))
            {
                System.Collections.ObjectModel.ObservableCollection<UIListString> moveMods = LoadModPackMods(System.IO.Path.Combine(ModPacksFolder, ModPacks[StoredModPacksListView.SelectedIndex].Name + ".txt"));

                foreach (UIListString mod in moveMods)
                {
                    if (!File.Exists(System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "mods", mod.Text)))
                    {
                        File.Copy(System.IO.Path.Combine(ModsFolder, mod.Text), System.IO.Path.Combine(Directories[DirectoriesListView.SelectedIndex].Path, "mods", mod.Text));
                    }
                }


                DirectoryModPacks.Add(new PackInDirectory(ModPacks[StoredModPacksListView.SelectedIndex], CurrentDirectory.Name));
            }
        }

        private void RemoveDirectoryModPackButton_Click(object sender, RoutedEventArgs e)
        {
            if (DirectoryModPacksListView.SelectedIndex != -1)
            {
                IEnumerable<UIListString> removeMods = LoadModPackMods(System.IO.Path.Combine(ModPacksFolder, DirectoryModPacks[DirectoryModPacksListView.SelectedIndex] + ".txt" ));
                
                DirectoryModPacks.RemoveAt(DirectoryModPacksListView.SelectedIndex);

                foreach (PackInDirectory pack in DirectoryModPacks)
                {
                    foreach (UIListString keepMod in LoadModPackMods(System.IO.Path.Combine(ModPacksFolder, pack.ModPack + ".txt")))
                    {
                        removeMods = from mod in removeMods where mod.Text != keepMod.Text select mod;
                    }
                }


                foreach (UIListString mod in removeMods)
                {
                    if (File.Exists(System.IO.Path.Combine(CurrentDirectory.Path, "mods", mod.Text)))
                    {
                        File.Delete(System.IO.Path.Combine(CurrentDirectory.Path, "mods", mod.Text));
                    }
                }
            }
        }
    }



    public class ModPackCompairer : EqualityComparer<MCModPack>
    {
        public override bool Equals(MCModPack x, MCModPack y)
        {
            return (x.Name == y.Name) ? true : false;
        }

        public override int GetHashCode(MCModPack obj)
        {
            return obj.GetHashCode();
        }
    }

    public class PackAccrossDirectoryCompairer : EqualityComparer<PackInDirectory>
    {
        public override bool Equals(PackInDirectory x, PackInDirectory y)
        {
            return (x.ModPack == y.ModPack) ? true : false;
        }

        public override int GetHashCode(PackInDirectory obj)
        {
            return obj.GetHashCode();
        }
    }
}
