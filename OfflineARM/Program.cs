using System;
using System.Windows.Forms;
using OfflineARM.Business;
using OfflineARM.Gui;
using OfflineARM.Business.Loggers;
using OfflineARM.Gui.Interfaces.Windows;

namespace OfflineARM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var starter = new Starter();
                starter.Start();

                var loginForm = IoCForm.Instance.Resolve<ILoginForm>();
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                InitDatabaseFull.Init();

                var mainForm = IoCForm.Instance.ResolveForm<IMainForm>();
                Application.Run(mainForm);
            }
            catch(Exception e)
            {
                Logger.Error(e.Message);
                Logger.Error(e.StackTrace);

                throw;
            }
        }
    }
}
