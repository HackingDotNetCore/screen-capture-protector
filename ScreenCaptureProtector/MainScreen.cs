using System;
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
            return form != null && isProtect == true ? SetWindowDisplayAffinity(form.Handle, WDA_MONITOR) == WDA_MONITOR : SetWindowDisplayAffinity(form.Handle, WDA_NONE) == WDA_NONE;
        }

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            bool result = SetProtect(this, true);
            Text = $"Screen Capture Protector // Protection: {result}";
        }
    }
}
