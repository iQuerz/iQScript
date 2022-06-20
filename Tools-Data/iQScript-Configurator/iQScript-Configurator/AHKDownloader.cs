using System;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace iQScript_Configurator
{
    class AHKDownloader
    {
        public static async Task<bool> InstallAHK(MainWindow mainForm)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.autohotkey.com/download/ahk-install.exe",
                UseShellExecute = true,
            });
            return true;
        }
    }
}
