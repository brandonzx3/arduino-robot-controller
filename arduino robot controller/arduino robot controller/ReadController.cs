using System;
using System.Collections.Generic;
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
        public int x;
        public bool a;

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
            x = state.Gamepad.LeftThumbX;
            a = state.Gamepad.Buttons.HasFlag(GamepadButtonFlags.A);
        }
    }
}
