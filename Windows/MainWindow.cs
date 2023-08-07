using System.Text.RegularExpressions;
using WindowsInput.Native;

namespace AutoClicker.Windows

{
    public partial class MainWindow : Form
    {
        private VirtualKeyCode _keyStart;
        private VirtualKeyCode _keyWillPress;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void KeyWillPressTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            ((TextBox)sender).Text = e.KeyCode.ToString();
            _keyWillPress = (VirtualKeyCode)e.KeyValue;
        }

        private void KeyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            ((TextBox)sender).Text = e.KeyCode.ToString();
            _keyStart = (VirtualKeyCode)e.KeyValue;
        }

        private void SelectAllTextBox(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void OnlyNumber_TextChange(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;

            if (Regex.IsMatch(box.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter only numbers.", "Exception");
                box.Clear();
            }
        }


    }
}