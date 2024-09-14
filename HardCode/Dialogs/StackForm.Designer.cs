namespace HardCode.Dialogs {
    partial class StackForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            darkListView1 = new DarkUI.Controls.DarkListView();
            SuspendLayout();
            // 
            // darkListView1
            // 
            darkListView1.Dock = DockStyle.Fill;
            darkListView1.Location = new Point(0, 0);
            darkListView1.Name = "darkListView1";
            darkListView1.Size = new Size(530, 450);
            darkListView1.TabIndex = 0;
            darkListView1.Text = "darkListView1";
            // 
            // Stack
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 450);
            Controls.Add(darkListView1);
            Name = "Stack";
            Text = "Stack";
            ResumeLayout(false);
        }

        #endregion

        private DarkUI.Controls.DarkListView darkListView1;
    }
}