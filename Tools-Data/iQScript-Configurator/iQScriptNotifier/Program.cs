using System;
using System.Diagnostics;
using System.Threading;

using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications;

namespace iQScriptNotifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started");

            #region OnLoad Checks
            if (ToastNotificationManagerCompat.WasCurrentProcessToastActivated())
                Environment.Exit(0);

            if (args.Length == 0)
                Environment.Exit(0);
            #endregion

            #region Generating Message
            string message = "";
            switch (args[0])
            {
                case Arguments.On:
                    message = Messages.On;
                    break;
                case Arguments.Off:
                    message = Messages.Off;
                    break;
                case Arguments.Update:
                    message = Messages.UpdateAvailable;
                    break;
                case Arguments.Uninstall:
                    ToastNotificationManagerCompat.Uninstall();
                    Environment.Exit(-1);
                    return; //compiler ne prepoznaje gornju liniju kao izlazecu tkd mora i ovo
                default:
                    message = Messages.Error;
                    break;
            }
            #endregion

            #region Check History
            var history = ToastNotificationManagerCompat.History.GetHistory();
            Console.WriteLine("History Count: " + history.Count);
            if (history.Count > 0)
                ToastNotificationManagerCompat.History.Clear();
            #endregion

            #region Create Button
            IToastButton button = new ToastButton()
                .SetContent("Ok")
                .AddArgument(Arguments.Ok);

            if (message == Messages.UpdateAvailable)
                button = new ToastButton().SetContent("Update")
                    .AddArgument("update");
            #endregion

            #region Create Notification
            var xml = new ToastContentBuilder()
                .AddArgument(Arguments.Dismiss)
                .AddText(message)
                .AddButton(button)
                .SetToastDuration(ToastDuration.Short)
                .GetXml();

            ToastNotification notification = new ToastNotification(xml);
            notification.Tag = "iQScriptNotification";
            notification.Group = "iQGroup";
            notification.ExpirationTime = DateTime.Now.AddSeconds(5);
            #endregion

            #region Show & Attach Event
            ToastNotificationManagerCompat.CreateToastNotifier().Show(notification);
            ToastNotificationManagerCompat.OnActivated += toastArgs =>
            {
                CheckInput(toastArgs);
            };
            #endregion

            #region God forbid
            Thread.Sleep(5000);
            Console.ReadLine();
            #endregion

            Console.WriteLine("Exiting...");
            ToastNotificationManagerCompat.History.Clear();
            Environment.Exit(0);
        }

        private static void CheckInput(ToastNotificationActivatedEventArgsCompat args)
        {
            Console.WriteLine("Event invoked!");
            if (args.Argument.Contains("update"))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.github.com/iQuerz/iQScript#readme",
                    UseShellExecute = true,
                });
            }
            ToastNotificationManagerCompat.History.Clear();
            Environment.Exit(1);
        }
    }
}
