namespace HardCodeWeb {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            panel1 = new Panel();
            ShowStackButton = new DarkUI.Controls.DarkButton();
            ShowRegisterButton = new DarkUI.Controls.DarkButton();
            runClick = new DarkUI.Controls.DarkButton();
            WebUI = new CefSharp.WinForms.ChromiumWebBrowser();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ShowStackButton);
            panel1.Controls.Add(ShowRegisterButton);
            panel1.Controls.Add(runClick);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 36);
            panel1.TabIndex = 12;
            // 
            // ShowStackButton
            // 
            ShowStackButton.Location = new Point(236, 4);
            ShowStackButton.Name = "ShowStackButton";
            ShowStackButton.Padding = new Padding(5);
            ShowStackButton.Size = new Size(97, 29);
            ShowStackButton.TabIndex = 10;
            ShowStackButton.Text = "Show Stack";
            ShowStackButton.Click += ShowStackButton_Click;
            // 
            // ShowRegisterButton
            // 
            ShowRegisterButton.Location = new Point(114, 4);
            ShowRegisterButton.Name = "ShowRegisterButton";
            ShowRegisterButton.Padding = new Padding(5);
            ShowRegisterButton.Size = new Size(116, 29);
            ShowRegisterButton.TabIndex = 9;
            ShowRegisterButton.Text = "Show Register";
            ShowRegisterButton.Click += ShowRegisterButton_Click;
            // 
            // runClick
            // 
            runClick.Location = new Point(11, 4);
            runClick.Name = "runClick";
            runClick.Padding = new Padding(5);
            runClick.Size = new Size(97, 29);
            runClick.TabIndex = 8;
            runClick.Text = "Run";
            runClick.Click += run_Click;
            // 
            // WebUI
            // 
            WebUI.ActivateBrowserOnCreation = false;
            WebUI.Dock = DockStyle.Fill;
            WebUI.Location = new Point(0, 36);
            WebUI.Name = "WebUI";
            WebUI.Size = new Size(1070, 512);
            WebUI.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 548);
            Controls.Add(WebUI);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HardCode";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DarkUI.Controls.DarkButton ShowStackButton;
        private DarkUI.Controls.DarkButton ShowRegisterButton;
        private DarkUI.Controls.DarkButton runClick;
        private CefSharp.WinForms.ChromiumWebBrowser WebUI;
    }
}