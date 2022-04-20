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
        private short[] axies = new short[6];
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
            axies[0] = state.Gamepad.LeftThumbX;
            axies[1] = state.Gamepad.LeftThumbY;
            axies[2] = state.Gamepad.RightThumbX;
            axies[3] = state.Gamepad.RightThumbY;
            axies[4] = state.Gamepad.LeftTrigger;
            axies[5] = state.Gamepad.RightTrigger;
            
            //add buttons to list
           buttons[0] = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.A);
            buttons[1] = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.B);
            buttons[2] = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.X);
            buttons[3] = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Y);
            buttons[4] = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftShoulder);
            buttons[5] = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.RightShoulder);
            buttons[6] = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.LeftThumb);
            buttons[7] = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.RightThumb);
            buttons[8] = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Start);
            buttons[9] = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.Back);
            buttons[10] = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadUp);
            buttons[11] = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadLeft);
            buttons[12] = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadDown);
            buttons[13] = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.DPadRight);
        }

        public short[] GetAxies() { return axies; }
        public bool[] GetButtons() { return buttons; }
        public bool isConnected() { return controller.IsConnected; }
    }
}