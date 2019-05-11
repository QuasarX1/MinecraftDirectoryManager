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

        private string ServerRootPath;

        private System.IO.MemoryStream AccessStream;

        public ConsoleAccessStream DirectInput;

        public System.IO.StreamReader DirectOutput;

        public ServerConsoleWindow(string root, string name)
        {
            InitializeComponent();

            this.AccessStream = new System.IO.MemoryStream();

            this.DirectInput = new ConsoleAccessStream(AccessStream);

            this.DirectOutput = new System.IO.StreamReader(AccessStream);

            this.Title = name;
            this.ServerRootPath = root;

            this.Server = null;
        }


        public void WriteToOutput(string text)
        {
            ((Paragraph)OutputRichTextBox.Document.Blocks.LastBlock).Inlines.Add(text);

            Paragraph newLine = new Paragraph(new Run());
            OutputRichTextBox.Document.Blocks.Add(newLine);
            OutputRichTextBox.ScrollToEnd();
        }

        private void WriteToServer(string text)
        {
            Server.StandardInput.WriteLine(text);
        }

        public void ClearOutput()
        {
            ((Paragraph)OutputRichTextBox.Document.Blocks.LastBlock).Inlines.Clear();
        }

        private void SubmitCommandInBox()
        {
            if (CommandEntryTextBox.Text != "")
            {
                WriteToOutput(CommandEntryTextBox.Text);

                if (Server != null && Server.HasExited == false) { WriteToServer(CommandEntryTextBox.Text); }

                CommandEntryTextBox.Text = "";
            }
        }










        private void StartServerButton_Click(object sender, RoutedEventArgs e)
        {
            // Enable and show the rest of the UI
            StartServerButton.IsEnabled = false;
            StartServerButton.Visibility = Visibility.Hidden;

            OutputRichTextBox.Visibility = Visibility.Visible;

            CommandEntryTextBox.IsEnabled = true;

            CommandSubmissionButton.IsEnabled = true;


            //// Start server
            //IPAddress IPv4 = Tools.UpdateServerProperties(ServerRootPath, DirectInput, DirectOutput, SendKey);
            //string server = Tools.SelectServer(ServerRootPath, DirectInput, SendKey, ClearOutput);
            //string guiOption = Tools.SelectGUI(DirectInput, SendKey);
            //double memory = Tools.SelectMemory(DirectInput, DirectOutput, SendKey);
            //string externalIP = Tools.GetExternalIP();
            //Tools.OutputLaunchPreamble(server, IPv4, guiOption, memory, externalIP, DirectInput, SendKey, ClearOutput);
            //Server = Tools.CreateProcess(ServerRootPath, "", "No GUI", 4);

            ////serverOutput = Server.StandardOutput;
            ////serverInput = Server.StandardInput;

            //Server.StartInfo.RedirectStandardOutput = true;
            //Server.OutputDataReceived += WriteText;
            //Server.StartInfo.RedirectStandardInput = true;

            //Server.StartInfo.CreateNoWindow = true;//TODO: change to false?
            
            

            //Server.Exited += ServerClosed;

            //Server.Start();
        }

        private void CommandEntryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SubmitCommandInBox();
            }
            else
            {

                if(SendKey != null)
                {
                    SendKey(this, Convert.ToChar(e.Key));
                    e.Handled = true;
                }
            }
        }

        private void CommandSubmissionButton_Click(object sender, RoutedEventArgs e)
        {
            SubmitCommandInBox();
        }








        private void WriteText(object sender, DataReceivedEventArgs e)
        {
            WriteToOutput(e.Data);
            //WriteToOutput(Server.StandardOutput.ReadLine());
        }

        public void ServerClosed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Server != null && Server.HasExited == false)
            {
                Server.Kill();
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