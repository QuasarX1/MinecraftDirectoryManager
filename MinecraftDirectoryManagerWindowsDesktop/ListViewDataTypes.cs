using System;
using System.Windows.Controls;
using System.ComponentModel;

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
}