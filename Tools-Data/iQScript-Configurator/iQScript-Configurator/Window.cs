using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;

namespace iQScript_Configurator
{
    public partial class MainWindow : Form
    {
        Configurator _configurator;
        public bool _startup = true;
        public bool _startMenu = false;
        public bool _desktop = false;

        public MainWindow getForm() { return this; }

        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (!IsAdministrator())
            {
                MessageBox.Show(this, "This tool won't work without admin privileges.\n" +
                    "Consider restarting it as an administrator.\n" +
                    "(Right-Click -> \"Run as Administrator\")",
                    "Elevation required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            Text += $" - v{Static.Version}";
            _configurator = new Configurator(this);
            string programFiles = Environment.ExpandEnvironmentVariables("%ProgramW6432%");
            installPath.Text = programFiles + "\\iQScript";
        }

        #region CheckBoxes
        private void MandatoryChk_CheckedChanged(object sender, EventArgs e)
        {
            MandatoryChk.Checked = true;
        }
        
        private void StartMenuChk_CheckedChanged(object sender, EventArgs e)
        {
            _startMenu = StartMenuChk.Checked;
        }

        private void StartupChk_CheckedChanged(object sender, EventArgs e)
        {
            _startup = StartupChk.Checked;
        }

        private void DesktopChk_CheckedChanged(object sender, EventArgs e)
        {
            _desktop = DesktopChk.Checked;
        }

        private void CheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckAll.Checked)
            {
                AltQCloseChk.Checked = true;
                AltWMinimizeChk.Checked = true;
                Alt8DelChk.Checked = true;
                Alt9HomeChk.Checked = true;
                Alt0EndChk.Checked = true;
                AltEExplorerChk.Checked = true;
                AltANotificationPanelChk.Checked = true;
                AltSScreenshotChk.Checked = true;
                LWinPowerToysChk.Checked = true;
                AltScrollHorizontalScrollChk.Checked = true;
                CapsLockFloatChk.Checked = true;
                NumPadHomerowFloatChk.Checked = true;
                SemiColonArrowSimChk.Checked = true;
                CheckAll.Text = "Uncheck All";
            }
            else
            {
                AltQCloseChk.Checked = false;
                AltWMinimizeChk.Checked = false;
                Alt8DelChk.Checked = false;
                Alt9HomeChk.Checked = false;
                Alt0EndChk.Checked = false;
                AltEExplorerChk.Checked = false;
                AltANotificationPanelChk.Checked = false;
                AltSScreenshotChk.Checked = false;
                LWinPowerToysChk.Checked = false;
                AltScrollHorizontalScrollChk.Checked = false;
                CapsLockFloatChk.Checked = false;
                NumPadHomerowFloatChk.Checked = false;
                SemiColonArrowSimChk.Checked = false;
                CheckAll.Text = "Check All";
            }
        }

        #endregion

        #region Buttons

        private void SaveButton_Click(object sender, EventArgs e)
        {
            install(false);
        }

        private void SaveRunButton_Click(object sender, EventArgs e)
        {
            install(true);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            if (folderBrowserDialog.SelectedPath != "")
                installPath.Text = folderBrowserDialog.SelectedPath + "\\iQScript";
        }

        private void UninstButton_Click(object sender, EventArgs e)
        {
            uninstall();
        }

        private async void installAHKButton_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            await AHKDownloader.InstallAHK(this);
            UseWaitCursor = false;
        }

        #endregion

        #region logic

        private void install(bool start)
        {
            try
            {
                List<Features> featuresToInstall = new List<Features>();

                // reading from checkboxes and adding selected features
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(CheckBox))
                    {
                        CheckBox chk = (CheckBox)c;
                        if (chk.Checked)
                        {
                            if (!chk.Equals(CheckAll) && !chk.Equals(StartupChk) && !chk.Equals(StartMenuChk) && !chk.Equals(DesktopChk))
                            {
                                // - 3 from chk.Name.Length because name of checkboxes is made like "{featureName}Chk"
                                string featureString = chk.Name.Substring(0, chk.Name.Length - 3);
                                featuresToInstall.Add((Features)Enum.Parse(typeof(Features), featureString));
                            }
                        }
                    }
                }
                _configurator.install(installPath.Text, featuresToInstall);

            }
            catch (Exception ex)
            {
                logAndNotify(ex);
                Dispose();
            }
            finally
            {
                try
                {
                    if (start)
                    {
                        Process script = new Process();
                        script.StartInfo = new ProcessStartInfo(installPath.Text + "\\Scripts\\iQscript.ahk");
                        script.StartInfo.UseShellExecute = true;
                        script.Start();
                    }
                }
                catch
                {
                    MessageBox.Show(this, "Couldn't run the script. Check if AHK is installed.\n(Can be done via \"Install AHK\" button in the installer.)", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show(this, "Selected features have been installed successfuly. Enjoy.", "iQScript-Configurator",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
        }
        private void uninstall()
        {
            try
            {
                _configurator.uninstall(installPath.Text);
            }
            catch (Exception ex)
            {
                logAndNotify(ex);
            }
            finally
            {
                IWin32Window owner = this;
                MessageBox.Show(owner, "Selected features have been removed successfuly.\nHope to see you soon!", "iQScript-Configurator",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
        }
        public void logAndNotify(Exception e)
        {
            string message = @"Installation ran into an error.
                            More about this crash has been stored inside " + installPath.Text + @"\Logs.
                            Please contact the developer with this information.";

            MessageBox.Show(this, message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            DirectoryInfo di = Directory.CreateDirectory(installPath.Text + "\\Logs");
            StreamWriter logger = new StreamWriter($"{di.FullName}\\log-{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}_{DateTime.Now.Hour}h{DateTime.Now.Minute}m.log");
            logger.WriteLine($"Version: {Static.Version}");
            logger.WriteLine($"Error: {e.Message}");
            logger.WriteLine(e.StackTrace);
            logger.Dispose();
        }
        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                      .IsInRole(WindowsBuiltInRole.Administrator);
        }

        #endregion

    }
}
