using System.Collections;
using SharpDX;
using SharpDX.XInput;
namespace arduino_robot_controller
{
    public partial class Form1 : Form
    {
        private ReadController controller = new ReadController();
        private bool enabled = false;
        bool[] buttons;
        short[] axies;

        public Form1()
        {
            controller.Start();
            InitializeComponent();
            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1;   // milliseconds
            tmr.Tick += Tmr_Tick;  // set handler
            tmr.Start();
            EnabledText.Text = "Disabled";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttons = controller.GetButtons();
            axies = controller.GetAxies();
            for (int i = 0; i < buttons.Length; i++)
            {
                buttonDisplay.Items.Add(new CheckBox().Text = i.ToString());
            }
            buttonDisplay.Height = (buttonDisplay.Items.Count + 1) * buttonDisplay.ItemHeight;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            buttons = controller.GetButtons();
            axies = controller.GetAxies();
            Console.WriteLine(axies[0]);

            if(controller.isConnected())
            {
                controllerConnected.Text = "Controller Connected";
            } else
            {
                controllerConnected.Text = "Controller Disconnected";
            }

            for (int i = 0; i < buttons.Length; i++)
            {
                buttonDisplay.SetItemChecked(i, buttons[i]);
            }

            if(enabled == true)
            {
                EnabledText.Text = "Enabled";
            }
            else
            {
                EnabledText.Text = "Disabled";
            }

            if (enabled) { SendData(); }
        }

        private void SendData()
        {
            switch(connectionMode.SelectedIndex)
            {
                case 1:
                    {
                        //serial

                        break;
                    }
            }
        }

        private void EnableButton_Click(object sender, EventArgs e)
        {
            if(connectionMode.SelectedIndex >= 0)
            {
                enabled = true;
            } else
            {
                enabled = false;
            }
        }

        private void DisableButton_Click(object sender, EventArgs e)
        {
            enabled = false;
        }

        private void connectionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            enabled = false;
            switch (connectionMode.SelectedIndex)
            {
                default:
                    {
                        //no state selected
                        break;
                    }
            }
        }
    }
}