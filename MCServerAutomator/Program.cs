using System;
using System.Net;

using static MDM_Server_Tools.Tools;

namespace MCServerAutomator
{
    class Program
    {
        static void Main(string[] args)
        {
            string root = "..";

            IPAddress IPv4 = UpdateServerProperties(root);
            string server = SelectServer(root);
            Console.WriteLine();
            string guiOption = SelectGUI();
            Console.WriteLine();
            double memory = SelectMemory();
            Console.WriteLine();
            string externalIP = GetExternalIP();
            OutputLaunchPreamble(server, IPv4, guiOption, memory, externalIP);
            System.Diagnostics.Process process = CreateProcess(root, server, guiOption, memory);
            process.Start();








            ////- Update server.properties with correct IPv4
            //    IPAddress ip = null;
            //    if (File.Exists("..\\server.properties"))
            //    {
            //        StreamReader propFile = new System.IO.StreamReader("..\\server.properties");
            //        List<string> lines = new List<string>();
            //        string line;
            //        line = propFile.ReadLine();
            //        do
            //        {
            //            lines.Add(line);
            //            line = propFile.ReadLine();
            //        } while (line != null);

            //        propFile.Close();


            //        //- Get internal IPv4
            //        IPHostEntry ipHostEntry = Dns.GetHostEntry(string.Empty);
            //        List<IPAddress> avalableIpv4 = (from adress in ipHostEntry.AddressList where adress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork select adress).ToList();

            //        if (avalableIpv4.Count > 0)
            //        {
            //            if (avalableIpv4.Count > 1)
            //            {
            //                ip = QConsole.Option(avalableIpv4.ToArray(), "Select an IP:");
            //                Console.WriteLine();
            //            }
            //            else
            //            {
            //                ip = avalableIpv4[0];
            //            }
            //        }
            //        else
            //        {
            //            throw new Exception();
            //        }
            //        Console.WriteLine("Using IPv4: " + ip);


            //    //- Offer to add BIOMESOP as the terain generator if it is in the mods folder
            //        int[] levelTypeOptionIndexes = (from option in lines where Regex.IsMatch(option, @"^level-type=.*") select lines.IndexOf(option)).ToArray();

            //        if (lines[levelTypeOptionIndexes[0]] == "level-type=DEFAULT" && Directory.Exists("..\\mods") && (from file in Directory.GetFiles("..\\mods") where Regex.IsMatch(file, @"BiomesOPlenty.*\.jar") select file).Count() > 0)
            //        {
            //            if (QConsole.Option(new string[] { "No", "Yes" }, "Enable Biomes O' Plenty?") == "Yes")
            //            {
            //                lines[levelTypeOptionIndexes[0]] = "level-type=BIOMESOP";
            //            }
            //        }


            //        //- Offer to change the motd
            //        int[] motdOptionIndexes = (from option in lines where Regex.IsMatch(option, @"^motd=.*") select lines.IndexOf(option)).ToArray();


            //        if (QConsole.Option(new string[] { "No", "Yes" }, "Change the message of the day?") == "Yes")
            //        {
            //            lines[motdOptionIndexes[0]] = "motd=" + QConsole.Input("New motd >>> ");
            //        }


            //        StreamWriter propFileWriter = new System.IO.StreamWriter("..\\server.properties");
            //        foreach (string lineWrite in lines)
            //        {
            //            if (Regex.IsMatch(lineWrite, @"^server-ip=.*"))
            //            {
            //                propFileWriter.WriteLine("server-ip=" + ip.ToString());
            //            }
            //            else
            //            {
            //                propFileWriter.WriteLine(lineWrite);
            //            }
            //        }

            //        propFileWriter.Close();
            //    }



            ////- Select the server to launch
            //    var avalableServers = (
            //        from file in Directory.GetFiles("..\\")
            //        where Regex.IsMatch(Path.GetFileName(file), @"forge.*\.jar") || Regex.IsMatch(Path.GetFileName(file), @"minecraft_server.*\.jar") || Regex.IsMatch(Path.GetFileName(file), @"server.*\.jar")
            //        select Path.GetFileName(file)
            //        ).ToList();

            //    string selectedServer = null;
            //    if (avalableServers.Count > 0)
            //    {
            //        if (avalableServers.Count > 1)
            //        {
            //            Console.WriteLine();
            //            selectedServer = QConsole.Option(avalableServers.ToArray(), "Select a server:");
            //            Console.WriteLine();
            //        }
            //        else
            //        {
            //            selectedServer = avalableServers[0];
            //        }
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.Write("No servers can be found in this directory.\nPress any key to continue... ");
            //        Console.ReadKey(true);

            //        System.Environment.Exit(0);
            //    }

            //    Console.WriteLine("Using server: " + selectedServer + "\n");



            ////- Select how to display the server output
            //    List<string> options = new List<string> { "GUI", "No GUI" };
            //    string guiOption = QConsole.Option(options.ToArray(), "Select a launch option:");



            //    //- Offer to change the motd
            //    double memory;


            //    if (QConsole.Option(new string[] { "No", "Yes" }, "Alocate custom memory ammount? (Deafult is 4GB)") == "Yes")
            //    {
            //        memory = Convert.ToInt16(QConsole.Input("Gigabytes of memory >>> ", Validators.IsInt, "The value must be an integer."));
            //    }
            //    else
            //    {
            //        memory = 4;
            //    }



            //    //- Find the machine's public IP
            //    string externalip = null;
            //    try
            //    {
            //        externalip = new WebClient().DownloadString("http://ipv4.icanhazip.com");
            //    }
            //    catch (WebException) { }




            //    Console.Clear();
            //    Console.WriteLine(string.Format("Running server \"{0}\" {1} with {2}.", selectedServer, ((ip != null) ? "on IPv4 adress " + ip.ToString() : "internaly"), guiOption));
            //    Console.WriteLine((externalip != null) ? string.Format("Public IP adress: {0}", externalip) : "Unable to locate a public IP adress. Check your internet connection.");
            //    Console.WriteLine("Press any key to start the server...");
            //    Console.ReadKey(true);

            ////- Launch the server with the correct configuration
            //    System.Diagnostics.Process process = new System.Diagnostics.Process();
            //    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //    startInfo.WorkingDirectory = "..//";
            //    startInfo.CreateNoWindow = guiOption != "No GUI";
            //    startInfo.WindowStyle = (guiOption == "No GUI") ? System.Diagnostics.ProcessWindowStyle.Hidden : System.Diagnostics.ProcessWindowStyle.Normal;
            //    startInfo.FileName = "java";
            //    startInfo.Arguments = string.Format("-Xmx{0}G -Xms{0}G -jar {1}{2}", 4, selectedServer, (guiOption == "No GUI") ? " nogui" : "");
            //    process.StartInfo = startInfo;
            //    process.Start();
        }
    }
}
