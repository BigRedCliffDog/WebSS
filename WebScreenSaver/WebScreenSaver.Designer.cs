namespace WebScreenSaver
{
    partial class WebScreenSaver
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
            this.WB = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WB
            // 
            this.WB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WB.Location = new System.Drawing.Point(0, 0);
            this.WB.MinimumSize = new System.Drawing.Size(20, 20);
            this.WB.Name = "WB";
            this.WB.ScriptErrorsSuppressed = true;
            this.WB.ScrollBarsEnabled = false;
            this.WB.Size = new System.Drawing.Size(284, 262);
            this.WB.TabIndex = 0;
            this.WB.Url = new System.Uri("http://sunpeaksresort.com/tv", System.UriKind.Absolute);
            // 
            // WebScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.WB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WebScreenSaver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.WebScreenSaver_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WebScreenSaver_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WebScreenSaver_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WebScreenSaver_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WB;
    }
}

