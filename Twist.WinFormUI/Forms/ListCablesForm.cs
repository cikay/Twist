using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Twist.Entity;
using Twist.Entity.Enums;
using Twist.ORM;
using Twist.WinFormUI.Classes;
using Twist.WinFormUI.Forms;

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

            IntPtr m = Application.OpenForms["TwistMainForm"].Handle;
            ComboBox comboBox_Languages = TwistMainForm.FromHandle(m).Controls.Find("combo_Languages", true).FirstOrDefault() as ComboBox;
            AddCableForm addCable = new AddCableForm();
            SetLanguage.SetChildFormLanguage(addCable, comboBox_Languages);
            addCable.ShowDialog();
        }
    }
}
