using System;
using System.Net;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Console = System.Console;

using QuasarCode.Library.IO.Text;
using QConsole = QuasarCode.Library.IO.Text.Console;
using QuasarCode.Library.Tools;

namespace MDM_Server_Tools
{
    public class Tools
    {
        static public IPAddress UpdateServerProperties(string root)
        {
            IPAddress ip = null;
            if (File.Exists(System.IO.Path.Combine(root, "server.properties")))
            {
                StreamReader propFile = new System.IO.StreamReader(System.IO.Path.Combine(root, "server.properties"));
                List<string> lines = new List<string>();
                string line;
                line = propFile.ReadLine();
                do
                {
                    lines.Add(line);
                    line = propFile.ReadLine();
                } while (line != null);

                propFile.Close();


                //- Get internal IPv4
                IPHostEntry ipHostEntry = Dns.GetHostEntry(string.Empty);
                List<IPAddress> avalableIpv4 = (from adress in ipHostEntry.AddressList where adress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork select adress).ToList();

                if (avalableIpv4.Count > 0)
                {
                    if (avalableIpv4.Count > 1)
                    {
                        ip = QConsole.Option(avalableIpv4.ToArray(), "Select an IP:");
                        Console.WriteLine();
                    }
                    else
                    {
                        ip = avalableIpv4[0];
                    }
                }
                else
                {
                    throw new Exception();
                }
                Console.WriteLine("Using IPv4: " + ip);


                //- Offer to add BIOMESOP as the terain generator if it is in the mods folder
                int[] levelTypeOptionIndexes = (from option in lines where Regex.IsMatch(option, @"^level-type=.*") select lines.IndexOf(option)).ToArray();

                if (lines[levelTypeOptionIndexes[0]] == "level-type=DEFAULT" && Directory.Exists(System.IO.Path.Combine(root, "mods")) && (from file in Directory.GetFiles(System.IO.Path.Combine(root, "mods")) where Regex.IsMatch(file, @"BiomesOPlenty.*\.jar") select file).Count() > 0)
                {
                    if (QConsole.Option(new string[] { "No", "Yes" }, "Enable Biomes O' Plenty?") == "Yes")
                    {
                        lines[levelTypeOptionIndexes[0]] = "level-type=BIOMESOP";
                    }
                }


                //- Offer to change the motd
                int[] motdOptionIndexes = (from option in lines where Regex.IsMatch(option, @"^motd=.*") select lines.IndexOf(option)).ToArray();


                if (QConsole.Option(new string[] { "No", "Yes" }, "Change the message of the day?") == "Yes")
                {
                    lines[motdOptionIndexes[0]] = "motd=" + QConsole.Input("New motd >>> ");
                }


                StreamWriter propFileWriter = new System.IO.StreamWriter(System.IO.Path.Combine(root, "server.properties"));
                foreach (string lineWrite in lines)
                {
                    if (Regex.IsMatch(lineWrite, @"^server-ip=.*"))
                    {
                        propFileWriter.WriteLine("server-ip=" + ip.ToString());
                    }
                    else
                    {
                        propFileWriter.WriteLine(lineWrite);
                    }
                }

                propFileWriter.Close();
            }

            return ip;
        }

        static public IPAddress UpdateServerProperties(string root, ref TextWriter output, ref TextReader input, ref EventHandler<string> SendKeyEvent)
        {
            IPAddress ip = null;
            if (File.Exists(System.IO.Path.Combine(root, "server.properties")))
            {
                StreamReader propFile = new System.IO.StreamReader(System.IO.Path.Combine(root, "server.properties"));
                List<string> lines = new List<string>();
                string line;
                line = propFile.ReadLine();
                do
                {
                    lines.Add(line);
                    line = propFile.ReadLine();
                } while (line != null);

                propFile.Close();


            //- Get internal IPv4
                IPHostEntry ipHostEntry = Dns.GetHostEntry(string.Empty);
                List<IPAddress> avalableIpv4 = (from adress in ipHostEntry.AddressList where adress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork select adress).ToList();

                if (avalableIpv4.Count > 0)
                {
                    if (avalableIpv4.Count > 1)
                    {
                        ip = QConsole.Option(avalableIpv4.ToArray(), ref SendKeyEvent, ref output, "Select an IP:");
                        output.WriteLine();
                    }
                    else
                    {
                        ip = avalableIpv4[0];
                    }
                }
                else
                {
                    throw new Exception();
                }
                output.WriteLine("Using IPv4: " + ip);


            //- Offer to add BIOMESOP as the terain generator if it is in the mods folder
                int[] levelTypeOptionIndexes = (from option in lines where Regex.IsMatch(option, @"^level-type=.*") select lines.IndexOf(option)).ToArray();

                if (lines[levelTypeOptionIndexes[0]] == "level-type=DEFAULT" && Directory.Exists(System.IO.Path.Combine(root, "mods")) && (from file in Directory.GetFiles(System.IO.Path.Combine(root, "mods")) where Regex.IsMatch(file, @"BiomesOPlenty.*\.jar") select file).Count() > 0)
                {
                    if (QConsole.Option(new string[] { "No", "Yes" }, ref SendKeyEvent, ref output, "Enable Biomes O' Plenty?") == "Yes")
                    {
                        lines[levelTypeOptionIndexes[0]] = "level-type=BIOMESOP";
                    }
                }


            //- Offer to change the motd
                int[] motdOptionIndexes = (from option in lines where Regex.IsMatch(option, @"^motd=.*") select lines.IndexOf(option)).ToArray();


                if (QConsole.Option(new string[] { "No", "Yes" }, ref SendKeyEvent, ref output, "Change the message of the day?") == "Yes")
                {
                    lines[motdOptionIndexes[0]] = "motd=" + QConsole.Input(ref output, ref input, "New motd >>> ");
                }


                StreamWriter propFileWriter = new System.IO.StreamWriter(System.IO.Path.Combine(root, "server.properties"));
                foreach (string lineWrite in lines)
                {
                    if (Regex.IsMatch(lineWrite, @"^server-ip=.*"))
                    {
                        propFileWriter.WriteLine("server-ip=" + ip.ToString());
                    }
                    else
                    {
                        propFileWriter.WriteLine(lineWrite);
                    }
                }

                propFileWriter.Close();
            }

            return ip;
        }



        static public string SelectServer(string root)
        {
            var avalableServers = (
                from file in Directory.GetFiles(root)
                where Regex.IsMatch(Path.GetFileName(file), @"forge.*\.jar") || Regex.IsMatch(Path.GetFileName(file), @"minecraft_server.*\.jar") || Regex.IsMatch(Path.GetFileName(file), @"server.*\.jar")
                select Path.GetFileName(file)
                ).ToList();

            string selectedServer = null;
            if (avalableServers.Count > 0)
            {
                if (avalableServers.Count > 1)
                {
                    Console.WriteLine();
                    selectedServer = QConsole.Option(avalableServers.ToArray(), "Select a server:");
                    Console.WriteLine();
                }
                else
                {
                    selectedServer = avalableServers[0];
                }
            }
            else
            {
                Console.Clear();
                Console.Write("No servers can be found in this directory.\nPress any key to continue... ");
                Console.ReadKey();

                System.Environment.Exit(0);
            }

            Console.WriteLine("Using server: " + selectedServer + "\n");

            return selectedServer;
        }

        static public string SelectServer(string root, ref TextWriter output, ref EventHandler<string> SendKeyEvent, Action consoleClear = null)
        {
            if (consoleClear is null)
            {
                consoleClear = Console.Clear;
            }

            var avalableServers = (
                from file in Directory.GetFiles(root)
                where Regex.IsMatch(Path.GetFileName(file), @"forge.*\.jar") || Regex.IsMatch(Path.GetFileName(file), @"minecraft_server.*\.jar") || Regex.IsMatch(Path.GetFileName(file), @"server.*\.jar")
                select Path.GetFileName(file)
                ).ToList();

            string selectedServer = null;
            if (avalableServers.Count > 0)
            {
                if (avalableServers.Count > 1)
                {
                    output.WriteLine();
                    selectedServer = QConsole.Option(avalableServers.ToArray(), ref SendKeyEvent, ref output, "Select a server:");
                    output.WriteLine();
                }
                else
                {
                    selectedServer = avalableServers[0];
                }
            }
            else
            {
                consoleClear();
                output.Write("No servers can be found in this directory.\nPress any key to continue... ");
                QConsole.ReadKey(ref SendKeyEvent);

                System.Environment.Exit(0);
            }

            output.WriteLine("Using server: " + selectedServer + "\n");

            return selectedServer;
        }



        static public string SelectGUI()
        {
            List<string> options = new List<string> { "GUI", "No GUI" };
            string guiOption = QConsole.Option(options.ToArray(), "Select a launch option:");
            return guiOption;
        }

        static public string SelectGUI(ref TextWriter output, ref EventHandler<string> SendKeyEvent)
        {
            List<string> options = new List<string> { "GUI", "No GUI" };
            string guiOption = QConsole.Option(options.ToArray(), ref SendKeyEvent, ref output, "Select a launch option:");
            return guiOption;
        }



        static public double SelectMemory()
        {

            double memory;

            if (QConsole.Option(new string[] { "No", "Yes" }, "Alocate custom memory ammount? (Deafult is 4GB)") == "Yes")
            {
                memory = Convert.ToInt16(QConsole.Input("Gigabytes of memory >>> ", Validators.IsInt, "The value must be an integer."));
            }
            else
            {
                memory = 4;
            }

            return memory;
        }

        static public double SelectMemory(ref TextWriter output, ref TextReader input, ref EventHandler<string> SendKeyEvent)
        {
            double memory;

            if (QConsole.Option(new string[] { "No", "Yes" }, ref SendKeyEvent, ref output, "Alocate custom memory ammount? (Deafult is 4GB)") == "Yes")
            {
                memory = Convert.ToInt16(QConsole.Input(ref output, ref input, "Gigabytes of memory >>> ", Validators.IsInt, "The value must be an integer."));
            }
            else
            {
                memory = 4;
            }

            return memory;
        }



        static public string GetExternalIP()
        {
            string externalip = null;
            try
            {
                externalip = new WebClient().DownloadString("http://ipv4.icanhazip.com");
            }
            catch (WebException) { }

            return externalip;
        }



        static public void OutputLaunchPreamble(string selectedServer, IPAddress ip, string guiOption, double memory, string externalip)
        {
            Console.Clear();
            Console.WriteLine(string.Format("Running server \"{0}\" {1} with {2} using {3}GB of RAM.", selectedServer, ((ip != null) ? "on IPv4 adress " + ip.ToString() : "internaly"), guiOption, memory));
            Console.WriteLine((externalip != null) ? string.Format("Public IP adress: {0}", externalip) : "Unable to locate a public IP adress. Check your internet connection.");
            Console.WriteLine("Press any key to start the server...");
            Console.ReadKey();
        }

        static public void OutputLaunchPreamble(string selectedServer, IPAddress ip, string guiOption, double memory, string externalip, ref TextWriter output, ref EventHandler<string> SendKeyEvent, Action consoleClear = null)
        {
            if (consoleClear is null)
            {
                consoleClear = Console.Clear;
            }

            consoleClear();
            output.WriteLine(string.Format("Running server \"{0}\" {1} with {2} using {3}GB of RAM.", selectedServer, ((ip != null) ? "on IPv4 adress " + ip.ToString() : "internaly"), guiOption, memory));
            output.WriteLine((externalip != null) ? string.Format("Public IP adress: {0}", externalip) : "Unable to locate a public IP adress. Check your internet connection.");
            output.WriteLine("Press any key to start the server...");
            QConsole.ReadKey(ref SendKeyEvent);
        }



        static public System.Diagnostics.Process CreateProcess(string root, string selectedServer, string guiOption, double memory)
        {
            //- Launch the server with the correct configuration
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WorkingDirectory = root,
                CreateNoWindow = guiOption != "No GUI",
                WindowStyle = (guiOption == "No GUI") ? System.Diagnostics.ProcessWindowStyle.Hidden : System.Diagnostics.ProcessWindowStyle.Normal,
                FileName = "java",
                Arguments = string.Format("-Xmx{0}G -Xms{0}G -jar {1}{2}", memory, selectedServer, (guiOption == "No GUI") ? " nogui" : "")
            };
            process.StartInfo = startInfo;

            return process;
        }
    }
}
