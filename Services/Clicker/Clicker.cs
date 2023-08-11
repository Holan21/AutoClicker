using AutoClicker.Extensions;
using WindowsInput;
using WindowsInput.Native;

namespace AutoClicker.Services.Clicker
{
    public class Clicker : IClicker
    {
        public void Click(int key)
        {
            InputSimulator input = new();

            if (IsKeyboardKey(key))
                input.Keyboard.KeyPress((VirtualKeyCode)key);
            else
                input.ClickByIntkey(key);

            Thread.Sleep(1);
        }

        private static bool IsKeyboardKey(int key)
        {
            return
                key != 0x00100000 &&
                key != 0x00200000 &&
                key != 0x00400000 &&
                key != 0x00800000 &&
                key != 0x01000000;
        }
    }
}
