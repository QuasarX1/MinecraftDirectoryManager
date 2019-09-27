using System;
using System.Windows.Controls;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace MinecraftDirectoryManagerWindowsDesktop
{
    public partial class ChangeNotifierBase
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string Obj)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(Obj));
            }
        }
    }

    public class MCDirectory : ChangeNotifierBase, INotifyPropertyChanged
    {
        public MCDirectory(string name, string path)
        {
            ID = Guid.NewGuid();
            this.name = name;
            this.path = path;
        }

        public readonly Guid ID;

        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        private string path;
        public string Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
                NotifyPropertyChanged("Path");
            }
        }
    }

    public class UIListString : ChangeNotifierBase, INotifyPropertyChanged
    {
        public UIListString(string text)
        {
            ID = Guid.NewGuid();
            this.text = text;
        }

        public readonly Guid ID;

        private string text;
        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
                NotifyPropertyChanged("Text");
            }
        }

        public override string ToString()
        {
            return text;
        }
    }

    public class MCModPack : ChangeNotifierBase, INotifyPropertyChanged
    {
        public MCModPack(string name, string version)
        {
            ID = Guid.NewGuid();
            this.name = name;
            this.version = version;
        }

        public readonly Guid ID;

        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        private string version;
        public string Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value;
                NotifyPropertyChanged("Version");
            }
        }
    }

    public class PackInDirectory : ChangeNotifierBase, INotifyPropertyChanged
    {
        public PackInDirectory(string modpack, string directory)
        {
            ID = Guid.NewGuid();
            this.modpack = modpack;
            this.directory = directory;
        }

        public PackInDirectory(MCModPack modpack, string directory)
        {
            ID = Guid.NewGuid();
            this.modpack = modpack.Name;
            this.directory = directory;
        }

        public readonly Guid ID;

        private string modpack;
        public string ModPack
        {
            get
            {
                return modpack;
            }

            set
            {
                modpack = value;
                NotifyPropertyChanged("ModPack");
            }
        }

        private string directory;
        public string Directory
        {
            get
            {
                return directory;
            }

            set
            {
                directory = value;
                NotifyPropertyChanged("Directory");
            }
        }

        public override string ToString()
        {
            return modpack;
        }
    }

    public class ModFile : UIListString
    {
        public ModFile(string text, bool extractVersionFromText = true) : base(text)
        {
            if (extractVersionFromText)
            {
                try
                {
                    MCVersion = new MCVersion(text, true);

                    try
                    {
                        Version = new MCVersion(text, true, 1);
                    }
                    catch (ArgumentException)
                    {

                        Version = null;
                    }
                }
                catch (ArgumentException)
                {

                    MCVersion = null;
                }
            }
            else
            {
                Version = null;
                MCVersion = null;
            }
        }

        public ModFile(string text, MCVersion mcVersion, MCVersion version) : base(text)
        {
            Version = version;
            MCVersion = mcVersion;
        }

        private MCVersion version;
        public MCVersion Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value;
                NotifyPropertyChanged("Version");
            }
        }

        private MCVersion mcVersion;
        public MCVersion MCVersion
        {
            get
            {
                return mcVersion;
            }

            set
            {
                mcVersion = value;
                NotifyPropertyChanged("Version");
            }
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(ModFile))
            {
                return false;
            }
            return Text == ((ModFile)obj).Text && Version == ((ModFile)obj).Version;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }



    public class MCVersion
    {
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Build { get; set; }

        public MCVersion(string versionString, bool extractFromString = false, int matchIndex = 0)
        {
            if (extractFromString)
            {
                MatchCollection matches = Regex.Matches(versionString, @"\d+[\.,]\d+([\.,]\d+)*");

                if (matches.Count <= matchIndex)
                {
                    throw new ArgumentException("The version string didn't contain enough matches.");
                }

                versionString = matches[matchIndex].Value;
            }

            if (!Regex.IsMatch(versionString, @"^\d+[\.,]\d+([\.,]\d+)*$"))
            {
                throw new ArgumentException("The version string provided contained characters that aren't valid for a version number.");
            }

            string[] numbers = versionString.Split('.', ',');

            Major = Convert.ToInt32(numbers[0]);
            Minor = Convert.ToInt32(numbers[1]);
            if (numbers.Length > 2)
            {
                Build = Convert.ToInt32(numbers[2]);
            }
            else
            {
                Build = 0;
            }
        }

        public MCVersion(int major, int minor, int build)
        {
            Major = major;
            Minor = minor;
            Build = build;
        }

        public override string ToString()
        {
            return Major + "." + Minor + "." + Build;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(MCVersion))
            {
                return false;
            }
            return Major == ((MCVersion)obj).Major && Minor == ((MCVersion)obj).Minor && Build == ((MCVersion)obj).Build;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}