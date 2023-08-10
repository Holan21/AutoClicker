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
        private int keyStart = (int)VirtualKeyCode.VK_Z;
        private int keyWillPress = (int)MouseButtons.Left;
        private int amoutClicks = 100000;
        private int delay = 100; // in ms
        private bool _infinnityClicks = true;


        private bool _startClickerThread = false;
        private bool _aliveClickerThread = true;

        private readonly Thread _threadClicker;

        private readonly IClicker _clicker;
        private readonly IKeyboardMouseEvents _globalHook;
        public MainWindow(IClicker clicker)
        {
            InitializeComponent();

            _clicker = clicker;

            KeyTextBox.Text = keyStart.ToString();
            KeyWillPressTextBox.Text = keyWillPress.ToString();
            AmountTextBox.Text = amoutClicks.ToString();
            DelayTextBox.Text = delay.ToString();
            InfinityCheckBox.Checked = _infinnityClicks;

            _globalHook = Hook.GlobalEvents();
            _globalHook.KeyDown += GlobalHook_KeyDown;
            _globalHook.MouseDown += GlobalHook_MouseDown;

            _threadClicker = new Thread(() =>
            {
                while (_aliveClickerThread)
                {
                    for (int i = 0; _startClickerThread && i != amoutClicks; i++)
                    {
                        if (amoutClicks >= 0 && !_infinnityClicks)
                            break;

                        new Clicker().Click(ref keyWillPress);
                        Thread.Sleep(delay);
                    }
                }
            });
            _threadClicker.Start();
        }

        private void GlobalHook_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyValue == keyStart
                && !KeyTextBox.Focused
                && !KeyWillPressTextBox.Focused
                && !AmountTextBox.Focused
                && !DelayTextBox.Focused
                && !InfinityCheckBox.Focused)
                ChangeStatusClicker();
        }
        private void GlobalHook_MouseDown(object? sender, MouseEventArgs e)
        {
            if ((int)e.Button == keyStart
                && !KeyTextBox.Focused
                && !KeyWillPressTextBox.Focused
                && !AmountTextBox.Focused
                && !DelayTextBox.Focused
                && !InfinityCheckBox.Focused)
                ChangeStatusClicker();
        }

        private void ChangeStatusClicker()
        {
            _startClickerThread = !_startClickerThread;
            Process pr = Process.GetCurrentProcess();
            var pointer = pr.MainWindowHandle;
            if (Focused && _startClickerThread || !Focused && !_startClickerThread)
                SetForegroundWindow(pointer);
        }

        private void KeyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            KeyTextBox.Text = e.KeyCode.ToString();
            keyStart = (int)e.KeyValue;
        }
        private void KeyTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            KeyTextBox.Text = e.Button.ToString();
            keyStart = (int)e.Button;
        }

        private void KeyWillBePressTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            KeyWillPressTextBox.Text = e.KeyCode.ToString();
            keyWillPress = (int)e.KeyValue;
        }
        private void KeyWillBePressTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            KeyWillPressTextBox.Text = e.Button.ToString();
            keyWillPress = (int)e.Button;
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

        private void InfinityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (InfinityCheckBox.Checked)
            {
                AmountTextBox.Enabled = false;
            }
            else
            {
                AmountTextBox.Enabled = true;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _aliveClickerThread = false;
            _startClickerThread = false;
        }

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr hWnd);
    }
}