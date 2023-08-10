namespace AutoClicker.Windows
{
    partial class MainWindow : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.DelayLabel = new System.Windows.Forms.Label();
            this.DelayTextBox = new System.Windows.Forms.TextBox();
            this.AmountClicksLablel = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.InfinityCheckBox = new System.Windows.Forms.CheckBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.KeyWillPressLabel = new System.Windows.Forms.Label();
            this.KeyWillPressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.HintTextBox = new System.Windows.Forms.TextBox();
            this.LinkLabelRepo = new System.Windows.Forms.LinkLabel();
            this.CreatorLinkLable = new System.Windows.Forms.LinkLabel();
            this.LinkLabelGitHub = new System.Windows.Forms.Label();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DelayLabel
            // 
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelayLabel.Location = new System.Drawing.Point(78, 191);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(123, 30);
            this.DelayLabel.TabIndex = 0;
            this.DelayLabel.Text = "Delay (ms):";
            // 
            // DelayTextBox
            // 
            this.DelayTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelayTextBox.Location = new System.Drawing.Point(270, 188);
            this.DelayTextBox.Name = "DelayTextBox";
            this.DelayTextBox.Size = new System.Drawing.Size(139, 35);
            this.DelayTextBox.TabIndex = 3;
            this.DelayTextBox.TabStop = false;
            this.DelayTextBox.TextChanged += new System.EventHandler(this.OnlyNumber_TextChange);
            // 
            // AmountClicksLablel
            // 
            this.AmountClicksLablel.AutoSize = true;
            this.AmountClicksLablel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountClicksLablel.Location = new System.Drawing.Point(78, 155);
            this.AmountClicksLablel.Name = "AmountClicksLablel";
            this.AmountClicksLablel.Size = new System.Drawing.Size(186, 30);
            this.AmountClicksLablel.TabIndex = 2;
            this.AmountClicksLablel.Text = "Amount of clicks:";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountTextBox.Location = new System.Drawing.Point(270, 150);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(139, 35);
            this.AmountTextBox.TabIndex = 1;
            this.AmountTextBox.TabStop = false;
            this.AmountTextBox.TextChanged += new System.EventHandler(this.OnlyNumber_TextChange);
            // 
            // InfinityCheckBox
            // 
            this.InfinityCheckBox.AutoSize = true;
            this.InfinityCheckBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InfinityCheckBox.Location = new System.Drawing.Point(270, 130);
            this.InfinityCheckBox.Name = "InfinityCheckBox";
            this.InfinityCheckBox.Size = new System.Drawing.Size(15, 14);
            this.InfinityCheckBox.TabIndex = 2;
            this.InfinityCheckBox.TabStop = false;
            this.InfinityCheckBox.UseVisualStyleBackColor = true;
            this.InfinityCheckBox.CheckedChanged += new System.EventHandler(this.InfinityCheckBox_CheckedChanged);
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KeyLabel.Location = new System.Drawing.Point(456, 135);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(103, 30);
            this.KeyLabel.TabIndex = 5;
            this.KeyLabel.Text = "Start-Key";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.KeyTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KeyTextBox.Location = new System.Drawing.Point(577, 135);
            this.KeyTextBox.MaxLength = 1;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.ReadOnly = true;
            this.KeyTextBox.ShortcutsEnabled = false;
            this.KeyTextBox.Size = new System.Drawing.Size(147, 35);
            this.KeyTextBox.TabIndex = 4;
            this.KeyTextBox.TabStop = false;
            this.KeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyTextBox.WordWrap = false;
            this.KeyTextBox.Click += new System.EventHandler(this.SelectAllTextBox);
            this.KeyTextBox.TextChanged += new System.EventHandler(this.SelectAllTextBox);
            this.KeyTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyTextBox_KeyUp);
            this.KeyTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KeyTextBox_MouseUp);
            // 
            // KeyWillPressLabel
            // 
            this.KeyWillPressLabel.AutoSize = true;
            this.KeyWillPressLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KeyWillPressLabel.Location = new System.Drawing.Point(456, 180);
            this.KeyWillPressLabel.Name = "KeyWillPressLabel";
            this.KeyWillPressLabel.Size = new System.Drawing.Size(117, 30);
            this.KeyWillPressLabel.TabIndex = 7;
            this.KeyWillPressLabel.Text = "Target-Key";
            // 
            // KeyWillPressTextBox
            // 
            this.KeyWillPressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.KeyWillPressTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KeyWillPressTextBox.Location = new System.Drawing.Point(577, 180);
            this.KeyWillPressTextBox.MaxLength = 1;
            this.KeyWillPressTextBox.Name = "KeyWillPressTextBox";
            this.KeyWillPressTextBox.ReadOnly = true;
            this.KeyWillPressTextBox.Size = new System.Drawing.Size(147, 35);
            this.KeyWillPressTextBox.TabIndex = 5;
            this.KeyWillPressTextBox.TabStop = false;
            this.KeyWillPressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyWillPressTextBox.Click += new System.EventHandler(this.SelectAllTextBox);
            this.KeyWillPressTextBox.TextChanged += new System.EventHandler(this.SelectAllTextBox);
            this.KeyWillPressTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyWillBePressTextBox_KeyUp);
            this.KeyWillPressTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KeyWillBePressTextBox_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Endless mode:";
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 398);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(800, 52);
            this.StatusBar.TabIndex = 9;
            // 
            // StatusBarLabel
            // 
            this.StatusBarLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusBarLabel.Name = "StatusBarLabel";
            this.StatusBarLabel.Size = new System.Drawing.Size(322, 47);
            this.StatusBarLabel.Text = "Waiting for start...";
            // 
            // HintTextBox
            // 
            this.HintTextBox.Enabled = false;
            this.HintTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HintTextBox.Location = new System.Drawing.Point(355, 251);
            this.HintTextBox.Multiline = true;
            this.HintTextBox.Name = "HintTextBox";
            this.HintTextBox.Size = new System.Drawing.Size(149, 131);
            this.HintTextBox.TabIndex = 10;
            this.HintTextBox.Text = "To stop\r\njust press\r\n\"Target-Key\"\r\n    Again!";
            this.HintTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LinkLabelRepo
            // 
            this.LinkLabelRepo.AutoSize = true;
            this.LinkLabelRepo.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LinkLabelRepo.LinkColor = System.Drawing.Color.Black;
            this.LinkLabelRepo.Location = new System.Drawing.Point(23, 9);
            this.LinkLabelRepo.Name = "LinkLabelRepo";
            this.LinkLabelRepo.Size = new System.Drawing.Size(310, 65);
            this.LinkLabelRepo.TabIndex = 11;
            this.LinkLabelRepo.TabStop = true;
            this.LinkLabelRepo.Text = "Auto-Clicker";
            this.LinkLabelRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelRepo_LinkClicked);
            // 
            // CreatorLinkLable
            // 
            this.CreatorLinkLable.AutoSize = true;
            this.CreatorLinkLable.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.CreatorLinkLable.LinkColor = System.Drawing.Color.Black;
            this.CreatorLinkLable.Location = new System.Drawing.Point(355, 21);
            this.CreatorLinkLable.Name = "CreatorLinkLable";
            this.CreatorLinkLable.Size = new System.Drawing.Size(181, 50);
            this.CreatorLinkLable.TabIndex = 12;
            this.CreatorLinkLable.TabStop = true;
            this.CreatorLinkLable.Text = "By Holan";
            this.CreatorLinkLable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LinkLabelGitHub
            // 
            this.LinkLabelGitHub.Image = ((System.Drawing.Image)(resources.GetObject("LinkLabelGitHub.Image")));
            this.LinkLabelGitHub.Location = new System.Drawing.Point(724, 334);
            this.LinkLabelGitHub.Name = "LinkLabelGitHub";
            this.LinkLabelGitHub.Size = new System.Drawing.Size(64, 64);
            this.LinkLabelGitHub.TabIndex = 13;
            this.LinkLabelGitHub.Click += new System.EventHandler(this.LinkLabelGitHub_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LinkLabelGitHub);
            this.Controls.Add(this.CreatorLinkLable);
            this.Controls.Add(this.LinkLabelRepo);
            this.Controls.Add(this.HintTextBox);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyWillPressTextBox);
            this.Controls.Add(this.KeyWillPressLabel);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.InfinityCheckBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.AmountClicksLablel);
            this.Controls.Add(this.DelayTextBox);
            this.Controls.Add(this.DelayLabel);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DelayLabel;
        private TextBox DelayTextBox;
        private Label AmountClicksLablel;
        private TextBox AmountTextBox;
        private CheckBox InfinityCheckBox;
        private Label KeyLabel;
        private TextBox KeyTextBox;
        private Label KeyWillPressLabel;
        private TextBox KeyWillPressTextBox;
        private Label label1;
        private StatusStrip StatusBar;
        private ToolStripStatusLabel StatusBarLabel;
        private TextBox HintTextBox;
        private LinkLabel LinkLabelRepo;
        private LinkLabel CreatorLinkLable;
        private Label LinkLabelGitHub;
    }
}