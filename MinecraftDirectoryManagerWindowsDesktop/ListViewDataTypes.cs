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
}