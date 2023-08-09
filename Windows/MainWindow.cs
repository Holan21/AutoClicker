using GlobalHandle;
using System.Diagnostics;
using System.Text.RegularExpressions;
using WindowsInput.Native;
namespace AutoClicker.Windows

{
    public partial class MainWindow : Form
    {
        private GlobalKeyboardHook _keyboardHandle;
        private VirtualKeyCode _keyStart = VirtualKeyCode.VK_Z;
        private VirtualKeyCode _keyWillPress = VirtualKeyCode.LBUTTON;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void KeyWillPressTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ((TextBox)sender).Text = e.KeyCode.ToString();
            _keyWillPress = (VirtualKeyCode)e.KeyValue;
        }

        private void KeyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ((TextBox)sender).Text = e.KeyCode.ToString();
            _keyStart = (VirtualKeyCode)e.KeyValue;
            GlobalKeyboardHook.PressedButton = e.KeyValue;
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

        private void MainWindow_Load(object sender, EventArgs e)
        {
            _keyboardHandle = new GlobalKeyboardHook();
            _keyboardHandle.KeyboardPressed += _keyboardHandle_KeyboardPressed;
        }

        private void _keyboardHandle_KeyboardPressed(object? sender, GlobalKeyboardHookEventArgs e)
        {
            if (e.KeyboardData.VirtualCode == GlobalKeyboardHook.PressedButton
                && e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown
                && KeyWillPressTextBox.Focused != true
                && KeyTextBox.Focused != true
                && DelayTextBox.Focused != true
                && AmountTextBox.Focused != true)
                Debug.WriteLine("Pressed " + (VirtualKeyCode)GlobalKeyboardHook.PressedButton);
        }
    }

}