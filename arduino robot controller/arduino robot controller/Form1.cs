using System.Collections;
using SharpDX;
using SharpDX.XInput;
namespace arduino_robot_controller
{
    public partial class Form1 : Form
    {
        private ReadController controller = new ReadController();
        private SerialData serialData = new SerialData();
        private bool enabled = false;
        bool[] buttons;
        short[] axies;
        String[] ports;
        String[] oldPortList;

        public Form1()
        {
            controller.Start();
            InitializeComponent();
            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1;
            tmr.Tick += Update;
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

            ports = serialData.GetPorts();
            foreach (String port in ports)
            {
                comPorts.Items.Add(port);
            }
            oldPortList = ports;
        }

        private void Update(object sender, EventArgs e)
        {
            buttons = controller.GetButtons();
            axies = controller.GetAxies();

            Console.WriteLine(axies[0]);

              ////////////////
             //Serial Logic//
            ////////////////
            ports = serialData.GetPorts();
            if (oldPortList != ports)
            {
                //new port added
                foreach (String port in ports)
                {
                    comPorts.Items.Add(port);
                }
                oldPortList = ports;
            }

              ////////////////////
             //Controller Logic//
            ////////////////////
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



            SendData();
        }

        private void SendData()
        {
            switch(connectionMode.SelectedItem)
            {
                case "Serial":
                    {
                        serialData.SendData(axies, buttons, enabled);
                        break;
                    }
            }
        }

        private void EnableButton_Click(object sender, EventArgs e)
        {
            switch(connectionMode.SelectedItem)
            {
                default:
                    {
                        enabled = false;
                        break;
                    }

                case "Serial":
                    {
                        if(ports.Length > 0 && comPorts.SelectedIndex > 0)
                        {
                            enabled = true;
                        } else enabled = false;
                        break;
                    }

                case "Wifi":
                    {
                        enabled = true;
                        break;
                    }

                case "Bluetooth":
                    {
                        enabled = true;
                        break;
                    }
            }
        }

        private void DisableButton_Click(object sender, EventArgs e)
        {
            enabled = false;
        }

        private void connectionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            enabled = false;
            switch (connectionMode.SelectedItem.ToString())
            {
                default:
                    {
                        SerialSettings.Visible = false;
                        break;
                    }
                case "Serial":
                    {
                        SerialSettings.Visible = true;
                        break;
                    }
                case "Wifi":
                    {
                        SerialSettings.Visible = false;
                        break;
                    }
                case "Bluetooth":
                    {
                        SerialSettings.Visible = false;
                        break;
                    }
            }
        }

        //change com port name
        private void comPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comPorts.SelectedItem != null)
            {
                serialData.SetPort(comPorts.SelectedItem.ToString(), 9200);
            }
            enabled = false;
        }
    }
}