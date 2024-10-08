﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using System.Diagnostics;
using HardCodeWeb;

namespace HardCode {
    class CefCustomObject {
        // Declare a local instance of chromium and the main form in order to execute things from here in the main thread
        private static ChromiumWebBrowser _instanceBrowser = null;
        // The form class needs to be changed according to yours
        private static Form1 _instanceMainForm = null;


        public CefCustomObject(ChromiumWebBrowser originalBrowser, Form1 mainForm) {
            _instanceBrowser = originalBrowser;
            _instanceMainForm = mainForm;
        }

        public void showDevTools() {
            _instanceBrowser.ShowDevTools();
        }

        public void test() {
            MessageBox.Show("nono el n3al");
        }
    }
}