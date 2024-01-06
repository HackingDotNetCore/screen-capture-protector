using System;
using System.Windows.Forms;
using ScreenCaptureProtector.Utilities.DependencyInjection;
using ScreenCaptureProtector.Utilities.Helpers;

namespace ScreenCaptureProtector
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            var container = new DependencyInjectionContainer();
            container.Register<IProtectorHelper>(new ProtectorHelper());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen(container.Resolve<IProtectorHelper>()));
        }
    }
}