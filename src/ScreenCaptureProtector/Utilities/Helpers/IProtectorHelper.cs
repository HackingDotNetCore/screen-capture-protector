using System.Windows.Forms;

namespace ScreenCaptureProtector.Utilities.Helpers
{
    public interface IProtectorHelper
    {
        bool Start(Form form);
        bool StartWithProcess(Form form, string processName);
        bool Stop(Form form);
    }
}