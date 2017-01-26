using System;
using System.Windows.Forms;
using OfflineARM.Gui;
using OfflineARM.Business;
using OfflineARM.Business.Loggers;

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
                starter.Start(null);

                var loginForm = new LoginForm();
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                Application.Run(new MainForm());
            }
            catch(Exception e)
            {
                Logger.Error(e.Message);
                Logger.Error(e.StackTrace);
            }
        }
    }
}
