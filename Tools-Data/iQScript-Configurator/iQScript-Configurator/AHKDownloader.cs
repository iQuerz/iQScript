using System;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace iQScript_Configurator
{
    class AHKDownloader
    {
        public static async void InstallAHK()
        {
            string myDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            File.Delete(myDocumentsFolder + "ahk-install.exe");
            WebClient webClient = new WebClient();
            await webClient.DownloadFileTaskAsync(new Uri("https://www.autohotkey.com/download/ahk-install.exe"), myDocumentsFolder + "ahk-install.exe");
            Process.Start(myDocumentsFolder + "ahk-install.exe");
            webClient.Dispose();
        }
    }
}
