using Gma.System.MouseKeyHook;
using System.Diagnostics;
using System.Text.RegularExpressions;
using WindowsInput.Native;
namespace AutoClicker.Windows

{
    public partial class MainWindow : Form
    {
        private int _keyStart = (int)VirtualKeyCode.VK_Z;
        private int _keyWillPress = (int)VirtualKeyCode.LBUTTON;

        private readonly IKeyboardMouseEvents m_GlobalHook;
        public MainWindow()
        {
            InitializeComponent();

            m_GlobalHook = Hook.GlobalEvents();

            m_GlobalHook.KeyDown += M_GlobalHook_KeyDown;
            m_GlobalHook.MouseDown += M_GlobalHook_MouseDown;
        }

        private void M_GlobalHook_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyValue == _keyStart)
                DoStart();
        }
        private void M_GlobalHook_MouseDown(object? sender, MouseEventArgs e)
        {
            if ((int)e.Button == _keyStart)
                DoStart();
        }

        private void DoStart()
        {
            Debug.WriteLine("Start");
        }

        private void KeyUp(object sender, KeyEventArgs e)
        {
            ((TextBox)sender).Text = e.KeyCode.ToString();
            _keyStart = (int)e.KeyValue;
        }
        private void MouseUp(object sender, MouseEventArgs e)
        {
            KeyTextBox.Text = e.Button.ToString();
            _keyStart = (int)e.Button;
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