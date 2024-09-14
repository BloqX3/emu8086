using DarkUI.Controls;
using DarkUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardCode.Dialogs {
    public partial class StackForm : DarkForm {
        public StackForm(string title, List<string> items) {
            InitializeComponent();
            this.Text = title;
            foreach(string item in items) {
                darkListView1.Items.Add(new DarkListItem(item));
            }
            
        }
    }
}
