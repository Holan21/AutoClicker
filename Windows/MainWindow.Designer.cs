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
            this.DelayLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelayLabel.Location = new System.Drawing.Point(12, 45);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(63, 25);
            this.DelayLabel.TabIndex = 0;
            this.DelayLabel.Text = "Delay:";
            // 
            // DelayTextBox
            // 
            this.DelayTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelayTextBox.Location = new System.Drawing.Point(180, 42);
            this.DelayTextBox.Name = "DelayTextBox";
            this.DelayTextBox.PlaceholderText = "ms";
            this.DelayTextBox.Size = new System.Drawing.Size(100, 33);
            this.DelayTextBox.TabIndex = 3;
            this.DelayTextBox.TabStop = false;
            this.DelayTextBox.TextChanged += new System.EventHandler(this.OnlyNumber_TextChange);
            // 
            // AmountClicksLablel
            // 
            this.AmountClicksLablel.AutoSize = true;
            this.AmountClicksLablel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountClicksLablel.Location = new System.Drawing.Point(12, 9);
            this.AmountClicksLablel.Name = "AmountClicksLablel";
            this.AmountClicksLablel.Size = new System.Drawing.Size(133, 25);
            this.AmountClicksLablel.TabIndex = 2;
            this.AmountClicksLablel.Text = "Amount clicks:";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountTextBox.Location = new System.Drawing.Point(180, 3);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 33);
            this.AmountTextBox.TabIndex = 1;
            this.AmountTextBox.TabStop = false;
            this.AmountTextBox.TextChanged += new System.EventHandler(this.OnlyNumber_TextChange);
            // 
            // InfinityCheckBox
            // 
            this.InfinityCheckBox.AutoSize = true;
            this.InfinityCheckBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfinityCheckBox.Location = new System.Drawing.Point(286, 5);
            this.InfinityCheckBox.Name = "InfinityCheckBox";
            this.InfinityCheckBox.Size = new System.Drawing.Size(89, 29);
            this.InfinityCheckBox.TabIndex = 2;
            this.InfinityCheckBox.TabStop = false;
            this.InfinityCheckBox.Text = "Infinity";
            this.InfinityCheckBox.UseVisualStyleBackColor = true;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyLabel.Location = new System.Drawing.Point(12, 84);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(124, 25);
            this.KeyLabel.TabIndex = 5;
            this.KeyLabel.Text = "Key(for start):";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.KeyTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyTextBox.Location = new System.Drawing.Point(180, 81);
            this.KeyTextBox.MaxLength = 1;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(100, 33);
            this.KeyTextBox.TabIndex = 4;
            this.KeyTextBox.TabStop = false;
            this.KeyTextBox.Text = "Z";
            this.KeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyTextBox.Click += new System.EventHandler(this.SelectAllTextBox);
            this.KeyTextBox.TextChanged += new System.EventHandler(this.OnlyNumber_TextChange);
            this.KeyTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyTextBox_KeyUp);
            // 
            // KeyWillPressLabel
            // 
            this.KeyWillPressLabel.AutoSize = true;
            this.KeyWillPressLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyWillPressLabel.Location = new System.Drawing.Point(12, 123);
            this.KeyWillPressLabel.Name = "KeyWillPressLabel";
            this.KeyWillPressLabel.Size = new System.Drawing.Size(162, 25);
            this.KeyWillPressLabel.TabIndex = 7;
            this.KeyWillPressLabel.Text = "Key(will be press):";
            // 
            // KeyWillPressTextBox
            // 
            this.KeyWillPressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.KeyWillPressTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyWillPressTextBox.Location = new System.Drawing.Point(180, 120);
            this.KeyWillPressTextBox.MaxLength = 1;
            this.KeyWillPressTextBox.Name = "KeyWillPressTextBox";
            this.KeyWillPressTextBox.Size = new System.Drawing.Size(100, 33);
            this.KeyWillPressTextBox.TabIndex = 5;
            this.KeyWillPressTextBox.TabStop = false;
            this.KeyWillPressTextBox.Text = "E";
            this.KeyWillPressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyWillPressTextBox.Click += new System.EventHandler(this.SelectAllTextBox);
            this.KeyWillPressTextBox.TextChanged += new System.EventHandler(this.SelectAllTextBox);
            this.KeyWillPressTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyWillPressTextBox_KeyUp);
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