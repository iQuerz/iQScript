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
            try
            {
                string myDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                File.Delete(myDocumentsFolder + "\\ahk-install.exe");

                // download ahk installer from their website.
                WebClient webClient = new WebClient();
                await webClient.DownloadFileTaskAsync(new Uri("https://www.autohotkey.com/download/ahk-install.exe"), myDocumentsFolder + "\\ahk-install.exe");
                webClient.Dispose();

                // make sure the script configurator is not running until the ahk installer is closed.
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = myDocumentsFolder + "\\ahk-install.exe"
                    }
                };
                process.Start();
                process.WaitForExit();

                // delete installer after finishing the process
                File.Delete(myDocumentsFolder + "\\ahk-install.exe");

                return true;
            }
            catch (Exception e)
            {
                mainForm.logAndNotify(e);
                return false;
            }
        }
    }
}
