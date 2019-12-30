using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twist.Entity;
using Twist.Entity.Enums;
using Twist.ORM;

namespace WindowsFormsApp1.Forms
{
    public partial class AddCableForm : Form
    {
        public AddCableForm()
        {
            InitializeComponent();
        }
       
       
        ProtocolInfo protocolInfo = new ProtocolInfo();
        ModbusORMBASE modbusORMBASE = new ModbusORMBASE();
     

        private void AddCableForm_Load(object sender, EventArgs e)
        {

        }
        private void btn_AddCable_Click(object sender, EventArgs e)
        {
            protocolInfo.comType = WriteOrRead.write;
            protocolInfo.requestDataType = RequestDataType.cables;
            WriteOrReadDataType allowProtocol = modbusORMBASE.DataExchangeProtocol(protocolInfo);
            if (allowProtocol == WriteOrReadDataType.writeableCables)
            {
                Cable cable = new Cable();
                cable.Name.Value = txt_CableName.Text;
                cable.Section.Value = txt_CableSection.Text;
                cable.OuterDiameter.Value = txt_OuterDiameter.Text;
                cable.Direction.Value = txt_Direction.Text;
                cable.Color.Value = txt_Color.Text;
                modbusORMBASE.SendData<Cable>(cable);
            }
        }
    }
}
