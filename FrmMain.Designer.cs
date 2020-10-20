namespace HotKeyApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tbarBrightness = new System.Windows.Forms.TrackBar();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbarBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // tbarBrightness
            // 
            this.tbarBrightness.AutoSize = false;
            this.tbarBrightness.BackColor = System.Drawing.Color.Gainsboro;
            this.tbarBrightness.Location = new System.Drawing.Point(55, 12);
            this.tbarBrightness.Maximum = 100;
            this.tbarBrightness.Name = "tbarBrightness";
            this.tbarBrightness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarBrightness.Size = new System.Drawing.Size(21, 129);
            this.tbarBrightness.TabIndex = 0;
            this.tbarBrightness.TickFrequency = 0;
            this.tbarBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbarBrightness.ValueChanged += new System.EventHandler(this.tbarBrightness_ValueChanged);
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.BackColor = System.Drawing.Color.Gainsboro;
            this.lblBrightness.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrightness.ForeColor = System.Drawing.Color.Black;
            this.lblBrightness.Location = new System.Drawing.Point(56, 147);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(18, 18);
            this.lblBrightness.TabIndex = 2;
            this.lblBrightness.Text = "0";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Contact: rodavid20@yahoo.co.in";
            this.notifyIcon.BalloonTipTitle = "HotKey App";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "HotKey by rodavid20";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(128, 175);
            this.ControlBox = false;
            this.Controls.Add(this.lblBrightness);
            this.Controls.Add(this.tbarBrightness);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowInTaskbar = false;
            this.Text = "HotKey Application";
            this.TopMost = true;
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tbarBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbarBrightness;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer timer;
    }
}