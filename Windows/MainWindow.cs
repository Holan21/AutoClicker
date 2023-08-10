using AutoClicker.Services.Clicker;
using Gma.System.MouseKeyHook;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using WindowsInput.Native;
namespace AutoClicker.Windows

{
    public partial class MainWindow : Form
    {
        private int _keyStart = (int)VirtualKeyCode.VK_Z;
        private int _keyWillPress = (int)MouseButtons.Left;
        private bool start = false;
        private bool infinnity = true;
        private int _amoutClicks = 100000;

        private Thread thread;

        private readonly IClicker _clicker;
        private readonly IKeyboardMouseEvents m_GlobalHook;
        public MainWindow(IClicker clicker)
        {
            InitializeComponent();
            _clicker = clicker;

            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyDown += M_GlobalHook_KeyDown;
            m_GlobalHook.MouseDown += M_GlobalHook_MouseDown;

            thread = new Thread(() =>
            {
                while (true)
                {
                    for (int i = 0; start && i != _amoutClicks; i++)
                    {
                        if (_amoutClicks >= 0 && !infinnity)
                            break;

                        new Clicker().Click(ref _keyWillPress);
                        _amoutClicks--;

                    }
                }
            });
            thread.Start();
        }

        private void M_GlobalHook_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyValue == _keyStart
                && !KeyTextBox.Focused
                && !KeyWillPressTextBox.Focused
                && !AmountTextBox.Focused
                && !DelayTextBox.Focused
                && !InfinityCheckBox.Focused)
                Start();
        }
        private void M_GlobalHook_MouseDown(object? sender, MouseEventArgs e)
        {
            if ((int)e.Button == _keyStart
                && !KeyTextBox.Focused
                && !KeyWillPressTextBox.Focused
                && !AmountTextBox.Focused
                && !DelayTextBox.Focused
                && !InfinityCheckBox.Focused)
                Start();
        }

        private void Start()
        {
            start = !start;
            Process pr = Process.GetCurrentProcess();
            var pointer = pr.MainWindowHandle;
            if (Focused && start || !Focused && !start)
                SetForegroundWindow(pointer);
        }

        private void KeyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            KeyTextBox.Text = e.KeyCode.ToString();
            _keyStart = (int)e.KeyValue;
        }
        private void KeyTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            KeyTextBox.Text = e.Button.ToString();
            _keyStart = (int)e.Button;
        }

        private void KeyWillBePressTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            KeyWillPressTextBox.Text = e.KeyCode.ToString();
            _keyWillPress = (int)e.KeyValue;
        }
        private void KeyWillBePressTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            KeyWillPressTextBox.Text = e.Button.ToString();
            _keyWillPress = (int)e.Button;
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

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    }
}