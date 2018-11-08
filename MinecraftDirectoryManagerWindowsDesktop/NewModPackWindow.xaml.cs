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
using System.Windows.Shapes;

namespace MinecraftDirectoryManagerWindowsDesktop
{
    /// <summary>
    /// Interaction logic for NewModPackWindow.xaml
    /// </summary>
    public partial class NewModPackWindow : Window
    {
        public MCModPack ModPack { get; private set; }

        public event CreateEventEventHandler Create;

        public NewModPackWindow()
        {
            InitializeComponent();

            ModPack = new MCModPack("", "");
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text != "" && VersionTextBox.Text != "")
            {
                ModPack.Name = NameTextBox.Text;
                ModPack.Version = VersionTextBox.Text;

                if (Create != null)
                {
                    if (this.Create(this) == true)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }



    public delegate bool CreateEventEventHandler(NewModPackWindow sender);
}
