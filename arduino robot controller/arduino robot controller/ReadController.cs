using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.XInput;

namespace arduino_robot_controller
{
    public class ReadController
    {
        private Controller controller;
        private System.Threading.Timer timer;
        private int[] axies = new int[6];
        private bool[] buttons = new bool[14];

        public ReadController()
        {
            controller = new Controller(UserIndex.One);
            timer = new System.Threading.Timer(obj => Update());
        }

        public void Start()
        {
            timer.Change(0, 1000 / 60);
        }

        private void Update()
        {
            controller.GetState(out var state);

            //add axies to list
            axies[0] = (int)state.Gamepad.LeftThumbX;
            axies[1] = (int)state.Gamepad.LeftThumbY;
            axies[2] = (int)state.Gamepad.RightThumbX;
            axies[3] = (int)state.Gamepad.RightThumbY;
            axies[4] = (int)state.Gamepad.LeftTrigger;
            axies[5] = (int)state.Gamepad.RightTrigger;

            //add buttons to list
           buttons[0] = (bool)state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.A);
            buttons[1] = (bool)state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.B);
            buttons[2] = (bool)state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.X);
            buttons[3] = (bool)state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Y);
            buttons[4] = (bool)state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftShoulder);
            buttons[5] =(bool)state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.RightShoulder);
            buttons[6] =(bool)state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftThumb);
            buttons[7] =(bool)state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.RightThumb);
            buttons[8] =(bool)state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Start);
            buttons[9] =(bool)state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Back);
            buttons[10] = (bool)state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadUp);
            buttons[11] =(bool)state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadLeft);
            buttons[12] =(bool)state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadDown);
            buttons[13] = (bool)state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadRight);
        }

        public int[] GetAxies() { return axies; }
        public bool[] GetButtons() { return buttons; }
    }
}
