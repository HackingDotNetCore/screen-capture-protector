# Screen Capture Protector 

Microsoft has been developed an API named [**SetWindowDisplayAffinity**](https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-setwindowdisplayaffinity?redirectedfrom=MSDN) to support the window content protection. This feature enables applications to protect application content from being captured or copied through a specific set of public operating system features and APIs. 

Unlike other security features or an implementation of DRM there is no guarantee that this API can strictly protect window content, for example where someone takes a photograph of screen using mobile camera. But this API is feasible and easy to use.

## Usage/Examples

There are two types of DWORD values **WDA_MONITOR** and **WDA_NONE**. We have to set **WDA_MONITOR** to protect the application contents.

```cs
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
```

## Feedback

If you have any feedback, please reach out to us at akin.bicer@outlook.com.tr