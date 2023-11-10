namespace ScreenCaptureProtector
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.ntfyScreenCaptureProtector = new System.Windows.Forms.NotifyIcon(this.components);
            this.cntxtMnScreenCaptureProtector = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stripMnItmShowHideButton = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProtect = new System.Windows.Forms.Button();
            this.txtBxProcessName = new System.Windows.Forms.TextBox();
            this.chckBxProcessName = new System.Windows.Forms.CheckBox();
            this.cntxtMnScreenCaptureProtector.SuspendLayout();
            this.SuspendLayout();
            // 
            // ntfyScreenCaptureProtector
            // 
            this.ntfyScreenCaptureProtector.ContextMenuStrip = this.cntxtMnScreenCaptureProtector;
            this.ntfyScreenCaptureProtector.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfyScreenCaptureProtector.Icon")));
            this.ntfyScreenCaptureProtector.Text = "Screen Capture Protector";
            this.ntfyScreenCaptureProtector.Visible = true;
            this.ntfyScreenCaptureProtector.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfyScreenCaptureProtector_MouseDoubleClick);
            // 
            // cntxtMnScreenCaptureProtector
            // 
            this.cntxtMnScreenCaptureProtector.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMnItmShowHideButton});
            this.cntxtMnScreenCaptureProtector.Name = "cntxtMnScreenCaptureProtector";
            this.cntxtMnScreenCaptureProtector.Size = new System.Drawing.Size(100, 26);
            // 
            // stripMnItmShowHideButton
            // 
            this.stripMnItmShowHideButton.Name = "stripMnItmShowHideButton";
            this.stripMnItmShowHideButton.Size = new System.Drawing.Size(99, 22);
            this.stripMnItmShowHideButton.Text = "Hide";
            this.stripMnItmShowHideButton.Click += new System.EventHandler(this.stripMnItmShowHideButton_Click);
            // 
            // btnProtect
            // 
            this.btnProtect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProtect.Location = new System.Drawing.Point(12, 72);
            this.btnProtect.Name = "btnProtect";
            this.btnProtect.Size = new System.Drawing.Size(289, 49);
            this.btnProtect.TabIndex = 1;
            this.btnProtect.Text = "Start Protect";
            this.btnProtect.UseVisualStyleBackColor = true;
            this.btnProtect.Click += new System.EventHandler(this.btnProtect_Click);
            // 
            // txtBxProcessName
            // 
            this.txtBxProcessName.Enabled = false;
            this.txtBxProcessName.Location = new System.Drawing.Point(140, 30);
            this.txtBxProcessName.Name = "txtBxProcessName";
            this.txtBxProcessName.Size = new System.Drawing.Size(137, 20);
            this.txtBxProcessName.TabIndex = 3;
            // 
            // chckBxProcessName
            // 
            this.chckBxProcessName.AutoSize = true;
            this.chckBxProcessName.Location = new System.Drawing.Point(36, 32);
            this.chckBxProcessName.Name = "chckBxProcessName";
            this.chckBxProcessName.Size = new System.Drawing.Size(98, 17);
            this.chckBxProcessName.TabIndex = 4;
            this.chckBxProcessName.Text = "Process Name:";
            this.chckBxProcessName.UseVisualStyleBackColor = true;
            this.chckBxProcessName.CheckedChanged += new System.EventHandler(this.chckBxProcessName_CheckedChanged);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 133);
            this.Controls.Add(this.chckBxProcessName);
            this.Controls.Add(this.txtBxProcessName);
            this.Controls.Add(this.btnProtect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen Capture Protector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.cntxtMnScreenCaptureProtector.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ntfyScreenCaptureProtector;
        private System.Windows.Forms.ContextMenuStrip cntxtMnScreenCaptureProtector;
        private System.Windows.Forms.ToolStripMenuItem stripMnItmShowHideButton;
        private System.Windows.Forms.Button btnProtect;
        private System.Windows.Forms.TextBox txtBxProcessName;
        private System.Windows.Forms.CheckBox chckBxProcessName;
    }
}

