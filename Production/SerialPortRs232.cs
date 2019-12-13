using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Production.LoadingUnit
{
    public class SerialPortRS232: SerialPort
    {
        //Constructor
        public SerialPortRS232(String[] strSerialPortSettingsArg)
        {
            this.BaudRate = int.Parse(strSerialPortSettingsArg[0]);
            this.DataBits = int.Parse(strSerialPortSettingsArg[1]);
            this.PortName = strSerialPortSettingsArg[2];
            this.NewLine = strSerialPortSettingsArg[3];
            this.Parity = (Parity)int.Parse(strSerialPortSettingsArg[4]);
            this.StopBits = (StopBits)int.Parse(strSerialPortSettingsArg[5]);
        }
    }
}
