using AutoClicker.Enums;
using AutoClicker.Services.Clicker;
using Gma.System.MouseKeyHook;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace AutoClicker.Windows

{
    public partial class MainWindow : Form
    {
        private int keyStart = (int)KeysAndMouseButtons.Z;
        private int keyWillPress = (int)KeysAndMouseButtons.LBUTTON;
        private int amoutClicks = 100000;
        private int delayMs = 100;
        private bool infinnityClicks = true;
        private bool canStart = true;

        private bool _startClickerThread = false;
        private bool _aliveClickerThread = true;

        private readonly Thread _threadClicker;

        private readonly IClicker _clicker;
        private readonly IKeyboardMouseEvents _globalHook;
        public MainWindow(IClicker clicker)
        {
            InitializeComponent();

            _clicker = clicker;

            KeyTextBox.Text = ((KeysAndMouseButtons)keyStart).ToString();
            KeyWillPressTextBox.Text = ((KeysAndMouseButtons)keyWillPress).ToString();
            AmountTextBox.Text = amoutClicks.ToString();
            DelayTextBox.Text = delayMs.ToString();
            InfinityCheckBox.Checked = infinnityClicks;

            _globalHook = Hook.GlobalEvents();
            _globalHook.KeyDown += GlobalHook_KeyDown;
            _globalHook.MouseDown += GlobalHook_MouseDown;

            _threadClicker = new Thread(() =>
            {
                while (_aliveClickerThread)
                {
                    for (int i = 0; _startClickerThread; i++)
                    {
                        if (i >= amoutClicks && !infinnityClicks)
                            _startClickerThread = false;

                        new Clicker().Click(ref keyWillPress);
                        Thread.Sleep(delayMs);
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
                && canStart)
                ChangeStatusClicker();
        }
        private void GlobalHook_MouseDown(object? sender, MouseEventArgs e)
        {
            if ((int)e.Button == keyStart
                && !KeyTextBox.Focused
                && !KeyWillPressTextBox.Focused
                && canStart
                )
                ChangeStatusClicker();
        }

        private void ChangeStatusClicker()
        {
            if (keyStart == keyWillPress)
            {
                canStart = false;
                MessageBox.Show("Key for start can't be equel to key will press.", "Exception");
                KeyTextBox.Text = "Z";
                KeyWillPressTextBox.Text = "LBUTTON";
                keyStart = (int)KeysAndMouseButtons.Z;
                keyWillPress = (int)KeysAndMouseButtons.LBUTTON;
                return;
            }

            _startClickerThread = !_startClickerThread;

            Process pr = Process.GetCurrentProcess();

            if (Focused && _startClickerThread)
            {
                this.Enabled = false;
                TurnOffElement();
                SetForegroundWindow(pr.MainWindowHandle);
            }
            else if (!Focused && !_startClickerThread)
            {
                this.Enabled = true;
                SetForegroundWindow(pr.MainWindowHandle);
                TurnOnElement();
            }
        }
        private void TurnOffElement()
        {
            AmountTextBox.Enabled = false;
            KeyTextBox.Enabled = false;
            KeyWillPressTextBox.Enabled = false;
            DelayTextBox.Enabled = false;
            InfinityCheckBox.Enabled = false;
        }

        private void TurnOnElement()
        {
            AmountTextBox.Enabled = !infinnityClicks;
            KeyTextBox.Enabled = true;
            KeyWillPressTextBox.Enabled = true;
            DelayTextBox.Enabled = true;
            InfinityCheckBox.Enabled = true;
        }
        private void KeyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            KeyTextBox.Text = ((KeysAndMouseButtons)e.KeyCode).ToString();
            keyStart = (int)e.KeyValue;

        }
        private void KeyTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            KeyTextBox.Text = ((KeysAndMouseButtons)e.Button).ToString();
            keyStart = (int)e.Button;
        }

        private void KeyWillBePressTextBox_KeyUp(object sender, KeyEventArgs e)
        {

            KeyWillPressTextBox.Text = ((KeysAndMouseButtons)e.KeyCode).ToString();
            keyWillPress = (int)e.KeyValue;

        }
        private void KeyWillBePressTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            KeyWillPressTextBox.Text = ((KeysAndMouseButtons)e.Button).ToString();
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
                infinnityClicks = true;
            }
            else
            {
                AmountTextBox.Enabled = true;
                infinnityClicks = false;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _aliveClickerThread = false;
            _startClickerThread = false;
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            amoutClicks = int.Parse(AmountTextBox.Text);
        }

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr hWnd);
    }
}