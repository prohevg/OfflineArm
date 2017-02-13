using System;
using System.Windows.Forms;
using OfflineARM.Controller;
using OfflineARM.Controller.Loggers;
using OfflineARM.Controller.ViewInterfaces;
using OfflineARM.View;

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
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var starter = new Starter();
                starter.Start();

                var autorizationView = IoCView.Instance.Resolve<IAutorizationView>();
                autorizationView.Controller.LoadView();
                if (!autorizationView.ShowDialog())
                {
                    return;
                }

                InitDatabaseFull.Init();

                var mainView = IoCView.Instance.Resolve<IMainView>();
                mainView.Controller.LoadView();
                Application.Run(mainView as Form);
            }
            catch(Exception e)
            {
                Logger.Error(e.Message);
                Logger.Error(e.StackTrace);
            }
        }

        /// <summary>
        /// Ообработчка ошибок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var exp = e.ExceptionObject as Exception;
            if (exp != null)
            {
                Logger.Error(exp.Message);
                Logger.Error(exp.StackTrace);
            }
        }
    }
}
