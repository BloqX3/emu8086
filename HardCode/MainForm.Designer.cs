namespace HardCode {
    partial class MainForm {
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            panel1 = new Panel();
            ShowStackButton = new DarkUI.Controls.DarkButton();
            ShowRegisterButton = new DarkUI.Controls.DarkButton();
            darkButton1 = new DarkUI.Controls.DarkButton();
            CodeBox = new FastColoredTextBoxNS.FastColoredTextBox();
            darkSectionPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CodeBox).BeginInit();
            SuspendLayout();
            // 
            // darkSectionPanel1
            // 
            darkSectionPanel1.Controls.Add(panel1);
            darkSectionPanel1.Controls.Add(CodeBox);
            darkSectionPanel1.Dock = DockStyle.Fill;
            darkSectionPanel1.Location = new Point(0, 0);
            darkSectionPanel1.Name = "darkSectionPanel1";
            darkSectionPanel1.SectionHeader = null;
            darkSectionPanel1.Size = new Size(888, 452);
            darkSectionPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(ShowStackButton);
            panel1.Controls.Add(ShowRegisterButton);
            panel1.Controls.Add(darkButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(1, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(886, 36);
            panel1.TabIndex = 9;
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
            // darkButton1
            // 
            darkButton1.Location = new Point(11, 4);
            darkButton1.Name = "darkButton1";
            darkButton1.Padding = new Padding(5);
            darkButton1.Size = new Size(97, 29);
            darkButton1.TabIndex = 8;
            darkButton1.Text = "Run";
            darkButton1.Click += darkButton1_Click;
            // 
            // CodeBox
            // 
            CodeBox.AutoCompleteBracketsList = new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };
            CodeBox.AutoIndentCharsPatterns = "";
            CodeBox.AutoScrollMinSize = new Size(31, 18);
            CodeBox.BackBrush = null;
            CodeBox.BackColor = Color.FromArgb(200, 200, 200);
            CodeBox.CharHeight = 18;
            CodeBox.CharWidth = 10;
            CodeBox.CommentPrefix = "#";
            CodeBox.Cursor = Cursors.IBeam;
            //CodeBox.DisabledColor = Color.FromArgb(150, 230, 230, 230);
            CodeBox.Dock = DockStyle.Bottom;
            CodeBox.ForeColor = Color.FromArgb(40, 40, 40);
            CodeBox.IndentBackColor = Color.FromArgb(60, 63, 65);
            CodeBox.IsReplaceMode = false;
            CodeBox.Language = FastColoredTextBoxNS.Language.JSON;
            CodeBox.LeftBracket = '(';
            CodeBox.LineNumberColor = Color.Gainsboro;
            CodeBox.Location = new Point(1, 63);
            CodeBox.Name = "CodeBox";
            CodeBox.Paddings = new Padding(0);
            CodeBox.RightBracket = ')';
            CodeBox.SelectionColor = Color.FromArgb(100, 129, 136, 148);
            CodeBox.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("CodeBox.ServiceColors");
            CodeBox.ServiceLinesColor = Color.FromArgb(230, 230, 230);
            CodeBox.Size = new Size(886, 388);
            CodeBox.TabIndex = 7;
            CodeBox.TextAreaBorderColor = Color.Gainsboro;
            CodeBox.Zoom = 100;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 452);
            Controls.Add(darkSectionPanel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HardCode";
            darkSectionPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CodeBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private FastColoredTextBoxNS.FastColoredTextBox CodeBox;
        private DarkUI.Controls.DarkButton darkButton1;
        private Panel panel1;
        private DarkUI.Controls.DarkButton ShowStackButton;
        private DarkUI.Controls.DarkButton ShowRegisterButton;
    }
}