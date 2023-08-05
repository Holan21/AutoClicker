using System.Text.RegularExpressions;

namespace AutoClicker.Windows

{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Key_UpTextBox(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            ((TextBox)sender).Text = e.KeyCode.ToString();
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