using AutoClicker.Enums;
using AutoClicker.Models.Config;
using AutoClicker.Services.Clicker;
using AutoClicker.Services.ConfigController;
using Gma.System.MouseKeyHook;
using System.Diagnostics;
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

            KeyTextBox.Text = ((KeysAndMouseButtons)config.KeyStart).ToString();
            KeyWillPressTextBox.Text = ((KeysAndMouseButtons)config.KeyWillPress).ToString();
            AmountTextBox.Text = config.AmoutClicks.ToString();
            DelayTextBox.Text = config.DelayMs.ToString();
            InfinityCheckBox.Checked = config.InfinnityClicks;

            _globalHook = Hook.GlobalEvents();
            _globalHook.KeyDown += GlobalHook_KeyDown;
            _globalHook.MouseDown += GlobalHook_MouseDown;

            _threadClicker = new Thread(() =>
            {
                while (_aliveClickerThread)
                {
                    for (int i = 0; _startClickerThread; i++)
                    {
                        if (i >= config.AmoutClicks && !config.InfinnityClicks)
                            _startClickerThread = false;

                        new Clicker().Click(config.KeyWillPress);
                        Thread.Sleep(config.DelayMs);
                    }
                }
            });

            _threadClicker.Start();
        }

        private void GlobalHook_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyValue == config.KeyStart && AllTextBoxHaventFocus() && canStart)
                ChangeStatusClicker();
        }
        private void GlobalHook_MouseDown(object? sender, MouseEventArgs e)
        {
            if ((int)e.Button == config.KeyStart && AllTextBoxHaventFocus() && canStart)
                ChangeStatusClicker();
        }
        private bool AllTextBoxHaventFocus()
        {
            return !KeyTextBox.Focused
                && !KeyWillPressTextBox.Focused
                && !AmountTextBox.Focused
                && !DelayTextBox.Focused
                && !HintTextBox.Focused;
        }
        private void ChangeStatusClicker()
        {
            if (config.KeyStart == config.KeyWillPress)
            {
                canStart = false;
                MessageBox.Show("Key for start can't be equel to key will press.", "Exception");

                ToDefualtButtonsBind();

                canStart = true;
            }
            else
            {
                _startClickerThread = !_startClickerThread;

                if (_startClickerThread)
                    StatusBarLabel.Text = "Process is going...";
                else
                    StatusBarLabel.Text = "Completed succesfully!";
            }
        }

        private void ToDefualtButtonsBind()
        {
            ConfigApp configApp = new();
            KeyTextBox.Text = ((KeysAndMouseButtons)configApp.KeyStart).ToString();
            KeyWillPressTextBox.Text = ((KeysAndMouseButtons)configApp.KeyWillPress).ToString(); ;

            config.KeyStart = configApp.KeyStart;
            config.KeyWillPress = configApp.KeyWillPress;
        }

        private void KeyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            KeyTextBox.Text = ((KeysAndMouseButtons)e.KeyCode).ToString();
            config.KeyStart = (int)e.KeyValue;

        }
        private void KeyTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            KeyTextBox.Text = ((KeysAndMouseButtons)e.Button).ToString();
            config.KeyStart = (int)e.Button;
        }

        private void KeyWillBePressTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            KeyWillPressTextBox.Text = ((KeysAndMouseButtons)e.KeyCode).ToString();
            config.KeyWillPress = (int)e.KeyValue;

        }
        private void KeyWillBePressTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            KeyWillPressTextBox.Text = ((KeysAndMouseButtons)e.Button).ToString();
            config.KeyWillPress = (int)e.Button;
        }

        private void SelectAllTextBox(object sender, EventArgs e)
           => ((TextBox)sender).SelectAll();


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
            AmountTextBox.Enabled = !InfinityCheckBox.Checked;
            config.InfinnityClicks = InfinityCheckBox.Checked;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _config.SetConfig(config);
            _aliveClickerThread = false;
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
            => config.AmoutClicks = int.Parse(AmountTextBox.Text);

        private void linkCreator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start(new ProcessStartInfo(config.LinkCreator) { UseShellExecute = true });

        private void LinkLabelGitHub_Click(object sender, EventArgs e)
            => Process.Start(new ProcessStartInfo(config.LinkRepo) { UseShellExecute = true });

        private void MainWindow_Click(object sender, EventArgs e)
            => ActiveControl = null;

        private void GitHub_Click(object sender, EventArgs e) => Process.Start(new ProcessStartInfo(config.LinkRepo) { UseShellExecute = true });
    }
}