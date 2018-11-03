using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftDirectoryManagerWindowsDesktop
{
    static class Constants
    {
        public static string APPDATA = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.Create) + @"\MDM\";
    }
}
