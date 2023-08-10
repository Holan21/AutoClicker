using AutoClicker.Enums;
using AutoClicker.Models.Config;
using AutoClicker.Services.Clicker;
using AutoClicker.Services.ConfigController;
using Gma.System.MouseKeyHook;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace AutoClicker.Windows

{
    public partial class MainWindow : Form
    {
        private ConfigApp config = new();

        private bool canStart = true;
        private bool _startClickerThread = false;
        private bool _aliveClickerThread = true;

        private readonly Thread _threadClicker;

        private readonly IClicker _clicker;
        private readonly IKeyboardMouseEvents _globalHook;
        private readonly IConfigController _config;
        public MainWindow(IClicker clicker, IConfigController configController)
        {
            InitializeComponent();

            _clicker = clicker;
            _config = configController;

            config = _config.GetConfig();

            KeyTextBox.Text = ((KeysAndMouseButtons)config.keyStart).ToString();
            KeyWillPressTextBox.Text = ((KeysAndMouseButtons)config.keyWillPress).ToString();
            AmountTextBox.Text = config.amoutClicks.ToString();
            DelayTextBox.Text = config.delayMs.ToString();
            InfinityCheckBox.Checked = config.infinnityClicks;

            _globalHook = Hook.GlobalEvents();
            _globalHook.KeyDown += GlobalHook_KeyDown;
            _globalHook.MouseDown += GlobalHook_MouseDown;

            _threadClicker = new Thread(() =>
            {
                while (_aliveClickerThread)
                {
                    for (int i = 0; _startClickerThread; i++)
                    {
                        if (i >= config.amoutClicks && !config.infinnityClicks)
                            _startClickerThread = false;

                        new Clicker().Click(config.keyWillPress);
                        Thread.Sleep(config.delayMs);
                    }
                }
            });

            _threadClicker.Start();
        }

        private void GlobalHook_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyValue == config.keyStart
                && !KeyTextBox.Focused
                && !KeyWillPressTextBox.Focused
                && !AmountTextBox.Focused
                && !DelayTextBox.Focused
                && canStart)
                ChangeStatusClicker();
        }
        private void GlobalHook_MouseDown(object? sender, MouseEventArgs e)
        {
            if ((int)e.Button == config.keyStart
                && !KeyTextBox.Focused
                && !KeyWillPressTextBox.Focused
                && !AmountTextBox.Focused
                && !DelayTextBox.Focused
                && canStart)
                ChangeStatusClicker();
        }

        private void ChangeStatusClicker()
        {
            if (config.keyStart == config.keyWillPress)
            {
                canStart = false;
                MessageBox.Show("Key for start can't be equel to key will press.", "Exception");

                KeyTextBox.Text = "Z";
                KeyWillPressTextBox.Text = "LBUTTON";

                config.keyStart = (int)KeysAndMouseButtons.Z;
                config.keyWillPress = (int)KeysAndMouseButtons.LBUTTON;
                return;
            }

            _startClickerThread = !_startClickerThread;

            Process pr = Process.GetCurrentProcess();
            if (Focused && _startClickerThread)
            {
                SetForegroundWindow(pr.MainWindowHandle);
                StatusBarLabel.Text = "Process is going";
            }
            else if (!Focused && !_startClickerThread)
                StatusBarLabel.Text = "Completed succesfully!";

        }

        private void KeyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            KeyTextBox.Text = ((KeysAndMouseButtons)e.KeyCode).ToString();
            config.keyStart = (int)e.KeyValue;

        }
        private void KeyTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            KeyTextBox.Text = ((KeysAndMouseButtons)e.Button).ToString();
            config.keyStart = (int)e.Button;
        }

        private void KeyWillBePressTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            KeyWillPressTextBox.Text = ((KeysAndMouseButtons)e.KeyCode).ToString();
            config.keyWillPress = (int)e.KeyValue;

        }
        private void KeyWillBePressTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            KeyWillPressTextBox.Text = ((KeysAndMouseButtons)e.Button).ToString();
            config.keyWillPress = (int)e.Button;
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
                config.infinnityClicks = true;
            }
            else
            {
                AmountTextBox.Enabled = true;
                config.infinnityClicks = false;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _config.SetConfig(config);
            _aliveClickerThread = false;
            _startClickerThread = false;
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            config.amoutClicks = int.Parse(AmountTextBox.Text);
        }

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr hWnd);

    }
}