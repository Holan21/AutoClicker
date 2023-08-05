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
            this.DelayLabel = new System.Windows.Forms.Label();
            this.DelayTextBox = new System.Windows.Forms.TextBox();
            this.AmountClicksLablel = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.InfinityCheckBox = new System.Windows.Forms.CheckBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.KeyWillPressLabel = new System.Windows.Forms.Label();
            this.KeyWillPressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DelayLabel
            // 
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.Location = new System.Drawing.Point(12, 34);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(39, 15);
            this.DelayLabel.TabIndex = 0;
            this.DelayLabel.Text = "Delay:";
            this.DelayLabel.UseWaitCursor = true;
            // 
            // DelayTextBox
            // 
            this.DelayTextBox.Location = new System.Drawing.Point(119, 31);
            this.DelayTextBox.Name = "DelayTextBox";
            this.DelayTextBox.PlaceholderText = "ms";
            this.DelayTextBox.Size = new System.Drawing.Size(100, 23);
            this.DelayTextBox.TabIndex = 1;
            this.DelayTextBox.UseWaitCursor = true;
            // 
            // AmountClicksLablel
            // 
            this.AmountClicksLablel.AutoSize = true;
            this.AmountClicksLablel.Location = new System.Drawing.Point(12, 9);
            this.AmountClicksLablel.Name = "AmountClicksLablel";
            this.AmountClicksLablel.Size = new System.Drawing.Size(86, 15);
            this.AmountClicksLablel.TabIndex = 2;
            this.AmountClicksLablel.Text = "Amount clicks:";
            this.AmountClicksLablel.UseWaitCursor = true;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(119, 6);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.AmountTextBox.TabIndex = 3;
            this.AmountTextBox.UseWaitCursor = true;
            // 
            // InfinityCheckBox
            // 
            this.InfinityCheckBox.AutoSize = true;
            this.InfinityCheckBox.Location = new System.Drawing.Point(225, 8);
            this.InfinityCheckBox.Name = "InfinityCheckBox";
            this.InfinityCheckBox.Size = new System.Drawing.Size(63, 19);
            this.InfinityCheckBox.TabIndex = 4;
            this.InfinityCheckBox.Text = "Infinity";
            this.InfinityCheckBox.UseVisualStyleBackColor = true;
            this.InfinityCheckBox.UseWaitCursor = true;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(12, 58);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(78, 15);
            this.KeyLabel.TabIndex = 5;
            this.KeyLabel.Text = "Key(for start):";
            this.KeyLabel.UseWaitCursor = true;
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(119, 55);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(100, 23);
            this.KeyTextBox.TabIndex = 6;
            this.KeyTextBox.UseWaitCursor = true;
            // 
            // KeyWillPressLabel
            // 
            this.KeyWillPressLabel.AutoSize = true;
            this.KeyWillPressLabel.Location = new System.Drawing.Point(12, 83);
            this.KeyWillPressLabel.Name = "KeyWillPressLabel";
            this.KeyWillPressLabel.Size = new System.Drawing.Size(101, 15);
            this.KeyWillPressLabel.TabIndex = 7;
            this.KeyWillPressLabel.Text = "Key(will be press):";
            this.KeyWillPressLabel.UseWaitCursor = true;
            // 
            // KeyWillPressTextBox
            // 
            this.KeyWillPressTextBox.Location = new System.Drawing.Point(119, 80);
            this.KeyWillPressTextBox.Name = "KeyWillPressTextBox";
            this.KeyWillPressTextBox.Size = new System.Drawing.Size(100, 23);
            this.KeyWillPressTextBox.TabIndex = 8;
            this.KeyWillPressTextBox.UseWaitCursor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "Auto-Clicker";
            this.UseWaitCursor = true;
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
    }
}