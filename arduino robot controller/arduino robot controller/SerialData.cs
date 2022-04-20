using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace arduino_robot_controller
{
    public class SerialData
    {
        private SerialPort port;
        private String[] ports = SerialPort.GetPortNames();
        public SerialData()
        {
            if (ports[0] != null)
            {
                port = new SerialPort(ports[0], 9600);
            }
        }

        public void SetPort(string name, int baudrate)
        {
            port.BaudRate = baudrate;
            port.PortName = name;
        }

        public void SendData(short[] axies, bool[] buttons, bool enabled)
        {
            String data = "";
            if(enabled)
            {
                data = "enabled,";
            } else
            {
                data = "disabled,";
            }

            foreach(short i in axies)
            {
                data += i.ToString() + ",";
            }

            foreach(bool i in buttons)
            {
                data += i.ToString() + ",";
            }

            port.Open();
            port.WriteLine(data);
            port.Close();
        }

        public String[] GetPorts() { return ports; }
    }
}
