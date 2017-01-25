using System;
using System.Windows.Forms;
using OfflineARM.Gui;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginForm = new LoginForm {ShowInTaskbar = false};
            if (loginForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Application.Run(new MainForm());
        }
    }
}
