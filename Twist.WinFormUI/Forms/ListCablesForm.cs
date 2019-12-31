using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Twist.Entity;
using Twist.Entity.Enums;
using Twist.ORM;


namespace WindowsFormsApp1.Forms
{
    public partial class ListCablesForm : Form
    {
        public ListCablesForm()
        {
            InitializeComponent();
        }

        ModbusORMBASE modbusORMBASE = new ModbusORMBASE();
        ProtocolInfo protocolInfo = new ProtocolInfo();
        Dictionary<int, Cable> dataCollection;
        private void ListCablesForm_Load(object sender, EventArgs e)
        {
            ListCables();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            lV_Cables.Items.Clear();
            lV_Cables.Refresh();
            ListCables();
            
        }

        private void ListCables()
        {
            protocolInfo.comType = WriteOrRead.read;
            protocolInfo.requestDataType = RequestDataType.cables;
            WriteOrReadDataType allowProtocol = modbusORMBASE.DataExchangeProtocol(protocolInfo);
            ListData listData = new ListData();

            if (allowProtocol == WriteOrReadDataType.readableCables)
            {
                Cable cable = new Cable();
               
                lV_Cables= listData.List<Cable>(lV_Cables);
               
            }
        }

        private void btn_AddCable_Click(object sender, EventArgs e)
        {
            AddCableForm addCable = new AddCableForm();
            addCable.ShowDialog();
        }
    }
}
