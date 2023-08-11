using Arphox.MouseManipulator;
using AutoClicker.Enums;
using WindowsInput;

namespace AutoClicker.Extensions
{
    public static class InputSimulatorExtension
    {
        public static void ClickByIntkey(this InputSimulator simulator, int key)
        {
            switch (key)
            {
                case (int)KeysAndMouseButtons.LBUTTON:
                    MouseManipulator.LeftClick();
                    break;
                case (int)KeysAndMouseButtons.RBUTTON:
                    MouseManipulator.RightClick();
                    break;
                case (int)KeysAndMouseButtons.Middle:
                    MouseManipulator.MiddleClick();
                    break;
                case (int)KeysAndMouseButtons.XButton1:
                    simulator.Mouse.XButtonClick(1);
                    break;
                case (int)KeysAndMouseButtons.XButton2:
                    simulator.Mouse.XButtonClick(2);
                    break;
                default:
                    throw new KeyNotFoundException("Can't find mouse key");
            }
        }
    }
}
