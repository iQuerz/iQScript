
namespace iQScript_Configurator
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveButton = new System.Windows.Forms.Button();
            this.MandatoryChk = new System.Windows.Forms.CheckBox();
            this.AltQCloseChk = new System.Windows.Forms.CheckBox();
            this.AltWMinimizeChk = new System.Windows.Forms.CheckBox();
            this.Alt8DelChk = new System.Windows.Forms.CheckBox();
            this.Alt9HomeChk = new System.Windows.Forms.CheckBox();
            this.Alt0EndChk = new System.Windows.Forms.CheckBox();
            this.AltEExplorerChk = new System.Windows.Forms.CheckBox();
            this.AltANotificationPanelChk = new System.Windows.Forms.CheckBox();
            this.AltSScreenshotChk = new System.Windows.Forms.CheckBox();
            this.LWinPowerToysChk = new System.Windows.Forms.CheckBox();
            this.AltScrollHorizontalScrollChk = new System.Windows.Forms.CheckBox();
            this.CapsLockFloatChk = new System.Windows.Forms.CheckBox();
            this.NumPadHomerowFloatChk = new System.Windows.Forms.CheckBox();
            this.SemiColonArrowSimChk = new System.Windows.Forms.CheckBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.CheckAll = new System.Windows.Forms.CheckBox();
            this.installPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderIcon = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Uninst = new System.Windows.Forms.Button();
            this.StartupChk = new System.Windows.Forms.CheckBox();
            this.StartMenuChk = new System.Windows.Forms.CheckBox();
            this.DesktopChk = new System.Windows.Forms.CheckBox();
            this.SaveRunButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(140, 464);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 41);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MandatoryChk
            // 
            this.MandatoryChk.AutoSize = true;
            this.MandatoryChk.Checked = true;
            this.MandatoryChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MandatoryChk.Location = new System.Drawing.Point(12, 12);
            this.MandatoryChk.Name = "MandatoryChk";
            this.MandatoryChk.Size = new System.Drawing.Size(84, 19);
            this.MandatoryChk.TabIndex = 2;
            this.MandatoryChk.Text = "Mandatory";
            this.MandatoryChk.UseVisualStyleBackColor = true;
            this.MandatoryChk.CheckedChanged += new System.EventHandler(this.MandatoryChk_CheckedChanged);
            // 
            // AltQCloseChk
            // 
            this.AltQCloseChk.AutoSize = true;
            this.AltQCloseChk.Location = new System.Drawing.Point(12, 37);
            this.AltQCloseChk.Name = "AltQCloseChk";
            this.AltQCloseChk.Size = new System.Drawing.Size(216, 19);
            this.AltQCloseChk.TabIndex = 3;
            this.AltQCloseChk.Text = "Alt+Q for closing the active window";
            this.AltQCloseChk.UseVisualStyleBackColor = true;
            // 
            // AltWMinimizeChk
            // 
            this.AltWMinimizeChk.AutoSize = true;
            this.AltWMinimizeChk.Location = new System.Drawing.Point(12, 62);
            this.AltWMinimizeChk.Name = "AltWMinimizeChk";
            this.AltWMinimizeChk.Size = new System.Drawing.Size(240, 19);
            this.AltWMinimizeChk.TabIndex = 4;
            this.AltWMinimizeChk.Text = "Alt+W for minimizing the active window";
            this.AltWMinimizeChk.UseVisualStyleBackColor = true;
            // 
            // Alt8DelChk
            // 
            this.Alt8DelChk.AutoSize = true;
            this.Alt8DelChk.Location = new System.Drawing.Point(12, 87);
            this.Alt8DelChk.Name = "Alt8DelChk";
            this.Alt8DelChk.Size = new System.Drawing.Size(130, 19);
            this.Alt8DelChk.TabIndex = 5;
            this.Alt8DelChk.Text = "Alt+8 for Delete key";
            this.Alt8DelChk.UseVisualStyleBackColor = true;
            // 
            // Alt9HomeChk
            // 
            this.Alt9HomeChk.AutoSize = true;
            this.Alt9HomeChk.Location = new System.Drawing.Point(12, 112);
            this.Alt9HomeChk.Name = "Alt9HomeChk";
            this.Alt9HomeChk.Size = new System.Drawing.Size(130, 19);
            this.Alt9HomeChk.TabIndex = 6;
            this.Alt9HomeChk.Text = "Alt+9 for Home key";
            this.Alt9HomeChk.UseVisualStyleBackColor = true;
            // 
            // Alt0EndChk
            // 
            this.Alt0EndChk.AutoSize = true;
            this.Alt0EndChk.Location = new System.Drawing.Point(12, 137);
            this.Alt0EndChk.Name = "Alt0EndChk";
            this.Alt0EndChk.Size = new System.Drawing.Size(117, 19);
            this.Alt0EndChk.TabIndex = 7;
            this.Alt0EndChk.Text = "Alt+0 for End key";
            this.Alt0EndChk.UseVisualStyleBackColor = true;
            // 
            // AltEExplorerChk
            // 
            this.AltEExplorerChk.AutoSize = true;
            this.AltEExplorerChk.Location = new System.Drawing.Point(12, 162);
            this.AltEExplorerChk.Name = "AltEExplorerChk";
            this.AltEExplorerChk.Size = new System.Drawing.Size(140, 19);
            this.AltEExplorerChk.TabIndex = 8;
            this.AltEExplorerChk.Text = "Alt+E for File Explorer";
            this.AltEExplorerChk.UseVisualStyleBackColor = true;
            // 
            // AltANotificationPanelChk
            // 
            this.AltANotificationPanelChk.AutoSize = true;
            this.AltANotificationPanelChk.Location = new System.Drawing.Point(12, 187);
            this.AltANotificationPanelChk.Name = "AltANotificationPanelChk";
            this.AltANotificationPanelChk.Size = new System.Drawing.Size(173, 19);
            this.AltANotificationPanelChk.TabIndex = 9;
            this.AltANotificationPanelChk.Text = "Alt+A for Notification Panel";
            this.AltANotificationPanelChk.UseVisualStyleBackColor = true;
            // 
            // AltSScreenshotChk
            // 
            this.AltSScreenshotChk.AutoSize = true;
            this.AltSScreenshotChk.Location = new System.Drawing.Point(12, 212);
            this.AltSScreenshotChk.Name = "AltSScreenshotChk";
            this.AltSScreenshotChk.Size = new System.Drawing.Size(385, 19);
            this.AltSScreenshotChk.TabIndex = 10;
            this.AltSScreenshotChk.Text = "Alt+S for Screenshot. Relies on PrintScreen and Screensnip(for now).";
            this.AltSScreenshotChk.UseVisualStyleBackColor = true;
            // 
            // LWinPowerToysChk
            // 
            this.LWinPowerToysChk.AutoSize = true;
            this.LWinPowerToysChk.Location = new System.Drawing.Point(12, 237);
            this.LWinPowerToysChk.Name = "LWinPowerToysChk";
            this.LWinPowerToysChk.Size = new System.Drawing.Size(489, 19);
            this.LWinPowerToysChk.TabIndex = 11;
            this.LWinPowerToysChk.Text = "Replaces Windows button with Alt+R for PowerToys Run. Requires Microsoft Powertoy" +
    "s.";
            this.LWinPowerToysChk.UseVisualStyleBackColor = true;
            // 
            // AltScrollHorizontalScrollChk
            // 
            this.AltScrollHorizontalScrollChk.AutoSize = true;
            this.AltScrollHorizontalScrollChk.Location = new System.Drawing.Point(12, 262);
            this.AltScrollHorizontalScrollChk.Name = "AltScrollHorizontalScrollChk";
            this.AltScrollHorizontalScrollChk.Size = new System.Drawing.Size(336, 19);
            this.AltScrollHorizontalScrollChk.TabIndex = 12;
            this.AltScrollHorizontalScrollChk.Text = "Alt+Scroll for Horizontal Scroll. Up is left and down is right.";
            this.AltScrollHorizontalScrollChk.UseVisualStyleBackColor = true;
            // 
            // CapsLockFloatChk
            // 
            this.CapsLockFloatChk.AutoSize = true;
            this.CapsLockFloatChk.Location = new System.Drawing.Point(12, 287);
            this.CapsLockFloatChk.Name = "CapsLockFloatChk";
            this.CapsLockFloatChk.Size = new System.Drawing.Size(211, 19);
            this.CapsLockFloatChk.TabIndex = 13;
            this.CapsLockFloatChk.Text = "Enable CapsLock Floating Indicator";
            this.CapsLockFloatChk.UseVisualStyleBackColor = true;
            // 
            // NumPadHomerowFloatChk
            // 
            this.NumPadHomerowFloatChk.AutoSize = true;
            this.NumPadHomerowFloatChk.Location = new System.Drawing.Point(12, 312);
            this.NumPadHomerowFloatChk.Name = "NumPadHomerowFloatChk";
            this.NumPadHomerowFloatChk.Size = new System.Drawing.Size(280, 19);
            this.NumPadHomerowFloatChk.TabIndex = 14;
            this.NumPadHomerowFloatChk.Text = "Ctrl + CapsLock to turn homerow into NumPad.";
            this.NumPadHomerowFloatChk.UseVisualStyleBackColor = true;
            // 
            // SemiColonArrowSimChk
            // 
            this.SemiColonArrowSimChk.AutoSize = true;
            this.SemiColonArrowSimChk.Location = new System.Drawing.Point(12, 337);
            this.SemiColonArrowSimChk.Name = "SemiColonArrowSimChk";
            this.SemiColonArrowSimChk.Size = new System.Drawing.Size(428, 19);
            this.SemiColonArrowSimChk.TabIndex = 15;
            this.SemiColonArrowSimChk.Text = "Enable Arrow Keys simulation on I, J, K, L while holding down Semicolon key";
            this.SemiColonArrowSimChk.UseVisualStyleBackColor = true;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(396, 464);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(122, 41);
            this.QuitButton.TabIndex = 16;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CheckAll
            // 
            this.CheckAll.AutoSize = true;
            this.CheckAll.Location = new System.Drawing.Point(103, 11);
            this.CheckAll.Name = "CheckAll";
            this.CheckAll.Size = new System.Drawing.Size(76, 19);
            this.CheckAll.TabIndex = 17;
            this.CheckAll.Text = "Check All";
            this.CheckAll.UseVisualStyleBackColor = true;
            this.CheckAll.CheckedChanged += new System.EventHandler(this.CheckAll_CheckedChanged);
            // 
            // installPath
            // 
            this.installPath.Location = new System.Drawing.Point(43, 391);
            this.installPath.Name = "installPath";
            this.installPath.Size = new System.Drawing.Size(408, 23);
            this.installPath.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Installation path:";
            // 
            // folderIcon
            // 
            this.folderIcon.BackColor = System.Drawing.SystemColors.Control;
            this.folderIcon.BackgroundImage = global::iQScript_Configurator.Resources.folder;
            this.folderIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.folderIcon.Image = global::iQScript_Configurator.Resources.folder;
            this.folderIcon.Location = new System.Drawing.Point(12, 391);
            this.folderIcon.Name = "folderIcon";
            this.folderIcon.Size = new System.Drawing.Size(25, 23);
            this.folderIcon.TabIndex = 21;
            this.folderIcon.TabStop = false;
            // 
            // Uninst
            // 
            this.Uninst.Location = new System.Drawing.Point(268, 464);
            this.Uninst.Name = "Uninst";
            this.Uninst.Size = new System.Drawing.Size(122, 41);
            this.Uninst.TabIndex = 25;
            this.Uninst.Text = "Uninstall";
            this.Uninst.UseVisualStyleBackColor = true;
            this.Uninst.Click += new System.EventHandler(this.UninstButton_Click);
            // 
            // StartupChk
            // 
            this.StartupChk.AutoSize = true;
            this.StartupChk.Location = new System.Drawing.Point(378, 112);
            this.StartupChk.Name = "StartupChk";
            this.StartupChk.Size = new System.Drawing.Size(103, 19);
            this.StartupChk.TabIndex = 26;
            this.StartupChk.Text = "Add to Startup";
            this.StartupChk.UseVisualStyleBackColor = true;
            this.StartupChk.CheckedChanged += new System.EventHandler(this.StartupChk_CheckedChanged);
            // 
            // StartMenuChk
            // 
            this.StartMenuChk.AutoSize = true;
            this.StartMenuChk.Location = new System.Drawing.Point(378, 137);
            this.StartMenuChk.Name = "StartMenuChk";
            this.StartMenuChk.Size = new System.Drawing.Size(123, 19);
            this.StartMenuChk.TabIndex = 27;
            this.StartMenuChk.Text = "Add to Start Menu";
            this.StartMenuChk.UseVisualStyleBackColor = true;
            this.StartMenuChk.CheckedChanged += new System.EventHandler(this.StartMenuChk_CheckedChanged);
            // 
            // DesktopChk
            // 
            this.DesktopChk.AutoSize = true;
            this.DesktopChk.Location = new System.Drawing.Point(378, 162);
            this.DesktopChk.Name = "DesktopChk";
            this.DesktopChk.Size = new System.Drawing.Size(108, 19);
            this.DesktopChk.TabIndex = 28;
            this.DesktopChk.Text = "Add to Desktop";
            this.DesktopChk.UseVisualStyleBackColor = true;
            this.DesktopChk.CheckedChanged += new System.EventHandler(this.DesktopChk_CheckedChanged);
            // 
            // SaveRunButton
            // 
            this.SaveRunButton.Location = new System.Drawing.Point(12, 464);
            this.SaveRunButton.Name = "SaveRunButton";
            this.SaveRunButton.Size = new System.Drawing.Size(122, 41);
            this.SaveRunButton.TabIndex = 29;
            this.SaveRunButton.Text = "Save And Run";
            this.SaveRunButton.UseVisualStyleBackColor = true;
            this.SaveRunButton.Click += new System.EventHandler(this.SaveRunButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 44);
            this.button2.TabIndex = 30;
            this.button2.Text = "Install AutoHotkey (Required)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.installAHKButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 517);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SaveRunButton);
            this.Controls.Add(this.DesktopChk);
            this.Controls.Add(this.StartMenuChk);
            this.Controls.Add(this.StartupChk);
            this.Controls.Add(this.Uninst);
            this.Controls.Add(this.folderIcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.installPath);
            this.Controls.Add(this.CheckAll);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.SemiColonArrowSimChk);
            this.Controls.Add(this.NumPadHomerowFloatChk);
            this.Controls.Add(this.CapsLockFloatChk);
            this.Controls.Add(this.AltScrollHorizontalScrollChk);
            this.Controls.Add(this.LWinPowerToysChk);
            this.Controls.Add(this.AltSScreenshotChk);
            this.Controls.Add(this.AltANotificationPanelChk);
            this.Controls.Add(this.AltEExplorerChk);
            this.Controls.Add(this.Alt0EndChk);
            this.Controls.Add(this.Alt9HomeChk);
            this.Controls.Add(this.Alt8DelChk);
            this.Controls.Add(this.AltWMinimizeChk);
            this.Controls.Add(this.AltQCloseChk);
            this.Controls.Add(this.MandatoryChk);
            this.Controls.Add(this.SaveButton);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iQConfig";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox MandatoryChk;
        private System.Windows.Forms.CheckBox AltQCloseChk;
        private System.Windows.Forms.CheckBox AltWMinimizeChk;
        private System.Windows.Forms.CheckBox Alt8DelChk;
        private System.Windows.Forms.CheckBox Alt9HomeChk;
        private System.Windows.Forms.CheckBox Alt0EndChk;
        private System.Windows.Forms.CheckBox AltEExplorerChk;
        private System.Windows.Forms.CheckBox AltANotificationPanelChk;
        private System.Windows.Forms.CheckBox AltSScreenshotChk;
        private System.Windows.Forms.CheckBox LWinPowerToysChk;
        private System.Windows.Forms.CheckBox AltScrollHorizontalScrollChk;
        private System.Windows.Forms.CheckBox CapsLockFloatChk;
        private System.Windows.Forms.CheckBox NumPadHomerowFloatChk;
        private System.Windows.Forms.CheckBox SemiColonArrowSimChk;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.CheckBox CheckAll;
        private System.Windows.Forms.TextBox installPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox folderIcon;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button Uninst;
        private System.Windows.Forms.CheckBox StartupChk;
        private System.Windows.Forms.CheckBox StartMenuChk;
        private System.Windows.Forms.CheckBox DesktopChk;
        private System.Windows.Forms.Button SaveRunButton;
        private System.Windows.Forms.Button button2;
    }
}

