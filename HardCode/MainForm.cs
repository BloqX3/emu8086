using DarkUI.Forms;
using HardCode.Core;
using HardCode.Core.Engine;
using HardCode.Dialogs;

namespace HardCode {
    public partial class MainForm : DarkForm {

        Context Engine;
        public MainForm() {
            InitializeComponent();
            Engine = new Context();
        }

        private void darkButton1_Click(object sender, EventArgs e) {
            Engine = new Context();
            Engine.Run(CodeBox.Text);
        }

        private void ShowRegisterButton_Click(object sender, EventArgs e) {
            List<string> items= new List<string>();
            int i = 0;
            foreach(var key in Storage.RegistersIdicies.Keys) 
                items.Add(key + ": " + Engine.storage.Registers[i++]);
            new StackForm("Register Info",items).ShowDialog();
        }
        private void ShowStackButton_Click(object sender, EventArgs e) {
            List<string> items = new List<string>();
            foreach (var item in Engine.storage.Pool)
                items.Add(item.ToString());
            new StackForm("Stack Memory", items).ShowDialog();

        }
    }
}