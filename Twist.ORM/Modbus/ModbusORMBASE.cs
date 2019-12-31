using EasyModbus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Twist.Entity;
using Twist.Entity.Enums;

namespace Twist.ORM
{
    public class ModbusORMBASE
    {

        public ModbusClient modbusClient = new ModbusClient() { IPAddress = "192.168.2.86", Port = 502 };

        public ModbusORMBASE()
        {
            try
            {
                modbusClient.Connect();
            }
            catch (Exception)
            {
            }
           

        }

        public WriteOrReadDataType DataExchangeProtocol(ProtocolInfo protocolInfo)
        {
            if (modbusClient.Connected) return WriteOrReadDataType.Non;
            int[] Values = new int[100];

            modbusClient.WriteSingleRegister((int)RegisterAdress.AccessSystem, (int)AccessSystem.talep); //sistem erişim talebi
            modbusClient.WriteSingleCoil(135, true);
            Thread.Sleep(250);
            Values = modbusClient.ReadHoldingRegisters((int)RegisterAdress.AccessSystem, 1);

            try
            {
                if (Values[0] == (int)AccessSystem.onay)
                {
                    

                    int[] reqData = new int[] { (int)RequestData.talep, (int)protocolInfo.requestDataType, (int)protocolInfo.comType, (int)DataExchangeStatus.musait, (int)DataExchangeStatus.musait, (int)DataExchangeStatus.musait };

                    modbusClient.WriteMultipleRegisters((int)RegisterAdress.RequestData, reqData); //veri talebi
                    modbusClient.WriteSingleCoil(135, true);
                    Thread.Sleep(200);
                    Values = modbusClient.ReadHoldingRegisters((int)RegisterAdress.RequestData, 4); //veri talebi durumu

                    if (Values[0] == (int)RequestData.onay)
                    {
                        if (Values[2] == (int)WriteOrRead.read)
                        {
                            if (Values[1] == (int)RequestDataType.users)
                            {
                                return WriteOrReadDataType.readableAccounts;
                            }
                            else if (Values[1] == (int)RequestDataType.products)
                            {

                                return WriteOrReadDataType.readableProducts;
                            }
                            else if (Values[1] == (int)RequestDataType.cables)
                            {

                                return WriteOrReadDataType.readableCables;
                            }
                        }
                        else if (Values[2] == (int)WriteOrRead.write)
                        {
                            if (Values[1] == (int)RequestDataType.users)
                            {

                                return WriteOrReadDataType.writeableAccounts;

                            }
                            else if (Values[1] == (int)RequestDataType.products)
                            {
                                return WriteOrReadDataType.writeableProducts;
                            }
                            else if (Values[1] == (int)RequestDataType.cables)
                            {

                                return WriteOrReadDataType.writeableCables;
                            }
                        }
                    }
                    else if (Values[0] == (int)RequestData.red)
                    {
                        return WriteOrReadDataType.Non;
                    }
                }
                else if (Values[0] == (int)AccessSystem.red)
                {
                    return WriteOrReadDataType.Non;
                }

                Thread.Sleep(250);
            }
            catch (Exception)
            {
                return WriteOrReadDataType.Non;
            }

            return WriteOrReadDataType.Non;
        }

        public bool SendData<T>(T data)
        {
            if (modbusClient.Connected) return false;
            PropertyInfo[] Properties = typeof(T).GetProperties();

            foreach (var prop in Properties)
            {

                Parameters parameters = (Parameters)(prop.GetValue(data));
                int StartingAdress = Convert.ToInt32(parameters.StartingAdress);

                byte[] byteArray = Encoding.ASCII.GetBytes(parameters.Value);
                int[] intArray = new int[byteArray.Length];

                for (int i = 0; i < byteArray.Length; i++) intArray[i] = (int)byteArray[i];

                modbusClient.WriteMultipleRegisters(StartingAdress, intArray);

            }

            return true;

        }

        public Dictionary<int, T> GetData<T>()
        {
            Dictionary<int, T> DataCollection = new Dictionary<int, T>();
            if (!modbusClient.Connected) return DataCollection = null;

            int[] veriDurumu = modbusClient.ReadHoldingRegisters((int)RegisterAdress.DataStatus, 1);
            if (veriDurumu[0] != (int)DataExchangeStatus.hazir)
            {
                DataCollection = null;
                return DataCollection;
            }

            int[] AccountCount = modbusClient.ReadHoldingRegisters((int)RegisterAdress.DataCount, 1);
            PropertyInfo[] Properties = typeof(T).GetProperties();
            string stringValue = string.Empty;
            int startingAdress = 0;

            for (int i = 0; i < AccountCount[0]; i++)
            {
                T data = Activator.CreateInstance<T>();

                foreach (var prop in Properties)
                {

                    Parameters parameters = (Parameters)(prop.GetValue(data));
                    int length = parameters.Length;
                    startingAdress += parameters.StartingAdress;


                    int[] registerValues = modbusClient.ReadHoldingRegisters(5000 + startingAdress, length);

                    if (parameters.ConvertToAsciiString)
                    {
                        stringValue = ModbusClient.ConvertRegistersToString(registerValues, 0, length);

                    }
                    else
                    {
                        stringValue = string.Join("", registerValues);
                    }

                    if (!prop.Equals(Properties.Last())) startingAdress -= parameters.StartingAdress;
                    else startingAdress++; //sonraki adrese geçmesi için

                    parameters.Value = stringValue;
                    

                }

                DataCollection.Add(i, data);
            }
            int[] alindi = { (int)DataExchangeStatus.alindi };
            modbusClient.WriteMultipleRegisters((int)RegisterAdress.DataStatus, alindi);
            return DataCollection;
        }

    }
}

