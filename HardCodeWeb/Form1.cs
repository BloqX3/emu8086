using CefSharp;
using CefSharp.Internals;
using CefSharp.WinForms;
using DarkUI.Forms;
using HardCode;
using HardCode.Core;
using HardCode.Core.Engine;
using HardCode.Dialogs;

namespace HardCodeWeb {
    public partial class Form1 : DarkForm {
        public string code = "";
        Context Engine;

        public Form1() {
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
            InitializeComponent();
            CefSettings cefSettings = new CefSettings();
            String page = string.Format(@"{0}\UI\index.html", Application.StartupPath);
            if (!File.Exists(page)) {
                throw new Exception("Error loading the UI");
            }

            WebUI.LoadUrl(page);
            WebUI.FrameLoadEnd += WebUI_FrameLoadEnd;
            WebUI.ConsoleMessage += (s, e) => {
                string flag = "CODE_FLAG";
                if (e.Message.Substring(0, flag.Length) == flag)
                    //MessageBox.Show($"{e.Message.Substring(flag.Length)}");
                    code = e.Message.Substring(flag.Length);
            };


        }

        private void WebUI_FrameLoadEnd(object? sender, FrameLoadEndEventArgs e) {
            this.Invoke(new Action(() => {
                ShowInTaskbar = true;
                WindowState = FormWindowState.Normal;
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            Cef.Shutdown();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void run_Click(object sender, EventArgs e) {
            Engine = new Context();
            Engine.Run(code);

        }

        private void ShowRegisterButton_Click(object sender, EventArgs e) {
            List<string> items = new List<string>();
            int i = 0;
            foreach (var key in Storage.RegistersIdicies.Keys)
                items.Add(key + ": " + Engine.storage.Registers[i++]);
            new StackForm("Register Info", items).ShowDialog();

        }

        private void ShowStackButton_Click(object sender, EventArgs e) {
            List<string> items = new List<string>();
            foreach (var item in Engine.storage.Pool)
                items.Add(item.ToString());
            new StackForm("Stack Memory", items).ShowDialog();

        }
    }
}