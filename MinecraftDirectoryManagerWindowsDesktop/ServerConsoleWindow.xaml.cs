using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for ServerConsoleWindow.xaml
    /// </summary>
    public partial class ServerConsoleWindow : Window
    {
        //private System.IO.StreamReader serverOutput;

        //private System.IO.StreamWriter serverInput;

        private Process Server;

        public ServerConsoleWindow(Process server, string name)
        {
            InitializeComponent();

            Server = server;
            this.Title = name;

            //serverOutput = Server.StandardOutput;
            //serverInput = Server.StandardInput;
            Server.StartInfo.RedirectStandardOutput = true;
            Server.StartInfo.RedirectStandardInput = true;
            Server.StartInfo.CreateNoWindow = true;//TODO: change to false

            Server.OutputDataReceived += WriteText;

            Server.Start();
        }
        
        private void WriteText(object sender, DataReceivedEventArgs e)
        {
            ((Paragraph)OutputRichTextBox.Document.Blocks.LastBlock).Inlines.Add(e.Data);
        }

        private void ReadCommand(object sender, DataReceivedEventArgs e)
        {
            if (CommandEntryTextBox.Text != "")
            {
                Server.StandardInput.WriteLine(CommandEntryTextBox.Text);
                CommandEntryTextBox.Text = "";
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Server.Kill();
        }
    }
}
