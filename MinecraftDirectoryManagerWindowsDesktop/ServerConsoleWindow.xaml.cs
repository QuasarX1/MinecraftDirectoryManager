using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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
using QuasarCode.Library.IO.Text;
using QConsole = QuasarCode.Library.IO.Text.Console;

namespace MinecraftDirectoryManagerWindowsDesktop
{
    public class IntermediateConsole: QConsole
    {
        MemoryStream Memory;

        public IntermediateConsole(string title, MemoryStream memoryStream) : base(title, new System.IO.StreamReader(memoryStream), new System.IO.StreamWriter(memoryStream), null, true)
        {
            Memory = memoryStream;
        }

        new public string Read()
        {
            this.Memory.Seek(0, SeekOrigin.Begin);
            string result = this.In.ReadLine();
            this.Memory.Seek(0, SeekOrigin.Begin);
            return result;
        }
    }

    /// <summary>
    /// Interaction logic for ServerConsoleWindow.xaml
    /// </summary>
    public partial class ServerConsoleWindow : Window
    {
        private Thread ServerThread;

        private Process Server;

        private string ServerRootPath;

        private System.IO.MemoryStream AccessStream;

        //public System.IO.TextWriter DirectInput;

        //public System.IO.TextReader DirectOutput;

        private IntermediateConsole ConsoleHandeler;

        private delegate void WriteToOutputCallback(string text);
        private delegate void ClearCallback();


        public ServerConsoleWindow(string root, string name)
        {
            InitializeComponent();

            this.ConsoleHandeler = new IntermediateConsole(this.Title, new System.IO.MemoryStream());
            this.ConsoleHandeler.OnWrite += WriteText;
            this.ConsoleHandeler.OnClear += (object sender, EventArgs e) => { this.ClearOutput(); };

            this.Title = name;

            this.ServerRootPath = root;

            this.Server = null;
        }

        private void StartServerButton_Click(object sender, RoutedEventArgs e)
        {
            // Enable and show the rest of the UI
            StartServerButton.IsEnabled = false;
            StartServerButton.Visibility = Visibility.Hidden;
            OutputRichTextBox.Visibility = Visibility.Visible;
            CommandEntryTextBox.IsEnabled = true;
            CommandSubmissionButton.IsEnabled = true;

            ServerThread = new Thread(new ThreadStart(StartServer));

            ServerThread.Start();
        }

        private void StartServer()
        {
            // Start server
            IPAddress IPv4 = Tools.UpdateServerProperties(ServerRootPath, ref this.ConsoleHandeler.GetOut(), ref DirectOutput, ref SendKey);
            string server = Tools.SelectServer(ServerRootPath, ref DirectInput, ref SendKey, ClearOutput);
            double memory = Tools.SelectMemory(ref DirectInput, ref DirectOutput, ref SendKey);
            string externalIP = Tools.GetExternalIP();
            Tools.OutputLaunchPreamble(server, IPv4, "No GUI", memory, externalIP, ref DirectInput, ref SendKey, ClearOutput);
            Server = Tools.CreateProcess(ServerRootPath, "", "No GUI", 4);

            //serverOutput = Server.StandardOutput;
            //serverInput = Server.StandardInput;

            Server.StartInfo.RedirectStandardOutput = true;
            Server.OutputDataReceived += WriteText;
            Server.StartInfo.RedirectStandardInput = true;

            Server.StartInfo.CreateNoWindow = true;
            Server.StartInfo.UseShellExecute = false;

            Server.Exited += ServerClosed;

            Server.Start();
        }

        private void WriteText(object sender, EventArgs e)
        {
            string text = ConsoleHandeler.Read();

            OutputRichTextBox.Dispatcher.Invoke(new WriteToOutputCallback(WriteToOutput), text);
        }

        private void WriteText(object sender, DataReceivedEventArgs e)
        {
            WriteToOutput(e.Data);
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
            OutputRichTextBox.Dispatcher.Invoke(new ClearCallback(() => { ((Paragraph)OutputRichTextBox.Document.Blocks.LastBlock).Inlines.Clear(); }));
        }
    }




























    /// <summary>
    /// Interaction logic for ServerConsoleWindow.xaml
    /// </summary>
    public partial class ServerConsoleWindow : Window
    {
        ////private System.IO.StreamReader serverOutput;

        ////private System.IO.StreamWriter serverInput;

        //private Thread ServerThread;

        //private Process Server;

        //private string ServerRootPath;

        //private System.IO.MemoryStream AccessStream;

        //public System.IO.TextWriter DirectInput;

        //public System.IO.TextReader DirectOutput;

        //private QConsole ConsoleHandeler;

        //private delegate void WriteToOutputCallback(string text);
        //private delegate void ClearCallback();



        //public ServerConsoleWindow(string root, string name)
        //{
        //    InitializeComponent();

        //    this.AccessStream = new System.IO.MemoryStream();
            
        //    //this.DirectInput = (System.IO.StreamWriter)System.IO.TextWriter.Synchronized(new ConsoleAccessStream(AccessStream));
        //    this.DirectInput = new ConsoleAccessStream(AccessStream);
        //    ((ConsoleAccessStream)DirectInput).OnWrite += WriteText;

        //    this.DirectOutput = new System.IO.StreamReader(AccessStream);

        //    this.Title = name;
        //    this.ServerRootPath = root;

        //    this.Server = null;

        //    this.ConsoleHandeler = new QConsole(this.Title, this.DirectOutput, this.DirectInput, this.DirectInput);
        //}

        //public void WriteToOutput(string text)
        //{
        //    ((Paragraph)OutputRichTextBox.Document.Blocks.LastBlock).Inlines.Add(text);

        //    Paragraph newLine = new Paragraph(new Run());
        //    OutputRichTextBox.Document.Blocks.Add(newLine);
        //    OutputRichTextBox.ScrollToEnd();
        //}

        //private void WriteToServer(string text)
        //{
        //    Server.StandardInput.WriteLine(text);
        //}

        //public void ClearOutput()
        //{
        //    /*((Paragraph)OutputRichTextBox.Document.Blocks.LastBlock).Inlines.Clear();*///TODO: error for same reason as line 166
        //    OutputRichTextBox.Dispatcher.Invoke(new ClearCallback(() => { ((Paragraph)OutputRichTextBox.Document.Blocks.LastBlock).Inlines.Clear(); }));
        //}

        private void SubmitCommandInBox()
        {
            if (CommandEntryTextBox.Text != "")
            {
                WriteToOutput(CommandEntryTextBox.Text);

                if (Server != null && Server.HasExited == false) { WriteToServer(CommandEntryTextBox.Text); }

                CommandEntryTextBox.Text = "";
            }
        }

        //private void StartServerButton_Click(object sender, RoutedEventArgs e)
        //{
        //    // Enable and show the rest of the UI
        //    StartServerButton.IsEnabled = false;
        //    StartServerButton.Visibility = Visibility.Hidden;
        //    OutputRichTextBox.Visibility = Visibility.Visible;
        //    CommandEntryTextBox.IsEnabled = true;
        //    CommandSubmissionButton.IsEnabled = true;

        //    ServerThread = new Thread(new ThreadStart(StartServer));

        //    ServerThread.Start();
        //}

        //private void StartServer()
        //{
        //    // Start server
        //    IPAddress IPv4 = Tools.UpdateServerProperties(ServerRootPath, ref DirectInput, ref DirectOutput, ref SendKey);
        //    string server = Tools.SelectServer(ServerRootPath, ref DirectInput, ref SendKey, ClearOutput);
        //    double memory = Tools.SelectMemory(ref DirectInput, ref DirectOutput, ref SendKey);
        //    string externalIP = Tools.GetExternalIP();
        //    Tools.OutputLaunchPreamble(server, IPv4, "No GUI", memory, externalIP, ref DirectInput, ref SendKey, ClearOutput);
        //    Server = Tools.CreateProcess(ServerRootPath, "", "No GUI", 4);

        //    //serverOutput = Server.StandardOutput;
        //    //serverInput = Server.StandardInput;

        //    Server.StartInfo.RedirectStandardOutput = true;
        //    Server.OutputDataReceived += WriteText;
        //    Server.StartInfo.RedirectStandardInput = true;

        //    Server.StartInfo.CreateNoWindow = true;
        //    Server.StartInfo.UseShellExecute = false;

        //    Server.Exited += ServerClosed;

        //    Server.Start();
        //}

        private void CommandEntryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(SendKey != null)
            {
                KeyConverter converter = new KeyConverter();
                string key = converter.ConvertToString(e.Key);

                SendKey(this, key);
                e.Handled = true;
            }
            else if (e.Key == Key.Enter)
            {
                SubmitCommandInBox();
            }
        }

        private void CommandSubmissionButton_Click(object sender, RoutedEventArgs e)
        {
            SubmitCommandInBox();
        }

        //private void WriteText(object sender, EventArgs e)
        //{
        //    // (System.IO.StreamReader)DirectOutput cast is valid as the object is created by this class as a StreamReader
        //    long position = ((System.IO.StreamReader)DirectOutput).BaseStream.Position;
        //    ((System.IO.StreamReader)DirectOutput).BaseStream.Position = 0;// change to be start of last or clear buffer
        //    string text = DirectOutput.ReadLine();
        //    //((System.IO.StreamReader)DirectOutput).BaseStream.Flush();


        //    ((System.IO.StreamReader)DirectOutput).BaseStream.Position = 0;// position;
            
        //    OutputRichTextBox.Dispatcher.Invoke(new WriteToOutputCallback(WriteToOutput), text);
        //}

        //private void WriteText(object sender, DataReceivedEventArgs e)
        //{
        //    WriteToOutput(e.Data);
        //    //WriteToOutput(Server.StandardOutput.ReadLine());
        //}

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

            if (ServerThread != null && ServerThread.IsAlive)
            {
                ServerThread.Abort();
            }
        }


        public event EventHandler<string> SendKey;

        public class ConsoleAccessStream : System.IO.StreamWriter
        {
            public event EventHandler OnWrite;

            public ConsoleAccessStream(System.IO.MemoryStream stream) : base(stream) { }

            public override void Write(char value)
            {
                base.Write(value);
                this.Flush();
                OnWrite?.Invoke(this, new EventArgs());
            }

            public override void Write(string value)
            {
                base.Write(value);
                this.Flush();
                OnWrite?.Invoke(this, new EventArgs());
            }

            public override void Write(object value)
            {
                base.Write(value);
                this.Flush();
                OnWrite?.Invoke(this, new EventArgs());
            }

            public override void WriteLine()
            {
                base.WriteLine();
                this.Flush();
                OnWrite?.Invoke(this, new EventArgs());
            }

            public override void WriteLine(char value)
            {
                base.WriteLine(value);
                this.Flush();
                OnWrite?.Invoke(this, new EventArgs());
            }

            public override void WriteLine(string value)
            {
                base.WriteLine(value);
                this.Flush();
                OnWrite?.Invoke(this, new EventArgs());
            }

            public override void WriteLine(object value)
            {
                base.WriteLine(value);
                this.Flush();
                OnWrite?.Invoke(this, new EventArgs());
            }
        }

        
    }
}