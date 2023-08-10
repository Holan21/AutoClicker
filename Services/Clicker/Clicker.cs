using Arphox.MouseManipulator;
using WindowsInput;
using WindowsInput.Native;

namespace AutoClicker.Services.Clicker
{
    public class Clicker : IClicker
    {
        public void Click(ref int key)
        {
            InputSimulator input = new();

            if (IsKeyboardKey(key))
            {
                input.Keyboard.KeyPress((VirtualKeyCode)key);
            }
            if ((int)MouseButtons.Right == key)
            {
                MouseManipulator.RightClick();
            }
            else if ((int)MouseButtons.Left == key)
            {
                MouseManipulator.LeftClick();
            }
            else if ((int)MouseButtons.Middle == key)
            {
                MouseManipulator.MiddleClick();
            }
            else if ((int)MouseButtons.XButton1 == key)
            {
                input.Mouse.XButtonClick(1);
            }
            else if ((int)MouseButtons.XButton1 == key)
            {
                input.Mouse.XButtonClick(2);
            }

            Thread.Sleep(10);
        }


        private static bool IsKeyboardKey(int key)
        {
            if (key != 0x00100000 &&
                key != 0x00200000 &&
                key != 0x00400000 &&
                key != 0x00800000 &&
                key != 0x01000000)
                return true;
            else
                return false;
        }
    }
}
