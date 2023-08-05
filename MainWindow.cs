using AutoClicker.Services.KeySender;

namespace AutoClicker
{
    public partial class MainWindow : Form
    {
        private static Keys _keyForStart = Keys.Control;
        private static Keys _keyWillPress = Keys.Z;
        public MainWindow(IKeySender sender)
        {
            InitializeComponent();
        }

        private void KeyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            _keyForStart = e.KeyCode;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == _keyForStart)
                //START PROGRAM
                ;
        }
    }
}