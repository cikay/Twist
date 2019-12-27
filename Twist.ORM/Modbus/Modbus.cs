using EasyModbus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EasyModbus.ModbusClient;

namespace Twist.ORM
{
    public class Modbus
    {


        public ModbusClient modbusClient = new ModbusClient() { IPAddress = "192.168.2.86", Port = 502 };

        public Modbus()
        {
            try
            {
                modbusClient.Connect();
            }
            catch (Exception)
            {
                
            }
        }

    }
}
