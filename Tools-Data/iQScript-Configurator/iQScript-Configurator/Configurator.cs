using System;
using System.Collections.Generic;
using System.IO;

namespace iQScript_Configurator
{
    public class Configurator
    {
        readonly Dictionary<Features, string> _features;
        readonly MainWindow _mainWindow;
        public Configurator(MainWindow mainWindow)
        {
            _features = new Dictionary<Features, string>();
            _mainWindow = mainWindow;
        }

        #region install

        // Concoct the script based on user's choices.
        public void install(string path, List<Features> featuresToInstall)
        {
            loadData();

            #region Directories Setup (+ caps, numpad, notifier.exe)
            Directory.CreateDirectory(path);

            DirectoryInfo di;

            di = Directory.CreateDirectory(path + "\\Tools-Data");
            File.WriteAllBytes(di.FullName + "\\iQScriptNotifier.exe", Resources.iQScriptNotifier);

            // Create CapsLock folder and save CapsLock.png to it
            if (featuresToInstall.Contains(Features.CapsLockFloat))
            {
                di = Directory.CreateDirectory(path + "\\Tools-Data\\CapsLock");
                Resources.CapsLock.Save(di.FullName + "\\CapsLock.png");
            }

            // Same but for NumPad\NumPad.png
            if (featuresToInstall.Contains(Features.NumPadHomerowFloat))
            {
                di = Directory.CreateDirectory(path + "\\Tools-Data\\NumPad");
                Resources.NumPad.Save(di.FullName + "\\NumPad.png");
            }

            // Create Scripts folder. We will store our scripts here.
            di = Directory.CreateDirectory(path + "\\Scripts");
            #endregion

            #region Main script file
            // Writes code for each feature the user wants to use.
            StreamWriter writer = new StreamWriter(path + "\\Scripts\\iQscript.txt");
            writer.WriteLine($"currentVersion = {Static.Version}");
            foreach(var snippet in _features)
            {
                if (featuresToInstall.Contains(snippet.Key))
                {
                    writer.WriteLine(snippet.Value);
                }
            }
            writer.Dispose();
            File.Delete(path + "\\Scripts\\iQscript.ahk");
            File.Move(path + "\\Scripts\\iQscript.txt", path + "\\Scripts\\iQscript.ahk");
            #endregion

            #region Other script files
            // Saves other script files
            if (featuresToInstall.Contains(Features.CapsLockFloat))
                File.WriteAllText(di.FullName + "\\iQcaps.ahk", Resources.iQcaps);

            if(featuresToInstall.Contains(Features.NumPadHomerowFloat))
                File.WriteAllText(di.FullName + "\\iQnumpad.ahk", Resources.iQnumpad);

            File.WriteAllText(di.FullName + "\\iQdialog.ahk", Resources.iQdialog);
            #endregion

            #region Shortcuts
            if (_mainWindow.getForm()._desktop)
                Desktop(path + "\\Scripts\\iQscript.ahk");

            if(_mainWindow.getForm()._startMenu)
                StartMenu(path + "\\Scripts\\iQscript.ahk");

            if (_mainWindow.getForm()._startup)
                Startup(path + "\\Scripts\\iQscript.ahk");
            #endregion
        }


        // Tie each feature with its code snippet
        private void loadData()
        {
            StringReader reader = new StringReader(Resources.iQscript);
            Features feature = Features.Mandatory;
            string buffer = "";
            string temp;
            while (true)
            {
                temp = reader.ReadLine();
                if (temp == null)
                    break;
                if (temp.StartsWith(';'))
                {
                    _features.Add(feature, buffer);
                    buffer = temp;
                    string featureString = temp[1..temp.IndexOf(" ")];
                    feature = (Features)Enum.Parse(typeof(Features), featureString);
                    continue;
                }
                buffer += "\n" + temp;
            }
            _features.Add(feature, buffer);
        }

        #endregion

        #region uninstall

        public void uninstall(string path)
        {
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\iQscript.lnk");
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup) + "\\iQscript.lnk");

            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\iQScript"))
            {
                emptyDir(new DirectoryInfo
                    (Environment.GetFolderPath
                        (Environment.SpecialFolder.CommonPrograms)
                            + "\\iQScript"));
            }

            if (Directory.Exists(path))
            {
                emptyDir(new DirectoryInfo(path));
            }
        }
        public void emptyDir(DirectoryInfo dir)
        {
            foreach (FileInfo file in dir.GetFiles())
                file.Delete();
            foreach (DirectoryInfo subdir in dir.GetDirectories())
                emptyDir(subdir);
            dir.Delete();
        }

        #endregion

        #region shortcuts

        // Create a shortcut inside the Start Menu folder.
        private void StartMenu(string pathToFile)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
            Directory.CreateDirectory(path + "\\iQScript");
            ShortcutTool.MakeShortcut(pathToFile, path + "\\iQScript\\iQscript.lnk", "iQScript");
        }


        // Create a shortcut inside the Startup folder.
        private void Startup(string pathToFile)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
            ShortcutTool.MakeShortcut(pathToFile, path + "\\iQscript.lnk", "iQScript");
        }


        // Create a shortcut inside the Desktop folder
        private void Desktop(string pathToFile)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ShortcutTool.MakeShortcut(pathToFile, path + "\\iQscript.lnk", "iQScript");
        }

        #endregion

    }
}
