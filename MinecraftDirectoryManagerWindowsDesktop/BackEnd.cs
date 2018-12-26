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
using System.Collections.ObjectModel;
using System.Deployment;
using System.Deployment.Application;

namespace MinecraftDirectoryManagerWindowsDesktop
{
    static class BackEnd
    {
        //- Atributes
        public static ExecutionModes Deployed;
        
        /// <summary>
        /// Filepath for the application's data storage root directory.
        /// </summary>
        public static string RootDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.Create) + @"\MDM\";

        /// <summary>
        /// Filepath for the directories text file.
        /// </summary>
        public static string DirectoriesFile = System.IO.Path.Combine(RootDirectory, "Directories.txt");

        /// <summary>
        /// Filepath for the mods folder.
        /// </summary>
        public static string ModsFolder = System.IO.Path.Combine(RootDirectory, "Mods");
        /// <summary>
        /// Filepath for the mod packs folder.
        /// </summary>
        public static string ModPacksFolder = System.IO.Path.Combine(ModsFolder, "ModPacks");
        /// <summary>
        /// Filepath for the mod packs text file.
        /// </summary>
        public static string ModPacksFile = System.IO.Path.Combine(ModPacksFolder, "ModPacks.txt");
        /// <summary>
        /// Filepath for the packs in directories text file.
        /// </summary>
        public static string PacksInDirectoriesFile = System.IO.Path.Combine(ModPacksFolder, "PacksInDirectories.txt");

        /// <summary>
        /// Filepath for the saves folder.
        /// </summary>
        public static string SavesFolder = System.IO.Path.Combine(RootDirectory, "Saves");

        /// <summary>
        /// Filepath for the versions folder.
        /// </summary>
        public static string VersionsFolder = System.IO.Path.Combine(RootDirectory, "Versions");



    //- Methods
        /// <summary>
        /// Creates any missing files and folders in the data storage directory.
        /// </summary>
        public static void CreateFileStructure()
        {
            // Root folder
            if (!System.IO.Directory.Exists(RootDirectory))
            {
                System.IO.Directory.CreateDirectory(RootDirectory);
            }

            // Directories.txt
            if (!System.IO.File.Exists(DirectoriesFile))
            {
                var file = System.IO.File.Create(DirectoriesFile);
                file.Close();
            }

            // Mods folder
            if (!System.IO.Directory.Exists(ModsFolder))
            {
                System.IO.Directory.CreateDirectory(ModsFolder);
            }

            // ModPacks folder
            if (!System.IO.Directory.Exists(ModPacksFolder))
            {
                System.IO.Directory.CreateDirectory(ModPacksFolder);
            }

            // ModPacks.txt
            if (!System.IO.File.Exists(ModPacksFile))
            {
                var file = System.IO.File.Create(ModPacksFile);
                file.Close();
            }

            // PacksInDirectories.txt
            if (!System.IO.File.Exists(PacksInDirectoriesFile))
            {
                var file = System.IO.File.Create(PacksInDirectoriesFile);
                file.Close();
            }

            // Saves folder
            if (!System.IO.Directory.Exists(SavesFolder))
            {
                System.IO.Directory.CreateDirectory(SavesFolder);
            }

            // Versions folder
            if (!System.IO.Directory.Exists(VersionsFolder))
            {
                System.IO.Directory.CreateDirectory(VersionsFolder);
            }
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



        public static string GetPublishedVersion()
        {
            string result = "";
            switch (Deployed)
            {
                case ExecutionModes.Debug:
                    if (File.Exists(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MinecraftDirectoryManagerWindowsDesktop.application")))
                    {
                        System.Data.DataSet ds = new System.Data.DataSet();
                        ds.ReadXml(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MinecraftDirectoryManagerWindowsDesktop.application"));
                        System.Data.DataTable dt = new System.Data.DataTable();
                        if (ds.Tables.Count > 1)
                        {
                            dt = ds.Tables[1];
                            result = "Dev Build - " + dt.Rows[0]["version"].ToString();
                        }
                    }
                    else
                    {
                        result = "Debug";
                    }
                    break;

                case ExecutionModes.Portable:
                    result = "Portable";
                    break;

                case ExecutionModes.Deployed:
                    Version version = ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    result = version.Major.ToString() + "." + version.Minor.ToString() + "." + version.Build.ToString();
                    break;

                default:
                    throw new Exception();
            }

            return result;
        }



        /// <summary>
        /// Checks that a directory is a valid minecraft directory.
        /// </summary>
        /// <param name="directoryPath">The filepath to the minecraft directory.</param>
        /// <param name="modded">Require the directory to be a valid modded directory.</param>
        /// <returns>Boolean indicating whether or not the directory provided is valid.</returns>
        public static bool ValidateDirectory(string directoryPath, bool modded = false, bool server = false)
        {
            if (Directory.Exists(directoryPath))
            {
                int missingItems = 0;

                if (!server)
                {
                    foreach (string item in new string[] { "saves", "versions", (modded == true) ? "mods" : "" })
                    {
                        if (Directory.GetDirectories(directoryPath).Contains(System.IO.Path.Combine(directoryPath, item)) || item == "")
                        {
                            continue;
                        }
                        else
                        {
                            missingItems++;
                        }
                    }
                }
                else
                {
                    foreach (string item in new string[] { "world", (modded == true) ? "mods" : "" })
                    {
                        if (Directory.GetDirectories(directoryPath).Contains(System.IO.Path.Combine(directoryPath, item)) || item == "")
                        {
                            continue;
                        }
                        else
                        {
                            missingItems++;
                        }
                    }
                }

                return (missingItems == 0) ? true : false;
            }
            else
            {
                return false;
            }
        }
        //TODO: Enum for types vanilla/modded/server/modded server? add tests?



        /// <summary>
        /// Loads the list of known directories.
        /// </summary>
        /// <returns>A collection of MCDirectory objects that represents the directories.</returns>
        public static System.Collections.ObjectModel.ObservableCollection<MCDirectory> LoadDirectories()
        {
            CreateFileStructure();

            string filepath = DirectoriesFile;

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

        /// <summary>
        /// Loads the list of mod packs.
        /// </summary>
        /// <returns>A collection of MCModPack objects that represent the mod packs.</returns>
        public static ObservableCollection<MCModPack> LoadModPacks()
        {
            CreateFileStructure();

            string filepath = ModPacksFile;

            ObservableCollection<MCModPack> modpacks = new ObservableCollection<MCModPack>();

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

        /// <summary>
        /// Saves the list of mod packs and overites the old list.
        /// </summary>
        /// <param name="modpacks">ObservableCollection of MCModPack objects.</param>
        public static void SaveModPacks(ObservableCollection<MCModPack> modpacks)
        {
            CreateFileStructure();

            string filepath = ModPacksFile;

            string[] lines = new string[modpacks.Count];
            for (int i = 0; i < modpacks.Count; i++)
            {
                lines[i] = modpacks[i].Name + ";" + modpacks[i].Version;
            }

            System.IO.File.WriteAllLines(filepath, lines);
        }

        /// <summary>
        /// Loads a list of mods contained in a given mod pack.
        /// </summary>
        /// <param name="filepath">The filepath of the mod pack index file.</param>
        /// <returns>A collection of UIListString objects representing the mods.</returns>
        public static ObservableCollection<ModFile> LoadModPackMods(string filepath)
        {
            CreateFileStructure();

            ObservableCollection<ModFile> mods = new ObservableCollection<ModFile>();

            var data = System.IO.File.OpenText(filepath);

            // Populate the mods list
            string line = data.ReadLine();
            while (line != null)
            {
                mods.Add(new ModFile(line, true));

                line = data.ReadLine();
            }
            data.Close();

            return mods;
        }

        /// <summary>
        /// Saves the list of mods in the mod pack and overites the old list.
        /// </summary>
        /// <param name="filepath">The filepath of the mod pack index file.</param>
        /// <param name="mods">A collection of UIListString objects representing the mods.</param>
        public static void SaveModPackMods(string filepath, ObservableCollection<ModFile> mods)
        {
            CreateFileStructure();

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

        /// <summary>
        /// Loads the list of mod packs contained by a specified directory.
        /// </summary>
        /// <param name="directoryName">The name of the directory to be used to filter the mod packs.
        /// "null" (deafult) will result in the list being unfiltered returning all packs in all known directories.</param>
        /// <returns>
        /// A collection of PackInDirectory objects that represents
        /// the links between a/all directory(s) and a mod packs.
        /// </returns>
        public static ObservableCollection<PackInDirectory> LoadPacksInDirectories(string directoryName = null)
        {
            CreateFileStructure();

            string filepath = PacksInDirectoriesFile;

            ObservableCollection<PackInDirectory> packsInDirectories = new ObservableCollection<PackInDirectory>();

            var data = System.IO.File.OpenText(filepath);

            // Populate the modpacks list
            string line = data.ReadLine();
            while (line != null)
            {
                string[] values = line.Split(new char[] { ';' });
                if (values[0] == directoryName || directoryName == null)
                {
                    packsInDirectories.Add(new PackInDirectory(values[1], values[0]));
                }

                line = data.ReadLine();
            }
            data.Close();

            return packsInDirectories;
        }

        /// <summary>
        /// Updates the saved list of mod packs in directories using the list provided (assumed to be comprehensive for theat directory).
        /// </summary>
        /// <param name="directoryName">The name of the directory being updated.</param>
        /// <param name="directoryModPacks">A list of the mod packs in a single directory.</param>
        public static void SavePacksInDirectories(string directoryName, ObservableCollection<PackInDirectory> directoryModPacks)
        {
            foreach (PackInDirectory join in directoryModPacks)
            {
                if (join.Directory != directoryName)
                {
                    throw new ArgumentException("One of the mod links provided wasn't a link to the expected directory.");
                }
            }

            string filepath = PacksInDirectoriesFile;

            // Load a copy of the current list of indexes
            ObservableCollection<PackInDirectory> currentList = LoadPacksInDirectories();

            // Remove all indexes for current directory
            for (int i = currentList.Count - 1; i >= 0; i--)
            {
                if (currentList[i].Directory == directoryName)
                {
                    currentList.RemoveAt(i);
                }
            }


            // Update the list with the new entries
            currentList = new ObservableCollection<PackInDirectory>(currentList.Concat(directoryModPacks));


            // Sort on modpack then directrory
            currentList = new ObservableCollection<PackInDirectory>(from item in (from item in currentList orderby item.ModPack select item) orderby item.Directory select item);
            

            // Save and overite
            string[] lines = new string[currentList.Count];
            for (int i = 0; i < currentList.Count; i++)
            {
                lines[i] = currentList[i].Directory + ";" + currentList[i].ModPack;
            }

            System.IO.File.WriteAllLines(filepath, lines);
        }
    }

    public enum ExecutionModes
    {
        Debug = 1,
        Portable = 2,
        Deployed = 3
    }
}