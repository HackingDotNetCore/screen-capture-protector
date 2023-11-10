using System;
using System.Windows.Forms;
using ScreenCaptureProtector.Utilities;
using ScreenCaptureProtector.Utilities.Helpers;

namespace ScreenCaptureProtector
{
    public partial class MainScreen : Form
    {
        private readonly IProtectorHelper _protectorHelper;

        public MainScreen(IProtectorHelper protectorHelper)
        {
            InitializeComponent();
            _protectorHelper = protectorHelper;
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            stripMnItmShowHideButton.Text = @"Show";
            Hide();
        }

        private void btnProtect_Click(object sender, EventArgs e)
        {
            if (btnProtect.Text == @"Start Protect")
            {
                if (string.IsNullOrEmpty(txtBxProcessName.Text))
                    _protectorHelper.StartWithProcess(this, txtBxProcessName.Text);
                else
                    _protectorHelper.Start(this);

                btnProtect.Text = @"Stop Protect";
            }
            else
            {
                btnProtect.Text = @"Start Protect";
                _protectorHelper.Stop(this);
            }
        }

        private void chckBxProcessName_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxProcessName.Checked)
            {
                txtBxProcessName.Enabled = true;
                txtBxProcessName.Text = string.Empty;
            }
            else
            {
                txtBxProcessName.Enabled = false;
                txtBxProcessName.Text = string.Empty;
            }
        }

        private void ntfyScreenCaptureProtector_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void stripMnItmShowHideButton_Click(object sender, EventArgs e)
        {
            if (stripMnItmShowHideButton.Text == @"Show")
            {
                stripMnItmShowHideButton.Text = @"Hide";
                Show();
            }
            else
            {
                stripMnItmShowHideButton.Text = @"Show";
                Hide();
            }
        }
    }
}