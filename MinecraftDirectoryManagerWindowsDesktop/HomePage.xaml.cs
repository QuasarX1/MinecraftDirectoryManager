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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();

            VersionLabel.Content += BackEnd.GetPublishedVersion();
        }

        private void Button_Click(object sender, RoutedEventArgs args)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/QuasarX1/MinecraftDirectoryManager");
            }
            catch (System.ComponentModel.Win32Exception e)
            {
                if (e.ErrorCode == -2147467259)
                    MessageBox.Show(e.Message);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
