using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
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

using MDM_Server_Tools;

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

        private System.IO.MemoryStream AccessStream;
        public ConsoleAccessStream DirectInput;
        public System.IO.StreamReader DirectOutput;

        public ServerConsoleWindow(string root, string name)
        {
            InitializeComponent();

            this.Show();

            AccessStream = new System.IO.MemoryStream();
            DirectInput = new ConsoleAccessStream(AccessStream);
            DirectOutput = new System.IO.StreamReader(AccessStream);

            this.Title = name;
            
            IPAddress IPv4 = Tools.UpdateServerProperties(root, DirectInput, DirectOutput, SendKey);
            string server = Tools.SelectServer(root, DirectInput, SendKey, ClearOutput);
            string guiOption = Tools.SelectGUI(DirectInput, SendKey);
            double memory = Tools.SelectMemory(DirectInput, DirectOutput, SendKey);
            string externalIP = Tools.GetExternalIP();
            Tools.OutputLaunchPreamble(server, IPv4, guiOption, memory, externalIP, DirectInput, SendKey, ClearOutput);
            Server = Tools.CreateProcess(root, "", "No GUI", 4);

            //serverOutput = Server.StandardOutput;
            //serverInput = Server.StandardInput;
            Server.StartInfo.RedirectStandardOutput = true;
            Server.StartInfo.RedirectStandardInput = true;
            Server.StartInfo.CreateNoWindow = true;//TODO: change to false

            Server.OutputDataReceived += WriteText;
            Server.Exited += ServerClosed;

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

        public void ClearOutput()
        {
            ((Paragraph)OutputRichTextBox.Document.Blocks.LastBlock).Inlines.Clear();
        }

        public void ServerClosed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Server.Kill();
        }

        private void CommandEntryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (SendKey != null)
            {
                SendKey(this, Convert.ToChar(e.Key));
                e.Handled = true;
            }
        }


        public event EventHandler<char> SendKey;

        public class ConsoleAccessStream : System.IO.StreamWriter
        {
            public event EventHandler OnWrite;

            public ConsoleAccessStream(System.IO.MemoryStream stream) : base(stream) { }

            public override void Write(char value)
            {
                base.Write(value);
                OnWrite?.Invoke(this, new EventArgs());
            }

            public override void Write(string value)
            {
                base.Write(value);
                OnWrite?.Invoke(this, new EventArgs());
            }

            public override void Write(object value)
            {
                base.Write(value);
                OnWrite?.Invoke(this, new EventArgs());
            }

            public override void WriteLine()
            {
                base.WriteLine();
                OnWrite?.Invoke(this, new EventArgs());
            }

            public override void WriteLine(char value)
            {
                base.WriteLine(value);
                OnWrite?.Invoke(this, new EventArgs());
            }

            public override void WriteLine(string value)
            {
                base.WriteLine(value);
                OnWrite?.Invoke(this, new EventArgs());
            }

            public override void WriteLine(object value)
            {
                base.WriteLine(value);
                OnWrite?.Invoke(this, new EventArgs());
            }
        }
    }
}