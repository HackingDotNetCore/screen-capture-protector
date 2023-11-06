using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ScreenCaptureProtector
{
    public partial class MainScreen : Form
    {
        private const uint WDA_NONE = 0x00000000;
        private const uint WDA_MONITOR = 0x00000001;

        [DllImport("user32.dll")]
        public static extern uint SetWindowDisplayAffinity(IntPtr hWnd, uint dwAffinity);

        public static bool SetProtect(Form form, bool isProtect)
        {
            return form != null && isProtect ? SetWindowDisplayAffinity(form.Handle, WDA_MONITOR) == WDA_MONITOR : SetWindowDisplayAffinity(form.Handle, WDA_NONE) == WDA_NONE;
        }
        
        public static bool SetProtect(string process, Form form, bool isProtect)
        {
            var processes = Process.GetProcessesByName(process);
            
            if (!processes.Any()) 
                MessageBox.Show($"It has been determined that the specified application is not currently working. Please make sure it is working.\n\nApplication Name: {process}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            return form != null && isProtect ? SetWindowDisplayAffinity(form.Handle, WDA_MONITOR) == WDA_MONITOR : SetWindowDisplayAffinity(form.Handle, WDA_NONE) == WDA_NONE;
        }
        
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            //var result = SetProtect("chrome.exe", this, true);
            var result = SetProtect(this, true);
            
            Text = $"Screen Capture Protector // Protection: {result}";
        }
    }
}