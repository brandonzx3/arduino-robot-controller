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
            if(ports.Length > 0 && ports[0] != null)
            {
                port = new SerialPort(ports[0], 28800);
            }
        }

        public void SendData(short[] axies, bool[] buttons, bool enabled)
        {
            string data = enabled ? "enabled," : "disabled,";
            foreach(short s in axies) { data += s.ToString() + ","; }
            foreach(bool b in buttons) { data += b.ToString() + ","; }
            if(port != null)
            {
                port.Open();
                port.Write(data);
                port.Close();
            }
        }

        public void SetPort(string name, int baudrate)
        {
            if(name != null)
            {
                port = new SerialPort(name, baudrate);
            } else
            {
                port = null;
            }
        }

        public string[] GetPorts() { return SerialPort.GetPortNames(); }
    }
}
