using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ScreenCaptureProtector.Utilities.Helpers
{
    public class ProtectorHelper : IProtectorHelper
    {
        private const uint WDA_NONE = 0x00000000;
        private const uint WDA_MONITOR = 0x00000001;

        public bool Start(Form form)
        {
            if (form == null)
                throw new ArgumentNullException(nameof(form));

            try
            {
                SetWindowDisplayAffinity(form.Handle, WDA_MONITOR);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool StartWithProcess(Form form, string processName)
        {
            if (form == null)
                throw new ArgumentNullException(nameof(form));
            if (processName == null)
                throw new ArgumentNullException(nameof(processName));

            try
            {
                var processes = Process.GetProcessesByName(processName);

                if (processes != null)
                    SetWindowDisplayAffinity(form.Handle, WDA_MONITOR);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Stop(Form form)
        {
            try
            {
                SetWindowDisplayAffinity(form.Handle, WDA_NONE);
                return true;
            }
            catch
            {
                return false;
            }
        }

        [DllImport("user32.dll")]
        public static extern uint SetWindowDisplayAffinity(IntPtr hWnd, uint dwAffinity);
    }
}